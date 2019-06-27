using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFOSiS_2._0.Server;

namespace INFOSiS_2._0
{
    public partial class WeekAvailability : UserControl
    {
        private static WeekAvailability _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private static Server.user user;
        private string weekAvailability;

        private int[,] schedule = new int[11,7];

        public static WeekAvailability Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WeekAvailability();
                return _instance;
            }
        }



        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public static user User { get => user; set => user = value; }

        public WeekAvailability()
        {
            InitializeComponent();
            server = new Server.ServerClient();
            SetWeekAvailability();
        }

        public void SetWeekAvailability()
        {
            weekAvailability = server.GetWeekAvailability(user.username);
            label1.Text = weekAvailability;

            if (weekAvailability.Length == 77)
            {
                int j = -1;
                for (int i = 0; i < 77; i++)
                {
                    if (i % 11 == 0) j++;
                    schedule[i - 11 * j, j] = (int)weekAvailability[i] - 48;
                }
            }
            label2.Text = "";
            for (int j = 0; j < 7; j++)
            {
                for (int i = 0; i < 11; i++)
                {
                    label2.Text = label2.Text + schedule[i, j].ToString();
                }
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

                    c.Text = schedule[row, 0].ToString();
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

                c.Text = schedule[row, 1].ToString();
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

                c.Text = schedule[row, 2].ToString();
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

                c.Text = schedule[row, 3].ToString();
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

                c.Text = schedule[row, 4].ToString();
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

                c.Text = schedule[row, 5].ToString();
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

                c.Text = schedule[row, 6].ToString();
            }
        }

        //LUNES
        private void btnMon8_Click(object sender, EventArgs e)
        {
            if (btnMon8.BackColor == Color.Silver) btnMon8.BackColor = Color.SteelBlue;
            else btnMon8.BackColor = Color.Silver;
        }

        private void btnMon9_Click(object sender, EventArgs e)
        {
            if (btnMon9.BackColor == Color.Silver) btnMon9.BackColor = Color.SteelBlue;
            else btnMon9.BackColor = Color.Silver;
        }

        private void btnMon10_Click(object sender, EventArgs e)
        {
            if (btnMon10.BackColor == Color.Silver) btnMon10.BackColor = Color.SteelBlue;
            else btnMon10.BackColor = Color.Silver;
        }

        private void btnMon11_Click(object sender, EventArgs e)
        {
            if (btnMon11.BackColor == Color.Silver) btnMon11.BackColor = Color.SteelBlue;
            else btnMon11.BackColor = Color.Silver;
        }

        private void btnMon12_Click(object sender, EventArgs e)
        {
            if (btnMon12.BackColor == Color.Silver) btnMon12.BackColor = Color.SteelBlue;
            else btnMon12.BackColor = Color.Silver;
        }

        private void btnMon13_Click(object sender, EventArgs e)
        {
            if (btnMon13.BackColor == Color.Silver) btnMon13.BackColor = Color.SteelBlue;
            else btnMon13.BackColor = Color.Silver;
        }

        private void btnMon14_Click(object sender, EventArgs e)
        {
            if (btnMon14.BackColor == Color.Silver) btnMon14.BackColor = Color.SteelBlue;
            else btnMon14.BackColor = Color.Silver;
        }

        private void btnMon15_Click(object sender, EventArgs e)
        {
            if (btnMon15.BackColor == Color.Silver) btnMon15.BackColor = Color.SteelBlue;
            else btnMon15.BackColor = Color.Silver;
        }

        private void btnMon16_Click(object sender, EventArgs e)
        {
            if (btnMon16.BackColor == Color.Silver) btnMon16.BackColor = Color.SteelBlue;
            else btnMon16.BackColor = Color.Silver;
        }

        private void btnMon17_Click(object sender, EventArgs e)
        {
            if (btnMon17.BackColor == Color.Silver) btnMon17.BackColor = Color.SteelBlue;
            else btnMon17.BackColor = Color.Silver;
        }

        private void btnMon18_Click(object sender, EventArgs e)
        {
            if (btnMon18.BackColor == Color.Silver) btnMon18.BackColor = Color.SteelBlue;
            else btnMon18.BackColor = Color.Silver;
        }
        //MARTES
        private void btnTue8_Click(object sender, EventArgs e)
        {
            if (btnTue8.BackColor == Color.Silver) btnTue8.BackColor = Color.SteelBlue;
            else btnTue8.BackColor = Color.Silver;
        }

        private void btnTue9_Click(object sender, EventArgs e)
        {
            if (btnTue9.BackColor == Color.Silver) btnTue9.BackColor = Color.SteelBlue;
            else btnTue9.BackColor = Color.Silver;
        }

        private void btnTue10_Click(object sender, EventArgs e)
        {
            if (btnTue10.BackColor == Color.Silver) btnTue10.BackColor = Color.SteelBlue;
            else btnTue10.BackColor = Color.Silver;
        }

        private void btnTue11_Click(object sender, EventArgs e)
        {
            if (btnTue11.BackColor == Color.Silver) btnTue11.BackColor = Color.SteelBlue;
            else btnTue11.BackColor = Color.Silver;
        }

        private void btnTue12_Click(object sender, EventArgs e)
        {
            if (btnTue12.BackColor == Color.Silver) btnTue12.BackColor = Color.SteelBlue;
            else btnTue12.BackColor = Color.Silver;
        }

        private void btnTue13_Click(object sender, EventArgs e)
        {
            if (btnTue13.BackColor == Color.Silver) btnTue13.BackColor = Color.SteelBlue;
            else btnTue13.BackColor = Color.Silver;
        }

        private void btnTue14_Click(object sender, EventArgs e)
        {
            if (btnTue14.BackColor == Color.Silver) btnTue14.BackColor = Color.SteelBlue;
            else btnTue14.BackColor = Color.Silver;
        }

        private void btnTue15_Click(object sender, EventArgs e)
        {
            if (btnTue15.BackColor == Color.Silver) btnTue15.BackColor = Color.SteelBlue;
            else btnTue15.BackColor = Color.Silver;
        }

        private void btnTue16_Click(object sender, EventArgs e)
        {
            if (btnTue16.BackColor == Color.Silver) btnTue16.BackColor = Color.SteelBlue;
            else btnTue16.BackColor = Color.Silver;
        }

        private void btnTue17_Click(object sender, EventArgs e)
        {
            if (btnTue17.BackColor == Color.Silver) btnTue17.BackColor = Color.SteelBlue;
            else btnTue17.BackColor = Color.Silver;
        }

        private void btnTue18_Click(object sender, EventArgs e)
        {
            if (btnTue18.BackColor == Color.Silver) btnTue18.BackColor = Color.SteelBlue;
            else btnTue18.BackColor = Color.Silver;
        }
        //MIÉRCOLES
        private void btnWed8_Click(object sender, EventArgs e)
        {
            if (btnWed8.BackColor == Color.Silver) btnWed8.BackColor = Color.SteelBlue;
            else btnWed8.BackColor = Color.Silver;
        }

        private void btnWed9_Click(object sender, EventArgs e)
        {
            if (btnWed9.BackColor == Color.Silver) btnWed9.BackColor = Color.SteelBlue;
            else btnWed9.BackColor = Color.Silver;
        }

        private void btnWed10_Click(object sender, EventArgs e)
        {
            if (btnWed10.BackColor == Color.Silver) btnWed10.BackColor = Color.SteelBlue;
            else btnWed10.BackColor = Color.Silver;
        }

        private void btnWed11_Click(object sender, EventArgs e)
        {
            if (btnWed11.BackColor == Color.Silver) btnWed11.BackColor = Color.SteelBlue;
            else btnWed11.BackColor = Color.Silver;
        }

        private void btnWed12_Click(object sender, EventArgs e)
        {
            if (btnWed12.BackColor == Color.Silver) btnWed12.BackColor = Color.SteelBlue;
            else btnWed12.BackColor = Color.Silver;
        }

        private void btnWed13_Click(object sender, EventArgs e)
        {
            if (btnWed13.BackColor == Color.Silver) btnWed13.BackColor = Color.SteelBlue;
            else btnWed13.BackColor = Color.Silver;
        }

        private void btnWed14_Click(object sender, EventArgs e)
        {
            if (btnWed14.BackColor == Color.Silver) btnWed14.BackColor = Color.SteelBlue;
            else btnWed14.BackColor = Color.Silver;
        }

        private void btnWed15_Click(object sender, EventArgs e)
        {
            if (btnWed15.BackColor == Color.Silver) btnWed15.BackColor = Color.SteelBlue;
            else btnWed15.BackColor = Color.Silver;
        }

        private void btnWed16_Click(object sender, EventArgs e)
        {
            if (btnWed16.BackColor == Color.Silver) btnWed16.BackColor = Color.SteelBlue;
            else btnWed16.BackColor = Color.Silver;
        }

        private void btnWed17_Click(object sender, EventArgs e)
        {
            if (btnWed17.BackColor == Color.Silver) btnWed17.BackColor = Color.SteelBlue;
            else btnWed17.BackColor = Color.Silver;
        }

        private void btnWed18_Click(object sender, EventArgs e)
        {
            if (btnWed18.BackColor == Color.Silver) btnWed18.BackColor = Color.SteelBlue;
            else btnWed18.BackColor = Color.Silver;
        }
        //JUEVES
        private void btnThu8_Click(object sender, EventArgs e)
        {
            if (btnThu8.BackColor == Color.Silver) btnThu8.BackColor = Color.SteelBlue;
            else btnThu8.BackColor = Color.Silver;
        }

        private void btnThu9_Click(object sender, EventArgs e)
        {
            if (btnThu9.BackColor == Color.Silver) btnThu9.BackColor = Color.SteelBlue;
            else btnThu9.BackColor = Color.Silver;
        }

        private void btnThu10_Click(object sender, EventArgs e)
        {
            if (btnThu10.BackColor == Color.Silver) btnThu10.BackColor = Color.SteelBlue;
            else btnThu10.BackColor = Color.Silver;
        }

        private void btnThu11_Click(object sender, EventArgs e)
        {
            if (btnThu11.BackColor == Color.Silver) btnThu11.BackColor = Color.SteelBlue;
            else btnThu11.BackColor = Color.Silver;
        }

        private void btnThu12_Click(object sender, EventArgs e)
        {
            if (btnThu12.BackColor == Color.Silver) btnThu12.BackColor = Color.SteelBlue;
            else btnThu12.BackColor = Color.Silver;
        }

        private void btnThu13_Click(object sender, EventArgs e)
        {
            if (btnThu13.BackColor == Color.Silver) btnThu13.BackColor = Color.SteelBlue;
            else btnThu13.BackColor = Color.Silver;
        }

        private void btnThu14_Click(object sender, EventArgs e)
        {
            if (btnThu14.BackColor == Color.Silver) btnThu14.BackColor = Color.SteelBlue;
            else btnThu14.BackColor = Color.Silver;
        }

        private void btnThu15_Click(object sender, EventArgs e)
        {
            if (btnThu15.BackColor == Color.Silver) btnThu15.BackColor = Color.SteelBlue;
            else btnThu15.BackColor = Color.Silver;
        }

        private void btnThu16_Click(object sender, EventArgs e)
        {
            if (btnThu16.BackColor == Color.Silver) btnThu16.BackColor = Color.SteelBlue;
            else btnThu16.BackColor = Color.Silver;
        }

        private void btnThu17_Click(object sender, EventArgs e)
        {
            if (btnThu17.BackColor == Color.Silver) btnThu17.BackColor = Color.SteelBlue;
            else btnThu17.BackColor = Color.Silver;
        }

        private void btnThu18_Click(object sender, EventArgs e)
        {
            if (btnThu18.BackColor == Color.Silver) btnThu18.BackColor = Color.SteelBlue;
            else btnThu18.BackColor = Color.Silver;
        }
        //VIERNES
        private void btnFri8_Click(object sender, EventArgs e)
        {
            if (btnFri8.BackColor == Color.Silver) btnFri8.BackColor = Color.SteelBlue;
            else btnFri8.BackColor = Color.Silver;
        }

        private void btnFri9_Click(object sender, EventArgs e)
        {
            if (btnFri9.BackColor == Color.Silver) btnFri9.BackColor = Color.SteelBlue;
            else btnFri9.BackColor = Color.Silver;
        }

        private void btnFri10_Click(object sender, EventArgs e)
        {
            if (btnFri10.BackColor == Color.Silver) btnFri10.BackColor = Color.SteelBlue;
            else btnFri10.BackColor = Color.Silver;
        }

        private void btnFri11_Click(object sender, EventArgs e)
        {
            if (btnFri11.BackColor == Color.Silver) btnFri11.BackColor = Color.SteelBlue;
            else btnFri11.BackColor = Color.Silver;
        }

        private void btnFri12_Click(object sender, EventArgs e)
        {
            if (btnFri12.BackColor == Color.Silver) btnFri12.BackColor = Color.SteelBlue;
            else btnFri12.BackColor = Color.Silver;
        }

        private void btnFri13_Click(object sender, EventArgs e)
        {
            if (btnFri13.BackColor == Color.Silver) btnFri13.BackColor = Color.SteelBlue;
            else btnFri13.BackColor = Color.Silver;
        }

        private void btnFri14_Click(object sender, EventArgs e)
        {
            if (btnFri14.BackColor == Color.Silver) btnFri14.BackColor = Color.SteelBlue;
            else btnFri14.BackColor = Color.Silver;
        }

        private void btnFri15_Click(object sender, EventArgs e)
        {
            if (btnFri15.BackColor == Color.Silver) btnFri15.BackColor = Color.SteelBlue;
            else btnFri15.BackColor = Color.Silver;
        }

        private void btnFri16_Click(object sender, EventArgs e)
        {
            if (btnFri16.BackColor == Color.Silver) btnFri16.BackColor = Color.SteelBlue;
            else btnFri16.BackColor = Color.Silver;
        }

        private void btnFri17_Click(object sender, EventArgs e)
        {
            if (btnFri17.BackColor == Color.Silver) btnFri17.BackColor = Color.SteelBlue;
            else btnFri17.BackColor = Color.Silver;
        }

        private void btnFri18_Click(object sender, EventArgs e)
        {
            if (btnFri18.BackColor == Color.Silver) btnFri18.BackColor = Color.SteelBlue;
            else btnFri18.BackColor = Color.Silver;
        }
        //SÁBADO
        private void btnSat8_Click(object sender, EventArgs e)
        {
            if (btnSat8.BackColor == Color.Silver) btnSat8.BackColor = Color.SteelBlue;
            else btnSat8.BackColor = Color.Silver;
        }

        private void btnSat9_Click(object sender, EventArgs e)
        {
            if (btnSat9.BackColor == Color.Silver) btnSat9.BackColor = Color.SteelBlue;
            else btnSat9.BackColor = Color.Silver;
        }

        private void btnSat10_Click(object sender, EventArgs e)
        {
            if (btnSat10.BackColor == Color.Silver) btnSat10.BackColor = Color.SteelBlue;
            else btnSat10.BackColor = Color.Silver;
        }

        private void btnSat11_Click(object sender, EventArgs e)
        {
            if (btnSat11.BackColor == Color.Silver) btnSat11.BackColor = Color.SteelBlue;
            else btnSat11.BackColor = Color.Silver;
        }

        private void btnSat12_Click(object sender, EventArgs e)
        {
            if (btnSat12.BackColor == Color.Silver) btnSat12.BackColor = Color.SteelBlue;
            else btnSat12.BackColor = Color.Silver;
        }

        private void btnSat13_Click(object sender, EventArgs e)
        {
            if (btnSat13.BackColor == Color.Silver) btnSat13.BackColor = Color.SteelBlue;
            else btnSat13.BackColor = Color.Silver;
        }

        private void btnSat14_Click(object sender, EventArgs e)
        {
            if (btnSat14.BackColor == Color.Silver) btnSat14.BackColor = Color.SteelBlue;
            else btnSat14.BackColor = Color.Silver;
        }

        private void btnSat15_Click(object sender, EventArgs e)
        {
            if (btnSat15.BackColor == Color.Silver) btnSat15.BackColor = Color.SteelBlue;
            else btnSat15.BackColor = Color.Silver;
        }

        private void btnSat16_Click(object sender, EventArgs e)
        {
            if (btnSat16.BackColor == Color.Silver) btnSat16.BackColor = Color.SteelBlue;
            else btnSat16.BackColor = Color.Silver;
        }
        //DOMINGO
        private void btnSun8_Click(object sender, EventArgs e)
        {
            if (btnSun8.BackColor == Color.Silver) btnSun8.BackColor = Color.SteelBlue;
            else btnSun8.BackColor = Color.Silver;
        }

        private void btnSun9_Click(object sender, EventArgs e)
        {
            if (btnSun9.BackColor == Color.Silver) btnSun9.BackColor = Color.SteelBlue;
            else btnSun9.BackColor = Color.Silver;
        }

        private void btnSun10_Click(object sender, EventArgs e)
        {
            if (btnSun10.BackColor == Color.Silver) btnSun10.BackColor = Color.SteelBlue;
            else btnSun10.BackColor = Color.Silver;
        }

        private void btnSun11_Click(object sender, EventArgs e)
        {
            if (btnSun11.BackColor == Color.Silver) btnSun11.BackColor = Color.SteelBlue;
            else btnSun11.BackColor = Color.Silver;
        }

        private void btnSun12_Click(object sender, EventArgs e)
        {
            if (btnSun12.BackColor == Color.Silver) btnSun12.BackColor = Color.SteelBlue;
            else btnSun12.BackColor = Color.Silver;
        }

        private void btnSun13_Click(object sender, EventArgs e)
        {
            if (btnSun13.BackColor == Color.Silver) btnSun13.BackColor = Color.SteelBlue;
            else btnSun13.BackColor = Color.Silver;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string rowS;
            int row;
            //LUNES
            foreach (Control c in gbMon.Controls)
            {
                if (c is Button)
                {
                    rowS = c.Name.Substring(6);
                    row = Int32.Parse(rowS) - 8;
                    if (c.BackColor == Color.SteelBlue)
                    {
                        schedule[row, 0] = 1;
                    }
                    else schedule[row, 0] = 0;

                    c.Text = schedule[row, 0].ToString();
                }
            }
            //MARTES
            foreach (Control c in gbTue.Controls)
            {
                rowS = c.Name.Substring(6);
                row = Int32.Parse(rowS) - 8;
                if (c.BackColor == Color.SteelBlue)
                {
                    schedule[row, 1] = 1;
                }
                else schedule[row, 1] = 0;

                c.Text = schedule[row, 1].ToString();
            }
            //MIÉRCOLES
            foreach (Control c in gbWed.Controls)
            {
                rowS = c.Name.Substring(6);
                row = Int32.Parse(rowS) - 8;
                if (c.BackColor == Color.SteelBlue)
                {
                    schedule[row, 2] = 1;
                }
                else schedule[row, 2] = 0;

                c.Text = schedule[row, 2].ToString();
            }
            //JUEVES
            foreach (Control c in gbThu.Controls)
            {
                rowS = c.Name.Substring(6);
                row = Int32.Parse(rowS) - 8;
                if (c.BackColor == Color.SteelBlue)
                {
                    schedule[row, 3] = 1;
                }
                else schedule[row, 3] = 0;

                c.Text = schedule[row, 3].ToString();
            }
            //VIERNES
            foreach (Control c in gbFri.Controls)
            {
                rowS = c.Name.Substring(6);
                row = Int32.Parse(rowS) - 8;
                if (c.BackColor == Color.SteelBlue)
                {
                    schedule[row, 4] = 1;
                }
                else schedule[row, 4] = 0;

                c.Text = schedule[row, 4].ToString();
            }
            //SÁBADO
            foreach (Control c in gbSat.Controls)
            {
                rowS = c.Name.Substring(6);
                row = Int32.Parse(rowS) - 8;
                if (c.BackColor == Color.SteelBlue)
                {
                    schedule[row, 5] = 1;
                }
                else schedule[row, 5] = 0;

                c.Text = schedule[row, 5].ToString();
            }
            //DOMINGO
            foreach (Control c in gbSun.Controls)
            {
                rowS = c.Name.Substring(6);
                row = Int32.Parse(rowS) - 8;
                if (c.BackColor == Color.SteelBlue)
                {
                    schedule[row, 6] = 1;
                }
                else schedule[row, 6] = 0;

                c.Text = schedule[row, 6].ToString();
            }

            weekAvailability = "";
            for(int j = 0; j < 7; j++)
            {
                for(int i = 0;i < 11; i++)
                {
                    weekAvailability = weekAvailability + schedule[i, j].ToString();
                }
            }

            server.UpdateWeekAvailability(weekAvailability, user.username);

            label1.Text = user.username;
        }
    }
}
