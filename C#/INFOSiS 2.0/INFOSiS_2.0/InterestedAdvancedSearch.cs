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
    public partial class InterestedAdvancedSearch : Form
    {
        private Server.ServerClient servidor;
        private Server.interested inte;
        public InterestedAdvancedSearch()
        {
            InitializeComponent();
        }

        public interested Inte { get => inte; set => inte = value; }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(tbApeMa.Text.Equals("") &&
                tbApePa.Text.Equals("") &&
                tbNombre.Text.Equals("") &&
                tbSNombre.Text.Equals(""))
                MessageBox.Show("No se ingresó información alguna", "Aviso", MessageBoxButtons.OK);
            else
            {
                servidor = new Server.ServerClient();
                Server.interested[] interesteds = servidor.SearchInterestedByName(tbNombre.Text, tbSNombre.Text, tbApePa.Text, tbApeMa.Text);
                if (interesteds == null)
                {
                    MessageBox.Show("No se encontraron resultados", "Resultados no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dgvInteresados.DataSource = null;
                }
                else
                {
                    BindingList<Server.interested> interested_list = new BindingList<Server.interested>(interesteds);
                    dgvInteresados.AutoGenerateColumns = false;
                    dgvInteresados.DataSource = interested_list;
                }

            }

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            inte = new Server.interested();
            inte = (Server.interested)dgvInteresados.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
