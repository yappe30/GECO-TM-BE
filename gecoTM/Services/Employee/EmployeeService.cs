using AutoMapper;
using gecoTM.DTO.Employee;
using gecoTM.Repository.Employee;

namespace gecoTM.Services.Employee
{
    public class EmployeeService: IEmployeeService
    {
        private IMapper _mapper;
        private IEmployeeRepo _employeeRepo;

        public EmployeeService(IMapper mapper, IEmployeeRepo employeeRepo)
        {
            _mapper = mapper;
            _employeeRepo = employeeRepo;
        }

        public async Task<List<EmployeeDTO>> GetEmployee()
        {
            var employeesList = await _employeeRepo.GetEmployee();
            var records = _mapper.Map<List<EmployeeDTO>>(employeesList);

            return records;
        }
    }
}
