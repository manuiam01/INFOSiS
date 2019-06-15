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
    public partial class WorkforceModify : UserControl
    {
        private static WorkforceModify _instance;
        private static Panel _panelMdi;

        public static WorkforceModify Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WorkforceModify();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public WorkforceModify()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void lbBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            WorkforceAdvancedSearch formSearchIntern = new WorkforceAdvancedSearch();
            if (formSearchIntern.ShowDialog() == DialogResult.OK)
            {
                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInterestedCourses.DataSource = formBuscarCursosInteresado.}
            }
        }
    }
}
