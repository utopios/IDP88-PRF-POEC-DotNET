using System.ComponentModel.DataAnnotations;

namespace PizzBlazor.DTOs
{
    public class PizzaEditDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Le Nom est requis.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "La liste des ingrédients est requise.")]
        [RegularExpression(@"^[\w0-9 \-]+(\,[\w0-9\- ]+)*$", ErrorMessage = "La liste des ingrédients doit etre séparée par des virgules et non vide.")]
        public string? IngredientsString { get; set; }
        [Required(ErrorMessage = "Le lien vers l'image est requis.")]
        public string? ImageLink { get; set; }
        [Range(1, 99, ErrorMessage = "Le prix doit être compris entre 1 et 99 €.")]
        public decimal Price { get; set; }
    }
}

