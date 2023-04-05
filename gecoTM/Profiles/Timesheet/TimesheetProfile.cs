using AutoMapper;
using gecoTM.DTO.Timesheet;
using gecoTM.Models.Timesheet;

namespace gecoTM.Profiles.Timesheet
{
    public class TimesheetProfile: Profile
    {
        public TimesheetProfile()
        {
            CreateMap<TimesheetModel, TimesheetDTO>();
            CreateMap<TimesheetDTO, TimesheetModel>();
            CreateMap<TimesheetJoinDTO, TimesheetModel>();
            CreateMap<TimesheetModel, TimesheetJoinDTO>();

        }
    }
}
