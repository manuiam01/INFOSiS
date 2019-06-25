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

namespace INFOSiS_2._0
{
    public partial class WorkforceModify : UserControl
    {
        private static WorkforceModify _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private Server.intern intern;
        private Server.userType access;
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
            intern = server.SearchInternByIdPUCP(txtPUCPCode.Text);
            if(intern.idNumber != null)
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
                setState(Estado.Buscar);
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
                setState(Estado.Buscar);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            setState(Estado.Actualizar);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
            setState(Estado.Inicial);
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
            access = new Server.userType();
            access.id = 0;
            access.name = "USER";

            intern = new Server.intern();
            access = new Server.userType();
            access.id = 0;
            access.name = "USER";

            if (rbDNI.Checked)
            {
                if (txtDocumentNumber.Text.Count() != 8 ||
                   (txtDocumentNumber.Text.Count() == 8 && !verifyDocumentNumber(txtDocumentNumber.Text)))
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
                if (txtDocumentNumber.Text.Count() != 12 ||
                   (txtDocumentNumber.Text.Count() == 12 && !verifyDocumentNumber(txtDocumentNumber.Text)))
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
            else if (!rbDNI.Checked && !rbForeignCard.Checked && !rbPassport.Checked)
            {
                MessageBox.Show("Escoge un tipo de documento", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPUCPCode.Text.Count() != 8)
            {
                MessageBox.Show("Código PUCP inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtEmailPUCP.Text.Contains("@") || !txtEmailPUCP.Text.Contains("."))
            {
                MessageBox.Show("Correo PUCP inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtEmail.Text.Count() > 0 && (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".")))
            {
                MessageBox.Show("Correo alternativo inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            //intern.idPUCP = txtPUCPCode.Text;
            intern.address = txtAddress.Text;
            if (birthdaySelected)
            {
                intern.birthdaySpecified = true;
                intern.birthday = dtpBirthday.Value;
                birthdaySelected = false;
            }

            int res = server.UpdateIntern(intern, access);

            if (res > 0)
            {
                MessageBox.Show("Registro exitoso", "Registro efectuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
            }
            else if (res == -1)
            {
                MessageBox.Show("Código PUCP registrado anteriormente", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (res == -2)
            {
                MessageBox.Show("Código PUCP es un campo obligatorio", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (res == -3)
            {
                MessageBox.Show("Número de identidad registrado anteriormente", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
