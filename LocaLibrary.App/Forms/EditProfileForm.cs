using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LocaLibrary.App.Services;

namespace LocaLibrary.App.Forms
{
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            InitializeComponent();
        }

        private void checkLogin()
        {
            if (AuthService.UserLogin == null)
            {
                MessageBox.Show("User is not logged in", "Error");
                Close();
            }
        }

        private void loadProfile()
        {
            var sql = @"SELECT FullName FROM Employee WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", AuthService.UserLogin.Id);

            string error = null;
            var dataTable = DatabaseService.GetDataTable(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("User not found", "Error");
                return;
            }
            inputFullName.Text = dataTable.Rows[0]["FullName"].ToString();
        }

        private string validateForm()
        {
            var fullName = inputFullName.Text;
            if (fullName == "")
            {
                return "Full name is required";
            }
            return null;
        }

        private void updateProfile()
        {
            var sql = @"UPDATE Employee SET FullName = @FullName WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@FullName", inputFullName.Text);
            command.Parameters.AddWithValue("@Id", AuthService.UserLogin.Id);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            checkLogin();
            loadProfile();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            var error = validateForm();
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            updateProfile();
            Close();
        }
    }
}
