using System;
using e_commerce.Data;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class ProductContext : ApplicationDbContext
    {
        public ProductContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}

