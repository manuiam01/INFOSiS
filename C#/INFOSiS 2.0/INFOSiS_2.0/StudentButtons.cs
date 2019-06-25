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
    public partial class StudentButtons : UserControl
    {
        private static StudentButtons _instance;
        private static Panel _panelMdi;

        public static StudentButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StudentButtons();
                return _instance;
            }
        }

        public StudentButtons()
        {
            InitializeComponent();
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        private void cleanWindow()
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }
        }

        private void btnRegStudent_Click(object sender, EventArgs e)
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(StudentRegister.Instance))
            {
                PanelMdi.Controls.Add(StudentRegister.Instance);
                StudentRegister.Instance.Dock = DockStyle.Fill;
                StudentRegister.PanelMdi = PanelMdi;
                StudentRegister.Instance.Visible = true;
                StudentRegister.Instance.BringToFront();
            }
            else
            {
                StudentRegister.Instance.Visible = true;
                StudentRegister.Instance.BringToFront();
            }
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(StudentModify.Instance))
            {
                PanelMdi.Controls.Add(StudentModify.Instance);
                StudentModify.Instance.Dock = DockStyle.Fill;
                StudentModify.PanelMdi = PanelMdi;
                StudentModify.Instance.Visible = true;
                StudentModify.Instance.BringToFront();
            }
            else
            {
                StudentModify.Instance.Visible = true;
                StudentModify.Instance.BringToFront();
            }
        }
    }
}
