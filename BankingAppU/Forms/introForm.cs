using BankingAppU.Core;
using BankingAppU.Data;
using BankingAppU.Exceptions;
using BankingAppU.Models;
using BankingAppU.Roles;
using BankingAppU.Validation;
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
        Validator _validator;
        public introForm()
        {
            InitializeComponent();
            regControl.btn_sign.Text = "Sign Up";
            logControl.btn_sign.Text = "Sign In";

            regControl.btn_sign.Click += Btn_signUp_Click;
            logControl.btn_sign.Click += Btn_signIn_Click;

            logControl.txbx_password.UseSystemPasswordChar = true;
            regControl.txbx_password.UseSystemPasswordChar = true;
           _validator  = new Validator();

        }

        private void Btn_signIn_Click(object sender, EventArgs e)
        {
            string
                  email = logControl.txbx_email.Text,
                  password = logControl .txbx_password.Text;
            //validation
            try
            {
                _validator.IsEmpty(email,password);
                _validator.IsValidEmail(email);
                _validator.IsValidPassword(password);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill out all inputs");
            }
            catch (InvalidEmailException)
            {
                MessageBox.Show("Email must contains @!");
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("Your password is too short!");
            }

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
                MessageBox.Show("This user does not exists");
            }


        }

        private void Btn_signUp_Click(object sender, EventArgs e)
        {
            string
                  email = regControl.txbx_email.Text,
                  password = regControl.txbx_password.Text;
            //Validation
            try
            {
                _validator.IsEmpty(email, password);
                _validator.IsValidEmail(email);
                _validator.IsValidPassword(password);
            }
           catch (ArgumentNullException)
            {
                MessageBox.Show("Please fill out all inputs");
            }
            catch (InvalidEmailException)
            {
                MessageBox.Show("Email must contains @!");
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("Your password is too short!");
            }
            Dbcontext = new DbContext();
           if (Dbcontext.Users.Any(u => u.Email == email))
           {
                MessageBox.Show("User already exists");
            }
            else
            {
                User user = new User
                {
                 Id = Identificator<User>.GenerateId().ToString(),
                    Email = email,
                    Password = password,
                    UserRole = Roles.UserRole.User
                };
            }

        }

        private void logControl_Load(object sender, EventArgs e)
        {

        }

        private void regControl_Load(object sender, EventArgs e)
        {

        }
    }
}
