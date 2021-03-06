﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace INFOSiS_2._0
{
    public partial class InterestedRegister : UserControl
    {
        private Server.ServerClient servidor;
        MessageBoxIcon iconoWarning = MessageBoxIcon.Warning;
        MessageBoxIcon iconoPregunta = MessageBoxIcon.Question;
        MessageBoxIcon iconoCorrecto = MessageBoxIcon.Asterisk;
        private static InterestedRegister _instance;
        private static Panel _panelMdi;
        private DataTable tbCursos = new DataTable();
        private BindingList<string> idcursos;
        public static InterestedRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedRegister();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedRegister()
        {
            InitializeComponent();
            limpiar();
            servidor = new Server.ServerClient();
            idcursos = new BindingList<string>();
            tbCursos.Columns.Add("ID", typeof(string));
            tbCursos.Columns.Add("Nombre", typeof(string));
            txbNDocumento.CharacterCasing = CharacterCasing.Upper;
            txbApePa.CharacterCasing = CharacterCasing.Upper;
            txbApeMa.CharacterCasing = CharacterCasing.Upper;
            txbNombre.CharacterCasing = CharacterCasing.Upper;
            txbSegundoNom.CharacterCasing = CharacterCasing.Upper;
        }

        private void InterestedRegister_Load(object sender, EventArgs e)
        {

        }

        private void DgvInterestedCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtBuscarCursos_Click(object sender, EventArgs e)
        {
            //bindinglist
            BindingList<Server.course> courses = new BindingList<Server.course>(servidor.queryAllCourse());
            if (idcursos.Count == courses.Count)
            {
                MessageBox.Show("Ya escogió todos los cursos de interés disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InterestedCourses formBuscarCursosInteresado = new InterestedCourses(idcursos);
                if (formBuscarCursosInteresado.ShowDialog() == DialogResult.OK)
                {

                    if (formBuscarCursosInteresado.Cursos != null)
                    {
                        idcursos = formBuscarCursosInteresado.Cursos;
                        foreach (string id in idcursos)
                        {
                            Server.course c = new Server.course();
                            c = servidor.queryCourseById(id);
                            tbCursos.Rows.Add(c.id, c.name);
                        }
                        dgvInterestedCourses.DataSource = tbCursos;
                        idcursos = new BindingList<string>();
                        foreach (DataGridViewRow row in dgvInterestedCourses.Rows)
                        {
                            idcursos.Add(row.Cells[0].Value.ToString());
                        }

                    }

                    //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                    //dgvInterestedCourses.DataSource = formBuscarCursosInteresado.}

                }
            }
            
        }

        public int verificarVacio()
        {
            int resultado = 1;
            //falta verificar el dateNacimiento.Value != DateTime.Today ||, pero no sé como hacerlo uwur
            if (txbApeMa.Text != "" ||
            txbApePa.Text != "" ||
            txbNDocumento.Text != "" ||
            txbNombre.Text != "" ||
            txbSegundoNom.Text != "" ||
            txtCellphone.Text != "" ||
            txtEmail.Text != "" ||
            //txtEmailPUCP.Text != "" ||
            //txtHomephone.Text != "" ||
            rbCarnet.Checked != false ||
            //rbDNI.Checked != false ||
            rbPasaporte.Checked != false ||
            dgvInterestedCourses.Rows.Count != 0)
            {
                resultado = 0;
            }
            
            return resultado;
        }

        private void InterestedRegister_Leave(object sender, EventArgs e)
        {

            if (verificarVacio() == 0) {
                DialogResult result = MessageBox.Show("Está seguro de salir sin guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, iconoWarning);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                }
            }
        }
        public void limpiar()
        {
            txbApeMa.Text = "";
            txbApePa.Text = "";
            txbNDocumento.Text = "";
            txbNombre.Text = "";
            txbSegundoNom.Text = "";
            txtCellphone.Text = "";
            txtEmail.Text = "";
            //txtEmailPUCP.Text = "";
            //txtHomephone.Text = "";
            rbCarnet.Checked = false;
            rbDNI.Checked = true;
            rbPasaporte.Checked = false;
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            servidor = new Server.ServerClient();
            Server.interested i = new Server.interested();
            Server.course c1 = new Server.course();
            Server.course c2 = new Server.course();

            if (rbCarnet.Checked == false && rbDNI.Checked == false && rbPasaporte.Checked == false)
                MessageBox.Show("No seleccionó el tipo de documento", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbNDocumento.Text == "")
                MessageBox.Show("No ingresó el número de documento", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (!ValidarIdentificacion(txbNDocumento.Text))
                MessageBox.Show("El documento ingresado es inválido", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbNombre.Text == "")
                MessageBox.Show("No ingresó el nombre del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbApePa.Text == "")
                MessageBox.Show("No ingresó el apellido paterno del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbApeMa.Text == "")
                MessageBox.Show("No ingresó el apellido materno del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (rbMale.Checked == false && rbFemale.Checked == false)
                MessageBox.Show("No escogió el género", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txtCellphone.Text == "")
                MessageBox.Show("No ingresó el número del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txtEmail.Text == "")
                MessageBox.Show("No ingresó el correo del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (dgvInterestedCourses.Rows.Count == 0)
                MessageBox.Show("No escogió cursos de interés", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else
            {
                if (!(new EmailAddressAttribute().IsValid(txtEmail.Text)))
                    MessageBox.Show("El correo ingresado no es válido", "Aviso", MessageBoxButtons.OK);
                else
                {
                    Server.interested inte = new Server.interested();
                    inte = servidor.QueryInterestedByID(txbNDocumento.Text);
                    if (inte.firstName != null)
                        MessageBox.Show("El documento ingresado ya se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK);
                    else
                    {
                        iconoPregunta = MessageBoxIcon.Question;
                        DialogResult result = MessageBox.Show("Está seguro de que quiere guardar el registro?", "Aviso", MessageBoxButtons.YesNo, iconoPregunta);
                        if (result == DialogResult.Yes)
                        {
                            if (rbDNI.Checked == true)
                                i.idType = 0;
                            else if (rbCarnet.Checked == true)
                                i.idType = 1;
                            else
                                i.idType = 2;
                            i.idNumber = txbNDocumento.Text;
                            i.firstName = txbNombre.Text;
                            i.middleName = txbSegundoNom.Text;
                            i.primaryLastName = txbApePa.Text;
                            i.secondLastName = txbApeMa.Text;
                            if (rbMale.Checked == true)
                                i.gender = "M";
                            else
                                i.gender = "F";
                            i.cellPhoneNumber = txtCellphone.Text;
                            i.email = txtEmail.Text;
                            int tama = 0;
                            BindingList<Server.course> courses = new BindingList<Server.course>();
                            foreach (DataGridViewRow row in dgvInterestedCourses.Rows)
                            {
                                Server.course c = new Server.course();
                                c.id = row.Cells[0].Value.ToString();
                                courses.Add(c);
                                tama = tama + 1;
                            }
                            Server.course[] coursesList = new Server.course[tama];
                            coursesList = courses.ToArray<Server.course>();
                            i.courses = coursesList;
                            servidor.InsertInterested(i);

                            MessageBox.Show("Se registró al interesado de manera correcta", "Éxito", MessageBoxButtons.OK, iconoCorrecto);
                            limpiar();
                            tbCursos.Clear();
                        }
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (verificarVacio() == 0)
            {
                DialogResult result = MessageBox.Show("Está seguro de que quiere cancelar el registro?", "Aviso", MessageBoxButtons.YesNo,iconoWarning);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                    tbCursos.Clear();
                    idcursos = new BindingList<string>();
                }
            }
        }

        private void DgvInterestedCourses_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            idcursos = new BindingList<string>();
            foreach (DataGridViewRow row in dgvInterestedCourses.Rows)
            {
                idcursos.Add(row.Cells[0].Value.ToString());
            }
        }
        private bool ValidarIdentificacion(string identificacion)
        {
            if (identificacion.Length == 0)
            {
                return false;
            }

            if (rbDNI.Checked)
            {
                if (identificacion.Length != 8) return false;
                int dni;
                bool resultado = int.TryParse(identificacion, out dni);
                return resultado;
            }
            else
            {
                if (identificacion.Length != 12) return false;
                var validos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
                bool valido = true;
                foreach (char c in identificacion)
                {
                    valido = validos.IndexOf(c) != -1;
                    if (!valido) break;
                }
                return valido;
            }
        }

        private void txbNDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbDNI.Checked)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txbSegundoNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txbApePa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txbApeMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void rbDNI_CheckedChanged(object sender, EventArgs e)
        {
            txbNDocumento.MaxLength = 8;
            txbNDocumento.Text = "";
        }

        private void rbCarnet_CheckedChanged(object sender, EventArgs e)
        {
            txbNDocumento.MaxLength = 12;
            txbNDocumento.Text = "";
        }

        private void rbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            txbNDocumento.MaxLength = 12;
            txbNDocumento.Text = "";
        }
    }
}
