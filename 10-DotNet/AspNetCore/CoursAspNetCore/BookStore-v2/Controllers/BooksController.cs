using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TP03.Datas;
using TP03.Models;
using TP03.Models.ViewModels;

namespace TP03.Controllers
{
    [Authorize(Policy = "AdminOnly")]
    public class BooksController : Controller
    {
        private IRepository<Book> _booksRepository;
        private IRepository<Author> _authorsRepository;

        public BooksController(IRepository<Book> booksRepository, IRepository<Author> authorsRepository)
        {
            _booksRepository = booksRepository;
            _authorsRepository = authorsRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var books = _booksRepository.GetAll();
            return View(books);
        }

        [AllowAnonymous]
        public IActionResult Filter(string searchString)
        {
            if (string.IsNullOrEmpty(searchString)) return View("Index");

            var books = _booksRepository.GetAll();

            var filteredList = books.Where(x => x.Title.ToUpper().Contains(searchString.ToUpper()) || x.Description.ToUpper().Contains(searchString.ToUpper())).ToList();

            return View("Index", filteredList);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            Book bookDetails = _booksRepository.GetById(id);

            return View(bookDetails);
        }

        public IActionResult Create()
        {
            

            return View();
        }
        
        [HttpPost]
        public IActionResult Create(BookVM book)
        {
            if(!ModelState.IsValid)
            {
                return View(book);
            }

            Book newBook = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                PictureURL = book.PictureURL,
                ISBN = book.ISBN,
                Price = book.Price,
                BookCategory = book.BookCategory,
                ReleaseDate = book.ReleaseDate,
                Author = _authorsRepository.GetById(book.AuthorId)
            };

            _booksRepository.Add(newBook);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Book bookDetails = _booksRepository.GetById(id);

            BookVM bookVM = new BookVM()
            {
                Id = bookDetails.Id,
                Title = bookDetails.Title,
                Description = bookDetails.Description,
                PictureURL = bookDetails.PictureURL,
                ISBN = bookDetails.ISBN,
                Price = bookDetails.Price,
                BookCategory = bookDetails.BookCategory,
                ReleaseDate = bookDetails.ReleaseDate,
                AuthorId = bookDetails.Author.Id
            };

            ViewBag.Authors = new SelectList(_authorsRepository.GetAll(), "Id", "Fullname");

            return View(bookVM);
        }

        [HttpPost]
        public IActionResult Edit(int id, BookVM book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            Book editedBook = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                PictureURL = book.PictureURL,
                ISBN = book.ISBN,
                Price = book.Price,
                BookCategory = book.BookCategory,
                ReleaseDate = book.ReleaseDate,
                Author = _authorsRepository.GetById(book.AuthorId)
            };

            _booksRepository.Update(id, editedBook);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Book bookDetails = _booksRepository.GetById(id);

            return View(bookDetails);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _booksRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
