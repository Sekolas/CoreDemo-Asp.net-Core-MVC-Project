using BussinesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager messageManager = new Message2Manager(new EfMessage2Repository());

        public IActionResult Inbox()
        {
            int id = 2;
            var values = messageManager.GetInboxWithByWriter(id);
            return View(values);
            
        }
		public IActionResult MessageDetails(int id)
		{
			var value=messageManager.TGetbyId(id);


			return View(value);

		}
	}
}
