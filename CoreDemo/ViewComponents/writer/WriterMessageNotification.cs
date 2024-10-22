using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.writer
{
    public class WriterMessageNotification:ViewComponent
    {
        CommentManagaer cm = new CommentManagaer(new EfCommentRepository());

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
