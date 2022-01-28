using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System.Collections.Generic;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // ViewBag
            // Model
            // ViewData

            var product = new Product { Name = "Iphone X", Price = 6000, Description = "güzel telefon" };

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            // ViewBag.Product
            return View(product);
        }
        public IActionResult List()
        {
            var products = new List<Product>()
            {
                new Product { Name ="Iphone 7",Price =3000,Description="İyi Telefon",IsApproved=false},
                new Product { Name ="Iphone 8",Price =4000,Description="Çok iyi Telefon",IsApproved=true},
                new Product { Name ="Iphone X",Price =5000,Description="Çok iyi Telefon",IsApproved=true},
                new Product { Name ="Iphone 11",Price =7000,Description="Çok iyi Telefon"}
            };

            var category = new Category { Name = "Telefonlar", Description = "Telefon Kategorisi" };
            var productViewModel = new ProductViewModel()
            {
                Categori = category,
                Products = products
            };
            return View(productViewModel);
        }
        public IActionResult Details(int id)
        {
            // name: "samsung s6"
            // price: 3000
            // description: "iyi telefon"

            // ViewBag.Name = "samsung s6";
            // ViewBag.Price = 3000;
            // ViewBag.Description = "iyi telefon";

            var p = new Product();

            p.Name = "Samsung S6";
            p.Price = 3000;
            p.Description = "İyi Telefon";

            return View(p);
        }
    }
}
