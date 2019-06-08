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
    public partial class frmCourseHistoryManager : Form
    {
        public frmCourseHistoryManager()
        {
            InitializeComponent();
            ComponentsState(State.Initial);
            CleanComponents();
        }

        private void CleanComponents()
        {
            txtId.Text = "";
            cmbCourse.Text = "";
            cmbProffesor.Text = "";
            cmbAssistant.Text = "";
        }

        private void ComponentsState(State state)
        {
            switch (state)
            {
                case State.Initial:
                    CleanComponents();
                    txtId.Enabled = false;
                    btnAddSession.Enabled = false;
                    cmbCourse.Enabled = false;
                    cmbProffesor.Enabled = false;
                    cmbAssistant.Enabled = false;
                    btnSelectSurvey.Enabled = false;
                    cmbStudent.Enabled = false;
                    dgvStudents.Enabled = false;
                    btnNew.Enabled = true;
                    btnModify.Enabled = false;
                    btnSearch.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnAddStudent.Enabled = false;
                    btnDeleteStudent.Enabled = false;
                    break;
                case State.New:
                    txtId.Enabled = true;
                    btnAddSession.Enabled = true;
                    cmbCourse.Enabled = true;
                    cmbProffesor.Enabled = true;
                    cmbAssistant.Enabled = true;
                    btnSelectSurvey.Enabled = true;
                    cmbStudent.Enabled = true;
                    dgvStudents.Enabled = true;
                    btnNew.Enabled = false;
                    btnModify.Enabled = false;
                    btnSearch.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnAddStudent.Enabled = true;
                    btnDeleteStudent.Enabled = true;
                    break;
                case State.Modify:
                    txtId.Enabled = false;
                    btnAddSession.Enabled = true;
                    cmbCourse.Enabled = true;
                    cmbProffesor.Enabled = true;
                    cmbAssistant.Enabled = true;
                    btnSelectSurvey.Enabled = true;
                    cmbStudent.Enabled = true;
                    dgvStudents.Enabled = true;
                    btnNew.Enabled = false;
                    btnModify.Enabled = false;
                    btnSearch.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnAddStudent.Enabled = true;
                    btnDeleteStudent.Enabled = true;
                    break;
                case State.Search:
                    txtId.Enabled = true;
                    btnAddSession.Enabled = false;
                    cmbCourse.Enabled = false;
                    cmbProffesor.Enabled = false;
                    cmbAssistant.Enabled = false;
                    btnSelectSurvey.Enabled = false;
                    cmbStudent.Enabled = false;
                    dgvStudents.Enabled = false;
                    btnNew.Enabled = false;
                    btnModify.Enabled = true;
                    btnSearch.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    btnAddStudent.Enabled = false;
                    btnDeleteStudent.Enabled = false;
                    break;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ComponentsState(State.New);
            CleanComponents();
            btnAddSession.Text = "Añadir sesiones";
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Search);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Modify);
            btnAddSession.Text = "Modificar sesiones";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Initial);
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Initial);
            
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            frmAddSession addsession = new frmAddSession();
            addsession.ShowDialog();
        }
    }
}
