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
        private DAServer.ServerClient servidor;
        private static WorkforceRegister _instance;
        private static Panel _panelMdi;

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
            if (rbDNI.Checked)
            {
                if (txtDocumentNumber.Text.Count() != 8 ||
                   (txtDocumentNumber.Text.Count() == 8 && !verifyDocumentNumber(txtDocumentNumber.Text)))
                {
                    MessageBox.Show("Número de documento inválido", "Error en el registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
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
                servidor = new DAServer.ServerClient();
            }
        }
    }
}
