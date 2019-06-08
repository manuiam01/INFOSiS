using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiSView
{
    public partial class frmStudentManager : Form
    {
        public frmStudentManager()
        {
            InitializeComponent();
            txtAddress.Enabled = false;
            txtCellphone.Enabled = false;
            txtDocument.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtHomePhone.Enabled = false;
            txtMiddleName.Enabled = false;
            txtPrimaryLastName.Enabled = false;
            txtPucpCode.Enabled = false;
            txtSecondLastName.Enabled = false;
            rbDni.Enabled = false;
            rbForeignCard.Enabled = false;
            rbMan.Enabled = false;
            rbPassport.Enabled = false;
            rbWoman.Enabled = false;
            dtpBirthday.Enabled = false;
        }

        void ComponentsState(State state)
        {
            switch (state)
            {
                case State.New:
                    txtAddress.Enabled = true;
                    txtCellphone.Enabled = true;
                    txtDocument.Enabled = true;
                    txtEmail.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtHomePhone.Enabled = true;
                    txtMiddleName.Enabled = true;
                    txtPrimaryLastName.Enabled = true;
                    txtPucpCode.Enabled = true;
                    txtSecondLastName.Enabled = true;
                    rbDni.Enabled = true;
                    rbForeignCard.Enabled = true;
                    rbMan.Enabled = true;
                    rbPassport.Enabled = true;
                    rbWoman.Enabled = true;
                    dtpBirthday.Enabled = true;
                    break;
                case State.Modify:
                    txtAddress.Enabled = false;
                    txtCellphone.Enabled = false;
                    txtDocument.Enabled = false;
                    txtEmail.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtHomePhone.Enabled = false;
                    txtMiddleName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    txtPucpCode.Enabled = true;
                    txtSecondLastName.Enabled = false;
                    rbDni.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbMan.Enabled = false;
                    rbPassport.Enabled = false;
                    rbWoman.Enabled = false;
                    dtpBirthday.Enabled = false;
                    break;
                case State.Save:
                    txtAddress.Enabled = false;
                    txtCellphone.Enabled = false;
                    txtDocument.Enabled = false;
                    txtEmail.Enabled = false;
                    txtFirstName.Enabled = false;
                    txtHomePhone.Enabled = false;
                    txtMiddleName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    txtPucpCode.Enabled = true;
                    txtSecondLastName.Enabled = false;
                    rbDni.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbMan.Enabled = false;
                    rbPassport.Enabled = false;
                    rbWoman.Enabled = false;
                    dtpBirthday.Enabled = false;
                    break;
                case State.Cancel:
                    txtAddress.Clear();
                    txtCellphone.Clear();
                    txtDocument.Clear();
                    txtEmail.Clear();
                    txtFirstName.Clear();
                    txtHomePhone.Clear();
                    txtMiddleName.Clear();
                    txtPrimaryLastName.Clear();
                    txtPucpCode.Clear();
                    txtSecondLastName.Clear();
                    rbDni.Checked = false;
                    rbForeignCard.Checked = false;
                    rbMan.Checked = false;
                    rbPassport.Checked = false;
                    rbWoman.Checked = false;
                    dtpBirthday.Value = DateTime.Today;
                    break;
                case State.Search:
                    txtAddress.Enabled = true;
                    txtCellphone.Enabled = true;
                    txtDocument.Enabled = true;
                    txtEmail.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtHomePhone.Enabled = true;
                    txtMiddleName.Enabled = true;
                    txtPrimaryLastName.Enabled = true;
                    txtPucpCode.Enabled = false;
                    txtSecondLastName.Enabled = true;
                    rbDni.Enabled = true;
                    rbForeignCard.Enabled = true;
                    rbMan.Enabled = true;
                    rbPassport.Enabled = true;
                    rbWoman.Enabled = true;
                    dtpBirthday.Enabled = true;
                    break;
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ComponentsState(State.New);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Modify);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Save);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Cancel);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Search);
        }
    }
}
