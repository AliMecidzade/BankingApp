using BankingAppU.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppU.Models
{
    public class User : Entity
    {
        public User()
        {
            Cards = new HashSet<Card>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password  { get; set; }
        public UserRole UserRole { get; set; }
        public IEnumerable<Card> Cards { get; set; }
    }
}
