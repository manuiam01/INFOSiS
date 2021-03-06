﻿using System;
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
    public partial class Login : Form
    {
        private Server.ServerClient servidor;
        private bool eyeNotClick = true;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            iniciar_login();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciar_login();
            }
        }

        private void iniciar_login()
        {
            if (txtUser.Text == "")
            {
                String mensaje = "ERROR: Debe ingresar un usuario";
                String titulo = "Usuario inválido";
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult mensajeError = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
            }
            else if (txtPassword.Text == "")
            {
                String mensaje = "ERROR: Debe ingresar una contraseña";
                String titulo = "Contraseña inválida";
                MessageBoxIcon icono = MessageBoxIcon.Error;
                DialogResult mensajeError = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
            }
            else
            {
                servidor = new Server.ServerClient();
                Server.user u = new Server.user();
                u.username = txtUser.Text;
                u.password = txtPassword.Text;
                u.acces = servidor.VerifyUser(u);
                if (u.acces.id != -1)
                {
                    //String role = u.acces.name;
                    //DialogResult mensajeError = MessageBox.Show(role, "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MdiInfosis mdiInfosis = new MdiInfosis(u);
                    mdiInfosis.ShowDialog();
                    this.Close();
                }
                else
                {
                    DialogResult mensajeError = MessageBox.Show("Usuario y/o Contraseña incorrecto(s)", "Vuelva a ingresar sus datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void lblEye_Click(object sender, EventArgs e)
        {
            if (eyeNotClick)
            {
                txtPassword.PasswordChar = '\0';
                eyeNotClick = false;
            }
            else
            {
                txtPassword.PasswordChar = '●';
                eyeNotClick = true;
            }
        }
    }
}
