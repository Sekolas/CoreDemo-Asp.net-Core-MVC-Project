using CoreDemo.Models;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterUserController : Controller
	{

		private readonly UserManager<AppUser> _usermanager;

        public RegisterUserController(UserManager<AppUser> usermanager)
        {
			_usermanager=usermanager;
            
        }
		[HttpGet]
        public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task <IActionResult> Index(UserSignUpViewModel p)
		{
			if (ModelState.IsValid) {
				AppUser user = new AppUser()
				{
					Email = p.Mail,
					UserName = p.UserName,
					NameSurname = p.NameSurname

				};
				var result = await _usermanager.CreateAsync(user);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Login");
				}
				else {
					foreach (var item in result.Errors) {
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(p);
		}
	}
}
