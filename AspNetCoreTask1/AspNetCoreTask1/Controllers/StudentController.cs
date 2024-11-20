using AspNetCoreTask1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTask1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Sema",
                Age = 20
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Test",
                Age = 19
            };
            List<Student> students = new List<Student>() { student, student2 };


            return View(students);
        }
    }
}
