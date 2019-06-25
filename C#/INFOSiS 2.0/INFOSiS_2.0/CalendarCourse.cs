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
    public partial class CalendarCourse : UserControl
    {
        public CalendarCourse()
        {
            InitializeComponent();
        }

        public CalendarCourse(String nombreCurso, String hora, String aula, String profesor)
        {
            InitializeComponent();
            lblCurso.Text = nombreCurso;
            lblHora.Text = hora;
            lblLugar.Text = aula;
            lblProfessor.Text = profesor;
        }
    }
}
