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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }

        private void EmptyForm()
        {
            GetMemberGrid().ClearSelection();
            GetBookGrid().ClearSelection();
            dateExpectedReturnDate.Value = DateTime.Now;
        }

        private string ValidateForm()
        {
            var expectedReturnDate = dateExpectedReturnDate.Value;
            if (expectedReturnDate.Date < DateTime.Now.Date)
            {
                return "Invalid expected return date";
            }
            if (GetMemberGrid().SelectedRows.Count == 0)
            {
                return "Member is required";
            }
            if (GetBookGrid().SelectedRows.Count == 0)
            {
                return "Book is required";
            }
            return null;
        }

        private DataGridView GetMemberGrid()
        {
            return gridMembers;
        }

        private DataGridView GetBookGrid()
        {
            return gridBooks;
        }

        private void LoadAllMembers()
        {
            var search = inputSearchMembers.Text;
            var sql = search == ""
                ? "SELECT * FROM Member"
                : @"SELECT *
                    FROM Member
                    WHERE Code LIKE @SearchLike OR FullName LIKE @SearchLike OR ClassName LIKE @SearchLike";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            if (search != "")
            {
                command.Parameters.AddWithValue("@SearchLike", "%" + search + "%");
            }

            string error = null;
            var dataTable = DatabaseService.GetDataTable(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            GetMemberGrid().DataSource = dataTable;
        }

        private void LoadAllBooks()
        {
            var search = inputSearchBooks.Text;
            var sql = search == ""
                ? "SELECT * FROM Book"
                : "SELECT * FROM Book WHERE Title LIKE @SearchLike OR Author LIKE @SearchLike";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            if (search != "")
            {
                command.Parameters.AddWithValue("@SearchLike", "%" + search + "%");
            }

            string error = null;
            var dataTable = DatabaseService.GetDataTable(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            GetBookGrid().DataSource = dataTable;
        }

        private void BorrowBook()
        {
            var memberId = GetMemberGrid().SelectedRows[0].Cells["Id"].Value.ToString();
            var bookId = GetBookGrid().SelectedRows[0].Cells["Id"].Value.ToString();

            var sql = @"INSERT INTO BookBorrow(BookId, MemberId, EmployeeId, BorrowDate, ExpectedReturnDate)
                        VALUES (@BookId, @MemberId, @EmployeeId, @BorrowDate, @ExpectedReturnDate)";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@MemberId", memberId);
            command.Parameters.AddWithValue("@BookId", bookId);
            command.Parameters.AddWithValue("@EmployeeId", AuthService.UserLogin.Id);
            command.Parameters.AddWithValue("@BorrowDate", DateTime.Now.Date);
            command.Parameters.AddWithValue("@ExpectedReturnDate", dateExpectedReturnDate.Value.Date);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            LoadAllMembers();
            LoadAllBooks();
        }

        private void inputSearchMembers_TextChanged(object sender, EventArgs e)
        {
            LoadAllMembers();
        }

        private void inputSearchBooks_TextChanged(object sender, EventArgs e)
        {
            LoadAllBooks();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            var error = ValidateForm();
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            BorrowBook();
            EmptyForm();
            Close();
        }
    }
}
