using ShopApp.WebUI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp.WebUI.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1, Name = "Telefonlar", Description = "Telefon Kategorisi" },
                new Category {CategoryId=2, Name = "Bilgisayar", Description = "Bilgisayar Kategorisi" },
                new Category {CategoryId=3, Name = "Elektronik", Description = "Elektronik Kategorisi" }
            };
        }
        public static List<Category> Categories
        {
            get { return _categories; }
        }

        public static void AddProduct(Category category)
        {
            _categories.Add(category);
        }
        public static Category GetProductById(int id)
        {

            return _categories.FirstOrDefault(x => x.CategoryId == id);
        }
    }
}
