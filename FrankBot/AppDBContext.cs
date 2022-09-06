using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrankBot.Models;
using Microsoft.EntityFrameworkCore;

namespace FrankBot
{
    public class AppDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
