using BussinesLayer.Concrete;
using DataAccesLayer.concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class statistic2:ViewComponent
    {
        Context c = new Context();
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
           



            return View();
        }
    }
}
