using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.writer
{
    public class WriterNotification:ViewComponent
    {

        NotificationManager nm = new NotificationManager(new EfNoticitaionRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.GetAll();

            return View(values);
        }
    }
}

