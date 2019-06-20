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
        private Server.ServerClient servidor;
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
            servidor = new Server.ServerClient();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //BindingList<Server.intern> interns = new BindingList<Server.intern>();
            Server.intern[] interns = new Server.intern[100];
            interns = servidor.QueryAllInterns();
            BindingList<Server.intern> interns_cs = new BindingList<Server.intern>(interns);



            //ArrayList interns = new ArrayList();
            //interns = servidor.QueryAllInterns();
            /*
            for (int i = 0; i < interns.Length - 1; i++)
            {
                if (string.Compare(interns[i].idNumber, txtDocumentNumber.Text) == 0)
                {
                    txtDocumentNumber.Enabled = false;
                    txtFirstName.Text = interns[i].firstName;
                    txtSecondName.Text = interns[i].middleName;
                    txtPrimaryLastName.Text = interns[i].primaryLastName;
                    txtSecondLastName.Text = interns[i].secondLastName;
                    if (interns[i].gender == "F") rbWoman.Checked = true;
                    else if (interns[i].gender == "M") rbMan.Checked = true;
                    txtCellphone.Text = interns[i].cellPhoneNumber;
                    txtHomephone.Text = interns[i].homePhone;
                    txtEmailPUCP.Text = interns[i].emailPUCP;
                    txtEmail.Text = interns[i].email;
                    txtPUCPCode.Text = interns[i].idPUCP;
                    txtAddress.Text = interns[i].address;
                    if (interns[i].user.isActive) rbActive.Checked = true;
                    else if (interns[i].user.isActive) rbInactive.Checked = true;

                    btnModify.Enabled = true;
                    break;
                }
            }*/

            foreach (Server.intern i in interns)
            {
                if (string.Compare(i.idNumber, txtDocumentNumber.Text) == 0)
                {
                    txtDocumentNumber.Enabled = false;
                    txtFirstName.Text = i.firstName;
                    txtSecondName.Text = i.middleName;
                    txtPrimaryLastName.Text = i.primaryLastName;
                    txtSecondLastName.Text = i.secondLastName;
                    if (i.gender == "F") rbWoman.Checked = true;
                    else if (i.gender == "M") rbMan.Checked = true;
                    txtCellphone.Text = i.cellPhoneNumber;
                    txtHomephone.Text = i.homePhone;
                    txtEmailPUCP.Text = i.emailPUCP;
                    txtEmail.Text = i.email;
                    txtPUCPCode.Text = i.idPUCP;
                    txtAddress.Text = i.address;
                    if (i.user.isActive) rbActive.Checked = true;
                    else if (i.user.isActive) rbInactive.Checked = true;

                    btnModify.Enabled = true;
                    break;
                }
            }

            intern = new Server.intern();


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
