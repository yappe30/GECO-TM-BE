using gecoTM.DTO.UpcomingEvent;
using gecoTM.Models;
using gecoTM.Models.Employee;
using gecoTM.Models.UpcomingEvent;
using Microsoft.EntityFrameworkCore;

namespace gecoTM.Repository.UpcomingEvent
{
    public class UpcomingEventRepo : IUpcomingEventRepo
    {
        private TmContext _upcomingContext;

        public UpcomingEventRepo(TmContext upcomingContext)
        {
            _upcomingContext = upcomingContext;
        }
        public async Task<List<UpcomingEventModel>> GetUpcomingEvent()
        {
            return await _upcomingContext.UpcomingEvent.ToListAsync();
        }

    }
}
