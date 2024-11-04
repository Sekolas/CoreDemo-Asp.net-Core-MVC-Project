using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        NotificationManager nm=new NotificationManager(new EfNoticitaionRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllNotificaiton()
        {
            var values = nm.GetAll();
            return View(values);
        }
    }
}
