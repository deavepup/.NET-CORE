using System;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.Controllers
{
    // localhost:5000/home
    public class HomeController:Controller
    {
        // localhost:5000
        // localhost:5000/home
        // localhost:5000/home/index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat>12?"İyi Günler":"Günaydın";
            ViewBag.UserName = "Sadık";

            return View();
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