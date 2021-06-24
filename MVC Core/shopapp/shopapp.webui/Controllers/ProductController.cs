using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            // ViewBag.Name="Samsung S6";
            // ViewBag.Price=3000;
            // ViewBag.Description="İyi";

             var p = new Product();
             p.Name="Samsung S6";
             p.Price=3000;
             p.Description="İyi";
            return View(p);


        }
    }
}
