using BookStore.Models;

namespace BookStore.Services
{
    public interface ICart
    {
        public List<Book> GetCart();
        public void AddToCart(int id);
        public void RemoveFromCart(int id);
        public decimal TotalCart();
    }
}
