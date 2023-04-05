using gecoTM.DTO.UpcomingEvent;
using gecoTM.Services.Timesheet;
using gecoTM.Services.UpcomingEvent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gecoTM.Controllers.UpcomingEvent
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpcomingEventController : ControllerBase
    {
        private IUpcomingEventService _upcomingEventServce;
        ILogger _logger;

        public UpcomingEventController(IUpcomingEventService upcomingEventService, ILogger<UpcomingEventController> logger) 
        {
            _upcomingEventServce = upcomingEventService;
            _logger = logger;
        }
        [HttpGet("/GetUpcomingEvent")]
        public async Task<ActionResult<List<UpcomingEventDTO>>> GetUpcomingEvent()
        {
            var eventList = await _upcomingEventServce.GetUpcomingEvent();
            if (eventList != null)
            {
                _logger.LogInformation("Success GetEmployee Data");

                return Ok(eventList);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
