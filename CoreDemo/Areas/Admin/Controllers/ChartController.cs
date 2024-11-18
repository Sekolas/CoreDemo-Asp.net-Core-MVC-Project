using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ChartController : Controller
	{

        public IActionResult Index()
		{
			return View();
		}
		public IActionResult CategoryChart()
		{
			List<Categoryclass> list=new List<Categoryclass>();
			list.Add(new Categoryclass
			{
				Categoryname = "teknoloji",
				CategoryCount = 10
			});
			list.Add(new Categoryclass
			{
				Categoryname = "yazılım",
				CategoryCount = 14
			});
			list.Add(new Categoryclass
			{
				Categoryname = "spor",
				CategoryCount = 5
			});
			return Json(new {jsonlist=list});
		}
	}
}

