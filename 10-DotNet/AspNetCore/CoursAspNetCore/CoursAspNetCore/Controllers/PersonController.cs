using Microsoft.AspNetCore.Mvc;

namespace CoursAspNetCore.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult ListPersons()
        {
            //return new ContentResult() { Content = "<h1>Je suis une liste de personne</h1>", ContentType="text/html" };
            //return new ViewResult() { ViewName = "" };
            return View();
        }
    }
}
