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
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            //Según la gran comeña, las 2 lineas de abajo no sirven :v
            //panelMdi.Visible = true;
            //panelHeader.BringToFront();
            
>>>>>>> 7c2773cf0e4c8468c43da6fb7950cab60e9694a1

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
            panelMdi.Controls.Remove(ProfessorControl.Instance);
            /*Agregar los remove de los que sean necesarios*/
            //if (!panelMdi.Controls.Contains(ProfessorControl.Instance))
            //{
            //    panelMdi.Controls.Add(ProfessorControl.Instance);
            //    ProfessorControl.Instance.Dock = DockStyle.Fill;
            //    ProfessorControl.PanelnotThisProfessor = panelMdi;
            //    ProfessorControl.Instance.BringToFront();
            //}
            //else
            //{
            //    ProfessorControl.Instance.Visible = true;
            //    ProfessorControl.Instance.BringToFront();
            //}
        }
    }
}
