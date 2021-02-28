using BankingAppU.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppU.Validation
{
   public class Validator
   {
        public void IsEmpty(string email, string password)
        {
           
            if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Please fill out all inputs");
            }
            
            
        }
        public void IsValidEmail(string email)
        {
            if (!email.Contains("@"))
            {
                throw new InvalidEmailException("Email must contains @!");
            }
        }
        public void IsValidPassword(string password)
        {
            if(password.Length < 5)
            {
                throw new InvalidPasswordException("Your password is too short!");
            }
        }
   }
}
