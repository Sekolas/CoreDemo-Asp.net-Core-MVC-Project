using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
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

		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult PartialAddComment(coments p)
		{
			p.CommentDate=DateTime.Parse(DateTime.Now.ToString());
			p.CommentStatus=true;
			p.BlogId = 2;
			cm.AddComment(p);
			return View();
		}

		public PartialViewResult CommentListByBlock(int id)
		{
			var values = cm.Getlist(id);
			return PartialView(values);
		}
	}
}
