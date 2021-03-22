using BankingAppU.Components;
using BankingAppU.Core;
using BankingAppU.Data;
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

namespace BankingAppU.Forms
{
    public partial class UserConfigurationForm : Form
    {
        private User _user;
        private DatabaseManager _db;
        public UserConfigurationForm()
        {
            _dbcontext = Session.DbContext;
            InitializeComponent();
            if (Session.User != null)
            {
                _user = Session.User;
            }
            else
            {
                MessageBox.Show("404 not found");
                Close();
            }
           
            //credentials Control
            credentialsControl.btn_sign.Text = "Update Info";
            credentialsControl.btn_sign.Click += Btn_updateUser_Click;
            credentialsControl.txbx_email.Enabled = false;
        }

        private void Btn_updateUser_Click(object sender, EventArgs e)
        {
            UpdateUser(_user);

            // update data
           
            MessageBox.Show("Success");
        }

        private void UserConfigurationForm_Load(object sender, EventArgs e)
        {
            ShowUserInfo(_user);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ShowUserInfo(User user)
        {
            txbx_name.Text = user.Name;
            txbx_surname.Text = user.Surname;
            credentialsControl.txbx_email.Text = user.Email;
            credentialsControl.txbx_password.Text = user.Password;
        }
        private void UpdateUser(User user)
        {
            user.Name = txbx_name.Text;
            user.Surname = txbx_surname.Text;
            user.Password = credentialsControl.txbx_password.Text;
            
        }
    }
}
