using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePendu.Models
{
    [Table("word")]
    public class Word
    {
        private int id;
        private string wordValue;

        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("word_value")]
        public string WordValue { get => wordValue; set => wordValue = value; }

        public List<PenduUser> Users { get; set; }
    }
}
