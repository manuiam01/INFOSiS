using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiSView
{
    public partial class frmInterestedManager : Form
    {
        private string caso;
        public frmInterestedManager()
        {
            caso = "uno";
            InitializeComponent();
            ComponentsState(State.Modify);
            lbIntereses.Items.Add("Excel");
            lbIntereses.Items.Add("SQL");
            lbIntereses.Items.Add("AutoCAD");
            btnModify.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmInterestedManager_Load(object sender, EventArgs e)
        {

        }
        void ComponentsState(State state)
        {
            switch (state)
            {
                case State.New:
                    checkBox1.Checked = false;
                    txtCellphone.Enabled = true;
                    txtDocument.Enabled = true;
                    txtEmail.Enabled = true;
                    txtFirstName.Enabled = true;
                    txtMiddleName.Enabled = true;
                    txtPrimaryLastName.Enabled = true;
                    txtSecondLastName.Enabled = true;
                    rbDni.Enabled = true;
                    rbForeignCard.Enabled = true;
                    rbMan.Enabled = true;
                    rbPassport.Enabled = true;
                    rbWoman.Enabled = true;
                    lbIntereses.Enabled = true;
                    button4.Enabled = true;
                    btnModify.Enabled = false;
                    lbIntereses.SelectedItems.Clear();
                    btnSearch.Enabled = false;
                    break;
                case State.Modify:
                    checkBox1.Enabled = false;
                    txtCellphone.Enabled = false;
                    txtDocument.Enabled = true;
                    txtEmail.Enabled = false;
                    txtFirstName.Enabled = false;
                    button4.Enabled = true;
                    txtMiddleName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;
                    lbIntereses.SelectedItems.Clear();
                    txtSecondLastName.Enabled = false;
                    
                    rbDni.Enabled = true;
                    rbForeignCard.Enabled = true;
                    rbMan.Enabled = false;
                    rbPassport.Enabled = true;
                    rbWoman.Enabled = false;
                    lbIntereses.Enabled = false;
                    btnModify.Enabled = true;
                    btnSearch.Enabled = true;
                    button4.Enabled = false;
                    checkBox1.Enabled = true;
                    button5.Enabled = false;
                    break;
                case State.Save:

                    txtCellphone.Enabled = false;
                    txtDocument.Enabled = false;
                    txtEmail.Enabled = false;
                    txtFirstName.Enabled = false;
                    button4.Enabled = true;
                    txtMiddleName.Enabled = false;
                    txtPrimaryLastName.Enabled = false;

                    txtSecondLastName.Enabled = false;
                    rbDni.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbMan.Enabled = false;
                    rbPassport.Enabled = false;
                    rbWoman.Enabled = false;
                    lbIntereses.Enabled = false;
                    break;
                case State.Cancel:
                    checkBox1.Checked = false;
                    txtCellphone.Clear();
                    txtDocument.Clear();
                    txtEmail.Clear();
                    txtFirstName.Clear();
                    lbIntereses.SelectedItems.Clear();
                    txtMiddleName.Clear();
                    txtPrimaryLastName.Clear();
                    button4.Enabled = false;
                    txtSecondLastName.Clear();
                    rbDni.Checked = false;
                    rbForeignCard.Checked = false;
                    rbMan.Checked = false;
                    rbPassport.Checked = false;
                    rbWoman.Checked = false;

                    break;
                case State.Search:

                    txtCellphone.Enabled = true;
                    txtDocument.Enabled = false;
                    txtEmail.Enabled = true;
                    txtFirstName.Enabled = true;
                    checkBox1.Enabled = false;
                    txtMiddleName.Enabled = true;
                    txtPrimaryLastName.Enabled = true;
                    button4.Enabled = true;
                    txtSecondLastName.Enabled = true;
                    rbDni.Enabled = false;
                    rbForeignCard.Enabled = false;
                    rbMan.Enabled = true;
                    rbPassport.Enabled = false;
                    rbWoman.Enabled = true;
                    lbIntereses.Enabled = true;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComponentsState(State.New);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if(caso == "uno")
            {
                DialogResult dialog = MessageBox.Show("Seguro que quieres guardar el nuevo interesado?", "Aviso", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    DialogResult dialog2 = MessageBox.Show("Se guardó al interesado de manera correcta", "Aviso", MessageBoxButtons.OK);
                    //if (dialog2 == DialogResult.OK)
                    //{
                    //    this.Close();
                    //}
                    ComponentsState(State.Modify);
                }
                else if (dialog == DialogResult.No)
                {
                    string rowor = "uwur";
                }
            }
            else if (caso == "dos")
            {
                DialogResult dialog = MessageBox.Show("Seguro que quieres actualizar al interesado?", "Aviso", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    DialogResult dialog2 = MessageBox.Show("Se actualizó al interesado", "Aviso", MessageBoxButtons.OK);
                    ComponentsState(State.Modify);
                }
                else if (dialog == DialogResult.No)
                {
                    string rowor = "uwur";
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Modify);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seguro que quieres cancelar el proceso?", "Aviso", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                ComponentsState(State.Modify);
            }
            else if (dialog == DialogResult.No)
            {
                string rowor = "uwur";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComponentsState(State.Search);
            caso = "dos";
        }


    }
}
