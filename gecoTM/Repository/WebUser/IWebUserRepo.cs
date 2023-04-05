using gecoTM.DTO.WebUser;
using gecoTM.Models.WebUser;
using System.Threading.Tasks;

namespace gecoTM.Repository.WebUser
{
    public interface IWebUserRepo
    {
        Task<List<WebUserJoinDTO>> GetWebUser(string username, string password);
    }
}