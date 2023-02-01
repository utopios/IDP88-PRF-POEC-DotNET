using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCore.Controllers
{
    public class ContactController : Controller
    {
       public string Index()
        {
            return "Je suis la page liste contacts";
        }

        public string detail(int? id)
        {
            return "Je suis la page detail contact "+id;
        }

        public string form()
        {
            return "Je suis la page pour ajouter un contact";
        }
    }
}
