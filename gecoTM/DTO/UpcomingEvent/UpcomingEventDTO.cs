
using System.ComponentModel.DataAnnotations;

namespace gecoTM.DTO.UpcomingEvent
{
    public class UpcomingEventDTO
    {
        public string event_name { get; set; } = string.Empty;
        public string event_description { get; set; } = string.Empty;
        public string event_image { get; set; } = string.Empty;
        public DateTime startDate { get; set; } = string.Empty;
        public string event_link { get; set; } = string.Empty;

    }
}
