using BussinesLayer.Abstract;
using DataAccesLayer.abstracct;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;

namespace BussinesLayer.Concrete
{
    public class CategoryManager : IcategoryService
    {
        IcategoryDal _categoryDal;

        public CategoryManager(IcategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
            
        }
        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);

        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetListAll();
        }

        public Category GetCategory(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void RemoveCategory(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
