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
    public partial class CourseModify : UserControl
    {

        private static CourseModify _instance;
        private static Panel _panelMdi;
        private byte[] syllabus;
        private string silabo;
        private Server.ServerClient server;
        MessageBoxIcon iconoCorrecto = MessageBoxIcon.Asterisk;

        public CourseModify()
        {
            InitializeComponent();
            establecerEstado(Estado.Inicial);
            server = new Server.ServerClient();
            Server.courseType[] coursetypes = server.queryAllCourseType();
            BindingList<Server.courseType> list_coursetypes = new BindingList<Server.courseType>(coursetypes);
            cmbCourseType.DataSource = list_coursetypes;
            cmbCourseType.DisplayMember = "name";
            
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }
        public static CourseModify Instance {
            get
            {
                if (_instance == null)
                    _instance = new CourseModify();
                return _instance;
            }

        }

        public void establecerEstado(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    txtID.Enabled = true;
                    txtName.Enabled = false;
                    txtDescription.Enabled = false;
                    lblNameSyllabus.Text = "";
                    lblNameSyllabus.Enabled = false;                
                    btnCancel.Enabled = false;
                    btnModify.Enabled = false;
                    btnAddPreKnowledge.Enabled = false;
                    cmbCourseType.Enabled = false;
                    cmbCourseType.Text = "";
                    dataGridView1.DataSource = null;                                     
                    break;

                case Estado.Actualizar:
                    txtID.Enabled = false;
                    txtName.Enabled = true;
                    txtDescription.Enabled = true;
                    lblNameSyllabus.Text = "";
                    lblNameSyllabus.Enabled = true;
                    btnCancel.Enabled = true;
                    btnModify.Enabled = true;
                    btnAddPreKnowledge.Enabled = true;
                    cmbCourseType.Enabled = true;                  
                    break;
            }
        }

        public void limpiar()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            lblNameSyllabus.Text = "";                             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de que quiere cancelar la modificación?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                limpiar();
                establecerEstado(Estado.Inicial);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("No ingresó el N° de documento", "Aviso", MessageBoxButtons.OK);
            }
            else {
                String idCourse = txtID.Text;
                server = new Server.ServerClient();
                Server.course course = server.queryCourseById(idCourse);

                if (course.id == idCourse)
                {
                    establecerEstado(Estado.Actualizar);
                    txtName.Text = course.name;
                    txtDescription.Text = course.description;
                    cmbCourseType.Text = course.courseType.name;
                    syllabus = course.syllabus;
                }
                else
                {
                    DialogResult mensajeError;
                    String mensaje;
                    String titulo;
                    MessageBoxIcon icono;
                    if (!ValidarCodigo(idCourse))
                    {                     
                        mensaje = "ERROR: El código del curso ingresado no es válido.";
                        titulo = "Código de curso no válido";
                        icono = MessageBoxIcon.Error;                       
                    }                  
                    else
                    {
                        mensaje = "ADVERTENCIA: El código de curso ingresado no está registrado.";
                        titulo = "Curso no registrado";
                        icono = MessageBoxIcon.Warning;
                    }
                    mensajeError = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                }
            }
        }
        public enum Estado
        {
            Inicial = 0,
            Nuevo = 1,
            Guardar = 2,
            Actualizar = 3,
            Eliminar = 4
        }

        private bool ValidarCodigo(string codigo)
        {
            if (codigo.Length == 0)
            {
                return false;
            }

            if (codigo.Length != 6) return false;
            var validos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
            bool valido = true;
            foreach (char c in codigo)
            {
                valido = validos.IndexOf(c) != -1;
                if (!valido) break;
            }
            return valido;

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                MessageBox.Show("No ingresó el nombre del curso", "Aviso", MessageBoxButtons.OK);
            else if (txtDescription.Text == "")
                MessageBox.Show("No ingresó la descripción del curso", "Aviso", MessageBoxButtons.OK);
            else {
                server = new Server.ServerClient();
                Server.course course = new Server.course();
                course.id = txtID.Text;
                course.name = txtName.Text;
                course.description = txtDescription.Text;
                course.courseType = (Server.courseType)cmbCourseType.SelectedItem;
                course.isActive = true;
                if (syllabus == null)
                {
                    syllabus = File.ReadAllBytes(silabo);
                }
                course.syllabus = syllabus;
                server.UpdateCourse(course);             
                MessageBox.Show("Se modificó al interesado de manera correcta", "Éxito", MessageBoxButtons.OK, iconoCorrecto);
                limpiar();
                establecerEstado(Estado.Inicial);
            }
        }

        private void btnAddSyllabus_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog opSilabo = new OpenFileDialog();
            opSilabo.Title = "Abrir sílabo del curso";
            opSilabo.Filter = "PDF files|*.pdf";
            if (opSilabo.ShowDialog() == DialogResult.OK)
            {
                silabo = opSilabo.FileName;
                lblNameSyllabus.Text = opSilabo.SafeFileName;
            }
        }
    }
}
