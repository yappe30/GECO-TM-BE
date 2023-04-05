namespace gecoTM.Models.UpcomingEvent
{
    public class UpcomingEventModel
    {
        public int id { get; set; }
        public string event_name { get; set; } = string.Empty;
        public string event_description { get; set; } = string.Empty;
        public string event_image { get; set; } = string.Empty;
        public DateTime startDate { get; set; }
        public string event_link { get; set; } = string.Empty;


    }
}
