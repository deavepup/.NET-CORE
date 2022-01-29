using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System;
using System.Collections.Generic;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product { Name ="Iphone 7",Price =3000,Description="İyi Telefon",IsApproved=false},
                new Product { Name ="Iphone 8",Price =4000,Description="Çok iyi Telefon",IsApproved=true},
                new Product { Name ="Iphone X",Price =5000,Description="Çok iyi Telefon",IsApproved=true},
                new Product { Name ="Iphone 11",Price =7000,Description="Çok iyi Telefon"}
            };

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };
            return View(productViewModel);
        }

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
