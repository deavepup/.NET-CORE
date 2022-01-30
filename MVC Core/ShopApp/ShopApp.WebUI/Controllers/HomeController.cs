using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
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

            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
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
