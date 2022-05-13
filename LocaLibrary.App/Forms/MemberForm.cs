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
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }

        private string getSelectedId()
        {
            if (gridMembers.SelectedRows.Count == 0)
            {
                return null;
            }
            return gridMembers.SelectedRows[0].Cells["Id"].Value.ToString();
        }

        private void emptyForm()
        {
            gridMembers.ClearSelection();
            inputCode.Clear();
            inputFullName.Clear();
            inputClassName.Clear();
            inputStartYear.Clear();
        }

        private string validateForm()
        {
            var code = inputCode.Text;
            var fullName = inputFullName.Text;
            var className = inputClassName.Text;
            var startYear = inputStartYear.Text;

            if (code == "" || fullName == "" || className == "" || startYear == "")
            {
                return "Missing information";
            }
            try
            {
                var value = int.Parse(startYear);
                if (value < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                return "Invalid start year";
            }
            return null;
        }

        private void loadMembers()
        {
            var sql = "SELECT * FROM Member";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            string error = null;
            var dataTable = DatabaseService.GetDataTable(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            gridMembers.DataSource = dataTable;
        }

        private void createMember()
        {
            var sql = @"INSERT INTO Member(Code, FullName, ClassName, StartYear)
                        VALUES (@Code, @FullName, @ClassName, @StartYear)";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Code", inputCode.Text);
            command.Parameters.AddWithValue("@FullName", inputFullName.Text);
            command.Parameters.AddWithValue("@ClassName", inputClassName.Text);
            command.Parameters.AddWithValue("@StartYear", inputStartYear.Text);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
            }
        }

        private void updateMember(string id)
        {
            var sql = @"UPDATE Member
                        SET Code = @Code, FullName = @FullName, ClassName = @ClassName, StartYear = @StartYear
                        WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Code", inputCode.Text);
            command.Parameters.AddWithValue("@FullName", inputFullName.Text);
            command.Parameters.AddWithValue("@ClassName", inputClassName.Text);
            command.Parameters.AddWithValue("@StartYear", inputStartYear.Text);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
            }
        }

        private void deleteMember(string id)
        {
            var sql = @"DELETE FROM Member WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
            }
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void gridMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridMembers.SelectedRows.Count == 0)
            {
                return;
            }
            var row = gridMembers.SelectedRows[0];

            inputCode.Text = row.Cells["Code"].Value.ToString();
            inputFullName.Text = row.Cells["FullName"].Value.ToString();
            inputClassName.Text = row.Cells["ClassName"].Value.ToString();
            inputStartYear.Text = row.Cells["StartYear"].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedId = getSelectedId();
            if (selectedId == null)
            {
                return;
            }
            deleteMember(selectedId);
            loadMembers();
            emptyForm();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var selectedId = getSelectedId();
            if (selectedId == null)
            {
                return;
            }
            var error = validateForm();
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            updateMember(selectedId);
            loadMembers();
            emptyForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var error = validateForm();
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            createMember();
            loadMembers();
            emptyForm();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            loadMembers();
            emptyForm();
        }
    }
}
