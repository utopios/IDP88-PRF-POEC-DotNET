using BookStore.Models;
using BookStore.Tools;

namespace BookStore.Services
{
    public class LoginService : ILogin
    {
        private DataContext _dataContext;
        private IHttpContextAccessor _contextAccessor;

        public LoginService(DataContext dataContext, IHttpContextAccessor contextAccessor)
        {
            _dataContext = dataContext;
            _contextAccessor = contextAccessor;
        }

        public string GetEmail()
        {
            return _contextAccessor.HttpContext.Session.GetString("email");
        }

        public bool IsAdmin()
        {
            string role = _contextAccessor.HttpContext.Session.GetString("role");
            return role == "admin";
        }

        public bool IsLoggedIn()
        {
            int? isLogged = _contextAccessor.HttpContext.Session.GetInt32("logged");
            return isLogged == 1;
        }

        public bool Login(string email, string password)
        {
            UserApp user = _dataContext.Users.FirstOrDefault(x => x.Email == email || x.Password == password);
            if (user == null)
            {
                return false;
            }
            else
            {
                _contextAccessor.HttpContext.Session.SetString("email", user.Email);
                _contextAccessor.HttpContext.Session.SetString("name", user.Name);
                _contextAccessor.HttpContext.Session.SetString("role", user.Role);
                _contextAccessor.HttpContext.Session.SetInt32("logged", 1);
                return true;
            }
        }

        public void Logout()
        {
            _contextAccessor.HttpContext.Session.Clear();
        }
    }
}
