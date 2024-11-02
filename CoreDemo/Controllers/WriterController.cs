using BussinesLayer.Concrete;
using BussinesLayer.ValidationRules;
using CoreDemo.Models;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager vm=new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult writernavbar()
        {
            return PartialView();
        }

        public PartialViewResult footerPartial()
        {
            {
                return PartialView();
            }
        }
        
        public IActionResult WriterEditProfile() {
            var values = vm.TGetbyId(2);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidatör wl=new WriterValidatör();
            FluentValidation.Results.ValidationResult validationResult = wl.Validate(p);

            if (validationResult.IsValid)
            {
                p.WriterStatus = true;
                vm.Update(p); 
                
                return RedirectToAction("Index", "Dashboard");

            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w=new Writer();
            if (p.writerImage != null) {
                var extension = Path.GetExtension(p.writerImage.FileName);
                var newimagename=Guid.NewGuid()+extension;
                var location=Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/"+newimagename);
                var stream=new FileStream(location,FileMode.Create);
                p.writerImage.CopyTo(stream);
                w.writerImage=newimagename;
            
            }
            w.WriterMail = p.WriterMail;
            w.WriterAbout = p.WriterAbout;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus= p.WriterStatus;
            vm.TAdd(w);
            return View();
        }
    }
}


