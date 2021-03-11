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
    public partial class CardManagerForm : Form
    {
        private readonly User _currentUser;
        private readonly DbContext _dbContext;
        public CardManagerForm()
        {
            InitializeComponent();
            _currentUser = Session.User;
            _dbContext = Session.DbContext;
        }

        private void CardManagerForm_Load(object sender, EventArgs e)
        {
          

        }

        private void btn_order_Click(object sender, EventArgs e)
        {

            string
             
              bank = cmbx_bank.Text,
              duration = cmbx_duration.Text,
              type = cmbx_type.Text;

            CardManager cardManager = new CardManager(bank, _currentUser);
            Card generatedCard = cardManager.GenerateCard(duration, type);
            ShowCardInfo(generatedCard);
            _currentUser.Cards.Append(generatedCard);
            _dbContext.Cards.Add(generatedCard);

        }
        private void ShowCardInfo(Card card)
        {
            txbx_cardNumber.Text = card.Number;
            txbx_cvc.Text = card.CVC;
            txbx_expiredDate.Text = card.ExpireDate.ToString();
        }
    }
}
