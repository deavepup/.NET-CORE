using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Data;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
            var product = new Product {Name="Iphone X",Price=6000,Description="güzel telefon"};

            // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            // ViewBag.Product
            return View(product);
        }
        // product/list => tüm ürünleri (sayfalama)
        // product/list/2 => 2 numaralı kategoriye ait ürünler
        public IActionResult list(int? id,string q,double? min_price,double? max_price) 
        {
            // {controller}/{action}/{id?}
            // product/list/3
            // RouteData.Values["controller"] => product
            // RouteData.Values["action"] => list
            // RouteData.Values["id"] => 3

            // Console.WriteLine(RouteData.Values["controller"]);
            // Console.WriteLine(RouteData.Values["action"]);
            // Console.WriteLine(RouteData.Values["id"]);

            // QueryString
            // Console.WriteLine(q);
            // Console.WriteLine(HttpContext.Request.Query["q"].ToString());
            // Console.WriteLine(HttpContext.Request.Query["min_price"].ToString());

            var products = ProductRepository.Products;

            if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i=>i.Name.Contains(q) || i.Description.Contains(q)).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products =products
            };

            return View(productViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }
    }
}