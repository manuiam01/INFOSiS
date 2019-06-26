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
    public partial class WorkforceRegister : UserControl
    {
        private static WorkforceRegister _instance;
        private static Panel _panelMdi;
        private Server.ServerClient servidor;
        private Server.intern intern;
        private Server.userType access;
        private bool birthdaySelected = false;


        public static WorkforceRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WorkforceRegister();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public WorkforceRegister()
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            rbDNI.Checked = true;
        }

        public bool verifyDocumentNumber(String id)
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
            intern.idPUCP = txtPUCPCode.Text;
            intern.address = txtAddress.Text;
            if (birthdaySelected)
            {
                intern.birthdaySpecified = true;
                intern.birthday = dtpBirthday.Value;
                birthdaySelected = false;
            }

            int res = servidor.InsertIntern(intern, access);

            if (res > 0)
            {
                MessageBox.Show("Registro exitoso", "Registro efectuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdaySelected = true;
        }
    }
}
