using BankingAppU.Core;
using BankingAppU.Data;
using BankingAppU.Models;
using BankingAppU.Roles;
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

    public partial class introForm : Form
    {
        private DbContext Dbcontext { get; set; }

        public introForm()
        {
            InitializeComponent();
            regControl.btn_sign.Text = "Sign Up";
            logControl.btn_sign.Text = "Sign In";

            regControl.btn_sign.Click += Btn_signUp_Click;
            logControl.btn_sign.Click += Btn_signIn_Click;
        }

        private void Btn_signIn_Click(object sender, EventArgs e)
        {
            string
                  email = logControl.txbx_email.Text,
                  password = logControl .txbx_password.Text;
            if (Dbcontext.Users.Any(u => u.Email == email && u.Password == password))
            {
                var currentUser = Dbcontext.Users.Get(u => u.Email == email && u.Password == password);
                Session.User = currentUser;
                Session.IntroForm =  Session.IntroForm ?? this;
                //new form opens
                Hide();
                new UserDashboard().ShowDialog();

            }
            else
            {
                MessageBox.Show("This user already exists");
            }


        }

        private void Btn_signUp_Click(object sender, EventArgs e)
        {
            string
                  email = regControl.txbx_email.Text,
                  password = regControl.txbx_password.Text;

         
            Dbcontext = new DbContext();
           if (Dbcontext.Users.Any(u => u.Email == email))
           {
                MessageBox.Show("User already exists");
            }
            else
            {
                User user = new User
                {
                 Id = Identificator<User>.GenerateId(),
                    Email = email,
                    Password = password,
                    UserRole = Roles.UserRole.User
                };
            }

        }

        private void logControl_Load(object sender, EventArgs e)
        {

        }
    }
}
