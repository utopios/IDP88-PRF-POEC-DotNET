using System.ComponentModel.DataAnnotations.Schema;

namespace CaisseEnregistreuse.Models
{
    [Table("user_app")]
    public class UserApp
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get;set; }
    }
}
