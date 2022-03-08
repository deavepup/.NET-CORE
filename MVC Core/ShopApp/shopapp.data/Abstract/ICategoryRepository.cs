using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
       List<Category> GetPopularCategories(); 
    }
}
