using DataAccesLayer.abstracct;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
	public interface IBlogService:IgenericService<Blog>
	{
		List<Blog> GetBlockWithCategory();

		List<Blog> GetBlogListByWriter(int id);
		public List<Blog> GetBlogById(int id);


    }
}
