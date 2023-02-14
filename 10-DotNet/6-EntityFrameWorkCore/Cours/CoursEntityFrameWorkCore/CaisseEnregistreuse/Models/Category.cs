using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.Models
{
    [Table("category")]
    public class Category
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public Category() {
            Products = new List<Product>();            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
