namespace BankingAppU.Forms
{
    partial class UserConfigurationForm
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
            this.grbx_info = new System.Windows.Forms.GroupBox();
            this.credentialsControl = new BankingAppU.Components.UserControl1();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbx_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_info
            // 
            this.grbx_info.Controls.Add(this.credentialsControl);
            this.grbx_info.Controls.Add(this.lbl_surname);
            this.grbx_info.Controls.Add(this.txbx_surname);
            this.grbx_info.Controls.Add(this.txbx_name);
            this.grbx_info.Controls.Add(this.lbl_name);
            this.grbx_info.Location = new System.Drawing.Point(12, 25);
            this.grbx_info.Name = "grbx_info";
            this.grbx_info.Size = new System.Drawing.Size(247, 383);
            this.grbx_info.TabIndex = 0;
            this.grbx_info.TabStop = false;
            this.grbx_info.Text = "User Info";
            // 
            // credentialsControl
            // 
            this.credentialsControl.Location = new System.Drawing.Point(23, 175);
            this.credentialsControl.Name = "credentialsControl";
            this.credentialsControl.Size = new System.Drawing.Size(174, 158);
            this.credentialsControl.TabIndex = 5;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(30, 133);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(49, 13);
            this.lbl_surname.TabIndex = 4;
            this.lbl_surname.Text = "Surname";
            this.lbl_surname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(23, 149);
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(164, 20);
            this.txbx_surname.TabIndex = 3;
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(23, 101);
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(164, 20);
            this.txbx_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(30, 85);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // UserConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.grbx_info);
            this.Name = "UserConfigurationForm";
            this.Text = "UserConfigurationForm";
            this.Load += new System.EventHandler(this.UserConfigurationForm_Load);
            this.grbx_info.ResumeLayout(false);
            this.grbx_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_info;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label lbl_name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Components.UserControl1 credentialsControl;
    }
}