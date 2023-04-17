namespace gecoTM.Models.Timesheet
{
    public class TimesheetModel
    {
        public int id { get; set; }
        public string timesheet_id { get; set; } = string.Empty;
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string project_id { get; set; } = string.Empty;
        public string employee_id { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public string? remarks { get; set; } = string.Empty;

    }
}
