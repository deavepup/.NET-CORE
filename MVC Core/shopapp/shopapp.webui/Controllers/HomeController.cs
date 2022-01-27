using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {      
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 7",Price=3000,Description="iyi telefon",IsApproved=false},
                new Product {Name="Iphone 8",Price=4000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone X",Price=5000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone 11",Price=7000,Description="çok iyi telefon"},
            };

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

         // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

         public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}