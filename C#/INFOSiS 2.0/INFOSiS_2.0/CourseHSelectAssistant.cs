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
    public partial class CourseHSelectAssistant : Form
    {
        private DataTable table;
        private String idAssistant;
        private Server.ServerClient server;
        public CourseHSelectAssistant()
        {
            InitializeComponent();
            //server = new Server.ServerClient();
            //table = new DataTable();
            //table.Columns.Add("ID", typeof(string));
            //table.Columns.Add("Nombre", typeof(string));
            //BindingList<Server.professor> assistants = new BindingList<Server.professor>(server.query);
            //foreach (Server.course c in courses)
            //{
            //    table.Rows.Add(c.id, c.name);
            //}
            //dgvCursos.DataSource = table;
        }
    }
}
