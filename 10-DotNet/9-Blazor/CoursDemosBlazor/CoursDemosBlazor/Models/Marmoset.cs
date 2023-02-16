using System.ComponentModel.DataAnnotations;

namespace CoursDemosBlazor.Models
{
    public class Marmoset
    {
        public int Id { get; set; }
        [Required, StringLength(12, MinimumLength = 3, ErrorMessage = "Le nom doit faire entre 3 et 12 caractères")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public bool OwnsBanana { get; set; }
        [Required]
        public FurColors FurColor { get; set; }
        public enum FurColors
        {
            Red,
            Brown,
            Yellow,
            Orange,
            White
        }

        public override string? ToString()
        {
            return $"{Name} {Description} {OwnsBanana} {FurColor}";
        }
    }
}
