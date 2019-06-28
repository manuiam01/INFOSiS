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
    public partial class CourseHSelectCourseH : Form
    {
        private DataTable table;
        private int idCourseH;
        private Server.ServerClient server;
        private BindingList<Server.courseHistory> courses;
        public CourseHSelectCourseH(String idCourse)
        {
            InitializeComponent();
            idCourseH = 0;
            server = new Server.ServerClient();
            table = new DataTable();
            table.Columns.Add("StartDate", typeof(string));
            table.Columns.Add("EndDate", typeof(string));
            table.Columns.Add("Professor", typeof(string));
            table.Columns.Add("Assistant", typeof(string));
            courses = new BindingList<Server.courseHistory>(server.queryCourseHistoryByCourse(idCourse));
            dgvCursos.AutoGenerateColumns = false;
            foreach (Server.courseHistory c in courses)
            {
                String fullnameP = c.professor.firstName + " " + c.professor.primaryLastName + " " + c.professor.secondLastName;
                String fullnameA = c.assistant.firstName + " " + c.assistant.primaryLastName + " " + c.assistant.secondLastName;
                table.Rows.Add(c.startDate.ToString("dd/MM/yyyy"), c.endDate.ToString("dd/MM/yyyy"),fullnameP, fullnameA);
            }
            dgvCursos.DataSource = table;
        }

        public int IdCourseH { get => idCourseH; set => idCourseH = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dgvCursos.SelectedRows)
            {
                IdCourseH = courses.ElementAt(c.Index).id;
                
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
