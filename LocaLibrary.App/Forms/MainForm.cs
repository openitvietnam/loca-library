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
using LocaLibrary.App.Forms;
using LocaLibrary.App.Services;

namespace LocaLibrary.App
{
    public partial class MainForm : Form, ICrudForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public DataGridView GetGrid()
        {
            return gridBookBorrows;
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
            dateExpectedReturnDate.Value = DateTime.Now;
            buttonSelectBook.Tag = null;
            buttonSelectMember.Tag = null;
        }

        public string ValidateForm()
        {
            var expectedReturnDate = dateExpectedReturnDate.Value;
            var memberId = buttonSelectMember.Tag;
            var bookId = buttonSelectBook.Tag;

            if (expectedReturnDate.Date < DateTime.Now.Date)
            {
                return "Invalid expected return date";
            }
            if (memberId == null)
            {
                return "Member is required";
            }
            if (bookId == null)
            {
                return "Book is required";
            }
            return null;
        }

        public void LoadAll()
        {
            var sql = @"SELECT
                            bb.Id, bb.IsDone, bb.BorrowDate,
                            bb.ExpectedReturnDate, bb.ReturnDate,                           
                            b.Id AS BookId, b.Title AS BookTitle,
                            m.Id AS MemberId, m.Code AS MemberCode, 
                            m.FullName AS MemberFullName, m.ClassName as MemberClassName,
                            e.FullName AS EmployeeFullName
                        FROM BookBorrow bb
                            INNER JOIN Book b ON bb.BookId = b.Id
                            INNER JOIN Member m ON bb.MemberId = m.Id
                            INNER JOIN Employee e ON bb.EmployeeId = e.Id
                        ORDER BY bb.BorrowDate, bb.Id DESC";
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

        public void Create() {
            var sql = @"INSERT INTO BookBorrow(BookId, MemberId, EmployeeId, BorrowDate, ExpectedReturnDate)
                        VALUES (@BookId, @MemberId, @EmployeeId, @BorrowDate, @ExpectedReturnDate)";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@BookId", buttonSelectBook.Tag);
            command.Parameters.AddWithValue("@MemberId", buttonSelectMember.Tag);
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

        public void Update(string id) {
            // Just set IsDone = true
            var sql = @"UPDATE BookBorrow
                        SET IsDone = 1, ReturnDate = @ReturnDate
                        WHERE Id = @Id";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@ReturnDate", DateTime.Now);

            string error = null;
            DatabaseService.Execute(command, ref error);
            if (error != null)
            {
                MessageBox.Show(error, "Error");
            }
        }

        public void Delete(string id) {
            // Do nothing
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            // https://docs.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/start-internet-browser
            const string HOMEPAGE_URL = "https://github.com/openitvietnam/loca-library";
            try
            {
                System.Diagnostics.Process.Start(HOMEPAGE_URL);
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message, "Error");
            }
            catch (Exception other)
            {
                MessageBox.Show(other.Message, "Error");
            }
        }

        private void menuItemCheckForUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available", "Information");
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            AuthService.Logout();
            Close();
        }

        private void menuItemEditProfile_Click(object sender, EventArgs e)
        {
            new EditProfileForm().ShowDialog();
        }

        private void menuItemBooks_Click(object sender, EventArgs e)
        {
            new BookForm().ShowDialog();
        }

        private void menuItemCategorys_Click(object sender, EventArgs e)
        {
            new CategoryForm().ShowDialog();
        }

        private void menuItemMembers_Click(object sender, EventArgs e)
        {
            new MemberForm().ShowDialog();
        }

        private void menuItemEmployees_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!AuthService.UserLogin.IsAdmin)
            {
                menuItemManage.Enabled = false;
            }

            // Load current user
            labelCurrentUserFullName.Text = AuthService.UserLogin.FullName;
            labelCurrentUserEmail.Text = AuthService.UserLogin.Email;
            labelToday.Text = DateTime.Today.ToString("dd/MM/yyyy");

            // Load book overview
            var borrowingBookCount = 0;
            var totalBookCount = 0;
            labelBorrowingBookCount.Text = String.Format("Borrowing: {0}", borrowingBookCount);
            labelTotalBookCount.Text = String.Format("Total: {0}", totalBookCount);

            LoadAll();
        }

        private void gridBookBorrows_SelectionChanged(object sender, EventArgs e)
        {
            if (GetGrid().SelectedRows.Count == 0)
            {
                return;
            }
            var row = GetGrid().SelectedRows[0];

            dateExpectedReturnDate.Value = Convert.ToDateTime(row.Cells["ExpectedReturnDate"].Value);
            buttonSelectBook.Tag = row.Cells["BookId"].Value.ToString();
            buttonSelectMember.Tag = row.Cells["MemberId"].Value.ToString();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadAll();
            EmptyForm();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
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

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            var selectedId = GetSelectedId();
            if (selectedId == null)
            {
                return;
            }
            Update(selectedId);
            LoadAll();
            EmptyForm();
        }
    }
}
