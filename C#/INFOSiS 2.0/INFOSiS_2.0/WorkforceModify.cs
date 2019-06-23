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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            server = new Server.ServerClient();
            intern = new Server.intern();
            intern = server.SearchInternByIdNumber(txtDocumentNumber.Text);
            if(intern.idNumber != null)
            {
                txtDocumentNumber.Enabled = false;
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
                else if (intern.user.isActive) rbInactive.Checked = true;

                btnModify.Enabled = true;
            }
        }

        private void lbBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            WorkforceAdvancedSearch formSearchIntern = new WorkforceAdvancedSearch();
            if (formSearchIntern.ShowDialog() == DialogResult.OK)
            {
                //Acá en teoría debería de devolver todo el ArrayList de practicantes para ingresarlo al dgv
                //dgvInterestedCourses.DataSource = formBuscarCursosInteresado.
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            intern = new Server.intern();
            access = new Server.userType();
            access.id = 0;
            access.name = "USER";
        }
    }
}
