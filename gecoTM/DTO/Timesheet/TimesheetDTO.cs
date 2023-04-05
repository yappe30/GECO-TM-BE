using System;

namespace gecoTM.DTO.Timesheet
{
    public class TimesheetDTO
    {
        public string? timesheet_id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string? project_id { get; set; }
        public string? employee_id { get; set; }
        public string? status { get; set; }
    }
}
