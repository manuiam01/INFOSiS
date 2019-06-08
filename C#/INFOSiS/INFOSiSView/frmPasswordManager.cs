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
    public partial class frmPasswordManager : Form
    {
        public frmPasswordManager()
        {
            InitializeComponent();
        }

        private void frmPasswordManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seguro que quieres cambiar la contraseña?", "Aviso", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DialogResult dialog2 = MessageBox.Show("Se actualizó la contraseña", "Aviso", MessageBoxButtons.OK);
                if (dialog2 == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seguro que quieres salir del proceso?", "Aviso", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
