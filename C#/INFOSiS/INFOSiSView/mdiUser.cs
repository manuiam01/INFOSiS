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
    public partial class mdiUser : Form
    {
        private frmCourseHistoryManager frmcoursehistory;
        private frmCoursesManager frmcourse;
        private frmProfessorManager frmprofessor;
        private frmStudentConsult frmstudentconsult;
        private frmStudentManager frmstudent;
        private frmInterestedMailing frminterestedmail;
        private frmInterestedManager frminterested;
        private frmPasswordManager frmpw;
        private FrmWeekAvailability frmweekavailability;
        public mdiUser()
        {
            InitializeComponent();
            cambiarEstado(State.New);
        }

        public void fManage_Closingfrm(object sender, FormClosingEventArgs e)
        {
            frmcourse = null;
            frmcoursehistory = null;
            frmprofessor = null;
            frmstudentconsult = null;
            frmstudent = null;
            frmweekavailability = null;
            frminterestedmail = null;
            frminterested = null;
            frmpw = null;
            cambiarEstado(State.New);
        }

        private void gestiónDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcourse == null)
            {
                frmcourse = new frmCoursesManager();
                frmcourse.FormClosing += fManage_Closingfrm;
                frmcourse.MdiParent=this;
                cambiarEstado(State.Modify);
            }
            frmcourse.enable_Report(false);
            frmcourse.Visible = true;
        }

        private void cambiarEstado(State estado)
        {
            switch (estado)
            {
                case State.New:
                    coursesToolStripMenuItem.Enabled = true;
                    alumnosToolStripMenuItem.Enabled = true;
                    interesadosToolStripMenuItem.Enabled = true;
                    profesoresToolStripMenuItem.Enabled = true;
                    practicantesToolStripMenuItem.Enabled = true;
                    opcionesToolStripMenuItem.Enabled = true;
                    break;
                case State.Modify:
                    coursesToolStripMenuItem.Enabled = false;
                    alumnosToolStripMenuItem.Enabled = false;
                    interesadosToolStripMenuItem.Enabled = false;
                    profesoresToolStripMenuItem.Enabled = false;
                    practicantesToolStripMenuItem.Enabled = false;
                    opcionesToolStripMenuItem.Enabled = false;
                    break;
            }

        }

        private void gestiónDeCursosDictadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmcoursehistory == null)
            {
                frmcoursehistory = new frmCourseHistoryManager();
                frmcoursehistory.FormClosing += fManage_Closingfrm;
                frmcoursehistory.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmcoursehistory.Visible = true;
        }

        private void consultaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmstudentconsult == null)
            {
                frmstudentconsult = new frmStudentConsult();
                frmstudentconsult.FormClosing += fManage_Closingfrm;
                frmstudentconsult.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmstudentconsult.Visible = true;
        }

        private void gestiónDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmstudent == null)
            {
                frmstudent = new frmStudentManager();
                frmstudent.FormClosing += fManage_Closingfrm;
                frmstudent.MdiParent=this;
                cambiarEstado(State.Modify);
            }
            frmstudent.Visible = true;
        }

        private void mandarPublicidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frminterestedmail = new frmInterestedMailing();
            if (frminterestedmail == null)
            {
                
                frminterestedmail.FormClosing += fManage_Closingfrm;
                frminterestedmail.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frminterestedmail.Visible = true;
        }

        private void gestiónDeInteresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frminterested == null)
            {
                frminterested = new frmInterestedManager();
                frminterested.FormClosing += fManage_Closingfrm;
                frminterested.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frminterested.Visible = true;
            
        }

        private void gestiónDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmprofessor == null)
            {
                frmprofessor = new frmProfessorManager();
                frmprofessor.FormClosing += fManage_Closingfrm;
                frmprofessor.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmprofessor.enable_Report(false);
            frmprofessor.Visible = true;
        }

        private void disponibilidadSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmweekavailability == null)
            {
                frmweekavailability = new FrmWeekAvailability();
                frmweekavailability.FormClosing += fManage_Closingfrm;
                frmweekavailability.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmweekavailability.Visible = true;

        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmpw == null)
            {
                frmpw = new frmPasswordManager();
                frmpw.FormClosing += fManage_Closingfrm;
                frmpw.MdiParent = this;
                cambiarEstado(State.Modify);
            }
            frmpw.Visible = true;
        }  
    }
}
