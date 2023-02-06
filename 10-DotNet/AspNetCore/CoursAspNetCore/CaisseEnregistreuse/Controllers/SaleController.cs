using CaisseEnregistreuse.Services;
using Microsoft.AspNetCore.Mvc;

namespace CaisseEnregistreuse.Controllers
{
    public class SaleController : Controller
    {

        private ICartService _cartService;

        public SaleController(ICartService cartService)
        {
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            return View(_cartService.GetAllCart());
        }

        public IActionResult AddToCart(int id)
        {
           
            _cartService.AddToCart(id);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}
