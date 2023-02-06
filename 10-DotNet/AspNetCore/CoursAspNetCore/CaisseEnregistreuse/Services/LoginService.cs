using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;

namespace CaisseEnregistreuse.Services
{
    public class LoginService : ILoginService
    {
        private DataDbContext _dataDbContext;
        private HttpContextAccessor _httpContextAccessor;

        public LoginService(DataDbContext dataDbContext, HttpContextAccessor httpContextAccessor)
        {
            _dataDbContext = dataDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetEmail()
        {
            string email = _httpContextAccessor.HttpContext.Session.GetString("email");
            return email;
        }

        public bool IsLogged()
        {
            int? isLogged = _httpContextAccessor.HttpContext.Session.GetInt32("IsLogged");
            return isLogged == 1;
        }

        public bool Login(string email, string password)
        {
            UserApp user = _dataDbContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (user == null)
            {
                return false;
            }
            _httpContextAccessor.HttpContext.Session.SetString("email", email);
            _httpContextAccessor.HttpContext.Session.SetInt32("IsLogged", 1);
            return true;
        }
    }
}
