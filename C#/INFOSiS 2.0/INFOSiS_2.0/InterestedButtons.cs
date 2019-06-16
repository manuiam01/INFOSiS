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
            btnNewInte.BackColor = Color.LightGray;
            btnModificarInte.BackColor = Color.LightSteelBlue;
            btnMailing.BackColor = Color.LightSteelBlue;
        }

        private void BtnNewInte_Click(object sender, EventArgs e)
        {
            
            actualizarBotones(btnNewInte);
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }
            if (!PanelMdi.Controls.Contains(InterestedModified.Instance))
            {
                PanelMdi.Controls.Add(InterestedRegister.Instance);
                InterestedRegister.Instance.Dock = DockStyle.Fill;
                InterestedModified.PanelMdi = PanelMdi;
                InterestedModified.Instance.Visible = true;
                InterestedModified.Instance.BringToFront();
            }
            else
            {
                InterestedModified.Instance.Visible = true;
                InterestedModified.Instance.BringToFront();
            }
        }
        public void actualizarBotones(Button boton)
        {
            btnNewInte.BackColor = Color.LightSteelBlue;
            btnModificarInte.BackColor = Color.LightSteelBlue;
            btnMailing.BackColor = Color.LightSteelBlue;
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

                if (!PanelMdi.Controls.Contains(InterestedModified.Instance))
                {
                    PanelMdi.Controls.Add(InterestedModified.Instance);
                    InterestedModified.Instance.Dock = DockStyle.Fill;
                    InterestedModified.PanelMdi = PanelMdi;
                    InterestedModified.Instance.Visible = true;
                    InterestedModified.Instance.BringToFront();
                }
                else
                {
                    InterestedModified.Instance.Visible = true;
                    InterestedModified.Instance.BringToFront();
                }

            }
        }

        private void InterestedButtons_Leave(object sender, EventArgs e)
        {
            btnNewInte.BackColor = Color.LightSteelBlue;
            btnModificarInte.BackColor = Color.LightSteelBlue;
            btnMailing.BackColor = Color.LightSteelBlue;
        }

        private void BtnMailing_Click(object sender, EventArgs e)
        {
            actualizarBotones(btnMailing);
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(InterestedPublicity.Instance))
            {
                PanelMdi.Controls.Add(InterestedPublicity.Instance);
                InterestedPublicity.Instance.Dock = DockStyle.Fill;
                InterestedPublicity.PanelMdi = PanelMdi;
                InterestedPublicity.Instance.Visible = true;
                InterestedPublicity.Instance.BringToFront();
            }
            else
            {
                InterestedPublicity.Instance.Visible = true;
                InterestedPublicity.Instance.BringToFront();
            }
        }

        //private void BtnBajaInteresado_Click(object sender, EventArgs e)
        //{
        //    actualizarBotones(btnBajaInteresado);
        //    foreach (Control item in PanelMdi.Controls.OfType<Control>())
        //    {
        //        PanelMdi.Controls.Remove(item);
        //    }

        //    if (!PanelMdi.Controls.Contains(InterestedDisable.Instance))
        //    {
        //        PanelMdi.Controls.Add(InterestedDisable.Instance);
        //        InterestedDisable.Instance.Dock = DockStyle.Fill;
        //        InterestedDisable.PanelMdi = PanelMdi;
        //        InterestedDisable.Instance.Visible = true;
        //        InterestedDisable.Instance.BringToFront();
        //    }
        //    else
        //    {
        //        InterestedDisable.Instance.Visible = true;
        //        InterestedDisable.Instance.BringToFront();
        //    }
        //}
    }
}
