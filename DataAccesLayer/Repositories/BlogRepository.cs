using DataAccesLayer.abstracct;
using DataAccesLayer.concrete;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    internal class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var c = new Context();

            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();

            c.Remove(blog);
            c.SaveChanges();
        }

        public void DeletUpdateBlog(Blog blog)
        {
            using var c = new Context();

            c.Update(blog);
            c.SaveChanges();
        }

        public Blog GetbyId(int id)
        {
            using var c = new Context();

            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllCategory()
        {
            using var c = new Context();

            return c.Blogs.ToList();
        }
    }
}
