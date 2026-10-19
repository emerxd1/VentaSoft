namespace VentaSoft
{
    public partial class Login : Form
    {
        // false = contraseña oculta (estado por defecto)
        private bool passwordVisible = false;

        public Login()
        {
            InitializeComponent();
          //  ApplyPasswordState();   // la contraseña arranca oculta
        }

      

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Mensaje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Application.Exit();
        }

        private void button_minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbPass_Click_1(object sender, EventArgs e)
        {

            passwordVisible = !passwordVisible;
           // ApplyPasswordState();
            textBox_Password.FocusTexto();   // devuelve el cursor al cuadro de texto
        }

        private void textBox_Email_TextBoxTextChanged(object sender, EventArgs e)
        {

        }
    }
}