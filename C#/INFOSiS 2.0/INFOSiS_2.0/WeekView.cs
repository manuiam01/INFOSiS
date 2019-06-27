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
    public partial class WeekView : UserControl
    {
        private static WeekView _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        //private Server.intern intern;

        public static WeekView Instance
        {
            get
            {
                if (_instance == null) _instance = new WeekView();
                return _instance;
            }
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }

        public WeekView()
        {
            InitializeComponent();
            server = new Server.ServerClient();
            BindingList<Server.intern> interns = new BindingList<Server.intern>(server.QueryAllInterns());

            cbInterns.DataSource = interns;
            cbInterns.DisplayMember = "firstName" + " " + "middleName" + " " + "primaryLastName" + " " + "secondLastName";
        }
    }
}
