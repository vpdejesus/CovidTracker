namespace Server.Models
{
    public class Attributes
    {
        public string Country_Region { get; set; }
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Active { get; set; }
        public int Deaths { get; set; }
        public object Last_Update { get; set; }
    }
}
