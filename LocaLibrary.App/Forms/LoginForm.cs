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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void OpenMainForm()
        {
            Hide();
            new MainForm().Show();
        }

        private string validateForm()
        {
            var email = inputEmail.Text;
            var password = inputPassword.Text;

            if (email == "")
            {
                return "Email is required";
            }
            if (password == "")
            {
                return "Password is required";
            }
            if (!UtilService.IsValidEmail(email))
            {
                return "Email is invalid";
            }
            return null;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var error = validateForm();
            if (error != null)
            {
                MessageBox.Show(error, "Error");
                return;
            }
            OpenMainForm();
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact any admins for a new password", "Information");
        }
    }
}
