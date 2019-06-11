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
                    btModificar.Enabled = false;
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
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (rbCarnet.Checked == false && rbDNI.Checked == false && rbPasaporte.Checked == false)
            {
                MessageBox.Show("No escogió el tipo de documento a ingresar", "Aviso", MessageBoxButtons.OK);
            }
            else if (txbNDocumento.Text == "")
                MessageBox.Show("No ingresó el N° de documento", "Aviso", MessageBoxButtons.OK);
            
            else
            {
                establecerEstado(Estado.Actualizar);
            }
            
        }

        private void BtnSave_Leave(object sender, EventArgs e)
        {

        }

        private void InterestedModified_Leave(object sender, EventArgs e)
        {
            if (txbNDocumento.Enabled == false)
            {
                DialogResult result = MessageBox.Show("Está seguro de salir sin guardar los cambios?", "Aviso", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                    establecerEstado(Estado.Inicial);
                }
            }
        }

        private void BtModificar_EnabledChanged(object sender, EventArgs e)
        {
            //btModificar.ForeColor = sender == false ? Color.Blue : Color.Red;
            //btModificar.BackColor = Color.AliceBlue;
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text == "")
                MessageBox.Show("No ingresó el nombre del interesado", "Aviso", MessageBoxButtons.OK);
            else if (txbApePa.Text == "")
                MessageBox.Show("No ingresó el apelldio paterno del interesado", "Aviso", MessageBoxButtons.OK);
            else if (txbApeMa.Text == "")
                MessageBox.Show("No ingresó el apellido materno", "Aviso", MessageBoxButtons.OK);
            else if (txtEmail.Text == "" || txtEmailPUCP.Text == "")
                MessageBox.Show("No ingresó el coreo del interesado", "Aviso", MessageBoxButtons.OK);
            else if (txtCellphone.Text == "" || txtHomephone.Text == "")
                MessageBox.Show("No ingresó el número del interesado", "Aviso", MessageBoxButtons.OK);
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de que quiere cancelar la modificación?", "Aviso", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                limpiar();
                establecerEstado(Estado.Inicial);
            }
        }
    }
}
