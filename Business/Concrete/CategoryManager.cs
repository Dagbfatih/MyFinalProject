using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        // Select - from Categories where CategoryId = 3
        public Category GelById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
