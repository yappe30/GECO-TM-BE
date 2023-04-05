namespace gecoTM.Models.Employee
{
    public class EmployeeModel
    {
        public int id { get; set; }
        public string employee_id { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
        public string first_name { get; set; } = string.Empty;
        public string middle_name { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
        public int age { get; set; }
    }
}
