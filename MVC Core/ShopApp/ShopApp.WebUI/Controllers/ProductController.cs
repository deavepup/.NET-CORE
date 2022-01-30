using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Data;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };
            return View(productViewModel);
        }
        public IActionResult List(int? id,string q)
        {
            var products = ProductRepository.Products;
            if (id !=null)
            {
                products = products.Where(x => x.CategoryId == id).ToList();
            }
            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(x => x.Name.ToLower().Contains(q.ToLower()) || x.Description.ToLower().Contains(q.ToLower())).ToList();
            }
            var productViewModel = new ProductViewModel()
            {
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

            //var p = new Product();

            //p.Name = "Samsung S6";
            //p.Price = 3000;
            //p.Description = "İyi Telefon";
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return View(ProductRepository.GetProductById(id));
            }
        }
    }
}
