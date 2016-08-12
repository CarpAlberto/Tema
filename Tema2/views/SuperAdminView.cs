using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2.views
{
    public partial class SuperAdminView : Form
    {
        public SuperAdminView()
        {
            InitializeComponent();
        }

        private void SuperAdminView_Load(object sender, EventArgs e)
        {

        }

        private void loadSuperAdmin()
        {
            new ManagementUseriView().ShowDialog();
        }
        private void link_Mana_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadSuperAdmin();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadSuperAdmin();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            loadSuperAdmin();
        }
    }
}
