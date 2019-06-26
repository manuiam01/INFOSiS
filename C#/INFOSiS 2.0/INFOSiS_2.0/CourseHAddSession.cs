using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFOSiS_2._0.Server;

namespace INFOSiS_2._0
{
    public partial class CourseHAddSession : Form
    {
        private DataTable table;
        private Server.session[] sessions;
        private BindingList<Server.session> listSession;

        public session[] Sessions { get => sessions; set => sessions = value; }
        public BindingList<session> ListSession { get => listSession; set => listSession = value; }

        public CourseHAddSession(Server.session[] sessions)
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("DateTimeSession", typeof(DateTime));
            table.Columns.Add("Hours", typeof(int));
            table.Columns.Add("Location", typeof(String));           

            if (sessions != null)
            {
                ListSession = new BindingList<session>(sessions);             
            }
            else {
                ListSession = new BindingList<session>();
            }
            dgvSessions.DataSource = ListSession;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingList<Server.session> listAux = new BindingList<Server.session>(ListSession.OrderBy(x => x.dateSession).ToList());
            sessions = new Server.session[listAux.Count];
            listAux.CopyTo(sessions, 0);
            this.DialogResult = DialogResult.OK;
            dgvSessions.DataSource = null;
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {

            if (txtHours.Text == "")
            {
                MessageBox.Show("No se ha ingresado las horas de la sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("No se ha registrado el aula de la sesión", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                Server.session s = new Server.session();
                DateTime d = dtpDay.Value.Date.Add(dtpTime.Value.TimeOfDay);
                s.dateSession = d;
                s.hours = Int32.Parse(txtHours.Text);
                s.location = txtLocation.Text;
                //MessageBox.Show(s.dateSession.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try
                {
                    ListSession.Add(s);
                    dgvSessions.DataSource = ListSession;
                    int index = 0;
                    foreach (Server.session session in ListSession)
                    {
                        dgvSessions.Rows[index].Cells[0].Value = session.dateSession.ToString();
                        index++;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error desconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
