using gecoTM.DTO.Blog;
using gecoTM.Models;
using gecoTM.Models.Blog;
using gecoTM.Models.Employee;
using Microsoft.EntityFrameworkCore;

namespace gecoTM.Repository.Blog
{
    public class BlogRepo: IBlogRepo
    {
        private TmContext _blogContext;

        public BlogRepo(TmContext blogContext)
        {
            _blogContext = blogContext;
        }
        public async Task<List<BlogModel>> GetBlog()
        {
            return await _blogContext.Blog.ToListAsync();
        }
    }
}
