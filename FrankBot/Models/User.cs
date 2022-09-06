using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrankBot.Models
{
    public class User
    {
        public int Id { get; set; }
        public long ChatId { get; set; }
        public List<User> Users { get; set; } = new();
    }
}
