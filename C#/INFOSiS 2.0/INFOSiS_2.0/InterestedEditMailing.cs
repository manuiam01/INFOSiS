using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace INFOSiS_2._0
{
    
    public partial class InterestedEditMailing : Form
    {
        OpenFileDialog ofdAttachment;
        private static string email;
        private static string password;
        private static string smtp;
        private static string port;
        private static Boolean ssl;
        private static string subject;
        private static string message;
        private static string fileName="";
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
        public string FileName { get => fileName; set => fileName = value; }

        public enum Estado
        {
            Inicial = 0,
            Nuevo = 1,
            Guardar = 2,
            Actualizar = 3,
            Eliminar = 4
        }
        public InterestedEditMailing()
        {
            InitializeComponent();
            establecerEstado(Estado.Inicial);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.jpge,.png)|*.png;*jpge;*jpg;|Pdf files|*pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName.ToString();
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
            bool escorrecto = true;
            if (txtEmail.Text.Equals(""))
                MessageBox.Show("No ingresó el correo de salida", "Aviso", MessageBoxButtons.OK);
            else if (txtPassword.Text.Equals(""))
                MessageBox.Show("No ingresó la contraseña", "Aviso", MessageBoxButtons.OK);
            else if (txtSmtp.Text.Equals(""))
                MessageBox.Show("No ingresó el smtp", "Aviso", MessageBoxButtons.OK);
            else if (txtPort.Text.Equals(""))
                MessageBox.Show("No ingresó el puerto", "Aviso", MessageBoxButtons.OK);
            else if (txbAsunto.Text.Equals(""))
                MessageBox.Show("No ingresó el asunto", "Aviso", MessageBoxButtons.OK);
            else if (txbMessage.Text.Equals(""))
                MessageBox.Show("No ingresó mensaje alguno", "Aviso", MessageBoxButtons.OK);
            else
            {

                bool isValid  = new EmailAddressAttribute().IsValid(txtEmail.Text);
                if(!isValid)
                    MessageBox.Show("El correo ingresado no es válido", "Aviso", MessageBoxButtons.OK, iconoWarning);
                else
                {
                    //Esta prueba se hace para ver si es que el correo y la contraseña ingresada son correctas
                    try
                    {

                        SmtpClient clientDetails = new SmtpClient();
                        clientDetails.Port = Convert.ToInt32(txtPort.Text);
                        clientDetails.Host = txtSmtp.Text;
                        clientDetails.EnableSsl = cbSSL.Checked;
                        clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                        clientDetails.UseDefaultCredentials = false;
                        clientDetails.Credentials = new NetworkCredential(txtEmail.Text, txtPassword.Text);
                        MailMessage mailDetails = new MailMessage();
                        //mailDetails.From = new MailAddress(email);
                        mailDetails.From = new MailAddress("somewhere@gmail.com");
                        mailDetails.To.Add(txtEmail.Text);
                        if (!fileName.Equals(""))
                            mailDetails.Attachments.Add(new Attachment(fileName));
                        //mailDetails.Subject = subject;
                        mailDetails.Subject = txbAsunto.Text;
                        mailDetails.IsBodyHtml = cbHTML.Checked;
                        mailDetails.Body = txbMessage.Text;
                        clientDetails.Send(mailDetails);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("El correo/contraseña no es válido", "Aviso", MessageBoxButtons.OK, iconoWarning);
                        escorrecto = false;
                    }
                    if (escorrecto)
                    {
                        DialogResult result = MessageBox.Show("Está seguro de que quiere realizar estos cambios?", "Aviso", MessageBoxButtons.YesNo, iconoPregunta);
                        if (result == DialogResult.Yes)
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


        }
        public void establecerEstado(Estado e)
        {
            switch (e)
            {
                case Estado.Inicial:
                    rbGmail.Checked = true;
                    txtPort.Enabled = false;
                    txtSmtp.Enabled = false;
                    break;
                case Estado.Nuevo:
                    txtSmtp.Enabled = true;
                    txtPort.Enabled = true;
                    break;
                case Estado.Actualizar:
                    txtPort.Enabled = false;
                    txtSmtp.Enabled = false;
                    break;
            }
        }

        private void RbGmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGmail.Checked == true)
            {
                establecerEstado(Estado.Actualizar);
                txtSmtp.Text = "smtp.gmail.com";
                txtPort.Text = "587";
            }
            
        }

        private void RbHotmail_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHotmail.Checked == true)
            {
                establecerEstado(Estado.Actualizar);
                txtSmtp.Text = "smtp.live.com";
                txtPort.Text = "465";
            }
        }

        private void RbYahoo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYahoo.Checked == true)
            {
                establecerEstado(Estado.Actualizar);
                txtSmtp.Text = "smtp.mail.yahoo.com";
                txtPort.Text = "465";
            }
        }

        private void RbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
            {
                establecerEstado(Estado.Nuevo);
                txtSmtp.Text = "";
                txtPort.Text = "";
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de que quiere realizar estos cambios?", "Aviso", MessageBoxButtons.YesNo, iconoPregunta);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
