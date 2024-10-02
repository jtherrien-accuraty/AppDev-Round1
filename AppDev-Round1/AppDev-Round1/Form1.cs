using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using JSON_Deserializer_Class;
using System.IO;
using System.Text.Json;
using System.Collections;
using System.Linq;


namespace AppDev_Round1
{
    public partial class Form1 : Form
    {
        private string _fileContents = string.Empty;
        private List<DeserializerTemplate>? _json;
        private Dictionary<string, Dictionary<string, Training>> _processedTrainings;
        private List<string> _trainings;
        public Form1()
        {
            InitializeComponent();
            _processedTrainings = new Dictionary<string, Dictionary<string, Training>>();
            _trainings = new List<string>();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openJSONFile.ShowDialog() == DialogResult.OK)
            {
                initializeForm();
            }
        }
        /// <summary>
        /// Resets form and processes selected JSON file
        /// </summary>
        private void initializeForm()
        {
            if(!processJson())
            {
                return;
            }
            trainings.Items.Clear();
            trainings.Enabled = false;
            //jsonPreview.Text = string.Empty;
            outputPreview.Text = string.Empty;
            outputType.Text = string.Empty;
            outputType.Enabled = true;
            outputTypeLbl.Enabled = true;
            updateOutput.Enabled = false;
            saveJSON.Enabled = false;
            expiredTraining.Enabled = false;
            expiredTrainingLbl.Enabled = false;
            fiscalYear.Enabled = false;
            fiscalYearLbl.Enabled = false;
            updateTrainingList();
        }


        /// <summary>
        /// Deserializes select JSON file and sets JSON File Preview to file contents
        /// </summary>
        /// <returns>true if successfully process JSON, else false</returns>
        private bool processJson()
        {
            try
            {
                //open file and read contents
                _fileContents = File.ReadAllText(openJSONFile.FileName);
                jsonPreview.Text = _fileContents;

                //parse JSON
                _json = JsonSerializer.Deserialize<List<DeserializerTemplate>>(_fileContents);

                //convert deserialized json into a dictionary using user names as keys and eliminate duplicate trainings 
                _processedTrainings.Clear();
                foreach(var record in _json)
                {
                    if (!_processedTrainings.ContainsKey(record.name))
                    {
                        //User not added to dictionary yet, add them
                        _processedTrainings.Add(record.name, new Dictionary<string, Training>());
                    }
                    //Loop through each training and add if not yet in dictionary, and replace with most recent if so,
                    //  and add to _trainings.
                    foreach(var training in record.completions)
                    {
                        //dictionary processing
                        if (_processedTrainings[record.name].ContainsKey(training.name))
                        {
                            //Training already added, replace if current is more recent
                            if (DateTime.Parse(training.timestamp) > DateTime.Parse( _processedTrainings[record.name][training.name].timestamp) )
                            {
                                _processedTrainings[record.name][training.name] = training;
                            }
                        }
                        else
                        {
                            //New Training, add to dictionary
                            _processedTrainings[record.name].Add(training.name, training);
                        }
                        //_trainings processing
                        _trainings.Add(training.name);
                    }
                }
            }
            catch (Exception ex) 
            {
                jsonPreview.Text = $"Error Parsing JSON, please select file with valid JSON. Error: {ex}";
                return false;
            }
            return true;
        }

        private void updateTrainingList()
        {
            trainings.Items.Clear();
            var uniqueTrainings = _trainings
                .OrderBy(x => x)
                .Distinct()
            ;
            foreach( var training in uniqueTrainings )
            {
                trainings.Items.Add(training);
            }
            _trainings = uniqueTrainings.ToList();
        }

        private void openJSONFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveJSON_Click(object sender, EventArgs e)
        {
            if (saveJSONFile.ShowDialog() == DialogResult.OK)
            {
                SaveOutput();
            }
        }

        /// <summary>
        /// Saves the generated output to .Json file
        /// </summary>
        private void SaveOutput()
        {
            outputPreview.Text = "Save Output Clicked";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateOutput.Enabled = true;
            switch (outputType.SelectedItem)
            {
                case "Completed Trainings":
                    
                    CompletedTrainingsSelected();
                    break;
                case "Training Reports":
                    TrainingReportsSelected();
                    break;
                case "Expired Trainings":
                    ExpiredTrainingsSelected();
                    break;
                default:
                    updateOutput.Enabled = false;
                    break;
            }

        }

        private void CompletedTrainingsSelected()
        {
            trainings.Enabled = false;
            trainingsLbl.Enabled = false;
            fiscalYear.Enabled = false;
            fiscalYearLbl.Enabled = false;
            expiredTraining.Enabled = false;
            expiredTrainingLbl.Enabled = false;
        }

        private void TrainingReportsSelected()
        {
            trainings.Enabled = true;
            trainingsLbl.Enabled = true;
            fiscalYear.Enabled = true;
            fiscalYearLbl.Enabled = true;
            expiredTraining.Enabled = false;
            expiredTrainingLbl.Enabled = false;
        }

        private void ExpiredTrainingsSelected()
        {
            trainings.Enabled = false;
            trainingsLbl.Enabled = false;
            fiscalYear.Enabled = false;
            fiscalYearLbl.Enabled = false;
            expiredTraining.Enabled = true;
            expiredTrainingLbl.Enabled = true;
        }

        private void ProcessCompletedTrainings()
        {

            outputPreview.Text = "Process Completed Trainings Selected";
        }

        private void ProcessTrainingReports()
        {
            outputPreview.Text = "Process Training Reports Selected";
        }

        private void updateOutput_Click(object sender, EventArgs e)
        {
            switch (outputType.SelectedItem)
            {
                case "Completed Trainings":
                    ProcessCompletedTrainings();
                    break;
                case "Training Reports":
                    ProcessTrainingReports();
                    break;
                case "Expired Trainings":
                    ExpiredTrainingsSelected();
                    break;
                default:
                    updateOutput.Enabled = false;
                    return;
            }
            saveJSON.Enabled = true;
        }
    }
}
