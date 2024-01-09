using System;
using e_commerce.Data;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class CategoryContext : ApplicationDbContext
    {
        public CategoryContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

