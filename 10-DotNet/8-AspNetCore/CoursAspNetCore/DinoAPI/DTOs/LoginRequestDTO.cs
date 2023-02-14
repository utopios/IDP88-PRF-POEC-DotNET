using System.ComponentModel.DataAnnotations;

namespace DinoAPI.DTOs
{
    public class LoginRequestDTO
    {
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required]
        //validateur custom de password à faire
        public string? PassWord { get; set; }
    }
}
