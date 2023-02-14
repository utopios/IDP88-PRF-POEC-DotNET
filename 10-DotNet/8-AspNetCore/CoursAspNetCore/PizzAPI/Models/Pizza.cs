using static System.Net.Mime.MediaTypeNames;

namespace PizzAPI.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Description {get; set;}
        public decimal Prix {get; set;}
        public string? Statuts {get; set;}
        public List<Ingredient>? Ingredients { get; set;}
        public enum PizzaStatus
        {
            Vegetarienne,
            Piquante
        }
    }
}
