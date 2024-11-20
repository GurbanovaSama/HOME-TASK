using AspNetCoreTask1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTask1.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teacher = new Teacher()
            { 
                Id = 1,
                Name = "Narmin",
                Surname = "Shivakhanova"
            };

            Teacher teacher2 = new Teacher()
            {
                Id = 2,
                Name = "Vilayat",
                Surname = "Aliyev"
            };

           List<Teacher> teachers = new List<Teacher> { teacher, teacher2 };
            return View(teachers);
        }
    }
}
