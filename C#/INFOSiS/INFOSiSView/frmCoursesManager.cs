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
    public partial class frmCoursesManager : Form
    {

        frmAddRequisites addreq;
        public frmCoursesManager()
        {
           
            InitializeComponent();
//<<<<<<< HEAD
            ComponentsState(State.Initial);
            CleanComponents();
        }

        void ComponentsState(State state)
        {
            switch (state)
            {
                case State.Initial:
                    txtName.Enabled = false;
                    txtId.Enabled = false;
                    txtDescription.Enabled = false;
                    btnAddRequisite.Enabled = false;
                    btnAddSyllabus.Enabled = false;
                    cmbCourseType.Enabled = false;
                    btnNew.Enabled = true;
                    btnModify.Enabled = true;
                    
                    btnSave.Enabled = false;
                    btnDisable.Enabled = true;
                    btnCancel.Enabled = false;
                    
                    break;
                case State.New:
                    txtName.Enabled = true;
                    txtId.Enabled = true;
                    txtDescription.Enabled = true;
                    btnAddRequisite.Enabled = true;
                    btnAddSyllabus.Enabled = true;
                    cmbCourseType.Enabled = true;
                    btnNew.Enabled = false;
                    btnModify.Enabled = false;
                    
                    btnSave.Enabled = true;
                    btnDisable.Enabled = false;
                    btnCancel.Enabled = true;
                    
                    break;
                case State.Modify:
                    txtName.Enabled = true;
                    txtId.Enabled = false;
                    txtDescription.Enabled = true;
                    btnAddRequisite.Enabled = true;
                    btnAddSyllabus.Enabled = true;
                    cmbCourseType.Enabled = true;
                    btnNew.Enabled = false;
                    btnModify.Enabled = false;
                    
                    btnSave.Enabled = true;
                    btnDisable.Enabled = false;
                    btnCancel.Enabled = true;
                    
                    break;
               
                case State.Search:
                    txtName.Enabled = false;
                    txtId.Enabled = true;
                    txtDescription.Enabled = false;
                    btnAddRequisite.Enabled = false;
                    btnAddSyllabus.Enabled = false;
                    cmbCourseType.Enabled = false;
                    btnNew.Enabled = false;
                    btnModify.Enabled = true;
                   
                    btnSave.Enabled = false;
                    btnDisable.Enabled = true;
                    btnCancel.Enabled = true;
                    
                    break;
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ComponentsState(State.New);
            CleanComponents();
            btnAddRequisite.Text = "Añadir Requisitos";
            btnAddSyllabus.Text = "Añadir Sílabo";
        }

        private void CleanComponents()
        {
            txtName.Text = "";
            txtId.Text = "";
            txtDescription.Text = "";
            cmbCourseType.Text = "";
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Modify);
            btnAddRequisite.Text = "Modificar Requisitos";
            btnAddSyllabus.Text = "Modificar Sílabo";
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Initial);
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Initial);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Initial);
        }

        private void btnAddRequisite_Click(object sender, EventArgs e)
        {
            addreq = new frmAddRequisites();    
            addreq.ShowDialog();

            //dgvCourses.Rows.Add("SQL","101","Curso sobre BD");
            //dgvCourses.Rows.Add("Excel Básico", "102", "Curso sobre excel básico");
        }

        public void enable_Report(bool flag)
        {
            btnReport.Enabled = flag;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (dgvCourses.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione un curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmCourseReport courseReport = new frmCourseReport();
                courseReport.ShowDialog();
            }

        }
    }
  
}
