namespace BankingAppU.Forms
{
    partial class CardDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grbx_card = new System.Windows.Forms.GroupBox();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_bank = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_cvc = new System.Windows.Forms.Label();
            this.lbl_expiredDate = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.txbx_bank = new System.Windows.Forms.TextBox();
            this.txbx_duration = new System.Windows.Forms.TextBox();
            this.txbx_type = new System.Windows.Forms.TextBox();
            this.txbx_number = new System.Windows.Forms.TextBox();
            this.txbx_cvc = new System.Windows.Forms.TextBox();
            this.txbx_expiredDate = new System.Windows.Forms.TextBox();
            this.txbx_balance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grbx_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(535, 412);
            this.dataGridView2.TabIndex = 1;
            // 
            // grbx_card
            // 
            this.grbx_card.Controls.Add(this.txbx_balance);
            this.grbx_card.Controls.Add(this.txbx_expiredDate);
            this.grbx_card.Controls.Add(this.txbx_cvc);
            this.grbx_card.Controls.Add(this.txbx_number);
            this.grbx_card.Controls.Add(this.txbx_type);
            this.grbx_card.Controls.Add(this.txbx_duration);
            this.grbx_card.Controls.Add(this.txbx_bank);
            this.grbx_card.Controls.Add(this.lbl_balance);
            this.grbx_card.Controls.Add(this.lbl_expiredDate);
            this.grbx_card.Controls.Add(this.lbl_cvc);
            this.grbx_card.Controls.Add(this.label4);
            this.grbx_card.Controls.Add(this.lbl_duration);
            this.grbx_card.Controls.Add(this.lbl_bank);
            this.grbx_card.Controls.Add(this.lbl_number);
            this.grbx_card.Location = new System.Drawing.Point(582, 12);
            this.grbx_card.Name = "grbx_card";
            this.grbx_card.Size = new System.Drawing.Size(264, 276);
            this.grbx_card.TabIndex = 2;
            this.grbx_card.TabStop = false;
            this.grbx_card.Text = "Card";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(22, 127);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(53, 13);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number : ";
            // 
            // lbl_bank
            // 
            this.lbl_bank.AutoSize = true;
            this.lbl_bank.Location = new System.Drawing.Point(22, 35);
            this.lbl_bank.Name = "lbl_bank";
            this.lbl_bank.Size = new System.Drawing.Size(41, 13);
            this.lbl_bank.TabIndex = 1;
            this.lbl_bank.Text = "Bank : ";
            // 
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(22, 65);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(56, 13);
            this.lbl_duration.TabIndex = 2;
            this.lbl_duration.Text = "Duration : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type : ";
            // 
            // lbl_cvc
            // 
            this.lbl_cvc.AutoSize = true;
            this.lbl_cvc.Location = new System.Drawing.Point(22, 161);
            this.lbl_cvc.Name = "lbl_cvc";
            this.lbl_cvc.Size = new System.Drawing.Size(37, 13);
            this.lbl_cvc.TabIndex = 4;
            this.lbl_cvc.Text = "CVC : ";
            // 
            // lbl_expiredDate
            // 
            this.lbl_expiredDate.AutoSize = true;
            this.lbl_expiredDate.Location = new System.Drawing.Point(8, 195);
            this.lbl_expiredDate.Name = "lbl_expiredDate";
            this.lbl_expiredDate.Size = new System.Drawing.Size(77, 13);
            this.lbl_expiredDate.TabIndex = 5;
            this.lbl_expiredDate.Text = "Expired Date : ";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(22, 231);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(55, 13);
            this.lbl_balance.TabIndex = 6;
            this.lbl_balance.Text = "Balance : ";
            // 
            // txbx_bank
            // 
            this.txbx_bank.Enabled = false;
            this.txbx_bank.Location = new System.Drawing.Point(81, 32);
            this.txbx_bank.Name = "txbx_bank";
            this.txbx_bank.Size = new System.Drawing.Size(174, 20);
            this.txbx_bank.TabIndex = 7;
            // 
            // txbx_duration
            // 
            this.txbx_duration.Enabled = false;
            this.txbx_duration.Location = new System.Drawing.Point(81, 62);
            this.txbx_duration.Name = "txbx_duration";
            this.txbx_duration.Size = new System.Drawing.Size(174, 20);
            this.txbx_duration.TabIndex = 8;
            // 
            // txbx_type
            // 
            this.txbx_type.Enabled = false;
            this.txbx_type.Location = new System.Drawing.Point(80, 93);
            this.txbx_type.Name = "txbx_type";
            this.txbx_type.Size = new System.Drawing.Size(175, 20);
            this.txbx_type.TabIndex = 9;
            // 
            // txbx_number
            // 
            this.txbx_number.Enabled = false;
            this.txbx_number.Location = new System.Drawing.Point(81, 127);
            this.txbx_number.Name = "txbx_number";
            this.txbx_number.Size = new System.Drawing.Size(177, 20);
            this.txbx_number.TabIndex = 10;
            // 
            // txbx_cvc
            // 
            this.txbx_cvc.Enabled = false;
            this.txbx_cvc.Location = new System.Drawing.Point(80, 161);
            this.txbx_cvc.Name = "txbx_cvc";
            this.txbx_cvc.Size = new System.Drawing.Size(175, 20);
            this.txbx_cvc.TabIndex = 11;
            // 
            // txbx_expiredDate
            // 
            this.txbx_expiredDate.Enabled = false;
            this.txbx_expiredDate.Location = new System.Drawing.Point(80, 195);
            this.txbx_expiredDate.Name = "txbx_expiredDate";
            this.txbx_expiredDate.Size = new System.Drawing.Size(175, 20);
            this.txbx_expiredDate.TabIndex = 12;
            // 
            // txbx_balance
            // 
            this.txbx_balance.Enabled = false;
            this.txbx_balance.Location = new System.Drawing.Point(80, 228);
            this.txbx_balance.Name = "txbx_balance";
            this.txbx_balance.Size = new System.Drawing.Size(175, 20);
            this.txbx_balance.TabIndex = 13;
            // 
            // CardDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 436);
            this.Controls.Add(this.grbx_card);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CardDataForm";
            this.Text = "CardDataForm";
            this.Load += new System.EventHandler(this.CardDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbx_card.ResumeLayout(false);
            this.grbx_card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grbx_card;
        private System.Windows.Forms.TextBox txbx_balance;
        private System.Windows.Forms.TextBox txbx_expiredDate;
        private System.Windows.Forms.TextBox txbx_cvc;
        private System.Windows.Forms.TextBox txbx_number;
        private System.Windows.Forms.TextBox txbx_type;
        private System.Windows.Forms.TextBox txbx_duration;
        private System.Windows.Forms.TextBox txbx_bank;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_expiredDate;
        private System.Windows.Forms.Label lbl_cvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_bank;
        private System.Windows.Forms.Label lbl_number;
    }
}