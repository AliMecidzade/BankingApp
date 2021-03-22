using BankingAppU.Core;
using BankingAppU.Data;
using BankingAppU.Models;
using BankingAppU.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingAppU.Forms
{
    public partial class AdminPanel : Form
    {
        private readonly DbContext _dbContext;
        public AdminPanel()
        {
            InitializeComponent();
            _dbContext = Session.DbContext;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void link_users_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // read data
         
            using(DatabaseManager databaseManager = new DatabaseManager("myDb"))
            {
               
                dgv_data.DataSource = databaseManager.GetAllUsers().Where(u => u.UserRole == UserRole.User).
              Select(u => new { u.Id, FullName = $"{u.Name } {u.Surname}", u.Email }).ToList();
            }
           

        }

        private void link_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.AdminPanel = Session.AdminPanel ?? this;
            Session.IntroForm.Show();
        }

        private void link_cards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // read data
           // dgv_data.DataSource = _dbContext.Cards.GetAll().
            //    Select(c => new { c.Id, c.Number, c.Balance, c.CVC, c.Bank, c.CardType, c.CardHolder, c.ExpireDate }).
               //   ToList();
        }
    }
}
