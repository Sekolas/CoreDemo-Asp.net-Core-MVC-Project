using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManager bm=new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke(int id)
		{
			var values = bm.GetBlogListByWriter(id);
			return View(values);
		}
	}
}
