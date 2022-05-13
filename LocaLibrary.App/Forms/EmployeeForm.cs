using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LocaLibrary.App.Commons;
using LocaLibrary.App.Services;

namespace LocaLibrary.App.Forms
{
    public partial class EmployeeForm : Form, ICrudForm
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public DataGridView GetGrid()
        {
            return gridEmployees;
        }

        public string GetSelectedId()
        {
            if (GetGrid().SelectedRows.Count == 0)
            {
                return null;
            }
            return GetGrid().SelectedRows[0].Cells["Id"].Value.ToString();
        }

        public void EmptyForm()
        {
            GetGrid().ClearSelection();
            inputEmail.Clear();
            inputFullName.Clear();
            checkIsAdmin.Checked = false;
            checkIsLocked.Checked = false;
            inputNewPassword.Clear();
        }

        public string ValidateForm()
        {
            var email = inputEmail.Text;
            var fullName = inputFullName.Text;

            if (email == "" || fullName == "")
            {
                return "Missing information";
            }
            return null;
        }

        public void LoadAll()
        {
            var sql = "SELECT Id, Email, FullName, IsAdmin, IsLocked FROM Employee";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            string error = null;
            var dataTable = DatabaseService.GetDataTable(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            GetGrid().DataSource = dataTable;
        }

        public void Create()
        {
            var DEFAULT_PASSWORD = "123456";
            var sql = @"INSERT INTO Employee(Email, PasswordHash, FullName, IsAdmin, IsLocked)
                        VALUES (@Email, PWDENCRYPT(@DefaultPassword), @FullName, @IsAdmin, @IsLocked)";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Email", inputEmail.Text);
            command.Parameters.AddWithValue("@DefaultPassword", DEFAULT_PASSWORD);
            command.Parameters.AddWithValue("@FullName", inputFullName.Text);
            command.Parameters.AddWithValue("@IsAdmin", checkIsAdmin.Checked);
            command.Parameters.AddWithValue("@IsLocked", checkIsLocked.Checked);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            MessageBox.Show("Default password for new user is " + DEFAULT_PASSWORD, "Information");
        }

        public void Update(string id)
        {
            var sql = @"UPDATE Employee
                        SET Email = @Email, FullName = @FullName, IsAdmin = @IsAdmin, IsLocked = @IsLocked
                        WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Email", inputEmail.Text);
            command.Parameters.AddWithValue("@FullName", inputFullName.Text);
            command.Parameters.AddWithValue("@IsAdmin", checkIsAdmin.Checked);
            command.Parameters.AddWithValue("@IsLocked", checkIsLocked.Checked);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
        }

        public void Delete(string id)
        {
            var sql = @"DELETE FROM Employee WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
        }

        private void gridEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (GetGrid().SelectedRows.Count == 0)
            {
                return;
            }
            var row = GetGrid().SelectedRows[0];

            inputEmail.Text = row.Cells["Email"].Value.ToString();
            inputFullName.Text = row.Cells["FullName"].Value.ToString();
            checkIsAdmin.Checked = (bool)row.Cells["IsAdmin"].Value;
            checkIsLocked.Checked = (bool)row.Cells["IsLocked"].Value;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedId = GetSelectedId();
            if (selectedId == null)
            {
                return;
            }
            Delete(selectedId);
            LoadAll();
            EmptyForm();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedId = GetSelectedId();
            if (selectedId == null)
            {
                return;
            }
            var error = ValidateForm();
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            Update(selectedId);
            LoadAll();
            EmptyForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var error = ValidateForm();
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            Create();
            LoadAll();
            EmptyForm();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadAll();
            EmptyForm();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            var selectedId = GetSelectedId();
            if (selectedId == null)
            {
                return;
            }
            var newPassword = inputNewPassword.Text;
            if (newPassword == "")
            {
                MessageBox.Show("New password is required", "Error");
                return;
            }
            var confirmResult = MessageBox.Show(
                "Do you want to reset password for this employee?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            var sql = @"UPDATE Employee
                        SET PasswordHash = PWDENCRYPT(@NewPassword)
                        WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", selectedId);
            command.Parameters.AddWithValue("@NewPassword", newPassword);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
        }
    }
}
