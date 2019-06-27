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

namespace INFOSiS_2._0
{
    public partial class ProfileChangePassword : UserControl
    {
        private static ProfileChangePassword _instance;
        private static Panel _panelMdi;
        private Server.user user;
        private Server.ServerClient server;

        public static ProfileChangePassword Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileChangePassword();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public Server.user User { get => user; set => user = value; }

        public ProfileChangePassword()
        {
            InitializeComponent();
        }

        public void poner_datos(Server.user u)
        {
            server = new Server.ServerClient();
            user = u;
            if (u.acces.id == 2)
            {
                //Coordinator
                Server.coordinator c = server.queryCoordByID(user.username);
                lblNombre.Text = c.primaryLastName + " " + c.secondLastName + ", " + c.firstName + " " + c.middleName;
                lblRol.Text = "Coordinadora";
            }
            else
            {
                //Practicante
                Server.intern c = server.SearchInternByIdPUCP(user.username);
                lblNombre.Text = c.primaryLastName + " " + c.secondLastName + ", " + c.firstName + " " + c.middleName;
                if (u.acces.id == 0)
                {
                    lblRol.Text = "Practicante";
                }
                else
                {
                    lblRol.Text = "Administrador";
                }
            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar su contraseña actual primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(txtNewPassword.Text.Equals(txtRepeatPassword.Text)))
            {
                MessageBox.Show("La nueva contraseña no coincide con la confirmación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Server.user usu = new Server.user();
                usu.username = user.username;
                usu.password = txtOldPassword.Text;
                usu.acces = server.VerifyUser(usu);
                if (usu.acces.id != -1)
                {
                    usu.password = txtNewPassword.Text;
                    int res = server.updateUser(usu);
                    if (res < 1)
                    {
                        MessageBox.Show("No se pudo actualizar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Se actualizó la contraseña", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
