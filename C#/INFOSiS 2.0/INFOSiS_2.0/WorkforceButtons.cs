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
    public partial class WorkforceButtons : UserControl
    {
        private static WorkforceButtons _instance;
        private static Panel _panelMdi;
        private static Server.user usuario;

        public static WorkforceButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WorkforceButtons();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public static user Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public WorkforceButtons()
        {
            InitializeComponent();
        }

        private void btnNewIntern_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(WorkforceRegister.Instance))
            {
                PanelMdi.Controls.Add(WorkforceRegister.Instance);
                WorkforceRegister.Instance.Dock = DockStyle.Fill;
                WorkforceRegister.PanelMdi = PanelMdi;
                WorkforceRegister.Instance.Visible = true;
                WorkforceRegister.Instance.BringToFront();
            }
            else
            {
                WorkforceRegister.Instance.Visible = true;
                WorkforceRegister.Instance.BringToFront();
            }
        }

        private void cleanWindow()
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }
        }

        private void btnModificarIntern_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(WorkforceModify.Instance))
            {
                PanelMdi.Controls.Add(WorkforceModify.Instance);
                WorkforceModify.Instance.Dock = DockStyle.Fill;
                WorkforceModify.PanelMdi = PanelMdi;
                WorkforceModify.Instance.Visible = true;
                WorkforceModify.Instance.BringToFront();
            }
            else
            {
                WorkforceModify.Instance.Visible = true;
                WorkforceModify.Instance.BringToFront();
            }
        }

        private void btnWeekAvailability_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(WeekAvailability.Instance))
            {
                PanelMdi.Controls.Add(WeekAvailability.Instance);
                WeekAvailability.Instance.Dock = DockStyle.Fill;
                WeekAvailability.PanelMdi = PanelMdi;
                WeekAvailability.User = Usuario;
                WeekAvailability.Instance.Visible = true;
                WeekAvailability.Instance.BringToFront();
            }
            else
            {
                WeekAvailability.Instance.Visible = true;
                WeekAvailability.Instance.BringToFront();
            }
        }
    }
}
