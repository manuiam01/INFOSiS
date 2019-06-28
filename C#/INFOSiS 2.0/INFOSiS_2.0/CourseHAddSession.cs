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

        public CourseHAddSession(BindingList<Server.session> sessions)
        {
            InitializeComponent();          
            dgvSessions.AutoGenerateColumns = false;
            listSession = new BindingList<session>();
            if (sessions != null)
            {
                foreach (Server.session s in sessions)
                    listSession.Add(s);// = sessions;             
            }
            dgvSessions.Columns[0].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            dgvSessions.DataSource = listSession;
            //int index = 0;
            //foreach (Server.session session in listSession)
            //{
               
            //    dgvSessions.Rows[index].Cells[0].Value = session.dateSession.ToString();
            //    MessageBox.Show(session.dateSession.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    index++;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingList<Server.session> listAux = new BindingList<Server.session>(ListSession.OrderBy(x => x.dateSession).ToList());
            listSession = listAux;
            dgvSessions.DataSource = null;
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
                //en realida debería ser así como está abajo :v así dijo el profe
                //DateTime d = dtpDay.Value;
                //d.Add(dtpTime.Value.TimeOfDay);
                s.dateSession = d;
                s.hours = Int32.Parse(txtHours.Text);
                s.location = txtLocation.Text;               
                listSession.Add(s);
                dgvSessions.DataSource = listSession;              

            }


        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dgvSessions.SelectedRows)
            {
                listSession.RemoveAt(c.Index);

            }
            dgvSessions.DataSource = listSession;
        }
    }
}
