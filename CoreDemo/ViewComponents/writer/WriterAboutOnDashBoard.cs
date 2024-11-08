using BussinesLayer.Concrete;
using DataAccesLayer.concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace CoreDemo.ViewComponents.writer
{
    public class WriterAboutOnDashBoard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            
            var writerID=c.Writers.Where(x=>x.WriterMail==usermail).Select(y=>y.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
