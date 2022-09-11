using FrankBot.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace FrankBot
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public AppDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("",
                new MySqlServerVersion(new Version(8, 0, 30)));
        }
    }
}
