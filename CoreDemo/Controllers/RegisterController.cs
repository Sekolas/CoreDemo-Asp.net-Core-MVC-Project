using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
using FluentValidation.Results;
using FluentValidation.TestHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{

		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{

			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer p)
		{
			WriterValidatör wv = new WriterValidatör();
			ValidationResult result = wv.Validate(p);

			if (result.IsValid)
			{
				p.WriterStatus = true;
				p.WriterAbout = "Deneme test";
				wm.WriterAdd(p);
				return RedirectToAction("Index", "Blog");

			}
			else
			{
				foreach(var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();

			
		}
	}
}
