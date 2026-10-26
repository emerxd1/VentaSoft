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

            // Se desuscribe antes de suscribir: así el evento queda enlazado UNA sola vez,
            // aunque el Designer ya lo tenga conectado (evita iniciar sesión dos veces).
            textBox_Email.KeyDown -= textBox_Email_KeyDown;
            textBox_Email.KeyDown += textBox_Email_KeyDown;
            textBox_Password.KeyDown -= textBox_Password_KeyDown;
            textBox_Password.KeyDown += textBox_Password_KeyDown;
        }

        // Mostrar / ocultar contraseña

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

        // Color del borde al enfocar / salir

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

        // Tecla Enter

        // En el correo, Enter pasa a la contraseña.
        private void textBox_Email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita el pitido de Windows
                textBox_Password.Focus();
            }
        }

        // En la contraseña, Enter inicia sesión.
        private void textBox_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(sender, EventArgs.Empty);
            }
        }

        // Login

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

                FrmMain mtr = new FrmMain(O_user);
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

        // Botones de ventana

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}