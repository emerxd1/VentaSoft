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
            MenuReportes = new Sunny.UI.UISymbolButton();
            panel12 = new Panel();
            btnReporteVentas = new Sunny.UI.UISymbolButton();
            panel13 = new Panel();
            BtnReporteCompra = new Sunny.UI.UISymbolButton();
            SubmenuVentas = new FlowLayoutPanel();
            panel7 = new Panel();
            MenuVentas = new Sunny.UI.UISymbolButton();
            panel6 = new Panel();
            btnDetallesVentas = new Sunny.UI.UISymbolButton();
            panel15 = new Panel();
            MenuAbout = new Sunny.UI.UISymbolButton();
            submenuCompras = new FlowLayoutPanel();
            panel10 = new Panel();
            MenuCompras = new Sunny.UI.UISymbolButton();
            panel11 = new Panel();
            Btndetallecompras = new Sunny.UI.UISymbolButton();
            panel9 = new Panel();
            MenuProveedores = new Sunny.UI.UISymbolButton();
            panel8 = new Panel();
            MenuEmpleados = new Sunny.UI.UISymbolButton();
            panel4 = new Panel();
            MenuProducto = new Sunny.UI.UISymbolButton();
            panel3 = new Panel();
            MenuCategory = new Sunny.UI.UISymbolButton();
            panel5 = new Panel();
            MenuClientes = new Sunny.UI.UISymbolButton();
            panel2 = new Panel();
            MenuHome = new Sunny.UI.UISymbolButton();
            PanelMenu = new FlowLayoutPanel();
            panel16 = new Panel();
            lblVentasoft = new AntdUI.HyperlinkLabel();
            IconVS = new PictureBox();
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
            Header.Location = new Point(238, 0);
            Header.Margin = new Padding(4);
            Header.Name = "Header";
            Header.Size = new Size(1470, 55);
            Header.TabIndex = 0;
            Header.Paint += Header_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 18);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 29;
            label2.Text = "Menu";
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.Right;
            lblRol.AutoSize = true;
            lblRol.Location = new Point(1189, 29);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(50, 20);
            lblRol.TabIndex = 28;
            lblRol.Text = "label1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1165, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 27;
            label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(1235, 9);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 20);
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
            btnMenu.Location = new Point(4, 6);
            btnMenu.Margin = new Padding(4);
            btnMenu.MinimumSize = new Size(1, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Radius = 10;
            btnMenu.RectColor = Color.White;
            btnMenu.RectDisableColor = Color.White;
            btnMenu.RectHoverColor = Color.White;
            btnMenu.RectPressColor = Color.White;
            btnMenu.RectSelectedColor = Color.White;
            btnMenu.ShowFocusLine = true;
            btnMenu.Size = new Size(34, 44);
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
            nightControlBox1.Location = new Point(1331, 0);
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
            PanelContenedor.Location = new Point(238, 55);
            PanelContenedor.Margin = new Padding(4);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1470, 930);
            PanelContenedor.TabIndex = 34;
            // 
            // SubMenuReports
            // 
            SubMenuReports.Controls.Add(panel1);
            SubMenuReports.Controls.Add(panel12);
            SubMenuReports.Controls.Add(panel13);
            SubMenuReports.FlowDirection = FlowDirection.RightToLeft;
            SubMenuReports.Location = new Point(4, 526);
            SubMenuReports.Margin = new Padding(4);
            SubMenuReports.Name = "SubMenuReports";
            SubMenuReports.Size = new Size(238, 40);
            SubMenuReports.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.Controls.Add(MenuReportes);
            panel1.Location = new Point(-16, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 50);
            panel1.TabIndex = 34;
            // 
            // MenuReportes
            // 
            MenuReportes.FillColor = Color.FromArgb(11, 46, 34);
            MenuReportes.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuReportes.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuReportes.FillPressColor = Color.Silver;
            MenuReportes.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuReportes.ImageAlign = ContentAlignment.MiddleLeft;
            MenuReportes.Location = new Point(-8, -26);
            MenuReportes.Margin = new Padding(4);
            MenuReportes.MinimumSize = new Size(1, 1);
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Radius = 10;
            MenuReportes.RectColor = Color.White;
            MenuReportes.RectDisableColor = Color.White;
            MenuReportes.RectHoverColor = Color.White;
            MenuReportes.RectPressColor = Color.White;
            MenuReportes.RectSelectedColor = Color.White;
            MenuReportes.ShowFocusLine = true;
            MenuReportes.Size = new Size(270, 98);
            MenuReportes.Style = Sunny.UI.UIStyle.Custom;
            MenuReportes.Symbol = 362829;
            MenuReportes.SymbolOffset = new Point(20, 0);
            MenuReportes.SymbolSize = 30;
            MenuReportes.TabIndex = 25;
            MenuReportes.Text = "Reportes";
            MenuReportes.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuReportes.Click += btnReportes_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnReporteVentas);
            panel12.Location = new Point(-16, 62);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(250, 40);
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
            btnReporteVentas.Location = new Point(-8, -26);
            btnReporteVentas.Margin = new Padding(4);
            btnReporteVentas.MinimumSize = new Size(1, 1);
            btnReporteVentas.Name = "btnReporteVentas";
            btnReporteVentas.Radius = 10;
            btnReporteVentas.RectColor = Color.White;
            btnReporteVentas.RectDisableColor = Color.White;
            btnReporteVentas.RectHoverColor = Color.White;
            btnReporteVentas.RectPressColor = Color.White;
            btnReporteVentas.RectSelectedColor = Color.White;
            btnReporteVentas.ShowFocusLine = true;
            btnReporteVentas.Size = new Size(270, 98);
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
            panel13.Location = new Point(-16, 110);
            panel13.Margin = new Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new Size(250, 40);
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
            BtnReporteCompra.Location = new Point(-8, -26);
            BtnReporteCompra.Margin = new Padding(4);
            BtnReporteCompra.MinimumSize = new Size(1, 1);
            BtnReporteCompra.Name = "BtnReporteCompra";
            BtnReporteCompra.Radius = 10;
            BtnReporteCompra.RectColor = Color.White;
            BtnReporteCompra.RectDisableColor = Color.White;
            BtnReporteCompra.RectHoverColor = Color.White;
            BtnReporteCompra.RectPressColor = Color.White;
            BtnReporteCompra.RectSelectedColor = Color.White;
            BtnReporteCompra.ShowFocusLine = true;
            BtnReporteCompra.Size = new Size(270, 98);
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
            SubmenuVentas.Location = new Point(4, 468);
            SubmenuVentas.Margin = new Padding(4);
            SubmenuVentas.Name = "SubmenuVentas";
            SubmenuVentas.Size = new Size(238, 50);
            SubmenuVentas.TabIndex = 29;
            // 
            // panel7
            // 
            panel7.Controls.Add(MenuVentas);
            panel7.Location = new Point(4, 4);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 50);
            panel7.TabIndex = 30;
            // 
            // MenuVentas
            // 
            MenuVentas.FillColor = Color.FromArgb(11, 46, 34);
            MenuVentas.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuVentas.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuVentas.FillPressColor = Color.Silver;
            MenuVentas.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuVentas.ImageAlign = ContentAlignment.MiddleLeft;
            MenuVentas.Location = new Point(-8, -26);
            MenuVentas.Margin = new Padding(4);
            MenuVentas.MinimumSize = new Size(1, 1);
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Radius = 10;
            MenuVentas.RectColor = Color.White;
            MenuVentas.RectDisableColor = Color.White;
            MenuVentas.RectHoverColor = Color.White;
            MenuVentas.RectPressColor = Color.White;
            MenuVentas.RectSelectedColor = Color.White;
            MenuVentas.ShowFocusLine = true;
            MenuVentas.Size = new Size(270, 98);
            MenuVentas.Style = Sunny.UI.UIStyle.Custom;
            MenuVentas.Symbol = 61562;
            MenuVentas.SymbolOffset = new Point(5, 0);
            MenuVentas.SymbolSize = 30;
            MenuVentas.TabIndex = 25;
            MenuVentas.Text = "Ventas";
            MenuVentas.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuVentas.Click += FrmSales_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnDetallesVentas);
            panel6.Location = new Point(4, 62);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 40);
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
            btnDetallesVentas.Location = new Point(-10, -26);
            btnDetallesVentas.Margin = new Padding(4);
            btnDetallesVentas.MinimumSize = new Size(1, 1);
            btnDetallesVentas.Name = "btnDetallesVentas";
            btnDetallesVentas.Padding = new Padding(12, 0, 0, 0);
            btnDetallesVentas.Radius = 10;
            btnDetallesVentas.RectColor = Color.White;
            btnDetallesVentas.RectDisableColor = Color.White;
            btnDetallesVentas.RectHoverColor = Color.White;
            btnDetallesVentas.RectPressColor = Color.White;
            btnDetallesVentas.RectSelectedColor = Color.White;
            btnDetallesVentas.ShowFocusLine = true;
            btnDetallesVentas.Size = new Size(270, 98);
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
            panel15.Controls.Add(MenuAbout);
            panel15.Location = new Point(4, 574);
            panel15.Margin = new Padding(4);
            panel15.Name = "panel15";
            panel15.Size = new Size(238, 50);
            panel15.TabIndex = 30;
            // 
            // MenuAbout
            // 
            MenuAbout.FillColor = Color.FromArgb(11, 46, 34);
            MenuAbout.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuAbout.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuAbout.FillPressColor = Color.Silver;
            MenuAbout.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuAbout.ImageAlign = ContentAlignment.MiddleLeft;
            MenuAbout.Location = new Point(-5, -25);
            MenuAbout.Margin = new Padding(4);
            MenuAbout.MinimumSize = new Size(1, 1);
            MenuAbout.Name = "MenuAbout";
            MenuAbout.Radius = 10;
            MenuAbout.RectColor = Color.White;
            MenuAbout.RectDisableColor = Color.White;
            MenuAbout.RectHoverColor = Color.White;
            MenuAbout.RectPressColor = Color.White;
            MenuAbout.RectSelectedColor = Color.White;
            MenuAbout.ShowFocusLine = true;
            MenuAbout.Size = new Size(266, 98);
            MenuAbout.Style = Sunny.UI.UIStyle.Custom;
            MenuAbout.Symbol = 361530;
            MenuAbout.SymbolSize = 30;
            MenuAbout.TabIndex = 25;
            MenuAbout.Text = "Sobre Nosotros";
            MenuAbout.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // submenuCompras
            // 
            submenuCompras.Controls.Add(panel10);
            submenuCompras.Controls.Add(panel11);
            submenuCompras.FlowDirection = FlowDirection.RightToLeft;
            submenuCompras.Location = new Point(4, 410);
            submenuCompras.Margin = new Padding(4);
            submenuCompras.Name = "submenuCompras";
            submenuCompras.Size = new Size(238, 50);
            submenuCompras.TabIndex = 31;
            // 
            // panel10
            // 
            panel10.Controls.Add(MenuCompras);
            panel10.Location = new Point(0, 4);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(234, 50);
            panel10.TabIndex = 30;
            // 
            // MenuCompras
            // 
            MenuCompras.FillColor = Color.FromArgb(11, 46, 34);
            MenuCompras.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuCompras.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuCompras.FillPressColor = Color.Silver;
            MenuCompras.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuCompras.ImageAlign = ContentAlignment.MiddleLeft;
            MenuCompras.Location = new Point(-4, -26);
            MenuCompras.Margin = new Padding(4);
            MenuCompras.MinimumSize = new Size(1, 1);
            MenuCompras.Name = "MenuCompras";
            MenuCompras.Radius = 10;
            MenuCompras.RectColor = Color.White;
            MenuCompras.RectDisableColor = Color.White;
            MenuCompras.RectHoverColor = Color.White;
            MenuCompras.RectPressColor = Color.White;
            MenuCompras.RectSelectedColor = Color.White;
            MenuCompras.ShowFocusLine = true;
            MenuCompras.Size = new Size(266, 98);
            MenuCompras.Style = Sunny.UI.UIStyle.Custom;
            MenuCompras.Symbol = 62096;
            MenuCompras.SymbolOffset = new Point(5, 0);
            MenuCompras.SymbolSize = 30;
            MenuCompras.TabIndex = 25;
            MenuCompras.Text = "Compras";
            MenuCompras.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuCompras.Click += btnCompras_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(Btndetallecompras);
            panel11.Location = new Point(-12, 62);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(246, 40);
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
            Btndetallecompras.Location = new Point(9, -26);
            Btndetallecompras.Margin = new Padding(4);
            Btndetallecompras.MinimumSize = new Size(1, 1);
            Btndetallecompras.Name = "Btndetallecompras";
            Btndetallecompras.Padding = new Padding(12, 0, 0, 0);
            Btndetallecompras.Radius = 10;
            Btndetallecompras.RectColor = Color.White;
            Btndetallecompras.RectDisableColor = Color.White;
            Btndetallecompras.RectHoverColor = Color.White;
            Btndetallecompras.RectPressColor = Color.White;
            Btndetallecompras.RectSelectedColor = Color.White;
            Btndetallecompras.ShowFocusLine = true;
            Btndetallecompras.Size = new Size(238, 98);
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
            panel9.Controls.Add(MenuProveedores);
            panel9.Location = new Point(4, 352);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(238, 50);
            panel9.TabIndex = 31;
            // 
            // MenuProveedores
            // 
            MenuProveedores.FillColor = Color.FromArgb(11, 46, 34);
            MenuProveedores.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuProveedores.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuProveedores.FillPressColor = Color.Silver;
            MenuProveedores.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            MenuProveedores.Location = new Point(-5, -25);
            MenuProveedores.Margin = new Padding(4);
            MenuProveedores.MinimumSize = new Size(1, 1);
            MenuProveedores.Name = "MenuProveedores";
            MenuProveedores.Radius = 10;
            MenuProveedores.RectColor = Color.White;
            MenuProveedores.RectDisableColor = Color.White;
            MenuProveedores.RectHoverColor = Color.White;
            MenuProveedores.RectPressColor = Color.White;
            MenuProveedores.RectSelectedColor = Color.White;
            MenuProveedores.ShowFocusLine = true;
            MenuProveedores.Size = new Size(266, 98);
            MenuProveedores.Style = Sunny.UI.UIStyle.Custom;
            MenuProveedores.Symbol = 358763;
            MenuProveedores.SymbolOffset = new Point(5, 0);
            MenuProveedores.SymbolSize = 30;
            MenuProveedores.TabIndex = 25;
            MenuProveedores.Text = "Proveedores";
            MenuProveedores.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuProveedores.Click += btnProveedores_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(MenuEmpleados);
            panel8.Location = new Point(4, 294);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(238, 50);
            panel8.TabIndex = 30;
            // 
            // MenuEmpleados
            // 
            MenuEmpleados.FillColor = Color.FromArgb(11, 46, 34);
            MenuEmpleados.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuEmpleados.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuEmpleados.FillPressColor = Color.Silver;
            MenuEmpleados.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            MenuEmpleados.Location = new Point(-5, -25);
            MenuEmpleados.Margin = new Padding(4);
            MenuEmpleados.MinimumSize = new Size(1, 1);
            MenuEmpleados.Name = "MenuEmpleados";
            MenuEmpleados.Radius = 10;
            MenuEmpleados.RectColor = Color.White;
            MenuEmpleados.RectDisableColor = Color.White;
            MenuEmpleados.RectHoverColor = Color.White;
            MenuEmpleados.RectPressColor = Color.White;
            MenuEmpleados.RectSelectedColor = Color.White;
            MenuEmpleados.ShowFocusLine = true;
            MenuEmpleados.Size = new Size(266, 98);
            MenuEmpleados.Style = Sunny.UI.UIStyle.Custom;
            MenuEmpleados.Symbol = 361632;
            MenuEmpleados.SymbolOffset = new Point(5, 0);
            MenuEmpleados.SymbolSize = 30;
            MenuEmpleados.TabIndex = 25;
            MenuEmpleados.Text = "Empleados";
            MenuEmpleados.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuEmpleados.Click += btnEmpleados_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(MenuProducto);
            panel4.Location = new Point(4, 236);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 50);
            panel4.TabIndex = 27;
            // 
            // MenuProducto
            // 
            MenuProducto.FillColor = Color.FromArgb(11, 46, 34);
            MenuProducto.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuProducto.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuProducto.FillPressColor = Color.Silver;
            MenuProducto.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuProducto.ImageAlign = ContentAlignment.MiddleLeft;
            MenuProducto.Location = new Point(-5, -25);
            MenuProducto.Margin = new Padding(4);
            MenuProducto.MinimumSize = new Size(1, 1);
            MenuProducto.Name = "MenuProducto";
            MenuProducto.Radius = 10;
            MenuProducto.RectColor = Color.White;
            MenuProducto.RectDisableColor = Color.White;
            MenuProducto.RectHoverColor = Color.White;
            MenuProducto.RectPressColor = Color.White;
            MenuProducto.RectSelectedColor = Color.White;
            MenuProducto.ShowFocusLine = true;
            MenuProducto.Size = new Size(266, 98);
            MenuProducto.Style = Sunny.UI.UIStyle.Custom;
            MenuProducto.Symbol = 557809;
            MenuProducto.SymbolOffset = new Point(5, 0);
            MenuProducto.SymbolSize = 30;
            MenuProducto.TabIndex = 25;
            MenuProducto.Text = "Productos";
            MenuProducto.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuProducto.Click += btnProducts_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(MenuCategory);
            panel3.Location = new Point(4, 178);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 50);
            panel3.TabIndex = 26;
            // 
            // MenuCategory
            // 
            MenuCategory.FillColor = Color.FromArgb(11, 46, 34);
            MenuCategory.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuCategory.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuCategory.FillPressColor = Color.Silver;
            MenuCategory.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuCategory.ImageAlign = ContentAlignment.MiddleLeft;
            MenuCategory.Location = new Point(-5, -25);
            MenuCategory.Margin = new Padding(4);
            MenuCategory.MinimumSize = new Size(1, 1);
            MenuCategory.Name = "MenuCategory";
            MenuCategory.Radius = 10;
            MenuCategory.RectColor = Color.White;
            MenuCategory.RectDisableColor = Color.White;
            MenuCategory.RectHoverColor = Color.White;
            MenuCategory.RectPressColor = Color.White;
            MenuCategory.RectSelectedColor = Color.White;
            MenuCategory.ShowFocusLine = true;
            MenuCategory.Size = new Size(270, 98);
            MenuCategory.Style = Sunny.UI.UIStyle.Custom;
            MenuCategory.Symbol = 560361;
            MenuCategory.SymbolOffset = new Point(5, 0);
            MenuCategory.SymbolSize = 30;
            MenuCategory.TabIndex = 25;
            MenuCategory.Text = "Categorias";
            MenuCategory.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuCategory.Click += btnCategorias_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(MenuClientes);
            panel5.Location = new Point(4, 120);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(238, 50);
            panel5.TabIndex = 28;
            // 
            // MenuClientes
            // 
            MenuClientes.FillColor = Color.FromArgb(11, 46, 34);
            MenuClientes.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuClientes.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuClientes.FillPressColor = Color.Silver;
            MenuClientes.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuClientes.ImageAlign = ContentAlignment.MiddleLeft;
            MenuClientes.Location = new Point(-5, -25);
            MenuClientes.Margin = new Padding(4);
            MenuClientes.MinimumSize = new Size(1, 1);
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Radius = 10;
            MenuClientes.RectColor = Color.White;
            MenuClientes.RectDisableColor = Color.White;
            MenuClientes.RectHoverColor = Color.White;
            MenuClientes.RectPressColor = Color.White;
            MenuClientes.RectSelectedColor = Color.White;
            MenuClientes.ShowFocusLine = true;
            MenuClientes.Size = new Size(266, 98);
            MenuClientes.Style = Sunny.UI.UIStyle.Custom;
            MenuClientes.Symbol = 358769;
            MenuClientes.SymbolOffset = new Point(5, 0);
            MenuClientes.SymbolSize = 30;
            MenuClientes.TabIndex = 25;
            MenuClientes.Text = "Clientes";
            MenuClientes.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuClientes.Click += btnClientes_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(MenuHome);
            panel2.Location = new Point(4, 62);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 50);
            panel2.TabIndex = 3;
            // 
            // MenuHome
            // 
            MenuHome.FillColor = Color.FromArgb(11, 46, 34);
            MenuHome.FillDisableColor = Color.FromArgb(224, 224, 224);
            MenuHome.FillHoverColor = Color.FromArgb(8, 92, 63);
            MenuHome.FillPressColor = Color.Silver;
            MenuHome.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuHome.ImageAlign = ContentAlignment.MiddleLeft;
            MenuHome.Location = new Point(-5, -26);
            MenuHome.Margin = new Padding(4);
            MenuHome.MinimumSize = new Size(1, 1);
            MenuHome.Name = "MenuHome";
            MenuHome.Radius = 10;
            MenuHome.RectColor = Color.White;
            MenuHome.RectDisableColor = Color.White;
            MenuHome.RectHoverColor = Color.White;
            MenuHome.RectPressColor = Color.White;
            MenuHome.RectSelectedColor = Color.White;
            MenuHome.ShowFocusLine = true;
            MenuHome.Size = new Size(270, 98);
            MenuHome.Style = Sunny.UI.UIStyle.Custom;
            MenuHome.Symbol = 61461;
            MenuHome.SymbolOffset = new Point(5, 0);
            MenuHome.SymbolSize = 30;
            MenuHome.TabIndex = 25;
            MenuHome.Text = "Inicio";
            MenuHome.TipsFont = new Font("Microsoft Sans Serif", 9F);
            MenuHome.Click += btnHome_Click;
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
            PanelMenu.Controls.Add(panel15);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.FlowDirection = FlowDirection.TopDown;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Margin = new Padding(4);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(238, 985);
            PanelMenu.TabIndex = 33;
            PanelMenu.Paint += PanelMenu_Paint;
            // 
            // panel16
            // 
            panel16.Controls.Add(lblVentasoft);
            panel16.Controls.Add(IconVS);
            panel16.Location = new Point(4, 4);
            panel16.Margin = new Padding(4);
            panel16.Name = "panel16";
            panel16.Size = new Size(238, 50);
            panel16.TabIndex = 26;
            // 
            // lblVentasoft
            // 
            lblVentasoft.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVentasoft.ForeColor = Color.White;
            lblVentasoft.HoverStyle = linkAppearance3;
            lblVentasoft.Location = new Point(72, 11);
            lblVentasoft.Margin = new Padding(4);
            lblVentasoft.Name = "lblVentasoft";
            linkAppearance4.LinkStyle = FontStyle.Bold;
            lblVentasoft.NormalStyle = linkAppearance4;
            lblVentasoft.Size = new Size(120, 29);
            lblVentasoft.TabIndex = 26;
            lblVentasoft.Text = "VentaSoft";
            // 
            // IconVS
            // 
            IconVS.Image = (Image)resources.GetObject("IconVS.Image");
            IconVS.Location = new Point(0, -4);
            IconVS.Margin = new Padding(4);
            IconVS.Name = "IconVS";
            IconVS.Size = new Size(51, 54);
            IconVS.SizeMode = PictureBoxSizeMode.Zoom;
            IconVS.TabIndex = 0;
            IconVS.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1708, 985);
            Controls.Add(PanelContenedor);
            Controls.Add(Header);
            Controls.Add(PanelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Sunny.UI.UISymbolButton btnMenu;
        private Panel PanelContenedor;
        private FlowLayoutPanel SubMenuReports;
        private Panel panel1;
        private Sunny.UI.UISymbolButton MenuReportes;
        private Panel panel12;
        private Sunny.UI.UISymbolButton btnReporteVentas;
        private Panel panel13;
        private Sunny.UI.UISymbolButton BtnReporteCompra;
        private FlowLayoutPanel submenuCompras;
        private Panel panel10;
        private Sunny.UI.UISymbolButton MenuCompras;
        private Panel panel11;
        private Sunny.UI.UISymbolButton Btndetallecompras;
        private FlowLayoutPanel SubmenuVentas;
        private Panel panel7;
        private Sunny.UI.UISymbolButton MenuVentas;
        private Panel panel6;
        private Sunny.UI.UISymbolButton btnDetallesVentas;
        private Panel panel9;
        private Sunny.UI.UISymbolButton MenuProveedores;
        private Panel panel8;
        private Sunny.UI.UISymbolButton MenuEmpleados;
        private Panel panel4;
        private Sunny.UI.UISymbolButton MenuProducto;
        private Panel panel3;
        private Sunny.UI.UISymbolButton MenuCategory;
        private Panel panel5;
        private Sunny.UI.UISymbolButton MenuClientes;
        private Panel panel2;
        private Sunny.UI.UISymbolButton MenuHome;
        private FlowLayoutPanel PanelMenu;
        private Panel panel15;
        private Sunny.UI.UISymbolButton MenuAbout;
        private Label lblRol;
        private Label label1;
        private Label lblUsuario;
        private Panel panel16;
        private PictureBox IconVS;
        private AntdUI.HyperlinkLabel lblVentasoft;
        private Label label2;
    }
}