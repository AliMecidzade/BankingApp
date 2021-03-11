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
    public partial class CardDataForm : Form
    {
        private readonly User _currentUser;
        public readonly DbContext _dbContext;
        public CardDataForm()
        {
            InitializeComponent();
            _dbContext = Session.DbContext;
            _currentUser = Session.User;
        }

        private void CardDataForm_Load(object sender, EventArgs e)
        {

            dgv_cards.DataSource = _dbContext.Cards.GetAll(card => card.User.Id == _currentUser.Id).
                Select(c => new { c.Id, c.Number,c.Balance, c.CVC,  c.Bank, c.CardType, c.CardHolder, c.ExpireDate }).
                  ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_cards_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (int.TryParse((dgv_cards[e.ColumnIndex, e.RowIndex].Value).ToString(), out int idValue))
            {
                if (_dbContext.Cards.GetAll().Any(x => x.Id == idValue))
                {
                    ShowCardInfo(idValue);
                }
            }
        }

        private void ShowCardInfo(int value)
        {
            Card card = _dbContext.Cards.Get(c => c.Id == value);
            txbx_bank.Text = card.Bank.ToString();
            txbx_number.Text = card.Number;
            txbx_type.Text = card.CardType.ToString();
            txbx_expiredDate.Text = card.ExpireDate.ToString();
            txbx_balance.Text = card.Balance.ToString();
            txbx_cvc.Text = card.CVC;
            txbx_duration.Text = card.Duration.ToString();
            
        }
    }
}
