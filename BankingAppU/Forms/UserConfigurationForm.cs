using BankingAppU.Components;
using BankingAppU.Core;
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
        public UserConfigurationForm()
        {
            InitializeComponent();
            _user = Session.User != null ? Session.User : null; MessageBox.Show("404 Not Found!");
            Close();
            //credentials Control
            credentialsControl.btn_sign.Text = "Update Info";
            credentialsControl.btn_sign.Click += Btn_updateUser_Click;
            credentialsControl.txbx_email.Enabled = false;
        }

        private void Btn_updateUser_Click(object sender, EventArgs e)
        {

        }

        private void UserConfigurationForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ShowUserInfo(User user)
        {
            txbx_name.Text = user.Name;
            txbx_surname.Text = user.Surname;
            credentialsControl.Text = txbx_email.Text = user.Email;
            credentialsControl.Text = txbx_password.Text = user.Password;
        }
    }
}
