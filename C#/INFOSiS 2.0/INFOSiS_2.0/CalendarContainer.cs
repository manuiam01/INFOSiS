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
    public partial class CalendarContainer : UserControl
    {
        private Server.ServerClient server;
        public CalendarContainer()
        {
            InitializeComponent();
            /*for (int i=1; i<4; i++)
            {
                CalendarDate Dia = new CalendarDate(i.ToString());
                Dia.Dock = DockStyle.None;
                Dia.Visible = true;
                Dia.Location = new Point(0,0+(i-1)*150);
                Dia.BringToFront();
                this.Controls.Add(Dia);
            }*/
            server = new Server.ServerClient();
            actualizar_calendario(DateTime.Today);
        }

        public void actualizar_calendario(DateTime dia)
        {
            Server.courseHistory[] ch = server.queryCourseHByDate(dia);
            BindingList <Server.courseHistory> listaCH = new BindingList<Server.courseHistory>(ch);
            BindingList<SesionDisp> lSesiones = new BindingList<SesionDisp>();

           foreach(Server.courseHistory courseHistory in listaCH)
            {
                
            }
        }

        private class SesionDisp
        {
            private String courseName;
            private DateTime dia;
            
        }
    }
}
