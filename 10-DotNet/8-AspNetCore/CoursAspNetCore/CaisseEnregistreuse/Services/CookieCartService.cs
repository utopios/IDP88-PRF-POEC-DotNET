using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
using System.Text.Json;

namespace CaisseEnregistreuse.Services
{
    public class CookieCartService : ICartService
    {
        private DataDbContext _dataDbContext;
        private IHttpContextAccessor _contextAccessor;

        public CookieCartService(DataDbContext dataDbContext, IHttpContextAccessor contextAccessor)
        {
            _dataDbContext = dataDbContext;
            _contextAccessor = contextAccessor;
        }

        public void AddToCart(int id)
        {
            List<SaleProduct> products = GetAllCart();
            Product product = _dataDbContext.Products.Find(id);
            if(product != null)
            {
                bool found = false;
                products.ForEach(p =>
                {
                    if (p.Product.Id == product.Id)
                    {
                        p.Qty++;
                        found= true;
                    }
                });
                if(!found)
                {
                    products.Add(new SaleProduct() { Product = product, Qty = 1});
                }
                WriteToCookie(products);

            }
            
        }

        public List<SaleProduct> GetAllCart()
        {
            string cartCookies = _contextAccessor.HttpContext.Request.Cookies["cart"];
            if(cartCookies == null)
            {
                return new List<SaleProduct> { };
            }
            else
            {
                return JsonSerializer.Deserialize<List<SaleProduct>>(cartCookies);
            }
        }


        //Supprimer du panier
        public void RemoveFromCart(int id)
        {
            List<SaleProduct> products = GetAllCart();
            Product product = _dataDbContext.Products.Find(id);
            if (product != null)
            {
                SaleProduct productToRemove = null;
                products.ForEach(p =>
                {
                    if (p.Product.Id == product.Id)
                    {
                        if((p.Qty-1) > 0)
                        {
                            p.Qty--;
                        }
                        else
                        {
                            productToRemove = p;
                        }
                        
                    }
                });
                if (productToRemove != null)
                {
                    products.Remove(productToRemove);
                }
                WriteToCookie(products);

            }
        }

        private void WriteToCookie(List<SaleProduct> products)
        {
            _contextAccessor.HttpContext.Response.Cookies.Append("cart", JsonSerializer.Serialize(products));
        }
    }
}
