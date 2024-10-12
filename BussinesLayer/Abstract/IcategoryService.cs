using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
    public interface IcategoryService
    {
        void AddCategory(Category category);
        void RemoveCategory(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetAllCategories();
        Category GetCategory(int id);
    }
}
