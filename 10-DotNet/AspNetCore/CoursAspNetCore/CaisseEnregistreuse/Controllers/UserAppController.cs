using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
using Microsoft.AspNetCore.Mvc;

namespace CaisseEnregistreuse.Controllers
{
    public class UserAppController : Controller
    {
        private DataDbContext _dataContext;

        public UserAppController(DataDbContext dataContext)
        {
            _dataContext= dataContext;
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
    }
}
