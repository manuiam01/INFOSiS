using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace INFOSiS_2._0
{
    public partial class Calendar : UserControl
    {
        public Calendar()
        {
            InitializeComponent();
        }

        public void actualizar_calendario(BindingList<Server.calendarSession> sesiones)
        {
            limpiar_calendario();

            DateTime diaActual = new DateTime(1998, 11, 25);
            int y = 0;
            foreach (Server.calendarSession cs in sesiones)
            {
                //Cambio de día
                if (cs.inicio.Year > diaActual.Year)
                {
                    diaActual = cs.inicio;
                    String nuevoDia = cs.inicio.ToString("D", CultureInfo.CreateSpecificCulture("es-ES"));
                    CalendarDate newCal = new CalendarDate(nuevoDia);
                    newCal.Dock = DockStyle.None;
                    newCal.Location = new Point(0, y);
                    y += 65;
                    newCal.Visible = true;
                    newCal.BringToFront();
                    this.Controls.Add(newCal);

                }
                else if (cs.inicio.Month > diaActual.Month)
                {
                    diaActual = cs.inicio;
                    String nuevoDia = cs.inicio.ToString("D", CultureInfo.CreateSpecificCulture("es-ES"));
                    CalendarDate newCal = new CalendarDate(nuevoDia);
                    newCal.Dock = DockStyle.None;
                    newCal.Location = new Point(0, y);
                    y += 65;
                    newCal.Visible = true;
                    newCal.BringToFront();
                    this.Controls.Add(newCal);
                }
                else if (cs.inicio.Day > diaActual.Day)
                {
                    diaActual = cs.inicio;
                    String nuevoDia = cs.inicio.ToString("D", CultureInfo.CreateSpecificCulture("es-ES"));
                    CalendarDate newCal = new CalendarDate(nuevoDia);
                    newCal.Dock = DockStyle.None;
                    newCal.Location = new Point(0, y);
                    y += 65;
                    newCal.Visible = true;
                    newCal.BringToFront();
                    this.Controls.Add(newCal);
                }
                String hora = cs.inicio.ToString("hh:mm") + " - " + cs.fin.ToString("hh:mm");
                CalendarCourse newCourse = new CalendarCourse(cs.courseName, hora, cs.aula, cs.professor);
                newCourse.Dock = DockStyle.None;
                newCourse.Location = new Point(0, y);
                y += 163;
                newCourse.Visible = true;
                newCourse.BringToFront();
                this.Controls.Add(newCourse);
            }

        }

        internal void limpiar_calendario()
        {
            foreach (Control item in this.Controls.OfType<Control>())
            {
                this.Controls.Remove(item);
            }

            foreach (Control item in this.Controls.OfType<Control>())
            {
                this.Controls.Remove(item);
            }

            foreach (Control item in this.Controls.OfType<Control>())
            {
                this.Controls.Remove(item);
            }

            foreach (Control item in this.Controls.OfType<Control>())
            {
                this.Controls.Remove(item);
            }

            foreach (Control item in this.Controls.OfType<Control>())
            {
                this.Controls.Remove(item);
            }

        }
    }
}
