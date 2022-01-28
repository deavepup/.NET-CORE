using Microsoft.AspNetCore.Mvc;
using System;
namespace ShopApp.WebUI.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
           int saat= DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Hüseyin";
              return View();
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
