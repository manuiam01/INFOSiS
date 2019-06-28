using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace INFOSiS_2._0
{

    public partial class CourseHistoryModify : UserControl
    {
        private static CourseHistoryModify _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private Server.course course;
        private Server.professor professor;
        private Server.professor assistant;
        private Server.session[] sessions;
        private BindingList<string> idAlumnos;
        private BindingList<float?> grades;
        private BindingList<float?> amountPaid;
        private Server.courseHistory courseH;

        private DataTable tbAlumnos = new DataTable();
        private int cantHours;
        public CourseHistoryModify()
        {
            InitializeComponent();
            txtCourse.Enabled = false;
            txtProfessor.Enabled = false;
            txtAssistant.Enabled = false;
            idAlumnos = new BindingList<string>();
            grades = new BindingList<float?>();
            amountPaid = new BindingList<float?>();
            tbAlumnos.Columns.Add("ID", typeof(string));
            tbAlumnos.Columns.Add("Nombre", typeof(string));
            tbAlumnos.Columns.Add("Nota", typeof(float));
            tbAlumnos.Columns.Add("Pagado", typeof(float));
        }
        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }
        public static CourseHistoryModify Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CourseHistoryModify();
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
            if (sessions != null) listsessions = new BindingList<Server.session>(sessions);
            else listsessions = new BindingList<Server.session>();
            CourseHAddSession formAddSession = new CourseHAddSession(listsessions);
            if (formAddSession.ShowDialog() == DialogResult.OK)
            {
                if (formAddSession.ListSession != null)
                {
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
            if (formAddStudent.ShowDialog() == DialogResult.OK)
            {
                if (formAddStudent.Alumnos != null)
                {
                    dgvStudents.AutoGenerateColumns = false;
                    idAlumnos = formAddStudent.Alumnos;

                    foreach (string id in idAlumnos)
                    {
                        Server.student s = new Server.student();
                        s = server.queryStudentById(id);
                        fullname = s.firstName + " " + s.primaryLastName + " " + s.secondLastName;
                        tbAlumnos.Rows.Add(s.idNumber, fullname, 0, 0);
                    }
                    dgvStudents.DataSource = tbAlumnos;
                    idAlumnos = new BindingList<string>();
                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        if (row.Cells[0].Value != null) idAlumnos.Add(row.Cells[0].Value.ToString());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dgvStudents.SelectedRows)
            {
                idAlumnos.RemoveAt(c.Index);
                grades.RemoveAt(c.Index);
                amountPaid.RemoveAt(c.Index);
            }
            BindingList<String> auxAlumnos = new BindingList<string>();
            BindingList<float?> auxGrades = new BindingList<float?>();
            BindingList<float?> auxAmount = new BindingList<float?>();
            int tam = idAlumnos.Count();
            for (int i = 0; i < tam; i++)
            {
                auxAlumnos.Add(idAlumnos.ElementAt(i));
                auxGrades.Add(grades.ElementAt(i));
                auxAmount.Add(amountPaid.ElementAt(i));
            }
            tbAlumnos.Clear();
            for (int i = 0; i < auxAlumnos.Count(); i++)
            {
                Server.student s = new Server.student();
                s = server.queryStudentById(auxAlumnos.ElementAt(i));
                String fullname = s.firstName + " " + s.primaryLastName + " " + s.secondLastName;
                tbAlumnos.Rows.Add(s.idNumber, fullname, auxGrades.ElementAt(i), auxAmount.ElementAt(i));
            }
            dgvStudents.DataSource = tbAlumnos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dgvStudents.Rows)
            {
                if (c.Cells[2].Value != null)
                {
                    grades.Insert(c.Index, float.Parse(c.Cells[2].Value.ToString()));
                    amountPaid.Insert(c.Index, float.Parse(c.Cells[3].Value.ToString()));
                }

            }
            server = new Server.ServerClient();
            BindingList<String> idStudents = new BindingList<string>();
            
            StreamReader reader;
            bool hayAlumnos = false;
            OpenFileDialog opSilabo = new OpenFileDialog();
            opSilabo.Title = "Abrir archivo de alumnos del Curso";
            opSilabo.Filter = "CSV Files|*.csv";
            if (opSilabo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (reader = new StreamReader(opSilabo.FileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            String line = reader.ReadLine();
                            String[] values = line.Split(';');
                            if (values[4].Equals("MATRICULADO"))
                            {
                                String codPucp = values[1];
                                String FirstLastName = values[5];
                                String SecondLastName = values[6];
                                String[] nombres = values[7].Split(' ');
                                String firstName = nombres[0];
                                String middleName = "";
                                for (int i = 1; i < nombres.Length; i++)
                                {
                                    if (i > 1) middleName = middleName + " ";
                                    middleName = middleName + nombres[i];
                                }
                                String birthday = values[8];
                                DateTime dateNacimiento = Convert.ToDateTime(birthday);
                                birthday = dateNacimiento.ToString("yyyy/MM/dd");
                                char[] b = new char[values[9].Length];
                                b = values[9].ToCharArray();
                                String Gender = b[0].ToString();

                                values[10] = values[10].Replace(" ", String.Empty);
                                values[11] = values[11].Replace(" ", String.Empty);
                                values[12] = values[12].Replace(" ", String.Empty);
                                int idtype;
                                String idNumber;
                                if (values[11] != "")
                                {
                                    idtype = 0;
                                    idNumber = values[11];
                                }
                                else if (values[12] != "")
                                {
                                    idtype = 1;
                                    idNumber = values[12];
                                }
                                else
                                {
                                    idtype = 2;
                                    idNumber = values[10];
                                }
                                String address = values[22];
                                String email = values[24];
                                String cellPhone = values[25];
                                String homePhone = values[26];
                                Server.interested interested = new Server.interested();
                                interested.idNumber = idNumber;
                                interested.idType = idtype;
                                interested.firstName = firstName;
                                interested.middleName = middleName;
                                interested.primaryLastName = FirstLastName;
                                interested.secondLastName = SecondLastName;
                                interested.gender = Gender;
                                interested.email = email;
                                interested.cellPhoneNumber = cellPhone;
                                interested.isUnsubscribed = false;
                                server.InsertInterested(interested);

                                //Server.student s = new Server.student();
                                //s.idNumber = idNumber;
                                Server.student student = server.queryStudentById(idNumber);
                                bool seEncuentra = false;
                                BindingList<String> listaPucp;
                                if (student.idNumber == idNumber)
                                {

                                    if (student.idPUCPList != null)
                                    {
                                        listaPucp = new BindingList<string>(student.idPUCPList);
                                        foreach (String str in listaPucp)
                                        {
                                            if (str == codPucp) seEncuentra = true;
                                        }
                                        if (!seEncuentra) listaPucp.Add(codPucp);

                                    }
                                    else
                                    {
                                        listaPucp = new BindingList<string>();
                                        listaPucp.Add(codPucp);
                                    }

                                    student.idPUCPList = new string[listaPucp.Count];
                                    listaPucp.CopyTo(student.idPUCPList, 0);
                                    int result = server.updateStudent(student, birthday);
                                }
                                else
                                {
                                    student = new Server.student();
                                    student.idNumber = idNumber;
                                    student.address = address;
                                    student.homePhone = homePhone;
                                    listaPucp = new BindingList<string>();
                                    listaPucp.Add(codPucp);
                                    student.idPUCPList = new string[listaPucp.Count];
                                    listaPucp.CopyTo(student.idPUCPList, 0);
                                    int result = server.InsertStudent(student, birthday);

                                }
                                seEncuentra = false;
                                foreach (String str in idAlumnos)
                                {
                                    if (str == idNumber) seEncuentra = true;
                                }
                                if (!seEncuentra)
                                    idStudents.Add(idNumber);
                            }



                        }
                    }
                    if (idStudents != null)
                    {
                        BindingList<String> auxAlumnos = new BindingList<string>();
                        BindingList<float?> auxGrades = new BindingList<float?>();
                        BindingList<float?> auxAmount = new BindingList<float?>();
                        int tam = idAlumnos.Count();
                        for (int i = 0; i < tam; i++)
                        {
                            auxAlumnos.Add(idAlumnos.ElementAt(i));
                            auxGrades.Add(grades.ElementAt(i));
                            auxAmount.Add(amountPaid.ElementAt(i));
                        }
                        foreach (String id in idStudents)
                        {
                            auxAlumnos.Add(id);
                            idAlumnos.Add(id);
                            auxGrades.Add(0f);
                            grades.Add(0f);
                            auxAmount.Add(0f);
                            amountPaid.Add(0f);

                        }
                        tbAlumnos.Clear();
                        for (int i = 0; i < auxAlumnos.Count(); i++)
                        {
                            Server.student s = new Server.student();
                            s = server.queryStudentById(auxAlumnos.ElementAt(i));
                            String fullname = s.firstName + " " + s.primaryLastName + " " + s.secondLastName;
                            tbAlumnos.Rows.Add(s.idNumber, fullname, auxGrades.ElementAt(i), auxAmount.ElementAt(i));
                        }
                        dgvStudents.DataSource = tbAlumnos;
                        dgvStudents.AutoGenerateColumns = false;
                        idAlumnos = idStudents;

                        foreach (string id in idAlumnos)
                        {
                            Server.student s = new Server.student();
                            s = server.queryStudentById(id);
                            String fullname = s.firstName + " " + s.primaryLastName + " " + s.secondLastName;
                            tbAlumnos.Rows.Add(s.idNumber, fullname, 0, 0);
                        }
                        dgvStudents.DataSource = tbAlumnos;
                        idAlumnos = new BindingList<string>();
                        foreach (DataGridViewRow row in dgvStudents.Rows)
                        {
                            if (row.Cells[0].Value != null) idAlumnos.Add(row.Cells[0].Value.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El archivo seleccionado es inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
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
            else
            {
                DialogResult mensajeOK;
                String mensaje;
                String titulo;
                MessageBoxIcon icono;
                //Server.courseHistory courseH = new Server.courseHistory();
                courseH.course = course;
                courseH.professor = professor;
                courseH.assistant = assistant;
                courseH.sessions = sessions;
                cantHours = 0;

                BindingList<long> auxdates = new BindingList<long>();
                foreach (Server.session s in sessions)
                {
                    long totalMili = new long();
                    totalMili = (long)(s.dateSession - new DateTime(1970, 1, 1)).TotalMilliseconds + 5L * 60L * 60L * 1000;
                    auxdates.Add(totalMili);
                    cantHours = cantHours + s.hours;
                }
                courseH.hours = cantHours;
                BindingList<Server.student> students = new BindingList<Server.student>();
                foreach (string id in idAlumnos)
                {
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

                int result = server.updateCourseHistory(courseH, auxdates.ToArray());
                if (result == 1)
                {
                    mensaje = "Se ha modificado el curso dictado";
                    titulo = "Curso dictado registrado";
                    icono = MessageBoxIcon.Asterisk;
                    mensajeOK = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                    limpiar();
                }
                else
                {
                    mensaje = "No se pudo modificar el curso dictado";
                    titulo = "Curso dictado no registrado";
                    icono = MessageBoxIcon.Asterisk;
                    mensajeOK = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            courseH = new Server.courseHistory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            CourseHSelectCourseH formCourseH = new CourseHSelectCourseH(txtSearchCourse.Text);
           
            if (formCourseH.ShowDialog() == DialogResult.OK)
            {

                if (formCourseH.IdCourseH != null)
                {
                    courseH = server.queryCourseHById(formCourseH.IdCourseH);
                    professor = courseH.professor;
                    assistant = courseH.assistant;
                    course = courseH.course;
                    txtCourse.Text = course.name;
                    txtProfessor.Text = professor.firstName + " " + professor.primaryLastName + " " + professor.secondLastName;
                    txtAssistant.Text = assistant.firstName + " " + assistant.primaryLastName + " " + assistant.secondLastName;

                    BindingList<Server.session> listsessions;
                    if (courseH.sessions != null) listsessions = new BindingList<Server.session>(sessions);
                    else listsessions = new BindingList<Server.session>();
                      if (listsessions != null)
                        {
                            dgvSessions.AutoGenerateColumns = false;                            
                            dgvSessions.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
                            dgvSessions.DataSource = listsessions;

                            sessions = listsessions.ToArray();
                        }


                    
                    String fullname;
                    
                    
                        if (courseH.students != null)
                        {

                            dgvStudents.AutoGenerateColumns = false;
                            BindingList<String> auxAlumnos = new BindingList<string>();
                            BindingList<float?> auxGrades = new BindingList<float?>();
                            BindingList<float?> auxAmount = new BindingList<float?>();
                            int tam = courseH.students.Count();
                            for (int i = 0; i < tam; i++)
                            {
                                auxAlumnos.Add(courseH.students.ElementAt(i).idNumber);
                                auxGrades.Add(courseH.historyGrade.ElementAt(i));
                                auxAmount.Add(courseH.amountPaids.ElementAt(i));
                                idAlumnos.Add(courseH.students.ElementAt(i).idNumber);
                                grades.Add(courseH.historyGrade.ElementAt(i));
                                amountPaid.Add(courseH.amountPaids.ElementAt(i));
                            }
                            
                            tbAlumnos.Clear();
                            for (int i = 0; i < auxAlumnos.Count(); i++)
                            {
                                Server.student s = new Server.student();
                                s = server.queryStudentById(auxAlumnos.ElementAt(i));
                                fullname = s.firstName + " " + s.primaryLastName + " " + s.secondLastName;
                                tbAlumnos.Rows.Add(s.idNumber, fullname, auxGrades.ElementAt(i), auxAmount.ElementAt(i));
                            }
                            dgvStudents.DataSource = tbAlumnos;
                        }
                    


                }

            }
        }
    }
}
