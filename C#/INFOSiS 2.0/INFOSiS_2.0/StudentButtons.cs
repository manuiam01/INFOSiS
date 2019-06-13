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

    }
}
