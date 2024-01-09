//using System;
//using e_commerce.Data;
//using Microsoft.EntityFrameworkCore;

//namespace e_commerce.Models
//{
//    public class CategoryProductContext : ApplicationDbContext
//    {
//        public CategoryProductContext(DbContextOptions<ApplicationDbContext> options) : base(options)
//        {

//        }
//        public DbSet<CategoryProduct> CategoryProduct { get; set; }
//    }

//    public class CategoryProduct
//    {
//        public Category Category { get; set; } = null;

//        public int CategoryId { get; set; }

//        public Product Product { get; set; } = null;

//        public int ProductId { get; set; }
//    }
//}

