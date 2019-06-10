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
    public partial class InterestedButtons : UserControl
    {
        private static InterestedButtons _instance;
        private static Panel _panelMdi;
        public static InterestedButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedButtons();
                return _instance;
            }
        }
        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedButtons()
        {
            InitializeComponent();
            btnNewInte.BackColor = Color.LightSteelBlue;
            btnModificarInte.BackColor = Color.LightSteelBlue;

        }

        private void BtnNewInte_Click(object sender, EventArgs e)
        {

            actualizarBotones(btnNewInte);
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }
            if (!PanelMdi.Controls.Contains(InterestedSearch.Instance))
            {
                PanelMdi.Controls.Add(InterestedRegister.Instance);
                InterestedRegister.Instance.Dock = DockStyle.Fill;
                InterestedSearch.PanelMdi = PanelMdi;
                InterestedSearch.Instance.Visible = true;
                InterestedSearch.Instance.BringToFront();
            }
            else
            {
                InterestedSearch.Instance.Visible = true;
                InterestedSearch.Instance.BringToFront();
            }
        }
        public void actualizarBotones(Button boton)
        {
            btnNewInte.BackColor = Color.LightSteelBlue;
            btnModificarInte.BackColor = Color.LightSteelBlue;
            boton.BackColor = Color.LightGray;
        }

        private void BtnModificarInte_Click(object sender, EventArgs e)
        {
            {
                //la verdad ni idea de que hace todo el código de abajo, pero funciona así que alv, gracias comeña :3
                actualizarBotones(btnModificarInte);
                foreach (Control item in PanelMdi.Controls.OfType<Control>())
                {
                    PanelMdi.Controls.Remove(item);
                }

                if (!PanelMdi.Controls.Contains(InterestedSearch.Instance))
                {
                    PanelMdi.Controls.Add(InterestedSearch.Instance);
                    InterestedSearch.Instance.Dock = DockStyle.Fill;
                    InterestedSearch.PanelMdi = PanelMdi;
                    InterestedSearch.Instance.Visible = true;
                    InterestedSearch.Instance.BringToFront();
                }
                else
                {
                    InterestedSearch.Instance.Visible = true;
                    InterestedSearch.Instance.BringToFront();
                }

            }
        }
    }
}
