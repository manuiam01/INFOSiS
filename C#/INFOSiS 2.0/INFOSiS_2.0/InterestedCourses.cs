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
        /*
        private MySQLCourses controllerCursos;
        private ArrayList<Courses> cursos;
        */
        private DataTable table;
        private BindingList<string> cursos;
        private Server.ServerClient servidor;

        public BindingList<string> Cursos { get => cursos; set => cursos = value; }

        public InterestedCourses()
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            table = new DataTable();
            cursos = new BindingList<string>();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            BindingList<Server.course> courses = new BindingList<Server.course>(servidor.queryAllCourse());
            foreach(Server.course c in courses)
            {
                table.Rows.Add(c.id, c.name);
            }
            dgvCursos.DataSource = table;
            //dgvCursos.DataSource = cursos;
            //u.username = txtUser.Text;
            //u.password = txtPassword.Text;
            //u.acces = servidor.VerifyUser(u);
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
