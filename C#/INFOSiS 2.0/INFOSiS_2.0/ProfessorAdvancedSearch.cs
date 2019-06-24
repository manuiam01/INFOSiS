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
    public partial class ProfessorAdvancedSearch : Form
    {

        private Server.ServerClient server;
        private Server.professor professor;
        public ProfessorAdvancedSearch()
        {
            InitializeComponent();
        }

        public professor Professor { get => professor; set => professor = value; }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            Server.professor[] professors = server.SearchProfessorByName(txtName.Text, txtMiddleName.Text, txtFirstLastName.Text, txtSecondLastName.Text);
            if (professors == null)
            {
                MessageBox.Show("No se encontraron resultados", "Resultados no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                BindingList<Server.professor> professors_list = new BindingList<Server.professor>(professors);
                dgvProfessors.AutoGenerateColumns = false;
                dgvProfessors.DataSource = professors_list;
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            professor = new Server.professor();
            professor = (Server.professor)dgvProfessors.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
