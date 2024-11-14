using BussinesLayer.Concrete;
using DataAccesLayer.concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Viewcomponent.Statistic
{
    public class statisctic1 : ViewComponent
    {
        Context c = new Context();
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetAll().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Writers.Count();

            return View();
        }

    }
}
