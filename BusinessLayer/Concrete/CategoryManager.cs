using DataAccessLayer.Abstract;
using EntitiesLayer;
using NorthwindInterfaces;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    
        public class CategoryManager : ICategoryService
        {
            ICategoryDal _categoryDal;
            public CategoryManager(ICategoryDal categoryDal)
            {
                _categoryDal = categoryDal;
            }
            public void Add(Category category)
            {
                _categoryDal.Add(category);
            }

            public void Delete(int categoryId)
            {
                _categoryDal.Delete(categoryId);

            }
            public List<Category> GetAll()
            {
                return _categoryDal.GetAll();
            }

            public void Update(Category category)
            {
                _categoryDal.Update(category);
            }

            public Category GetById(int categoryId)
            {
                return _categoryDal.GetById(categoryId);

            }
        }
}
