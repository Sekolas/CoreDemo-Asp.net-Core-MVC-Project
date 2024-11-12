using BussinesLayer.Concrete;
using DataAccesLayer.concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using System.ComponentModel.DataAnnotations;
using X.PagedList;
using FluentValidation.Results;
using BussinesLayer.ValidationRules;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory() {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p) {
            

            CategoryValidator bv = new CategoryValidator();
            FluentValidation.Results.ValidationResult result = bv.Validate(p);

            if (result.IsValid)
            {
                p.CategoryStatus = true;

                cm.TAdd(p);
                return RedirectToAction("Index","Category");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View("AddCategory");
  
        }
        public IActionResult CategoryDelete(int id)
        {
            var value = cm.TGetbyId(id);
            cm.TRemove(value);
            return RedirectToAction("Index", "Category", new { area = "Admin" });


        }
    }
}
