using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursTDD
{
    public class Shop
    {
        private List<Product> products;

        public List<Product> Products { get => products; set => products = value; }

        public Shop() {
            products = new List<Product>();        
        }
        public void Update(Product product)
        {
            if(product.Quality <= 0)
            {
                product.Quality = 0;
            }
            else if(product.Quality >= 50)
            {
                product.Quality = 50;
            }
            else
            {
                if (product.Type == "l")
                {
                    if(product.Name == "Brie")
                    {
                        product.Quality++;
                    }else
                    {
                        if (product.SellIn == 0)
                            product.Quality -= 4;
                        else
                            product.Quality -= 2;
                    }
                    
                }
                else
                {
                    if (product.SellIn == 0)
                        product.Quality -= 2;
                    else
                        product.Quality -= 1;
                }
            }
            
            if(product.SellIn > 0)
            {
                product.SellIn--;
            }
        }
    }
}
