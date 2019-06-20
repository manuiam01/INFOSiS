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
        private Server.ServerClient server;
        private Server.professor professor;

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
                    btnModificar.Enabled = true;
                    txtCellphone.Enabled = true;
                    txtEmailPUCP.Enabled = true;
                    txtEmail.Enabled = true;
                    txtPUCPCode.Enabled = true;
                    rbActive.Enabled = true;
                    rbInactive.Enabled = true;
                    rbDNI.Enabled = true;
                    rbForeignCard.Enabled = true;
                    rbPassport.Enabled = true;
                    dtpBirthday.Enabled = true;
                    break;

                case Estado.Buscar:
                    txtDocumentNumber.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtSecondName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    txtSecondLastName.Enabled = false;
                    rbWoman.Enabled = false;
                    rbMan.Enabled = false;
                    btCancelar.Enabled = false;
                    btnModificar.Enabled = true;
                    txtCellphone.Enabled = false;
                    txtEmailPUCP.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPUCPCode.Enabled = false;
                    rbActive.Enabled = false;
                    rbInactive.Enabled = false;
                    rbDNI.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbPassport.Enabled = false;
                    dtpBirthday.Enabled = false;
                    break;
                case Estado.Actualizar:
                    txtDocumentNumber.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtSecondName.Enabled = true;
                    txtPrimaryLastName.Enabled = true;
                    txtSecondLastName.Enabled = true;
                    rbWoman.Enabled = true;
                    rbMan.Enabled = true;
                    btCancelar.Enabled = true;
                    btnSearch.Enabled = false;
                    txtCellphone.Enabled = true;
                    txtEmailPUCP.Enabled = true;
                    txtEmail.Enabled = true;
                    txtPUCPCode.Enabled = false;
                    rbActive.Enabled = true;
                    rbInactive.Enabled = true;
                    rbDNI.Enabled = true;
                    rbForeignCard.Enabled = true;
                    rbPassport.Enabled = true;
                    dtpBirthday.Enabled = true;
                    break;
            }
        }

        public enum Estado
        {
            Inicial = 0,
            Nuevo = 1,
            Guardar = 2,
            Buscar = 3,
            Actualizar = 4
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
            server = new Server.ServerClient();
            professor = new Server.professor();
            professor.idPUCP = txtPUCPCode.Text;
            professor.idNumber = txtDocumentNumber.Text;
            professor.firstName = txtFirstName.Text;
            professor.middleName = txtSecondName.Text;
            professor.primaryLastName = txtPrimaryLastName.Text;
            professor.secondLastName = txtSecondLastName.Text;
            professor.email = txtEmail.Text;
            professor.emailPUCP = txtEmailPUCP.Text;
            professor.birthday = dtpBirthday.Value;
            if (rbMan.Checked)
                professor.gender = "M";
            else if (rbWoman.Checked)
                professor.gender = "F";
            if (rbActive.Checked)
                professor.isActive = true;
            else if (rbInactive.Checked)
                professor.isActive = false;
            if (rbDNI.Checked)
                professor.idType = 0;
            else if (rbForeignCard.Checked)
                professor.idType = 1;
            else if (rbPassport.Checked)
                professor.idType = 2;
            professor.cellPhoneNumber = txtCellphone.Text;

            int res = server.UpdateProfessor(professor);
            if (res > 0)
            {
                MessageBox.Show("Profesor actualizado correctamente", "Profesor actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            btnModificar.Enabled = true;
            txtCellphone.Clear();
            txtEmailPUCP.Clear();
            txtEmail.Clear();
            txtPUCPCode.Clear();
            txtDocumentNumber.Clear();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            professor = new Server.professor();
            professor = server.SearchProfessorById(txtPUCPCode.Text);
            if (professor.idPUCP != null)
            {
                txtPUCPCode.Text = professor.idPUCP;
                txtDocumentNumber.Text = professor.idNumber;
                txtFirstName.Text = professor.firstName;
                txtSecondName.Text = professor.middleName;
                txtPrimaryLastName.Text = professor.primaryLastName;
                txtSecondLastName.Text = professor.secondLastName;
                txtCellphone.Text = professor.cellPhoneNumber;
                txtEmail.Text = professor.email;
                txtEmailPUCP.Text = professor.emailPUCP;
                if (professor.gender == "M") rbMan.Checked = true;
                else if (professor.gender == "F") rbWoman.Checked = true;
                if (professor.idType == 0) rbDNI.Checked = true;
                else if (professor.idType == 1) rbForeignCard.Checked = true;
                else if (professor.idType == 2) rbPassport.Checked = true;
                if (professor.isActive) rbActive.Checked = true;
                else if (!professor.isActive) rbInactive.Checked = true;
                establecerEstado(Estado.Buscar);
            }
            else
            {
                MessageBox.Show("Código PUCP no encontrado", "Profesor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
