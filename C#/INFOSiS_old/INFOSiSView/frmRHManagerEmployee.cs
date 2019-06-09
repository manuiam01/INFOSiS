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
    public partial class frmRHManagerEmployee : Form
    {
        public frmRHManagerEmployee()
        {
            InitializeComponent();
            dgvInterns.Rows.Add("Diego","Andre","Recalde","Manrique","20132222","diego.recalde@gmail.com","928987892");
        }

        private void BtnInternReport_Click(object sender, EventArgs e)
        {
            if (dgvInterns.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un practicante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmInternReport internReport = new frmInternReport();
                internReport.ShowDialog();
            }
        }
    }
}
