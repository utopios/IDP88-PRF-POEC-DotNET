﻿using CaisseEnregistreuse.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaisseEnregistreuse.Controllers
{
    public class ProductController : Controller
    {
        private DataDbContext _dataDbContext;

        public ProductController()
        {
            _dataDbContext = new DataDbContext();
        }
        public IActionResult Index()
        {
            //ViewData["products"] = _dataDbContext.Products.Include(p => p.Category).ToList();

            //ViewBag.products = _dataDbContext.Products.Include(p => p.Category).ToList();
            return View(_dataDbContext.Products.Include(p => p.Category).ToList());
        }

        public IActionResult Detail(int? id)
        {
            return View(_dataDbContext.Products.Include(p=> p.Category).FirstOrDefault( p => p.Id == id));
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
