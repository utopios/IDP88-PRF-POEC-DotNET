using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using TP03.Models;
using TP03.Models.Enums;

namespace TP03.Datas
{
    public class MockDatabase
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<WebAppUser> WebAppUsers { get; set; }

        public MockDatabase()
        {
            Books = new List<Book>();
            Authors = new List<Author>();
            Orders = new List<Order>();
            OrderItems = new List<OrderItem>();
            WebAppUsers = new List<WebAppUser>();


            Seed();
        }

        private void Seed()
        {
            if (!Authors.Any())
            {
                Authors.AddRange(new List<Author>()
                {
                    new Author()
                    {
                        Firstname = "Franck",
                        Lastname = "Thilliez",
                        BirthDate = new DateTime(1997, 10, 15),
                        PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Franck_Thilliez_-_quai_du_polar_2021_%281%29.jpg/220px-Franck_Thilliez_-_quai_du_polar_2021_%281%29.jpg"
                    },
                    new Author()
                    {
                        Firstname = "Stan",
                        Lastname = "Lee",
                        BirthDate= new DateTime(1922, 12, 28),
                        PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Stan_Lee_11_January_2007.jpg/250px-Stan_Lee_11_January_2007.jpg"
                    },
                    new Author()
                    {
                        Firstname = "Stephen",
                        Lastname = "King",
                        BirthDate = new DateTime(1947, 09, 21),
                        PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Stephen_King%2C_Comicon.jpg/220px-Stephen_King%2C_Comicon.jpg"
                    },
                    new Author()
                    {
                        Firstname = "Philip",
                        Lastname = "Pullman",
                        BirthDate = new DateTime(1946, 10, 19),
                        PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Philip_Pullman_2005-04-16.png/200px-Philip_Pullman_2005-04-16.png",
                    },
                    new Author()
                    {
                        Firstname ="Joanne",
                        Lastname = "Rowling",
                        BirthDate = new DateTime(1965, 07, 31),
                        PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/J._K._Rowling_2010.jpg/220px-J._K._Rowling_2010.jpg"
                    }
                });
            }

            if (!Books.Any())
            {
                Books.AddRange(new List<Book>()
                {
                    new Book()
                    {
                        Title = "La Mémoire Fantôme",
                        Description = "Cinquième roman de l'auteur s'intéressant à l'amnésie",
                        PictureURL = "https://lirepassion.fr/wp-content/uploads/2020/10/La_Memoire_fantome.gif",
                        ISBN = "978-2-847-42104-0",
                        Price = 14.99,
                        BookCategory = BookCategory.Mystery,
                        ReleaseDate = new DateTime(2007, 07, 26),
                        Author = Authors[0]
                    },
                    new Book()
                    {
                        Title = "Journey into Mystery #83",
                        Description = "Première apparition de Thor dans l'univers Marvel",
                        PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/6/64/Journey_into_Mystery_no._83_%28cover_art%29.jpg/250px-Journey_into_Mystery_no._83_%28cover_art%29.jpg",
                        ISBN = "0-784-25741-0",
                        Price = 7.99,
                        BookCategory = BookCategory.Comic,
                        ReleaseDate = new DateTime(),
                        Author = Authors[1]
                    },
                    new Book()
                    {
                        Title = "Ca",
                        Description = "Nouvelle ayant sucité plusieurs adaptations au cinéma",
                        PictureURL = "https://www.livredepoche.com/sites/default/files/styles/manual_crop_269_435/public/images/livres/couv/9782253151340-001-T.jpeg?itok=N4kEjLU-",
                        ISBN = "0-670-81302-8",
                        Price = 14.99,
                        BookCategory = BookCategory.Mystery,
                        ReleaseDate = new DateTime(1986, 09, 15),
                        Author = Authors[2]
                    },
                    new Book()
                    {
                        Title = "The Subtle Knife",
                        Description = "Deuxième tome de la trilogie A la Croisée des Mondes",
                        PictureURL = "https://images-na.ssl-images-amazon.com/images/I/91Q9KM0HvRL.jpg",
                        ISBN = "0-590-54243-5",
                        Price = 19.99,
                        BookCategory = BookCategory.Fantasy,
                        ReleaseDate = new DateTime(1997, 07, 22),
                        Author = Authors[3]
                    },
                    new Book()
                    {
                        Title = "Le Prisonnier d'Azkaban",
                        Description = "Troisième tome de la saga Harry Potter",
                        PictureURL = "https://images-na.ssl-images-amazon.com/images/I/91MKYJnP9FS.jpg",
                        ISBN = "2-07-052818-9",
                        Price = 14.99,
                        BookCategory = BookCategory.Fantasy,
                        ReleaseDate = new DateTime(1999, 10, 19),
                        Author = Authors[4]
                    }
                });

                Authors[0].Books.Add(Books[0]);
                Authors[1].Books.Add(Books[1]);
                Authors[2].Books.Add(Books[2]);
                Authors[3].Books.Add(Books[3]);
                Authors[4].Books.Add(Books[4]);
            }

            if (!WebAppUsers.Any())
            {
                WebAppUsers.AddRange(new List<WebAppUser>()
                {
                    new WebAppUser()
                    {
                        FirstName = "John",
                        LastName = "MARTIN",
                        UserName = "JohnRoxxor",
                        Email = "john.martin@example.com",
                        Password = "john1234"
                    },
                    new WebAppUser()
                    {
                        FirstName = "Sarah",
                        LastName = "LANCE",
                        UserName = "Admin",
                        Email = "sarah.lance@example.com",
                        Password = "admin"
                    }
                });

                WebAppUsers[0].Claims.Add(new Claim(ClaimTypes.Name, WebAppUsers[0].UserName));
                WebAppUsers[0].Claims.Add(new Claim(ClaimTypes.Email, WebAppUsers[0].Email));

                WebAppUsers[1].Claims = new List<Claim> { new Claim("Admin", "true") };
                WebAppUsers[1].Claims.Add(new Claim(ClaimTypes.Name, WebAppUsers[1].UserName));
                WebAppUsers[1].Claims.Add(new Claim(ClaimTypes.Email, WebAppUsers[1].Email));
            }
        }
    }
}
