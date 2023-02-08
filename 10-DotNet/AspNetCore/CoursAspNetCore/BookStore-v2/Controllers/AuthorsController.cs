using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TP03.Datas;
using TP03.Models;

namespace TP03.Controllers
{
    [Authorize(Policy = "AdminOnly")]
    public class AuthorsController : Controller
    {
        private IRepository<Author> _authorsRepository;

        public AuthorsController(IRepository<Author> authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        public IActionResult Index()
        {
            var authors = _authorsRepository.GetAll();

            return View(authors);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            Author authorDetails = _authorsRepository.GetById(id);

            return View(authorDetails);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            if(!ModelState.IsValid)
            {
                return View(author);
            }

            _authorsRepository.Add(author);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Author authorDetails = _authorsRepository.GetById(id);

            return View(authorDetails);
        }

        [HttpPost]
        public IActionResult Edit(int id, Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }

            _authorsRepository.Update(id, author);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Author authorDetails = _authorsRepository.GetById(id);

            return View(authorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _authorsRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
