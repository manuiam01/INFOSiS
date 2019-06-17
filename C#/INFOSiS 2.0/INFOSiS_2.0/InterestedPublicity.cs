using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiS_2._0
{
    public partial class InterestedPublicity : UserControl
    {
        private static InterestedPublicity _instance;
        private static Panel _panelMdi;
        public static InterestedPublicity Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedPublicity();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedPublicity()
        {
            InitializeComponent();
            dtpInicioCurso.MinDate = DateTime.Now;
            //limpiar();
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            InterestedCourseMailing formBuscarCursosInteresado = new InterestedCourseMailing();
            if (formBuscarCursosInteresado.ShowDialog() == DialogResult.OK)
            {
                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInteresadosMailing.DataSource = formBuscarCursosInteresado}
            }
        }

        private void LblEditarMail_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LblEditarMail_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
