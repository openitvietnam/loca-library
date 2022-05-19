namespace LocaLibrary.App.Forms
{
    partial class BookForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
			this.panelInfo = new System.Windows.Forms.Panel();
			this.panelPrice = new System.Windows.Forms.Panel();
			this.inputPrice = new System.Windows.Forms.TextBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.panelLanguage = new System.Windows.Forms.Panel();
			this.inputLanguage = new System.Windows.Forms.TextBox();
			this.labelLanguage = new System.Windows.Forms.Label();
			this.panelPublishYear = new System.Windows.Forms.Panel();
			this.inputPublishYear = new System.Windows.Forms.TextBox();
			this.labelPublishYear = new System.Windows.Forms.Label();
			this.panelPublisher = new System.Windows.Forms.Panel();
			this.inputPublisher = new System.Windows.Forms.TextBox();
			this.labelPublisher = new System.Windows.Forms.Label();
			this.panelAuthor = new System.Windows.Forms.Panel();
			this.inputAuthor = new System.Windows.Forms.TextBox();
			this.labelAuthor = new System.Windows.Forms.Label();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.inputTitle = new System.Windows.Forms.TextBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panelAction = new System.Windows.Forms.Panel();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.inputSearch = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.buttonReload = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.gridBooks = new System.Windows.Forms.DataGridView();
			this.panelInfo.SuspendLayout();
			this.panelPrice.SuspendLayout();
			this.panelLanguage.SuspendLayout();
			this.panelPublishYear.SuspendLayout();
			this.panelPublisher.SuspendLayout();
			this.panelAuthor.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panelAction.SuspendLayout();
			this.panelSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// panelInfo
			// 
			this.panelInfo.AutoScroll = true;
			this.panelInfo.Controls.Add(this.panelPrice);
			this.panelInfo.Controls.Add(this.panelLanguage);
			this.panelInfo.Controls.Add(this.panelPublishYear);
			this.panelInfo.Controls.Add(this.panelPublisher);
			this.panelInfo.Controls.Add(this.panelAuthor);
			this.panelInfo.Controls.Add(this.panelTitle);
			this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelInfo.Location = new System.Drawing.Point(744, 0);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Padding = new System.Windows.Forms.Padding(20);
			this.panelInfo.Size = new System.Drawing.Size(240, 501);
			this.panelInfo.TabIndex = 1;
			// 
			// panelPrice
			// 
			this.panelPrice.Controls.Add(this.inputPrice);
			this.panelPrice.Controls.Add(this.labelPrice);
			this.panelPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPrice.Location = new System.Drawing.Point(20, 395);
			this.panelPrice.Name = "panelPrice";
			this.panelPrice.Size = new System.Drawing.Size(200, 75);
			this.panelPrice.TabIndex = 18;
			// 
			// inputPrice
			// 
			this.inputPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.inputPrice.Location = new System.Drawing.Point(0, 35);
			this.inputPrice.Name = "inputPrice";
			this.inputPrice.Size = new System.Drawing.Size(200, 25);
			this.inputPrice.TabIndex = 1;
			// 
			// labelPrice
			// 
			this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPrice.Location = new System.Drawing.Point(0, 0);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(200, 35);
			this.labelPrice.TabIndex = 0;
			this.labelPrice.Text = "Price";
			this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelLanguage
			// 
			this.panelLanguage.Controls.Add(this.inputLanguage);
			this.panelLanguage.Controls.Add(this.labelLanguage);
			this.panelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLanguage.Location = new System.Drawing.Point(20, 320);
			this.panelLanguage.Name = "panelLanguage";
			this.panelLanguage.Size = new System.Drawing.Size(200, 75);
			this.panelLanguage.TabIndex = 17;
			// 
			// inputLanguage
			// 
			this.inputLanguage.Dock = System.Windows.Forms.DockStyle.Top;
			this.inputLanguage.Location = new System.Drawing.Point(0, 35);
			this.inputLanguage.Name = "inputLanguage";
			this.inputLanguage.Size = new System.Drawing.Size(200, 25);
			this.inputLanguage.TabIndex = 1;
			// 
			// labelLanguage
			// 
			this.labelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelLanguage.Location = new System.Drawing.Point(0, 0);
			this.labelLanguage.Name = "labelLanguage";
			this.labelLanguage.Size = new System.Drawing.Size(200, 35);
			this.labelLanguage.TabIndex = 0;
			this.labelLanguage.Text = "Language";
			this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelPublishYear
			// 
			this.panelPublishYear.Controls.Add(this.inputPublishYear);
			this.panelPublishYear.Controls.Add(this.labelPublishYear);
			this.panelPublishYear.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPublishYear.Location = new System.Drawing.Point(20, 245);
			this.panelPublishYear.Name = "panelPublishYear";
			this.panelPublishYear.Size = new System.Drawing.Size(200, 75);
			this.panelPublishYear.TabIndex = 16;
			// 
			// inputPublishYear
			// 
			this.inputPublishYear.Dock = System.Windows.Forms.DockStyle.Top;
			this.inputPublishYear.Location = new System.Drawing.Point(0, 35);
			this.inputPublishYear.Name = "inputPublishYear";
			this.inputPublishYear.Size = new System.Drawing.Size(200, 25);
			this.inputPublishYear.TabIndex = 1;
			// 
			// labelPublishYear
			// 
			this.labelPublishYear.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPublishYear.Location = new System.Drawing.Point(0, 0);
			this.labelPublishYear.Name = "labelPublishYear";
			this.labelPublishYear.Size = new System.Drawing.Size(200, 35);
			this.labelPublishYear.TabIndex = 0;
			this.labelPublishYear.Text = "Publish year";
			this.labelPublishYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelPublisher
			// 
			this.panelPublisher.Controls.Add(this.inputPublisher);
			this.panelPublisher.Controls.Add(this.labelPublisher);
			this.panelPublisher.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelPublisher.Location = new System.Drawing.Point(20, 170);
			this.panelPublisher.Name = "panelPublisher";
			this.panelPublisher.Size = new System.Drawing.Size(200, 75);
			this.panelPublisher.TabIndex = 15;
			// 
			// inputPublisher
			// 
			this.inputPublisher.Dock = System.Windows.Forms.DockStyle.Top;
			this.inputPublisher.Location = new System.Drawing.Point(0, 35);
			this.inputPublisher.Name = "inputPublisher";
			this.inputPublisher.Size = new System.Drawing.Size(200, 25);
			this.inputPublisher.TabIndex = 1;
			// 
			// labelPublisher
			// 
			this.labelPublisher.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPublisher.Location = new System.Drawing.Point(0, 0);
			this.labelPublisher.Name = "labelPublisher";
			this.labelPublisher.Size = new System.Drawing.Size(200, 35);
			this.labelPublisher.TabIndex = 0;
			this.labelPublisher.Text = "Publisher";
			this.labelPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelAuthor
			// 
			this.panelAuthor.Controls.Add(this.inputAuthor);
			this.panelAuthor.Controls.Add(this.labelAuthor);
			this.panelAuthor.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelAuthor.Location = new System.Drawing.Point(20, 95);
			this.panelAuthor.Name = "panelAuthor";
			this.panelAuthor.Size = new System.Drawing.Size(200, 75);
			this.panelAuthor.TabIndex = 14;
			// 
			// inputAuthor
			// 
			this.inputAuthor.Dock = System.Windows.Forms.DockStyle.Top;
			this.inputAuthor.Location = new System.Drawing.Point(0, 35);
			this.inputAuthor.Name = "inputAuthor";
			this.inputAuthor.Size = new System.Drawing.Size(200, 25);
			this.inputAuthor.TabIndex = 1;
			// 
			// labelAuthor
			// 
			this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelAuthor.Location = new System.Drawing.Point(0, 0);
			this.labelAuthor.Name = "labelAuthor";
			this.labelAuthor.Size = new System.Drawing.Size(200, 35);
			this.labelAuthor.TabIndex = 0;
			this.labelAuthor.Text = "Author";
			this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.inputTitle);
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(20, 20);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(200, 75);
			this.panelTitle.TabIndex = 13;
			// 
			// inputTitle
			// 
			this.inputTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.inputTitle.Location = new System.Drawing.Point(0, 35);
			this.inputTitle.Name = "inputTitle";
			this.inputTitle.Size = new System.Drawing.Size(200, 25);
			this.inputTitle.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(200, 35);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Title";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelAction
			// 
			this.panelAction.Controls.Add(this.panelSearch);
			this.panelAction.Controls.Add(this.buttonReload);
			this.panelAction.Controls.Add(this.buttonAdd);
			this.panelAction.Controls.Add(this.buttonUpdate);
			this.panelAction.Controls.Add(this.buttonDelete);
			this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelAction.Location = new System.Drawing.Point(0, 441);
			this.panelAction.Name = "panelAction";
			this.panelAction.Padding = new System.Windows.Forms.Padding(10);
			this.panelAction.Size = new System.Drawing.Size(744, 60);
			this.panelAction.TabIndex = 3;
			// 
			// panelSearch
			// 
			this.panelSearch.Controls.Add(this.inputSearch);
			this.panelSearch.Controls.Add(this.labelSearch);
			this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelSearch.Location = new System.Drawing.Point(465, 10);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Padding = new System.Windows.Forms.Padding(8);
			this.panelSearch.Size = new System.Drawing.Size(269, 40);
			this.panelSearch.TabIndex = 13;
			// 
			// inputSearch
			// 
			this.inputSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inputSearch.Location = new System.Drawing.Point(63, 8);
			this.inputSearch.Name = "inputSearch";
			this.inputSearch.Size = new System.Drawing.Size(198, 25);
			this.inputSearch.TabIndex = 15;
			this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
			// 
			// labelSearch
			// 
			this.labelSearch.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelSearch.Location = new System.Drawing.Point(8, 8);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(55, 24);
			this.labelSearch.TabIndex = 14;
			this.labelSearch.Text = "Search";
			this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.gridBooks.Location = new System.Drawing.Point(0, 0);
			this.gridBooks.Name = "gridBooks";
			this.gridBooks.ReadOnly = true;
			this.gridBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridBooks.Size = new System.Drawing.Size(744, 441);
			this.gridBooks.TabIndex = 4;
			// 
			// BookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(984, 501);
			this.Controls.Add(this.gridBooks);
			this.Controls.Add(this.panelAction);
			this.Controls.Add(this.panelInfo);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "BookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Book list";
			this.Load += new System.EventHandler(this.BookForm_Load);
			this.panelInfo.ResumeLayout(false);
			this.panelPrice.ResumeLayout(false);
			this.panelPrice.PerformLayout();
			this.panelLanguage.ResumeLayout(false);
			this.panelLanguage.PerformLayout();
			this.panelPublishYear.ResumeLayout(false);
			this.panelPublishYear.PerformLayout();
			this.panelPublisher.ResumeLayout(false);
			this.panelPublisher.PerformLayout();
			this.panelAuthor.ResumeLayout(false);
			this.panelAuthor.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panelAction.ResumeLayout(false);
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panelLanguage;
        private System.Windows.Forms.TextBox inputLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Panel panelPublishYear;
        private System.Windows.Forms.TextBox inputPublishYear;
        private System.Windows.Forms.Label labelPublishYear;
        private System.Windows.Forms.Panel panelPublisher;
        private System.Windows.Forms.TextBox inputPublisher;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Panel panelAuthor;
        private System.Windows.Forms.TextBox inputAuthor;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Label labelSearch;
    }
}
