using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TP03.Datas;
using TP03.Models;
using TP03.Models.ViewModels;
using TP03.Services;

namespace TP03.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private IRepository<Order> _ordersRepository;
        private IRepository<Book> _booksRepository;
        private OrderService _orderService;

        public OrdersController(IRepository<Order> ordersRepository, OrderService orderService, IRepository<Book> booksRepository)
        {
            _ordersRepository = ordersRepository;
            _orderService = orderService;
            _booksRepository = booksRepository;
        }

        public IActionResult Index()
        {
            string userId = HttpContext.User.Identity.Name;

            List<Order> orders = _ordersRepository.GetAll().Where(o => o.UserId == userId && o.OrderItems.Count > 0).ToList();

            return View(orders);
        }

        [Authorize(Policy ="AdminOnly")]
        public IActionResult AllOrders()
        {

            List<Order> orders = _ordersRepository.GetAll().Where(o => o.OrderItems.Count > 0).ToList();

            return View("Index",orders);
        }

        public IActionResult ShoppingCart()
        {
            var items = _orderService.GetOrderItems();

            OrderVM orderVM = new OrderVM()
            {
                Order = _orderService.CurrentOrder,
                OrderTotal = _orderService.GetShoppingCartTotal(),
            };

            return View(orderVM);
        }

        public IActionResult AddBookToCart(int id)
        {
            Book book = _booksRepository.GetById(id);

            if (book != null)
            {
                _orderService.AddBookToOrder(book);
            }

            return RedirectToAction("ShoppingCart");
        }

        public IActionResult RemoveBookFromCart(int id)
        {
            Book book = _booksRepository.GetById(id);

            if (book != null)
            {
                _orderService.RemoveBookFromOrder(book);
            }

            return RedirectToAction("ShoppingCart");
        }

        public IActionResult CompleteOrder()
        {
            _orderService.CompleteOrder();

            return View("OrderCompleted");
        }
    }
}
