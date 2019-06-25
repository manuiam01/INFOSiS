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
    public partial class ProfileAssistance : UserControl
    {
        private static ProfileAssistance _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;

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
            Server.internAssistance ia = server.getLastRegisterIntern(usuario.username);
            MessageBox.Show("holi");
        }
    }
}
