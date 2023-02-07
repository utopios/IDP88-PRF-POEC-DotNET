using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using BookStore.Tools;

namespace BookStore.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly DataContext _context;

        public AuthorsController(DataContext context)
        {
            _context = context;
        }

        // GET: Authors
        public IActionResult Index()
        {
            return View(_context.Authors.ToList());
        }

        // GET: Authors/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            Author author = _context.Authors
                .FirstOrDefault(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // GET: Authors/Create
        public IActionResult Create()
        {
            return View();
        }


        public IActionResult SubmitCreate([Bind("Id,Name")] Author author)
        {

            _context.Authors.Add(author);
            if (_context.SaveChanges() > 0)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("Create");
        }

        
        // GET: Authors/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            Author author =  _context.Authors
                .FirstOrDefault(m => m.Id == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        
        public IActionResult DeleteConfirmed(int id)
        {
            if (_context.Authors == null)
            {
                return Problem("Pas d'auteur dans la base de donnée");
            }
            Author author =  _context.Authors.Find(id);
            if (author != null)
            {
                _context.Authors.Remove(author);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthorExists(int id)
        {
            return _context.Authors.Any(e => e.Id == id);
        }
    }
}
