using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace INFOSiS_2._0
{
    public partial class ProfessorModify : UserControl
    {

        private static ProfessorModify _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private Server.professor professor;
        private bool birthdaySelected = false;
        private String previousId;

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
            setState(Estado.Inicial);
            server = new Server.ServerClient();
            txtDocumentNumber.CharacterCasing = CharacterCasing.Upper;
            txtFirstName.CharacterCasing = CharacterCasing.Upper;
            txtSecondName.CharacterCasing = CharacterCasing.Upper;
            txtPrimaryLastName.CharacterCasing = CharacterCasing.Upper;
            txtSecondLastName.CharacterCasing = CharacterCasing.Upper;
        }
        public void setState(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    txtDocumentNumber.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtSecondName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    txtSecondLastName.Enabled = false;
                    rbWoman.Enabled = false;
                    rbMan.Enabled = false;                    
                    txtCellphone.Enabled = false;
                    txtEmailPUCP.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPUCPCode.Enabled = true;
                    rbActive.Enabled = false;
                    rbInactive.Enabled = false;
                    rbDNI.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbPassport.Enabled = false;
                    dtpBirthday.Enabled = false;
                    btnSearch.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnSaveChanges.Enabled = false;
                    lblAdvancedSearch.Enabled = true;
                    break;
                case Estado.Buscar:
                    txtDocumentNumber.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtSecondName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    txtSecondLastName.Enabled = false;
                    rbWoman.Enabled = false;
                    rbMan.Enabled = false;
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
                    btnSearch.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSaveChanges.Enabled = false;
                    btnModificar.Enabled = true;
                    lblAdvancedSearch.Enabled = true;
                    break;
                case Estado.Actualizar:
                    txtDocumentNumber.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtSecondName.Enabled = true;
                    txtPrimaryLastName.Enabled = true;
                    txtSecondLastName.Enabled = true;
                    rbWoman.Enabled = true;
                    rbMan.Enabled = true;                    
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
                    btnCancelar.Enabled = true;
                    btnSearch.Enabled = false;
                    btnSaveChanges.Enabled = true;
                    btnModificar.Enabled = false;
                    lblAdvancedSearch.Enabled = false;
                    break;
                case Estado.Guardar:
                    txtDocumentNumber.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtSecondName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    txtSecondLastName.Enabled = false;
                    rbWoman.Enabled = false;
                    rbMan.Enabled = false;
                    txtCellphone.Enabled = false;
                    txtEmailPUCP.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPUCPCode.Enabled = true;
                    rbActive.Enabled = false;
                    rbInactive.Enabled = false;
                    rbDNI.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbPassport.Enabled = false;
                    dtpBirthday.Enabled = false;
                    btnSearch.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSaveChanges.Enabled = false;
                    btnModificar.Enabled = false;
                    lblAdvancedSearch.Enabled = true;
                    break;
            }
        }

        public enum Estado
        {
            Inicial = 1,
            Buscar = 2,
            Actualizar = 3,
            Guardar = 4
        }

        private void lblAdvancedSearch_Click(object sender, EventArgs e)
        {
            ProfessorAdvancedSearch formSearchProfessor = new ProfessorAdvancedSearch();
            if (formSearchProfessor.ShowDialog() == DialogResult.OK)
            {
                professor = formSearchProfessor.Professor;
                txtPUCPCode.Text = professor.idPUCP;
                txtDocumentNumber.Text = professor.idNumber;
                previousId = txtDocumentNumber.Text;
                txtFirstName.Text = professor.firstName;
                txtSecondName.Text = professor.middleName;
                txtPrimaryLastName.Text = professor.primaryLastName;
                txtSecondLastName.Text = professor.secondLastName;
                txtEmailPUCP.Text = professor.emailPUCP;
                txtEmail.Text = professor.email;
                txtCellphone.Text = professor.cellPhoneNumber;
                if (professor.idType == 0) rbDNI.Checked = true;
                else if (professor.idType == 1) rbForeignCard.Checked = true;
                else if (professor.idType == 2) rbPassport.Checked = true;
                if (professor.gender == "F") rbWoman.Checked = true;
                else if (professor.gender == "M") rbMan.Checked = true;
                if (professor.isActive) rbActive.Checked = true;
                else if (!professor.isActive) rbInactive.Checked = true;
                if (professor.birthday.Date < dtpBirthday.MinDate) dtpBirthday.Value = dtpBirthday.MaxDate; //fecha nula
                else dtpBirthday.Value = professor.birthday.Date;
                setState(Estado.Buscar);

            }
        }

        private void setProfessor()
        {            
            professor = new Server.professor();
            professor.idPUCP = txtPUCPCode.Text;
            professor.idNumber = txtDocumentNumber.Text;
            professor.firstName = txtFirstName.Text;
            professor.middleName = txtSecondName.Text;
            professor.primaryLastName = txtPrimaryLastName.Text;
            professor.secondLastName = txtSecondLastName.Text;
            professor.email = txtEmail.Text;
            professor.emailPUCP = txtEmailPUCP.Text;
            if (birthdaySelected)
            {
                professor.birthdaySpecified = true;
                professor.birthday = dtpBirthday.Value;
                birthdaySelected = false;
            }
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
        }
        private bool verifyDocumentNumber(String id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i])) return false;
            }
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            setState(Estado.Actualizar);        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clean();
            setState(Estado.Inicial);
        }

        public void clean()
        {            
            txtFirstName.Clear();
            txtSecondName.Clear();
            txtPrimaryLastName.Clear();
            txtSecondLastName.Clear();
            rbWoman.Checked = false;
            rbMan.Checked = false;
            btnCancelar.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnModificar.Enabled = false;
            txtCellphone.Clear();
            txtEmailPUCP.Clear();
            txtEmail.Clear();
            txtPUCPCode.Clear();
            txtDocumentNumber.Clear();
            dtpBirthday.Value = dtpBirthday.MaxDate;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            professor = new Server.professor();
            professor = server.SearchProfessorByIdPUCP(txtPUCPCode.Text);
            if (professor.idPUCP != null)
            {
                txtPUCPCode.Text = professor.idPUCP;
                txtDocumentNumber.Text = professor.idNumber;
                previousId = txtDocumentNumber.Text;
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
                if (professor.birthday.Date < dtpBirthday.MinDate) dtpBirthday.Value = dtpBirthday.MaxDate; //fecha nula
                else dtpBirthday.Value = professor.birthday.Date;
                setState(Estado.Buscar);
            }
            else
            {
                MessageBox.Show("Código PUCP no encontrado", "Profesor no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPUCPCode.Clear();
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            bool firstValidation = true;
            bool secondValidation = true;

            if (txtDocumentNumber.Text.Count() == 0 || txtFirstName.Text.Count() == 0 || txtPrimaryLastName.Text.Count() == 0
               || txtSecondLastName.Text.Count() == 0 || txtEmailPUCP.Text.Count() == 0)
            {
                MessageBox.Show("Revisar los campos obligatorios", "Actualización inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                firstValidation = false; ;
            }
            if (firstValidation)
            {
                if (rbDNI.Checked)
                {
                    if (txtDocumentNumber.Text.Count() != 8 )
                    {
                        MessageBox.Show("Número de documento inválido", "Error en la actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        secondValidation = false;
                    }
                }
                else
                {
                    if (txtDocumentNumber.Text.Count() != 12)
                    {
                        MessageBox.Show("Número de documento inválido", "Error en la actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        secondValidation = false;
                    }
                }

                if (!(new EmailAddressAttribute().IsValid(txtEmailPUCP.Text)))
                {
                    MessageBox.Show("Correo PUCP inválido", "Error en la actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    secondValidation = false;
                }
                else if (txtEmail.Text.Count() > 0 && (!(new EmailAddressAttribute().IsValid(txtEmail.Text))))
                {
                    MessageBox.Show("Correo alternativo inválido", "Error en la actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    secondValidation = false;
                }

                else if(secondValidation)
                {
                    setProfessor();
                }
            }

            if ((server.SearchProfessorById(txtDocumentNumber.Text) == 1) && (previousId != txtDocumentNumber.Text)){
                MessageBox.Show("Documento de identidad registrado anteriormente", "Actualización inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (firstValidation==true && secondValidation==true)
            {
                int res = server.UpdateProfessor(professor);
                if (res > 0)
                {
                    MessageBox.Show("Profesor actualizado correctamente", "Profesor actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();
                    setState(Estado.Guardar);
                }
            }


        }

        private void DtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdaySelected = true;
        }

        private void RbDNI_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumentNumber.MaxLength = 8;
        }

        private void RbForeignCard_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumentNumber.MaxLength = 12;
        }

        private void RbPassport_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumentNumber.MaxLength = 12;
        }

        private void TxtDocumentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbDNI.Checked)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPrimaryLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtSecondLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
