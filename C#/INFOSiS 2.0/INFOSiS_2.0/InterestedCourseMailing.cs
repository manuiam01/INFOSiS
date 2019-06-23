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
    public partial class InterestedCourseMailing : Form
    {
        private Server.ServerClient servidor;
        private DataTable table;
        private BindingList<Server.courseHistory> courseH;

        public InterestedCourseMailing(DateTime coursedate,int idCourse)
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            //dgvCourses.AutoGenerateColumns = false;
            table = new DataTable();
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Fecha inicio", typeof(DateTime));
            table.Columns.Add("Fecha fin", typeof(DateTime));
            table.Columns.Add("Horas totales", typeof(int));

            courseH =  new BindingList<Server.courseHistory>(servidor.queryCourseHByDate(coursedate));
            foreach(Server.courseHistory c in courseH)
            {
                table.Rows.Add(c.course.name, c.sessions[0],c.sessions[1], c.hours);
            }
            dgvCourses.DataSource = table;
            
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int i = dgvCourses.CurrentRow.Index;
            
            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void InterestedCourseMailing_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbCourse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
