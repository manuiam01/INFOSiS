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
        private Server.ServerClient server;
        private Server.professor professor;
        
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
        }

        private void ProfessorReport_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            professor = new Server.professor();
            professor = server.SearchProfessorByIdPUCP(txtPUCPcode.Text);
            if (professor.idPUCP != null)
            {
                dgvCoursesHistory.AutoGenerateColumns = false;
                dgvCoursesHistory.DataSource = server.queryCourseHistoryByIdProfessor(professor.idPUCP);
            }
            else
            {
                MessageBox.Show("Código PUCP no encontrado", "Profesor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lblAdvancedSearch_Click(object sender, EventArgs e)
        {
            ProfessorAdvancedSearch formSearchProfessor = new ProfessorAdvancedSearch();
            if (formSearchProfessor.ShowDialog() == DialogResult.OK)
            {
                professor = formSearchProfessor.Professor;
                txtPUCPcode.Text = professor.idPUCP;
                dgvCoursesHistory.AutoGenerateColumns = false;
                dgvCoursesHistory.DataSource = server.queryCourseHistoryByIdProfessor(professor.idPUCP);

            }
        }
    }
}
