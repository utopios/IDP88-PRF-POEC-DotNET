using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PizzAPI.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(PizzaId))]
        public int PizzaId { get; set; }
        // [JsonIgnore] // est utile lorsque l'on ne veut pas la pizza dans l'ingrédient
        public Pizza? Pizza { get; set; }
    }
}
