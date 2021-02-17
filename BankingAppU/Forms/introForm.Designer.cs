namespace BankingAppU
{
    partial class introForm
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
            this.grbx_signup = new System.Windows.Forms.GroupBox();
            this.regControl = new BankingAppU.Components.UserControl1();
            this.grbx_signin = new System.Windows.Forms.GroupBox();
            this.logControl = new BankingAppU.Components.UserControl1();
            this.grbx_signup.SuspendLayout();
            this.grbx_signin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_signup
            // 
            this.grbx_signup.Controls.Add(this.regControl);
            this.grbx_signup.Location = new System.Drawing.Point(0, 0);
            this.grbx_signup.Name = "grbx_signup";
            this.grbx_signup.Size = new System.Drawing.Size(284, 216);
            this.grbx_signup.TabIndex = 0;
            this.grbx_signup.TabStop = false;
            this.grbx_signup.Text = "Sign Up";
            // 
            // regControl
            // 
            this.regControl.Location = new System.Drawing.Point(52, 32);
            this.regControl.Name = "regControl";
            this.regControl.Size = new System.Drawing.Size(174, 158);
            this.regControl.TabIndex = 0;
            // 
            // grbx_signin
            // 
            this.grbx_signin.Controls.Add(this.logControl);
            this.grbx_signin.Location = new System.Drawing.Point(299, 0);
            this.grbx_signin.Name = "grbx_signin";
            this.grbx_signin.Size = new System.Drawing.Size(284, 216);
            this.grbx_signin.TabIndex = 1;
            this.grbx_signin.TabStop = false;
            this.grbx_signin.Text = "Sign In";
            // 
            // logControl
            // 
            this.logControl.Location = new System.Drawing.Point(57, 32);
            this.logControl.Name = "logControl";
            this.logControl.Size = new System.Drawing.Size(174, 158);
            this.logControl.TabIndex = 1;
            this.logControl.Load += new System.EventHandler(this.logControl_Load);
            // 
            // introForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 224);
            this.Controls.Add(this.grbx_signin);
            this.Controls.Add(this.grbx_signup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "introForm";
            this.Text = "Sign Up/In";
            this.grbx_signup.ResumeLayout(false);
            this.grbx_signin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_signup;
        private System.Windows.Forms.GroupBox grbx_signin;
        private Components.UserControl1 regControl;
        private Components.UserControl1 logControl;
    }
}

