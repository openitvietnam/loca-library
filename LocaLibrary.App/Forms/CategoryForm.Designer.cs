namespace LocaLibrary.App.Forms
{
    partial class CategoryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
			this.panelAction = new System.Windows.Forms.Panel();
			this.buttonReload = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.panelName = new System.Windows.Forms.Panel();
			this.inputName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.gridCategories = new System.Windows.Forms.DataGridView();
			this.panelAction.SuspendLayout();
			this.panelInfo.SuspendLayout();
			this.panelName.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
			this.SuspendLayout();
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
			this.panelAction.TabIndex = 5;
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
			this.panelInfo.Controls.Add(this.panelName);
			this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelInfo.Location = new System.Drawing.Point(544, 0);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Padding = new System.Windows.Forms.Padding(20);
			this.panelInfo.Size = new System.Drawing.Size(240, 501);
			this.panelInfo.TabIndex = 4;
			// 
			// panelName
			// 
			this.panelName.Controls.Add(this.inputName);
			this.panelName.Controls.Add(this.labelName);
			this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelName.Location = new System.Drawing.Point(20, 20);
			this.panelName.Name = "panelName";
			this.panelName.Size = new System.Drawing.Size(200, 75);
			this.panelName.TabIndex = 13;
			// 
			// inputName
			// 
			this.inputName.Dock = System.Windows.Forms.DockStyle.Top;
			this.inputName.Location = new System.Drawing.Point(0, 35);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(200, 25);
			this.inputName.TabIndex = 1;
			// 
			// labelName
			// 
			this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelName.Location = new System.Drawing.Point(0, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(200, 35);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gridCategories
			// 
			this.gridCategories.AllowUserToAddRows = false;
			this.gridCategories.AllowUserToDeleteRows = false;
			this.gridCategories.AllowUserToResizeRows = false;
			this.gridCategories.BackgroundColor = System.Drawing.Color.White;
			this.gridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCategories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridCategories.GridColor = System.Drawing.Color.LightGray;
			this.gridCategories.Location = new System.Drawing.Point(0, 0);
			this.gridCategories.Name = "gridCategories";
			this.gridCategories.ReadOnly = true;
			this.gridCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.gridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridCategories.Size = new System.Drawing.Size(544, 441);
			this.gridCategories.TabIndex = 7;
			this.gridCategories.SelectionChanged += new System.EventHandler(this.gridCategories_SelectionChanged);
			// 
			// CategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 501);
			this.Controls.Add(this.gridCategories);
			this.Controls.Add(this.panelAction);
			this.Controls.Add(this.panelInfo);
			this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CategoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Category list";
			this.Load += new System.EventHandler(this.CategoryForm_Load);
			this.panelAction.ResumeLayout(false);
			this.panelInfo.ResumeLayout(false);
			this.panelName.ResumeLayout(false);
			this.panelName.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView gridCategories;
    }
}
