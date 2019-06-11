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
    public partial class InterestedModified : UserControl
    {
        private static InterestedModified _instance;
        private static Panel _panelMdi;

        public static InterestedModified Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedModified();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedModified()
        {
            InitializeComponent();

        }
        public void establecerEstado(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:

                    break;
            }

        private void InterestedSearch_Load(object sender, EventArgs e)
        {

        }

        private void BtBuscarCursos_Click(object sender, EventArgs e)
        {
            InterestedCourses formBuscarCursosInteresado = new InterestedCourses();
            if (formBuscarCursosInteresado.ShowDialog() == DialogResult.OK)
            {
                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInterestedCourses.DataSource = formBuscarCursosInteresado.}
            }
        }
        public enum Estado
        {
            Inicial = 0,
            Nuevo = 1,
            Guardar = 2,
            Actualizar = 3,
            Eliminar = 4
        }
    }
}
