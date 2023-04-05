using gecoTM.DTO.UpcomingEvent;
using gecoTM.Models.UpcomingEvent;
using AutoMapper;

namespace gecoTM.Profiles.UpcomingEvent
{
    public class UpcomingEventProfile: Profile
    {
        public UpcomingEventProfile() 
        {
            CreateMap<UpcomingEventModel, UpcomingEventDTO>();
            CreateMap<UpcomingEventDTO, UpcomingEventModel>();
        }
    }
}
