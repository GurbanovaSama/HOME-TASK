using FrontToBackTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FrontToBackTask.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
       

     
        public DbSet<Team> teams { get; set; }  
        
    }
}






