using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnregistreuse.Models
{
    [Table("Sale")]
    public class Sale
    {
        private decimal total;

        public int Id { get; set; }
        public decimal Total
        {
            get
            {
                total = 0;
                Products.ForEach(p =>
                {
                    total += p.Qty * p.Product.Price;
                });
                return total;
            }
            set
            {
                total = value;
            }
        }

        public List<SaleProduct> Products { get; set; }

        public Sale()
        {
            Products = new List<SaleProduct>();
        }
    }
}
