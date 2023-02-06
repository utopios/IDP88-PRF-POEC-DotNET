using CaisseEnregistreuse.Models;

namespace CaisseEnregistreuse.Services
{
    public interface ICartService
    {
        public void AddToCart(int id);
        public void RemoveFromCart(int id);
        public List<SaleProduct> GetAllCart();
    }
}
