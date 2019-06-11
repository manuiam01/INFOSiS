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
            establecerEstado(Estado.Inicial);

        }
        public void establecerEstado(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    txbNombre.Enabled = false;
                    txbApePa.Enabled = false;
                    txbSegundoNom.Enabled = false;
                    txbApeMa.Enabled = false;
                    txtCellphone.Enabled = false;
                    txtEmail.Enabled = false;
                    txtEmailPUCP.Enabled = false;
                    txtHomephone.Enabled = false;
                    btCancelar.Enabled = false;
                    btModificar.Enabled = false;
                    btBuscarCursos.Enabled = false;
                    txbNDocumento.Enabled = true;
                    rbCarnet.Enabled = true;
                    rbDNI.Enabled = true;
                    rbPasaporte.Enabled = true;
                    break;

                case Estado.Actualizar:
                    txbNombre.Enabled = true;
                    txbApePa.Enabled = true;
                    txbSegundoNom.Enabled = true;
                    txbApeMa.Enabled = true;
                    txtCellphone.Enabled = true;
                    txtEmail.Enabled = true;
                    txtEmailPUCP.Enabled = true;
                    txtHomephone.Enabled = true;
                    btCancelar.Enabled = true;
                    btModificar.Enabled = true;
                    btBuscarCursos.Enabled = true;
                    txbNDocumento.Enabled = false;
                    rbCarnet.Enabled = false;
                    rbDNI.Enabled = false;
                    rbPasaporte.Enabled = false;
                    break;
            }
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            establecerEstado(Estado.Actualizar);
        }
    }
}
