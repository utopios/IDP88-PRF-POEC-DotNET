using CoursAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCore.Controllers
{
    public class ContactController : Controller
    {
       public IActionResult Index()
        {
            //return "Je suis la page liste contacts";
            List<Contact> contacts = new List<Contact>() { 
                new Contact() { Name = "toto" },
                new Contact() { Name = "titi" },
                new Contact() { Name = "tata" },
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
            return View("Index");
        }

        public IActionResult form()
        {
            //return "Je suis la page pour ajouter un contact";
            return View("~/Views/Home/Index.cshtml");
        }

        public string CustomDetail(string firstName, string lastName) { 
            return firstName+" "+lastName;
        }
    }
}
