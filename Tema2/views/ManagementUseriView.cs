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

namespace Tema2.views
{
    public partial class ManagementUseriView : Form
    {
        public ManagementUseriView()
        {
            InitializeComponent();
        }

        private void loadPendingUsers()
        {
            this.listBox1.DataSource = UserManager.getInstance().GetAllPendingUsers();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
