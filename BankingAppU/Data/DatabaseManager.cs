using BankingAppU.Models;
using BankingAppU.Roles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppU.Data
{
  public class DatabaseManager : IDisposable
    {
        private readonly SqlConnection _sqlConnection;

        public DatabaseManager(string connectionName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
        }
      
        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
         
        public IEnumerable<Card> GetCardsByUserId(int id)
        {
            return _GetCards(@"SELECT  [Id]
                              ,[Bank]
                              ,[CardNumber]
                              ,[CVC]
                              ,[Balance]
                              ,[CardType]
                              ,[DurationYears]
                              ,[ExpiredDate]
                              ,[CardHolder]
                              ,[UserId]
                          FROM [BankingAppDb].[dbo].[ufn_GetCardsByUserId(@userId)]", x => x.Parameters.AddWithValue("@userId", id));
        }

        public IEnumerable<User> GetAllUsers()
        {
     return _GetUsers(   @"SELECT    [Id]
                                           ,[Name]
                                     ,[Surname]
                             ,[Email]
                       ,[Password]
                    ,[UserType]
              FROM[BankingAppDb].[dbo].[uv_getUsers]" , null);
        }

        public IEnumerable<User> GetAllCards()
        {
            return _GetUsers(@"SELECT[Id]
                              ,[Bank]
                              ,[CardNumber]
                              ,[CVC]
                              ,[Balance]
                              ,[CardType]
                              ,[DurationYears]
                              ,[ExpiredDate]
                              ,[CardHolder]
                              ,[UserId]
                          FROM[BankingAppDb].[dbo].[uv_getCards]", null);
        }
        public User GetUserById(int id)
        {
            return _GetUsers(@"SELECT  [Id]
                              ,[Name]
                              ,[Surname]
                              ,[Email]
                              ,[Password]
                              ,[UserType]
                          FROM [BankingAppDb].[dbo].[ufn_GetUserById(@Id)]", null).FirstOrDefault();
        }

        public Card GetCardById(int id)
        {
            return _GetCards(@"SELECT  [Id]
                              ,[Bank]
                              ,[CardNumber]
                              ,[CVC]
                              ,[Balance]
                              ,[CardType]
                              ,[DurationYears]
                              ,[ExpiredDate]
                              ,[CardHolder]
                              ,[UserId]
                          FROM [BankingAppDb].[dbo].[ufn_GetCardById(@id)]", x => x.Parameters.AddWithValue("@id" , id)).FirstOrDefault();
        }
        private IEnumerable<User> _GetUsers(string query,Action<SqlCommand> action )
        {
            List<User> users = new List<User>();


            using (SqlCommand sqlCommand = new SqlCommand(query,_sqlConnection))
            {
                action(sqlCommand);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        users.Add(new User
                        {
                            Id = Convert.ToInt32(sqlDataReader["Id"]),
                            Name = sqlDataReader["Name"].ToString(),
                            Surname = sqlDataReader["Surname"].ToString(),
                            Email = sqlDataReader["Email"].ToString(),
                            Password = sqlDataReader["Password"].ToString(),
                            UserRole = (UserRole)Enum.Parse(typeof(UserRole), sqlDataReader["UserType"].ToString())
                        });

                    }
                }
            }
            return users;
            
            
         
        }

        private IEnumerable<Card> _GetCards(string query, Action<SqlCommand> action)
        {
            List<Card> cards = new List<Card>();


            using (SqlCommand sqlCommand = new SqlCommand(query, _sqlConnection))
            {
                action(sqlCommand);
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        cards.Add(new Card
                        {
                           Id = Convert.ToInt32(sqlDataReader["Id"]),
                            Bank = (BankName)Enum.Parse(typeof(BankName), sqlDataReader["Bank"].ToString()),
                            Duration = (CardDuration)Enum.Parse(typeof(CardDuration), sqlDataReader["DurationYears"].ToString()),
                            CardType = (CardType)Enum.Parse(typeof(CardType), sqlDataReader["CardType"].ToString()),
                            Number = sqlDataReader["CardNumber"].ToString(),
                            CVC = sqlDataReader["CVC"].ToString(),
                            ExpireDate = (DateTime)sqlDataReader["ExpiredDate"],
                            CardHolder = sqlDataReader["CardHolder"].ToString(),
                            Balance = Convert.ToDecimal(sqlDataReader["Balance"]),
                           UserId = Convert.ToInt32(sqlDataReader["UserId"])
                        });

                    }
                }
            }
            return cards;



        }

        public void Adduser(User user)
        {
            string command = "INSERT INTO Users(Name, Surname , Email, Password , UserType) VALUES(@n , @s , @em , @p , @ut)";
            using (SqlCommand sqlCom = new SqlCommand(command , _sqlConnection))
            {
                sqlCom.Parameters.AddWithValue("@n", user.Name);
                sqlCom.Parameters.AddWithValue("@s", user.Surname);
                sqlCom.Parameters.AddWithValue("@em", user.Email);
                sqlCom.Parameters.AddWithValue("@p", user.Password);
                sqlCom.Parameters.AddWithValue("@ut", user.UserRole.ToString());
            }
        }
    }
}
