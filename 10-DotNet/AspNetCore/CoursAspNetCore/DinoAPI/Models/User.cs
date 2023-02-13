using System.ComponentModel.DataAnnotations;

namespace DinoAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z].*", ErrorMessage = "FirstName must start with an Uppercase Letter !")]
        public string? FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z\-]*", ErrorMessage = "LastName must be only Uppercase !")]
        public string? LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        // équivalent : public string FullName2 { get { return FirstName + " " + LastName; } }
        public int Age => DateTime.Now.Year - BirthDate.Year; // pas forcément exact 
        [Required]
        public string? Gender { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
        [Required]
        //validateur custom de password à faire
        public string? PassWord { get; set; }
        [Required]
        public bool IsAdmin { get; set; } = false;
    }
}
