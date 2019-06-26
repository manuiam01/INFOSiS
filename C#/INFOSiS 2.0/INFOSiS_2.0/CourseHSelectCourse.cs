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
    public partial class CourseHSelectCourse : Form
    {

        private DataTable table;
        private String idCourse;
        private Server.ServerClient server;
        
        public CourseHSelectCourse()
        {
            InitializeComponent();
            server = new Server.ServerClient();
            table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            BindingList<Server.course> courses = new BindingList<Server.course>(server.queryAllCourse());         
            foreach (Server.course c in courses)
            {               
                table.Rows.Add(c.id, c.name);
            }
            dgvCursos.DataSource = table;
        }

        public string IdCourse { get => idCourse; set => idCourse = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow c in dgvCursos.SelectedRows)
            {
                IdCourse = c.Cells[0].Value.ToString();
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
