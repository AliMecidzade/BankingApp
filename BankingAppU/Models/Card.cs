using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppU.Models
{
   public class Card : Entity
    {
        public BankName Bank { get; set; }
        public CardDuration Duration { get; set; }
        public CardType CardType { get; set; }
        public string Number { get; set; }
        public string CVC { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CardHolder { get; set; }
        public decimal Balance { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
