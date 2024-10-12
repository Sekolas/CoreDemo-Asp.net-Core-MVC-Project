using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
	public interface IBlogService
	{
		void AddBlog(Blog category);
		void RemoveBlog(Blog category);
		void BlogUpdate(Blog category);
		List<Blog> GetList();
		Blog GetById (int id);
	}
}
