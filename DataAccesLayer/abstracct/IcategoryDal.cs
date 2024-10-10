using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.abstracct
{
    public interface IcategoryDal
    {
        List<Category> ListAllCategory();
        void AddCategory(Category category);
        void DeleteCategory(Category category);

        void UpdateCategory(Category category);

        Category GetbyId(int id);






    }
}
