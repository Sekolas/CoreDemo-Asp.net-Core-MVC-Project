using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using System.Reflection.Metadata;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{

			var values = bm.GetBlockWithCategory();
			return View(values);
		}
		public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;
			var values = bm.GetBlogById(id);
			return View(values);
		}

		public IActionResult BlogListByWriter()
		{
			var values=bm.GetBlogListByWriter(2);
			return View(values);
		}
		[HttpGet]
        public IActionResult BlogAdd()
        {
			return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {

            BlogValidatör bv = new BlogValidatör();
            ValidationResult result = bv.Validate(p);

            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString();
                p.WriterID = 2;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

    }
}
