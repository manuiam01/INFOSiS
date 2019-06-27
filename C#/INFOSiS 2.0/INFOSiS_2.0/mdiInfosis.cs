using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFOSiS_2._0.Server;

namespace INFOSiS_2._0
{
    public partial class MdiInfosis : Form
    {
        private Server.user user;

        public user User { get => user; set => user = value; }

        public MdiInfosis()
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            panelMdiOptions.Visible = false;
        }
        public MdiInfosis(Server.user u)
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            panelMdiOptions.Visible = false;
            this.User = u;
            this.Text = this.Text + " " + user.username + " " + user.acces.name;
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
            panelMdiOptions.Visible = true;
            if (!panelMdiInfosis.Controls.Contains(StudentRegister.Instance))
            {
                panelMdiInfosis.Controls.Add(StudentRegister.Instance);
                StudentRegister.Instance.Dock = DockStyle.Fill;
                StudentRegister.PanelMdi = panelMdiInfosis;
                StudentRegister.Instance.Visible = true;
                StudentRegister.Instance.BringToFront();
            }
            else
            {
                StudentRegister.Instance.Visible = true;
                StudentRegister.Instance.BringToFront();
            }

            if (!panelMdiOptions.Controls.Contains(StudentButtons.Instance))
            {
                panelMdiOptions.Controls.Add(StudentButtons.Instance);
                StudentButtons.Instance.Dock = DockStyle.Fill;
                StudentButtons.PanelMdi = panelMdiInfosis;
                StudentButtons.Instance.Visible = true;
                StudentButtons.Instance.BringToFront();
            }
            else
            {
                StudentButtons.Instance.Visible = true;
                StudentButtons.Instance.BringToFront();
            }


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
                if (user.acces.id != 2)
                {
                    ProfileButtons.Instance.verificar_usuario(user);
                }
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
            panelMdiOptions.Visible = true;
            if (!panelMdiInfosis.Controls.Contains(CourseRegister.Instance))
            {
                panelMdiInfosis.Controls.Add(CourseRegister.Instance);
                CourseRegister.Instance.Dock = DockStyle.Fill;
                CourseRegister.PanelMdi = panelMdiInfosis;
                CourseRegister.Instance.Visible = true;
                CourseRegister.Instance.BringToFront();
            }
            else
            {
                CourseRegister.Instance.Visible = true;
                CourseRegister.Instance.BringToFront();
            }

            if (!panelMdiOptions.Controls.Contains(CourseButtons.Instance))
            {
                panelMdiOptions.Controls.Add(CourseButtons.Instance);
                CourseButtons.Instance.Dock = DockStyle.Fill;
                CourseButtons.PanelMdi = panelMdiInfosis;
                CourseButtons.Instance.Visible = true;
                CourseButtons.Instance.BringToFront();
            }
            else
            {
                CourseButtons.Instance.Visible = true;
                CourseButtons.Instance.BringToFront();
            }
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
                if (user.acces.id != 2)
                {
                    WorkforceButtons.Usuario = user;
                }
                WorkforceButtons.Instance.Visible = true;
                WorkforceButtons.Instance.BringToFront();
            }
            else
            {
                WorkforceButtons.Instance.Visible = true;
                WorkforceButtons.Instance.BringToFront();
            }
        }

        private void MdiInfosis_Load(object sender, EventArgs e)
        {

        }
    }
}
