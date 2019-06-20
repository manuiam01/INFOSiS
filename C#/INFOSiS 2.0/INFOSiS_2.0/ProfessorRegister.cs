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
        private DAServer.ServerClient servidor;
        private DAServer.professor professor;

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
            servidor = new DAServer.ServerClient();
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
            
            professor = new DAServer.professor();
            if (rbDNI.Checked)
            {
                if (txtDocumentNumber.Text.Count() != 8 || 
                   (txtDocumentNumber.Text.Count() == 8 && !verifyDocumentNumber(txtDocumentNumber.Text)))
                {
                    MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    professor.idNumber = txtDocumentNumber.Text;
                    professor.idType = 0;
                    professor.firstName = txtFirstName.Text;
                    professor.middleName = txtSecondName.Text;
                    professor.primaryLastName = txtPrimaryLastName.Text;
                    professor.secondLastName = txtSecondLastName.Text;
                    professor.birthDate = dtpBirthday.Value;
                    professor.cellPhoneNumber = txtCellphone.Text;
                    professor.email = txtEmail.Text;
                    professor.emailPUCP = txtEmailPUCP.Text;
                    professor.idPUCP = txtPUCPCode.Text;
                    if (rbWoman.Checked)
                        professor.gender = "F";
                    else if (rbMan.Checked)
                        professor.gender = "M";
                    int res = servidor.InsertProfessor(professor);
                    MessageBox.Show("Registro exitoso", "Registro efectuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Registro exitoso", "Registro efectuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de documento", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        
        
    }
}
