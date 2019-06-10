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
        public InterestedCourses()
        {
            InitializeComponent();
            //ArrayList<Courses> cursos = new ArrayList<Courses>();
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
    }
}
