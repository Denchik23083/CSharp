﻿using Microsoft.AspNetCore.Mvc;

namespace MvcEntity.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }
    }
}