using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnregistreuse.Models
{
    public class SaleProduct
    {
        private int qty;
        public int Id { get; set; }
        public int Qty
        {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
               
            }
        }

        public decimal TotalLine { get => Qty * Product.Price; }

        public int ProductId { get; set; }
        public int SaleId { get; set; }

        [ForeignKey(nameof(SaleId))]
        public Sale Sale { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
