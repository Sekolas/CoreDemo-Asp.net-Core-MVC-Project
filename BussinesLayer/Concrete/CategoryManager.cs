using BussinesLayer.Abstract;
using DataAccesLayer.abstracct;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;

namespace BussinesLayer.Concrete
{
    public class CategoryManager : IcategoryService
    {
        IcategoryDal _categoryDal;

        public CategoryManager(IcategoryDal categorydal)
        {
            _categoryDal = categorydal;
            
        }

        public List<Category> GetAll()
        {
           return _categoryDal.GetListAll();
        }

        public Category GetbyId(int id)
        {
           return _categoryDal.GetById(id);
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TRemove(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void Update(Category t)
        {
           _categoryDal.Update(t);
        }
    }
}
