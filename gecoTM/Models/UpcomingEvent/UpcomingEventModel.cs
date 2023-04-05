namespace gecoTM.Models.UpcomingEvent
{
    public class UpcomingEventModel
    {
        public int id { get; set; }
        public string? event_name { get; set; }
        public string? event_description { get; set; }
        public string? event_image { get; set; }
        public DateTime startDate { get; set; }
        public string? event_link { get; set; }


    }
}
