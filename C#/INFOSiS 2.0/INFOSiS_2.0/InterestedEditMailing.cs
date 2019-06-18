using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiS_2._0
{
    public partial class InterestedEditMailing : Form
    {
        OpenFileDialog ofdAttachment;
        String fileName = "";

        public InterestedEditMailing(string port, string host, string email, string password,string subject, Boolean ssl,Boolean html)
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.jpge,.png)|*.png;*jpge;*jpg;|Pdf files|*pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
