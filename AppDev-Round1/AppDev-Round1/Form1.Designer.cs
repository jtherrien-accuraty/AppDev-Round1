namespace AppDev_Round1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            jsonPreview = new TextBox();
            openJSONFile = new OpenFileDialog();
            openFile = new Button();
            saveJSON = new Button();
            label1 = new Label();
            outputType = new ComboBox();
            label2 = new Label();
            outputPreview = new TextBox();
            outputTypeLbl = new Label();
            trainings = new CheckedListBox();
            trainingsLbl = new Label();
            expiredTraining = new DateTimePicker();
            expiredTrainingLbl = new Label();
            fiscalYear = new ComboBox();
            fiscalYearLbl = new Label();
            saveJSONFile = new SaveFileDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // jsonPreview
            // 
            jsonPreview.Location = new Point(927, 112);
            jsonPreview.Multiline = true;
            jsonPreview.Name = "jsonPreview";
            jsonPreview.ReadOnly = true;
            jsonPreview.ScrollBars = ScrollBars.Both;
            jsonPreview.Size = new Size(580, 327);
            jsonPreview.TabIndex = 0;
            // 
            // openJSONFile
            // 
            openJSONFile.FileName = "Path\\To\\JSON.txt";
            openJSONFile.Filter = "JSON TXT|*.txt,*.json,*.Json";
            openJSONFile.InitialDirectory = "C:\\";
            openJSONFile.FileOk += openJSONFile_FileOk;
            // 
            // openFile
            // 
            openFile.Location = new Point(34, 53);
            openFile.Name = "openFile";
            openFile.Size = new Size(351, 58);
            openFile.TabIndex = 1;
            openFile.Text = "Open JSON TXT File";
            openFile.UseVisualStyleBackColor = true;
            openFile.Click += openFile_Click;
            // 
            // saveJSON
            // 
            saveJSON.Enabled = false;
            saveJSON.Location = new Point(34, 230);
            saveJSON.Name = "saveJSON";
            saveJSON.Size = new Size(351, 58);
            saveJSON.TabIndex = 2;
            saveJSON.Text = "Save Output";
            saveJSON.UseVisualStyleBackColor = true;
            saveJSON.Click += saveJSON_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(927, 44);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 3;
            label1.Text = "JSON File Preview";
            // 
            // outputType
            // 
            outputType.Enabled = false;
            outputType.Items.AddRange(new object[] { "Completed Trainings", "Training Reports", "Expired Trainings" });
            outputType.Location = new Point(117, 524);
            outputType.Name = "outputType";
            outputType.Size = new Size(302, 49);
            outputType.TabIndex = 0;
            outputType.SelectedIndexChanged += outputType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(927, 475);
            label2.Name = "label2";
            label2.Size = new Size(223, 41);
            label2.TabIndex = 5;
            label2.Text = "Output Preview";
            // 
            // outputPreview
            // 
            outputPreview.Location = new Point(927, 543);
            outputPreview.Multiline = true;
            outputPreview.Name = "outputPreview";
            outputPreview.ReadOnly = true;
            outputPreview.ScrollBars = ScrollBars.Both;
            outputPreview.Size = new Size(580, 327);
            outputPreview.TabIndex = 4;
            outputPreview.TextChanged += textBox1_TextChanged;
            // 
            // outputTypeLbl
            // 
            outputTypeLbl.AutoSize = true;
            outputTypeLbl.Enabled = false;
            outputTypeLbl.Location = new Point(117, 465);
            outputTypeLbl.Name = "outputTypeLbl";
            outputTypeLbl.Size = new Size(293, 41);
            outputTypeLbl.TabIndex = 6;
            outputTypeLbl.Text = "Choose Output Type";
            // 
            // trainings
            // 
            trainings.Enabled = false;
            trainings.FormattingEnabled = true;
            trainings.Location = new Point(535, 112);
            trainings.Name = "trainings";
            trainings.Size = new Size(351, 752);
            trainings.TabIndex = 7;
            // 
            // trainingsLbl
            // 
            trainingsLbl.AutoSize = true;
            trainingsLbl.Enabled = false;
            trainingsLbl.Location = new Point(535, 53);
            trainingsLbl.Name = "trainingsLbl";
            trainingsLbl.Size = new Size(260, 41);
            trainingsLbl.TabIndex = 8;
            trainingsLbl.Text = "Available Trainings";
            // 
            // expiredTraining
            // 
            expiredTraining.Enabled = false;
            expiredTraining.Format = DateTimePickerFormat.Short;
            expiredTraining.Location = new Point(117, 671);
            expiredTraining.Name = "expiredTraining";
            expiredTraining.Size = new Size(301, 47);
            expiredTraining.TabIndex = 9;
            // 
            // expiredTrainingLbl
            // 
            expiredTrainingLbl.AutoSize = true;
            expiredTrainingLbl.Enabled = false;
            expiredTrainingLbl.Location = new Point(112, 609);
            expiredTrainingLbl.Name = "expiredTrainingLbl";
            expiredTrainingLbl.Size = new Size(306, 41);
            expiredTrainingLbl.TabIndex = 10;
            expiredTrainingLbl.Text = "Find Expired Trainings";
            // 
            // fiscalYear
            // 
            fiscalYear.Enabled = false;
            fiscalYear.FormattingEnabled = true;
            fiscalYear.Location = new Point(117, 821);
            fiscalYear.Name = "fiscalYear";
            fiscalYear.Size = new Size(302, 49);
            fiscalYear.TabIndex = 11;
            // 
            // fiscalYearLbl
            // 
            fiscalYearLbl.AutoSize = true;
            fiscalYearLbl.Enabled = false;
            fiscalYearLbl.Location = new Point(117, 754);
            fiscalYearLbl.Name = "fiscalYearLbl";
            fiscalYearLbl.Size = new Size(152, 41);
            fiscalYearLbl.TabIndex = 12;
            fiscalYearLbl.Text = "Fiscal Year";
            // 
            // saveJSONFile
            // 
            saveJSONFile.DefaultExt = "Json";
            saveJSONFile.Filter = "JSON|*.Json";
            saveJSONFile.InitialDirectory = "C:\\";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(34, 141);
            button1.Name = "button1";
            button1.Size = new Size(351, 58);
            button1.TabIndex = 13;
            button1.Text = "Update Output";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 1029);
            Controls.Add(button1);
            Controls.Add(fiscalYearLbl);
            Controls.Add(fiscalYear);
            Controls.Add(expiredTrainingLbl);
            Controls.Add(expiredTraining);
            Controls.Add(trainingsLbl);
            Controls.Add(trainings);
            Controls.Add(outputTypeLbl);
            Controls.Add(label2);
            Controls.Add(outputPreview);
            Controls.Add(outputType);
            Controls.Add(label1);
            Controls.Add(saveJSON);
            Controls.Add(openFile);
            Controls.Add(jsonPreview);
            Name = "Form1";
            Text = "Round 1 - Json Reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox jsonPreview;
        private OpenFileDialog openJSONFile;
        private Button openFile;
        private Button saveJSON;
        private Label label1;
        private ComboBox outputType;
        private Label label2;
        private TextBox outputPreview;
        private Label outputTypeLbl;
        private CheckedListBox trainings;
        private Label trainingsLbl;
        private DateTimePicker expiredTraining;
        private Label expiredTrainingLbl;
        private ComboBox fiscalYear;
        private Label fiscalYearLbl;
        private SaveFileDialog saveJSONFile;
        private Button button1;
    }
}
