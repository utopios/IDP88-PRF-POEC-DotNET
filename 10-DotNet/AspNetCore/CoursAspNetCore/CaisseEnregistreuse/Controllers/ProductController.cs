using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaisseEnregistreuse.Controllers
{
    public class ProductController : Controller
    {
        private DataDbContext _dataDbContext;
        private IDevice _device;

        public ProductController(IDevice device, DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
            _device = device;
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
            ViewBag.Categories = _dataDbContext.Categories.ToList();
            return View();
        }

        public IActionResult SubmitForm(Product product)
        {
            _dataDbContext.Products.Add(product);
            if(_dataDbContext.SaveChanges() > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Form");
            }
        }
    }
}
