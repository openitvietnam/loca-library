namespace LocaLibrary.App.Forms
{
    partial class BorrowForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
			this.panelMembers = new System.Windows.Forms.Panel();
			this.gridMembers = new System.Windows.Forms.DataGridView();
			this.panelMembersAction = new System.Windows.Forms.Panel();
			this.panelSearchMembers = new System.Windows.Forms.Panel();
			this.inputSearchMembers = new System.Windows.Forms.TextBox();
			this.labelSearchMembers = new System.Windows.Forms.Label();
			this.panelBooks = new System.Windows.Forms.Panel();
			this.gridBooks = new System.Windows.Forms.DataGridView();
			this.panelBooksAction = new System.Windows.Forms.Panel();
			this.panelSearchBooks = new System.Windows.Forms.Panel();
			this.inputSearchBooks = new System.Windows.Forms.TextBox();
			this.labelSearchBooks = new System.Windows.Forms.Label();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.buttonBorrow = new System.Windows.Forms.Button();
			this.panelExpectedReturnDate = new System.Windows.Forms.Panel();
			this.dateExpectedReturnDate = new System.Windows.Forms.DateTimePicker();
			this.labelExpectedReturnDate = new System.Windows.Forms.Label();
			this.panelMembers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
			this.panelMembersAction.SuspendLayout();
			this.panelSearchMembers.SuspendLayout();
			this.panelBooks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
			this.panelBooksAction.SuspendLayout();
			this.panelSearchBooks.SuspendLayout();
			this.panelInfo.SuspendLayout();
			this.panelExpectedReturnDate.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMembers
			// 
			this.panelMembers.Controls.Add(this.gridMembers);
			this.panelMembers.Controls.Add(this.panelMembersAction);
			this.panelMembers.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMembers.Location = new System.Drawing.Point(0, 0);
			this.panelMembers.Name = "panelMembers";
			this.panelMembers.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.panelMembers.Size = new System.Drawing.Size(320, 411);
			this.panelMembers.TabIndex = 0;
			// 
			// gridMembers
			// 
			this.gridMembers.AllowUserToAddRows = false;
			this.gridMembers.AllowUserToDeleteRows = false;
			this.gridMembers.AllowUserToResizeRows = false;
			this.gridMembers.BackgroundColor = System.Drawing.Color.White;
			this.gridMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMembers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMembers.GridColor = System.Drawing.Color.LightGray;
			this.gridMembers.Location = new System.Drawing.Point(0, 0);
			this.gridMembers.Name = "gridMembers";
			this.gridMembers.ReadOnly = true;
			this.gridMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridMembers.Size = new System.Drawing.Size(310, 351);
			this.gridMembers.TabIndex = 17;
			// 
			// panelMembersAction
			// 
			this.panelMembersAction.Controls.Add(this.panelSearchMembers);
			this.panelMembersAction.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelMembersAction.Location = new System.Drawing.Point(0, 351);
			this.panelMembersAction.Name = "panelMembersAction";
			this.panelMembersAction.Padding = new System.Windows.Forms.Padding(10);
			this.panelMembersAction.Size = new System.Drawing.Size(310, 60);
			this.panelMembersAction.TabIndex = 16;
			// 
			// panelSearchMembers
			// 
			this.panelSearchMembers.Controls.Add(this.inputSearchMembers);
			this.panelSearchMembers.Controls.Add(this.labelSearchMembers);
			this.panelSearchMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelSearchMembers.Location = new System.Drawing.Point(10, 10);
			this.panelSearchMembers.Name = "panelSearchMembers";
			this.panelSearchMembers.Padding = new System.Windows.Forms.Padding(8);
			this.panelSearchMembers.Size = new System.Drawing.Size(290, 40);
			this.panelSearchMembers.TabIndex = 15;
			// 
			// inputSearchMembers
			// 
			this.inputSearchMembers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputSearchMembers.Location = new System.Drawing.Point(123, 8);
			this.inputSearchMembers.Name = "inputSearchMembers";
			this.inputSearchMembers.Size = new System.Drawing.Size(159, 25);
			this.inputSearchMembers.TabIndex = 15;
			this.inputSearchMembers.TextChanged += new System.EventHandler(this.inputSearchMembers_TextChanged);
			// 
			// labelSearchMembers
			// 
			this.labelSearchMembers.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelSearchMembers.Location = new System.Drawing.Point(8, 8);
			this.labelSearchMembers.Name = "labelSearchMembers";
			this.labelSearchMembers.Size = new System.Drawing.Size(115, 24);
			this.labelSearchMembers.TabIndex = 14;
			this.labelSearchMembers.Text = "Search members";
			this.labelSearchMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelBooks
			// 
			this.panelBooks.Controls.Add(this.gridBooks);
			this.panelBooks.Controls.Add(this.panelBooksAction);
			this.panelBooks.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelBooks.Location = new System.Drawing.Point(320, 0);
			this.panelBooks.Name = "panelBooks";
			this.panelBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.panelBooks.Size = new System.Drawing.Size(320, 411);
			this.panelBooks.TabIndex = 1;
			// 
			// gridBooks
			// 
			this.gridBooks.AllowUserToAddRows = false;
			this.gridBooks.AllowUserToDeleteRows = false;
			this.gridBooks.AllowUserToResizeRows = false;
			this.gridBooks.BackgroundColor = System.Drawing.Color.White;
			this.gridBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBooks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridBooks.GridColor = System.Drawing.Color.LightGray;
			this.gridBooks.Location = new System.Drawing.Point(10, 0);
			this.gridBooks.Name = "gridBooks";
			this.gridBooks.ReadOnly = true;
			this.gridBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridBooks.Size = new System.Drawing.Size(310, 351);
			this.gridBooks.TabIndex = 18;
			// 
			// panelBooksAction
			// 
			this.panelBooksAction.Controls.Add(this.panelSearchBooks);
			this.panelBooksAction.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBooksAction.Location = new System.Drawing.Point(10, 351);
			this.panelBooksAction.Name = "panelBooksAction";
			this.panelBooksAction.Padding = new System.Windows.Forms.Padding(10);
			this.panelBooksAction.Size = new System.Drawing.Size(310, 60);
			this.panelBooksAction.TabIndex = 17;
			// 
			// panelSearchBooks
			// 
			this.panelSearchBooks.Controls.Add(this.inputSearchBooks);
			this.panelSearchBooks.Controls.Add(this.labelSearchBooks);
			this.panelSearchBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelSearchBooks.Location = new System.Drawing.Point(10, 10);
			this.panelSearchBooks.Name = "panelSearchBooks";
			this.panelSearchBooks.Padding = new System.Windows.Forms.Padding(8);
			this.panelSearchBooks.Size = new System.Drawing.Size(290, 40);
			this.panelSearchBooks.TabIndex = 15;
			// 
			// inputSearchBooks
			// 
			this.inputSearchBooks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputSearchBooks.Location = new System.Drawing.Point(103, 8);
			this.inputSearchBooks.Name = "inputSearchBooks";
			this.inputSearchBooks.Size = new System.Drawing.Size(179, 25);
			this.inputSearchBooks.TabIndex = 15;
			this.inputSearchBooks.TextChanged += new System.EventHandler(this.inputSearchBooks_TextChanged);
			// 
			// labelSearchBooks
			// 
			this.labelSearchBooks.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelSearchBooks.Location = new System.Drawing.Point(8, 8);
			this.labelSearchBooks.Name = "labelSearchBooks";
			this.labelSearchBooks.Size = new System.Drawing.Size(95, 24);
			this.labelSearchBooks.TabIndex = 14;
			this.labelSearchBooks.Text = "Search books";
			this.labelSearchBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelInfo
			// 
			this.panelInfo.Controls.Add(this.buttonBorrow);
			this.panelInfo.Controls.Add(this.panelExpectedReturnDate);
			this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelInfo.Location = new System.Drawing.Point(640, 0);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Padding = new System.Windows.Forms.Padding(20);
			this.panelInfo.Size = new System.Drawing.Size(244, 411);
			this.panelInfo.TabIndex = 2;
			// 
			// buttonBorrow
			// 
			this.buttonBorrow.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonBorrow.Location = new System.Drawing.Point(20, 95);
			this.buttonBorrow.Name = "buttonBorrow";
			this.buttonBorrow.Size = new System.Drawing.Size(204, 40);
			this.buttonBorrow.TabIndex = 17;
			this.buttonBorrow.Text = "Borrow";
			this.buttonBorrow.UseVisualStyleBackColor = true;
			this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
			// 
			// panelExpectedReturnDate
			// 
			this.panelExpectedReturnDate.Controls.Add(this.dateExpectedReturnDate);
			this.panelExpectedReturnDate.Controls.Add(this.labelExpectedReturnDate);
			this.panelExpectedReturnDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelExpectedReturnDate.Location = new System.Drawing.Point(20, 20);
			this.panelExpectedReturnDate.Name = "panelExpectedReturnDate";
			this.panelExpectedReturnDate.Size = new System.Drawing.Size(204, 75);
			this.panelExpectedReturnDate.TabIndex = 16;
			// 
			// dateExpectedReturnDate
			// 
			this.dateExpectedReturnDate.CustomFormat = "dd/MM/yyyy";
			this.dateExpectedReturnDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.dateExpectedReturnDate.Location = new System.Drawing.Point(0, 35);
			this.dateExpectedReturnDate.Name = "dateExpectedReturnDate";
			this.dateExpectedReturnDate.Size = new System.Drawing.Size(204, 25);
			this.dateExpectedReturnDate.TabIndex = 2;
			// 
			// labelExpectedReturnDate
			// 
			this.labelExpectedReturnDate.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelExpectedReturnDate.Location = new System.Drawing.Point(0, 0);
			this.labelExpectedReturnDate.Name = "labelExpectedReturnDate";
			this.labelExpectedReturnDate.Size = new System.Drawing.Size(204, 35);
			this.labelExpectedReturnDate.TabIndex = 0;
			this.labelExpectedReturnDate.Text = "Expected return date";
			this.labelExpectedReturnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BorrowForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(884, 411);
			this.Controls.Add(this.panelInfo);
			this.Controls.Add(this.panelBooks);
			this.Controls.Add(this.panelMembers);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "BorrowForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Borrow book";
			this.Load += new System.EventHandler(this.BorrowForm_Load);
			this.panelMembers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
			this.panelMembersAction.ResumeLayout(false);
			this.panelSearchMembers.ResumeLayout(false);
			this.panelSearchMembers.PerformLayout();
			this.panelBooks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
			this.panelBooksAction.ResumeLayout(false);
			this.panelSearchBooks.ResumeLayout(false);
			this.panelSearchBooks.PerformLayout();
			this.panelInfo.ResumeLayout(false);
			this.panelExpectedReturnDate.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMembers;
        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelExpectedReturnDate;
        private System.Windows.Forms.DateTimePicker dateExpectedReturnDate;
        private System.Windows.Forms.Label labelExpectedReturnDate;
        private System.Windows.Forms.Panel panelMembersAction;
        private System.Windows.Forms.Panel panelSearchMembers;
        private System.Windows.Forms.TextBox inputSearchMembers;
        private System.Windows.Forms.Label labelSearchMembers;
        private System.Windows.Forms.Panel panelBooksAction;
        private System.Windows.Forms.Panel panelSearchBooks;
        private System.Windows.Forms.TextBox inputSearchBooks;
        private System.Windows.Forms.Label labelSearchBooks;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.DataGridView gridMembers;
        private System.Windows.Forms.DataGridView gridBooks;
    }
}