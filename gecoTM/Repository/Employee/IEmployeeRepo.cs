using gecoTM.Models.Employee;

namespace gecoTM.Repository.Employee
{
    public interface IEmployeeRepo
    {
        Task<List<EmployeeModel>> GetEmployee();
    }
}