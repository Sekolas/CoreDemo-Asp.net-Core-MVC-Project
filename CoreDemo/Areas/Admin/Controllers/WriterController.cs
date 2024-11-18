using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]

	public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
