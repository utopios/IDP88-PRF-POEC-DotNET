using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Models
{
    public class Contact
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
    }
}
