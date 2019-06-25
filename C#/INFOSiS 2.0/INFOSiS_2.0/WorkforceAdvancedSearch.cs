using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFOSiS_2._0.Server;

namespace INFOSiS_2._0
{
    public partial class WorkforceAdvancedSearch : Form
    {
        private Server.ServerClient server;
        private Server.intern intern;

        public WorkforceAdvancedSearch()
        {
            InitializeComponent();
        }

        public intern Intern { get => intern; set => intern = value; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            Server.intern[] interns = server.SearchInternByName(txtFirstName.Text, txtMiddleName.Text, txtPrimaryLastName.Text, txtSecondLastName.Text);
            if (interns == null)
            {
                MessageBox.Show("No se encontraron resultados", "Resultados no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                BindingList<Server.intern> interns_list = new BindingList<Server.intern>(interns);
                dgvInterns.AutoGenerateColumns = false;
                dgvInterns.DataSource = interns_list;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            intern = new Server.intern();
            intern = (Server.intern)dgvInterns.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
