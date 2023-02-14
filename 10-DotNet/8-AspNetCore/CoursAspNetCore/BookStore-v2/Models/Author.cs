using System.ComponentModel.DataAnnotations;

namespace TP03.Models
{
    public class Author
    {
        public int Id { get; set; }
        public static int Compteur;

        [Display(Name = "Prénom")]
        public string Firstname { get; set; }

        [Display(Name = "Nom")]
        public string Lastname { get; set; }

        [Display(Name = "Nom complet")]
        public string Fullname
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }

        [Display(Name = "Date de naissance")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Age")]
        public int Age
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }

        [Display(Name = "Photo")]
        public string PictureURL { get; set; }

        [Display(Name = "Livres")]
        public List<Book> Books { get; set; }

        public Author()
        {
            Id = ++Compteur;
            Books = new List<Book>();
        }
    }
}
