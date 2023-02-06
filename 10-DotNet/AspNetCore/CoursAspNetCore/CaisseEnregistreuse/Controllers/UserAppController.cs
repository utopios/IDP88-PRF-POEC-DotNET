using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Services;
using CaisseEnregistreuse.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CaisseEnregistreuse.Controllers
{
    public class UserAppController : Controller
    {
        private DataDbContext _dataContext;
        private ILoginService _loginService;

        public UserAppController(DataDbContext dataContext, ILoginService loginService)
        {
            _dataContext= dataContext;
            _loginService= loginService;
        }
        public IActionResult RegisterForm()
        {
            return View();
        }

        public IActionResult SubmitRegisterForm(UserApp userApp) {
            _dataContext.Users.Add(userApp);
            if(_dataContext.SaveChanges() > 0)
            {
                return RedirectToAction("LoginForm");
            }
            else
            {
                return View("RegisterForm");
            }
        }
        public IActionResult LoginForm()
        {
            return View();
        }
        public IActionResult SubmitLoginForm(string email, string password)
        {
            if(_loginService.Login(email, password))
            {
                return RedirectToAction("Index", "Product");
            }
            return View("LoginForm");
        }

        public IActionResult Logout()
        {
            _loginService.Logout();
            return RedirectToAction("Index", "Product");
        }
    }
}
