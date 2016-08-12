using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2.controllers;
using Tema2.utility;
using Tema2.views;

namespace Tema2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void onLoginClick(object sender, EventArgs e)
        {
            try
            {
                string Username = this.txt_Username.Text;
                string Password = this.txt_Password.Text;
                UserManager.getInstance().Login(Username, Password);
                Utility.PrintSuccesMessage("Succesfully logged in");
                this.Hide();
                UserManager.getInstance().Logged().Redirect();
                this.Close();

            }
            catch (Exception exception)
            {
                Utility.PrintErrorMessage(exception.Message);
            }
        }

        private void onRedirectRegisterClick(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            this.Close();
        }
    }
}
