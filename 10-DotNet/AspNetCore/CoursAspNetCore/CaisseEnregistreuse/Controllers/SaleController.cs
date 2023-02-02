using Microsoft.AspNetCore.Mvc;

namespace CaisseEnregistreuse.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
