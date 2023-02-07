using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("author")]
    public class Author
    {
        [Column("id")]
        public int Id { get; set; }

        [Display(Name ="Nom et prénom de l'auteur")]
        [Required(ErrorMessage ="Merci de saisir le nom de l'auteur")]
        [Column("name")]
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}
