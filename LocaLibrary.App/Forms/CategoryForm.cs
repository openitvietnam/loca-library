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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private string getSelectedId()
        {
            if (gridCategories.SelectedRows.Count == 0)
            {
                return null;
            }
            return gridCategories.SelectedRows[0].Cells["Id"].Value.ToString();
        }

        private void emptyForm()
        {
            gridCategories.ClearSelection();
            inputName.Clear();
        }

        private string validateForm()
        {
            var name = inputName.Text;
            if (name == "")
            {
                return "Missing information";
            }
            return null;
        }

        private void loadCategories()
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
            gridCategories.DataSource = dataTable;
        }

        private void createCategory()
        {
            var sql = @"INSERT INTO Category(Name) VALUES (@Name)";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Name", inputName.Text);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
            }
        }

        private void updateCategory(string id)
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
            }
        }

        private void deleteCategory(string id)
        {
            var sql = @"DELETE FROM Category WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedId = getSelectedId();
            if (selectedId == null)
            {
                return;
            }
            deleteCategory(selectedId);
            loadCategories();
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
            updateCategory(selectedId);
            loadCategories();
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
            createCategory();
            loadCategories();
            emptyForm();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            loadCategories();
            emptyForm();
        }

        private void gridCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCategories.SelectedRows.Count == 0)
            {
                return;
            }
            var row = gridCategories.SelectedRows[0];

            inputName.Text = row.Cells["Name"].Value.ToString();
        }
    }
}
