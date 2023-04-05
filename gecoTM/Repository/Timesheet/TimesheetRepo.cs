using gecoTM.DTO.Timesheet;
using gecoTM.Models;
using gecoTM.Models.Timesheet;
using Microsoft.EntityFrameworkCore;

namespace gecoTM.Repository.Timesheet
{
    public class TimesheetRepo: ITimesheetRepo
    {
        private TmContext _timesheetContext;

        public TimesheetRepo(TmContext timesheetContext)
        {
            _timesheetContext = timesheetContext;
        }
        public async Task<List<TimesheetJoinDTO>> GetTimesheet()
        {
            var result =  (from c in _timesheetContext.Timesheet
                           join p in _timesheetContext.Project on c.project_id equals p.project_id
                    join l in _timesheetContext.Employee on c.employee_id equals l.employee_id
                    select new TimesheetJoinDTO { 
                        timesheet_id = c.timesheet_id,
                        startDate = c.startDate,
                        endDate = c.endDate,
                        project_id = c.project_id,
                        project_name = p.project_name,
                        employee_id = c.employee_id,
                        last_name = l.last_name,
                        first_name = l.first_name,
                        middle_name = l.middle_name,
                        role = l.role,
                        status = c.status
                    });

           return await result.ToListAsync();
        }

        public async Task<TimesheetModel> UpdateTimesheet(string id, string status) 
        {
            var _timesheetData = await _timesheetContext.Timesheet.SingleOrDefaultAsync(found => found.timesheet_id == id);
                _timesheetData.status = status;
                await _timesheetContext.SaveChangesAsync();
                return _timesheetData;

           
        }
    }
}
