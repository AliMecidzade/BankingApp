using BankingAppU.Core;
using BankingAppU.Forms;
using BankingAppU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingAppU
{
    public partial class UserDashboard : Form
    {
        private readonly User _user;
        public UserDashboard()
        {
            InitializeComponent();
            if (Session.User != null)
            {
                _user = Session.User;
            }
            else
            {
                MessageBox.Show("404 Not Found!");
                Close();
            }
          
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
        
                ShowUserInfo(_user);
            
        }
        private void ShowUserInfo(User user)
        {
            lbl_name.Text = user.Name;
            lbl_surname.Text = user.Surname;
            lbl_email.Text = user.Email;
        }

        private void link_settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UserConfigurationForm().ShowDialog();
        }

        private void link_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserDashboard_Load(sender, e);
        }

        private void link_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.UserDashBoard = Session.UserDashBoard ?? this;
            Session.IntroForm.ShowDialog();

        }

        private void link_order_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardManagerForm().ShowDialog();
        }

        private void link_myCards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardDataForm().ShowDialog();
        }
    }
}
