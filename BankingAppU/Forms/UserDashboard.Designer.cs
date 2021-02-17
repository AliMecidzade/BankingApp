namespace BankingAppU
{
    partial class UserDashboard
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
            this.grbx_user = new System.Windows.Forms.GroupBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.grbx_cards = new System.Windows.Forms.GroupBox();
            this.link_order = new System.Windows.Forms.LinkLabel();
            this.link_myCards = new System.Windows.Forms.LinkLabel();
            this.grbx_settings = new System.Windows.Forms.GroupBox();
            this.link_settings = new System.Windows.Forms.LinkLabel();
            this.link_logOut = new System.Windows.Forms.LinkLabel();
            this.link_refresh = new System.Windows.Forms.LinkLabel();
            this.grbx_user.SuspendLayout();
            this.grbx_cards.SuspendLayout();
            this.grbx_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_user
            // 
            this.grbx_user.Controls.Add(this.lbl_email);
            this.grbx_user.Controls.Add(this.lbl_surname);
            this.grbx_user.Controls.Add(this.lbl_name);
            this.grbx_user.Location = new System.Drawing.Point(12, 12);
            this.grbx_user.Name = "grbx_user";
            this.grbx_user.Size = new System.Drawing.Size(257, 156);
            this.grbx_user.TabIndex = 0;
            this.grbx_user.TabStop = false;
            this.grbx_user.Text = "User";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(11, 72);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email : ";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(11, 47);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(58, 13);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Surname : ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(11, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name : ";
            // 
            // grbx_cards
            // 
            this.grbx_cards.Controls.Add(this.link_order);
            this.grbx_cards.Controls.Add(this.link_myCards);
            this.grbx_cards.Location = new System.Drawing.Point(12, 217);
            this.grbx_cards.Name = "grbx_cards";
            this.grbx_cards.Size = new System.Drawing.Size(257, 164);
            this.grbx_cards.TabIndex = 1;
            this.grbx_cards.TabStop = false;
            this.grbx_cards.Text = "Cards";
            // 
            // link_order
            // 
            this.link_order.AutoSize = true;
            this.link_order.Location = new System.Drawing.Point(35, 75);
            this.link_order.Name = "link_order";
            this.link_order.Size = new System.Drawing.Size(63, 13);
            this.link_order.TabIndex = 5;
            this.link_order.TabStop = true;
            this.link_order.Text = "Order Cards";
            this.link_order.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_order_LinkClicked);
            // 
            // link_myCards
            // 
            this.link_myCards.AutoSize = true;
            this.link_myCards.Location = new System.Drawing.Point(35, 36);
            this.link_myCards.Name = "link_myCards";
            this.link_myCards.Size = new System.Drawing.Size(51, 13);
            this.link_myCards.TabIndex = 6;
            this.link_myCards.TabStop = true;
            this.link_myCards.Text = "My Cards";
            this.link_myCards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_myCards_LinkClicked);
            // 
            // grbx_settings
            // 
            this.grbx_settings.Controls.Add(this.link_settings);
            this.grbx_settings.Location = new System.Drawing.Point(588, 253);
            this.grbx_settings.Name = "grbx_settings";
            this.grbx_settings.Size = new System.Drawing.Size(200, 128);
            this.grbx_settings.TabIndex = 2;
            this.grbx_settings.TabStop = false;
            this.grbx_settings.Text = "Settings";
            // 
            // link_settings
            // 
            this.link_settings.AutoSize = true;
            this.link_settings.Location = new System.Drawing.Point(29, 39);
            this.link_settings.Name = "link_settings";
            this.link_settings.Size = new System.Drawing.Size(45, 13);
            this.link_settings.TabIndex = 5;
            this.link_settings.TabStop = true;
            this.link_settings.Text = "Settings";
            this.link_settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_settings_LinkClicked);
            // 
            // link_logOut
            // 
            this.link_logOut.AutoSize = true;
            this.link_logOut.Location = new System.Drawing.Point(701, 32);
            this.link_logOut.Name = "link_logOut";
            this.link_logOut.Size = new System.Drawing.Size(42, 13);
            this.link_logOut.TabIndex = 3;
            this.link_logOut.TabStop = true;
            this.link_logOut.Text = "LogOut";
            this.link_logOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logOut_LinkClicked);
            // 
            // link_refresh
            // 
            this.link_refresh.AutoSize = true;
            this.link_refresh.Location = new System.Drawing.Point(701, 59);
            this.link_refresh.Name = "link_refresh";
            this.link_refresh.Size = new System.Drawing.Size(44, 13);
            this.link_refresh.TabIndex = 4;
            this.link_refresh.TabStop = true;
            this.link_refresh.Text = "Refresh";
            this.link_refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_refresh_LinkClicked);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_refresh);
            this.Controls.Add(this.link_logOut);
            this.Controls.Add(this.grbx_settings);
            this.Controls.Add(this.grbx_cards);
            this.Controls.Add(this.grbx_user);
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.grbx_user.ResumeLayout(false);
            this.grbx_user.PerformLayout();
            this.grbx_cards.ResumeLayout(false);
            this.grbx_cards.PerformLayout();
            this.grbx_settings.ResumeLayout(false);
            this.grbx_settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_user;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox grbx_cards;
        private System.Windows.Forms.LinkLabel link_order;
        private System.Windows.Forms.LinkLabel link_myCards;
        private System.Windows.Forms.GroupBox grbx_settings;
        private System.Windows.Forms.LinkLabel link_settings;
        private System.Windows.Forms.LinkLabel link_logOut;
        private System.Windows.Forms.LinkLabel link_refresh;
    }
}