using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Web.UI;

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
            txtPUCPcode.CharacterCasing = CharacterCasing.Upper;
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
                btnReport.Enabled = true;
            }
            else
            {
                MessageBox.Show("Código PUCP no encontrado", "Profesor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvCoursesHistory.DataSource = null;
                btnReport.Enabled = false;
            }
        }

        private void lblAdvancedSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            professor = new Server.professor();
            ProfessorAdvancedSearchForReport formSearchProfessor = new ProfessorAdvancedSearchForReport();
            if (formSearchProfessor.ShowDialog() == DialogResult.OK)
            {
                professor = formSearchProfessor.Professor;
                txtPUCPcode.Text = professor.idPUCP;
                dgvCoursesHistory.AutoGenerateColumns = false;
                dgvCoursesHistory.DataSource = server.queryCourseHistoryByIdProfessor(professor.idPUCP);
                btnReport.Enabled = true;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtPUCPcode.Clear();
            dgvCoursesHistory.DataSource = null;
            btnReport.Enabled = false;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            if(dgvCoursesHistory.SelectedRows.Count != 0){
                //si ha seleccionado un curso dictado
                Server.courseHistory courseHistory= (Server.courseHistory)dgvCoursesHistory.CurrentRow.DataBoundItem;
                server.generateCourseHistoryReport(courseHistory.id);
                server.saveCourseHistoryReport(courseHistory.id, "D:/Users/alulab14/Documents");  
            }
            else
            {
                //el reporte se hará sobre todos los cursos que ha dictado el profesor
            }
        }
    }
}
