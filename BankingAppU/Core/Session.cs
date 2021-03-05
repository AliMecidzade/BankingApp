using BankingAppU.Data;
using BankingAppU.Forms;
using BankingAppU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppU.Core
{
   public static class Session
    { 
        public static DbContext DbContext { get; set; }
        public static User User { get; set; }
        public static introForm IntroForm { get;  set; }
    
        public static UserDashboard UserDashBoard { get;  set; }
        public static AdminPanel AdminPanel { get; internal set; }
    }
}
