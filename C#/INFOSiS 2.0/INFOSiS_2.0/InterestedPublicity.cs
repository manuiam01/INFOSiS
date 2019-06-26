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
        public int cantEnvios=0;
        public static String port = "";
        public static String host = "";
        public static String email = "";
        public static String password = "";
        public static String subject = "";
        public static String message = "";
        public static Boolean ssl = false;
        public static Boolean html = false;
        public static String fileName = "";
        private String idCourse = "";
        private String nombreCurso = "";
        MessageBoxIcon iconoWarning = MessageBoxIcon.Warning;
        MessageBoxIcon iconoPregunta = MessageBoxIcon.Question;
        MessageBoxIcon iconoCorrecto = MessageBoxIcon.Asterisk;
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
        public string IdCourse { get => idCourse; set => idCourse = value; }

        public InterestedPublicity()
        {
            InitializeComponent();
            servidor = new Server.ServerClient();
            dtpInicioCurso.MinDate = DateTime.Now;
            dgvInteresadosMailing.AutoGenerateColumns = false;
            txbCourseSelected.Enabled = false;
            //dgvInteresadosMailing.DataSource = servidor.QueryAllInterested();
            //limpiar();
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DateTime datecourse = dtpInicioCurso.Value;
            InterestedCourseMailing formBuscarCursosInteresado = new InterestedCourseMailing(datecourse, idCourse);
            if (formBuscarCursosInteresado.ShowDialog() == DialogResult.OK)
            {
                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInteresadosMailing.DataSource = formBuscarCursosInteresado}
                
                Server.course c = new Server.course();
                idCourse = formBuscarCursosInteresado.IdCourse;
                c.id = idCourse;
                nombreCurso = formBuscarCursosInteresado.NombreCurso;
                txbCourseSelected.Text = formBuscarCursosInteresado.NombreCurso;
                dgvInteresadosMailing.DataSource = servidor.QueryAllByCourse(c);
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
            if(txbCourseSelected.Text.Equals(""))
                MessageBox.Show("No ha escogido ni un curso", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (dgvInteresadosMailing.Rows.Count == 0)
            {
                MessageBox.Show("No hay interesados en este curso", "Aviso", MessageBoxButtons.OK,iconoWarning);
            }
            else if(port.Equals("") ||
                host.Equals("") ||
                email.Equals("") ||
                password.Equals(""))
            {
                MessageBox.Show("Falta configurar las credenciales del envío de correo", "Aviso", MessageBoxButtons.OK);

            }
            else 
            {
                DialogResult result = MessageBox.Show("Está seguro de que quiere realizar el envío?", "Aviso", MessageBoxButtons.YesNo, iconoPregunta);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Detalles del servidor e email de donde sale el correo
                        SmtpClient clientDetails = new SmtpClient();
                        if (port == "" || host == "" || email == "" || password == "")
                            MessageBox.Show("Falta completar los datos de envío en configuración de mailing", "Aviso", MessageBoxButtons.OK, iconoWarning);
                        else
                        {
                            String mail = "";
                            foreach (DataGridViewRow row in dgvInteresadosMailing.Rows)
                            {
                                DataGridViewCheckBoxCell ck = row.Cells[4] as DataGridViewCheckBoxCell;
                                if (Convert.ToBoolean(ck.Value) == false)
                                {
                                    clientDetails.Port = Convert.ToInt32(port);
                                    clientDetails.Host = host;
                                    clientDetails.EnableSsl = ssl;
                                    clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                                    clientDetails.UseDefaultCredentials = false;
                                    clientDetails.Credentials = new NetworkCredential(email, password);
                                    mail = row.Cells[2].Value.ToString();
                                    MailMessage mailDetails = new MailMessage();
                                    //mailDetails.From = new MailAddress(email);
                                    mailDetails.From = new MailAddress(email);
                                    mailDetails.To.Add(mail);
                                    if (!fileName.Equals(""))
                                        mailDetails.Attachments.Add(new Attachment(fileName));
                                    //mailDetails.Subject = subject;
                                    mailDetails.Subject = subject + nombreCurso;
                                    mailDetails.IsBodyHtml = html;
                                    mailDetails.Body = message;
                                    clientDetails.Send(mailDetails);
                                    cantEnvios = cantEnvios + 1;
                                }
                            }
                            if (cantEnvios != 0)
                            {
                                MessageBox.Show("Se envió el mail Yeeeeh");
                                dgvInteresadosMailing.DataSource = null;
                                txbCourseSelected.Text = "";
                            }
                                
                            else
                                MessageBox.Show("No se envió ningún correo :(");

                        }
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
        }


        private void lblEditarMail_Click(object sender, EventArgs e)
        {
            InterestedEditMailing frmEditMailing = new InterestedEditMailing();
            if (frmEditMailing.ShowDialog() == DialogResult.OK)
            {
                if (frmEditMailing.Port != null)
                    port = frmEditMailing.Port;
                else
                    port = "";
                if (frmEditMailing.Port != null)
                    host = frmEditMailing.Smtp;
                else
                    host = "";
                if (frmEditMailing.Port != null)
                    ssl = frmEditMailing.Ssl;
                else
                    ssl = false;
                if (frmEditMailing.Port != null)
                    email = frmEditMailing.Email;
                else
                    email = "";
                if (frmEditMailing.Port != null)
                    password = frmEditMailing.Password;
                else
                    password = "";
                if (frmEditMailing.Port != null)
                    subject = frmEditMailing.Subject;
                else
                    subject = "";
                if (frmEditMailing.Port != null)
                    message = frmEditMailing.Message;
                else
                    message = "";
                if (frmEditMailing.FileName != null)
                    fileName = frmEditMailing.FileName;
                else
                    fileName = "";
            }
        
        }

        private void InterestedPublicity_Load(object sender, EventArgs e)
        {

        }

        private void dgvInteresadosMailing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro de que quiere cancelar el envío?", "Aviso", MessageBoxButtons.YesNo, iconoPregunta);
            if(result == DialogResult.Yes)
            {
                dgvInteresadosMailing.DataSource = null;
                txbCourseSelected.Text = "";
            }
        }
    }
}
