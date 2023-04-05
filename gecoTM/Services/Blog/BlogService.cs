using AutoMapper;
using gecoTM.DTO.Blog;
using gecoTM.Repository.Blog;

namespace gecoTM.Services.Blog
{
    public class BlogService: IBlogService
    {
        private IMapper _mapper;
        private IBlogRepo _blogRepo;

        public BlogService(IMapper mapper, IBlogRepo blogRepo)
        {
            _mapper = mapper;
            _blogRepo = blogRepo;
        }
        public async Task<List<BlogDTO>> GetBlog()
        {
            var blogList = await _blogRepo.GetBlog();
            var records = _mapper.Map<List<BlogDTO>>(blogList);

            return records;
        }
    }
}
