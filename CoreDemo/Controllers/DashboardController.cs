using DataAccesLayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.v1=c.Blogs.Count().ToString();
			ViewBag.v2 = c.Blogs.Where(x=>x.WriterID==2).Count().ToString();
			ViewBag.v3 = c.Categories.Count().ToString();

			return View();
        }
    }
}
