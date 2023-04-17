using AutoMapper;
using gecoTM.Repository.Timesheet;
using gecoTM.DTO.Timesheet;
using System.Linq;
using gecoTM.Models.Timesheet;

namespace gecoTM.Services.Timesheet
{
    public class TimesheetService: ITimesheetService
    {
        private IMapper _mapper;
        private ITimesheetRepo _timesheetRepo;
        public TimesheetService(IMapper mapper, ITimesheetRepo timesheetRepo)
        {
            _mapper = mapper;
            _timesheetRepo = timesheetRepo;
        }
        public async Task<List<TimesheetJoinDTO>> GetTimesheet()
        {
            var timesheetList = await _timesheetRepo.GetTimesheet();
            var records = _mapper.Map<List<TimesheetJoinDTO>>(timesheetList);

            return records;
        }
        public async Task<TimesheetDTO> UpdateTimesheet(string id, string status, string remarks) 
        {
            var timesheetList = await _timesheetRepo.UpdateTimesheet(id, status, remarks);
            var records = _mapper.Map<TimesheetDTO>(timesheetList);

            return records;
        }
    }
}
