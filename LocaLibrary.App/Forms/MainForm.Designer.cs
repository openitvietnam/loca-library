namespace LocaLibrary.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCategorys = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAccount,
            this.menuItemManage,
            this.menuItemHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1008, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuItemAccount
            // 
            this.menuItemAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditProfile,
            this.menuItemExit});
            this.menuItemAccount.Name = "menuItemAccount";
            this.menuItemAccount.Size = new System.Drawing.Size(64, 20);
            this.menuItemAccount.Text = "Account";
            // 
            // menuItemEditProfile
            // 
            this.menuItemEditProfile.Name = "menuItemEditProfile";
            this.menuItemEditProfile.Size = new System.Drawing.Size(140, 22);
            this.menuItemEditProfile.Text = "Edit Profile...";
            this.menuItemEditProfile.Click += new System.EventHandler(this.menuItemEditProfile_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(140, 22);
            this.menuItemExit.Text = "Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemManage
            // 
            this.menuItemManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEmployees,
            this.menuItemMembers,
            this.menuItemCategorys,
            this.menuItemBooks});
            this.menuItemManage.Name = "menuItemManage";
            this.menuItemManage.Size = new System.Drawing.Size(62, 20);
            this.menuItemManage.Text = "Manage";
            // 
            // menuItemEmployees
            // 
            this.menuItemEmployees.Name = "menuItemEmployees";
            this.menuItemEmployees.Size = new System.Drawing.Size(180, 22);
            this.menuItemEmployees.Text = "Employees...";
            // 
            // menuItemMembers
            // 
            this.menuItemMembers.Name = "menuItemMembers";
            this.menuItemMembers.Size = new System.Drawing.Size(180, 22);
            this.menuItemMembers.Text = "Members...";
            // 
            // menuItemCategorys
            // 
            this.menuItemCategorys.Name = "menuItemCategorys";
            this.menuItemCategorys.Size = new System.Drawing.Size(180, 22);
            this.menuItemCategorys.Text = "Categories...";
            this.menuItemCategorys.Click += new System.EventHandler(this.menuItemCategorys_Click);
            // 
            // menuItemBooks
            // 
            this.menuItemBooks.Name = "menuItemBooks";
            this.menuItemBooks.Size = new System.Drawing.Size(180, 22);
            this.menuItemBooks.Text = "Books...";
            this.menuItemBooks.Click += new System.EventHandler(this.menuItemBooks_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCheckForUpdates,
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "Help";
            // 
            // menuItemCheckForUpdates
            // 
            this.menuItemCheckForUpdates.Name = "menuItemCheckForUpdates";
            this.menuItemCheckForUpdates.Size = new System.Drawing.Size(174, 22);
            this.menuItemCheckForUpdates.Text = "Check for Updates";
            this.menuItemCheckForUpdates.Click += new System.EventHandler(this.menuItemCheckForUpdates_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(174, 22);
            this.menuItemAbout.Text = "About Loca Library";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loca Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemManage;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheckForUpdates;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemEmployees;
        private System.Windows.Forms.ToolStripMenuItem menuItemMembers;
        private System.Windows.Forms.ToolStripMenuItem menuItemCategorys;
        private System.Windows.Forms.ToolStripMenuItem menuItemBooks;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccount;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditProfile;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

