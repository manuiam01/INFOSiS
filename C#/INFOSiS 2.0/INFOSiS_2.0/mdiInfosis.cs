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
    public partial class mdiInfosis : Form
    {
        public mdiInfosis()
        {
            InitializeComponent();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {

            panelMdi.Visible = true;
            panelHeader.BringToFront();

            if (!panelMdi.Controls.Contains(ProfessorControl.Instance))
            {
                panelMdi.Controls.Add(ProfessorControl.Instance);
                ProfessorControl.Instance.Dock = DockStyle.Fill;
                ProfessorControl.PanelnotThisProfessor = panelMdi;
                ProfessorControl.Instance.BringToFront();
            }
            else
            {
                ProfessorControl.Instance.Visible = true;
                ProfessorControl.Instance.BringToFront();
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            panelMdi.Controls.Remove(ProfessorControl.Instance);
            
        }
    }
}
