using BookStore.Models;
using BookStore.Services;
using BookStore.Tools;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class UserController : Controller
    {
        private DataContext _dataContext;
        private ILogin _loginService;

        public UserController(DataContext dataContext, ILogin loginService)
        {
            _dataContext = dataContext;
            _loginService = loginService;
        }

        public IActionResult RegisterForm()
        {
            return View();
        }

        public IActionResult LoginForm() { 
            return View(); 
        }

        public IActionResult SubmitRegisterForm(UserApp userApp)
        {
            userApp.Role = "user";
            _dataContext.Users.Add(userApp);
            if(_dataContext.SaveChanges()>0)
            {
                return RedirectToAction("Index", "Books");
            }
            return View("RegisterForm");
        }

        public IActionResult SubmitLoginForm(string email, string password)
        {
            if(_loginService.Login(email, password))
            {
                return RedirectToAction("Index", "Books");
            }
            else
            {
                ViewBag.Message = "Erreur login";
                return View("LoginForm");
            }
            
        }

        public IActionResult Logout()
        {
            _loginService.Logout();
            return RedirectToAction("Index", "Books");
        }
    }
}
