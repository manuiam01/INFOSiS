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
    public partial class CourseHistoryRegister : UserControl
    {

        private static CourseHistoryRegister _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private Server.course course;
        private Server.professor professor;
        private Server.professor assistant;
        private Server.session[] sessions;
        public CourseHistoryRegister()
        {
            InitializeComponent();
            txtCourse.Enabled = false;
            txtProfessor.Enabled = false;
            txtAssistant.Enabled = false;
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }
        public static CourseHistoryRegister Instance {
            get
            {
                if (_instance == null)
                    _instance = new CourseHistoryRegister();
                return _instance;
            }
        }

        public void limpiar()
        {
            course = null;
            professor = null;
            assistant = null;
            txtCourse.Text = "";
            txtProfessor.Text = "";
            txtAssistant.Text = "";
            dgvSessions.DataSource = null;
            dgvStudents.DataSource = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCourse.Text == "")
            {
                MessageBox.Show("No ingresó el curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtProfessor.Text == "")
            {
                MessageBox.Show("No ingresó el profesor del cursp", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if (sessions == null || sessions.Length == 0)
            //{
            //    MessageBox.Show("No ingresó sesiones al curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else {
                DialogResult mensajeOK;
                String mensaje;
                String titulo;
                MessageBoxIcon icono;
                Server.courseHistory courseH = new Server.courseHistory();
                courseH.course = course;
                courseH.professor = professor;
                courseH.assistant = assistant;              
                courseH.sessions = sessions;
                courseH.hours = 24;
                int result = server.insertCourseHistory(courseH);              
                if (result == 1)
                {
                    mensaje = "Se ha registrado el curso dictado";
                    titulo = "Curso dictado registrado";
                    icono = MessageBoxIcon.Asterisk;
                    mensajeOK = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                }
                else
                {
                    mensaje = "No se pudo registrar el curso dictado";
                    titulo = "Curso dictado no registrado";
                    icono = MessageBoxIcon.Asterisk;
                    mensajeOK = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                }
            }
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            CourseHSelectCourse formCourseHSelectCourse = new CourseHSelectCourse();
            if (formCourseHSelectCourse.ShowDialog() == DialogResult.OK)
            {
                
                if (formCourseHSelectCourse.IdCourse != null)
                {
                    course = server.queryCourseById(formCourseHSelectCourse.IdCourse);
                    txtCourse.Text = course.name;                   
                }

            }
        }

        private void btnSearchProfessor_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            CourseHSelectProfessor formCourseHSelectCourse = new CourseHSelectProfessor();
            if (formCourseHSelectCourse.ShowDialog() == DialogResult.OK)
            {

                if (formCourseHSelectCourse.IdAssistant != null)
                {
                    professor = server.SearchProfessorByIdPUCP(formCourseHSelectCourse.IdAssistant);
                    txtProfessor.Text = formCourseHSelectCourse.Fullname;
                }

            }
        }

        private void btnSearchAssistant_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            CourseHSelectProfessor formCourseHSelectCourse = new CourseHSelectProfessor();
            if (formCourseHSelectCourse.ShowDialog() == DialogResult.OK)
            {
                if (formCourseHSelectCourse.IdAssistant != null)
                {
                    assistant = server.SearchProfessorByIdPUCP(formCourseHSelectCourse.IdAssistant);
                    txtAssistant.Text = formCourseHSelectCourse.Fullname;
                }

            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            CourseHAddSession formAddSession = new CourseHAddSession(sessions);
            if (formAddSession.ShowDialog() == DialogResult.OK) {
                if (formAddSession.Sessions != null) {
                    dgvSessions.AutoGenerateColumns = false;
                    sessions = formAddSession.Sessions;
                    BindingList<Server.session> listSession = new BindingList<Server.session>(sessions);
                    dgvSessions.DataSource = listSession;
                    int index = 0;
                    foreach (Server.session session in listSession)
                    {
                        dgvSessions.Rows[index].Cells[0].Value = session.dateSession.ToString();
                        index++;
                    }
                }
            }
        }
    }
}
