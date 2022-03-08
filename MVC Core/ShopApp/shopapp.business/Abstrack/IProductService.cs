using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstrack
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
