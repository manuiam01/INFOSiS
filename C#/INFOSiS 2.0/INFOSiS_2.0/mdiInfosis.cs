using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiS_2._0
{
    public partial class MdiInfosis : Form
    {
        public MdiInfosis()
        {
            InitializeComponent();
<<<<<<< HEAD
            WindowState = FormWindowState.Maximized;
=======
            panelMdiOptions.Visible = false;
>>>>>>> 0d7d79a84597a0c1b2919a4c9ddafb600d7611eb
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            panelMdiOptions.Visible = true;
            if (!panelMdiInfosis.Controls.Contains(ProfessorRegister.Instance))
            {
                panelMdiInfosis.Controls.Add(ProfessorRegister.Instance);
                ProfessorRegister.Instance.Dock = DockStyle.Fill;
                ProfessorRegister.PanelMdi = panelMdiInfosis;
                ProfessorRegister.Instance.Visible = true;
                ProfessorRegister.Instance.BringToFront();
            }
            else
            {
                ProfessorRegister.Instance.Visible = true;
                ProfessorRegister.Instance.BringToFront();
            }

            if (!panelMdiOptions.Controls.Contains(ProfessorButtons.Instance))
            {
                panelMdiOptions.Controls.Add(ProfessorButtons.Instance);
                ProfessorButtons.Instance.Dock = DockStyle.Fill;
                ProfessorButtons.PanelMdi = panelMdiInfosis;
                ProfessorButtons.Instance.Visible = true;
                ProfessorButtons.Instance.BringToFront();
            }
            else
            {
                ProfessorButtons.Instance.Visible = true;
                ProfessorButtons.Instance.BringToFront();
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            panelMdiOptions.Visible = true;
        }

        private void BtnInterested_Click(object sender, EventArgs e)
        {
            limpiarVistas();
            
        }
        

        //Para limpiar o desaparecer las demás vistas, si piensan que hay mejor formar de hacer eso
        //agreguenlo o eliminen el limpiar vistas si no lo ven necesario jeje
        public void limpiarVistas()
        {
            ProfessorButtons.Instance.Visible = false;
            ProfessorRegister.Instance.Visible = false;
            //StudentButtons.Instance.Visible = false;
            //InterestedButtons.Instance.Visible = false;
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            if (!panelMdiInfosis.Controls.Contains(ProfessorRegister.Instance))
            {
                panelMdiInfosis.Controls.Add(ProfessorRegister.Instance);
                ProfessorRegister.Instance.Dock = DockStyle.Fill;
                ProfessorRegister.PanelMdi = panelMdiInfosis;
                ProfessorRegister.Instance.Visible = true;
                ProfessorRegister.Instance.BringToFront();
            }
            else
            {
                ProfessorRegister.Instance.Visible = true;
                ProfessorRegister.Instance.BringToFront();
            }

            if (!panelMdiOptions.Controls.Contains(ProfileButtons.Instance))
            {
                panelMdiOptions.Controls.Add(ProfileButtons.Instance);
                ProfileButtons.Instance.Dock = DockStyle.Fill;
                ProfileButtons.PanelMdi = panelMdiInfosis;
                ProfileButtons.Instance.Visible = true;
                ProfileButtons.Instance.BringToFront();
            }
            else
            {
                ProfileButtons.Instance.Visible = true;
                ProfileButtons.Instance.BringToFront();
            }
        }
    }
}
