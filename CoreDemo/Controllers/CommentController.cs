using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{

		CommentManagaer cm = new CommentManagaer(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

		public PartialViewResult CommentListByBlock(int id)
		{
			var values = cm.Getlist(id);
			return PartialView(values);
		}
	}
}
