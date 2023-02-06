using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Services;
using CaisseEnregistreuse.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaisseEnregistreuse.Controllers
{
    public class ProductController : Controller
    {
        private DataDbContext _dataDbContext;
        private IDevice _device;
        private ILoginService _loginService;

        public ProductController(IDevice device, DataDbContext dataDbContext, ILoginService loginService)
        {
            _dataDbContext = dataDbContext;
            _device = device;
            _loginService = loginService;
        }
        public IActionResult Index()
        {
            //ViewData["products"] = _dataDbContext.Products.Include(p => p.Category).ToList();

            //ViewBag.products = _dataDbContext.Products.Include(p => p.Category).ToList();
            return View(_dataDbContext.Products.Include(p => p.Category).ToList());
        }

        public IActionResult Detail(int? id)
        {
            return View(_dataDbContext.Products.Include(p=> p.Category).FirstOrDefault( p => p.Id == id));
        }

        public IActionResult Form()
        {
            if(_loginService.IsLogged())
            {
                ViewBag.Categories = _dataDbContext.Categories.ToList();
                return View();
            }
            return RedirectToAction("LoginForm", "UserApp");
        }

        public IActionResult SubmitForm(Product product)
        {
            if (_loginService.IsLogged())
            {
                _dataDbContext.Products.Add(product);
                if (_dataDbContext.SaveChanges() > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Form");
                }
            }else
            {
                return RedirectToAction("LoginForm", "UserApp");
            }
                
        }
    }
}
