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
    public partial class ProfessorReport : UserControl
    {
        private static ProfessorReport _instance;
        private static Panel _panelMdi;

        public static ProfessorReport Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfessorReport();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public ProfessorReport()
        {
            InitializeComponent();
            btnReport.Enabled = false;
            txtFirstName.Enabled = false;
            txtSecondName.Enabled = false;
            txtPrimaryLastName.Enabled = false;
            txtSecondLastName.Enabled = false;
        }

        private void ProfessorReport_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text.Count()!=0){
                btnReport.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", "Profesor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
