using gecoTM.DTO.UpcomingEvent;
using gecoTM.Models.UpcomingEvent;

namespace gecoTM.Repository.UpcomingEvent
{
    public interface IUpcomingEventRepo
    {
        Task<List<UpcomingEventModel>> GetUpcomingEvent();
    }
}