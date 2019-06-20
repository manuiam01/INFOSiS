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
        }

        public bool verifyDocumentNumber(String id)
        {
            for(int i = 0; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i])) return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e) { 
            
            professor = new Server.professor();

            if (rbDNI.Checked)
            {
                if (txtDocumentNumber.Text.Count() != 8 ||
                   (txtDocumentNumber.Text.Count() == 8 && !verifyDocumentNumber(txtDocumentNumber.Text)))
                {
                    MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    professor.idPUCP = txtPUCPCode.Text;
                    professor.idNumber = txtDocumentNumber.Text;
                    professor.idType = 0;
                    professor.email = txtEmail.Text;
                    professor.birthDate = dtpBirthday.Value.Date;
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
                    }else if (res < 0)
                    {
                        MessageBox.Show("Código PUCP registrado anteriormente", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (rbForeignCard.Checked || rbPassport.Checked)
            {
                if (txtDocumentNumber.Text.Count() != 12 ||
                   (txtDocumentNumber.Text.Count() == 12 && !verifyDocumentNumber(txtDocumentNumber.Text)))
                {
                    MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    professor.idPUCP = txtPUCPCode.Text;
                    professor.idNumber = txtDocumentNumber.Text;
                    if (rbForeignCard.Checked)
                        professor.idType = 1;
                    else if (rbPassport.Checked)
                        professor.idType = 2;
                    professor.email = txtEmail.Text;
                    professor.birthDate = dtpBirthday.Value.Date;
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
                        MessageBox.Show("Código PUCP registrado anteriormente", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if(res == -2)
                    {
                        MessageBox.Show("Código PUCP es un campo obligatorio", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if(res == -3)
                    {
                        MessageBox.Show("Número de identidad registrado anteriormente", "Registro inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clean();
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
            rbInactive.Checked = false;
            rbActive.Checked = false;
            rbMan.Checked = false;
            rbWoman.Checked = false;
        }
    }
}
