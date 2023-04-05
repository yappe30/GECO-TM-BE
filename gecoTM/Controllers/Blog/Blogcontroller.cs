using gecoTM.DTO.Blog;
using Microsoft.AspNetCore.Mvc;
using gecoTM.Services.Blog;

namespace gecoTM.Controllers.Blog
{
    [Route("api/[controller]")]
    [ApiController]
    public class Blogcontroller : ControllerBase
    {
        private IBlogService _blogService;
        ILogger _logger;

        public Blogcontroller(IBlogService blogService, ILogger<Blogcontroller> logger) 
        {
            _blogService = blogService;
            _logger = logger;
        }

        [HttpGet("/GetBlog")]
        public async Task<ActionResult<List<BlogDTO>>> GetBlog() 
        {
            var blogList = await _blogService.GetBlog();
            if (blogList != null)
            {
                _logger.LogInformation("Success GetEmployee Data");

                return Ok(blogList);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
