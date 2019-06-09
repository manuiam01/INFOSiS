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
    public partial class ProfessorControl : UserControl
    {
        private static ProfessorControl _instance;
        private static Panel _panelnotThisProfessor;

        public static ProfessorControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfessorControl();
                return _instance;
            }
        }

        public static Panel PanelnotThisProfessor
        {
            get => _panelnotThisProfessor;
            set => _panelnotThisProfessor = value;
        }
            
        
        public ProfessorControl()
        {
            InitializeComponent();


            panelProfessor.Visible = true;
            panelProfessorOptions.BringToFront();

            if (!panelProfessor.Controls.Contains(ProfessorRegister.Instance))
            {
                panelProfessor.Controls.Add(ProfessorRegister.Instance);
                ProfessorRegister.Instance.Dock = DockStyle.Fill;
                ProfessorRegister.PanelnotThisProfessorRegister = panelProfessor;
                ProfessorRegister.Instance.BringToFront();
                
            }
            else
            {
                ProfessorRegister.Instance.Visible = true;
                ProfessorRegister.Instance.BringToFront();
            }
          }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            panelProfessor.Visible = true;
            panelProfessorOptions.BringToFront();

            if (!panelProfessor.Controls.Contains(ProfessorRegister.Instance))
            {
                panelProfessor.Controls.Add(ProfessorRegister.Instance);
                ProfessorRegister.Instance.Dock = DockStyle.Fill;
                ProfessorRegister.PanelnotThisProfessorRegister = panelProfessor;
                ProfessorRegister.Instance.BringToFront();

            }
            else
            {
                ProfessorRegister.Instance.Visible = true;
                ProfessorRegister.Instance.BringToFront();
            }
            panelProfessorOptions.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelProfessor.Visible = true;
            panelProfessorOptions.BringToFront();

            if (!panelProfessor.Controls.Contains(ProfessorSearch.Instance))
            {
                panelProfessor.Controls.Add(ProfessorSearch.Instance);
                ProfessorSearch.Instance.Dock = DockStyle.Fill;
                ProfessorSearch.PanelnotThisProfessorSearch = panelProfessor;
                ProfessorSearch.Instance.BringToFront();

            }
            else
            {
                ProfessorSearch.Instance.Visible = true;
                ProfessorSearch.Instance.BringToFront();
            }
            panelProfessorOptions.BringToFront();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void panelProfessor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
