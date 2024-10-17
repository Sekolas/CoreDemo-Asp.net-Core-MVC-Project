using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class LoginContoller : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
