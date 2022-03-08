using shopapp.data.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopapp.data.Conctrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product,ShopContext>,IProductRepository
    {
        private ShopContext db = new ShopContext();
       public List<Product> GetPopularProducts()
        {
            using(var context = new ShopContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new NotImplementedException();
        }
    }
}
