using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.writer
{
    public class WriterMessageNotification:ViewComponent
    {
        
        MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p;
            p = "seko@gmail.com";
            var values = messageManager.GetInboxWithByWriter(p);
            return View(values);
        }
    }
}
