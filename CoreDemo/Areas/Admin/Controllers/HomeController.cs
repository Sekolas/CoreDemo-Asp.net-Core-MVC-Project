﻿using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        [Route("Admin/[controller]/[action]")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
