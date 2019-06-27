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
            txtDocumentNumber.MaxLength= 8;
            txtFirstName.CharacterCasing = CharacterCasing.Upper;
            txtSecondName.CharacterCasing = CharacterCasing.Upper;
            txtPrimaryLastName.CharacterCasing = CharacterCasing.Upper;
            txtSecondLastName.CharacterCasing = CharacterCasing.Upper;
            txtPUCPCode.CharacterCasing = CharacterCasing.Upper;
            txtDocumentNumber.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            intern = new Server.intern();
            access = new Server.userType();
            access.id = 0;
            access.name = "USER";

            if (txtDocumentNumber.Text.Equals("") || txtFirstName.Text.Equals("") ||
                txtPrimaryLastName.Text.Equals("") || txtDocumentNumber.Text.Equals("") ||
                txtEmailPUCP.Text.Equals("") )
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
            if(rbMan.Checked == false && rbWoman.Checked == false)
            {
                MessageBox.Show("No eligió el sexo", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int res = 0;
            DialogResult result = MessageBox.Show("Está seguro de que quiere guardar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                res = servidor.InsertIntern(intern, access);
            }
            

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
            txtDocumentNumber.MaxLength=8;
            rbDNI.Checked = true;
            rbForeignCard.Checked = false;
            rbPassport.Checked = false;
            rbMan.Checked = false;
            rbWoman.Checked = false;
        }
        public int verificarVacio()
        {
            int resultado = 1;
            //falta verificar el dateNacimiento.Value != DateTime.Today ||, pero no sé como hacerlo uwur
            if (txtSecondName.Text != "" ||
            txtPrimaryLastName.Text != "" ||
            txtDocumentNumber.Text != "" ||
            txtFirstName.Text != "" ||
            txtSecondLastName.Text != "" ||
            txtCellphone.Text != "" ||
            txtEmail.Text != "" ||
            txtEmailPUCP.Text != "" ||
            txtHomephone.Text != "" ||
            txtPUCPCode.Text!= "" ||
            txtAddress.Text!= ""
            )
            {
                resultado = 0;
            }

            return resultado;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (verificarVacio() == 0)
            {
                DialogResult result = MessageBox.Show("Está seguro de salir sin guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    clean();
                }
            }
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdaySelected = true;
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

        private void txtDocumentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(rbDNI.Checked==true)
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
        }

        private void txtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtHomephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void rbDNI_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumentNumber.Text = "";
            txtDocumentNumber.MaxLength=8;
        }

        private void rbForeignCard_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumentNumber.Text = "";
            txtDocumentNumber.MaxLength=12;
        }

        private void rbPassport_CheckedChanged(object sender, EventArgs e)
        {
            txtDocumentNumber.Text = "";
            txtDocumentNumber.MaxLength = 12; 
        }
    }
}
