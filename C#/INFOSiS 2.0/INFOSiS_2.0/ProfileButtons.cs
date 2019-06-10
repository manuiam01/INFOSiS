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
    public partial class ProfileButtons : UserControl
    {
        private static ProfileButtons _instance;
        private static Panel _panelMdi;

        public static ProfileButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileButtons();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public ProfileButtons()
        {
            InitializeComponent();
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(ProfileEdit.Instance))
            {
                PanelMdi.Controls.Add(ProfileEdit.Instance);
                ProfileEdit.Instance.Dock = DockStyle.Fill;
                ProfileEdit.PanelMdi = PanelMdi;
                ProfileEdit.Instance.Visible = true;
                ProfileEdit.Instance.BringToFront();
            }
            else
            {
                ProfileEdit.Instance.Visible = true;
                ProfileEdit.Instance.BringToFront();
            }
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            cleanWindow();
            if (!PanelMdi.Controls.Contains(ProfileChangePassword.Instance))
            {
                PanelMdi.Controls.Add(ProfileChangePassword.Instance);
                ProfileChangePassword.Instance.Dock = DockStyle.Fill;
                ProfileChangePassword.PanelMdi = PanelMdi;
                ProfileChangePassword.Instance.Visible = true;
                ProfileChangePassword.Instance.BringToFront();
            }
            else
            {
                ProfileChangePassword.Instance.Visible = true;
                ProfileChangePassword.Instance.BringToFront();
            }
        }

        private void cleanWindow()
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }
        }
        
    }
}
