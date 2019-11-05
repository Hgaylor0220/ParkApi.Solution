namespace ParkMVC.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public string Location { get; set; }
        public string Coordinates { get; set; }
        public string Attraction { get; set; }
        public string Information { get; set; }
        public string RequirmentType { get; set; }
    }
}