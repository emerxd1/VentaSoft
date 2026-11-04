using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// Asegúrate de importar el espacio de nombres de tu capa de negocio
using Store;

namespace Main
{
    public partial class FrmRecoverPassword : Form
    {
        public FrmRecoverPassword()
        {
            InitializeComponent();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            // 1. Validar que el campo no esté vacío (reemplaza 'txtUser' por el nombre real de tu TextBox en el diseñador)
            string usuarioOEmail = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(usuarioOEmail))
            {
                MessageBox.Show("Por favor, ingresa tu correo.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Desactivar el botón para evitar múltiples clics mientras procesa
                btnSent.Enabled = false;
                Cursor = Cursors.WaitCursor;

                // 2. Instanciar la capa de negocio
                var service = new S_RecuperarPassword();

                // 3. Ejecutar el método de recuperación
                string resultado = service.recoverPassword(usuarioOEmail);

                // 4. Mostrar el resultado al usuario
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restaurar el cursor y el botón
                btnSent.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Cierra esta ventana y regresa al login (o la pantalla anterior)
            this.Close();
        }
    }
}