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
        }

        public string ValidateForm()
        {
            // Do nothing
            return null;
        }

        public void LoadAll()
        {
            var searchMembers = inputSearchMembers.Text;
            var searchBooks = inputSearchBooks.Text;
            var overDue = comboFilterOverDue.SelectedIndex; // 0 is all, 1 is over due

            // In combobox, 0 is all, 1 is borrowing, 2 is returned
            // Convert to -1 is all, IsDone match to 0, 1
            var status = comboFilterStatus.SelectedIndex - 1;

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
                        WHERE
                            (@SearchMembersLike = '%%'
                                OR m.Code LIKE @SearchMembersLike 
                                OR m.FullName LIKE @SearchMembersLike 
                                OR m.ClassName LIKE @SearchMembersLike)
                            AND (@SearchBooksLike = '%%'
                                OR b.Title LIKE @SearchBooksLike
                                OR b.Author LIKE @SearchBooksLike)
                            AND (@OverDue = 0 OR GETDATE() >= bb.ExpectedReturnDate)
                            AND (@Status = -1 OR bb.IsDone = @Status)
                        ORDER BY bb.BorrowDate DESC, bb.Id DESC";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            command.Parameters.AddWithValue("@SearchMembersLike", "%" + searchMembers + "%");
            command.Parameters.AddWithValue("@SearchBooksLike", "%" + searchBooks + "%");
            command.Parameters.AddWithValue("@OverDue", overDue);
            command.Parameters.AddWithValue("@Status", status);

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
            // Do nothing
        }

        public void Update(string id)
        {
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
                return;
            }
        }

        public void Delete(string id)
        {
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
            comboFilterStatus.SelectedIndex = 0;
            comboFilterOverDue.SelectedIndex = 0;

            // Load current user
            labelCurrentUserFullName.Text = AuthService.UserLogin.FullName;
            labelCurrentUserEmail.Text = AuthService.UserLogin.Email;
            labelToday.Text = DateTime.Today.ToString("dd/MM/yyyy");

            // Load book overview
            var borrowingBookCount = getBorrowingBookCount();
            var totalBookCount = getTotalBookCount();
            labelBorrowingBookCount.Text = String.Format("Borrowing: {0}", borrowingBookCount);
            labelTotalBookCount.Text = String.Format("Total: {0}", totalBookCount);

            LoadAll();
        }

        private int getBorrowingBookCount()
        {
            var sql = @"SELECT count(Id) FROM BookBorrow WHERE IsDone = 0";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            string error = null;
            var value = DatabaseService.GetValue(command, ref error);
            if (error != null)
            {
                return 0;
            }
            return (int)value;
        }

        private int getTotalBookCount()
        {
            var sql = @"SELECT count(Id) FROM Book";
            var command = DatabaseService.CreateCommand(sql, CommandType.Text);
            string error = null;
            var value = DatabaseService.GetValue(command, ref error);
            if (error != null)
            {
                return 0;
            }
            return (int)value;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadAll();
            EmptyForm();
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            new BorrowForm().ShowDialog();
            LoadAll();
            EmptyForm();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Confirm return books?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }
            var selectedId = GetSelectedId();
            if (selectedId == null)
            {
                return;
            }
            Update(selectedId);
            LoadAll();
            EmptyForm();
        }

        private void comboFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAll();
            EmptyForm();
        }

        private void comboFilterOverDue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAll();
            EmptyForm();
        }

        private void inputSearchMembers_TextChanged(object sender, EventArgs e)
        {
            LoadAll();
            EmptyForm();
        }

        private void inputSearchBooks_TextChanged(object sender, EventArgs e)
        {
            LoadAll();
            EmptyForm();
        }
    }
}
