﻿using System;
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
    public partial class InterestedModified : UserControl
    {
        private static InterestedModified _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        MessageBoxIcon iconoCorrecto = MessageBoxIcon.Asterisk;

        public static InterestedModified Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedModified();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedModified()
        {
            InitializeComponent();
            establecerEstado(Estado.Inicial);

        }
        public void establecerEstado(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    txbNombre.Enabled = false;
                    txbApePa.Enabled = false;
                    txbSegundoNom.Enabled = false;
                    txbApeMa.Enabled = false;
                    txtCellphone.Enabled = false;
                    txtEmail.Enabled = false;
                    //txtEmailPUCP.Enabled = false;
                    //txtHomephone.Enabled = false;
                    btCancelar.Enabled = false;
                    btModificar.Enabled = false;
                    btBuscarCursos.Enabled = false;
                    cbDesactivado.Enabled = false;
                    txbNDocumento.Enabled = true;
                    rbCarnet.Enabled = true;
                    rbDNI.Enabled = true;
                    rbDNI.Checked = true;
                    rbPasaporte.Enabled = true;
                    break;

                case Estado.Actualizar:
                    btModificar.Enabled = false;
                    txbNombre.Enabled = true;
                    txbApePa.Enabled = true;
                    txbSegundoNom.Enabled = true;
                    txbApeMa.Enabled = true;
                    txtCellphone.Enabled = true;
                    txtEmail.Enabled = true;
                    //txtEmailPUCP.Enabled = true;
                    //txtHomephone.Enabled = true;
                    btCancelar.Enabled = true;
                    btModificar.Enabled = true;
                    btBuscarCursos.Enabled = true;
                    cbDesactivado.Enabled = true;
                    txbNDocumento.Enabled = false;
                    rbCarnet.Enabled = false;
                    rbDNI.Enabled = false;
                    rbPasaporte.Enabled = false;
                    break;
            }
        }

        private void InterestedSearch_Load(object sender, EventArgs e)
        {

        }

        private void BtBuscarCursos_Click(object sender, EventArgs e)
        {
            InterestedCourses formBuscarCursosInteresado = new InterestedCourses();
            if (formBuscarCursosInteresado.ShowDialog() == DialogResult.OK)
            {

                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInterestedCourses.DataSource = formBuscarCursosInteresado.}
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
            cbDesactivado.Checked = false;
            rbCarnet.Checked = false;
            rbDNI.Checked = false;
            rbPasaporte.Checked = false;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (rbCarnet.Checked == false && rbDNI.Checked == false && rbPasaporte.Checked == false)
            {
                MessageBox.Show("No escogió el tipo de documento a ingresar", "Aviso", MessageBoxButtons.OK);
            }
            else if (txbNDocumento.Text == "")
                MessageBox.Show("No ingresó el N° de documento", "Aviso", MessageBoxButtons.OK);
            
            else
            {
                String identificacion = txbNDocumento.Text;
                server = new Server.ServerClient();
                Server.interested interested = server.QueryInterestedByID(identificacion);
                
                if (interested.idNumber == identificacion)
                {
                    establecerEstado(Estado.Actualizar);
                    txbNombre.Text = interested.firstName;
                    txbSegundoNom.Text = interested.middleName;
                    txbApePa.Text = interested.primaryLastName;
                    txbApeMa.Text = interested.secondLastName;
                    txtCellphone.Text = interested.cellPhoneNumber;
                    txtEmail.Text = interested.email;
                    rbCarnet.Enabled = false;
                    rbDNI.Enabled = false;
                    rbPasaporte.Enabled = false;
                    btBuscarCursos.Enabled = false;

                }
                else
                {
                    DialogResult mensajeError;
                    String mensaje;
                    String titulo;
                    MessageBoxIcon icono;
                    if (!ValidarIdentificacion(identificacion))
                    {
                        mensaje = "ERROR: El número de identificación ingresado no es válido.";
                        titulo = "Número de identificación no válido";
                        icono = MessageBoxIcon.Error;

                    }
                    else
                    {
                        mensaje = "ADVERTENCIA: El alumno ingresado aún no está registrado como interesado.";
                        titulo = "Alumno no registrado como interesado";
                        icono = MessageBoxIcon.Warning;
                    }
                    mensajeError = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
                }
            }
            
        }

        private void BtnSave_Leave(object sender, EventArgs e)
        {

        }

        private void InterestedModified_Leave(object sender, EventArgs e)
        {
            if (txbNDocumento.Enabled == false)
            {
                DialogResult result = MessageBox.Show("Está seguro de salir sin guardar los cambios?", "Aviso", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                    establecerEstado(Estado.Inicial);
                }
            }
        }

        private void BtModificar_EnabledChanged(object sender, EventArgs e)
        {
            //btModificar.ForeColor = sender == false ? Color.Blue : Color.Red;
            //btModificar.BackColor = Color.AliceBlue;
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text == "")
                MessageBox.Show("No ingresó el nombre del interesado", "Aviso", MessageBoxButtons.OK);
            else if (txbApePa.Text == "")
                MessageBox.Show("No ingresó el apelldio paterno del interesado", "Aviso", MessageBoxButtons.OK);
            else if (txbApeMa.Text == "")
                MessageBox.Show("No ingresó el apellido materno", "Aviso", MessageBoxButtons.OK);
            else if (txtCellphone.Text == "")
                MessageBox.Show("No ingresó el número de contacto del interesado", "Aviso", MessageBoxButtons.OK);
            else if (txtEmail.Text == "")
                MessageBox.Show("No ingresó el correo del interesado", "Aviso", MessageBoxButtons.OK);
            else
            {
                server = new Server.ServerClient();
                Server.interested inte = new Server.interested();
                inte.firstName = txbNombre.Text;
                inte.idNumber = txbNDocumento.Text;
                inte.secondLastName = txbApeMa.Text;
                inte.primaryLastName = txbApePa.Text;
                inte.middleName = txbSegundoNom.Text;
                inte.cellPhoneNumber = txtCellphone.Text;
                inte.email = txtEmail.Text;
                inte.courses = new Server.course[5];
                server.UpdateInterested(inte);
                MessageBox.Show("Se modificó al interesado de manera correcta", "Éxito", MessageBoxButtons.OK, iconoCorrecto);
                limpiar();
                establecerEstado(Estado.Inicial);
            }
            
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de que quiere cancelar la modificación?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                limpiar();
                establecerEstado(Estado.Inicial);
            }
        }

        private void LbBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            InterestedAdvancedSearch formBuscarInteresado = new InterestedAdvancedSearch();
            if (formBuscarInteresado.ShowDialog() == DialogResult.OK)
            {
                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInterestedCourses.DataSource = formBuscarCursosInteresado.}
            }
        }

        private void LbBusquedaAvanzada_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LbBusquedaAvanzada_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
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
    }
}
