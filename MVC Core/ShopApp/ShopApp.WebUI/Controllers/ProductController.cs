using Microsoft.AspNetCore.Mvc;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int id)
        {

            return View();
        }
        public IActionResult Details(int id)
        {

            return View();
        }
    }
}
