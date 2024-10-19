using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {

        NewsletterManager nw = new NewsletterManager(new EfNewsletterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus =true;
            nw.AddNewsLetter(p);
            return View();
            
        }
    }
}
