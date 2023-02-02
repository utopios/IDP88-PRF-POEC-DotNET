﻿using CaisseEnregistreuse.Models;
using CaisseEnregistreuse.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaisseEnregistreuse.Controllers
{
    public class CategoryController : Controller
    {
        private DataDbContext _dataDbContext;
        public CategoryController()
        {
            _dataDbContext = new DataDbContext();
        }
        public IActionResult Index()
        {
            return View(_dataDbContext.Categories.ToList());
        }

        public IActionResult GetProducts(int? id)
        {
            List<Product> products = _dataDbContext.Products.Include(c => c.Category).Where(p=>p.CategoryId == id).ToList();
            return View("~/Views/Product/Index.cshtml", products);
        }
    }
}