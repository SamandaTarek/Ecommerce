using System;
using System.Linq;
using e_commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        //Httpget
        [HttpGet]
        public async Task<IActionResult> Index(string ProductSearch)
        {
            ViewData["Getproductdetails"] = ProductSearch;
            var productquery = from x in _context.Products select x;
            var productquery2 = from y in _context.Categories select y;

            if (!String.IsNullOrEmpty(ProductSearch))
            {
                productquery = productquery.Where(x =>
                x.Name.Contains(ProductSearch));

                productquery2 = productquery2.Where(y =>
                y.Name.Contains(ProductSearch));
            }
            return View(await productquery.AsNoTracking().ToListAsync());
            
        }

    }
}

