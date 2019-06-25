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
        private BindingList<ListaStrings> listaCodigos;
        private Server.ServerClient server;
        public StudentRegister()
        {
            InitializeComponent();
            rbnDNI.Checked = true;
            dateNacimiento.MaxDate = DateTime.Today;
            listaCodigos = new BindingList<ListaStrings>();
            //listaCodigos.Add(new ListaStrings("20161811"));
            dgvCodigos.DataSource = listaCodigos;
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
            server = new Server.ServerClient();
            Server.interested interested = server.QueryInterestedByID(identificacion);
            if (interested.idNumber==identificacion)
            {
                txtNombre.Text = interested.firstName;
                txtSegundoNombre.Text = interested.middleName;
                txtApellidoPaterno.Text = interested.primaryLastName;
                txtApellidoMaterno.Text = interested.secondLastName;
                txtDocumento.Enabled = false;
                rbnCarneExtranjeria.Enabled = false;
                rbnDNI.Enabled = false;
                rbnPasaporte.Enabled = false;
                dateNacimiento.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
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

        private void btnAgregarCodigos_Click(object sender, EventArgs e)
        {
            InterfazCodigos interfazCodigos = new InterfazCodigos(listaCodigos);
            interfazCodigos.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult mensajeError;
            String mensaje;
            String titulo;
            MessageBoxIcon icono;
            bool exito = false;
            int telefono;
            if (!(txtDireccion.Text.Length!=0 && txtDireccion.Text.Length <= 100))
            {
                mensaje = "ERROR: La dirección no es válida";
                titulo = "Dirección no válida";
                icono = MessageBoxIcon.Error;
            }
            else if(!(txtTelefono.Text.Length==7 && int.TryParse(txtTelefono.Text,out telefono)))
            {
                mensaje = "ERROR: El telefono ingresado no es válido";
                titulo = "Teléfono no válido";
                icono = MessageBoxIcon.Error;
            }
            else if (!(obtenerLenght(listaCodigos) >= 1))
            {
                mensaje = "ERROR: Debe ingresar al menos un código PUCP";
                titulo = "Ingresar Código PUCP";
                icono = MessageBoxIcon.Error;
            }
            else
            {
                /*Aquí se registrtaría en BD*/
                Server.student s = new Server.student();
                s.idNumber = txtDocumento.Text;
                s.homePhone = txtTelefono.Text;
                s.address = txtDireccion.Text;
                s.birthDate = dateNacimiento.Value.Date;
                String birthday = dateNacimiento.Value.ToString("yyyy/MM/dd");
                s.idPUCPList = new string[listaCodigos.Count];
                BindingList<string> lstring = new BindingList<string>();
                foreach (ListaStrings ls in listaCodigos)
                {
                    lstring.Add(ls.Cadena);
                }
                lstring.CopyTo(s.idPUCPList, 0);
                int result = server.InsertStudent(s,birthday);
                if (result == 1)
                {
                    mensaje = "ÉXITO: Se ha registrado al alumno";
                    titulo = "Registro completo";
                    icono = MessageBoxIcon.Information;
                    exito = true;
                }
                else
                {
                    mensaje = "No se pudo registrar al alumno";
                    titulo = "Error en registro";
                    icono = MessageBoxIcon.Error;
                    exito = false;
                }
            }
            mensajeError = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
            if (exito)
            {
                txtDocumento.Enabled = true;
                txtDocumento.Text = "";
                rbnCarneExtranjeria.Enabled = true;
                rbnCarneExtranjeria.Checked = false;
                rbnDNI.Enabled = true;
                rbnDNI.Checked = true;
                rbnPasaporte.Enabled = true;
                rbnPasaporte.Checked = false;
                dateNacimiento.Enabled = false;
                txtDireccion.Enabled = false;
                txtDireccion.Text = "";
                txtTelefono.Enabled = false;
                txtTelefono.Text = "";
                btnAgregarCodigos.Enabled = false;
                btnGuardar.Enabled = false;
                txtNombre.Text = "";
                txtSegundoNombre.Text = "";
                txtApellidoMaterno.Text = "";
                txtApellidoPaterno.Text = "";
                listaCodigos = new BindingList<ListaStrings>();
                dgvCodigos.DataSource = listaCodigos;
            }
        }

        private int obtenerLenght(BindingList<ListaStrings> listaCodigos)
        {
            int len = 0;
            foreach(ListaStrings l in listaCodigos)
            {
                len++;
            }
            return len;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que quiere cancelar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtDocumento.Enabled = true;
                txtDocumento.Text = "";
                rbnCarneExtranjeria.Enabled = true;
                rbnCarneExtranjeria.Checked = false;
                rbnDNI.Enabled = true;
                rbnDNI.Checked = true;
                rbnPasaporte.Enabled = true;
                rbnPasaporte.Checked = false;
                dateNacimiento.Enabled = false;
                txtDireccion.Enabled = false;
                txtDireccion.Text = "";
                txtTelefono.Enabled = false;
                txtTelefono.Text = "";
                btnAgregarCodigos.Enabled = false;
                btnGuardar.Enabled = false;
                txtNombre.Text = "";
                txtSegundoNombre.Text = "";
                txtApellidoMaterno.Text = "";
                txtApellidoPaterno.Text = "";
                listaCodigos = new BindingList<ListaStrings>();
                dgvCodigos.DataSource = listaCodigos;
            }
        }
    }
}
