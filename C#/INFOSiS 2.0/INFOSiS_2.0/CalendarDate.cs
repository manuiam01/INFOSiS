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
    public partial class CalendarDate : UserControl
    {
        public CalendarDate()
        {
            InitializeComponent();
        }

        public CalendarDate(String date)
        {
            InitializeComponent();
            lblDia.Text = date;
        }
    }
}
