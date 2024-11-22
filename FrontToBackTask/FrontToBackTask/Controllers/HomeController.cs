using FrontToBackTask.DAL;
using FrontToBackTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _context;
        public HomeController(AppDbContext appDbContext)
        {
            _context = appDbContext;    
        }
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
            //Team team1 = new Team() 
            //{ 
            //    Name = "John Doe",
            //    Role = "Business Development",
            //    MainImageUrl = "team-01.jpg"
            //};

            //Team team2 = new Team()
            //{
            //    Name = "Jane Doe",
            //    Role = "Media Development",
            //    MainImageUrl = "team-02.jpg"
            //};

            //Team team3 = new Team()
            //{
            //    Name = "Sam",
            //    Role = "Developer",
            //    MainImageUrl = "team-03.jpg"
            //};

           
            //_context.teams.Add(team1);
            //_context.teams.Add(team2);
            //_context.teams.Add(team3);

            IEnumerable<Team> teams
                =_context.teams.ToList();

       

            return View(teams);
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
