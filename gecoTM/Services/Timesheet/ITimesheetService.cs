using gecoTM.DTO.Timesheet;

namespace gecoTM.Services.Timesheet
{
    public interface ITimesheetService
    {
        Task<List<TimesheetJoinDTO>> GetTimesheet();
        Task<TimesheetDTO> UpdateTimesheet(string id, string status, string remarks);
    }
}