namespace BankingAppU.Forms
{
    partial class CardManagerForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbx_card = new System.Windows.Forms.GroupBox();
            this.cmbx_type = new System.Windows.Forms.ComboBox();
            this.cmbx_duration = new System.Windows.Forms.ComboBox();
            this.cmbx_bank = new System.Windows.Forms.ComboBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.txbx_expiredDate = new System.Windows.Forms.TextBox();
            this.txbx_cvc = new System.Windows.Forms.TextBox();
            this.txbx_number = new System.Windows.Forms.TextBox();
            this.lbl_expiredDate = new System.Windows.Forms.Label();
            this.lbl_cvc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_duration = new System.Windows.Forms.Label();
            this.lbl_bank = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.grbx_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_card
            // 
            this.grbx_card.Controls.Add(this.cmbx_type);
            this.grbx_card.Controls.Add(this.cmbx_duration);
            this.grbx_card.Controls.Add(this.cmbx_bank);
            this.grbx_card.Controls.Add(this.btn_order);
            this.grbx_card.Controls.Add(this.txbx_expiredDate);
            this.grbx_card.Controls.Add(this.txbx_cvc);
            this.grbx_card.Controls.Add(this.txbx_number);
            this.grbx_card.Controls.Add(this.lbl_expiredDate);
            this.grbx_card.Controls.Add(this.lbl_cvc);
            this.grbx_card.Controls.Add(this.label4);
            this.grbx_card.Controls.Add(this.lbl_duration);
            this.grbx_card.Controls.Add(this.lbl_bank);
            this.grbx_card.Controls.Add(this.lbl_number);
            this.grbx_card.Location = new System.Drawing.Point(9, 12);
            this.grbx_card.Name = "grbx_card";
            this.grbx_card.Size = new System.Drawing.Size(264, 338);
            this.grbx_card.TabIndex = 3;
            this.grbx_card.TabStop = false;
            this.grbx_card.Text = "Card";
            // 
            // cmbx_type
            // 
            this.cmbx_type.FormattingEnabled = true;
            this.cmbx_type.Items.AddRange(new object[] {
            "Salary",
            "Debet",
            "Scolarship",
            "Credit"});
            this.cmbx_type.Location = new System.Drawing.Point(81, 93);
            this.cmbx_type.Name = "cmbx_type";
            this.cmbx_type.Size = new System.Drawing.Size(174, 21);
            this.cmbx_type.TabIndex = 16;
            // 
            // cmbx_duration
            // 
            this.cmbx_duration.FormattingEnabled = true;
            this.cmbx_duration.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.cmbx_duration.Location = new System.Drawing.Point(80, 65);
            this.cmbx_duration.Name = "cmbx_duration";
            this.cmbx_duration.Size = new System.Drawing.Size(174, 21);
            this.cmbx_duration.TabIndex = 15;
            // 
            // cmbx_bank
            // 
            this.cmbx_bank.FormattingEnabled = true;
            this.cmbx_bank.Items.AddRange(new object[] {
            "Kapital Bank",
            "Express Bank",
            "BTB Bank",
            "Yellow Bank",
            "Beynaxalq Bank"});
            this.cmbx_bank.Location = new System.Drawing.Point(81, 35);
            this.cmbx_bank.Name = "cmbx_bank";
            this.cmbx_bank.Size = new System.Drawing.Size(174, 21);
            this.cmbx_bank.TabIndex = 14;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(80, 246);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(174, 38);
            this.btn_order.TabIndex = 13;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // txbx_expiredDate
            // 
            this.txbx_expiredDate.Enabled = false;
            this.txbx_expiredDate.Location = new System.Drawing.Point(80, 195);
            this.txbx_expiredDate.Name = "txbx_expiredDate";
            this.txbx_expiredDate.Size = new System.Drawing.Size(175, 20);
            this.txbx_expiredDate.TabIndex = 12;
            // 
            // txbx_cvc
            // 
            this.txbx_cvc.Enabled = false;
            this.txbx_cvc.Location = new System.Drawing.Point(80, 161);
            this.txbx_cvc.Name = "txbx_cvc";
            this.txbx_cvc.Size = new System.Drawing.Size(175, 20);
            this.txbx_cvc.TabIndex = 11;
            // 
            // txbx_number
            // 
            this.txbx_number.Enabled = false;
            this.txbx_number.Location = new System.Drawing.Point(81, 127);
            this.txbx_number.Name = "txbx_number";
            this.txbx_number.Size = new System.Drawing.Size(174, 20);
            this.txbx_number.TabIndex = 10;
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
            // lbl_cvc
            // 
            this.lbl_cvc.AutoSize = true;
            this.lbl_cvc.Location = new System.Drawing.Point(22, 161);
            this.lbl_cvc.Name = "lbl_cvc";
            this.lbl_cvc.Size = new System.Drawing.Size(37, 13);
            this.lbl_cvc.TabIndex = 4;
            this.lbl_cvc.Text = "CVC : ";
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
            // lbl_duration
            // 
            this.lbl_duration.AutoSize = true;
            this.lbl_duration.Location = new System.Drawing.Point(22, 65);
            this.lbl_duration.Name = "lbl_duration";
            this.lbl_duration.Size = new System.Drawing.Size(56, 13);
            this.lbl_duration.TabIndex = 2;
            this.lbl_duration.Text = "Duration : ";
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
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(22, 127);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(53, 13);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number : ";
            // 
            // CardManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 353);
            this.Controls.Add(this.grbx_card);
            this.Name = "CardManagerForm";
            this.Text = "CardManagerForm";
            this.Load += new System.EventHandler(this.CardManagerForm_Load);
            this.grbx_card.ResumeLayout(false);
            this.grbx_card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbx_card;
        private System.Windows.Forms.ComboBox cmbx_type;
        private System.Windows.Forms.ComboBox cmbx_duration;
        private System.Windows.Forms.ComboBox cmbx_bank;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.TextBox txbx_expiredDate;
        private System.Windows.Forms.TextBox txbx_cvc;
        private System.Windows.Forms.TextBox txbx_number;
        private System.Windows.Forms.Label lbl_expiredDate;
        private System.Windows.Forms.Label lbl_cvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_duration;
        private System.Windows.Forms.Label lbl_bank;
        private System.Windows.Forms.Label lbl_number;
    }
}