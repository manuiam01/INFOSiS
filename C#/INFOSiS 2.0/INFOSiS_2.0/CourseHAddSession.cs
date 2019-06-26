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

        public CourseHAddSession(Server.session[] sessions)
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("DateTimeSession", typeof(DateTime));
            table.Columns.Add("Hours", typeof(int));
            table.Columns.Add("Location", typeof(String));           

            if (sessions != null)
            {
                listSession = new BindingList<session>(sessions);             
            }
            else {
                listSession = new BindingList<session>();
            }
            dgvSessions.DataSource = listSession;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingList<Server.session> listAux = new BindingList<Server.session>(listSession.OrderBy(x => x.dateSession).ToList());
            sessions = new Server.session[listAux.Count];
            listAux.CopyTo(sessions, 0);
            this.DialogResult = DialogResult.OK;
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
                listSession.Add(s);
                dgvSessions.DataSource = listSession;
                int index = 0;
                foreach (Server.session session in listSession)
                {
                    dgvSessions.Rows[index].Cells[0].Value = session.dateSession.ToString();
                    index++;
                }
            }
            
        }
    }
}
