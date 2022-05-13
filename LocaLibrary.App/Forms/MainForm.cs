using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LocaLibrary.App.Forms;
using LocaLibrary.App.Services;

namespace LocaLibrary.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
