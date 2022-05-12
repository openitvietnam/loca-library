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
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.panelFullName = new System.Windows.Forms.Panel();
            this.inputFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.panelActions.SuspendLayout();
            this.panelFullName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonSaveChanges);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(30, 95);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panelActions.Size = new System.Drawing.Size(284, 60);
            this.panelActions.TabIndex = 4;
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
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.panelActions);
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
            this.panelActions.ResumeLayout(false);
            this.panelFullName.ResumeLayout(false);
            this.panelFullName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Panel panelFullName;
        private System.Windows.Forms.TextBox inputFullName;
        private System.Windows.Forms.Label labelFullName;
    }
}
