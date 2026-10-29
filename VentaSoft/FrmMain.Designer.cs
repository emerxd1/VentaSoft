namespace Main
{
    partial class FrmMain
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
            AntdUI.HyperlinkLabel.LinkAppearance linkAppearance3 = new AntdUI.HyperlinkLabel.LinkAppearance();
            AntdUI.HyperlinkLabel.LinkAppearance linkAppearance4 = new AntdUI.HyperlinkLabel.LinkAppearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Header = new Panel();
            label2 = new Label();
            lblRol = new Label();
            label1 = new Label();
            lblUsuario = new Label();
            btnMenu = new Sunny.UI.UISymbolButton();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            PanelContenedor = new Panel();
            SubMenuReports = new FlowLayoutPanel();
            panel1 = new Panel();
            btnReportes = new Sunny.UI.UISymbolButton();
            panel12 = new Panel();
            btnReporteVentas = new Sunny.UI.UISymbolButton();
            panel13 = new Panel();
            BtnReporteCompra = new Sunny.UI.UISymbolButton();
            SubmenuVentas = new FlowLayoutPanel();
            panel7 = new Panel();
            btnVentas = new Sunny.UI.UISymbolButton();
            panel6 = new Panel();
            btnDetallesVentas = new Sunny.UI.UISymbolButton();
            panel15 = new Panel();
            BtnAboutme = new Sunny.UI.UISymbolButton();
            submenuCompras = new FlowLayoutPanel();
            panel10 = new Panel();
            btnCompras = new Sunny.UI.UISymbolButton();
            panel11 = new Panel();
            Btndetallecompras = new Sunny.UI.UISymbolButton();
            panel9 = new Panel();
            btnProveedores = new Sunny.UI.UISymbolButton();
            panel8 = new Panel();
            btnEmpleados = new Sunny.UI.UISymbolButton();
            panel4 = new Panel();
            btnProducts = new Sunny.UI.UISymbolButton();
            panel3 = new Panel();
            btnCategorias = new Sunny.UI.UISymbolButton();
            panel5 = new Panel();
            btnClientes = new Sunny.UI.UISymbolButton();
            panel2 = new Panel();
            btnHome = new Sunny.UI.UISymbolButton();
            PanelMenu = new FlowLayoutPanel();
            panel16 = new Panel();
            lblVentasoft = new AntdUI.HyperlinkLabel();
            IconVS = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel14 = new Panel();
            btnAjustes = new Sunny.UI.UISymbolButton();
            Header.SuspendLayout();
            SubMenuReports.SuspendLayout();
            panel1.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SubmenuVentas.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel15.SuspendLayout();
            submenuCompras.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            PanelMenu.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconVS).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.White;
            Header.Controls.Add(label2);
            Header.Controls.Add(lblRol);
            Header.Controls.Add(label1);
            Header.Controls.Add(lblUsuario);
            Header.Controls.Add(btnMenu);
            Header.Controls.Add(nightControlBox1);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(190, 0);
            Header.Name = "Header";
            Header.Size = new Size(1176, 44);
            Header.TabIndex = 0;
            Header.Paint += Header_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 14);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 29;
            label2.Text = "Menu";
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.Right;
            lblRol.AutoSize = true;
            lblRol.Location = new Point(951, 23);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(38, 15);
            lblRol.TabIndex = 28;
            lblRol.Text = "label1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(932, 5);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 27;
            label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(988, 7);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 26;
            lblUsuario.Text = "label1";
            // 
            // btnMenu
            // 
            btnMenu.FillColor = Color.White;
            btnMenu.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnMenu.FillHoverColor = Color.FromArgb(11, 127, 87);
            btnMenu.FillPressColor = Color.Silver;
            btnMenu.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(3, 5);
            btnMenu.MinimumSize = new Size(1, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Radius = 10;
            btnMenu.RectColor = Color.White;
            btnMenu.RectDisableColor = Color.White;
            btnMenu.RectHoverColor = Color.White;
            btnMenu.RectPressColor = Color.White;
            btnMenu.RectSelectedColor = Color.White;
            btnMenu.ShowFocusLine = true;
            btnMenu.Size = new Size(27, 35);
            btnMenu.Style = Sunny.UI.UIStyle.Custom;
            btnMenu.Symbol = 61641;
            btnMenu.SymbolColor = Color.FromArgb(11, 46, 34);
            btnMenu.TabIndex = 24;
            btnMenu.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnMenu.Click += btnMenu_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1037, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.Black;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.Black;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            nightControlBox1.Click += nightControlBox1_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(190, 44);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1176, 744);
            PanelContenedor.TabIndex = 34;
            // 
            // SubMenuReports
            // 
            SubMenuReports.Controls.Add(panel1);
            SubMenuReports.Controls.Add(panel12);
            SubMenuReports.Controls.Add(panel13);
            SubMenuReports.FlowDirection = FlowDirection.RightToLeft;
            SubMenuReports.Location = new Point(3, 417);
            SubMenuReports.Name = "SubMenuReports";
            SubMenuReports.Size = new Size(190, 32);
            SubMenuReports.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReportes);
            panel1.Location = new Point(-13, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 40);
            panel1.TabIndex = 34;
            // 
            // btnReportes
            // 
            btnReportes.FillColor = Color.FromArgb(11, 46, 34);
            btnReportes.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnReportes.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnReportes.FillPressColor = Color.Silver;
            btnReportes.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(-6, -21);
            btnReportes.MinimumSize = new Size(1, 1);
            btnReportes.Name = "btnReportes";
            btnReportes.Radius = 10;
            btnReportes.RectColor = Color.White;
            btnReportes.RectDisableColor = Color.White;
            btnReportes.RectHoverColor = Color.White;
            btnReportes.RectPressColor = Color.White;
            btnReportes.RectSelectedColor = Color.White;
            btnReportes.ShowFocusLine = true;
            btnReportes.Size = new Size(216, 78);
            btnReportes.Style = Sunny.UI.UIStyle.Custom;
            btnReportes.Symbol = 362829;
            btnReportes.SymbolOffset = new Point(20, 0);
            btnReportes.SymbolSize = 30;
            btnReportes.TabIndex = 25;
            btnReportes.Text = "Reportes";
            btnReportes.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReportes.Click += btnReportes_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnReporteVentas);
            panel12.Location = new Point(-13, 49);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 32);
            panel12.TabIndex = 35;
            // 
            // btnReporteVentas
            // 
            btnReporteVentas.FillColor = Color.FromArgb(11, 46, 34);
            btnReporteVentas.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnReporteVentas.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnReporteVentas.FillPressColor = Color.Silver;
            btnReporteVentas.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteVentas.Location = new Point(-6, -21);
            btnReporteVentas.MinimumSize = new Size(1, 1);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Radius = 10;
            btnReporteVentas.RectColor = Color.White;
            btnReporteVentas.RectDisableColor = Color.White;
            btnReporteVentas.RectHoverColor = Color.White;
            btnReporteVentas.RectPressColor = Color.White;
            btnReporteVentas.RectSelectedColor = Color.White;
            btnReporteVentas.ShowFocusLine = true;
            btnReporteVentas.Size = new Size(216, 78);
            btnReporteVentas.Style = Sunny.UI.UIStyle.Custom;
            btnReporteVentas.Symbol = 0;
            btnReporteVentas.SymbolSize = 30;
            btnReporteVentas.TabIndex = 25;
            btnReporteVentas.Text = "Reporte de Ventas";
            btnReporteVentas.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReporteVentas.Click += btnReporteVentas_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(BtnReporteCompra);
            panel13.Location = new Point(-13, 87);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 32);
            panel13.TabIndex = 36;
            // 
            // BtnReporteCompra
            // 
            BtnReporteCompra.FillColor = Color.FromArgb(11, 46, 34);
            BtnReporteCompra.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnReporteCompra.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnReporteCompra.FillPressColor = Color.Silver;
            BtnReporteCompra.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReporteCompra.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReporteCompra.Location = new Point(-6, -21);
            BtnReporteCompra.MinimumSize = new Size(1, 1);
            BtnReporteCompra.Name = "BtnReporteCompra";
            BtnReporteCompra.Radius = 10;
            BtnReporteCompra.RectColor = Color.White;
            BtnReporteCompra.RectDisableColor = Color.White;
            BtnReporteCompra.RectHoverColor = Color.White;
            BtnReporteCompra.RectPressColor = Color.White;
            BtnReporteCompra.RectSelectedColor = Color.White;
            BtnReporteCompra.ShowFocusLine = true;
            BtnReporteCompra.Size = new Size(216, 78);
            BtnReporteCompra.Style = Sunny.UI.UIStyle.Custom;
            BtnReporteCompra.Symbol = 0;
            BtnReporteCompra.SymbolOffset = new Point(5, 0);
            BtnReporteCompra.SymbolSize = 30;
            BtnReporteCompra.TabIndex = 25;
            BtnReporteCompra.Text = "Reporte de compras";
            BtnReporteCompra.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnReporteCompra.Click += BtnReporteCompra_Click_1;
            // 
            // SubmenuVentas
            // 
            SubmenuVentas.Controls.Add(panel7);
            SubmenuVentas.Controls.Add(panel6);
            SubmenuVentas.Location = new Point(3, 371);
            SubmenuVentas.Name = "SubmenuVentas";
            SubmenuVentas.Size = new Size(190, 40);
            SubmenuVentas.TabIndex = 29;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnVentas);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 40);
            panel7.TabIndex = 30;
            // 
            // btnVentas
            // 
            btnVentas.FillColor = Color.FromArgb(11, 46, 34);
            btnVentas.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnVentas.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnVentas.FillPressColor = Color.Silver;
            btnVentas.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(-6, -21);
            btnVentas.MinimumSize = new Size(1, 1);
            btnVentas.Name = "btnVentas";
            btnVentas.Radius = 10;
            btnVentas.RectColor = Color.White;
            btnVentas.RectDisableColor = Color.White;
            btnVentas.RectHoverColor = Color.White;
            btnVentas.RectPressColor = Color.White;
            btnVentas.RectSelectedColor = Color.White;
            btnVentas.ShowFocusLine = true;
            btnVentas.Size = new Size(216, 78);
            btnVentas.Style = Sunny.UI.UIStyle.Custom;
            btnVentas.Symbol = 61562;
            btnVentas.SymbolOffset = new Point(5, 0);
            btnVentas.SymbolSize = 30;
            btnVentas.TabIndex = 25;
            btnVentas.Text = "Ventas";
            btnVentas.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnVentas.Click += FrmSales_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDetallesVentas);
            panel6.Location = new Point(3, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 32);
            panel6.TabIndex = 29;
            // 
            // btnDetallesVentas
            // 
            btnDetallesVentas.FillColor = Color.FromArgb(11, 46, 34);
            btnDetallesVentas.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnDetallesVentas.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnDetallesVentas.FillPressColor = Color.Silver;
            btnDetallesVentas.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetallesVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetallesVentas.Location = new Point(-8, -21);
            btnDetallesVentas.MinimumSize = new Size(1, 1);
            btnDetallesVentas.Name = "btnDetallesVentas";
            btnDetallesVentas.Padding = new Padding(10, 0, 0, 0);
            btnDetallesVentas.Radius = 10;
            btnDetallesVentas.RectColor = Color.White;
            btnDetallesVentas.RectDisableColor = Color.White;
            btnDetallesVentas.RectHoverColor = Color.White;
            btnDetallesVentas.RectPressColor = Color.White;
            btnDetallesVentas.RectSelectedColor = Color.White;
            btnDetallesVentas.ShowFocusLine = true;
            btnDetallesVentas.Size = new Size(216, 78);
            btnDetallesVentas.Style = Sunny.UI.UIStyle.Custom;
            btnDetallesVentas.Symbol = 0;
            btnDetallesVentas.SymbolOffset = new Point(5, 0);
            btnDetallesVentas.SymbolSize = 30;
            btnDetallesVentas.TabIndex = 25;
            btnDetallesVentas.Text = "Detalles de Ventas";
            btnDetallesVentas.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDetallesVentas.Click += btnDetallesVentas_Click;
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Bottom;
            panel15.Controls.Add(BtnAboutme);
            panel15.Location = new Point(3, 224);
            panel15.Name = "panel15";
            panel15.Size = new Size(190, 40);
            panel15.TabIndex = 30;
            // 
            // BtnAboutme
            // 
            BtnAboutme.FillColor = Color.FromArgb(11, 46, 34);
            BtnAboutme.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnAboutme.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnAboutme.FillPressColor = Color.Silver;
            BtnAboutme.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAboutme.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAboutme.Location = new Point(-4, -20);
            BtnAboutme.MinimumSize = new Size(1, 1);
            BtnAboutme.Name = "BtnAboutme";
            BtnAboutme.Radius = 10;
            BtnAboutme.RectColor = Color.White;
            BtnAboutme.RectDisableColor = Color.White;
            BtnAboutme.RectHoverColor = Color.White;
            BtnAboutme.RectPressColor = Color.White;
            BtnAboutme.RectSelectedColor = Color.White;
            BtnAboutme.ShowFocusLine = true;
            BtnAboutme.Size = new Size(213, 78);
            BtnAboutme.Style = Sunny.UI.UIStyle.Custom;
            BtnAboutme.Symbol = 361530;
            BtnAboutme.SymbolSize = 30;
            BtnAboutme.TabIndex = 25;
            BtnAboutme.Text = "Sobre Nosotros";
            BtnAboutme.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // submenuCompras
            // 
            submenuCompras.Controls.Add(panel10);
            submenuCompras.Controls.Add(panel11);
            submenuCompras.FlowDirection = FlowDirection.RightToLeft;
            submenuCompras.Location = new Point(3, 325);
            submenuCompras.Name = "submenuCompras";
            submenuCompras.Size = new Size(190, 40);
            submenuCompras.TabIndex = 31;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnCompras);
            panel10.Location = new Point(0, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(187, 40);
            panel10.TabIndex = 30;
            // 
            // btnCompras
            // 
            btnCompras.FillColor = Color.FromArgb(11, 46, 34);
            btnCompras.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnCompras.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnCompras.FillPressColor = Color.Silver;
            btnCompras.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(-3, -21);
            btnCompras.MinimumSize = new Size(1, 1);
            btnCompras.Name = "btnCompras";
            btnCompras.Radius = 10;
            btnCompras.RectColor = Color.White;
            btnCompras.RectDisableColor = Color.White;
            btnCompras.RectHoverColor = Color.White;
            btnCompras.RectPressColor = Color.White;
            btnCompras.RectSelectedColor = Color.White;
            btnCompras.ShowFocusLine = true;
            btnCompras.Size = new Size(213, 78);
            btnCompras.Style = Sunny.UI.UIStyle.Custom;
            btnCompras.Symbol = 62096;
            btnCompras.SymbolOffset = new Point(5, 0);
            btnCompras.SymbolSize = 30;
            btnCompras.TabIndex = 25;
            btnCompras.Text = "Compras";
            btnCompras.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCompras.Click += btnCompras_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(Btndetallecompras);
            panel11.Location = new Point(-10, 49);
            panel11.Name = "panel11";
            panel11.Size = new Size(197, 32);
            panel11.TabIndex = 29;
            // 
            // Btndetallecompras
            // 
            Btndetallecompras.FillColor = Color.FromArgb(11, 46, 34);
            Btndetallecompras.FillDisableColor = Color.FromArgb(224, 224, 224);
            Btndetallecompras.FillHoverColor = Color.FromArgb(8, 92, 63);
            Btndetallecompras.FillPressColor = Color.Silver;
            Btndetallecompras.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btndetallecompras.ImageAlign = ContentAlignment.MiddleLeft;
            Btndetallecompras.Location = new Point(-3, -21);
            Btndetallecompras.MinimumSize = new Size(1, 1);
            Btndetallecompras.Name = "Btndetallecompras";
            Btndetallecompras.Padding = new Padding(10, 0, 0, 0);
            Btndetallecompras.Radius = 10;
            Btndetallecompras.RectColor = Color.White;
            Btndetallecompras.RectDisableColor = Color.White;
            Btndetallecompras.RectHoverColor = Color.White;
            Btndetallecompras.RectPressColor = Color.White;
            Btndetallecompras.RectSelectedColor = Color.White;
            Btndetallecompras.ShowFocusLine = true;
            Btndetallecompras.Size = new Size(190, 78);
            Btndetallecompras.Style = Sunny.UI.UIStyle.Custom;
            Btndetallecompras.Symbol = 0;
            Btndetallecompras.SymbolSize = 30;
            Btndetallecompras.TabIndex = 25;
            Btndetallecompras.Text = "Detalles de Compras";
            Btndetallecompras.TipsFont = new Font("Microsoft Sans Serif", 9F);
            Btndetallecompras.Click += Btndetallecompras_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnProveedores);
            panel9.Location = new Point(3, 279);
            panel9.Name = "panel9";
            panel9.Size = new Size(190, 40);
            panel9.TabIndex = 31;
            // 
            // btnProveedores
            // 
            btnProveedores.FillColor = Color.FromArgb(11, 46, 34);
            btnProveedores.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnProveedores.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnProveedores.FillPressColor = Color.Silver;
            btnProveedores.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedores.Location = new Point(-4, -20);
            btnProveedores.MinimumSize = new Size(1, 1);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Radius = 10;
            btnProveedores.RectColor = Color.White;
            btnProveedores.RectDisableColor = Color.White;
            btnProveedores.RectHoverColor = Color.White;
            btnProveedores.RectPressColor = Color.White;
            btnProveedores.RectSelectedColor = Color.White;
            btnProveedores.ShowFocusLine = true;
            btnProveedores.Size = new Size(213, 78);
            btnProveedores.Style = Sunny.UI.UIStyle.Custom;
            btnProveedores.Symbol = 358763;
            btnProveedores.SymbolOffset = new Point(5, 0);
            btnProveedores.SymbolSize = 30;
            btnProveedores.TabIndex = 25;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnProveedores.Click += btnProveedores_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnEmpleados);
            panel8.Location = new Point(3, 233);
            panel8.Name = "panel8";
            panel8.Size = new Size(190, 40);
            panel8.TabIndex = 30;
            // 
            // btnEmpleados
            // 
            btnEmpleados.FillColor = Color.FromArgb(11, 46, 34);
            btnEmpleados.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnEmpleados.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnEmpleados.FillPressColor = Color.Silver;
            btnEmpleados.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(-4, -20);
            btnEmpleados.MinimumSize = new Size(1, 1);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Radius = 10;
            btnEmpleados.RectColor = Color.White;
            btnEmpleados.RectDisableColor = Color.White;
            btnEmpleados.RectHoverColor = Color.White;
            btnEmpleados.RectPressColor = Color.White;
            btnEmpleados.RectSelectedColor = Color.White;
            btnEmpleados.ShowFocusLine = true;
            btnEmpleados.Size = new Size(213, 78);
            btnEmpleados.Style = Sunny.UI.UIStyle.Custom;
            btnEmpleados.Symbol = 361632;
            btnEmpleados.SymbolOffset = new Point(5, 0);
            btnEmpleados.SymbolSize = 30;
            btnEmpleados.TabIndex = 25;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProducts);
            panel4.Location = new Point(3, 187);
            panel4.Name = "panel4";
            panel4.Size = new Size(190, 40);
            panel4.TabIndex = 27;
            // 
            // btnProducts
            // 
            btnProducts.FillColor = Color.FromArgb(11, 46, 34);
            btnProducts.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnProducts.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnProducts.FillPressColor = Color.Silver;
            btnProducts.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(-4, -20);
            btnProducts.MinimumSize = new Size(1, 1);
            btnProducts.Name = "btnProducts";
            btnProducts.Radius = 10;
            btnProducts.RectColor = Color.White;
            btnProducts.RectDisableColor = Color.White;
            btnProducts.RectHoverColor = Color.White;
            btnProducts.RectPressColor = Color.White;
            btnProducts.RectSelectedColor = Color.White;
            btnProducts.ShowFocusLine = true;
            btnProducts.Size = new Size(213, 78);
            btnProducts.Style = Sunny.UI.UIStyle.Custom;
            btnProducts.Symbol = 557809;
            btnProducts.SymbolOffset = new Point(5, 0);
            btnProducts.SymbolSize = 30;
            btnProducts.TabIndex = 25;
            btnProducts.Text = "Productos";
            btnProducts.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnProducts.Click += btnProducts_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCategorias);
            panel3.Location = new Point(3, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 40);
            panel3.TabIndex = 26;
            // 
            // btnCategorias
            // 
            btnCategorias.FillColor = Color.FromArgb(11, 46, 34);
            btnCategorias.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnCategorias.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnCategorias.FillPressColor = Color.Silver;
            btnCategorias.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(-4, -20);
            btnCategorias.MinimumSize = new Size(1, 1);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Radius = 10;
            btnCategorias.RectColor = Color.White;
            btnCategorias.RectDisableColor = Color.White;
            btnCategorias.RectHoverColor = Color.White;
            btnCategorias.RectPressColor = Color.White;
            btnCategorias.RectSelectedColor = Color.White;
            btnCategorias.ShowFocusLine = true;
            btnCategorias.Size = new Size(216, 78);
            btnCategorias.Style = Sunny.UI.UIStyle.Custom;
            btnCategorias.Symbol = 560361;
            btnCategorias.SymbolOffset = new Point(5, 0);
            btnCategorias.SymbolSize = 30;
            btnCategorias.TabIndex = 25;
            btnCategorias.Text = "Categorias";
            btnCategorias.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCategorias.Click += btnCategorias_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnClientes);
            panel5.Location = new Point(3, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 40);
            panel5.TabIndex = 28;
            // 
            // btnClientes
            // 
            btnClientes.FillColor = Color.FromArgb(11, 46, 34);
            btnClientes.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnClientes.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnClientes.FillPressColor = Color.Silver;
            btnClientes.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(-4, -20);
            btnClientes.MinimumSize = new Size(1, 1);
            btnClientes.Name = "btnClientes";
            btnClientes.Radius = 10;
            btnClientes.RectColor = Color.White;
            btnClientes.RectDisableColor = Color.White;
            btnClientes.RectHoverColor = Color.White;
            btnClientes.RectPressColor = Color.White;
            btnClientes.RectSelectedColor = Color.White;
            btnClientes.ShowFocusLine = true;
            btnClientes.Size = new Size(213, 78);
            btnClientes.Style = Sunny.UI.UIStyle.Custom;
            btnClientes.Symbol = 358769;
            btnClientes.SymbolOffset = new Point(5, 0);
            btnClientes.SymbolSize = 30;
            btnClientes.TabIndex = 25;
            btnClientes.Text = "Clientes";
            btnClientes.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClientes.Click += btnClientes_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 40);
            panel2.TabIndex = 3;
            // 
            // btnHome
            // 
            btnHome.FillColor = Color.FromArgb(11, 46, 34);
            btnHome.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnHome.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnHome.FillPressColor = Color.Silver;
            btnHome.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-4, -21);
            btnHome.MinimumSize = new Size(1, 1);
            btnHome.Name = "btnHome";
            btnHome.Radius = 10;
            btnHome.RectColor = Color.White;
            btnHome.RectDisableColor = Color.White;
            btnHome.RectHoverColor = Color.White;
            btnHome.RectPressColor = Color.White;
            btnHome.RectSelectedColor = Color.White;
            btnHome.ShowFocusLine = true;
            btnHome.Size = new Size(216, 78);
            btnHome.Style = Sunny.UI.UIStyle.Custom;
            btnHome.Symbol = 61461;
            btnHome.SymbolOffset = new Point(5, 0);
            btnHome.SymbolSize = 30;
            btnHome.TabIndex = 25;
            btnHome.Text = "Inicio";
            btnHome.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnHome.Click += btnHome_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(11, 46, 34);
            PanelMenu.Controls.Add(panel16);
            PanelMenu.Controls.Add(panel2);
            PanelMenu.Controls.Add(panel5);
            PanelMenu.Controls.Add(panel3);
            PanelMenu.Controls.Add(panel4);
            PanelMenu.Controls.Add(panel8);
            PanelMenu.Controls.Add(panel9);
            PanelMenu.Controls.Add(submenuCompras);
            PanelMenu.Controls.Add(SubmenuVentas);
            PanelMenu.Controls.Add(SubMenuReports);
            PanelMenu.Controls.Add(flowLayoutPanel1);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.FlowDirection = FlowDirection.TopDown;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(190, 788);
            PanelMenu.TabIndex = 33;
            PanelMenu.Paint += PanelMenu_Paint;
            // 
            // panel16
            // 
            panel16.Controls.Add(lblVentasoft);
            panel16.Controls.Add(IconVS);
            panel16.Location = new Point(3, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(190, 40);
            panel16.TabIndex = 26;
            // 
            // lblVentasoft
            // 
            lblVentasoft.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVentasoft.ForeColor = Color.White;
            lblVentasoft.HoverStyle = linkAppearance3;
            lblVentasoft.Location = new Point(58, 9);
            lblVentasoft.Name = "lblVentasoft";
            linkAppearance4.LinkStyle = FontStyle.Bold;
            lblVentasoft.NormalStyle = linkAppearance4;
            lblVentasoft.Size = new Size(96, 23);
            lblVentasoft.TabIndex = 26;
            lblVentasoft.Text = "VentaSoft";
            // 
            // IconVS
            // 
            IconVS.Image = (Image)resources.GetObject("IconVS.Image");
            IconVS.Location = new Point(0, -3);
            IconVS.Name = "IconVS";
            IconVS.Size = new Size(41, 43);
            IconVS.SizeMode = PictureBoxSizeMode.Zoom;
            IconVS.TabIndex = 0;
            IconVS.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel15);
            flowLayoutPanel1.Controls.Add(panel14);
            PanelMenu.SetFlowBreak(flowLayoutPanel1, true);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(3, 455);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(187, 267);
            flowLayoutPanel1.TabIndex = 31;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Bottom;
            panel14.Controls.Add(btnAjustes);
            panel14.Location = new Point(3, 178);
            panel14.Name = "panel14";
            panel14.Size = new Size(190, 40);
            panel14.TabIndex = 29;
            // 
            // btnAjustes
            // 
            btnAjustes.FillColor = Color.FromArgb(11, 46, 34);
            btnAjustes.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnAjustes.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnAjustes.FillPressColor = Color.Silver;
            btnAjustes.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjustes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjustes.Location = new Point(-4, -20);
            btnAjustes.MinimumSize = new Size(1, 1);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Radius = 10;
            btnAjustes.RectColor = Color.White;
            btnAjustes.RectDisableColor = Color.White;
            btnAjustes.RectHoverColor = Color.White;
            btnAjustes.RectPressColor = Color.White;
            btnAjustes.RectSelectedColor = Color.White;
            btnAjustes.ShowFocusLine = true;
            btnAjustes.Size = new Size(213, 78);
            btnAjustes.Style = Sunny.UI.UIStyle.Custom;
            btnAjustes.Symbol = 559576;
            btnAjustes.SymbolSize = 30;
            btnAjustes.TabIndex = 25;
            btnAjustes.Text = "Ajustes";
            btnAjustes.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 788);
            Controls.Add(PanelContenedor);
            Controls.Add(Header);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            Text = "FrmMain";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            SubMenuReports.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            SubmenuVentas.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel15.ResumeLayout(false);
            submenuCompras.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            PanelMenu.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconVS).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel14.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Sunny.UI.UISymbolButton btnMenu;
        private Panel PanelContenedor;
        private FlowLayoutPanel SubMenuReports;
        private Panel panel1;
        private Sunny.UI.UISymbolButton btnReportes;
        private Panel panel12;
        private Sunny.UI.UISymbolButton btnReporteVentas;
        private Panel panel13;
        private Sunny.UI.UISymbolButton BtnReporteCompra;
        private FlowLayoutPanel submenuCompras;
        private Panel panel10;
        private Sunny.UI.UISymbolButton btnCompras;
        private Panel panel11;
        private Sunny.UI.UISymbolButton Btndetallecompras;
        private FlowLayoutPanel SubmenuVentas;
        private Panel panel7;
        private Sunny.UI.UISymbolButton btnVentas;
        private Panel panel6;
        private Sunny.UI.UISymbolButton btnDetallesVentas;
        private Panel panel9;
        private Sunny.UI.UISymbolButton btnProveedores;
        private Panel panel8;
        private Sunny.UI.UISymbolButton btnEmpleados;
        private Panel panel4;
        private Sunny.UI.UISymbolButton btnProducts;
        private Panel panel3;
        private Sunny.UI.UISymbolButton btnCategorias;
        private Panel panel5;
        private Sunny.UI.UISymbolButton btnClientes;
        private Panel panel2;
        private Sunny.UI.UISymbolButton btnHome;
        private FlowLayoutPanel PanelMenu;
        private Panel panel15;
        private Sunny.UI.UISymbolButton BtnAboutme;
        private Label lblRol;
        private Label label1;
        private Label lblUsuario;
        private Panel panel14;
        private Sunny.UI.UISymbolButton btnAjustes;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel16;
        private PictureBox IconVS;
        private AntdUI.HyperlinkLabel lblVentasoft;
        private Label label2;
    }
}