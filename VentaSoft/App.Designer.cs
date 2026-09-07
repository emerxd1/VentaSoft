namespace Main
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            lblUsuario = new Label();
            lblusershow = new Label();
            panelBarraUp = new Panel();
            btnMax = new Button();
            btnRest = new Button();
            btnMin = new Button();
            btnExit = new Button();
            btnMenu = new PictureBox();
            PanelContenedor = new Panel();
            MenuProducto = new Button();
            pictureBox1 = new PictureBox();
            MenuAdministrar = new Button();
            MenuAbout = new Button();
            MenuEmpleados = new Button();
            MenuVentas = new Button();
            MenuProveedores = new Button();
            MenuCompras = new Button();
            MenuReportes = new Button();
            panelSubMenu = new Panel();
            btnReporteShopping = new Button();
            btnReportVent = new Button();
            MenuClientes = new Button();
            panelMenu = new Panel();
            panelBarraUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSubMenu.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuario.Location = new Point(961, 26);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 21);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "lblUsuario";
            // 
            // lblusershow
            // 
            lblusershow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblusershow.AutoSize = true;
            lblusershow.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusershow.ForeColor = SystemColors.ActiveCaptionText;
            lblusershow.Location = new Point(894, 26);
            lblusershow.Name = "lblusershow";
            lblusershow.Size = new Size(69, 21);
            lblusershow.TabIndex = 9;
            lblusershow.Text = "Usuario:";
            // 
            // panelBarraUp
            // 
            panelBarraUp.BackColor = Color.White;
            panelBarraUp.BorderStyle = BorderStyle.FixedSingle;
            panelBarraUp.Controls.Add(lblUsuario);
            panelBarraUp.Controls.Add(btnMax);
            panelBarraUp.Controls.Add(lblusershow);
            panelBarraUp.Controls.Add(btnRest);
            panelBarraUp.Controls.Add(btnMin);
            panelBarraUp.Controls.Add(btnExit);
            panelBarraUp.Controls.Add(btnMenu);
            panelBarraUp.Dock = DockStyle.Top;
            panelBarraUp.Location = new Point(250, 0);
            panelBarraUp.Name = "panelBarraUp";
            panelBarraUp.Size = new Size(1050, 50);
            panelBarraUp.TabIndex = 0;
            panelBarraUp.Paint += panelBarraUp_Paint;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = (Image)resources.GetObject("btnMax.Image");
            btnMax.Location = new Point(992, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(25, 25);
            btnMax.TabIndex = 8;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnRest
            // 
            btnRest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRest.Cursor = Cursors.Hand;
            btnRest.FlatAppearance.BorderSize = 0;
            btnRest.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnRest.FlatStyle = FlatStyle.Flat;
            btnRest.Image = (Image)resources.GetObject("btnRest.Image");
            btnRest.Location = new Point(992, 0);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(25, 25);
            btnRest.TabIndex = 7;
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Visible = false;
            btnRest.Click += btnRest_Click;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Cursor = Cursors.Hand;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = (Image)resources.GetObject("btnMin.Image");
            btnMin.Location = new Point(961, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(25, 25);
            btnMin.TabIndex = 6;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(1023, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 25);
            btnExit.TabIndex = 5;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(6, 9);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 35);
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(250, 50);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1050, 650);
            PanelContenedor.TabIndex = 1;
            // 
            // MenuProducto
            // 
            MenuProducto.Anchor = AnchorStyles.Top;
            MenuProducto.AutoSize = true;
            MenuProducto.BackColor = Color.FromArgb(0, 122, 204);
            MenuProducto.Cursor = Cursors.Hand;
            MenuProducto.FlatAppearance.BorderSize = 0;
            MenuProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuProducto.FlatStyle = FlatStyle.Flat;
            MenuProducto.Font = new Font("Century Gothic", 12F);
            MenuProducto.ForeColor = Color.White;
            MenuProducto.Image = (Image)resources.GetObject("MenuProducto.Image");
            MenuProducto.ImageAlign = ContentAlignment.MiddleLeft;
            MenuProducto.Location = new Point(0, 53);
            MenuProducto.Name = "MenuProducto";
            MenuProducto.Size = new Size(250, 54);
            MenuProducto.TabIndex = 1;
            MenuProducto.Text = "Productos";
            MenuProducto.UseVisualStyleBackColor = false;
            MenuProducto.Click += btnProducts_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MenuAdministrar
            // 
            MenuAdministrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MenuAdministrar.AutoSize = true;
            MenuAdministrar.BackColor = Color.FromArgb(0, 122, 204);
            MenuAdministrar.Cursor = Cursors.Hand;
            MenuAdministrar.FlatAppearance.BorderSize = 0;
            MenuAdministrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuAdministrar.FlatStyle = FlatStyle.Flat;
            MenuAdministrar.Font = new Font("Century Gothic", 12F);
            MenuAdministrar.ForeColor = Color.White;
            MenuAdministrar.Image = (Image)resources.GetObject("MenuAdministrar.Image");
            MenuAdministrar.ImageAlign = ContentAlignment.MiddleLeft;
            MenuAdministrar.Location = new Point(-2, 662);
            MenuAdministrar.Name = "MenuAdministrar";
            MenuAdministrar.Size = new Size(250, 38);
            MenuAdministrar.TabIndex = 8;
            MenuAdministrar.Text = "Administrar";
            MenuAdministrar.UseVisualStyleBackColor = false;
            // 
            // MenuAbout
            // 
            MenuAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MenuAbout.AutoSize = true;
            MenuAbout.BackColor = Color.FromArgb(0, 122, 204);
            MenuAbout.Cursor = Cursors.Hand;
            MenuAbout.FlatAppearance.BorderSize = 0;
            MenuAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuAbout.FlatStyle = FlatStyle.Flat;
            MenuAbout.Font = new Font("Century Gothic", 12F);
            MenuAbout.ForeColor = Color.White;
            MenuAbout.Image = (Image)resources.GetObject("MenuAbout.Image");
            MenuAbout.ImageAlign = ContentAlignment.MiddleLeft;
            MenuAbout.Location = new Point(0, 623);
            MenuAbout.Name = "MenuAbout";
            MenuAbout.Size = new Size(250, 38);
            MenuAbout.TabIndex = 9;
            MenuAbout.Text = "Acerca de";
            MenuAbout.UseVisualStyleBackColor = false;
            // 
            // MenuEmpleados
            // 
            MenuEmpleados.Anchor = AnchorStyles.Top;
            MenuEmpleados.AutoSize = true;
            MenuEmpleados.BackColor = Color.FromArgb(0, 122, 204);
            MenuEmpleados.Cursor = Cursors.Hand;
            MenuEmpleados.FlatAppearance.BorderSize = 0;
            MenuEmpleados.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuEmpleados.FlatStyle = FlatStyle.Flat;
            MenuEmpleados.Font = new Font("Century Gothic", 12F);
            MenuEmpleados.ForeColor = Color.White;
            MenuEmpleados.Image = (Image)resources.GetObject("MenuEmpleados.Image");
            MenuEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            MenuEmpleados.Location = new Point(0, 281);
            MenuEmpleados.Name = "MenuEmpleados";
            MenuEmpleados.Size = new Size(250, 55);
            MenuEmpleados.TabIndex = 6;
            MenuEmpleados.Text = "Empleados";
            MenuEmpleados.UseVisualStyleBackColor = false;
            MenuEmpleados.Click += MenuEmpleados_Click;
            // 
            // MenuVentas
            // 
            MenuVentas.Anchor = AnchorStyles.Top;
            MenuVentas.AutoSize = true;
            MenuVentas.BackColor = Color.FromArgb(0, 122, 204);
            MenuVentas.Cursor = Cursors.Hand;
            MenuVentas.FlatAppearance.BorderSize = 0;
            MenuVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuVentas.FlatStyle = FlatStyle.Flat;
            MenuVentas.Font = new Font("Century Gothic", 12F);
            MenuVentas.ForeColor = Color.White;
            MenuVentas.Image = (Image)resources.GetObject("MenuVentas.Image");
            MenuVentas.ImageAlign = ContentAlignment.MiddleLeft;
            MenuVentas.Location = new Point(0, 158);
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(250, 55);
            MenuVentas.TabIndex = 2;
            MenuVentas.Text = "Ventas";
            MenuVentas.UseVisualStyleBackColor = false;
            // 
            // MenuProveedores
            // 
            MenuProveedores.Anchor = AnchorStyles.Top;
            MenuProveedores.AutoSize = true;
            MenuProveedores.BackColor = Color.FromArgb(0, 122, 204);
            MenuProveedores.Cursor = Cursors.Hand;
            MenuProveedores.FlatAppearance.BorderSize = 0;
            MenuProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuProveedores.FlatStyle = FlatStyle.Flat;
            MenuProveedores.Font = new Font("Century Gothic", 12F);
            MenuProveedores.ForeColor = Color.White;
            MenuProveedores.Image = (Image)resources.GetObject("MenuProveedores.Image");
            MenuProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            MenuProveedores.Location = new Point(-2, 342);
            MenuProveedores.Name = "MenuProveedores";
            MenuProveedores.Size = new Size(250, 55);
            MenuProveedores.TabIndex = 5;
            MenuProveedores.Text = "Proveedores";
            MenuProveedores.UseVisualStyleBackColor = false;
            // 
            // MenuCompras
            // 
            MenuCompras.Anchor = AnchorStyles.Top;
            MenuCompras.AutoSize = true;
            MenuCompras.BackColor = Color.FromArgb(0, 122, 204);
            MenuCompras.Cursor = Cursors.Hand;
            MenuCompras.FlatAppearance.BorderSize = 0;
            MenuCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuCompras.FlatStyle = FlatStyle.Flat;
            MenuCompras.Font = new Font("Century Gothic", 12F);
            MenuCompras.ForeColor = Color.White;
            MenuCompras.Image = (Image)resources.GetObject("MenuCompras.Image");
            MenuCompras.ImageAlign = ContentAlignment.MiddleLeft;
            MenuCompras.Location = new Point(0, 220);
            MenuCompras.Name = "MenuCompras";
            MenuCompras.Size = new Size(250, 55);
            MenuCompras.TabIndex = 4;
            MenuCompras.Text = "Compras";
            MenuCompras.UseVisualStyleBackColor = false;
            // 
            // MenuReportes
            // 
            MenuReportes.Anchor = AnchorStyles.Top;
            MenuReportes.AutoSize = true;
            MenuReportes.BackColor = Color.FromArgb(0, 122, 204);
            MenuReportes.Cursor = Cursors.Hand;
            MenuReportes.FlatAppearance.BorderSize = 0;
            MenuReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuReportes.FlatStyle = FlatStyle.Flat;
            MenuReportes.Font = new Font("Century Gothic", 12F);
            MenuReportes.ForeColor = Color.White;
            MenuReportes.Image = (Image)resources.GetObject("MenuReportes.Image");
            MenuReportes.ImageAlign = ContentAlignment.MiddleLeft;
            MenuReportes.Location = new Point(-2, 403);
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(250, 55);
            MenuReportes.TabIndex = 7;
            MenuReportes.Text = "Reportes";
            MenuReportes.UseVisualStyleBackColor = false;
            MenuReportes.Click += btnReports_Click;
            // 
            // panelSubMenu
            // 
            panelSubMenu.Controls.Add(btnReporteShopping);
            panelSubMenu.Controls.Add(btnReportVent);
            panelSubMenu.Location = new Point(50, 464);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(200, 69);
            panelSubMenu.TabIndex = 10;
            panelSubMenu.Visible = false;
            panelSubMenu.Paint += panel1_Paint;
            // 
            // btnReporteShopping
            // 
            btnReporteShopping.AutoSize = true;
            btnReporteShopping.BackColor = Color.FromArgb(0, 122, 204);
            btnReporteShopping.Cursor = Cursors.Hand;
            btnReporteShopping.FlatAppearance.BorderSize = 0;
            btnReporteShopping.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnReporteShopping.FlatStyle = FlatStyle.Flat;
            btnReporteShopping.Font = new Font("Century Gothic", 12F);
            btnReporteShopping.ForeColor = Color.White;
            btnReporteShopping.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteShopping.Location = new Point(-4, 33);
            btnReporteShopping.Name = "btnReporteShopping";
            btnReporteShopping.Size = new Size(200, 35);
            btnReporteShopping.TabIndex = 11;
            btnReporteShopping.Text = "Reporte Compras";
            btnReporteShopping.UseVisualStyleBackColor = false;
            btnReporteShopping.Click += btnReporteShopping_Click;
            // 
            // btnReportVent
            // 
            btnReportVent.AutoSize = true;
            btnReportVent.BackColor = Color.FromArgb(0, 122, 204);
            btnReportVent.Cursor = Cursors.Hand;
            btnReportVent.FlatAppearance.BorderSize = 0;
            btnReportVent.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnReportVent.FlatStyle = FlatStyle.Flat;
            btnReportVent.Font = new Font("Century Gothic", 12F);
            btnReportVent.ForeColor = Color.White;
            btnReportVent.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportVent.Location = new Point(-3, -8);
            btnReportVent.Name = "btnReportVent";
            btnReportVent.Size = new Size(200, 35);
            btnReportVent.TabIndex = 10;
            btnReportVent.Text = "Reporte Ventas";
            btnReportVent.UseVisualStyleBackColor = false;
            btnReportVent.Click += btnReportVent_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.Anchor = AnchorStyles.Top;
            MenuClientes.AutoSize = true;
            MenuClientes.BackColor = Color.FromArgb(0, 122, 204);
            MenuClientes.Cursor = Cursors.Hand;
            MenuClientes.FlatAppearance.BorderSize = 0;
            MenuClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            MenuClientes.FlatStyle = FlatStyle.Flat;
            MenuClientes.Font = new Font("Century Gothic", 12F);
            MenuClientes.ForeColor = Color.White;
            MenuClientes.Image = (Image)resources.GetObject("MenuClientes.Image");
            MenuClientes.ImageAlign = ContentAlignment.MiddleLeft;
            MenuClientes.Location = new Point(0, 111);
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(250, 55);
            MenuClientes.TabIndex = 3;
            MenuClientes.Text = "Clientes";
            MenuClientes.UseVisualStyleBackColor = false;
            MenuClientes.Click += MenuClientes_Click;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(MenuProducto);
            panelMenu.Controls.Add(MenuClientes);
            panelMenu.Controls.Add(panelSubMenu);
            panelMenu.Controls.Add(MenuReportes);
            panelMenu.Controls.Add(MenuCompras);
            panelMenu.Controls.Add(MenuProveedores);
            panelMenu.Controls.Add(MenuVentas);
            panelMenu.Controls.Add(MenuEmpleados);
            panelMenu.Controls.Add(MenuAbout);
            panelMenu.Controls.Add(MenuAdministrar);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 700);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 700);
            Controls.Add(PanelContenedor);
            Controls.Add(panelBarraUp);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            Load += App_Load;
            panelBarraUp.ResumeLayout(false);
            panelBarraUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSubMenu.ResumeLayout(false);
            panelSubMenu.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBarraUp;
        private PictureBox btnMenu;
        private Panel PanelContenedor;
        private Button btnMax;
        private Button btnRest;
        private Button btnMin;
        private Button btnExit;
        private Label lblusershow;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Button MenuProducto;
        private Button MenuAdministrar;
        private Button MenuAbout;
        private Button MenuEmpleados;
        private Button MenuVentas;
        private Button MenuProveedores;
        private Button MenuCompras;
        private Button MenuReportes;
        private Panel panelSubMenu;
        private Button btnReporteShopping;
        private Button btnReportVent;
        private Button MenuClientes;
        private Panel panelMenu;
    }
}