using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class blablaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
