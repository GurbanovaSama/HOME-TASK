using FrontToBackTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>()
            { 
                new User() { Id = 1, Name = "Xalide" },
                new User() { Id = 2, Name = "Xeyale" }
            };
            ViewData["users"] = "null";
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Work()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
