using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFOSiS_2._0.Server;
using System.Globalization;

namespace INFOSiS_2._0
{
    public partial class ProfileAssistance : UserControl
    {
        private static ProfileAssistance _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private int estado;
        private Server.internAssistance ia;
        public static ProfileAssistance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileAssistance();
                return _instance;
            }
        }
        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public ProfileAssistance()
        {
            InitializeComponent();
        }

        public void prepararUsuario(Server.user usuario)
        {
            server = new Server.ServerClient();
            Server.intern practicante = server.SearchInternByIdPUCP(usuario.username);
            txtName.Text = practicante.primaryLastName + " " + practicante.secondLastName + ", " + practicante.firstName + " " + practicante.middleName;
            txtPUCPCode.Text = practicante.idPUCP;
            ia = server.getLastRegisterIntern(usuario.username);
            if (ia.id == -1)
            {
                //Primer registro del día
                btnEntrada.Enabled = true;
                btnSalida.Enabled = false;
                txtEntrada.Text = "";
                txtSalida.Text = "";
                estado = 0;
            }
            else if (ia.end == new DateTime(1, 1, 1, 0, 0, 0))
            {
                //Registro de salida
                btnEntrada.Enabled = false;
                btnSalida.Enabled = true;
                txtEntrada.Text = ia.begin.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
                txtSalida.Text = "";
                estado = 1;
            }
            else {
                //Posible nuevo registro
                btnEntrada.Enabled = true;
                btnSalida.Enabled = false;
                txtEntrada.Text = ia.begin.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
                txtSalida.Text = ia.end.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
                estado = 2;
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {
                //Primer registro
                if (server.insertAssistance(txtPUCPCode.Text) < 1)
                {
                    MessageBox.Show("No se logró registrar la asistenica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizar_registros();
                }
            }
            else if (estado == 2)
            {
                DialogResult result = MessageBox.Show("Se procederá a realizar un nuevo registro", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (server.insertAssistance(txtPUCPCode.Text) < 1)
                    {
                        MessageBox.Show("No se logró registrar la asistenica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        actualizar_registros();
                    }
                }
            }
        }

        private void actualizar_registros()
        {
            ia = server.getLastRegisterIntern(txtPUCPCode.Text);
            if (ia.id == -1)
            {
                //Primer registro del día
                btnEntrada.Enabled = true;
                btnSalida.Enabled = false;
                txtEntrada.Text = "";
                txtSalida.Text = "";
                estado = 0;
            }
            else if (ia.end == new DateTime(1, 1, 1, 0, 0, 0))
            {
                //Registro de salida
                btnEntrada.Enabled = false;
                btnSalida.Enabled = true;
                txtEntrada.Text = ia.begin.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
                txtSalida.Text = "";
                estado = 1;
            }
            else
            {
                //Posible nuevo registro
                btnEntrada.Enabled = true;
                btnSalida.Enabled = false;
                txtEntrada.Text = ia.begin.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
                txtSalida.Text = ia.end.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
                estado = 2;
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                if (server.updateAssistance(ia.id.ToString())<1)
                {
                    MessageBox.Show("No se logró registrar la asistenica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizar_registros();
                }
            }
            
        }
    }
}
