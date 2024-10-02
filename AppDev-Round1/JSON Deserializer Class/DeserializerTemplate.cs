namespace JSON_Deserializer_Class
{
    public class DeserializerTemplate
    {
        public string name { get; set; }
        public List<Training> completions { get; set; }
    }

    public class Training
    {
        public string name { get; set; }
        public string timestamp { get; set; }
        public string? expires { get; set; }
    }
}
