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
            WindowState = FormWindowState.Maximized;
            panelMdiOptions.Visible = false;
        }

        public void cleanWindow()
        {
            foreach (Control item in panelMdiInfosis.Controls.OfType<Control>())
            {
                panelMdiInfosis.Controls.Remove(item);
            }

            foreach (Control item in panelMdiOptions.Controls.OfType<Control>())
            {
                panelMdiOptions.Controls.Remove(item);
            }
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            cleanWindow();
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
            cleanWindow();
                        
        }

        private void BtnInterested_Click(object sender, EventArgs e)
        {
            cleanWindow();
            panelMdiOptions.Visible = true;
            if (!panelMdiInfosis.Controls.Contains(InterestedRegister.Instance))
            {
                panelMdiInfosis.Controls.Add(InterestedRegister.Instance);
                InterestedRegister.Instance.Dock = DockStyle.Fill;
                InterestedRegister.PanelMdi = panelMdiInfosis;
                InterestedRegister.Instance.Visible = true;
                InterestedRegister.Instance.BringToFront();
            }
            else
            {
                InterestedRegister.Instance.Visible = true;
                InterestedRegister.Instance.BringToFront();
            }

            if (!panelMdiOptions.Controls.Contains(InterestedButtons.Instance))
            {
                panelMdiOptions.Controls.Add(InterestedButtons.Instance);
                InterestedButtons.Instance.Dock = DockStyle.Fill;
                InterestedButtons.PanelMdi = panelMdiInfosis;
                InterestedButtons.Instance.Visible = true;
                InterestedButtons.Instance.BringToFront();
            }
            else
            {
                InterestedButtons.Instance.Visible = true;
                InterestedButtons.Instance.BringToFront();
            }

        }
        
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            cleanWindow();
            panelMdiOptions.Visible = true;
            if (!panelMdiInfosis.Controls.Contains(ProfileEdit.Instance))
            {
                panelMdiInfosis.Controls.Add(ProfileEdit.Instance);
                ProfileEdit.Instance.Dock = DockStyle.Fill;
                ProfileEdit.PanelMdi = panelMdiInfosis;
                ProfileEdit.Instance.Visible = true;
                ProfileEdit.Instance.BringToFront();
            }
            else
            {
                ProfileEdit.Instance.Visible = true;
                ProfileEdit.Instance.BringToFront();
            }

            if (!panelMdiOptions.Controls.Contains(ProfileButtons.Instance))
            {
                panelMdiOptions.Controls.Add(ProfileButtons.Instance);
                ProfileButtons.Instance.Dock = DockStyle.Fill;
                ProfileButtons.PanelMdi = panelMdiInfosis;
                ProfileButtons.Instance.Visible = true;
                ProfileButtons.Instance.BringToFront();
            }
            else
            {
                ProfileButtons.Instance.Visible = true;
                ProfileButtons.Instance.BringToFront();
            }
        }

        private void BtnCourse_Click(object sender, EventArgs e)
        {
            cleanWindow();
        }

        private void BtnInterns_Click(object sender, EventArgs e)
        {
            cleanWindow();
            panelMdiOptions.Visible = true;
            if (!panelMdiInfosis.Controls.Contains(WorkforceRegister.Instance))
            {
                panelMdiInfosis.Controls.Add(WorkforceRegister.Instance);
                WorkforceRegister.Instance.Dock = DockStyle.Fill;
                WorkforceRegister.PanelMdi = panelMdiInfosis;
                WorkforceRegister.Instance.Visible = true;
                WorkforceRegister.Instance.BringToFront();
            }
            else
            {
                WorkforceRegister.Instance.Visible = true;
                WorkforceRegister.Instance.BringToFront();
            }

            if (!panelMdiOptions.Controls.Contains(WorkforceButtons.Instance))
            {
                panelMdiOptions.Controls.Add(WorkforceButtons.Instance);
                WorkforceButtons.Instance.Dock = DockStyle.Fill;
                WorkforceButtons.PanelMdi = panelMdiInfosis;
                WorkforceButtons.Instance.Visible = true;
                WorkforceButtons.Instance.BringToFront();
            }
            else
            {
                WorkforceButtons.Instance.Visible = true;
                WorkforceButtons.Instance.BringToFront();
            }
        }
    }
}
