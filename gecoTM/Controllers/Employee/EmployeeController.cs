using gecoTM.DTO.Employee;
using gecoTM.Services.Employee;
using Microsoft.AspNetCore.Mvc;

namespace gecoTM.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        ILogger _logger;

        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        [HttpGet("/GetEmployee")]
        public async Task<ActionResult<List<EmployeeDTO>>> GetEmployee()
        {
            var employeeList = await _employeeService.GetEmployee();
            if (employeeList != null)
            {
                _logger.LogInformation("Success GetEmployee Data");

                return Ok(employeeList);
            }
            else
            {
                _logger.LogInformation("Failed GetEmployee Data");
                return BadRequest();
            }
        }
    }
}
