using gecoTM.DTO.Employee;

namespace gecoTM.Services.Employee
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>> GetEmployee();
    }
}