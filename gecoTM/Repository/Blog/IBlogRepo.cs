using gecoTM.DTO.Blog;
using gecoTM.Models.Blog;

namespace gecoTM.Repository.Blog
{
    public interface IBlogRepo
    {
        Task<List<BlogModel>> GetBlog();
    }
}