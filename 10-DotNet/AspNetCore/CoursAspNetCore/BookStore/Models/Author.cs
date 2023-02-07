using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("author")]
    public class Author
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public List<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}
