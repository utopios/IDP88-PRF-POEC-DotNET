using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("user_app")]
    public class UserApp
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        
        [Column("role")]
        public string Role { get; set; }

    }
}
