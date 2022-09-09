using FrankBot.Models;
using Microsoft.EntityFrameworkCore;

namespace FrankBot
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FrankUsers;Trusted_Connection=True;");
        }
    }
}
