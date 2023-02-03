using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    [Table("todo")]
    public class ToDo
    {
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("done")]
        public bool Done { get; set; }
    }
}
