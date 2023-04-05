namespace gecoTM.DTO.Timesheet
{
    public class TimesheetJoinDTO
    {
        public string? timesheet_id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string? project_id { get; set; }
        public string? project_name { get; set; }
        public string? status { get; set; }
        public string? employee_id { get; set; }
        public string? last_name { get; set; }
        public string? first_name { get; set; }
        public string? middle_name { get; set; }
        public string? role { get; set; }
    }
}
