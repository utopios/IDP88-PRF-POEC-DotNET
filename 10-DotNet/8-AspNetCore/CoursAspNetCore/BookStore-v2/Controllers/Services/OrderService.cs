using TP03.Datas;
using TP03.Models;

namespace TP03.Services
{
    public class OrderService
    {
        private ISession _session;
        public string OrderId { get; set; }
        public Order CurrentOrder { get; set; }

        public IRepository<Order> _ordersRepository;
        public IRepository<WebAppUser> _webAppUserRepository;

        public OrderService(IHttpContextAccessor httpContext, IRepository<Order> ordersRepository, IRepository<WebAppUser> webAppUserRepository)
        {
            _ordersRepository = ordersRepository;
            _webAppUserRepository = webAppUserRepository;

            _session = httpContext.HttpContext.Session;

            string orderId = _session.GetString("orderId") ?? Guid.NewGuid().ToString();
            _session.SetString("orderId", orderId);

            CurrentOrder = _ordersRepository.GetAll().FirstOrDefault(x => x.OrderId == _session.GetString("orderId"));
            WebAppUser currentUser = _webAppUserRepository.GetAll().FirstOrDefault(x => x.UserName == httpContext.HttpContext.User.Identity.Name);

            if (CurrentOrder == null && currentUser != null)
            {
                CurrentOrder = new Order()
                {
                    OrderId = orderId,
                    UserId = currentUser.UserName,
                    Email = currentUser.Email,
                };

                _ordersRepository.Add(CurrentOrder);
            }
        }

        public void AddBookToOrder(Book book)
        {
            OrderItem item = CurrentOrder.OrderItems.FirstOrDefault(x => x.Book == book);

            if (item == null)
            {
                item = new OrderItem()
                {
                    Order = CurrentOrder,
                    Book = book,
                    Amount = 1
                };

                CurrentOrder.OrderItems.Add(item);
            }
            else
            {
                item.Amount++;
            }

            _ordersRepository.Update(CurrentOrder.Id, CurrentOrder);
        }

        public void RemoveBookFromOrder(Book book)
        {
            OrderItem item = CurrentOrder.OrderItems.FirstOrDefault(x => x.Book == book);

            if (item != null)
            {
                if (item.Amount > 1)
                {
                    item.Amount--;
                }
                else
                {
                    CurrentOrder.OrderItems.Remove(item);
                }
            }

            _ordersRepository.Update(CurrentOrder.Id, CurrentOrder);
        }

        public List<OrderItem> GetOrderItems()
        {
            return CurrentOrder.OrderItems;
        }
        public double GetShoppingCartTotal()
        {
            return CurrentOrder.OrderItems.Select(x => x.Book.Price * x.Amount).Sum();
        }

        public void CompleteOrder()
        {
            _ordersRepository.Update(CurrentOrder.Id, CurrentOrder);

            string orderId = Guid.NewGuid().ToString();
            _session.SetString("orderId", orderId);
        }

        public void EmptyCart()
        {
            if (CurrentOrder is not null) CurrentOrder.OrderItems.Clear();

            string orderId = Guid.NewGuid().ToString();
            _session.SetString("orderId", orderId);
        }
    }
}
