using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.abstracct
{
    public interface IBlogDal
    {
        List<Blog> ListAllCategory();
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);

        void DeletUpdateBlog(Blog blog);

        Blog GetbyId(int id);
    }
}
