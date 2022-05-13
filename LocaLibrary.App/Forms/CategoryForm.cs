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
    public partial class CategoryForm : Form, ICrudForm
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        public DataGridView GetGrid()
        {
            return gridCategories;
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
            inputName.Clear();
        }

        public string ValidateForm()
        {
            var name = inputName.Text;
            if (name == "")
            {
                return "Missing information";
            }
            return null;
        }

        public void LoadAll()
        {
            var sql = "SELECT * FROM Category";
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
            var sql = @"INSERT INTO Category(Name) VALUES (@Name)";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Name", inputName.Text);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
        }

        public void Update(string id)
        {
            var sql = @"UPDATE Category SET Name = @Name WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", inputName.Text);

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
            var sql = @"DELETE FROM Category WHERE Id = @Id";
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

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            LoadAll();
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

        private void gridCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (GetGrid().SelectedRows.Count == 0)
            {
                return;
            }
            var row = GetGrid().SelectedRows[0];

            inputName.Text = row.Cells["Name"].Value.ToString();
        }
    }
}
