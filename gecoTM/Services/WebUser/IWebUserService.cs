using gecoTM.DTO.WebUser;

namespace gecoTM.Services.WebUser
{
    public interface IWebUserService
    {
        Task<List<WebUserJoinDTO>> GetWebUser(string username, string password);
    }
}