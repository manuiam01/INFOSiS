using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace INFOSiS_2._0
{
    public partial class WelcomeControl : UserControl
    {
        private static WelcomeControl _instance;
        private static Panel _panelMdi;

        public static WelcomeControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WelcomeControl();
                return _instance;
            }
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }

        public WelcomeControl()
        {
            InitializeComponent();
            lblTime.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-US"));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            InfosisInfo info = new InfosisInfo();
            info.ShowDialog();
        }
    }
}
