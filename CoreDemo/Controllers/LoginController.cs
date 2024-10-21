using DataAccesLayer.concrete;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDemo.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
			public IActionResult Index() { return View(); }
		[HttpPost]
		[AllowAnonymous]

		public async Task<IActionResult> Index(Writer writer)
		{
			Context c = new Context();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
			if (datavalue != null)
			{
				var claims = new List<Claim>()
				{
					new Claim(ClaimTypes.Name,writer.WriterMail)
				};
				var useridenmtity = new ClaimsIdentity(claims, "a");
				ClaimsPrincipal user = new ClaimsPrincipal(useridenmtity);
				await HttpContext.SignInAsync(user);
				return RedirectToAction("Index", "Writer");
			}
			else
			{
				return View();
			}

		}
	}
}
