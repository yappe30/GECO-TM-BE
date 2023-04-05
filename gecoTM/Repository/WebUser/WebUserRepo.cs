
using gecoTM.DTO.WebUser;
using gecoTM.Models;
using gecoTM.Models.WebUser;
using Microsoft.EntityFrameworkCore;


namespace gecoTM.Repository.WebUser
{
    public class WebUserRepo: IWebUserRepo
    {
        private TmContext _webUserContext;
        public WebUserRepo(TmContext webUserContext)
        {
            _webUserContext = webUserContext;
        }
        public async Task<List<WebUserJoinDTO>> GetWebUser(string username, string password)
        {
            var query = (from c in _webUserContext.WebUser
                         join t in _webUserContext.Employee on c.employee_id equals t.employee_id
                         where c.employee_id == username && c.password == password
                         select new WebUserJoinDTO
                         {
                             employee_id = c.employee_id,
                             password = c.password,
                             last_name = t.last_name,
                             first_name = t.first_name,
                             middle_name = t.middle_name,
                             role = c.role,
                         }

                         );
            //var _result = await _webUserContext.WebUser.SingleOrDefaultAsync(found => found.employee_id == username && found.password == password);

            return await query.ToListAsync();


        }
    }
}
