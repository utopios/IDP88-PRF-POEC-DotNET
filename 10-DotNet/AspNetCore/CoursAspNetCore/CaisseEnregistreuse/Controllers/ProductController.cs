using Microsoft.AspNetCore.Mvc;

namespace CaisseEnregistreuse.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int? id)
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
