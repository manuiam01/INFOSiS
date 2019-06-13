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
    public partial class StudentRegister : UserControl
    {
        private static StudentRegister _instance;
        private static Panel _panelMdi;
        public StudentRegister()
        {
            InitializeComponent();
        }

        public static StudentRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StudentRegister();
                return _instance;
            }
        }
        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
    }
}
