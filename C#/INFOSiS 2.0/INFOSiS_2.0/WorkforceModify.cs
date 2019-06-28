using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace INFOSiS_2._0
{
    public partial class WorkforceModify : UserControl
    {
        private static WorkforceModify _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private Server.intern intern;
        private bool birthdaySelected = false;

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
            setState(Estado.Inicial);
            server = new Server.ServerClient();
            txtFirstName.CharacterCasing = CharacterCasing.Upper;
            txtSecondName.CharacterCasing = CharacterCasing.Upper;
            txtPrimaryLastName.CharacterCasing = CharacterCasing.Upper;
            txtSecondLastName.CharacterCasing = CharacterCasing.Upper;
            txtPUCPCode.CharacterCasing = CharacterCasing.Upper;
            txtDocumentNumber.CharacterCasing = CharacterCasing.Upper;
        }

        public enum Estado
        {
            Inicial = 1,
            Buscar = 2,
            Actualizar = 3,
            Guardar = 4
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
                    txtAddress.Enabled = false;
                    txtHomephone.Enabled = false;
                    rbActive.Enabled = false;
                    rbInactive.Enabled = false;
                    rbDNI.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbPassport.Enabled = false;
                    dtpBirthday.Enabled = false;
                    btnSearch.Enabled = true;
                    btnCancel.Enabled = true;
                    btnModify.Enabled = false;
                    btnSave.Enabled = false;
                    lbAdvancedSearch.Enabled = true;
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
                    txtAddress.Enabled = false;
                    txtHomephone.Enabled = false;
                    rbActive.Enabled = false;
                    rbInactive.Enabled = false;
                    rbDNI.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbPassport.Enabled = false;
                    dtpBirthday.Enabled = false;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = false;
                    btnModify.Enabled = true;
                    lbAdvancedSearch.Enabled = true;
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
                    txtAddress.Enabled = true;
                    txtHomephone.Enabled = true;
                    rbActive.Enabled = true;
                    rbInactive.Enabled = true;
                    rbDNI.Enabled = true;
                    rbForeignCard.Enabled = true;
                    rbPassport.Enabled = true;
                    dtpBirthday.Enabled = true;
                    btnCancel.Enabled = true;
                    btnSearch.Enabled = false;
                    btnSave.Enabled = true;
                    btnModify.Enabled = false;
                    lbAdvancedSearch.Enabled = false;
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
                    txtAddress.Enabled = false;
                    txtHomephone.Enabled = false;
                    rbActive.Enabled = false;
                    rbInactive.Enabled = false;
                    rbDNI.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbPassport.Enabled = false;
                    dtpBirthday.Enabled = false;
                    btnSearch.Enabled = true;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = false;
                    btnModify.Enabled = false;
                    lbAdvancedSearch.Enabled = true;
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            server = new Server.ServerClient();
            intern = new Server.intern();
            if (txtPUCPCode.Text.Count() != 8)
            {
                MessageBox.Show("Código PUCP inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                intern = server.SearchInternByIdPUCP(txtPUCPCode.Text);
                if (intern.idNumber != null)
                {
                    txtPUCPCode.Enabled = false;
                    txtDocumentNumber.Text = intern.idNumber;
                    if (intern.idType == 0) rbDNI.Checked = true;
                    else if (intern.idType == 1) rbForeignCard.Checked = true;
                    else if (intern.idType == 2) rbPassport.Checked = true;
                    txtFirstName.Text = intern.firstName;
                    txtSecondName.Text = intern.middleName;
                    txtPrimaryLastName.Text = intern.primaryLastName;
                    txtSecondLastName.Text = intern.secondLastName;
                    if (intern.gender == "F") rbWoman.Checked = true;
                    else if (intern.gender == "M") rbMan.Checked = true;
                    txtCellphone.Text = intern.cellPhoneNumber;
                    txtHomephone.Text = intern.homePhone;
                    txtEmailPUCP.Text = intern.emailPUCP;
                    txtEmail.Text = intern.email;
                    txtPUCPCode.Text = intern.idPUCP;
                    txtAddress.Text = intern.address;
                    if (intern.user.isActive) rbActive.Checked = true;
                    else if (!intern.user.isActive) rbInactive.Checked = true;
                    if (intern.birthday.Date < dtpBirthday.MinDate) dtpBirthday.Value = dtpBirthday.MaxDate; //fecha nula
                    else dtpBirthday.Value = intern.birthday.Date;
                    setState(Estado.Buscar);
                }
                else
                {
                    MessageBox.Show("El código ingresado no pertenece a ningún practicante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            
        }

        private void lbAdvancedSearch_Click(object sender, EventArgs e)
        {
            WorkforceAdvancedSearch formSearchIntern = new WorkforceAdvancedSearch();
            if (formSearchIntern.ShowDialog() == DialogResult.OK)
            {
                intern = formSearchIntern.Intern;
                txtPUCPCode.Enabled = false;
                txtDocumentNumber.Text = intern.idNumber;
                if (intern.idType == 0) rbDNI.Checked = true;
                else if (intern.idType == 1) rbForeignCard.Checked = true;
                else if (intern.idType == 2) rbPassport.Checked = true;
                txtFirstName.Text = intern.firstName;
                txtSecondName.Text = intern.middleName;
                txtPrimaryLastName.Text = intern.primaryLastName;
                txtSecondLastName.Text = intern.secondLastName;
                if (intern.gender == "F") rbWoman.Checked = true;
                else if (intern.gender == "M") rbMan.Checked = true;
                txtCellphone.Text = intern.cellPhoneNumber;
                txtHomephone.Text = intern.homePhone;
                txtEmailPUCP.Text = intern.emailPUCP;
                txtEmail.Text = intern.email;
                txtPUCPCode.Text = intern.idPUCP;
                txtAddress.Text = intern.address;
                if (intern.user.isActive) rbActive.Checked = true;
                else if (!intern.user.isActive) rbInactive.Checked = true;
                if (intern.birthday.Date < dtpBirthday.MinDate) dtpBirthday.Value = dtpBirthday.MaxDate; //fecha nula
                else dtpBirthday.Value = intern.birthday.Date;
                setState(Estado.Buscar);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            setState(Estado.Actualizar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtDocumentNumber.Text.Count() != 0)
            {
                DialogResult result = MessageBox.Show("Está seguro de no guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    clean();
                    setState(Estado.Inicial);
                }
            }
            
            
        }

        private void clean()
        {
            txtAddress.Clear();
            txtCellphone.Clear();
            txtDocumentNumber.Clear();
            txtEmail.Clear();
            txtEmailPUCP.Clear();
            txtFirstName.Clear();
            txtHomephone.Clear();
            txtPrimaryLastName.Clear();
            txtPUCPCode.Clear();
            txtSecondLastName.Clear();
            txtSecondName.Clear();
            rbDNI.Checked = false;
            rbForeignCard.Checked = false;
            rbPassport.Checked = false;
            rbMan.Checked = false;
            rbWoman.Checked = false;
            rbActive.Checked = false;
            rbInactive.Checked = false;
        }

        private bool verifyDocumentNumber(String id)
        {
            for (int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i])) return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            intern = new Server.intern();

            if (txtDocumentNumber.Text.Equals("") || txtFirstName.Text.Equals("") ||
                txtPrimaryLastName.Text.Equals("") || txtDocumentNumber.Text.Equals("") ||
                txtEmailPUCP.Text.Equals(""))
            {
                MessageBox.Show("Revisar los campos obligatorios", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rbDNI.Checked)
            {
                if (txtDocumentNumber.Text.Count() != 8)
                {
                    MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    intern.idType = 0;
                }
            }
            else if (rbForeignCard.Checked || rbPassport.Checked)
            {
                if (txtDocumentNumber.Text.Count() != 12)
                {
                    MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (rbForeignCard.Checked) intern.idType = 1;
                    else if (rbPassport.Checked) intern.idType = 2;
                }
            }

            if (txtPUCPCode.Text.Count() != 8)
            {
                MessageBox.Show("Código PUCP inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(new EmailAddressAttribute().IsValid(txtEmailPUCP.Text)))
            {
                MessageBox.Show("Correo PUCP inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEmail.Text.Count() > 0 && (!(new EmailAddressAttribute().IsValid(txtEmail.Text))))
            {
                MessageBox.Show("Correo alternativo inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbMan.Checked == false && rbWoman.Checked == false)
            {
                MessageBox.Show("No eligió el genero", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            intern.idPUCP = txtPUCPCode.Text;
            intern.idNumber = txtDocumentNumber.Text;
            intern.firstName = txtFirstName.Text;
            intern.middleName = txtSecondName.Text;
            intern.primaryLastName = txtPrimaryLastName.Text;
            intern.secondLastName = txtSecondLastName.Text;
            if (rbWoman.Checked) intern.gender = "F";
            else if (rbMan.Checked) intern.gender = "M";
            intern.cellPhoneNumber = txtCellphone.Text;
            intern.homePhone = txtHomephone.Text;
            intern.emailPUCP = txtEmailPUCP.Text;
            intern.email = txtEmail.Text;
            intern.address = txtAddress.Text;
            intern.weekAvailability = "";
            if (birthdaySelected)
            {
                intern.birthdaySpecified = true;
                intern.birthday = dtpBirthday.Value;
                birthdaySelected = false;
            }

            int res = server.UpdateIntern(intern);

            if (res > 0)
            {
                MessageBox.Show("Actualización exitosa", "Actualización efectuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
                setState(Estado.Inicial);
            }            
            else
            {
                MessageBox.Show(res.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdaySelected = true;
        }

        private void txtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDocumentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbDNI.Checked)
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void rbDNI_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDocumentNumber.Text = "";
            txtDocumentNumber.MaxLength = 8;
        }

        private void rbForeignCard_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDocumentNumber.Text = "";
            txtDocumentNumber.MaxLength = 12;
        }

        private void rbPassport_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDocumentNumber.Text = "";
            txtDocumentNumber.MaxLength = 12;
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
