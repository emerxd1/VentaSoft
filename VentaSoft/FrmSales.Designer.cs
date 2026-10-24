namespace Main
{
    partial class FrmSales
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new AntdUI.Label();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            label3 = new Label();
            CbTipodeDocumento = new Sunny.UI.UIComboBox();
            label2 = new Label();
            TxtFecha = new Sunny.UI.UITextBox();
            lblTituloGrupo1 = new Label();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            label18 = new Label();
            TxtApellido2Cli = new Sunny.UI.UITextBox();
            label19 = new Label();
            TxtApellido1Cli = new Sunny.UI.UITextBox();
            label17 = new Label();
            TxtNombre2Cli = new Sunny.UI.UITextBox();
            label16 = new Label();
            BtnBuscarCliente = new Sunny.UI.UISymbolButton();
            TxtNombre1Cli = new Sunny.UI.UITextBox();
            label11 = new Label();
            TxtDocCliente = new Sunny.UI.UITextBox();
            label4 = new Label();
            uiGroupBox3 = new Sunny.UI.UIGroupBox();
            BtnAgregarProd = new Sunny.UI.UISymbolButton();
            label12 = new Label();
            TxtCantidad = new NumericUpDown();
            label10 = new Label();
            label8 = new Label();
            TxtStock = new Sunny.UI.UITextBox();
            label9 = new Label();
            TxtPrecioVenta = new Sunny.UI.UITextBox();
            label7 = new Label();
            TxtNombreProd = new Sunny.UI.UITextBox();
            label6 = new Label();
            TxtcodProd = new Sunny.UI.UITextBox();
            BtnBuscarProd = new Sunny.UI.UISymbolButton();
            TxtidProd = new TextBox();
            label5 = new Label();
            BtnCrearVenta = new Sunny.UI.UISymbolButton();
            label21 = new Label();
            TxtCambio = new Sunny.UI.UITextBox();
            label20 = new Label();
            TxtPagaCon = new Sunny.UI.UITextBox();
            label15 = new Label();
            TxtTotalPago = new Sunny.UI.UITextBox();
            DgvData = new ModernControls.ModernGrid();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            uiPanel1 = new Sunny.UI.UIPanel();
            label13 = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            uiGroupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).BeginInit();
            TxtStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(6, 3);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(1079, 639);
            label1.TabIndex = 0;
            label1.Text = "";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.White;
            uiGroupBox1.Controls.Add(label3);
            uiGroupBox1.Controls.Add(CbTipodeDocumento);
            uiGroupBox1.Controls.Add(label2);
            uiGroupBox1.Controls.Add(TxtFecha);
            uiGroupBox1.Controls.Add(lblTituloGrupo1);
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(9, 51);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Radius = 10;
            uiGroupBox1.RectColor = Color.Silver;
            uiGroupBox1.Size = new Size(408, 87);
            uiGroupBox1.TabIndex = 2;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(31, 58, 48);
            label3.Location = new Point(164, 27);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 5;
            label3.Text = "Tipo de Documento*";
            // 
            // CbTipodeDocumento
            // 
            CbTipodeDocumento.BackgroundImageLayout = ImageLayout.Center;
            CbTipodeDocumento.Cursor = Cursors.HSplit;
            CbTipodeDocumento.DataSource = null;
            CbTipodeDocumento.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            CbTipodeDocumento.FillColor = Color.White;
            CbTipodeDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbTipodeDocumento.ForeColor = Color.Black;
            CbTipodeDocumento.ItemHoverColor = Color.FromArgb(201, 228, 217);
            CbTipodeDocumento.ItemRectColor = Color.FromArgb(57, 79, 71);
            CbTipodeDocumento.ItemSelectBackColor = Color.Silver;
            CbTipodeDocumento.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            CbTipodeDocumento.Location = new Point(164, 49);
            CbTipodeDocumento.Margin = new Padding(4, 5, 4, 5);
            CbTipodeDocumento.MinimumSize = new Size(63, 0);
            CbTipodeDocumento.Name = "CbTipodeDocumento";
            CbTipodeDocumento.Padding = new Padding(0, 0, 30, 2);
            CbTipodeDocumento.Radius = 10;
            CbTipodeDocumento.RectColor = Color.Silver;
            CbTipodeDocumento.Size = new Size(150, 29);
            CbTipodeDocumento.Style = Sunny.UI.UIStyle.Custom;
            CbTipodeDocumento.StyleDropDown = Sunny.UI.UIStyle.Custom;
            CbTipodeDocumento.SymbolSize = 24;
            CbTipodeDocumento.TabIndex = 6;
            CbTipodeDocumento.TextAlignment = ContentAlignment.MiddleLeft;
            CbTipodeDocumento.Watermark = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(31, 58, 48);
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha*";
            // 
            // TxtFecha
            // 
            TxtFecha.Cursor = Cursors.IBeam;
            TxtFecha.FillReadOnlyColor = Color.White;
            TxtFecha.Font = new Font("Microsoft Sans Serif", 12F);
            TxtFecha.ForeColor = Color.Gray;
            TxtFecha.ForeReadOnlyColor = Color.White;
            TxtFecha.Location = new Point(3, 49);
            TxtFecha.Margin = new Padding(3, 2, 3, 2);
            TxtFecha.MinimumSize = new Size(1, 16);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Padding = new Padding(5);
            TxtFecha.Radius = 10;
            TxtFecha.ReadOnly = true;
            TxtFecha.RectColor = Color.Silver;
            TxtFecha.RectReadOnlyColor = Color.Gray;
            TxtFecha.ShowText = false;
            TxtFecha.Size = new Size(150, 28);
            TxtFecha.Style = Sunny.UI.UIStyle.Custom;
            TxtFecha.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtFecha.TabIndex = 4;
            TxtFecha.TextAlignment = ContentAlignment.MiddleLeft;
            TxtFecha.Watermark = "";
            // 
            // lblTituloGrupo1
            // 
            lblTituloGrupo1.BackColor = Color.FromArgb(8, 92, 63);
            lblTituloGrupo1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrupo1.ForeColor = Color.White;
            lblTituloGrupo1.Location = new Point(-1, 0);
            lblTituloGrupo1.Name = "lblTituloGrupo1";
            lblTituloGrupo1.Padding = new Padding(8, 0, 0, 0);
            lblTituloGrupo1.Size = new Size(409, 22);
            lblTituloGrupo1.TabIndex = 1;
            lblTituloGrupo1.Text = "Información de la venta";
            lblTituloGrupo1.TextAlign = ContentAlignment.MiddleLeft;
            lblTituloGrupo1.Click += lblTituloGrupo1_Click;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(label18);
            uiGroupBox2.Controls.Add(TxtApellido2Cli);
            uiGroupBox2.Controls.Add(label19);
            uiGroupBox2.Controls.Add(TxtApellido1Cli);
            uiGroupBox2.Controls.Add(label17);
            uiGroupBox2.Controls.Add(TxtNombre2Cli);
            uiGroupBox2.Controls.Add(label16);
            uiGroupBox2.Controls.Add(BtnBuscarCliente);
            uiGroupBox2.Controls.Add(TxtNombre1Cli);
            uiGroupBox2.Controls.Add(label11);
            uiGroupBox2.Controls.Add(TxtDocCliente);
            uiGroupBox2.Controls.Add(label4);
            uiGroupBox2.FillColor = Color.White;
            uiGroupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox2.Location = new Point(9, 139);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Radius = 10;
            uiGroupBox2.RectColor = Color.Silver;
            uiGroupBox2.Size = new Size(408, 225);
            uiGroupBox2.TabIndex = 3;
            uiGroupBox2.Text = null;
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(31, 58, 48);
            label18.Location = new Point(211, 148);
            label18.Name = "label18";
            label18.Size = new Size(132, 20);
            label18.TabIndex = 87;
            label18.Text = "Segundo Apellido";
            // 
            // TxtApellido2Cli
            // 
            TxtApellido2Cli.BackColor = Color.White;
            TxtApellido2Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtApellido2Cli.ForeReadOnlyColor = Color.Gray;
            TxtApellido2Cli.Location = new Point(211, 170);
            TxtApellido2Cli.Margin = new Padding(4, 5, 4, 5);
            TxtApellido2Cli.MinimumSize = new Size(1, 16);
            TxtApellido2Cli.Name = "TxtApellido2Cli";
            TxtApellido2Cli.Padding = new Padding(5);
            TxtApellido2Cli.Radius = 10;
            TxtApellido2Cli.RectColor = Color.Silver;
            TxtApellido2Cli.ShowText = false;
            TxtApellido2Cli.Size = new Size(193, 29);
            TxtApellido2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido2Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtApellido2Cli.TabIndex = 88;
            TxtApellido2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido2Cli.Watermark = "Ej: Lopez";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(31, 58, 48);
            label19.Location = new Point(6, 148);
            label19.Name = "label19";
            label19.Size = new Size(125, 20);
            label19.TabIndex = 85;
            label19.Text = "Primer Apellido*";
            // 
            // TxtApellido1Cli
            // 
            TxtApellido1Cli.BackColor = Color.White;
            TxtApellido1Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtApellido1Cli.Location = new Point(6, 170);
            TxtApellido1Cli.Margin = new Padding(4, 5, 4, 5);
            TxtApellido1Cli.MinimumSize = new Size(1, 16);
            TxtApellido1Cli.Name = "TxtApellido1Cli";
            TxtApellido1Cli.Padding = new Padding(5);
            TxtApellido1Cli.Radius = 10;
            TxtApellido1Cli.RectColor = Color.Silver;
            TxtApellido1Cli.ShowText = false;
            TxtApellido1Cli.Size = new Size(189, 29);
            TxtApellido1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido1Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtApellido1Cli.TabIndex = 86;
            TxtApellido1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido1Cli.Watermark = "Ej: Perez";
            TxtApellido1Cli.TextChanged += txtLastName1_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(31, 58, 48);
            label17.Location = new Point(211, 84);
            label17.Name = "label17";
            label17.Size = new Size(132, 20);
            label17.TabIndex = 83;
            label17.Text = "Segundo Nombre";
            // 
            // TxtNombre2Cli
            // 
            TxtNombre2Cli.BackColor = Color.White;
            TxtNombre2Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtNombre2Cli.Location = new Point(211, 106);
            TxtNombre2Cli.Margin = new Padding(4, 5, 4, 5);
            TxtNombre2Cli.MinimumSize = new Size(1, 16);
            TxtNombre2Cli.Name = "TxtNombre2Cli";
            TxtNombre2Cli.Padding = new Padding(5);
            TxtNombre2Cli.Radius = 10;
            TxtNombre2Cli.RectColor = Color.Silver;
            TxtNombre2Cli.ShowText = false;
            TxtNombre2Cli.Size = new Size(193, 26);
            TxtNombre2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre2Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtNombre2Cli.TabIndex = 84;
            TxtNombre2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre2Cli.Watermark = "Ej: Jose";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(31, 58, 48);
            label16.Location = new Point(6, 84);
            label16.Name = "label16";
            label16.Size = new Size(125, 20);
            label16.TabIndex = 67;
            label16.Text = "Primer Nombre*";
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.BackColor = Color.White;
            BtnBuscarCliente.FillColor = Color.FromArgb(0, 192, 0);
            BtnBuscarCliente.FillColor2 = Color.Chocolate;
            BtnBuscarCliente.FillDisableColor = Color.White;
            BtnBuscarCliente.FillHoverColor = Color.FromArgb(11, 127, 87);
            BtnBuscarCliente.FillPressColor = Color.Silver;
            BtnBuscarCliente.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscarCliente.ForeColor = Color.Snow;
            BtnBuscarCliente.Location = new Point(214, 49);
            BtnBuscarCliente.MinimumSize = new Size(1, 1);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            BtnBuscarCliente.Radius = 15;
            BtnBuscarCliente.RectColor = Color.White;
            BtnBuscarCliente.RectDisableColor = Color.White;
            BtnBuscarCliente.RectHoverColor = Color.White;
            BtnBuscarCliente.RectPressColor = Color.White;
            BtnBuscarCliente.RectSelectedColor = Color.White;
            BtnBuscarCliente.ShowFocusLine = true;
            BtnBuscarCliente.Size = new Size(41, 31);
            BtnBuscarCliente.Style = Sunny.UI.UIStyle.Custom;
            BtnBuscarCliente.Symbol = 61442;
            BtnBuscarCliente.TabIndex = 82;
            BtnBuscarCliente.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // TxtNombre1Cli
            // 
            TxtNombre1Cli.BackColor = Color.White;
            TxtNombre1Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtNombre1Cli.Location = new Point(6, 106);
            TxtNombre1Cli.Margin = new Padding(4, 5, 4, 5);
            TxtNombre1Cli.MinimumSize = new Size(1, 16);
            TxtNombre1Cli.Name = "TxtNombre1Cli";
            TxtNombre1Cli.Padding = new Padding(5);
            TxtNombre1Cli.Radius = 10;
            TxtNombre1Cli.RectColor = Color.Silver;
            TxtNombre1Cli.ShowText = false;
            TxtNombre1Cli.Size = new Size(189, 26);
            TxtNombre1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre1Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtNombre1Cli.TabIndex = 68;
            TxtNombre1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre1Cli.Watermark = "Ej: Juan";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(6, 27);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 76;
            label11.Text = "DNI*";
            // 
            // TxtDocCliente
            // 
            TxtDocCliente.Cursor = Cursors.IBeam;
            TxtDocCliente.Font = new Font("Microsoft Sans Serif", 12F);
            TxtDocCliente.Location = new Point(6, 49);
            TxtDocCliente.Margin = new Padding(3, 2, 3, 2);
            TxtDocCliente.MinimumSize = new Size(1, 16);
            TxtDocCliente.Name = "TxtDocCliente";
            TxtDocCliente.Padding = new Padding(5);
            TxtDocCliente.Radius = 10;
            TxtDocCliente.RectColor = Color.Silver;
            TxtDocCliente.ShowText = false;
            TxtDocCliente.Size = new Size(199, 30);
            TxtDocCliente.Style = Sunny.UI.UIStyle.Custom;
            TxtDocCliente.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtDocCliente.TabIndex = 75;
            TxtDocCliente.TextAlignment = ContentAlignment.MiddleLeft;
            TxtDocCliente.Watermark = "EJ: 002-032004-8909Z";
            TxtDocCliente.KeyDown += TxtDocCliente_KeyDown;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(8, 92, 63);
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(8, 0, 0, 0);
            label4.Size = new Size(408, 22);
            label4.TabIndex = 2;
            label4.Text = "Información del Cliente";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox3
            // 
            uiGroupBox3.Controls.Add(BtnAgregarProd);
            uiGroupBox3.Controls.Add(label12);
            uiGroupBox3.Controls.Add(TxtCantidad);
            uiGroupBox3.Controls.Add(label10);
            uiGroupBox3.Controls.Add(label8);
            uiGroupBox3.Controls.Add(TxtStock);
            uiGroupBox3.Controls.Add(TxtPrecioVenta);
            uiGroupBox3.Controls.Add(label7);
            uiGroupBox3.Controls.Add(TxtNombreProd);
            uiGroupBox3.Controls.Add(label6);
            uiGroupBox3.Controls.Add(TxtcodProd);
            uiGroupBox3.Controls.Add(BtnBuscarProd);
            uiGroupBox3.Controls.Add(TxtidProd);
            uiGroupBox3.Controls.Add(label5);
            uiGroupBox3.FillColor = Color.White;
            uiGroupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox3.Location = new Point(9, 369);
            uiGroupBox3.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox3.MinimumSize = new Size(1, 1);
            uiGroupBox3.Name = "uiGroupBox3";
            uiGroupBox3.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox3.Radius = 10;
            uiGroupBox3.RectColor = Color.Silver;
            uiGroupBox3.Size = new Size(408, 264);
            uiGroupBox3.TabIndex = 4;
            uiGroupBox3.Text = null;
            uiGroupBox3.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // BtnAgregarProd
            // 
            BtnAgregarProd.BackColor = Color.Transparent;
            BtnAgregarProd.FillColor = Color.FromArgb(0, 192, 0);
            BtnAgregarProd.FillColor2 = Color.FromArgb(11, 127, 87);
            BtnAgregarProd.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnAgregarProd.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnAgregarProd.FillPressColor = Color.Silver;
            BtnAgregarProd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarProd.Location = new Point(240, 225);
            BtnAgregarProd.MinimumSize = new Size(1, 1);
            BtnAgregarProd.Name = "BtnAgregarProd";
            BtnAgregarProd.Radius = 15;
            BtnAgregarProd.RectColor = Color.White;
            BtnAgregarProd.RectDisableColor = Color.White;
            BtnAgregarProd.RectHoverColor = Color.White;
            BtnAgregarProd.RectPressColor = Color.White;
            BtnAgregarProd.RectSelectedColor = Color.White;
            BtnAgregarProd.ShowFocusLine = true;
            BtnAgregarProd.Size = new Size(165, 36);
            BtnAgregarProd.Style = Sunny.UI.UIStyle.Custom;
            BtnAgregarProd.Symbol = 61543;
            BtnAgregarProd.TabIndex = 72;
            BtnAgregarProd.Text = "Agregar";
            BtnAgregarProd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnAgregarProd.Click += BtnAgregarProd_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(31, 58, 48);
            label12.Location = new Point(6, 203);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 70;
            label12.Text = "Cantidad:";
            // 
            // TxtCantidad
            // 
            TxtCantidad.BackColor = Color.White;
            TxtCantidad.BorderStyle = BorderStyle.FixedSingle;
            TxtCantidad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCantidad.Location = new Point(91, 201);
            TxtCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(91, 27);
            TxtCantidad.TabIndex = 71;
            TxtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.KeyDown += TxtCantidad_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(31, 58, 48);
            label10.Location = new Point(153, 153);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 69;
            label10.Text = "Stock:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(31, 58, 48);
            label8.Location = new Point(6, 153);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 68;
            label8.Text = "Precio:";
            label8.Click += label8_Click;
            // 
            // TxtStock
            // 
            TxtStock.BackColor = Color.White;
            TxtStock.Controls.Add(label9);
            TxtStock.Cursor = Cursors.IBeam;
            TxtStock.FillReadOnlyColor = Color.White;
            TxtStock.Font = new Font("Microsoft Sans Serif", 12F);
            TxtStock.ForeReadOnlyColor = Color.Gray;
            TxtStock.Location = new Point(205, 149);
            TxtStock.Margin = new Padding(3, 2, 3, 2);
            TxtStock.MinimumSize = new Size(1, 16);
            TxtStock.Name = "TxtStock";
            TxtStock.Padding = new Padding(5);
            TxtStock.Radius = 10;
            TxtStock.ReadOnly = true;
            TxtStock.RectColor = Color.Transparent;
            TxtStock.ShowText = false;
            TxtStock.Size = new Size(69, 27);
            TxtStock.Style = Sunny.UI.UIStyle.Custom;
            TxtStock.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtStock.TabIndex = 12;
            TxtStock.Text = "AUTO";
            TxtStock.TextAlignment = ContentAlignment.MiddleLeft;
            TxtStock.Watermark = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(57, 79, 71);
            label9.Location = new Point(0, -19);
            label9.Name = "label9";
            label9.Size = new Size(51, 17);
            label9.TabIndex = 69;
            label9.Text = "Precio*";
            // 
            // TxtPrecioVenta
            // 
            TxtPrecioVenta.BackColor = Color.White;
            TxtPrecioVenta.Cursor = Cursors.IBeam;
            TxtPrecioVenta.FillReadOnlyColor = Color.White;
            TxtPrecioVenta.Font = new Font("Microsoft Sans Serif", 12F);
            TxtPrecioVenta.ForeReadOnlyColor = Color.Gray;
            TxtPrecioVenta.Location = new Point(62, 151);
            TxtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            TxtPrecioVenta.MinimumSize = new Size(1, 16);
            TxtPrecioVenta.Name = "TxtPrecioVenta";
            TxtPrecioVenta.Padding = new Padding(5);
            TxtPrecioVenta.Radius = 10;
            TxtPrecioVenta.ReadOnly = true;
            TxtPrecioVenta.RectColor = Color.Gainsboro;
            TxtPrecioVenta.ShowText = false;
            TxtPrecioVenta.Size = new Size(71, 28);
            TxtPrecioVenta.Style = Sunny.UI.UIStyle.Custom;
            TxtPrecioVenta.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtPrecioVenta.TabIndex = 11;
            TxtPrecioVenta.Text = "AUTO";
            TxtPrecioVenta.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPrecioVenta.Watermark = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(31, 58, 48);
            label7.Location = new Point(6, 82);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 9;
            label7.Text = "Producto";
            // 
            // TxtNombreProd
            // 
            TxtNombreProd.BackColor = Color.White;
            TxtNombreProd.Cursor = Cursors.IBeam;
            TxtNombreProd.FillReadOnlyColor = Color.White;
            TxtNombreProd.Font = new Font("Microsoft Sans Serif", 12F);
            TxtNombreProd.Location = new Point(-1, 104);
            TxtNombreProd.Margin = new Padding(3, 2, 3, 2);
            TxtNombreProd.MinimumSize = new Size(1, 16);
            TxtNombreProd.Name = "TxtNombreProd";
            TxtNombreProd.Padding = new Padding(5);
            TxtNombreProd.Radius = 10;
            TxtNombreProd.ReadOnly = true;
            TxtNombreProd.RectColor = Color.Silver;
            TxtNombreProd.ShowText = false;
            TxtNombreProd.Size = new Size(347, 28);
            TxtNombreProd.Style = Sunny.UI.UIStyle.Custom;
            TxtNombreProd.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtNombreProd.TabIndex = 10;
            TxtNombreProd.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombreProd.Watermark = "AUTOGENERADO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(31, 58, 48);
            label6.Location = new Point(6, 28);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 5;
            label6.Text = "Cód. del Producto";
            // 
            // TxtcodProd
            // 
            TxtcodProd.BackColor = Color.White;
            TxtcodProd.Cursor = Cursors.IBeam;
            TxtcodProd.FillReadOnlyColor = Color.White;
            TxtcodProd.Font = new Font("Microsoft Sans Serif", 12F);
            TxtcodProd.Location = new Point(6, 50);
            TxtcodProd.Margin = new Padding(3, 2, 3, 2);
            TxtcodProd.MinimumSize = new Size(1, 16);
            TxtcodProd.Name = "TxtcodProd";
            TxtcodProd.Padding = new Padding(5);
            TxtcodProd.Radius = 10;
            TxtcodProd.RectColor = Color.Silver;
            TxtcodProd.ShowText = false;
            TxtcodProd.Size = new Size(189, 30);
            TxtcodProd.Style = Sunny.UI.UIStyle.Custom;
            TxtcodProd.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtcodProd.TabIndex = 6;
            TxtcodProd.TextAlignment = ContentAlignment.MiddleLeft;
            TxtcodProd.Watermark = "EJ: \"P0001\" ";
            TxtcodProd.TextChanged += TxtcodProd_TextChanged;
            TxtcodProd.KeyDown += TxtcodProd_KeyDown;
            // 
            // BtnBuscarProd
            // 
            BtnBuscarProd.BackColor = Color.Transparent;
            BtnBuscarProd.FillColor = Color.FromArgb(0, 192, 0);
            BtnBuscarProd.FillColor2 = Color.FromArgb(11, 127, 87);
            BtnBuscarProd.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnBuscarProd.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnBuscarProd.FillPressColor = Color.Silver;
            BtnBuscarProd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscarProd.Location = new Point(211, 50);
            BtnBuscarProd.MinimumSize = new Size(1, 1);
            BtnBuscarProd.Name = "BtnBuscarProd";
            BtnBuscarProd.Radius = 12;
            BtnBuscarProd.RectColor = Color.White;
            BtnBuscarProd.RectDisableColor = Color.White;
            BtnBuscarProd.RectHoverColor = Color.White;
            BtnBuscarProd.RectPressColor = Color.White;
            BtnBuscarProd.RectSelectedColor = Color.White;
            BtnBuscarProd.ShowFocusLine = true;
            BtnBuscarProd.Size = new Size(44, 30);
            BtnBuscarProd.Style = Sunny.UI.UIStyle.Custom;
            BtnBuscarProd.Symbol = 61442;
            BtnBuscarProd.TabIndex = 7;
            BtnBuscarProd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnBuscarProd.Click += BtnBuscarProd_Click;
            // 
            // TxtidProd
            // 
            TxtidProd.Location = new Point(265, 52);
            TxtidProd.Name = "TxtidProd";
            TxtidProd.Size = new Size(40, 26);
            TxtidProd.TabIndex = 8;
            TxtidProd.Visible = false;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(8, 92, 63);
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(-1, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(8, 0, 0, 0);
            label5.Size = new Size(409, 22);
            label5.TabIndex = 3;
            label5.Text = "Información del Producto";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnCrearVenta
            // 
            BtnCrearVenta.BackColor = Color.White;
            BtnCrearVenta.FillColor = Color.FromArgb(0, 192, 0);
            BtnCrearVenta.FillColor2 = Color.FromArgb(11, 127, 87);
            BtnCrearVenta.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnCrearVenta.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnCrearVenta.FillPressColor = Color.Silver;
            BtnCrearVenta.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCrearVenta.ForeDisableColor = Color.White;
            BtnCrearVenta.LightColor = Color.White;
            BtnCrearVenta.Location = new Point(480, 543);
            BtnCrearVenta.MinimumSize = new Size(1, 1);
            BtnCrearVenta.Name = "BtnCrearVenta";
            BtnCrearVenta.Radius = 15;
            BtnCrearVenta.RectColor = Color.White;
            BtnCrearVenta.RectDisableColor = Color.White;
            BtnCrearVenta.RectHoverColor = Color.White;
            BtnCrearVenta.RectPressColor = Color.White;
            BtnCrearVenta.RectSelectedColor = Color.White;
            BtnCrearVenta.ShowFocusLine = true;
            BtnCrearVenta.Size = new Size(172, 36);
            BtnCrearVenta.Style = Sunny.UI.UIStyle.Custom;
            BtnCrearVenta.Symbol = 61483;
            BtnCrearVenta.SymbolDisableColor = Color.White;
            BtnCrearVenta.SymbolSize = 30;
            BtnCrearVenta.TabIndex = 8;
            BtnCrearVenta.Text = "Crear Venta";
            BtnCrearVenta.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnCrearVenta.Click += BtnCrearVenta_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.White;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(31, 58, 48);
            label21.Location = new Point(404, 502);
            label21.Name = "label21";
            label21.Size = new Size(66, 20);
            label21.TabIndex = 75;
            label21.Text = "Cambio:";
            // 
            // TxtCambio
            // 
            TxtCambio.BackColor = Color.White;
            TxtCambio.Cursor = Cursors.IBeam;
            TxtCambio.FillReadOnlyColor = Color.White;
            TxtCambio.Font = new Font("Microsoft Sans Serif", 12F);
            TxtCambio.Location = new Point(474, 497);
            TxtCambio.Margin = new Padding(3, 2, 3, 2);
            TxtCambio.MinimumSize = new Size(1, 16);
            TxtCambio.Name = "TxtCambio";
            TxtCambio.Padding = new Padding(5);
            TxtCambio.Radius = 10;
            TxtCambio.ReadOnly = true;
            TxtCambio.RectColor = Color.Silver;
            TxtCambio.ShowText = false;
            TxtCambio.Size = new Size(85, 30);
            TxtCambio.Style = Sunny.UI.UIStyle.Custom;
            TxtCambio.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtCambio.TabIndex = 74;
            TxtCambio.Text = "0";
            TxtCambio.TextAlignment = ContentAlignment.MiddleLeft;
            TxtCambio.Watermark = "";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.White;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(31, 58, 48);
            label20.Location = new Point(232, 504);
            label20.Name = "label20";
            label20.Size = new Size(76, 20);
            label20.TabIndex = 73;
            label20.Text = "Paga con:";
            // 
            // TxtPagaCon
            // 
            TxtPagaCon.BackColor = Color.White;
            TxtPagaCon.Cursor = Cursors.IBeam;
            TxtPagaCon.Font = new Font("Microsoft Sans Serif", 12F);
            TxtPagaCon.Location = new Point(309, 499);
            TxtPagaCon.Margin = new Padding(3, 2, 3, 2);
            TxtPagaCon.MinimumSize = new Size(1, 16);
            TxtPagaCon.Name = "TxtPagaCon";
            TxtPagaCon.Padding = new Padding(5);
            TxtPagaCon.Radius = 10;
            TxtPagaCon.RectColor = Color.Silver;
            TxtPagaCon.ShowText = false;
            TxtPagaCon.Size = new Size(85, 30);
            TxtPagaCon.Style = Sunny.UI.UIStyle.Custom;
            TxtPagaCon.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtPagaCon.TabIndex = 72;
            TxtPagaCon.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPagaCon.Watermark = "EJ: 50";
            TxtPagaCon.TextChanged += TxtPagaCon_TextChanged;
            TxtPagaCon.KeyDown += TxtPagaCon_KeyDown;
            TxtPagaCon.KeyPress += TxtPagaCon_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(31, 58, 48);
            label15.Location = new Point(22, 506);
            label15.Name = "label15";
            label15.Size = new Size(105, 20);
            label15.TabIndex = 71;
            label15.Text = "Total a Pagar:";
            // 
            // TxtTotalPago
            // 
            TxtTotalPago.BackColor = Color.White;
            TxtTotalPago.Cursor = Cursors.IBeam;
            TxtTotalPago.FillReadOnlyColor = Color.White;
            TxtTotalPago.Font = new Font("Microsoft Sans Serif", 12F);
            TxtTotalPago.Location = new Point(129, 501);
            TxtTotalPago.Margin = new Padding(3, 2, 3, 2);
            TxtTotalPago.MinimumSize = new Size(1, 16);
            TxtTotalPago.Name = "TxtTotalPago";
            TxtTotalPago.Padding = new Padding(5);
            TxtTotalPago.Radius = 10;
            TxtTotalPago.ReadOnly = true;
            TxtTotalPago.RectColor = Color.Silver;
            TxtTotalPago.ShowText = false;
            TxtTotalPago.Size = new Size(85, 30);
            TxtTotalPago.Style = Sunny.UI.UIStyle.Custom;
            TxtTotalPago.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtTotalPago.TabIndex = 68;
            TxtTotalPago.Text = "0";
            TxtTotalPago.TextAlignment = ContentAlignment.MiddleLeft;
            TxtTotalPago.Watermark = "";
            // 
            // DgvData
            // 
            DgvData.AllowUserToAddRows = false;
            DgvData.AllowUserToDeleteRows = false;
            DgvData.AllowUserToResizeColumns = false;
            DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvData.BackgroundColor = Color.White;
            DgvData.BorderStyle = BorderStyle.None;
            DgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvData.ColumnHeadersHeight = 44;
            DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal });
            DgvData.CornerRadius = 5;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvData.DefaultCellStyle = dataGridViewCellStyle3;
            DgvData.EnableHeadersVisualStyles = false;
            DgvData.Font = new Font("Segoe UI", 9.5F);
            DgvData.GridColor = Color.White;
            DgvData.HeaderBack = Color.FromArgb(8, 92, 63);
            DgvData.LineColor = Color.White;
            DgvData.Location = new Point(3, 1);
            DgvData.MultiSelect = false;
            DgvData.MutedColor = Color.White;
            DgvData.Name = "DgvData";
            DgvData.ReadOnly = true;
            DgvData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvData.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvData.RowTemplate.Height = 56;
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvData.ShowCellToolTips = false;
            DgvData.ShowColumnDividers = true;
            DgvData.Size = new Size(647, 468);
            DgvData.TabIndex = 8;
            DgvData.CellClick += DgvData_CellClick;
            DgvData.CellValueChanged += DgvData_CellValueChanged;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.FillWeight = 92F;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 92;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Precio
            // 
            Precio.FillWeight = 70F;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 70;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 89F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 89;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            SubTotal.FillWeight = 87F;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 87;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(label13);
            uiPanel1.Controls.Add(TxtPagaCon);
            uiPanel1.Controls.Add(BtnCrearVenta);
            uiPanel1.Controls.Add(TxtTotalPago);
            uiPanel1.Controls.Add(label21);
            uiPanel1.Controls.Add(label15);
            uiPanel1.Controls.Add(label20);
            uiPanel1.Controls.Add(DgvData);
            uiPanel1.Controls.Add(TxtCambio);
            uiPanel1.FillColor = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(422, 51);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.Silver;
            uiPanel1.Size = new Size(653, 584);
            uiPanel1.TabIndex = 76;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(8, 92, 63);
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(-1, 473);
            label13.Name = "label13";
            label13.Padding = new Padding(8, 0, 0, 0);
            label13.Size = new Size(653, 22);
            label13.TabIndex = 76;
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.FromArgb(8, 92, 63);
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(6, 12);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(1079, 36);
            bigLabel1.TabIndex = 77;
            bigLabel1.Text = "Registrar la Venta";
            // 
            // FrmSales
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 637);
            Controls.Add(bigLabel1);
            Controls.Add(uiPanel1);
            Controls.Add(uiGroupBox3);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            Name = "FrmSales";
            Text = "FrmSales";
            Load += FrmSales_Load;
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox1.PerformLayout();
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox2.PerformLayout();
            uiGroupBox3.ResumeLayout(false);
            uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).EndInit();
            TxtStock.ResumeLayout(false);
            TxtStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Label lblTituloGrupo1;
        private Label label2;
        private Sunny.UI.UITextBox TxtFecha;
        private Label label3;
        private Sunny.UI.UIComboBox CbTipodeDocumento;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Label label4;
        private Label label11;
        private Sunny.UI.UITextBox TxtDocCliente;
        private Sunny.UI.UISymbolButton BtnBuscarCliente;
        private Label label16;
        private Sunny.UI.UITextBox TxtNombre1Cli;
        private Label label17;
        private Sunny.UI.UITextBox TxtNombre2Cli;
        private Label label19;
        private Sunny.UI.UITextBox TxtApellido1Cli;
        private Label label18;
        private Sunny.UI.UITextBox TxtApellido2Cli;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Label label5;
        private Label label6;
        private Sunny.UI.UITextBox TxtcodProd;
        private Sunny.UI.UISymbolButton BtnBuscarProd;
        private TextBox TxtidProd;
        private Label label7;
        private Sunny.UI.UITextBox TxtNombreProd;
        private Sunny.UI.UITextBox TxtStock;
        private Sunny.UI.UITextBox TxtPrecioVenta;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label12;
        private NumericUpDown TxtCantidad;
        private ModernControls.ModernGrid DgvData;
        private Sunny.UI.UITextBox TxtTotalPago;
        private Label label21;
        private Sunny.UI.UITextBox TxtCambio;
        private Label label20;
        private Sunny.UI.UITextBox TxtPagaCon;
        private Label label15;
        private Sunny.UI.UISymbolButton BtnAgregarProd;
        private Sunny.UI.UISymbolButton BtnCrearVenta;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Sunny.UI.UIPanel uiPanel1;
        private Label label13;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}