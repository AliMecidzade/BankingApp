namespace BankingAppU.Forms
{
    partial class AdminPanel
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
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.link_users = new System.Windows.Forms.LinkLabel();
            this.link_cards = new System.Windows.Forms.LinkLabel();
            this.link_logOut = new System.Windows.Forms.LinkLabel();
            this.link_refresh = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(34, 164);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(726, 251);
            this.dgv_data.TabIndex = 0;
            this.dgv_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.link_refresh);
            this.groupBox1.Controls.Add(this.link_users);
            this.groupBox1.Controls.Add(this.link_cards);
            this.groupBox1.Controls.Add(this.link_logOut);
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // link_users
            // 
            this.link_users.AutoSize = true;
            this.link_users.Location = new System.Drawing.Point(24, 20);
            this.link_users.Name = "link_users";
            this.link_users.Size = new System.Drawing.Size(34, 13);
            this.link_users.TabIndex = 2;
            this.link_users.TabStop = true;
            this.link_users.Text = "Users";
            // 
            // link_cards
            // 
            this.link_cards.AutoSize = true;
            this.link_cards.Location = new System.Drawing.Point(24, 51);
            this.link_cards.Name = "link_cards";
            this.link_cards.Size = new System.Drawing.Size(34, 13);
            this.link_cards.TabIndex = 1;
            this.link_cards.TabStop = true;
            this.link_cards.Text = "Cards";
            // 
            // link_logOut
            // 
            this.link_logOut.AutoSize = true;
            this.link_logOut.Location = new System.Drawing.Point(662, 20);
            this.link_logOut.Name = "link_logOut";
            this.link_logOut.Size = new System.Drawing.Size(42, 13);
            this.link_logOut.TabIndex = 0;
            this.link_logOut.TabStop = true;
            this.link_logOut.Text = "LogOut";
            // 
            // link_refresh
            // 
            this.link_refresh.AutoSize = true;
            this.link_refresh.Location = new System.Drawing.Point(662, 51);
            this.link_refresh.Name = "link_refresh";
            this.link_refresh.Size = new System.Drawing.Size(44, 13);
            this.link_refresh.TabIndex = 3;
            this.link_refresh.TabStop = true;
            this.link_refresh.Text = "Refresh";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel link_users;
        private System.Windows.Forms.LinkLabel link_cards;
        private System.Windows.Forms.LinkLabel link_logOut;
        private System.Windows.Forms.LinkLabel link_refresh;
    }
}