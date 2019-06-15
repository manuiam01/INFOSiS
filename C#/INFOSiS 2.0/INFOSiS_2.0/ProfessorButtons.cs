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
    public partial class ProfessorButtons : UserControl
    {
        private static ProfessorButtons _instance;
        private static Panel _panelMdi;

        public static ProfessorButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfessorButtons();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public ProfessorButtons()
        {
            InitializeComponent();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(ProfessorModify.Instance))
            {
                PanelMdi.Controls.Add(ProfessorModify.Instance);
                ProfessorModify.Instance.Dock = DockStyle.Fill;
                ProfessorModify.PanelMdi = PanelMdi;
                ProfessorModify.Instance.Visible = true;
                ProfessorModify.Instance.BringToFront();
            }
            else
            {
                ProfessorModify.Instance.Visible = true;
                ProfessorModify.Instance.BringToFront();
            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(ProfessorRegister.Instance))
            {
                PanelMdi.Controls.Add(ProfessorRegister.Instance);
                ProfessorRegister.Instance.Dock = DockStyle.Fill;
                ProfessorModify.PanelMdi = PanelMdi;
                ProfessorModify.Instance.Visible = true;
                ProfessorModify.Instance.BringToFront();
            }
            else
            {
                ProfessorModify.Instance.Visible = true;
                ProfessorModify.Instance.BringToFront();
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(ProfessorReport.Instance))
            {
                PanelMdi.Controls.Add(ProfessorReport.Instance);
                ProfessorReport.Instance.Dock = DockStyle.Fill;
                ProfessorReport.PanelMdi = PanelMdi;
                ProfessorReport.Instance.Visible = true;
                ProfessorReport.Instance.BringToFront();
            }
            else
            {
                ProfessorReport.Instance.Visible = true;
                ProfessorReport.Instance.BringToFront();
            }

        }

        private void cleanWindow()
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }
        }
    }
}
