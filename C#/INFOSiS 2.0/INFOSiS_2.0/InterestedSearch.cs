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
    public partial class InterestedSearch : UserControl
    {
        private static InterestedSearch _instance;
        private static Panel _panelMdi;

        public static InterestedSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedSearch();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedSearch()
        {
            InitializeComponent();
        }


        private void InterestedSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
