﻿namespace LocaLibrary.App
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
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelOverview = new System.Windows.Forms.Panel();
            this.labelTotalBookCount = new System.Windows.Forms.Label();
            this.labelBorrowingBookCount = new System.Windows.Forms.Label();
            this.labelOverview = new System.Windows.Forms.Label();
            this.panelCurrentUser = new System.Windows.Forms.Panel();
            this.labelToday = new System.Windows.Forms.Label();
            this.labelCurrentUserEmail = new System.Windows.Forms.Label();
            this.labelCurrentUserFullName = new System.Windows.Forms.Label();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelOverview.SuspendLayout();
            this.panelCurrentUser.SuspendLayout();
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
            this.menuItemEmployees.Size = new System.Drawing.Size(140, 22);
            this.menuItemEmployees.Text = "Employees...";
            this.menuItemEmployees.Click += new System.EventHandler(this.menuItemEmployees_Click);
            // 
            // menuItemMembers
            // 
            this.menuItemMembers.Name = "menuItemMembers";
            this.menuItemMembers.Size = new System.Drawing.Size(140, 22);
            this.menuItemMembers.Text = "Members...";
            this.menuItemMembers.Click += new System.EventHandler(this.menuItemMembers_Click);
            // 
            // menuItemCategorys
            // 
            this.menuItemCategorys.Name = "menuItemCategorys";
            this.menuItemCategorys.Size = new System.Drawing.Size(140, 22);
            this.menuItemCategorys.Text = "Categories...";
            this.menuItemCategorys.Click += new System.EventHandler(this.menuItemCategorys_Click);
            // 
            // menuItemBooks
            // 
            this.menuItemBooks.Name = "menuItemBooks";
            this.menuItemBooks.Size = new System.Drawing.Size(140, 22);
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
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelSide.Controls.Add(this.panelOverview);
            this.panelSide.Controls.Add(this.panelCurrentUser);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 24);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(200, 577);
            this.panelSide.TabIndex = 1;
            // 
            // panelOverview
            // 
            this.panelOverview.Controls.Add(this.labelTotalBookCount);
            this.panelOverview.Controls.Add(this.labelBorrowingBookCount);
            this.panelOverview.Controls.Add(this.labelOverview);
            this.panelOverview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOverview.Location = new System.Drawing.Point(0, 427);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Padding = new System.Windows.Forms.Padding(20);
            this.panelOverview.Size = new System.Drawing.Size(200, 150);
            this.panelOverview.TabIndex = 1;
            // 
            // labelTotalBookCount
            // 
            this.labelTotalBookCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalBookCount.Location = new System.Drawing.Point(20, 90);
            this.labelTotalBookCount.Name = "labelTotalBookCount";
            this.labelTotalBookCount.Size = new System.Drawing.Size(160, 30);
            this.labelTotalBookCount.TabIndex = 6;
            this.labelTotalBookCount.Text = "Total: ?";
            this.labelTotalBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBorrowingBookCount
            // 
            this.labelBorrowingBookCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBorrowingBookCount.Location = new System.Drawing.Point(20, 60);
            this.labelBorrowingBookCount.Name = "labelBorrowingBookCount";
            this.labelBorrowingBookCount.Size = new System.Drawing.Size(160, 30);
            this.labelBorrowingBookCount.TabIndex = 5;
            this.labelBorrowingBookCount.Text = "Borrowing: ?";
            this.labelBorrowingBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOverview
            // 
            this.labelOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOverview.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelOverview.Location = new System.Drawing.Point(20, 20);
            this.labelOverview.Name = "labelOverview";
            this.labelOverview.Size = new System.Drawing.Size(160, 40);
            this.labelOverview.TabIndex = 4;
            this.labelOverview.Text = "Overview";
            this.labelOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCurrentUser
            // 
            this.panelCurrentUser.Controls.Add(this.labelToday);
            this.panelCurrentUser.Controls.Add(this.labelCurrentUserEmail);
            this.panelCurrentUser.Controls.Add(this.labelCurrentUserFullName);
            this.panelCurrentUser.Controls.Add(this.labelCurrentUser);
            this.panelCurrentUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCurrentUser.Location = new System.Drawing.Point(0, 0);
            this.panelCurrentUser.Name = "panelCurrentUser";
            this.panelCurrentUser.Padding = new System.Windows.Forms.Padding(20);
            this.panelCurrentUser.Size = new System.Drawing.Size(200, 180);
            this.panelCurrentUser.TabIndex = 0;
            // 
            // labelToday
            // 
            this.labelToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelToday.Location = new System.Drawing.Point(20, 120);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(160, 30);
            this.labelToday.TabIndex = 3;
            this.labelToday.Text = "dd/MM/yyyy";
            this.labelToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentUserEmail
            // 
            this.labelCurrentUserEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCurrentUserEmail.Location = new System.Drawing.Point(20, 90);
            this.labelCurrentUserEmail.Name = "labelCurrentUserEmail";
            this.labelCurrentUserEmail.Size = new System.Drawing.Size(160, 30);
            this.labelCurrentUserEmail.TabIndex = 2;
            this.labelCurrentUserEmail.Text = "Email";
            this.labelCurrentUserEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentUserFullName
            // 
            this.labelCurrentUserFullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCurrentUserFullName.Location = new System.Drawing.Point(20, 60);
            this.labelCurrentUserFullName.Name = "labelCurrentUserFullName";
            this.labelCurrentUserFullName.Size = new System.Drawing.Size(160, 30);
            this.labelCurrentUserFullName.TabIndex = 1;
            this.labelCurrentUserFullName.Text = "Full name";
            this.labelCurrentUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCurrentUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelCurrentUser.Location = new System.Drawing.Point(20, 20);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(160, 40);
            this.labelCurrentUser.TabIndex = 0;
            this.labelCurrentUser.Text = "Current user";
            this.labelCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loca Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.panelOverview.ResumeLayout(false);
            this.panelCurrentUser.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelOverview;
        private System.Windows.Forms.Panel panelCurrentUser;
        private System.Windows.Forms.Label labelCurrentUserFullName;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Label labelCurrentUserEmail;
        private System.Windows.Forms.Label labelTotalBookCount;
        private System.Windows.Forms.Label labelBorrowingBookCount;
        private System.Windows.Forms.Label labelOverview;
    }
}

