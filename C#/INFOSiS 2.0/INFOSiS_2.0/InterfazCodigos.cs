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
    public partial class InterfazCodigos : Form
    {
        public InterfazCodigos(BindingList<ListaStrings> listaCodigos)
        {
            InitializeComponent();
            dgvCodigos.DataSource = listaCodigos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            if (!ValidarCodigo(codigo))
            {
                DialogResult mensajeError;
                String mensaje;
                String titulo;
                MessageBoxIcon icono;
                mensaje = "ERROR: El código PUCP ingresado no es válido.";
                titulo = "Código PUCP no válido";
                icono = MessageBoxIcon.Error;
                mensajeError = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
            }
            else
            {
                ((BindingList<ListaStrings>)(dgvCodigos.DataSource)).Add(new ListaStrings(codigo));
            }
        }

        private bool ValidarCodigo(string codigo)
        {
            if (codigo.Length == 0 || codigo.Length > 15)
            {
                return false;
            }
            var validos = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890";
            bool valido = true;
            foreach (char c in codigo)
            {
                valido = validos.IndexOf(c) != -1;
                if (!valido) break;
            }
            return valido;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            ((BindingList<ListaStrings>)(dgvCodigos.DataSource)).RemoveAt(dgvCodigos.SelectedCells[0].RowIndex);

            
        }
    }
}
