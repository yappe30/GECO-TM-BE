using AutoMapper;
using gecoTM.DTO.WebUser;
using gecoTM.Repository.WebUser;

namespace gecoTM.Services.WebUser
{
    public class WebUserService: IWebUserService
    {
        private IMapper _mapper;
        private IWebUserRepo _webUserRepo;
        public WebUserService(IMapper mapper, IWebUserRepo webUserRepo)
        {
            _mapper = mapper;
            _webUserRepo = webUserRepo;
        }
        public async Task<List<WebUserJoinDTO>> GetWebUser(string username, string password)
        {
            var webUser = await _webUserRepo.GetWebUser(username, password);
            var records = _mapper.Map<List<WebUserJoinDTO>>(webUser);

            return records;
        }
    }
   
}
