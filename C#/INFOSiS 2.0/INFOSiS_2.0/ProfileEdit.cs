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
    public partial class ProfileEdit : UserControl
    {
        private static ProfileEdit _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;
        private Server.user user;

        public static ProfileEdit Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileEdit();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public ProfileEdit()
        {
            InitializeComponent();
        }

        public void poner_datos(Server.user u)
        {
            this.user = u;
            server = new Server.ServerClient();
            rbDNI.Enabled = false;
            rbForeignCard.Enabled = false;
            rbPassport.Enabled = false;
            rbWoman.Enabled = false;
            rbMan.Enabled = false;
            dtpBirthday.Enabled = false;
            txtAddress.Enabled = false;
            txtCellphone.Enabled = false;
            txtDocumentNumber.Enabled = false;
            txtEmail.Enabled = false;
            txtEmailPUCP.Enabled = false;
            txtFirstName.Enabled = false;
            txtHomephone.Enabled = false;
            txtPrimaryLastName.Enabled = false;
            txtPUCPCode.Enabled = false;
            txtSecondLastName.Enabled = false;
            txtSecondName.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btModify.Enabled = true;
            if (u.acces.id == 2)
            {
                //Coordinator
                Server.coordinator c = server.queryCoordByID(u.username);
                switch (c.idType)
                {
                    case 0:
                        rbDNI.Checked = true;
                        break;
                    case 1:
                        rbForeignCard.Checked = true;
                        break;
                    case 2:
                        rbPassport.Checked = true;
                        break;

                }
                switch(c.gender)
                {
                    case "M":
                        rbMan.Checked = true;
                        break;
                    case "F":
                        rbWoman.Checked = true;
                        break;
                }
                dtpBirthday.Value = c.birthday;
                txtAddress.Text = c.address;
                txtCellphone.Text = c.cellPhoneNumber;
                txtDocumentNumber.Text = c.idNumber;
                txtEmail.Text = c.email;
                txtEmailPUCP.Text = c.emailPUCP;
                txtFirstName.Text = c.firstName;
                txtHomephone.Text = c.homePhone;
                txtPrimaryLastName.Text = c.primaryLastName;
                txtPUCPCode.Text = c.idPUCP;
                txtSecondLastName.Text = c.secondLastName;
                txtSecondName.Text = c.middleName;
            }
            else
            {
                //Practicante
                Server.intern c = server.SearchInternByIdPUCP(u.username);
                switch (c.idType)
                {
                    case 0:
                        rbDNI.Checked = true;
                        break;
                    case 1:
                        rbForeignCard.Checked = true;
                        break;
                    case 2:
                        rbPassport.Checked = true;
                        break;

                }
                switch (c.gender)
                {
                    case "M":
                        rbMan.Checked = true;
                        break;
                    case "F":
                        rbWoman.Checked = true;
                        break;
                }
                dtpBirthday.Value = c.birthday;
                txtAddress.Text = c.address;
                txtCellphone.Text = c.cellPhoneNumber;
                txtDocumentNumber.Text = c.idNumber;
                txtDocumentNumber.Enabled = false;
                txtEmail.Text = c.email;
                txtEmailPUCP.Text = c.emailPUCP;
                txtFirstName.Text = c.firstName;
                txtHomephone.Text = c.homePhone;
                txtPrimaryLastName.Text = c.primaryLastName;
                txtPUCPCode.Text = c.idPUCP;
                txtPUCPCode.Enabled = false;
                txtSecondLastName.Text = c.secondLastName;
                txtSecondName.Text = c.middleName;
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            rbWoman.Enabled = true;
            rbMan.Enabled = true;
            dtpBirthday.Enabled = true;
            txtAddress.Enabled = true;
            txtCellphone.Enabled = true;
            txtEmail.Enabled = true;
            txtEmailPUCP.Enabled = true;
            txtFirstName.Enabled = true;
            txtHomephone.Enabled = true;
            txtPrimaryLastName.Enabled = true;
            txtSecondLastName.Enabled = true;
            txtSecondName.Enabled = true;
            btModify.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("¿Seguro que desea descartar los cambios?", "Cancelar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                poner_datos(this.user);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea guardar los cambios?", "Confirmar modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (user.acces.id == 2)
                {
                    //Coordinator
                    Server.coordinator c = server.queryCoordByID(user.username);
                    c.address = txtAddress.Text;
                    c.birthday = dtpBirthday.Value;
                    c.cellPhoneNumber = txtCellphone.Text;
                    c.email = txtEmail.Text;
                    c.emailPUCP = txtEmailPUCP.Text;
                    c.firstName = txtFirstName.Text;
                    c.homePhone = txtHomephone.Text;
                    c.middleName = txtSecondName.Text;
                    c.primaryLastName = txtPrimaryLastName.Text;
                    c.secondLastName = txtSecondLastName.Text;
                    if (rbMan.Checked == true)
                    {
                        c.gender = "M";
                    }
                    else
                    {
                        c.gender = "F";
                    }
                    int res = server.updateCoordinator(c);
                    if (res < 0)
                    {
                        MessageBox.Show("No se pudo actualizar sus datos personales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se actualizaron sus datos personales", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        poner_datos(this.user);
                    }
                }
                else
                {
                    //Practicante
                    Server.intern c = server.SearchInternByIdPUCP(user.username);
                    c.address = txtAddress.Text;
                    c.birthday = dtpBirthday.Value;
                    c.cellPhoneNumber = txtCellphone.Text;
                    c.email = txtEmail.Text;
                    c.emailPUCP = txtEmailPUCP.Text;
                    c.firstName = txtFirstName.Text;
                    c.homePhone = txtHomephone.Text;
                    c.middleName = txtSecondName.Text;
                    c.primaryLastName = txtPrimaryLastName.Text;
                    c.secondLastName = txtSecondLastName.Text;
                    if (rbMan.Checked == true)
                    {
                        c.gender = "M";
                    }
                    else
                    {
                        c.gender = "F";
                    }
                    int res = server.UpdateIntern(c);
                    if (res < 0)
                    {
                        MessageBox.Show("No se pudo actualizar sus datos personales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Se actualizaron sus datos personales", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        poner_datos(this.user);
                    }

                }
            }
        }
    }
}
