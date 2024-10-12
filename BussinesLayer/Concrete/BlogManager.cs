using BussinesLayer.Abstract;
using DataAccesLayer.abstracct;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal=blogdal;
        }
        public void AddBlog(Blog category)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog category)
		{
			throw new NotImplementedException();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetList()
		{
			return _blogdal.GetListAll();
		}

		public void RemoveBlog(Blog category)
		{
			throw new NotImplementedException();
		}
	}
}
