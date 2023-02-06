using CoursAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoursAspNetCore.Controllers
{
    public class ContactController : Controller
    {
       private IWebHostEnvironment _env;
       public ContactController(IWebHostEnvironment env)
        {
            _env = env;
        } 
       public IActionResult Index()
        {
            //return "Je suis la page liste contacts";
            List<Contact> contacts = new List<Contact>() { 
                new Contact() { Id=1, Name = "toto" },
                new Contact() { Id=2, Name = "titi" },
                new Contact() { Id=3, Name = "tata" },
            };

            //Pour passer des données à la vue on peut utiliser le viewData
            //ViewData["contacts"] = contacts;
            //Pour passer des données à la vue on peut utiliser le ViewBag
            //ViewBag.Contacts = contacts;
            //En utilisant les models de view
            return View(contacts);
        }

        public IActionResult detail(int? id)
        {
            //return "Je suis la page detail contact "+id;
            ViewBag.Id = id;
            return View();
        }

        public IActionResult form()
        {
            //return "Je suis la page pour ajouter un contact";
            return View();
        }

        //public IActionResult SubmitForm(string Name, string Email)
        public IActionResult SubmitForm(Contact contact, IFormFile avatar)
        {
            string path = Path.Combine(_env.WebRootPath, "images", avatar.FileName) ;
            Stream stream = System.IO.File.Create(path);
            avatar.CopyTo(stream);
            stream.Close();
            return RedirectToAction("Index");
        }

        public string CustomDetail(string firstName, string lastName) { 
            return firstName+" "+lastName;
        }

        public IActionResult AddToFavoris(int id)
        {
            //Cookie cookie= new Cookie() { 
            //    Name = "favoris",
            //    Value = id.ToString(),
            //};
            HttpContext.Response.Cookies.Append("favoris", id.ToString());
            return RedirectToAction("Index");
        }

        public IActionResult DisplayFavoris()
        {
            string favorisCookie = HttpContext.Request.Cookies["favoris"];
            if(favorisCookie != null)
            {
                ViewBag.FavorisContactId = favorisCookie;
            }
            return View();
        }
    }
}
