﻿using AspNetCoreTask1.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }
        

    }
}
