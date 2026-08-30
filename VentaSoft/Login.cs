namespace VentaSoft
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox_Email_Enter(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "Email")
            {
                textBox_Email.Text = "";
                textBox_Email.ForeColor = Color.Black;
            }
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "")
            {
                textBox_Email.Text = "Email";
                textBox_Email.ForeColor = Color.Black;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Password")
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.UseSystemPasswordChar = true;
            }

        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.Text = "Password";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.UseSystemPasswordChar = false;
            }
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
