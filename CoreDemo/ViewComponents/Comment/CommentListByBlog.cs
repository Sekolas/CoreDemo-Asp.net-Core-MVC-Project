using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.comments
{
	public class CommentListByBlog:ViewComponent
	{
		CommentManagaer cm = new CommentManagaer(new EfCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var values = cm.Getlist(id);

			return View(values);
		}

	}
}
