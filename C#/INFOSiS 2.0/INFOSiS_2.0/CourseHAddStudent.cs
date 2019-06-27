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
    public partial class CourseHAddStudent : Form
    {

        private DataTable table;
        private BindingList<string> alumnos;
        private Server.ServerClient servidor;
        private String fullname;
        public CourseHAddStudent(BindingList<string> idAlumnos)
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            table = new DataTable();
            Alumnos = new BindingList<string>();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            BindingList<Server.student> students = new BindingList<Server.student>(servidor.queryAllStudent());
            //En caso el tamaño de la lista de cursos en los que está interesado sea la misma
            //que la de los cursos disponibles en INFOPUC
            if (idAlumnos == null) idAlumnos = new BindingList<string>();
            foreach (Server.student s in students)
            {
                bool seencuentra = false;
                foreach (string id in idAlumnos)
                {
                    if (s.idNumber.Equals(id))
                    {
                        seencuentra = true;
                        break;
                    }

                }
                if (!seencuentra) { 
                    fullname = s.firstName + " " + s.primaryLastName + " " + s.secondLastName;
                    table.Rows.Add(s.idNumber, fullname);
                }

            }
            dgvStudents.DataSource = table;
        }

        public BindingList<string> Alumnos { get => alumnos; set => alumnos = value; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Alumnos = null;
            this.DialogResult = DialogResult.OK;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dgvStudents.SelectedRows)
            {
                Alumnos.Add(c.Cells[0].Value.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
