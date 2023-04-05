using gecoTM.DTO.UpcomingEvent;

namespace gecoTM.Services.UpcomingEvent
{
    public interface IUpcomingEventService
    {
        Task<List<UpcomingEventDTO>> GetUpcomingEvent();
    }
}