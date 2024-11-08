using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccesLayer.concrete;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());

        CategoryManager cm=new CategoryManager(new EfCategoryRepository());
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
            var usermail = User.Identity.Name;
            Context c=new Context();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bm.Test(writerID);
			return View(values);
		}
		[HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues=(from x in cm.GetAll() select new SelectListItem
            {
                    Text=x.CategoryName,
                    Value=x.CategoryId.ToString()
            }).ToList();
			return View(categoryvalues);
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            var usermail = User.Identity.Name;
            Context c = new Context();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            BlogValidatör bv = new BlogValidatör();
            ValidationResult result = bv.Validate(p);

            if (result.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString();
                p.WriterID = writerID;
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
        public IActionResult BlogDelete(int id) {
            var blogvalue=bm.TGetbyId(id);
            bm.TRemove(blogvalue);
            return RedirectToAction("BlogListByWriter");

        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryvalues=(from x in cm.GetAll() select new SelectListItem
            {
                    Text=x.CategoryName,
                    Value=x.CategoryId.ToString()
            }).ToList();
            var blogvalue = bm.TGetbyId(id);
            ViewBag.Categories=categoryvalues;
            

            return View(blogvalue);

        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {

            p.WriterID = 2;
            p.BlogStatus=true;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString();
            bm.Update(p);
            return RedirectToAction("BlogListByWriter", "Blog");
        }


    }
}
