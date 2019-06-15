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
    public partial class StudentRegister : UserControl
    {
        private static StudentRegister _instance;
        private static Panel _panelMdi;
        public StudentRegister()
        {
            InitializeComponent();
            rbnDNI.Checked = true;
            dateNacimiento.MaxDate = DateTime.Today;
        }

        public static StudentRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StudentRegister();
                return _instance;
            }
        }
        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        private void btnVerificarDocumento_Click(object sender, EventArgs e)
        {
            String identificacion = txtDocumento.Text;
            /*Aquí se debería verificar si hay un interesado con dicho documento*/
            if (identificacion == "73222296")
            {
                txtNombre.Text = "Manuel";
                txtSegundoNombre.Text = "Alberto";
                txtApellidoPaterno.Text = "Bezerra Brandao";
                txtApellidoMaterno.Text = "Corrales";
                txtDocumento.Enabled = false;
                rbnCarneExtranjeria.Enabled = false;
                rbnDNI.Enabled = false;
                rbnPasaporte.Enabled = false;
                dateNacimiento.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                dgvCodigos.Enabled = true;
                btnAgregarCodigos.Enabled = true;
                btnGuardar.Enabled = true;
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

        private bool ValidarIdentificacion(string identificacion)
        {
            if (identificacion.Length == 0)
            {
                return false;
            }

            if (rbnDNI.Checked)
            {
                if (identificacion.Length!=8) return false;
                int dni;
                bool resultado =  int.TryParse(identificacion,out dni);
                return resultado;
            }
            else
            {
                if (identificacion.Length != 12) return false;
                var validos = "abcdefghijklmnñopqrstuvwxyz1234567890";
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
