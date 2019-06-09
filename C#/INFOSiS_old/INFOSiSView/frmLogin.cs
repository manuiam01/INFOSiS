using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiSView
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            string user = txtUsername.Text;
            if (user == "admin"){
                mdiAdmin mdiadmin = new mdiAdmin();
                mdiadmin.ShowDialog();
            }
            else if (user == "coord")
            {
                mdiCoordinator mdicoord = new mdiCoordinator();
                mdicoord.ShowDialog();
            }
            else
            {
                mdiUser mdiuser = new mdiUser();
                mdiuser.ShowDialog();
            }
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
