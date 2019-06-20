using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace INFOSiS_2._0
{
    public partial class InterestedPublicity : UserControl
    {

        private Server.ServerClient servidor;
        private static InterestedPublicity _instance;
        private static Panel _panelMdi;
        public static String port = "";
        public static String host = "";
        public static String email = "";
        public static String password = "";
        public static String subject = "";
        public static Boolean ssl = false;
        public static Boolean html = false;
        public static InterestedPublicity Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedPublicity();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedPublicity()
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            dtpInicioCurso.MinDate = DateTime.Now;
            btnSearch.Enabled = false;
            dgvInteresadosMailing.AutoGenerateColumns = false;
            dgvInteresadosMailing.DataSource = servidor.QueryAllInterested();
            //limpiar();
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            InterestedCourseMailing formBuscarCursosInteresado = new InterestedCourseMailing();
            if (formBuscarCursosInteresado.ShowDialog() == DialogResult.OK)
            {
                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInteresadosMailing.DataSource = formBuscarCursosInteresado}
            }
        }

        private void LblEditarMail_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void LblEditarMail_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if(port != "" ||
                host != "" ||
                email != "" ||
                password != "")
            {
                MessageBox.Show("Falta configurar las credenciales del envío de correo", "Aviso", MessageBoxButtons.OK);

            }
            else
            {
                try
                {
                    //Detalles del servidor e email de donde sale el correo
                    SmtpClient clientDetails = new SmtpClient();
                    clientDetails.Port = 587;
                    clientDetails.Host = "smtp.gmail.com";
                    clientDetails.EnableSsl = true;
                    clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                    clientDetails.UseDefaultCredentials = false;
                    clientDetails.Credentials = new NetworkCredential("jeremi.cardenas@pucp.pe", "miamortlv11");
                    //clientDetails.Port = Convert.ToInt32(port);
                    //clientDetails.Host = host;
                    //clientDetails.EnableSsl = ssl;
                    //clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                    //clientDetails.UseDefaultCredentials = false;
                    //clientDetails.Credentials = new NetworkCredential(email,password);

                    //Detalles del Mensaje
                    //Esto debería hacerse por todo el arreglo de correos, pero por ahora probemos con uno solo
                    foreach(DataGridView row in dgvInteresadosMailing.Rows)
                    {
                        
                    }
                    MailMessage mailDetails = new MailMessage();
                    //mailDetails.From = new MailAddress(email);
                    mailDetails.From = new MailAddress("jeremi.cardenas@pucp.pe");
                    mailDetails.To.Add("jeremics97@gmail.com");
                    //mailDetails.Subject = subject;
                    mailDetails.Subject = "INFOPUC - Curso de Excel Avanzado - ";
                    mailDetails.IsBodyHtml = html;
                    mailDetails.Body = "Jeremixer never enemixer";

                    clientDetails.Send(mailDetails);
                    MessageBox.Show("Se envió el mail Yeeeeh");
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    for (int i = 0; i < ex.InnerExceptions.Length; i++)
                    {
                        SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                        if (status == SmtpStatusCode.MailboxBusy ||
                            status == SmtpStatusCode.MailboxUnavailable)
                        {
                            Console.WriteLine("Delivery failed - retrying in 5 seconds.");
                            System.Threading.Thread.Sleep(5000);
                            
                        }
                        else
                        {
                            Console.WriteLine("Failed to deliver message to {0}",
                                ex.InnerExceptions[i].FailedRecipient);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught in RetryIfBusy(): {0}",
                            ex.ToString());
                }
            }
        }


        private void lblEditarMail_Click(object sender, EventArgs e)
        {
            InterestedEditMailing frmEditMailing = new InterestedEditMailing(port,host,email,password,subject,ssl,html);
            if (frmEditMailing.ShowDialog() == DialogResult.OK)
            {

            }
        
        }

        private void InterestedPublicity_Load(object sender, EventArgs e)
        {

        }

        private void dgvInteresadosMailing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
