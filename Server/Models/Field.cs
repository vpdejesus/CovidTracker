namespace Server.Models
{
    public class Field
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Alias { get; set; }
        public string SqlType { get; set; }
        public int Length { get; set; }
        public object Domain { get; set; }
        public object DefaultValue { get; set; }
    }
}
