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
    public partial class InterestedDisable : UserControl
    {
        private static InterestedDisable _instance;
        private static Panel _panelMdi;

        public static InterestedDisable Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedDisable();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedDisable()
        {
            InitializeComponent();
        }
    }
}
