using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class ErrorPageController1 : Controller
	{
		public IActionResult Error1(int code)
		{
			return View();
		}
	}
}
