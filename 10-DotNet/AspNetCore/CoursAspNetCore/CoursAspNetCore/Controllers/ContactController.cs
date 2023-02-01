using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCore.Controllers
{
    public class ContactController : Controller
    {
       public IActionResult Index()
        {
            //return "Je suis la page liste contacts";
            return View();
        }

        public IActionResult detail(int? id)
        {
            //return "Je suis la page detail contact "+id;
            return View();
        }

        public IActionResult form()
        {
            //return "Je suis la page pour ajouter un contact";
            return View();
        }

        public string CustomDetail(string firstName, string lastName) { 
            return firstName+" "+lastName;
        }
    }
}
