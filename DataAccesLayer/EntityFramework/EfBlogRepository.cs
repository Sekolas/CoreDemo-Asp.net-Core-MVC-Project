using DataAccesLayer.abstracct;
using DataAccesLayer.concrete;
using DataAccesLayer.Repositories;
using EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c =new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }
    }
}
