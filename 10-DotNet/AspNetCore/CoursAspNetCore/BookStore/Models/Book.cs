using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{

    [Table("book")]
    public class Book
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("type")]
        public string Type { get; set; }

        [Column("poster")]
        public string Poster { get; set; }
        
        [Column("date_release")]
        public DateTime Date { get; set; }
        [Column("author_id")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }

        [Column("description")]
        public string Description { get; set; }
       
    }
}
