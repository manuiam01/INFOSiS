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
    public partial class ProfessorModify : UserControl
    {

        private static ProfessorModify _instance;
        private static Panel _panelMdi;

        public static ProfessorModify Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfessorModify();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public ProfessorModify()
        {            
            InitializeComponent();
            establecerEstado(Estado.Inicial);
        }
        public void establecerEstado(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    txtDocumentNumber.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtSecondName.Enabled = true;
                    txtPrimaryLastName.Enabled = true;
                    txtSecondLastName.Enabled = true;
                    rbWoman.Enabled = true;
                    rbMan.Enabled = true;
                    btCancelar.Enabled = true;
                    btModificar.Enabled = true;
                    txtCellphone.Enabled = true;
                    txtHomephone.Enabled = true;
                    txtEmailPUCP.Enabled = true;
                    txtEmail.Enabled = true;
                    txtPUCPCode.Enabled = true;
                    txtAddress.Enabled = true;
                    break;

                case Estado.Actualizar:
                    txtDocumentNumber.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtSecondName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    txtSecondLastName.Enabled = false;
                    rbWoman.Enabled = false;
                    rbMan.Enabled = false;
                    btCancelar.Enabled = false;
                    btModificar.Enabled = false;
                    txtCellphone.Enabled = false;
                    txtHomephone.Enabled = false;
                    txtEmailPUCP.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPUCPCode.Enabled = false;
                    txtAddress.Enabled = false;
                    break;
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ProfessorRegister.Instance.BringToFront();
        }

        private void lbBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            ProfessorAdvancedSearch formSearchProfessor = new ProfessorAdvancedSearch();
            if (formSearchProfessor.ShowDialog() == DialogResult.OK)
            {
               
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            establecerEstado(Estado.Actualizar);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtPrimaryLastName.Clear();
            txtSecondLastName.Clear();
            rbWoman.Checked = false;
            rbMan.Checked = false;
            btCancelar.Enabled = true;
            btModificar.Enabled = true;
            txtCellphone.Clear();
            txtHomephone.Clear();
            txtEmailPUCP.Clear();
            txtEmail.Clear();
            txtPUCPCode.Clear();
            txtAddress.Clear();
        }
    }
}
