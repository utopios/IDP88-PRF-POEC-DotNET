using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Models
{
    [Table("product")]
    public class Product : ObservableObject
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
                OnPropertyChanged();
            }
        }
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => description; set
            {
                description = value;
                OnPropertyChanged();
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }
        public int Stock
        {
            get => stock; 
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }

        
        [Column("category_id")]
        public int? CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }

        public List<SaleProduct> Sales { get; set; }
    }
}
