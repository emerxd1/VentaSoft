namespace Main
{
    partial class LoginM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginM));
            panel1 = new AntdUI.Panel();
            btnMin = new Sunny.UI.UISymbolButton();
            BtnClose = new Sunny.UI.UISymbolButton();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            btnLogin = new Sunny.UI.UISymbolButton();
            textBox_Password = new Sunny.UI.UITextBox();
            label8 = new Label();
            textBox_Email = new Sunny.UI.UITextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Back = Color.White;
            panel1.BackColor = Color.Transparent;
            panel1.BadgeBack = Color.AliceBlue;
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(BtnClose);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox_Email);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Radius = 10;
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(884, 521);
            panel1.TabIndex = 1;
            panel1.Text = "Developed by \"Los algoritmicos\"";
            panel1.Click += panel1_Click;
            // 
            // btnMin
            // 
            btnMin.Cursor = Cursors.Hand;
            btnMin.FillColor = Color.White;
            btnMin.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnMin.FillHoverColor = Color.FromArgb(224, 224, 224);
            btnMin.FillPressColor = Color.Silver;
            btnMin.FillSelectedColor = Color.White;
            btnMin.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMin.Location = new Point(818, 0);
            btnMin.MinimumSize = new Size(1, 1);
            btnMin.Name = "btnMin";
            btnMin.Radius = 0;
            btnMin.RectColor = Color.White;
            btnMin.RectDisableColor = Color.White;
            btnMin.RectHoverColor = Color.White;
            btnMin.RectPressColor = Color.White;
            btnMin.RectSelectedColor = Color.White;
            btnMin.Size = new Size(30, 30);
            btnMin.Style = Sunny.UI.UIStyle.Custom;
            btnMin.Symbol = 61544;
            btnMin.SymbolColor = Color.Gray;
            btnMin.SymbolDisableColor = Color.Silver;
            btnMin.SymbolHoverColor = Color.Black;
            btnMin.SymbolPressColor = Color.Red;
            btnMin.TabIndex = 27;
            btnMin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnMin.Click += btnMin_Click;
            // 
            // BtnClose
            // 
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.FillColor = Color.White;
            BtnClose.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnClose.FillHoverColor = Color.White;
            BtnClose.FillPressColor = Color.White;
            BtnClose.FillSelectedColor = Color.White;
            BtnClose.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClose.Location = new Point(854, 0);
            BtnClose.MinimumSize = new Size(1, 1);
            BtnClose.Name = "BtnClose";
            BtnClose.Radius = 0;
            BtnClose.RectColor = Color.White;
            BtnClose.RectDisableColor = Color.White;
            BtnClose.RectHoverColor = Color.FromArgb(255, 128, 128);
            BtnClose.RectPressColor = Color.Red;
            BtnClose.RectSelectedColor = Color.White;
            BtnClose.Size = new Size(30, 30);
            BtnClose.Style = Sunny.UI.UIStyle.Custom;
            BtnClose.Symbol = 61453;
            BtnClose.SymbolColor = Color.Gray;
            BtnClose.SymbolHoverColor = Color.FromArgb(255, 128, 128);
            BtnClose.SymbolPressColor = Color.Red;
            BtnClose.TabIndex = 26;
            BtnClose.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnClose.Click += uiSymbolButton5_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(8, 92, 63);
            linkLabel1.Location = new Point(680, 404);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 15);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Olvidaste tu contraseña?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(501, 493);
            label5.Name = "label5";
            label5.Size = new Size(223, 19);
            label5.TabIndex = 24;
            label5.Text = "Developed by \"Los Algoritmicos\"";
            // 
            // btnLogin
            // 
            btnLogin.FillColor = Color.FromArgb(11, 127, 87);
            btnLogin.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnLogin.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnLogin.FillPressColor = Color.Silver;
            btnLogin.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(430, 346);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 10;
            btnLogin.RectColor = Color.White;
            btnLogin.RectDisableColor = Color.White;
            btnLogin.RectHoverColor = Color.White;
            btnLogin.RectPressColor = Color.White;
            btnLogin.RectSelectedColor = Color.White;
            btnLogin.ShowFocusLine = true;
            btnLogin.Size = new Size(397, 45);
            btnLogin.Style = Sunny.UI.UIStyle.Custom;
            btnLogin.Symbol = 61584;
            btnLogin.SymbolOffset = new Point(135, 2);
            btnLogin.TabIndex = 23;
            btnLogin.Text = "Iniciar sesion";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox_Password
            // 
            textBox_Password.ButtonFillColor = Color.White;
            textBox_Password.ButtonFillHoverColor = Color.Transparent;
            textBox_Password.ButtonFillPressColor = Color.White;
            textBox_Password.ButtonForeColor = Color.Gray;
            textBox_Password.ButtonForeHoverColor = Color.Gray;
            textBox_Password.ButtonForePressColor = Color.Black;
            textBox_Password.ButtonRectColor = Color.Transparent;
            textBox_Password.ButtonRectHoverColor = Color.White;
            textBox_Password.ButtonRectPressColor = Color.White;
            textBox_Password.ButtonStyleInherited = false;
            textBox_Password.ButtonSymbol = 61550;
            textBox_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Password.Location = new Point(430, 263);
            textBox_Password.Margin = new Padding(4, 5, 4, 5);
            textBox_Password.MinimumSize = new Size(1, 16);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Padding = new Padding(5);
            textBox_Password.PasswordChar = '*';
            textBox_Password.Radius = 10;
            textBox_Password.RectColor = Color.Silver;
            textBox_Password.ScrollBarBackColor = Color.FromArgb(192, 255, 192);
            textBox_Password.ScrollBarColor = Color.FromArgb(192, 255, 192);
            textBox_Password.ScrollBarStyleInherited = false;
            textBox_Password.ShowButton = true;
            textBox_Password.ShowText = false;
            textBox_Password.Size = new Size(397, 43);
            textBox_Password.Style = Sunny.UI.UIStyle.Custom;
            textBox_Password.Symbol = 61475;
            textBox_Password.SymbolColor = Color.FromArgb(20, 81, 59);
            textBox_Password.TabIndex = 22;
            textBox_Password.TextAlignment = ContentAlignment.MiddleLeft;
            textBox_Password.Watermark = "Ingrese su contraseña";
            textBox_Password.ButtonClick += textBox_Password_ButtonClick;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            textBox_Password.KeyDown += textBox_Password_KeyDown;
            textBox_Password.Leave += textBox_Password_Leave;
            textBox_Password.Enter += textBox_Password_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(18, 24, 38);
            label8.Location = new Point(430, 239);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 21;
            label8.Text = "Contraseña";
            // 
            // textBox_Email
            // 
            textBox_Email.Font = new Font("Microsoft Sans Serif", 12F);
            textBox_Email.Location = new Point(430, 175);
            textBox_Email.Margin = new Padding(4, 5, 4, 5);
            textBox_Email.MinimumSize = new Size(1, 16);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Padding = new Padding(5);
            textBox_Email.Radius = 10;
            textBox_Email.RectColor = Color.Silver;
            textBox_Email.ScrollBarBackColor = Color.IndianRed;
            textBox_Email.ScrollBarColor = Color.FromArgb(192, 0, 0);
            textBox_Email.ScrollBarStyleInherited = false;
            textBox_Email.ShowText = false;
            textBox_Email.Size = new Size(397, 43);
            textBox_Email.Style = Sunny.UI.UIStyle.Custom;
            textBox_Email.Symbol = 61447;
            textBox_Email.SymbolColor = Color.FromArgb(20, 81, 59);
            textBox_Email.TabIndex = 20;
            textBox_Email.TextAlignment = ContentAlignment.MiddleLeft;
            textBox_Email.Watermark = "Ingrese su correo o nombre de usuario";
            textBox_Email.KeyDown += textBox_Email_KeyDown;
            textBox_Email.Leave += textBox_Email_Leave;
            textBox_Email.Enter += uiTextBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(18, 24, 38);
            label7.Location = new Point(430, 151);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 19;
            label7.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(18, 24, 38);
            label6.Location = new Point(430, 105);
            label6.Name = "label6";
            label6.Size = new Size(226, 17);
            label6.TabIndex = 13;
            label6.Text = "Inicia sesion para ingresar a tu panel.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(18, 24, 38);
            label4.Location = new Point(425, 66);
            label4.Name = "label4";
            label4.Size = new Size(278, 36);
            label4.TabIndex = 9;
            label4.Text = "Bienvenido de nuevo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 46, 34);
            panel2.Controls.Add(uiSymbolButton1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(uiSymbolButton4);
            panel2.Controls.Add(uiSymbolButton2);
            panel2.Controls.Add(uiSymbolButton3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 521);
            panel2.TabIndex = 4;
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Enabled = false;
            uiSymbolButton1.FillColor = Color.FromArgb(20, 81, 59);
            uiSymbolButton1.FillColor2 = Color.Transparent;
            uiSymbolButton1.FillColorGradient = true;
            uiSymbolButton1.FillDisableColor = Color.FromArgb(20, 81, 59);
            uiSymbolButton1.FillHoverColor = Color.Transparent;
            uiSymbolButton1.FillPressColor = Color.Transparent;
            uiSymbolButton1.FillSelectedColor = Color.Transparent;
            uiSymbolButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton1.ForeColor = Color.Transparent;
            uiSymbolButton1.ForeDisableColor = Color.Transparent;
            uiSymbolButton1.ForeHoverColor = Color.Transparent;
            uiSymbolButton1.ForePressColor = Color.Transparent;
            uiSymbolButton1.ForeSelectedColor = Color.Transparent;
            uiSymbolButton1.IsCircle = true;
            uiSymbolButton1.LightColor = Color.Transparent;
            uiSymbolButton1.Location = new Point(14, 309);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.RectColor = Color.Transparent;
            uiSymbolButton1.RectDisableColor = Color.Transparent;
            uiSymbolButton1.RectHoverColor = Color.Transparent;
            uiSymbolButton1.RectPressColor = Color.Transparent;
            uiSymbolButton1.RectSelectedColor = Color.Transparent;
            uiSymbolButton1.Size = new Size(111, 276);
            uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton1.Symbol = 61447;
            uiSymbolButton1.SymbolColor = Color.Transparent;
            uiSymbolButton1.SymbolDisableColor = Color.Transparent;
            uiSymbolButton1.SymbolHoverColor = Color.Transparent;
            uiSymbolButton1.SymbolPressColor = Color.Transparent;
            uiSymbolButton1.SymbolSelectedColor = Color.Transparent;
            uiSymbolButton1.SymbolSize = 0;
            uiSymbolButton1.TabIndex = 2;
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 31);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 4;
            label1.Text = "VentaSoft";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(181, 220, 201);
            label3.Location = new Point(14, 239);
            label3.Name = "label3";
            label3.Size = new Size(322, 51);
            label3.TabIndex = 6;
            label3.Text = "Ingresa con tu cuenta para continuar donde lo dejaste.";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(215, 149);
            label2.TabIndex = 5;
            label2.Text = "Gestiona tu pulperia con claridad.";
            // 
            // uiSymbolButton4
            // 
            uiSymbolButton4.Enabled = false;
            uiSymbolButton4.FillColor = Color.FromArgb(20, 81, 59);
            uiSymbolButton4.FillColor2 = Color.Transparent;
            uiSymbolButton4.FillColorGradient = true;
            uiSymbolButton4.FillDisableColor = Color.FromArgb(20, 81, 59);
            uiSymbolButton4.FillHoverColor = Color.Transparent;
            uiSymbolButton4.FillPressColor = Color.Transparent;
            uiSymbolButton4.FillSelectedColor = Color.Transparent;
            uiSymbolButton4.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton4.ForeColor = Color.Transparent;
            uiSymbolButton4.ForeDisableColor = Color.Transparent;
            uiSymbolButton4.ForeHoverColor = Color.Transparent;
            uiSymbolButton4.ForePressColor = Color.Transparent;
            uiSymbolButton4.ForeSelectedColor = Color.Transparent;
            uiSymbolButton4.IsCircle = true;
            uiSymbolButton4.LightColor = Color.Transparent;
            uiSymbolButton4.Location = new Point(241, 124);
            uiSymbolButton4.MinimumSize = new Size(1, 1);
            uiSymbolButton4.Name = "uiSymbolButton4";
            uiSymbolButton4.RectColor = Color.Transparent;
            uiSymbolButton4.RectDisableColor = Color.Transparent;
            uiSymbolButton4.RectHoverColor = Color.Transparent;
            uiSymbolButton4.RectPressColor = Color.Transparent;
            uiSymbolButton4.RectSelectedColor = Color.Transparent;
            uiSymbolButton4.Size = new Size(95, 94);
            uiSymbolButton4.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton4.Symbol = 61447;
            uiSymbolButton4.SymbolColor = Color.Transparent;
            uiSymbolButton4.SymbolDisableColor = Color.Transparent;
            uiSymbolButton4.SymbolHoverColor = Color.Transparent;
            uiSymbolButton4.SymbolPressColor = Color.Transparent;
            uiSymbolButton4.SymbolSelectedColor = Color.Transparent;
            uiSymbolButton4.SymbolSize = 0;
            uiSymbolButton4.TabIndex = 8;
            uiSymbolButton4.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton2
            // 
            uiSymbolButton2.Enabled = false;
            uiSymbolButton2.FillColor = Color.FromArgb(11, 127, 87);
            uiSymbolButton2.FillColor2 = Color.Transparent;
            uiSymbolButton2.FillColorGradient = true;
            uiSymbolButton2.FillDisableColor = Color.FromArgb(11, 127, 87);
            uiSymbolButton2.FillHoverColor = Color.Transparent;
            uiSymbolButton2.FillPressColor = Color.Transparent;
            uiSymbolButton2.FillSelectedColor = Color.Transparent;
            uiSymbolButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton2.ForeColor = Color.Transparent;
            uiSymbolButton2.ForeDisableColor = Color.Transparent;
            uiSymbolButton2.ForeHoverColor = Color.Transparent;
            uiSymbolButton2.ForePressColor = Color.Transparent;
            uiSymbolButton2.ForeSelectedColor = Color.Transparent;
            uiSymbolButton2.IsCircle = true;
            uiSymbolButton2.LightColor = Color.Transparent;
            uiSymbolButton2.Location = new Point(288, 4);
            uiSymbolButton2.MinimumSize = new Size(1, 1);
            uiSymbolButton2.Name = "uiSymbolButton2";
            uiSymbolButton2.RectColor = Color.Transparent;
            uiSymbolButton2.RectDisableColor = Color.Transparent;
            uiSymbolButton2.RectHoverColor = Color.Transparent;
            uiSymbolButton2.RectPressColor = Color.Transparent;
            uiSymbolButton2.RectSelectedColor = Color.Transparent;
            uiSymbolButton2.Size = new Size(80, 114);
            uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton2.Symbol = 61447;
            uiSymbolButton2.SymbolColor = Color.Transparent;
            uiSymbolButton2.SymbolDisableColor = Color.Transparent;
            uiSymbolButton2.SymbolHoverColor = Color.Transparent;
            uiSymbolButton2.SymbolPressColor = Color.Transparent;
            uiSymbolButton2.SymbolSelectedColor = Color.Transparent;
            uiSymbolButton2.SymbolSize = 0;
            uiSymbolButton2.TabIndex = 3;
            uiSymbolButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiSymbolButton3
            // 
            uiSymbolButton3.Enabled = false;
            uiSymbolButton3.FillColor = Color.FromArgb(11, 127, 87);
            uiSymbolButton3.FillColor2 = Color.Transparent;
            uiSymbolButton3.FillColorGradient = true;
            uiSymbolButton3.FillDisableColor = Color.FromArgb(11, 127, 87);
            uiSymbolButton3.FillHoverColor = Color.Transparent;
            uiSymbolButton3.FillPressColor = Color.Transparent;
            uiSymbolButton3.FillSelectedColor = Color.Transparent;
            uiSymbolButton3.Font = new Font("Microsoft Sans Serif", 12F);
            uiSymbolButton3.ForeColor = Color.Transparent;
            uiSymbolButton3.ForeDisableColor = Color.Transparent;
            uiSymbolButton3.ForeHoverColor = Color.Transparent;
            uiSymbolButton3.ForePressColor = Color.Transparent;
            uiSymbolButton3.ForeSelectedColor = Color.Transparent;
            uiSymbolButton3.IsCircle = true;
            uiSymbolButton3.LightColor = Color.Transparent;
            uiSymbolButton3.Location = new Point(165, 256);
            uiSymbolButton3.MinimumSize = new Size(1, 1);
            uiSymbolButton3.Name = "uiSymbolButton3";
            uiSymbolButton3.RectColor = Color.Transparent;
            uiSymbolButton3.RectDisableColor = Color.Transparent;
            uiSymbolButton3.RectHoverColor = Color.Transparent;
            uiSymbolButton3.RectPressColor = Color.Transparent;
            uiSymbolButton3.RectSelectedColor = Color.Transparent;
            uiSymbolButton3.Size = new Size(287, 377);
            uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton3.Symbol = 61447;
            uiSymbolButton3.SymbolColor = Color.Transparent;
            uiSymbolButton3.SymbolDisableColor = Color.Transparent;
            uiSymbolButton3.SymbolHoverColor = Color.Transparent;
            uiSymbolButton3.SymbolPressColor = Color.Transparent;
            uiSymbolButton3.SymbolSelectedColor = Color.Transparent;
            uiSymbolButton3.SymbolSize = 0;
            uiSymbolButton3.TabIndex = 7;
            uiSymbolButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // LoginM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 521);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginM";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Label label6;
        private Label label4;
        private Label label7;
        private Sunny.UI.UITextBox textBox_Email;
        private Sunny.UI.UITextBox textBox_Password;
        private Label label8;
        private Sunny.UI.UISymbolButton btnLogin;
        private Label label5;
        private LinkLabel linkLabel1;
        private Sunny.UI.UISymbolButton BtnClose;
        private Sunny.UI.UISymbolButton btnMin;
        private PictureBox pictureBox1;
    }
}