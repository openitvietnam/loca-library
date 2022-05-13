namespace LocaLibrary.App.Forms
{
    partial class EditProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            this.panelFullName = new System.Windows.Forms.Panel();
            this.inputFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.inputNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.panelFullName.SuspendLayout();
            this.panelResetPassword.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFullName
            // 
            this.panelFullName.Controls.Add(this.inputFullName);
            this.panelFullName.Controls.Add(this.labelFullName);
            this.panelFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFullName.Location = new System.Drawing.Point(30, 20);
            this.panelFullName.Name = "panelFullName";
            this.panelFullName.Size = new System.Drawing.Size(284, 75);
            this.panelFullName.TabIndex = 3;
            // 
            // inputFullName
            // 
            this.inputFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputFullName.Location = new System.Drawing.Point(0, 35);
            this.inputFullName.Name = "inputFullName";
            this.inputFullName.Size = new System.Drawing.Size(284, 25);
            this.inputFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFullName.Location = new System.Drawing.Point(0, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(284, 35);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full name";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.Controls.Add(this.inputNewPassword);
            this.panelResetPassword.Controls.Add(this.labelNewPassword);
            this.panelResetPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResetPassword.Location = new System.Drawing.Point(30, 95);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(284, 75);
            this.panelResetPassword.TabIndex = 5;
            // 
            // inputNewPassword
            // 
            this.inputNewPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputNewPassword.Location = new System.Drawing.Point(0, 35);
            this.inputNewPassword.Name = "inputNewPassword";
            this.inputNewPassword.Size = new System.Drawing.Size(284, 25);
            this.inputNewPassword.TabIndex = 1;
            this.inputNewPassword.UseSystemPasswordChar = true;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNewPassword.Location = new System.Drawing.Point(0, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(284, 35);
            this.labelNewPassword.TabIndex = 0;
            this.labelNewPassword.Text = "New password";
            this.labelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonSaveChanges);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(30, 170);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelActions.Size = new System.Drawing.Size(284, 60);
            this.panelActions.TabIndex = 6;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSaveChanges.Location = new System.Drawing.Point(164, 10);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveChanges.TabIndex = 0;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 256);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelResetPassword);
            this.Controls.Add(this.panelFullName);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EditProfileForm";
            this.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit profile";
            this.Load += new System.EventHandler(this.EditProfileForm_Load);
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox inputFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panelResetPassword;
        private System.Windows.Forms.TextBox inputNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}
