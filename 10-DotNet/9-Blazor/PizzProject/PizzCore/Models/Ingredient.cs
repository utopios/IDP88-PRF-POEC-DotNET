using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PizzCore.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [ForeignKey(nameof(Pizza))]
        public int PizzaId { get; set; }
        public Pizza? Pizza { get; set; }

        // pour définir qu'il est possible de convertir/cast une chaine caractère en ingrédient et vice-versa
        public static implicit operator string(Ingredient ingredient) => ingredient.Name ?? "";
        public static implicit operator Ingredient(string str) => new Ingredient() { Name = str };

        public override string ToString()
        {
            return Name ?? "";
        }
    }
}
