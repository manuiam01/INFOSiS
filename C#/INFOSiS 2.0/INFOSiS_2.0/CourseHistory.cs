using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiS_2._0
{
    public partial class CourseHistory : UserControl
    {

        private static CourseHistory _instance;
        private static Panel _panelMdi;      
        private Server.ServerClient server;
        private Server.course course;


        public CourseHistory()
        {
            InitializeComponent();
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }
        public static CourseHistory Instance {
            get
            {
                if (_instance == null)
                    _instance = new CourseHistory();
                return _instance;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            course = new Server.course();
            course = server.queryCourseById(txtIdCourse.Text);         
            if (course.id != null)
            {
                dgvCoursesHistory.AutoGenerateColumns = false;
                Server.courseHistory[] courses = server.queryCourseHistoryByCourse(course.id);
                dgvCoursesHistory.DataSource = courses;

                int index = 0;
                String fullname = "";
                foreach (Server.courseHistory c in courses)
                {
                    fullname = "";
                    fullname = c.professor.firstName + " " + c.professor.primaryLastName + " " + c.professor.secondLastName;
                    dgvCoursesHistory.Rows[index].Cells[1].Value = fullname;
                    index++;
                }
            }
            else
            {
                MessageBox.Show("Código del curso no encontrado", "Curso no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvCoursesHistory.DataSource = null;
            }
        }

    }
}
