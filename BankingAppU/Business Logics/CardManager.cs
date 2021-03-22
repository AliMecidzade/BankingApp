using BankingAppU.Models;
using System;
using System.Text;

namespace BankingAppU.Forms
{
    public class CardManager
    {
        private string _bank;
        private User _user;
        private Random _numberGenerator;
        public CardManager(string bank, User user)
        {
            _user = user;
            _numberGenerator = new Random();
            _bank = bank;
        }



        public Card GenerateCard(string duration, string type)
        {
            return new Card
            {
               
                Bank = (BankName)Enum.Parse(typeof(BankName), _bank),
                Duration = (CardDuration)Enum.Parse(typeof(CardDuration), duration),
                CardType = (CardType)Enum.Parse(typeof(CardType), type),
                Number = GenerateCardNumber(),
                CVC = GenerateCVC(),
                ExpireDate = GetExpiredDate(duration),
                CardHolder = $"{_user.Name} {_user.Surname}",
                Balance = 0, 
                User = _user
            };
        }
            private DateTime GetExpiredDate(string duration)
            {
            var exprDate = DateTime.Now;
           exprDate = exprDate.AddYears(int.Parse(duration));
            return exprDate;
            
            }

            private string GenerateCVC()
            {
            return _numberGenerator.Next(100,999).ToString();
            }

            private string GenerateCardNumber()
            {
            StringBuilder number = new StringBuilder();
            number.Append(_numberGenerator.Next(1000, 9999));
            for (int i = 2; i <= 4; i++)
            {
                number.Append(" " + _numberGenerator.Next(1000, 9999));

            }
            return number.ToString();
            }

        }
    }
