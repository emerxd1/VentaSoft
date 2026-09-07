using Main;
using ModuloEntidades;
using Data;

namespace VentaSoft
{
    public partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            textBox_Password = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            textBox_Email = new TextBox();
            linkLabelPass = new LinkLabel();
            button_exit = new Button();
            button_minimize = new Button();
            panel1 = new Panel();
            pbPass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPass).BeginInit();
            SuspendLayout();
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            sqlConnection1.SspiContextProvider = null;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = Color.White;
            textBox_Password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password.ForeColor = Color.Silver;
            textBox_Password.Location = new Point(69, 355);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(322, 27);
            textBox_Password.TabIndex = 2;
            textBox_Password.Text = "Password";
            textBox_Password.Enter += textBox_Password_Enter;
            textBox_Password.Leave += textBox_Password_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 61);
            label1.Name = "label1";
            label1.Size = new Size(177, 42);
            label1.TabIndex = 0;
            label1.Text = "VentaSoft";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 227);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 3;
            label2.Text = "Welcome Back";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 275);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(31, 350);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(39, 459);
            button1.Name = "button1";
            button1.Size = new Size(360, 37);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(133, 617);
            label3.Name = "label3";
            label3.Size = new Size(184, 15);
            label3.TabIndex = 11;
            label3.Text = "Developed by: \"Los Algoritmicos\"";
            // 
            // textBox_Email
            // 
            textBox_Email.BackColor = Color.White;
            textBox_Email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Email.ForeColor = Color.Silver;
            textBox_Email.Location = new Point(69, 280);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(319, 27);
            textBox_Email.TabIndex = 1;
            textBox_Email.Text = "Email";
            textBox_Email.Enter += textBox_Email_Enter;
            textBox_Email.Leave += textBox_Email_Leave;
            // 
            // linkLabelPass
            // 
            linkLabelPass.AutoSize = true;
            linkLabelPass.Location = new Point(261, 397);
            linkLabelPass.Name = "linkLabelPass";
            linkLabelPass.Size = new Size(127, 15);
            linkLabelPass.TabIndex = 0;
            linkLabelPass.TabStop = true;
            linkLabelPass.Text = "Forgot yout Password?";
            // 
            // button_exit
            // 
            button_exit.Cursor = Cursors.Hand;
            button_exit.FlatAppearance.BorderColor = Color.White;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Image = (Image)resources.GetObject("button_exit.Image");
            button_exit.Location = new Point(388, 34);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(25, 25);
            button_exit.TabIndex = 12;
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_minimize
            // 
            button_minimize.Cursor = Cursors.Hand;
            button_minimize.FlatAppearance.BorderColor = Color.White;
            button_minimize.FlatAppearance.BorderSize = 0;
            button_minimize.FlatAppearance.MouseDownBackColor = Color.White;
            button_minimize.FlatAppearance.MouseOverBackColor = Color.Silver;
            button_minimize.FlatStyle = FlatStyle.Flat;
            button_minimize.Image = (Image)resources.GetObject("button_minimize.Image");
            button_minimize.Location = new Point(355, 30);
            button_minimize.Name = "button_minimize";
            button_minimize.Size = new Size(25, 25);
            button_minimize.TabIndex = 13;
            button_minimize.UseVisualStyleBackColor = true;
            button_minimize.Click += button_minimize_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbPass);
            panel1.Controls.Add(button_minimize);
            panel1.Controls.Add(button_exit);
            panel1.Controls.Add(linkLabelPass);
            panel1.Controls.Add(textBox_Email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_Password);
            panel1.Location = new Point(-26, -32);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 684);
            panel1.TabIndex = 0;
            // 
            // pbPass
            // 
            pbPass.BackgroundImageLayout = ImageLayout.None;
            pbPass.Cursor = Cursors.Hand;
            pbPass.Image = (Image)resources.GetObject("pbPass.Image");
            pbPass.Location = new Point(373, 358);
            pbPass.Name = "pbPass";
            pbPass.Size = new Size(20, 20);
            pbPass.SizeMode = PictureBoxSizeMode.Zoom;
            pbPass.TabIndex = 14;
            pbPass.TabStop = false;
            pbPass.Click += pictureBox4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(390, 609);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPass).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidad_Usuario O_user = new D_Users().Lister()
                .Where(u => u.Correo == textBox_Email.Text && u.Clave == textBox_Password.Text)
                .FirstOrDefault();

            if (O_user != null)
            {
                this.Hide(); // ocultar login

                App mtr = new App(O_user);
                mtr.FormClosed += (s, args) =>
                {
                    textBox_Email.Clear();
                    textBox_Password.Clear();
                    this.Show();      // volver a mostrar el login
                    this.Activate();  // traerlo al frente
                };
                mtr.Show();
            }
            else
            {
                MessageBox.Show("Email o contraseña incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Email.Clear();
                textBox_Password.Clear();
            }
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox textBox_Password;
        private Label label1;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label3;
        private TextBox textBox_Email;
        private LinkLabel linkLabelPass;
        private Button button_exit;
        private Button button_minimize;
        private Panel panel1;
        private PictureBox pbPass;
    }
}
