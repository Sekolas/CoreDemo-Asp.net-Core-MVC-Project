using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using X.PagedList;
namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());

        public IActionResult Index(int page=1)
        {
            var values = cm.GetAll().ToPagedList(page, 3);
            return View(values);
        }
    }
}
