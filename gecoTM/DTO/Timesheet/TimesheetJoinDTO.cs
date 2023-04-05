namespace gecoTM.DTO.Timesheet
{
    public class TimesheetJoinDTO
    {
        public string timesheet_id { get; set; } = string.Empty;
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string project_id { get; set; } = string.Empty;
        public string project_name { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public string employee_id { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string first_name { get; set; } = string.Empty;
        public string middle_name { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
    }
}
