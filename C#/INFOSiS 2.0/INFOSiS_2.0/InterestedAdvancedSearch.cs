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
    public partial class InterestedAdvancedSearch : Form
    {
        public InterestedAdvancedSearch()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if(tbApeMa.Text==""&&
                tbApePa.Text==""&&
                tbNombre.Text==""&&
                tbSNombre.Text=="")
                MessageBox.Show("No se ingresó información alguna", "Aviso", MessageBoxButtons.OK);
            else
            {
                //se llena la data
                //dgvInteresados.DataSource =;
                //if(dgvInteresados.Rows.Count==0)
                //    MessageBox.Show("No hay interesado con esa información", "Aviso", MessageBoxButtons.OK);

            }

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            //if(dgvInteresados.SelectedRows!=null)
            //  this.DialogResult = DialogResult.OK;
            //else{
            //  MessageBox.Show("Favor de escoger a algún interesado", "Aviso", MessageBoxButtons.OK);
            //}
            //Por ahora solo lo devolvemos y ya
            this.DialogResult = DialogResult.OK;
        }
    }
}
