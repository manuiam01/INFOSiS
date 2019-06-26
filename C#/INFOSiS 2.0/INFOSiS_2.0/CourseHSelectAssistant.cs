using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiS_2._0
{
    public partial class CourseHSelectAssistant : Form
    {
        private DataTable table;
        private String idAssistant;
        private Server.ServerClient server;
        public CourseHSelectAssistant()
        {
            InitializeComponent();
            server = new Server.ServerClient();
            table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            BindingList<Server.professor> assistants = new BindingList<Server.professor>(server.queryAllProfessorsActive());
            String fullname;
            foreach (Server.professor a in assistants)
            {
                fullname = a.firstName + " " + a.primaryLastName + " " + a.secondLastName;
                table.Rows.Add(a.idPUCP, fullname);
            }
            dgvCursos.DataSource = table;
        }

        public string IdAssistant { get => idAssistant; set => idAssistant = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dgvCursos.SelectedRows)
            {
                IdAssistant = c.Cells[0].Value.ToString();
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
