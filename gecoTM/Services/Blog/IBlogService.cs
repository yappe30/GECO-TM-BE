using gecoTM.DTO.Blog;

namespace gecoTM.Services.Blog
{
    public interface IBlogService
    {
        Task<List<BlogDTO>> GetBlog();
    }
}