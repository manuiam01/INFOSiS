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
    public partial class CoursesCalendar : UserControl
    {
        private static CoursesCalendar _instance;
        private static Panel _panelMdi;

        public CoursesCalendar()
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Today;
        }

        public static CoursesCalendar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CoursesCalendar();
                return _instance;
            }
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }

        private void CoursesCalendar_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DateTime dia = dtpDesde.Value;
            calendarContainer1.actualizar_calendario(dtpDesde.Value);
        }
    }
}
