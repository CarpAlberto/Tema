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

namespace Tema2.views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            loadComboData();
        }
        private void loadComboData()
        {
            this.comboBox1.DataSource = UserManager.getInstance().LoadAllPermissions();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void onRegisterClick(object sender, EventArgs e)
        {
            try
            {
                string Username = this.txt_Username.Text.ToString();
                string Password = this.txt_Password.Text.ToString();
                controllers.Permisiuni permisiune = (controllers.Permisiuni) this.comboBox1.SelectedIndex;
                UserManager.getInstance().addNewAccount(Username, Password, permisiune);
                Utility.PrintSuccesMessage("Username added succesfully!  ");

            }
            catch(Exception exception)
            {
                Utility.PrintErrorMessage(exception.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Close();
        }
    }
}
