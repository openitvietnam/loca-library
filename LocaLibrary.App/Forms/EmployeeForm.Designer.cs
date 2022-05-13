namespace LocaLibrary.App.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.gridEmployees = new System.Windows.Forms.DataGridView();
            this.panelAction = new System.Windows.Forms.Panel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelCheck = new System.Windows.Forms.Panel();
            this.checkIsLocked = new System.Windows.Forms.CheckBox();
            this.checkIsAdmin = new System.Windows.Forms.CheckBox();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.inputFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.inputNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.panelAction.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelCheck.SuspendLayout();
            this.panelFullName.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelResetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmployees
            // 
            this.gridEmployees.AllowUserToAddRows = false;
            this.gridEmployees.AllowUserToDeleteRows = false;
            this.gridEmployees.AllowUserToResizeRows = false;
            this.gridEmployees.BackgroundColor = System.Drawing.Color.White;
            this.gridEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployees.GridColor = System.Drawing.Color.LightGray;
            this.gridEmployees.Location = new System.Drawing.Point(0, 0);
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.ReadOnly = true;
            this.gridEmployees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployees.Size = new System.Drawing.Size(544, 441);
            this.gridEmployees.TabIndex = 12;
            this.gridEmployees.SelectionChanged += new System.EventHandler(this.gridEmployees_SelectionChanged);
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.buttonReload);
            this.panelAction.Controls.Add(this.buttonAdd);
            this.panelAction.Controls.Add(this.buttonUpdate);
            this.panelAction.Controls.Add(this.buttonDelete);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 441);
            this.panelAction.Name = "panelAction";
            this.panelAction.Padding = new System.Windows.Forms.Padding(10);
            this.panelAction.Size = new System.Drawing.Size(544, 60);
            this.panelAction.TabIndex = 11;
            // 
            // buttonReload
            // 
            this.buttonReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonReload.Location = new System.Drawing.Point(310, 10);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(100, 40);
            this.buttonReload.TabIndex = 11;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdd.Location = new System.Drawing.Point(210, 10);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 40);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add new";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUpdate.Location = new System.Drawing.Point(110, 10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 40);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDelete.Location = new System.Drawing.Point(10, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.Controls.Add(this.panelResetPassword);
            this.panelInfo.Controls.Add(this.panelCheck);
            this.panelInfo.Controls.Add(this.panelFullName);
            this.panelInfo.Controls.Add(this.panelEmail);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfo.Location = new System.Drawing.Point(544, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(20);
            this.panelInfo.Size = new System.Drawing.Size(240, 501);
            this.panelInfo.TabIndex = 10;
            // 
            // panelCheck
            // 
            this.panelCheck.Controls.Add(this.checkIsLocked);
            this.panelCheck.Controls.Add(this.checkIsAdmin);
            this.panelCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCheck.Location = new System.Drawing.Point(20, 170);
            this.panelCheck.Name = "panelCheck";
            this.panelCheck.Size = new System.Drawing.Size(200, 60);
            this.panelCheck.TabIndex = 15;
            // 
            // checkIsLocked
            // 
            this.checkIsLocked.AutoSize = true;
            this.checkIsLocked.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIsLocked.Location = new System.Drawing.Point(0, 23);
            this.checkIsLocked.Name = "checkIsLocked";
            this.checkIsLocked.Size = new System.Drawing.Size(200, 23);
            this.checkIsLocked.TabIndex = 2;
            this.checkIsLocked.Text = "Is locked";
            this.checkIsLocked.UseVisualStyleBackColor = true;
            // 
            // checkIsAdmin
            // 
            this.checkIsAdmin.AutoSize = true;
            this.checkIsAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkIsAdmin.Location = new System.Drawing.Point(0, 0);
            this.checkIsAdmin.Name = "checkIsAdmin";
            this.checkIsAdmin.Size = new System.Drawing.Size(200, 23);
            this.checkIsAdmin.TabIndex = 1;
            this.checkIsAdmin.Text = "Is admin";
            this.checkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // panelFullName
            // 
            this.panelFullName.Controls.Add(this.inputFullName);
            this.panelFullName.Controls.Add(this.labelFullName);
            this.panelFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFullName.Location = new System.Drawing.Point(20, 95);
            this.panelFullName.Name = "panelFullName";
            this.panelFullName.Size = new System.Drawing.Size(200, 75);
            this.panelFullName.TabIndex = 14;
            // 
            // inputFullName
            // 
            this.inputFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputFullName.Location = new System.Drawing.Point(0, 35);
            this.inputFullName.Name = "inputFullName";
            this.inputFullName.Size = new System.Drawing.Size(200, 25);
            this.inputFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFullName.Location = new System.Drawing.Point(0, 0);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(200, 35);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full name";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.inputEmail);
            this.panelEmail.Controls.Add(this.labelEmail);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmail.Location = new System.Drawing.Point(20, 20);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(200, 75);
            this.panelEmail.TabIndex = 13;
            // 
            // inputEmail
            // 
            this.inputEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputEmail.Location = new System.Drawing.Point(0, 35);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(200, 25);
            this.inputEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmail.Location = new System.Drawing.Point(0, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(200, 35);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.Controls.Add(this.buttonResetPassword);
            this.panelResetPassword.Controls.Add(this.inputNewPassword);
            this.panelResetPassword.Controls.Add(this.labelNewPassword);
            this.panelResetPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResetPassword.Location = new System.Drawing.Point(20, 366);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(200, 115);
            this.panelResetPassword.TabIndex = 16;
            // 
            // inputNewPassword
            // 
            this.inputNewPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputNewPassword.Location = new System.Drawing.Point(0, 35);
            this.inputNewPassword.Name = "inputNewPassword";
            this.inputNewPassword.Size = new System.Drawing.Size(200, 25);
            this.inputNewPassword.TabIndex = 1;
            this.inputNewPassword.UseSystemPasswordChar = true;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNewPassword.Location = new System.Drawing.Point(0, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(200, 35);
            this.labelNewPassword.TabIndex = 0;
            this.labelNewPassword.Text = "New password";
            this.labelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonResetPassword.Location = new System.Drawing.Point(0, 75);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(200, 40);
            this.buttonResetPassword.TabIndex = 2;
            this.buttonResetPassword.Text = "Reset password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.gridEmployees);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee list";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelCheck.ResumeLayout(false);
            this.panelCheck.PerformLayout();
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmployees;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelCheck;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox inputFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.CheckBox checkIsAdmin;
        private System.Windows.Forms.CheckBox checkIsLocked;
        private System.Windows.Forms.Panel panelResetPassword;
        private System.Windows.Forms.Button buttonResetPassword;
        private System.Windows.Forms.TextBox inputNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
    }
}
