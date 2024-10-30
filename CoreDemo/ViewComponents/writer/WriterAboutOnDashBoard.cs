using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace CoreDemo.ViewComponents.writer
{
    public class WriterAboutOnDashBoard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = wm.GetWriterById(2);
            return View(values);
        }
    }
}
