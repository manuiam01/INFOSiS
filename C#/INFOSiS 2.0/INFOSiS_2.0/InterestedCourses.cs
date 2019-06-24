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
    public partial class InterestedCourses : Form
    {
        private DataTable table;
        private BindingList<string> cursos;
        private Server.ServerClient servidor;

        public BindingList<string> Cursos { get => cursos; set => cursos = value; }

        public InterestedCourses(BindingList<string> idcursos)
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            table = new DataTable();
            cursos = new BindingList<string>();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            BindingList<Server.course> courses = new BindingList<Server.course>(servidor.queryAllCourse());
            int enablecourses = courses.Count();
            int coursestaken = idcursos.Count();
            //En caso el tamaño de la lista de cursos en los que está interesado sea la misma
            //que la de los cursos disponibles en INFOPUC
            if (enablecourses == coursestaken && enablecourses!=0)
            {
                MessageBox.Show("Ya escogió todos los cursos de interés disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Server.course c in courses)
                {
                    bool seencuentra = false;
                    foreach (string id in idcursos)
                    {
                        if (c.id.Equals(id))
                        {
                            seencuentra = true;
                            break;
                        }

                    }
                    if (!seencuentra)
                        table.Rows.Add(c.id, c.name);

                }
                dgvCursos.DataSource = table;
            }
            
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            
            foreach(DataGridViewRow c in dgvCursos.SelectedRows){
                cursos.Add(c.Cells[0].Value.ToString());
            }

            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cursos = null;
            this.DialogResult = DialogResult.OK;
        }

        private void InterestedCourses_Load(object sender, EventArgs e)
        {

        }

        private void DgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
