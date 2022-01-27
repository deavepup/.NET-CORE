using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category {Name="Telefon",Description="Telefon Kategorisi"},
                new Category {Name="Bilgisayar",Description="Bilgisayar Kategorisi"},
                new Category {Name="Elektronik",Description="Elektronik Kategorisi"}
            };

            return View(categories);
        }
    }
}