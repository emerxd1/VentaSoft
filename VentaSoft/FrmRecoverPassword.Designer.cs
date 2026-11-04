namespace Main
{
    partial class FrmRecoverPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecoverPassword));
            pictureBox1 = new PictureBox();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            txtEmail = new Sunny.UI.UITextBox();
            label7 = new Label();
            btnSent = new Sunny.UI.UISymbolButton();
            btnBack = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 118);
            label1.Name = "label1";
            label1.Size = new Size(244, 31);
            label1.TabIndex = 1;
            label1.Text = "Recuperar Contraseña";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 155);
            label2.Name = "label2";
            label2.Size = new Size(418, 48);
            label2.TabIndex = 2;
            label2.Text = "Ingresa tu correo electrónico y te enviaremos un enlace para restablecer tu contraseña.";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(52, 243);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.Radius = 10;
            txtEmail.RectColor = Color.Silver;
            txtEmail.ScrollBarBackColor = Color.IndianRed;
            txtEmail.ScrollBarColor = Color.FromArgb(192, 0, 0);
            txtEmail.ScrollBarStyleInherited = false;
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(397, 43);
            txtEmail.Style = Sunny.UI.UIStyle.Custom;
            txtEmail.Symbol = 57462;
            txtEmail.SymbolColor = Color.FromArgb(20, 81, 59);
            txtEmail.TabIndex = 22;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Ingrese su correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(18, 24, 38);
            label7.Location = new Point(52, 219);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 21;
            label7.Text = "Correo electronico";
            // 
            // btnSent
            // 
            btnSent.FillColor = Color.FromArgb(11, 127, 87);
            btnSent.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnSent.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnSent.FillPressColor = Color.Silver;
            btnSent.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSent.Location = new Point(52, 318);
            btnSent.MinimumSize = new Size(1, 1);
            btnSent.Name = "btnSent";
            btnSent.Radius = 10;
            btnSent.RectColor = Color.White;
            btnSent.RectDisableColor = Color.White;
            btnSent.RectHoverColor = Color.White;
            btnSent.RectPressColor = Color.White;
            btnSent.RectSelectedColor = Color.White;
            btnSent.ShowFocusLine = true;
            btnSent.Size = new Size(397, 45);
            btnSent.Style = Sunny.UI.UIStyle.Custom;
            btnSent.Symbol = 57451;
            btnSent.SymbolOffset = new Point(0, 2);
            btnSent.TabIndex = 24;
            btnSent.Text = "Recuperar Contraseña";
            btnSent.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSent.Click += btnSent_Click;
            // 
            // btnBack
            // 
            btnBack.FillColor = Color.White;
            btnBack.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnBack.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnBack.FillPressColor = Color.Silver;
            btnBack.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(57, 79, 71);
            btnBack.ForePressColor = Color.Black;
            btnBack.Location = new Point(52, 384);
            btnBack.MinimumSize = new Size(1, 1);
            btnBack.Name = "btnBack";
            btnBack.Radius = 15;
            btnBack.RectColor = Color.Silver;
            btnBack.RectDisableColor = Color.White;
            btnBack.RectHoverColor = Color.White;
            btnBack.RectPressColor = Color.Silver;
            btnBack.RectSelectedColor = Color.White;
            btnBack.ShowFocusLine = true;
            btnBack.Size = new Size(397, 42);
            btnBack.Style = Sunny.UI.UIStyle.Custom;
            btnBack.Symbol = 558820;
            btnBack.SymbolColor = Color.FromArgb(57, 79, 71);
            btnBack.TabIndex = 83;
            btnBack.Text = "Volver al Login";
            btnBack.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnBack.Click += btnBack_Click;
            // 
            // FrmRecoverPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(516, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSent);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRecoverPassword";
            Text = "Recuperar Contraseña";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private Sunny.UI.UITextBox txtEmail;
        private Label label7;
        private Sunny.UI.UISymbolButton btnSent;
        private Sunny.UI.UISymbolButton btnBack;
    }
}