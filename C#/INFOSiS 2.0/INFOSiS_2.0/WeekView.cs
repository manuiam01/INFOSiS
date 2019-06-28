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
    public partial class WeekView : UserControl
    {
        private static WeekView _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        //private Server.intern intern;
        private int[,] schedule = new int[11, 7];

        public static WeekView Instance
        {
            get
            {
                if (_instance == null) _instance = new WeekView();
                return _instance;
            }
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }

        public WeekView()
        {
            InitializeComponent();
            server = new Server.ServerClient();

            BindingList<Server.intern> interns = new BindingList<Server.intern>(server.QueryAllInterns());

            cbInterns.DataSource = interns;
            cbInterns.DisplayMember = "completeName";
        }

        private void cbInterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server.intern intern = (Server.intern) cbInterns.SelectedItem;
            string weekAvailability = server.GetWeekAvailability(intern.idPUCP);

            if(weekAvailability != null && weekAvailability.Length == 77)
            {
                lbNoWeek.Visible = false;
                int j = -1;
                for (int i = 0; i < 77; i++)
                {
                    if (i % 11 == 0) j++;
                    schedule[i - 11 * j, j] = (int)weekAvailability[i] - 48;
                }

                string rowS;
                int row;
                //LUNES
                foreach (Control c in gbMon.Controls)
                {
                    if (c is Button)
                    {
                        rowS = c.Name.Substring(6);
                        row = Int32.Parse(rowS) - 8;
                        if (schedule[row, 0] == 1)
                        {
                            c.BackColor = Color.SteelBlue;
                        }
                        else c.BackColor = Color.Silver;

                        //c.Text = schedule[row, 0].ToString();
                    }
                }
                //MARTES
                foreach (Control c in gbTue.Controls)
                {
                    rowS = c.Name.Substring(6);
                    row = Int32.Parse(rowS) - 8;
                    if (schedule[row, 1] == 1)
                    {
                        c.BackColor = Color.SteelBlue;
                    }
                    else c.BackColor = Color.Silver;

                    //c.Text = schedule[row, 1].ToString();
                }
                //MIÉRCOLES
                foreach (Control c in gbWed.Controls)
                {
                    rowS = c.Name.Substring(6);
                    row = Int32.Parse(rowS) - 8;
                    if (schedule[row, 2] == 1)
                    {
                        c.BackColor = Color.SteelBlue;
                    }
                    else c.BackColor = Color.Silver;

                    //c.Text = schedule[row, 2].ToString();
                }
                //JUEVES
                foreach (Control c in gbThu.Controls)
                {
                    rowS = c.Name.Substring(6);
                    row = Int32.Parse(rowS) - 8;
                    if (schedule[row, 3] == 1)
                    {
                        c.BackColor = Color.SteelBlue;
                    }
                    else c.BackColor = Color.Silver;

                    //c.Text = schedule[row, 3].ToString();
                }
                //VIERNES
                foreach (Control c in gbFri.Controls)
                {
                    rowS = c.Name.Substring(6);
                    row = Int32.Parse(rowS) - 8;
                    if (schedule[row, 4] == 1)
                    {
                        c.BackColor = Color.SteelBlue;
                    }
                    else c.BackColor = Color.Silver;

                    //c.Text = schedule[row, 4].ToString();
                }
                //SÁBADO
                foreach (Control c in gbSat.Controls)
                {
                    rowS = c.Name.Substring(6);
                    row = Int32.Parse(rowS) - 8;
                    if (schedule[row, 5] == 1)
                    {
                        c.BackColor = Color.SteelBlue;
                    }
                    else c.BackColor = Color.Silver;

                    //c.Text = schedule[row, 5].ToString();
                }
                //DOMINGO
                foreach (Control c in gbSun.Controls)
                {
                    rowS = c.Name.Substring(6);
                    row = Int32.Parse(rowS) - 8;
                    if (schedule[row, 6] == 1)
                    {
                        c.BackColor = Color.SteelBlue;
                    }
                    else c.BackColor = Color.Silver;

                    //c.Text = schedule[row, 6].ToString();
                }
            }
            else
            {
                //MessageBox.Show("No registrada", "Disponibilidad Semanal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbNoWeek.Visible = true;

                //foreach (Control c in this.Controls)
                //{
                //    if (c is Button)
                //    {
                //        c.BackColor = Color.Silver;
                //    }
                //}

                //foreach (Control c in gbMon.Controls) if (c is Button) c.BackColor = Color.Silver;

                foreach (Control c in this.Controls)
                {
                    if (c is GroupBox)
                    {
                        foreach (Control b in c.Controls)
                        {
                            if (b is Button)
                            {
                                b.BackColor = Color.Silver;
                            }
                        }
                    }
                }
            }
        }
    }
}
