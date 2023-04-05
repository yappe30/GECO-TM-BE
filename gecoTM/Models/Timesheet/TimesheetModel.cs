namespace gecoTM.Models.Timesheet
{
    public class TimesheetModel
    {
        public int id { get; set; }
        public string? timesheet_id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string? project_id { get; set; }
        public string? employee_id { get; set; }
        public string? status { get; set; }

    }
}
