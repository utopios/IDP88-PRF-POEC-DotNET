using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCore.Controllers
{
    public class PersonController : Controller
    {
        public string ListPersons()
        {
            return "Je suis une liste de personne";
        }
    }
}
