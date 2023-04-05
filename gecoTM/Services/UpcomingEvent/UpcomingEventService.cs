using AutoMapper;
using gecoTM.DTO.Timesheet;
using gecoTM.DTO.UpcomingEvent;
using gecoTM.Repository.Timesheet;
using gecoTM.Repository.UpcomingEvent;

namespace gecoTM.Services.UpcomingEvent
{
    public class UpcomingEventService: IUpcomingEventService
    {
        private IMapper _mapper;
        private IUpcomingEventRepo _upcomingEventRepo;

        public UpcomingEventService(IMapper mapper, IUpcomingEventRepo upcomingEventRepo)
        {
            _mapper = mapper;
            _upcomingEventRepo = upcomingEventRepo;
        }
        public async Task<List<UpcomingEventDTO>> GetUpcomingEvent()
        {
            var upcomingEvent = await _upcomingEventRepo.GetUpcomingEvent();
            var records = _mapper.Map<List<UpcomingEventDTO>>(upcomingEvent);

            return records;
        }

    }
}
