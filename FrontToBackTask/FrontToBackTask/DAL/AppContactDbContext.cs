using FrontToBackTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackTask.DAL
{
    public class AppContactDbContext : DbContext
    {
        public DbSet<ContactForm> ContactForms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer("Server=localhost;database=PurpleBuzzDB;TrustServerCertificate=true;Trusted_Connection=true");
;
        }
    }
}
