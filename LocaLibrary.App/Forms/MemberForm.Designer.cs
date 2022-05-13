namespace LocaLibrary.App.Forms
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.gridMembers = new System.Windows.Forms.DataGridView();
            this.panelAction = new System.Windows.Forms.Panel();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelCode = new System.Windows.Forms.Panel();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.inputFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panelClassName = new System.Windows.Forms.Panel();
            this.inputClassName = new System.Windows.Forms.TextBox();
            this.labelClassName = new System.Windows.Forms.Label();
            this.panelStartYear = new System.Windows.Forms.Panel();
            this.inputStartYear = new System.Windows.Forms.TextBox();
            this.labelStartYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).BeginInit();
            this.panelAction.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelCode.SuspendLayout();
            this.panelFullName.SuspendLayout();
            this.panelClassName.SuspendLayout();
            this.panelStartYear.SuspendLayout();
            this.SuspendLayout();
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
            this.gridMembers.Size = new System.Drawing.Size(544, 441);
            this.gridMembers.TabIndex = 9;
            this.gridMembers.SelectionChanged += new System.EventHandler(this.gridMembers_SelectionChanged);
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
            this.panelAction.TabIndex = 8;
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
            this.panelInfo.Controls.Add(this.panelStartYear);
            this.panelInfo.Controls.Add(this.panelClassName);
            this.panelInfo.Controls.Add(this.panelFullName);
            this.panelInfo.Controls.Add(this.panelCode);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfo.Location = new System.Drawing.Point(544, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(20);
            this.panelInfo.Size = new System.Drawing.Size(240, 501);
            this.panelInfo.TabIndex = 7;
            // 
            // panelCode
            // 
            this.panelCode.Controls.Add(this.inputCode);
            this.panelCode.Controls.Add(this.labelCode);
            this.panelCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCode.Location = new System.Drawing.Point(20, 20);
            this.panelCode.Name = "panelCode";
            this.panelCode.Size = new System.Drawing.Size(200, 75);
            this.panelCode.TabIndex = 13;
            // 
            // inputCode
            // 
            this.inputCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputCode.Location = new System.Drawing.Point(0, 35);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(200, 25);
            this.inputCode.TabIndex = 1;
            // 
            // labelCode
            // 
            this.labelCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCode.Location = new System.Drawing.Point(0, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(200, 35);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code";
            this.labelCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // panelClassName
            // 
            this.panelClassName.Controls.Add(this.inputClassName);
            this.panelClassName.Controls.Add(this.labelClassName);
            this.panelClassName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClassName.Location = new System.Drawing.Point(20, 170);
            this.panelClassName.Name = "panelClassName";
            this.panelClassName.Size = new System.Drawing.Size(200, 75);
            this.panelClassName.TabIndex = 15;
            // 
            // inputClassName
            // 
            this.inputClassName.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputClassName.Location = new System.Drawing.Point(0, 35);
            this.inputClassName.Name = "inputClassName";
            this.inputClassName.Size = new System.Drawing.Size(200, 25);
            this.inputClassName.TabIndex = 1;
            // 
            // labelClassName
            // 
            this.labelClassName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelClassName.Location = new System.Drawing.Point(0, 0);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(200, 35);
            this.labelClassName.TabIndex = 0;
            this.labelClassName.Text = "Class name";
            this.labelClassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStartYear
            // 
            this.panelStartYear.Controls.Add(this.inputStartYear);
            this.panelStartYear.Controls.Add(this.labelStartYear);
            this.panelStartYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStartYear.Location = new System.Drawing.Point(20, 245);
            this.panelStartYear.Name = "panelStartYear";
            this.panelStartYear.Size = new System.Drawing.Size(200, 75);
            this.panelStartYear.TabIndex = 16;
            // 
            // inputStartYear
            // 
            this.inputStartYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputStartYear.Location = new System.Drawing.Point(0, 35);
            this.inputStartYear.Name = "inputStartYear";
            this.inputStartYear.Size = new System.Drawing.Size(200, 25);
            this.inputStartYear.TabIndex = 1;
            // 
            // labelStartYear
            // 
            this.labelStartYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStartYear.Location = new System.Drawing.Point(0, 0);
            this.labelStartYear.Name = "labelStartYear";
            this.labelStartYear.Size = new System.Drawing.Size(200, 35);
            this.labelStartYear.TabIndex = 0;
            this.labelStartYear.Text = "Start year";
            this.labelStartYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.gridMembers);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member list";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMembers)).EndInit();
            this.panelAction.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelCode.ResumeLayout(false);
            this.panelCode.PerformLayout();
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.panelClassName.ResumeLayout(false);
            this.panelClassName.PerformLayout();
            this.panelStartYear.ResumeLayout(false);
            this.panelStartYear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMembers;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelCode;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Panel panelStartYear;
        private System.Windows.Forms.TextBox inputStartYear;
        private System.Windows.Forms.Label labelStartYear;
        private System.Windows.Forms.Panel panelClassName;
        private System.Windows.Forms.TextBox inputClassName;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox inputFullName;
        private System.Windows.Forms.Label labelFullName;
    }
}
