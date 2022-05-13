namespace LocaLibrary.App.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureLogin = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.linkForgetPassword = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLogin
            // 
            this.pictureLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureLogin.Image = global::LocaLibrary.App.Properties.Resources.login;
            this.pictureLogin.Location = new System.Drawing.Point(324, 0);
            this.pictureLogin.Name = "pictureLogin";
            this.pictureLogin.Size = new System.Drawing.Size(300, 321);
            this.pictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogin.TabIndex = 0;
            this.pictureLogin.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelLogin);
            this.panelContainer.Controls.Add(this.panelPassword);
            this.panelContainer.Controls.Add(this.panelEmail);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(40);
            this.panelContainer.Size = new System.Drawing.Size(324, 321);
            this.panelContainer.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.linkForgetPassword);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(40, 190);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelLogin.Size = new System.Drawing.Size(244, 60);
            this.panelLogin.TabIndex = 2;
            // 
            // linkForgetPassword
            // 
            this.linkForgetPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkForgetPassword.Location = new System.Drawing.Point(0, 10);
            this.linkForgetPassword.Name = "linkForgetPassword";
            this.linkForgetPassword.Size = new System.Drawing.Size(124, 40);
            this.linkForgetPassword.TabIndex = 1;
            this.linkForgetPassword.TabStop = true;
            this.linkForgetPassword.Text = "Forget password?";
            this.linkForgetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetPassword_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonLogin.Location = new System.Drawing.Point(124, 10);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(120, 40);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.inputPassword);
            this.panelPassword.Controls.Add(this.labelPassword);
            this.panelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPassword.Location = new System.Drawing.Point(40, 115);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(244, 75);
            this.panelPassword.TabIndex = 1;
            // 
            // inputPassword
            // 
            this.inputPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPassword.Location = new System.Drawing.Point(0, 35);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(244, 25);
            this.inputPassword.TabIndex = 3;
            this.inputPassword.Text = "123456";
            // 
            // labelPassword
            // 
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPassword.Location = new System.Drawing.Point(0, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(244, 35);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.inputEmail);
            this.panelEmail.Controls.Add(this.labelEmail);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmail.Location = new System.Drawing.Point(40, 40);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(244, 75);
            this.panelEmail.TabIndex = 0;
            // 
            // inputEmail
            // 
            this.inputEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputEmail.Location = new System.Drawing.Point(0, 35);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(244, 25);
            this.inputEmail.TabIndex = 1;
            this.inputEmail.Text = "admin@gmail.com";
            // 
            // labelEmail
            // 
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmail.Location = new System.Drawing.Point(0, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(244, 35);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pictureLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to your account";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogin)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogin;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.LinkLabel linkForgetPassword;
    }
}
