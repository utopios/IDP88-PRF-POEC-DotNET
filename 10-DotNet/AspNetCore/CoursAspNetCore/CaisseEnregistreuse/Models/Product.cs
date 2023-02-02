using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnregistreuse.Models
{
    [Table("product")]
    public class Product
    {
        private int id;
        private string title;
        private string description;
        private decimal price;
        private int stock;



        public int Id
        {
            get => id;
            set
            {
                id = value;

            }
        }
        public string Title
        {
            get => title;
            set
            {
                title = value;

            }
        }
        public string Description
        {
            get => description; set
            {
                description = value;

            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                price = value;

            }
        }
        public int Stock
        {
            get => stock;
            set
            {
                stock = value;

            }
        }


        [Column("category_id")]
        public int? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }


    }
}