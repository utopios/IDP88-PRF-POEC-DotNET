using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using BookStore.Tools;
using BookStore.Services;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly DataContext _context;
        private IUpload _upload;
        public BooksController(DataContext context, IUpload upload)
        {
            _context = context;
            _upload = upload;
        }

        // GET: Books
        public IActionResult Index()
        {
            List<Book> books = _context.Books.Include(b => b.Author).ToList();
            return View(books);
        }

        public IActionResult Search(string search)
        {
            if(search == null || search == "") { return RedirectToAction(nameof(Index)); }
            List<Book> books = _context.Books.Include(b => b.Author).Where(b => b.Title.Contains(search) || b.Description.Contains(search) || b.Author.Name.Contains(search)).ToList();
            return View("Index", books);
        }

        // GET: Books/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            Book book =  _context.Books
                .Include(b => b.Author)
                .FirstOrDefault(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewBag.Authors = new SelectList(_context.Authors, "Id", "Name");
            return View();
        }

       
        public  IActionResult SubmitCreate([Bind("Title,Type,Date,AuthorId,Description, Price")] Book book, IFormFile poster)
        {
            book.Poster = _upload.Upload(poster);
            _context.Books.Add(book);
            if(_context.SaveChanges() > 0)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Create");
        }

        // GET: Books/Edit/5
        public  IActionResult Edit(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            Book book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewBag.Authors = new SelectList(_context.Authors, "Id", "Name");
            return View(book);
        }

        
        public  IActionResult SubmitEdit(int id, [Bind("Id,Title,Type,Poster,Date,AuthorId,Description,Price")] Book book, IFormFile newPoster)
        {
            if (id != book.Id)
            {
                return NotFound();
            }
            if(newPoster!= null)
            {
                book.Poster = _upload.Upload(newPoster);
            }
            
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Delete(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            Book book =  _context.Books
                .Include(b => b.Author)
                .FirstOrDefault(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        
        public  IActionResult DeleteConfirmed(int id)
        {
            if (_context.Books == null)
            {
                return Problem("Pas de table livre");
            }
            Book book =  _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }
            
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
          return _context.Books.Any(e => e.Id == id);
        }
    }
}
