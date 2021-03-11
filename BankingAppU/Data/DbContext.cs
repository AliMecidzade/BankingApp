using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingAppU.Models;
using System.Threading.Tasks;
using BankingAppU.Forms;

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
            AddDefaultUsers();
            AddDefaultCards();

        }
        public void AddDefaultUsers()
        {
            Users.Add(new User
            {
                Id = Identificator<User>.GenerateId(),
                Name = "Admin",
                Surname = "Adminov",
                Email = "admin@",
                Password = "123456",
                UserRole = Roles.UserRole.Admin
            }

               );
            Users.Add(new User
            {
                Id = Identificator<User>.GenerateId(),
                Name = "Ali",
                Surname = "Mecidzade",
                Email = "ali@gmail.com",
                Password = "123456",
                UserRole = Roles.UserRole.User
            }

                ); 
        }
        private void AddDefaultCards()
        {
            Card card = new CardManager("KapitalBank" , Users.Get(x => x.Id == 2)).GenerateCard("2", "Debet");
            Cards.Add(card);
        }
    }
}
    

