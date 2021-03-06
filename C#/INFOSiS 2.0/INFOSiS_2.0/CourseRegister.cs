﻿using System;
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
    public partial class CourseRegister : UserControl
    {
        private static CourseRegister _instance;
        private static Panel _panelMdi;
        private string silabo;
        private Server.ServerClient server;

        public static CourseRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CourseRegister();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public CourseRegister()
        {
            InitializeComponent();
            silabo = "";
            server = new Server.ServerClient();
            Server.courseType[] coursetypes = server.queryAllCourseType();
            BindingList<Server.courseType> list_coursetypes = new BindingList<Server.courseType>(coursetypes);
            cmbCourseType.DataSource = list_coursetypes;
            cmbCourseType.DisplayMember = "name";
            
        }

        public void limpiar()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            lblNameSyllabus.Text = "";
            silabo = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String codigo = txtID.Text;
            if (txtID.Text == "")
            {
                MessageBox.Show("No ingresó el código del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("No ingresó el nombre del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtDescription.Text == "")
            {
                MessageBox.Show("No ingresó la descripción del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (silabo == "") {
                MessageBox.Show("No ingresó el sílabo del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!ValidarCodigo(codigo))
            {
                DialogResult mensajeError;
                String mensaje;
                String titulo;
                MessageBoxIcon icono;
                mensaje = "ERROR: El código del curso ingresado no es válido.";
                titulo = "Código de curso no válido";
                icono = MessageBoxIcon.Error;
                mensajeError = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
            }
            else
            {
                DialogResult mensajeOK;
                String mensaje;
                String titulo;
                MessageBoxIcon icono;

                Server.course s = new Server.course();
                s.id = txtID.Text;
                s.name = txtName.Text;
                s.description = txtDescription.Text;
                s.courseType = (Server.courseType)cmbCourseType.SelectedItem;
                s.isActive = true;
                byte[] syllabus = File.ReadAllBytes(silabo);
                s.syllabus = syllabus;
                int result = server.InsertCourse(s);
                if (result == 1)
                {
                    mensaje = "Se ha registrado el curso";
                    titulo = "Curso registrado";
                    icono = MessageBoxIcon.Asterisk;
                    mensajeOK = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                    limpiar();
                }
                else
                {
                    mensaje = "No se pudo registrar el curso";
                    titulo = "Curso no registrado";
                    icono = MessageBoxIcon.Asterisk;
                    mensajeOK = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                }

            }
            
            
        }

        private bool ValidarCodigo(string codigo)
        {
            if (codigo.Length == 0)
            {
                return false;
            }

            if (codigo.Length != 7) return false;
            var validos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
            bool valido = true;
            foreach (char c in codigo)
            {
                valido = validos.IndexOf(c) != -1;
                if (!valido) break;
            }
            return valido;
            
        }

        private void btnAddSyllabus_Click(object sender, EventArgs e)
        {
            OpenFileDialog opSilabo = new OpenFileDialog();
            opSilabo.Title = "Abrir sílabo del curso";
            opSilabo.Filter = "PDF files|*.pdf";
            if(opSilabo.ShowDialog() == DialogResult.OK)
            {
                silabo = opSilabo.FileName;
                lblNameSyllabus.Text = opSilabo.SafeFileName;
            }
        }
    }
}
