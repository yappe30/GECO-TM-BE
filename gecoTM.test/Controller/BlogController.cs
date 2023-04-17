using Microsoft.AspNetCore.Mvc;
using Moq;
using gecoTM.Controllers.Blog;
using gecoTM.Models.Blog;
using gecoTM.Services.Blog;
using gecoTM.DTO.Blog;
using Microsoft.Extensions.Logging;

namespace gecoTM.test.Controller
{
    public class BlogControllerTest
    {
        private readonly Mock<IBlogService> _blogServiceMock;
        private readonly Mock<ILogger<Blogcontroller>> _logger;
        public BlogControllerTest()
        {
            // Mock IBlogService
            this._blogServiceMock = new Mock<IBlogService>();

            // Mock Serilog.ILogger
            this._logger = new Mock<ILogger<Blogcontroller>>();
        }

        [Fact]
        public void GetBlogs_ReturnOkResult()
        {
            var blogsData = new List<BlogDTO>()
            {
                new BlogDTO()
                {
                    blog_name = "Test name 1",
                    blog_subject = "Test Subject 1",
                    blog_image = "www.testImageLink1.com",
                    blog_description = "test description 1",
                },
                new BlogDTO()
                {
                    blog_name = "Test name 2",
                    blog_subject = "Test Subject 2",
                    blog_image = "www.testImageLink2.com",
                    blog_description = "test description 2",
                },
                new BlogDTO()
                {
                    blog_name = "Test name 3",
                    blog_subject = "Test Subject 3",
                    blog_image = "www.testImageLink3.com",
                    blog_description = "test description 3",
                }
            };

            _blogServiceMock.Setup(x => x.GetBlog()).Returns(Task.Run(() => blogsData));
            var blogController = new Blogcontroller(_blogServiceMock.Object, _logger.Object);
            var httpStatusCodeExpected = 200;

            // act
            var okObjectResult = blogController.GetBlog().Result.Result as OkObjectResult;
            //var httpStatusCodeResult = okObjectResult?.StatusCode;
            //var blogsResult = okObjectResult?.Value;

            // assert
            Assert.NotNull(okObjectResult);
            //Assert.Equal(httpStatusCodeResult, httpStatusCodeExpected);
            //Assert.IsType<List<BlogModel>>(blogsResult);
        }
    }
}