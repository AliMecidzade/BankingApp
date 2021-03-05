﻿using BankingAppU.Core;
using BankingAppU.Data;
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
            dgv_data.DataSource = _dbContext.Users.GetAll().Where(u => u.UserRole == Roles.UserRole.User).
                Select(u => new { u.Id, FullName = $"{u.Name } {u.Surname}", u.Email }).ToList();
        }

        private void link_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.AdminPanel = Session.AdminPanel ?? this;
            Session.IntroForm.ShowDialog();
        }

      
    }
}
