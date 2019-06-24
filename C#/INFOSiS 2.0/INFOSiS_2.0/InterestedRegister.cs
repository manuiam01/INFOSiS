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
    public partial class InterestedRegister : UserControl
    {
        private Server.ServerClient servidor;
        MessageBoxIcon iconoWarning = MessageBoxIcon.Warning;
        MessageBoxIcon iconoPregunta = MessageBoxIcon.Question;
        MessageBoxIcon iconoCorrecto = MessageBoxIcon.Asterisk;
        private static InterestedRegister _instance;
        private static Panel _panelMdi;
        private DataTable tbCursos;
        private BindingList<string> idcursos;
        public static InterestedRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InterestedRegister();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public InterestedRegister()
        {
            InitializeComponent();
            limpiar();
            tbCursos = new DataTable();
            idcursos = new BindingList<string>();
        }

        private void InterestedRegister_Load(object sender, EventArgs e)
        {

        }

        private void DgvInterestedCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtBuscarCursos_Click(object sender, EventArgs e)
        {
            InterestedCourses formBuscarCursosInteresado = new InterestedCourses();
            if (formBuscarCursosInteresado.ShowDialog() == DialogResult.OK)
            {
                
                tbCursos.Columns.Add("ID", typeof(string));
                tbCursos.Columns.Add("Nombre", typeof(string));
                idcursos = formBuscarCursosInteresado.Cursos;
                foreach(string id in idcursos)
                {
                    Server.course c = new Server.course();
                    c = servidor.queryCourseById(id);
                    tbCursos.Rows.Add(c.id, c.name);
                }
                //Acá en teoría debería de devolver todo el ArrayList de cursos para ingresarlo al dgv
                //dgvInterestedCourses.DataSource = formBuscarCursosInteresado.}

            }
        }

        public int verificarVacio()
        {
            int resultado = 1;
            //falta verificar el dateNacimiento.Value != DateTime.Today ||, pero no sé como hacerlo uwur
            if (txbApeMa.Text != "" ||
            txbApePa.Text != "" ||
            txbNDocumento.Text != "" ||
            txbNombre.Text != "" ||
            txbSegundoNom.Text != "" ||
            txtCellphone.Text != "" ||
            txtEmail.Text != "" ||
            //txtEmailPUCP.Text != "" ||
            //txtHomephone.Text != "" ||
            rbCarnet.Checked != false ||
            //rbDNI.Checked != false ||
            rbPasaporte.Checked != false ||
            rbMale.Checked != false ||
            rbFemale.Checked != false ||
            dgvInterestedCourses.Rows.Count != 0)
            {
                resultado = 0;
            }
            
            return resultado;
        }

        private void InterestedRegister_Leave(object sender, EventArgs e)
        {

            if (verificarVacio() == 0) {
                DialogResult result = MessageBox.Show("Está seguro de salir sin guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, iconoWarning);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                }
            }
        }
        public void limpiar()
        {
            txbApeMa.Text = "";
            txbApePa.Text = "";
            txbNDocumento.Text = "";
            txbNombre.Text = "";
            txbSegundoNom.Text = "";
            txtCellphone.Text = "";
            txtEmail.Text = "";
            //txtEmailPUCP.Text = "";
            //txtHomephone.Text = "";
            rbCarnet.Checked = false;
            rbDNI.Checked = true;
            rbPasaporte.Checked = false;
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            servidor = new Server.ServerClient();
            Server.interested i = new Server.interested();
            Server.course c1 = new Server.course();
            Server.course c2 = new Server.course();

            if (rbCarnet.Checked == false && rbDNI.Checked == false && rbPasaporte.Checked == false)
                MessageBox.Show("No seleccionó el tipo de documento", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbNDocumento.Text == "")
                MessageBox.Show("No ingresó el número de documento", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbNombre.Text == "")
                MessageBox.Show("No ingresó el nombre del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbApePa.Text == "")
                MessageBox.Show("No ingresó el apellido paterno del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txbApeMa.Text == "")
                MessageBox.Show("No ingresó el apellido materno del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (rbMale.Checked == false && rbFemale.Checked == false)
                MessageBox.Show("No escogió el género", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txtCellphone.Text == "" )
                MessageBox.Show("No ingresó el número del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            else if (txtEmail.Text == "" ) 
                MessageBox.Show("No ingresó el correo del interesado", "Aviso", MessageBoxButtons.OK, iconoWarning);
            //else if (dgvInterestedCourses.Rows.Count == 0)
            //   MessageBox.Show("No escogió cursos de interés", "Aviso", MessageBoxButtons.OK);
            else
            {
                iconoPregunta = MessageBoxIcon.Question;
                DialogResult result = MessageBox.Show("Está seguro de que quiere guardar el registro?", "Aviso", MessageBoxButtons.YesNo, iconoPregunta);
                if (result == DialogResult.Yes)
                {
                    if (rbDNI.Checked == true)
                        i.idType = 0;
                    else if (rbCarnet.Checked == true)
                        i.idType = 1;
                    else
                        i.idType = 2;
                    i.idNumber = txbNDocumento.Text;
                    i.firstName = txbNombre.Text;
                    i.middleName = txbSegundoNom.Text;
                    i.primaryLastName = txbApePa.Text;
                    i.secondLastName = txbApeMa.Text;
                    if (rbMale.Checked == true)
                        i.gender = "M";
                    else
                        i.gender = "F";
                    i.cellPhoneNumber = txtCellphone.Text;
                    i.email = txtEmail.Text;
                    i.courses = new Server.course[5];
                    servidor.InsertInterested(i);
                    
                    MessageBox.Show("Se registró al interesado de manera correcta", "Éxito", MessageBoxButtons.OK,iconoCorrecto);
                    limpiar();
                }
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (verificarVacio() == 0)
            {
                DialogResult result = MessageBox.Show("Está seguro de que quiere cancelar el registro?", "Aviso", MessageBoxButtons.YesNo,iconoWarning);
                if (result == DialogResult.Yes)
                {
                    limpiar();
                }
            }
        }
    }
}
