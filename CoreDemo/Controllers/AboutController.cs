using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class AboutController : Controller
	{
		AboutManager ab=new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
            var values = ab.Getlist();
            
            return View(values);
		}

		
		public PartialViewResult SocialMediaAbout() {
            return PartialView();

        }

    }
}
