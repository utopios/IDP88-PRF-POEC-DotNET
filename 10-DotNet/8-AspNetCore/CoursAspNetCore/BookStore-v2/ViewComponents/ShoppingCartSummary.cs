using Microsoft.AspNetCore.Mvc;
using TP03.Services;

namespace TP03.Models.ViewComponents
{
    public class ShoppingCartSummary : ViewComponent
    {
        private OrderService _service;
        public ShoppingCartSummary(OrderService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            if (_service.CurrentOrder is not null)
            {
                return View(_service.GetOrderItems().Count);
            }

            return View(0);
        }
    }
}
