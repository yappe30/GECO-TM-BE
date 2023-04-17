using gecoTM.DTO.Timesheet;
using gecoTM.Models.Timesheet;
using gecoTM.Services.Timesheet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gecoTM.Controllers.TimeSheet
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimesheetController : ControllerBase
    {
        private ITimesheetService _timesheetService;
        ILogger _logger;

        public TimesheetController(ITimesheetService timesheetService, ILogger<TimesheetController> logger)
        {
            _timesheetService = timesheetService;
            _logger = logger;
        }
        [HttpGet("/GetTimesheet")]
        public async Task<ActionResult<List<TimesheetJoinDTO>>> GetTimesheet() 
        {
            var timesheetList = await _timesheetService.GetTimesheet();
            if (timesheetList != null)
            {
                _logger.LogInformation("Success GetEmployee Data");

                return Ok(timesheetList);
            }
            else
            {
                throw new NotImplementedException();
            }

        }
        [HttpPut("/UpdateTimesheet")]
        public async Task<ActionResult<List<TimesheetDTO>>> UpdateTimesheet(string id, string status, string? remarks = "") 
        {
            
                var updateTimesheet = await _timesheetService.UpdateTimesheet(id, status, remarks);
            if (updateTimesheet != null)
            {
                return Ok(updateTimesheet);
            }
            else 
            {
                throw new NotImplementedException();
            }

               

        }
    }
}
