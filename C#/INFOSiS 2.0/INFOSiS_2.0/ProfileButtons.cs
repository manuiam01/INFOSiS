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
    public partial class ProfileButtons : UserControl
    {
        private static ProfileButtons _instance;
        private static Panel _panelMdi;
        private Server.user usuario;

        public static ProfileButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileButtons();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public user Usuario { get => usuario; set => usuario = value; }

        public ProfileButtons()
        {
            InitializeComponent();
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(ProfileEdit.Instance))
            {
                PanelMdi.Controls.Add(ProfileEdit.Instance);
                ProfileEdit.Instance.Dock = DockStyle.Fill;
                ProfileEdit.PanelMdi = PanelMdi;
                ProfileEdit.Instance.Visible = true;
                ProfileEdit.Instance.BringToFront();
                ProfileEdit.Instance.poner_datos(usuario);
            }
            else
            {
                ProfileEdit.Instance.Visible = true;
                ProfileEdit.Instance.BringToFront();
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(ProfileChangePassword.Instance))
            {
                PanelMdi.Controls.Add(ProfileChangePassword.Instance);
                ProfileChangePassword.Instance.Dock = DockStyle.Fill;
                ProfileChangePassword.PanelMdi = PanelMdi;
                ProfileChangePassword.Instance.poner_datos(usuario);
                ProfileChangePassword.Instance.Visible = true;
                ProfileChangePassword.Instance.BringToFront();
            }
            else
            {
                ProfileChangePassword.Instance.Visible = true;
                ProfileChangePassword.Instance.BringToFront();
            }
        }

        private void cleanWindow()
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }
        }

        public void verificar_usuario(Server.user u)
        {
            //Si llega, encontes sí es practicante
            if (u.acces.id != 2)
            {
                btnAsistencia.Enabled = true;
            }
            this.usuario = u;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(ProfileAssistance.Instance))
            {
                PanelMdi.Controls.Add(ProfileAssistance.Instance);
                ProfileAssistance.Instance.Dock = DockStyle.Fill;
                ProfileAssistance.PanelMdi = PanelMdi;
                ProfileAssistance.Instance.prepararUsuario(usuario);
                ProfileAssistance.Instance.Visible = true;
                ProfileAssistance.Instance.BringToFront();
            }
            else
            {
                ProfileAssistance.Instance.Visible = true;
                ProfileAssistance.Instance.BringToFront();
            }
        }
    }
}
