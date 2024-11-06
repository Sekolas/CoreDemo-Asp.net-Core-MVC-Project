using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.writer
{
    public class WriterMessageNotification:ViewComponent
    {
        
        Message2Manager messageManager = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id=2;
            var values = messageManager.GetInboxWithByWriter(id);
            return View(values);
        }
    }
}
