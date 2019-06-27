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
        private BindingList<string> idAlumnos;
        private long[] dates;
        private DataTable tbAlumnos = new DataTable();
        private int cantHours;
        public CourseHistoryRegister()
        {
            InitializeComponent();
            txtCourse.Enabled = false;
            txtProfessor.Enabled = false;
            txtAssistant.Enabled = false;
            idAlumnos = new BindingList<string>();
            tbAlumnos.Columns.Add("ID", typeof(string));
            tbAlumnos.Columns.Add("Nombre", typeof(string));
            tbAlumnos.Columns.Add("Nota", typeof(float));
            tbAlumnos.Columns.Add("Pagado", typeof(float));
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
            else if (sessions == null || sessions.Length == 0)
            {
                MessageBox.Show("No ingresó sesiones al curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                cantHours = 0;
             
                BindingList<long> auxdates = new BindingList<long>();
                foreach (Server.session s in sessions) {
                    long totalMili = new long();
                    totalMili = (long)(s.dateSession - new DateTime(1970, 1, 1)).TotalMilliseconds + 5L * 60L * 60L * 1000;
                    auxdates.Add(totalMili);
                    cantHours = cantHours + s.hours;
                }
                courseH.hours = cantHours;
                BindingList<Server.student> students = new BindingList<Server.student>();
                foreach (string id in idAlumnos) {
                    Server.student s = server.queryStudentById(id);
                    students.Add(s);
                }               
                courseH.students = students.ToArray();
                BindingList<float?> grades = new BindingList<float?>();
                BindingList<string> states = new BindingList<string>();
                BindingList<float?> amountPaids = new BindingList<float?>();
                float? nota;
                foreach (DataGridViewRow row in dgvStudents.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        nota = float.Parse(row.Cells[2].Value.ToString());
                        grades.Add(nota);
                        if (nota >= 10.5f)
                        {
                            states.Add("APROBADO");
                        }
                        else
                        {
                            states.Add("DESAPROBADO");
                        }
                        amountPaids.Add(float.Parse(row.Cells[3].Value.ToString()));
                    }
                }
                courseH.historyGrade = grades.ToArray();
                courseH.historyState = states.ToArray();
                courseH.amountPaids = amountPaids.ToArray();

                int result = server.insertCourseHistory(courseH, auxdates.ToArray());              
                if (result == 1)
                {
                    mensaje = "Se ha registrado el curso dictado";
                    titulo = "Curso dictado registrado";
                    icono = MessageBoxIcon.Asterisk;
                    mensajeOK = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                    limpiar();
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
            BindingList<Server.session> listsessions;
            if (sessions != null)  listsessions = new BindingList<Server.session>(sessions);
            else  listsessions = new BindingList<Server.session>();
            CourseHAddSession formAddSession = new CourseHAddSession(listsessions);
            if (formAddSession.ShowDialog() == DialogResult.OK) {
                if (formAddSession.ListSession != null) {
                    dgvSessions.AutoGenerateColumns = false;
                    listsessions = formAddSession.ListSession;
                    dgvSessions.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
                    dgvSessions.DataSource = listsessions;
                    
                    sessions = listsessions.ToArray();
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            String fullname;
            server = new Server.ServerClient();
            CourseHAddStudent formAddStudent = new CourseHAddStudent(idAlumnos);
            if (formAddStudent.ShowDialog() == DialogResult.OK) {
                if (formAddStudent.Alumnos != null) {
                    dgvStudents.AutoGenerateColumns = false;
                    idAlumnos = formAddStudent.Alumnos;
                    
                    foreach (string id in idAlumnos)
                    {
                        Server.student s = new Server.student();
                        s = server.queryStudentById(id);
                        fullname = s.firstName + " " + s.primaryLastName + " " + s.secondLastName;
                        tbAlumnos.Rows.Add(s.idNumber, fullname, 0,0);
                    }
                    dgvStudents.DataSource = tbAlumnos;
                    idAlumnos = new BindingList<string>();
                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        if(row.Cells[0].Value != null) idAlumnos.Add(row.Cells[0].Value.ToString());                       
                    }
                }
            }
        }
    }
}
