using AutoMapper;
using gecoTM.DTO.WebUser;
using gecoTM.Models.WebUser;

namespace gecoTM.Profiles.WebUser
{
    public class WebUserProfile: Profile
    {
        public WebUserProfile()
        {
            CreateMap<WebUserModel, WebUserDTO>();
            CreateMap<WebUserDTO, WebUserModel>();
        }
    }
}
