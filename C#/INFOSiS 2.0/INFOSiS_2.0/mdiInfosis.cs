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
            panelMdiOptions.Visible = false;
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {

            panelMdiInfosis.Visible = true;
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
    }
}
