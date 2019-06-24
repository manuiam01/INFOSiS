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
    public partial class ProfessorRegister : UserControl
    {
        private static ProfessorRegister _instance;
        private static Panel _panelMdi;
        private Server.ServerClient servidor;
        private Server.professor professor;
        private bool birthdaySelected = false;

        public static ProfessorRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfessorRegister();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public ProfessorRegister()
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            rbDNI.Checked = true;
            txtDocumentNumber.MaxLength = 8;
 
        }

        private bool verifyDocumentNumber(String id)
        {
            for(int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i])) return false;
            }
            return true;
        }

        private void registerProfessor()
        {
            professor = new Server.professor();
            professor.idPUCP = txtPUCPCode.Text;
            professor.idNumber = txtDocumentNumber.Text;
            if (rbDNI.Checked)
                professor.idType = 0;
            else if(rbForeignCard.Checked)
                professor.idType = 1;
            else professor.idType=2;
            professor.email = txtEmail.Text;
            if (birthdaySelected)
            {
                professor.birthdaySpecified = true;
                professor.birthday = dtpBirthday.Value;
                birthdaySelected = false;
            }
            professor.firstName = txtFirstName.Text;
            professor.middleName = txtSecondName.Text;
            professor.primaryLastName = txtPrimaryLastName.Text;
            professor.secondLastName = txtSecondLastName.Text;
            professor.cellPhoneNumber = txtCellphone.Text;
            professor.emailPUCP = txtEmailPUCP.Text;
            if (rbWoman.Checked)
                professor.gender = "F";
            else if (rbMan.Checked)
                professor.gender = "M";
            int res = servidor.InsertProfessor(professor);
            if (res > 0)
            {
                MessageBox.Show("Registro exitoso", "Registro efectuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();
            }
            else if (res == -1)
            {
                MessageBox.Show("Documento de identidad registrado anteriormente", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (res == -2)
            {
                MessageBox.Show("Código PUCP registrado anteriormente", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            bool firstValidation = true;
            bool secondValidation = true;

            if(txtDocumentNumber.Text.Count() == 0 ||  txtFirstName.Text.Count() == 0 || txtPrimaryLastName.Text.Count() == 0 
               || txtSecondLastName.Text.Count() == 0 || txtPUCPCode.Text.Count() == 0 || txtEmailPUCP.Text.Count() == 0)
            {
                MessageBox.Show("Revisar los campos obligatorios", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                firstValidation = false; ;
            }
            if (firstValidation)
            {
                if (rbDNI.Checked)
                {
                    if (txtDocumentNumber.Text.Count() != 8 ||
                       (txtDocumentNumber.Text.Count() == 8 && !verifyDocumentNumber(txtDocumentNumber.Text)))
                    {
                        MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        secondValidation = false;
                    }
                }
                if (rbForeignCard.Checked || rbPassport.Checked)
                {
                    if (txtDocumentNumber.Text.Count() != 12)
                    {
                        MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        secondValidation = false;
                    }
                }

                if (txtPUCPCode.Text.Count() != 8)
                {
                    MessageBox.Show("Código PUCP inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    secondValidation = false;
                }

                if (!txtEmailPUCP.Text.Contains("@") || !txtEmailPUCP.Text.Contains("."))
                {
                    MessageBox.Show("Correo PUCP inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    secondValidation = false;
                }
                if (txtEmail.Text.Count() > 0 && (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".")))
                {
                        MessageBox.Show("Correo alternativo inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        secondValidation = false;
                }
                
                    
                if (secondValidation)
                {
                    registerProfessor();
                }
            }        

        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void clean()
        {
            txtCellphone.Clear();
            txtDocumentNumber.Clear();
            txtEmail.Clear();
            txtEmailPUCP.Clear();
            txtFirstName.Clear();
            txtPrimaryLastName.Clear();
            txtPUCPCode.Clear();
            txtSecondLastName.Clear();
            txtSecondName.Clear();
            rbDNI.Checked = true;
            rbForeignCard.Checked = false;
            rbPassport.Checked = false;
            rbMan.Checked = false;
            rbWoman.Checked = false;
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

        private void DtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdaySelected = true;
        }

        private void TxtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
