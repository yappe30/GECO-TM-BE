using AutoMapper;
using gecoTM.Models.Blog;
using gecoTM.DTO.Blog;

namespace gecoTM.Profiles.Blog
{
    public class BlogProfile: Profile
    {
        public BlogProfile() {
            CreateMap<BlogModel, BlogDTO>();
            CreateMap<BlogDTO, BlogModel>();
        }

    }
}
