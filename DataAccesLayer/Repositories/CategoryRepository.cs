using DataAccesLayer.abstracct;
using DataAccesLayer.concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class CategoryRepository : IcategoryDal
    {
        Context c=new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();  
        }

        public Category GetbyId(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }
    }
}
