using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingAppU.Models;
using System.Threading.Tasks;

namespace BankingAppU.Data
{
    public class DbContext
    {
        public DbSet<User> Users { get; private set; }
        public DbSet<Card> Cards { get; private set; }
        public DbSet<Log> Logs { get; private set; }

        public DbContext()
        {
            Users = new DbSet<User>();
            Cards = new DbSet<Card>();
            Logs = new DbSet<Log>();

        }
    }
}
