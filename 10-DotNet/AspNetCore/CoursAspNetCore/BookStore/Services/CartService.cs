using BookStore.Models;
using BookStore.Tools;
using System.Text.Json;

namespace BookStore.Services
{
    public class CartService : ICart
    {
        private DataContext _dataContext;
        private IHttpContextAccessor _contextAccessor;

        public CartService(DataContext dataContext, IHttpContextAccessor contextAccessor)
        {
            _dataContext = dataContext;
            _contextAccessor = contextAccessor;
        }

        public void AddToCart(int id)
        {
            Book book = _dataContext.Books.Find(id);
            if(book != null) {
                List<Book> cart = _GetCart();
                cart.Add(book);
                WriteCart(cart);
            }
        }

        public List<Book> GetCart()
        {
            return _GetCart();
        }

        public void RemoveFromCart(int id)
        {
            Book book = _dataContext.Books.Find(id);
            if (book != null)
            {
                List<Book> cart = _GetCart();
                cart.Remove(book);
                WriteCart(cart);
            }
        }

        public decimal TotalCart()
        {
            decimal total = 0;
            List<Book> cart = _GetCart();
            cart.ForEach(c =>
            {
                total += c.Price;
            });
            return total;
        }
        private List<Book> _GetCart()
        {
            List<Book> cart = new List<Book>();
            string cartString = _contextAccessor.HttpContext.Session.GetString("cart");
            if(cartString != null)
            {
                cart = JsonSerializer.Deserialize<List<Book>>(cartString);
            }
            return cart; 
        }
        private void WriteCart(List<Book> cart)
        {
            _contextAccessor.HttpContext.Session.SetString("cart", JsonSerializer.Serialize(cart));
        }
    }
}
