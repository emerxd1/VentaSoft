using Data;
using ModuloEntidades;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class LoginM : Form
    {
        private bool passwordVisible = false;

        public LoginM()
        {
            InitializeComponent();
            ApplyPasswordState(); // estado inicial coherente
        }

        /*==========================================================================*/
        // Mostrar / ocultar contraseña
        /*==========================================================================*/

        private void ApplyPasswordState()
        {
            // '\0' = sin máscara (se ve el texto); '●' = oculto
            textBox_Password.PasswordChar = passwordVisible ? '\0' : '●';
            textBox_Password.ButtonSymbol = passwordVisible
                ? 61550  // ojo abierto (contraseña visible)
                : 61552; // ojo cerrado (contraseña oculta)
        }

        private void textBox_Password_ButtonClick(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible; // antes nunca cambiaba
            ApplyPasswordState();
        }

        /*==========================================================================*/
        // Color del borde al enfocar / salir
        /*==========================================================================*/

        private void uiTextBox1_Enter(object sender, EventArgs e)
        {
            textBox_Email.RectColor = Color.Green;
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            textBox_Email.RectColor = Color.Silver;
        }

        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            textBox_Password.RectColor = Color.Green;
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            textBox_Password.RectColor = Color.Silver; // unificado con el email
        }

        /*==========================================================================*/
        // Login
        /*==========================================================================*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBox_Email.Text.Trim();
            string clave = textBox_Password.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Ingresa tu email y contraseña.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Entidad_Usuario O_user = new D_Users().Lister()
                    .FirstOrDefault(u =>
                        string.Equals(u.Correo, email, StringComparison.OrdinalIgnoreCase)
                        && u.Clave == clave);

                if (O_user == null)
                {
                    MessageBox.Show("Email o contraseña incorrectos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Password.Clear();
                    textBox_Password.Focus();
                    return;
                }

                Hide(); // ocultar login

                App mtr = new App(O_user);
                mtr.FormClosed += (s, args) =>
                {
                    textBox_Email.Clear();
                    textBox_Password.Clear();
                    Show();      // volver a mostrar el login
                    Activate();  // traerlo al frente
                    mtr.Dispose();
                };
                mtr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*==========================================================================*/
        // Botones de ventana
        /*==========================================================================*/

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
    }
}