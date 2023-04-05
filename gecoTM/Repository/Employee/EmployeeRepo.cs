using gecoTM.DTO.Employee;
using gecoTM.Models;
using gecoTM.Models.Employee;
using Microsoft.EntityFrameworkCore;

namespace gecoTM.Repository.Employee
{
    public class EmployeeRepo: IEmployeeRepo
    {
        private TmContext _employeeContext;

        public EmployeeRepo(TmContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<List<EmployeeModel>> GetEmployee()
        {
            return await _employeeContext.Employee.ToListAsync();
        }
    }
}
