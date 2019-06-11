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
    public partial class InterestedRegister : UserControl
    {
        private static InterestedRegister _instance;
        private static Panel _panelMdi;
        public static InterestedRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedRegister();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedRegister()
        {
            InitializeComponent();
        }

        private void InterestedRegister_Load(object sender, EventArgs e)
        {

        }

        private void DgvInterestedCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        public int verificarVacio()
        {
            int resultado = 0;
            if(txbApeMa.Text == "" &&
            txbApePa.Text == "" &&
            txbNDocumento.Text == "" &&
            txbNombre.Text == "" &&
            txbSegundoNom.Text == "" &&
            txtCellphone.Text == "" &&
            txtEmail.Text == "" &&
            txtEmailPUCP.Text == "" &&
            txtHomephone.Text == ""&&
            rbCarnet.Checked==false &&
            rbDNI.Checked==false &&
            rbPasaporte.Checked==false &&
            rbMale.Checked == false &&
            rbFemale.Checked==false &&
            dateNacimiento.Value==DateTime.Today &&
            dgvInterestedCourses.Rows.Count==0)
            {
                resultado = 1;
            }
            
            return resultado;
        }

        private void InterestedRegister_Leave(object sender, EventArgs e)
        {
            if (verificarVacio() == 0) {
                DialogResult result = MessageBox.Show("Está seguro de salir sin guardar los cambios?", "Aviso", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                }
            }
        }
        public void limpiar()
        {
            txbApeMa.Text = "";
            txbApePa.Text = "";
            txbNDocumento.Text = "";
            txbNombre.Text = "";
            txbSegundoNom.Text = "";
            txtCellphone.Text = "";
            txtEmail.Text = "";
            txtEmailPUCP.Text = "";
            txtHomephone.Text = "";
            rbCarnet.Checked = false;
            rbDNI.Checked = false;
            rbPasaporte.Checked = false;
        }
    }
}
