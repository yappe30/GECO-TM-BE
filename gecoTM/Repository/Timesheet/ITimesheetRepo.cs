using gecoTM.DTO.Timesheet;
using gecoTM.Models.Timesheet;

namespace gecoTM.Repository.Timesheet
{
    public interface ITimesheetRepo
    {
        Task<List<TimesheetJoinDTO>> GetTimesheet();
        Task<TimesheetModel> UpdateTimesheet(string id, string status, string remarks);
    }
}