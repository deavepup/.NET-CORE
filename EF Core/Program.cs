using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EF_Core
{


    public class ShopContext: DbContext{
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public static readonly ILoggerFactory MyLoggerFactory
    = LoggerFactory.Create(builder => { builder.AddConsole(); });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseLoggerFactory(MyLoggerFactory)
            .UseSqlite("Data Source=shop.db");
        }
        
    }

    public class Product{
      
        
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Category{
        public int Id { get; set; }
        public string Name { get; set; }

    }
    

    
    class Program
    {
        static void Main(string[] args)
        {
            GetProductByName("Samsung");
           
        }
        static void AddProducts(){
        using(var db = new ShopContext()){
                var products = new List<Product>(){
                    new Product{Name="Samsung S6",Price=3000},
                    new Product{Name="Samsung S7",Price=4000},
                    new Product{Name="Samsung S8",Price=5000},
                    new Product{Name="Samsung S9",Price=6000}
                };
                db.Products.AddRange(products);
                db.SaveChanges();
                System.Console.WriteLine("Veriler Eklendi");
            }
    }
    static void AddProduct(){
        using(var db = new ShopContext()){
                var p =new Product{Name="Samsung S10",Price=8000};
                db.Products.AddRange(p);
                db.SaveChanges();
                System.Console.WriteLine("Veriler Eklendi");
            }
    }
    
    static void GetAllProduct(){
        using(var db = new ShopContext()){
            var products = db.
            Products
            .Select(x=> 
            new{
                    x.Name,
                    x.Price
            })
            .ToList();
            foreach (var p in products)
            {
                System.Console.WriteLine(p.Name,p.Price);
            }

        }
    }
    static void GetProductById(int id){
        using(var db = new ShopContext()){
            var products = db.Products.Where(x=>x.Id == id).FirstOrDefault();
            if (products !=null){
            System.Console.WriteLine(products.Id+" "+products.Name+" "+products.Price);}
            else{
            System.Console.WriteLine("Ürün Bulunamadı");}
        }
    }
    static void GetProductByName(string name){
        using(var db = new ShopContext()){
            var products = db.Products.Where(x=>x.Name.ToLower().Contains(name.ToLower())).ToList();
            if (products !=null){
            foreach (var p in products)
            {   
                System.Console.WriteLine(p.Name,p.Price);
            };
           
    }
    }
}




    }
}
