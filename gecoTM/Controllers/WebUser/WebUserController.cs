using gecoTM.Controllers.UpcomingEvent;
using gecoTM.DTO.UpcomingEvent;
using gecoTM.DTO.WebUser;
using gecoTM.Services.UpcomingEvent;
using gecoTM.Services.WebUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gecoTM.Controllers.WebUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebUserController : ControllerBase
    {
        private IWebUserService _webUserService;
        ILogger _logger;

        public WebUserController(IWebUserService webUserService, ILogger<WebUserController> logger) 
        {
            _webUserService = webUserService;
            _logger = logger;
        }

        [HttpGet("/GetWebUser")]
        public async Task<ActionResult<List<WebUserJoinDTO>>> GetWebUser(string username, string password)
        {
            var eventList = await _webUserService.GetWebUser(username, password);
            if (eventList != null)
            {
                _logger.LogInformation("Success Get User Data");

                return Ok(eventList);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
