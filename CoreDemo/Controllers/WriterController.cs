using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
   
    public class WriterController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
		[AllowAnonymous]
		public IActionResult WriterProfile()
        {
            return View();
        }
		[AllowAnonymous]
		public IActionResult WriterMail()
        {
            return View();
        }
    }
}
