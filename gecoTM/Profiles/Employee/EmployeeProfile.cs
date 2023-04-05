using AutoMapper;
using gecoTM.Models.Employee;
using gecoTM.DTO.Employee;

namespace gecoTM.Profiles.Employee
{
    public class EmployeeProfile: Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<EmployeeModel, EmployeeDTO>();
            CreateMap<EmployeeDTO, EmployeeModel>();
        }
    }
}
