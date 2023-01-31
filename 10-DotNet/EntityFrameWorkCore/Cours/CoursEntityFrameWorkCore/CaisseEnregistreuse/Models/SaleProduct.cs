using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Models
{
    public class SaleProduct
    {
        public int Id { get; set; }
        public int Qty { get; set; }

        public int ProductId { get; set; }
        public int SaleId { get; set; }

        [ForeignKey(nameof(SaleId))]
        public Sale Sale { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        //demo

        /*public static void Test()
        {
            List<SaleProduct> list = new List<SaleProduct>(); 
            Product p = new Product();
            Sale s =new Sale();
            SaleProduct saleProduct = new SaleProduct() { Qty = 1, Product = p, Sale = s };
            list.Add(saleProduct);
            
        }*/
    }
}
