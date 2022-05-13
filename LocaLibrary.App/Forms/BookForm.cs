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
    public partial class BookForm : Form, ICrudForm
    {
        public BookForm()
        {
            InitializeComponent();
        }

        public DataGridView GetGrid()
        {
            return gridBooks;
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
            inputTitle.Clear();
            inputAuthor.Clear();
            inputPublisher.Clear();
            inputPublishYear.Clear();
            inputLanguage.Clear();
            inputPrice.Clear();
        }

        public string ValidateForm()
        {
            var title = inputTitle.Text;
            var author = inputAuthor.Text;
            var publisher = inputPublisher.Text;
            var publishYear = inputPublishYear.Text;
            var language = inputLanguage.Text;
            var price = inputPrice.Text;

            if (title == "" || author == "" || publisher == "" ||
                publishYear == "" || language == "" || price == "")
            {
                return "Missing information";
            }
            try
            {
                var value = int.Parse(publishYear);
                if (value < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                return "Invalid publish year";
            }
            try
            {
                var value = float.Parse(price);
                if (value < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                return "Invalid price";
            }
            return null;
        }

        public void LoadAll()
        {
            var sql = "SELECT * FROM Book";
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
            var sql = @"INSERT INTO Book(Title, Author, Publisher, PublishYear, Language, Price)
                        VALUES (@Title, @Author, @Publisher, @PublishYear, @Language, @Price)";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Title", inputTitle.Text);
            command.Parameters.AddWithValue("@Author", inputAuthor.Text);
            command.Parameters.AddWithValue("@Publisher", inputPublisher.Text);
            command.Parameters.AddWithValue("@PublishYear", inputPublishYear.Text);
            command.Parameters.AddWithValue("@Language", inputLanguage.Text);
            command.Parameters.AddWithValue("@Price", inputPrice.Text);

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
            var sql = @"UPDATE Book
                        SET Title = @Title, Author = @Author, Publisher = @Publisher,
                            PublishYear = @PublishYear, Language = @Language, Price = @Price
                        WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Title", inputTitle.Text);
            command.Parameters.AddWithValue("@Author", inputAuthor.Text);
            command.Parameters.AddWithValue("@Publisher", inputPublisher.Text);
            command.Parameters.AddWithValue("@PublishYear", inputPublishYear.Text);
            command.Parameters.AddWithValue("@Language", inputLanguage.Text);
            command.Parameters.AddWithValue("@Price", inputPrice.Text);

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
            var sql = @"DELETE FROM Book WHERE Id = @Id";
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

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadAll();
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

        private void gridBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (GetGrid().SelectedRows.Count == 0)
            {
                return;
            }
            var row = GetGrid().SelectedRows[0];

            inputTitle.Text = row.Cells["Title"].Value.ToString();
            inputAuthor.Text = row.Cells["Author"].Value.ToString();
            inputPublisher.Text = row.Cells["Publisher"].Value.ToString();
            inputPublishYear.Text = row.Cells["PublishYear"].Value.ToString();
            inputLanguage.Text = row.Cells["Language"].Value.ToString();
            inputPrice.Text = row.Cells["Price"].Value.ToString();
        }
    }
}
