using ShopApp.WebUI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1, Name ="Iphone 7",Price =3000,Description="İyi Telefon",IsApproved=false,CategoryId=1,ImageUrl="1.jpg"},
                new Product {ProductId=2, Name ="Iphone 8",Price =4000,Description="Çok iyi Telefon",IsApproved=true,CategoryId=1,ImageUrl="2.jpg"},
                new Product {ProductId=3, Name ="Iphone X",Price =5000,Description="Çok iyi Telefon",IsApproved=true,CategoryId=1,ImageUrl="3.jpg"},
                new Product {ProductId=4, Name ="Iphone 11",Price =7000,Description="Çok iyi Telefon",CategoryId=1,ImageUrl="4.jpg"},

                new Product {ProductId=5, Name ="Lenovo",Price =3000,Description="İyi Bilgisayar",IsApproved=false,CategoryId=2,ImageUrl="lenovo.png"},
                new Product {ProductId=6, Name ="Msi",Price =4000,Description="Çok iyi Bilgisayar",IsApproved=true,CategoryId=2,ImageUrl="Msi.png"},
                new Product {ProductId=7, Name ="Asus",Price =5000,Description="Çok iyi Bilgisayar",IsApproved=true,CategoryId=2,ImageUrl="Asus.jpg"},
            };
        }
        public static List<Product> Products
        {
            get { return _products; }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {

            return _products.FirstOrDefault(x => x.ProductId == id);
        }public static Product GetProductLast()
        {

            return _products.LastOrDefault();
        }
        public static void EditProduct(Product product)
        {
            foreach (var p in _products)
            {
                if (product.ProductId ==p.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.Description= product.Description;
                    p.ImageUrl = product.ImageUrl;
                    p.IsApproved= product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }
        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

    }
}
