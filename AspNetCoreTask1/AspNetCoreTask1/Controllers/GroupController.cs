using AspNetCoreTask1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTask1.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            Group group = new Group()
            {
                Id = 1,
                Name = "AB205",
                Description = "Backend tedris olunur"
            };

            Group group2 = new Group()
            {
                Id = 2,
                Name = "AF105",
                Description = "Frontend tedris olunur"
            };
             List<Group> groups = new List<Group>() { group, group2 };
            return View(groups);    
        }
    }
}
