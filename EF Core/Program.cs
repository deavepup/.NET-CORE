using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{     
    public class ShopContext:DbContext
    {
        
        public DbSet<Product>Products{get;set;}
        public DbSet<Category>Categories{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuild)
        {
            OptionsBuild
            .UseLoggerFactory(MyLoggerFactory)
            .UseSqlite("Data Source=shop.db");
        }
        public static readonly ILoggerFactory MyLoggerFactory=LoggerFactory.Create(builder=>{builder.AddConsole();});
    }

// Entity Classes
    // Product (Id,Name,Price) => Product(Id,Name,Price)

    public class Product
    { 
        // primary key (Id, <type_name>Id)
        public int Id { get; set; }
       
       [MaxLength(100)]
       [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public string Description {get;set;}
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            GetProductByName("samsung s5");
                
        }
        static void AddProducts(){
                using(var db = new ShopContext())
            {
            //var p = new Product{Name="Samsung S5",Price=3000};
            var Products = new List<Product>(){
                new Product{Name="Samsung S6",Price=6000},
                new Product{Name="Samsung S7",Price=7000},
                new Product{Name="Samsung S8",Price=8000},
                new Product{Name="Samsung S9",Price=9000}
            };
            db.Products.AddRange(Products);
            db.SaveChanges();
            System.Console.WriteLine("Veriler Eklendi.");
            }
            }
        
        static void AddProduct(){
                using(var db = new ShopContext())
            {
            var p = new Product{Name="Samsung 10",Price=9500};
           
            db.Products.Add(p);
            db.SaveChanges();
            System.Console.WriteLine("Veriler Eklendi.");
            }
            }
        static void GetAllProducs(){
            using(var db = new ShopContext()){
                 var products = db.Products
                 .Select(p=> new{
                     p.Name,p.Price
                 })
                 .ToList();
                 foreach (var item in products)
                 {
                     System.Console.WriteLine(item.Name +" "+ item.Price);
                 }
            }
           
         }
        static void GetProductById(int id){
            using(var db = new ShopContext()){
                 var products = db.Products
                 .Where(x=>x.Id == id)
                 .Select(x=>new{x.Name,x.Price})
                 .FirstOrDefault();
                 if (products != null)
                 {
                     System.Console.WriteLine(products.Name +" "+ products.Price);
                 }
                 else{
                     System.Console.WriteLine("Ürün Bulunamadı");
                 }
            }
           
         
        }

          static void GetProductByName(string Name){
            using(var db = new ShopContext()){
                 var products = db.Products
                 .Where(x=>x.Name.ToLower().Contains(Name.ToLower()))
                 .Select(x=>new{x.Name,x.Price})
                 .ToList();
                 if (products != null)
                 {
                     foreach (var item in products)
                     {
                          System.Console.WriteLine(item.Name +" "+ item.Price);
                     }
                    
                 }
                 else{
                     System.Console.WriteLine("Ürün Bulunamadı");
                 }
            }
           
         
        }


        
        
        
        }

    }

