using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LePendu.Models
{
    [Table("pendu_user")]
    public class PenduUser
    {
        private int id;
        private string firstName;
        private string lastName;
        private string pseudo;

        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("first_name")]
        public string FirstName { get => firstName; set => firstName = value; }
        [Column("last_name")]
        public string LastName { get => lastName; set => lastName = value; }
        [Column("pseudo")]
        public string Pseudo { get => pseudo; set => pseudo = value; }

        public List<Word> Words { get; set; }

        public PenduUser()
        {
            Words = new List<Word>();
        }
    }
}
