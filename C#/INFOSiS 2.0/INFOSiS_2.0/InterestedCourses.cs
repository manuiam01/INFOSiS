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
    public partial class InterestedCourses : Form
    {
        /*
        private MySQLCourses controllerCursos;
        private ArrayList<Courses> cursos;
        */
        private Server.ServerClient servidor;
        public InterestedCourses()
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            Server.course c = new Server.course();
            
            //dgvCursos.DataSource = cursos;
            //u.username = txtUser.Text;
            //u.password = txtPassword.Text;
            //u.acces = servidor.VerifyUser(u);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            /*
            foreach(Course c : (Course)dgvCursos.SelectedRows){
                cursos.add(c);
            */

            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void InterestedCourses_Load(object sender, EventArgs e)
        {

        }
    }
}
