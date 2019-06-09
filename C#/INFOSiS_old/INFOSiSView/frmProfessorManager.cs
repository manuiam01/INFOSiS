using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiSView
{
    public partial class frmProfessorManager : Form
    {
        public frmProfessorManager()
        {
            InitializeComponent();
            dgvProfessors.Rows.Add("Freddy", "Paz", "Recalde", "freddy.paz@pucp.pe","959599595");
            dgvProfessors.Rows.Add("Miguel", "Guanira", "Erazo", "miguel.guanira@pucp.pe", "484848485");
        }

        void componentsState(State state)
        {
            switch (state)
            {
                case State.New:

                    break;
                
               
            }
        }

        public void enable_Report(bool flag)
        {
            btnReporte.Enabled = flag;
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            if (dgvProfessors.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmProfessorReport professorReport = new frmProfessorReport();
                professorReport.ShowDialog();
            }
        }
    }
}
