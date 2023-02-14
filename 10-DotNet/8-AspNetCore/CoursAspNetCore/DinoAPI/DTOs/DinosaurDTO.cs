using System.ComponentModel.DataAnnotations;

namespace DinoAPI.DTOs
{
    public class DinosaurDTO
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "Name must start with an Uppercase Letter !")]
        public string? Name { get; set; }
        [Required]
        public string? Species { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DinoColor Color { get; set; }

        public enum DinoColor
        {
            Red,
            Green,
            Blue,
            Yellow,
        }
    }
}
