using System;
using e_commerce.Data;

using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{

    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var category = _context.Categories.ToList();
            return View(category);
        }

    }
}

