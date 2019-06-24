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
        private string email;
        private string password;
        private string smtp;
        private string port;
        private Boolean ssl;
        private string subject;
        private string message;
        MessageBoxIcon iconoWarning = MessageBoxIcon.Warning;
        MessageBoxIcon iconoPregunta = MessageBoxIcon.Question;
        MessageBoxIcon iconoCorrecto = MessageBoxIcon.Asterisk;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Smtp { get => smtp; set => smtp = value; }
        public string Port { get => port; set => port = value; }
        public bool Ssl { get => ssl; set => ssl = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Message { get => message; set => message = value; }

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

        private void LblInterestedRegister_Click(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterestedEditMailing_Load(object sender, EventArgs e)
        {

        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            if(txbAsunto.Equals(""))
                MessageBox.Show("No ingresó el asunto", "Aviso", MessageBoxButtons.OK);
            else if (txbMessage.Equals(""))
                MessageBox.Show("No ingresó mensaje alguno", "Aviso", MessageBoxButtons.OK);
            else if(txtEmail.Equals(""))
                MessageBox.Show("No ingresó el correo de salida", "Aviso", MessageBoxButtons.OK);
            else if (txtPassword.Equals(""))
                MessageBox.Show("No ingresó la contraseña", "Aviso", MessageBoxButtons.OK);
            else if(txtPort.Equals(""))
                MessageBox.Show("No ingresó el puerto", "Aviso", MessageBoxButtons.OK);
            else if(txtSmtp.Equals(""))
                MessageBox.Show("No ingresó el smtp", "Aviso", MessageBoxButtons.OK);
            else
            {
                Subject = txbAsunto.Text;
                Password = txtPassword.Text;
                Email = txtEmail.Text;
                Smtp = txtSmtp.Text;
                Port = txtPort.Text;
                Message = txbMessage.Text;
                Ssl = cbSSL.Checked;
                this.DialogResult = DialogResult.OK;
            }


        }
    }
}
