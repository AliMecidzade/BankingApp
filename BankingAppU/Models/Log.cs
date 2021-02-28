using BankingAppU.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppU.Models
{
   public class Log : Entity
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string userEmail { get; set;  }
        public LogStatus LogStatus { get; set; }
    }
}
