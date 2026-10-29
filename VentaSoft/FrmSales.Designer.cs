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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            uiGroupBox1 = new Sunny.UI.UIPanel();
            chip1 = new Sunny.UI.UIPanel();
            lblTituloGrupo1 = new Label();
            label2 = new Label();
            TxtFecha = new Sunny.UI.UITextBox();
            label3 = new Label();
            CbTipodeDocumento = new Sunny.UI.UIComboBox();
            uiGroupBox2 = new Sunny.UI.UIPanel();
            chip2 = new Sunny.UI.UIPanel();
            label4 = new Label();
            label11 = new Label();
            TxtDocCliente = new Sunny.UI.UITextBox();
            BtnBuscarCliente = new Sunny.UI.UISymbolButton();
            label16 = new Label();
            TxtNombre1Cli = new Sunny.UI.UITextBox();
            label17 = new Label();
            TxtNombre2Cli = new Sunny.UI.UITextBox();
            label19 = new Label();
            TxtApellido1Cli = new Sunny.UI.UITextBox();
            label18 = new Label();
            TxtApellido2Cli = new Sunny.UI.UITextBox();
            uiGroupBox3 = new Sunny.UI.UIPanel();
            chip3 = new Sunny.UI.UIPanel();
            label5 = new Label();
            label6 = new Label();
            TxtcodProd = new Sunny.UI.UITextBox();
            BtnBuscarProd = new Sunny.UI.UISymbolButton();
            TxtidProd = new TextBox();
            label7 = new Label();
            TxtNombreProd = new Sunny.UI.UITextBox();
            label8 = new Label();
            TxtPrecioVenta = new Sunny.UI.UITextBox();
            label10 = new Label();
            TxtStock = new Sunny.UI.UITextBox();
            label12 = new Label();
            TxtCantidad = new NumericUpDown();
            BtnAgregarProd = new Sunny.UI.UISymbolButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            lblGridTitulo = new Label();
            DgvData = new ModernControls.ModernGrid();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewTextBoxColumn();
            linePie = new Label();
            label15 = new Label();
            TxtTotalPago = new Sunny.UI.UITextBox();
            label20 = new Label();
            TxtPagaCon = new Sunny.UI.UITextBox();
            label21 = new Label();
            TxtCambio = new Sunny.UI.UITextBox();
            BtnCrearVenta = new Sunny.UI.UISymbolButton();
            uiGroupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).BeginInit();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(242, 245, 245);
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(20, 32, 30);
            lblTitulo.Location = new Point(28, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1361, 34);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de venta";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.FromArgb(242, 245, 245);
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(70, 86, 79);
            lblSubtitulo.Location = new Point(30, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(1368, 20);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Registra los productos vendidos a un cliente y genera el documento de venta.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.FromArgb(242, 245, 245);
            uiGroupBox1.Controls.Add(chip1);
            uiGroupBox1.Controls.Add(lblTituloGrupo1);
            uiGroupBox1.Controls.Add(label2);
            uiGroupBox1.Controls.Add(TxtFecha);
            uiGroupBox1.Controls.Add(label3);
            uiGroupBox1.Controls.Add(CbTipodeDocumento);
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.FillColor2 = Color.White;
            uiGroupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiGroupBox1.Location = new Point(28, 76);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Radius = 10;
            uiGroupBox1.RectColor = Color.FromArgb(221, 228, 227);
            uiGroupBox1.Size = new Size(404, 106);
            uiGroupBox1.TabIndex = 3;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chip1
            // 
            chip1.BackColor = Color.White;
            chip1.FillColor = Color.FromArgb(223, 243, 239);
            chip1.FillColor2 = Color.FromArgb(223, 243, 239);
            chip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chip1.ForeColor = Color.FromArgb(11, 94, 88);
            chip1.Location = new Point(14, 11);
            chip1.Margin = new Padding(0);
            chip1.MinimumSize = new Size(1, 1);
            chip1.Name = "chip1";
            chip1.Radius = 12;
            chip1.RectColor = Color.FromArgb(223, 243, 239);
            chip1.Size = new Size(24, 24);
            chip1.Style = Sunny.UI.UIStyle.Custom;
            chip1.TabIndex = 4;
            chip1.Text = "1";
            chip1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrupo1
            // 
            lblTituloGrupo1.BackColor = Color.White;
            lblTituloGrupo1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloGrupo1.ForeColor = Color.FromArgb(20, 32, 30);
            lblTituloGrupo1.Location = new Point(46, 10);
            lblTituloGrupo1.Name = "lblTituloGrupo1";
            lblTituloGrupo1.Size = new Size(300, 24);
            lblTituloGrupo1.TabIndex = 5;
            lblTituloGrupo1.Text = "Datos de la venta";
            lblTituloGrupo1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(70, 86, 79);
            label2.Location = new Point(16, 42);
            label2.Name = "label2";
            label2.Size = new Size(178, 18);
            label2.TabIndex = 6;
            label2.Text = "Fecha*";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtFecha
            // 
            TxtFecha.BackColor = Color.White;
            TxtFecha.Cursor = Cursors.IBeam;
            TxtFecha.FillReadOnlyColor = Color.White;
            TxtFecha.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFecha.ForeColor = Color.FromArgb(20, 32, 30);
            TxtFecha.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtFecha.ImeMode = ImeMode.Disable;
            TxtFecha.Location = new Point(16, 60);
            TxtFecha.Margin = new Padding(3, 2, 3, 2);
            TxtFecha.MinimumSize = new Size(1, 16);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Padding = new Padding(5);
            TxtFecha.Radius = 6;
            TxtFecha.ReadOnly = true;
            TxtFecha.RectColor = Color.FromArgb(201, 211, 209);
            TxtFecha.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtFecha.ShowText = false;
            TxtFecha.Size = new Size(178, 34);
            TxtFecha.Style = Sunny.UI.UIStyle.Custom;
            TxtFecha.TabIndex = 7;
            TxtFecha.TextAlignment = ContentAlignment.MiddleLeft;
            TxtFecha.Watermark = "";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(70, 86, 79);
            label3.Location = new Point(210, 42);
            label3.Name = "label3";
            label3.Size = new Size(178, 18);
            label3.TabIndex = 8;
            label3.Text = "Tipo de documento*";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CbTipodeDocumento
            // 
            CbTipodeDocumento.BackColor = Color.White;
            CbTipodeDocumento.Cursor = Cursors.Hand;
            CbTipodeDocumento.DataSource = null;
            CbTipodeDocumento.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            CbTipodeDocumento.FillColor = Color.White;
            CbTipodeDocumento.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CbTipodeDocumento.ForeColor = Color.FromArgb(20, 32, 30);
            CbTipodeDocumento.ItemHoverColor = Color.FromArgb(238, 246, 245);
            CbTipodeDocumento.ItemRectColor = Color.FromArgb(201, 211, 209);
            CbTipodeDocumento.ItemSelectBackColor = Color.FromArgb(223, 243, 239);
            CbTipodeDocumento.ItemSelectForeColor = Color.FromArgb(20, 32, 30);
            CbTipodeDocumento.Location = new Point(210, 60);
            CbTipodeDocumento.Margin = new Padding(4, 5, 4, 5);
            CbTipodeDocumento.MinimumSize = new Size(63, 0);
            CbTipodeDocumento.Name = "CbTipodeDocumento";
            CbTipodeDocumento.Padding = new Padding(0, 0, 30, 2);
            CbTipodeDocumento.Radius = 6;
            CbTipodeDocumento.RectColor = Color.FromArgb(201, 211, 209);
            CbTipodeDocumento.Size = new Size(178, 34);
            CbTipodeDocumento.Style = Sunny.UI.UIStyle.Custom;
            CbTipodeDocumento.StyleDropDown = Sunny.UI.UIStyle.Custom;
            CbTipodeDocumento.SymbolSize = 24;
            CbTipodeDocumento.TabIndex = 9;
            CbTipodeDocumento.TextAlignment = ContentAlignment.MiddleLeft;
            CbTipodeDocumento.Watermark = "";
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.BackColor = Color.FromArgb(242, 245, 245);
            uiGroupBox2.Controls.Add(chip2);
            uiGroupBox2.Controls.Add(label4);
            uiGroupBox2.Controls.Add(label11);
            uiGroupBox2.Controls.Add(TxtDocCliente);
            uiGroupBox2.Controls.Add(BtnBuscarCliente);
            uiGroupBox2.Controls.Add(label16);
            uiGroupBox2.Controls.Add(TxtNombre1Cli);
            uiGroupBox2.Controls.Add(label17);
            uiGroupBox2.Controls.Add(TxtNombre2Cli);
            uiGroupBox2.Controls.Add(label19);
            uiGroupBox2.Controls.Add(TxtApellido1Cli);
            uiGroupBox2.Controls.Add(label18);
            uiGroupBox2.Controls.Add(TxtApellido2Cli);
            uiGroupBox2.FillColor = Color.White;
            uiGroupBox2.FillColor2 = Color.White;
            uiGroupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiGroupBox2.Location = new Point(28, 190);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Radius = 10;
            uiGroupBox2.RectColor = Color.FromArgb(221, 228, 227);
            uiGroupBox2.Size = new Size(404, 222);
            uiGroupBox2.TabIndex = 10;
            uiGroupBox2.Text = null;
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chip2
            // 
            chip2.BackColor = Color.White;
            chip2.FillColor = Color.FromArgb(223, 243, 239);
            chip2.FillColor2 = Color.FromArgb(223, 243, 239);
            chip2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chip2.ForeColor = Color.FromArgb(11, 94, 88);
            chip2.Location = new Point(14, 11);
            chip2.Margin = new Padding(0);
            chip2.MinimumSize = new Size(1, 1);
            chip2.Name = "chip2";
            chip2.Radius = 12;
            chip2.RectColor = Color.FromArgb(223, 243, 239);
            chip2.Size = new Size(24, 24);
            chip2.Style = Sunny.UI.UIStyle.Custom;
            chip2.TabIndex = 11;
            chip2.Text = "2";
            chip2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(20, 32, 30);
            label4.Location = new Point(46, 10);
            label4.Name = "label4";
            label4.Size = new Size(300, 24);
            label4.TabIndex = 12;
            label4.Text = "Cliente";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(70, 86, 79);
            label11.Location = new Point(16, 42);
            label11.Name = "label11";
            label11.Size = new Size(200, 18);
            label11.TabIndex = 13;
            label11.Text = "DNI*";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDocCliente
            // 
            TxtDocCliente.BackColor = Color.White;
            TxtDocCliente.Cursor = Cursors.IBeam;
            TxtDocCliente.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDocCliente.ForeColor = Color.FromArgb(20, 32, 30);
            TxtDocCliente.Location = new Point(16, 60);
            TxtDocCliente.Margin = new Padding(3, 2, 3, 2);
            TxtDocCliente.MinimumSize = new Size(1, 16);
            TxtDocCliente.Name = "TxtDocCliente";
            TxtDocCliente.Padding = new Padding(5);
            TxtDocCliente.Radius = 6;
            TxtDocCliente.RectColor = Color.FromArgb(201, 211, 209);
            TxtDocCliente.ShowText = false;
            TxtDocCliente.Size = new Size(324, 34);
            TxtDocCliente.Style = Sunny.UI.UIStyle.Custom;
            TxtDocCliente.TabIndex = 14;
            TxtDocCliente.TextAlignment = ContentAlignment.MiddleLeft;
            TxtDocCliente.Watermark = "Ej: 002-032004-8909Z";
            TxtDocCliente.KeyDown += TxtDocCliente_KeyDown;
            // 
            // BtnBuscarCliente
            // 
            BtnBuscarCliente.BackColor = Color.White;
            BtnBuscarCliente.Cursor = Cursors.Hand;
            BtnBuscarCliente.FillColor = Color.White;
            BtnBuscarCliente.FillDisableColor = Color.FromArgb(230, 236, 235);
            BtnBuscarCliente.FillHoverColor = Color.FromArgb(238, 246, 245);
            BtnBuscarCliente.FillPressColor = Color.FromArgb(223, 243, 239);
            BtnBuscarCliente.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarCliente.ForeColor = Color.FromArgb(20, 32, 30);
            BtnBuscarCliente.ForeDisableColor = Color.FromArgb(95, 111, 107);
            BtnBuscarCliente.ForeHoverColor = Color.FromArgb(20, 32, 30);
            BtnBuscarCliente.ForePressColor = Color.FromArgb(20, 32, 30);
            BtnBuscarCliente.Location = new Point(348, 60);
            BtnBuscarCliente.MinimumSize = new Size(1, 1);
            BtnBuscarCliente.Name = "BtnBuscarCliente";
            BtnBuscarCliente.Radius = 6;
            BtnBuscarCliente.RectColor = Color.FromArgb(201, 211, 209);
            BtnBuscarCliente.RectDisableColor = Color.FromArgb(221, 228, 227);
            BtnBuscarCliente.RectHoverColor = Color.FromArgb(15, 118, 110);
            BtnBuscarCliente.RectPressColor = Color.FromArgb(8, 76, 71);
            BtnBuscarCliente.RectSelectedColor = Color.FromArgb(201, 211, 209);
            BtnBuscarCliente.Size = new Size(40, 34);
            BtnBuscarCliente.Style = Sunny.UI.UIStyle.Custom;
            BtnBuscarCliente.Symbol = 61442;
            BtnBuscarCliente.SymbolColor = Color.FromArgb(15, 118, 110);
            BtnBuscarCliente.SymbolHoverColor = Color.FromArgb(15, 118, 110);
            BtnBuscarCliente.SymbolPressColor = Color.FromArgb(15, 118, 110);
            BtnBuscarCliente.SymbolSize = 18;
            BtnBuscarCliente.TabIndex = 15;
            BtnBuscarCliente.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarCliente.Click += BtnBuscarCliente_Click;
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(70, 86, 79);
            label16.Location = new Point(16, 100);
            label16.Name = "label16";
            label16.Size = new Size(178, 18);
            label16.TabIndex = 16;
            label16.Text = "Primer nombre*";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNombre1Cli
            // 
            TxtNombre1Cli.BackColor = Color.White;
            TxtNombre1Cli.Cursor = Cursors.IBeam;
            TxtNombre1Cli.FillDisableColor = Color.White;
            TxtNombre1Cli.FillReadOnlyColor = Color.White;
            TxtNombre1Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre1Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtNombre1Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtNombre1Cli.ImeMode = ImeMode.Disable;
            TxtNombre1Cli.Location = new Point(16, 118);
            TxtNombre1Cli.Margin = new Padding(3, 2, 3, 2);
            TxtNombre1Cli.MinimumSize = new Size(1, 16);
            TxtNombre1Cli.Name = "TxtNombre1Cli";
            TxtNombre1Cli.Padding = new Padding(5);
            TxtNombre1Cli.Radius = 6;
            TxtNombre1Cli.ReadOnly = true;
            TxtNombre1Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtNombre1Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtNombre1Cli.ShowText = false;
            TxtNombre1Cli.Size = new Size(178, 34);
            TxtNombre1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre1Cli.TabIndex = 17;
            TxtNombre1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre1Cli.Watermark = "Autogenerado";
            // 
            // label17
            // 
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(70, 86, 79);
            label17.Location = new Point(210, 100);
            label17.Name = "label17";
            label17.Size = new Size(178, 18);
            label17.TabIndex = 18;
            label17.Text = "Segundo nombre";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNombre2Cli
            // 
            TxtNombre2Cli.BackColor = Color.White;
            TxtNombre2Cli.Cursor = Cursors.IBeam;
            TxtNombre2Cli.FillDisableColor = Color.White;
            TxtNombre2Cli.FillReadOnlyColor = Color.White;
            TxtNombre2Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre2Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtNombre2Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtNombre2Cli.ImeMode = ImeMode.Disable;
            TxtNombre2Cli.Location = new Point(210, 118);
            TxtNombre2Cli.Margin = new Padding(3, 2, 3, 2);
            TxtNombre2Cli.MinimumSize = new Size(1, 16);
            TxtNombre2Cli.Name = "TxtNombre2Cli";
            TxtNombre2Cli.Padding = new Padding(5);
            TxtNombre2Cli.Radius = 6;
            TxtNombre2Cli.ReadOnly = true;
            TxtNombre2Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtNombre2Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtNombre2Cli.ShowText = false;
            TxtNombre2Cli.Size = new Size(178, 34);
            TxtNombre2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre2Cli.TabIndex = 19;
            TxtNombre2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre2Cli.Watermark = "Autogenerado";
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(70, 86, 79);
            label19.Location = new Point(16, 158);
            label19.Name = "label19";
            label19.Size = new Size(178, 18);
            label19.TabIndex = 20;
            label19.Text = "Primer apellido*";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtApellido1Cli
            // 
            TxtApellido1Cli.BackColor = Color.White;
            TxtApellido1Cli.Cursor = Cursors.IBeam;
            TxtApellido1Cli.FillDisableColor = Color.White;
            TxtApellido1Cli.FillReadOnlyColor = Color.White;
            TxtApellido1Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido1Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtApellido1Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtApellido1Cli.ImeMode = ImeMode.Disable;
            TxtApellido1Cli.Location = new Point(16, 176);
            TxtApellido1Cli.Margin = new Padding(3, 2, 3, 2);
            TxtApellido1Cli.MinimumSize = new Size(1, 16);
            TxtApellido1Cli.Name = "TxtApellido1Cli";
            TxtApellido1Cli.Padding = new Padding(5);
            TxtApellido1Cli.Radius = 6;
            TxtApellido1Cli.ReadOnly = true;
            TxtApellido1Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtApellido1Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtApellido1Cli.ShowText = false;
            TxtApellido1Cli.Size = new Size(178, 34);
            TxtApellido1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido1Cli.TabIndex = 21;
            TxtApellido1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido1Cli.Watermark = "Autogenerado";
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(70, 86, 79);
            label18.Location = new Point(210, 158);
            label18.Name = "label18";
            label18.Size = new Size(178, 18);
            label18.TabIndex = 22;
            label18.Text = "Segundo apellido";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtApellido2Cli
            // 
            TxtApellido2Cli.BackColor = Color.White;
            TxtApellido2Cli.Cursor = Cursors.IBeam;
            TxtApellido2Cli.FillDisableColor = Color.White;
            TxtApellido2Cli.FillReadOnlyColor = Color.White;
            TxtApellido2Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido2Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtApellido2Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtApellido2Cli.ImeMode = ImeMode.Disable;
            TxtApellido2Cli.Location = new Point(210, 176);
            TxtApellido2Cli.Margin = new Padding(3, 2, 3, 2);
            TxtApellido2Cli.MinimumSize = new Size(1, 16);
            TxtApellido2Cli.Name = "TxtApellido2Cli";
            TxtApellido2Cli.Padding = new Padding(5);
            TxtApellido2Cli.Radius = 6;
            TxtApellido2Cli.ReadOnly = true;
            TxtApellido2Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtApellido2Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtApellido2Cli.ShowText = false;
            TxtApellido2Cli.Size = new Size(178, 34);
            TxtApellido2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido2Cli.TabIndex = 23;
            TxtApellido2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido2Cli.Watermark = "Autogenerado";
            // 
            // uiGroupBox3
            // 
            uiGroupBox3.BackColor = Color.FromArgb(242, 245, 245);
            uiGroupBox3.Controls.Add(chip3);
            uiGroupBox3.Controls.Add(label5);
            uiGroupBox3.Controls.Add(label6);
            uiGroupBox3.Controls.Add(TxtcodProd);
            uiGroupBox3.Controls.Add(BtnBuscarProd);
            uiGroupBox3.Controls.Add(TxtidProd);
            uiGroupBox3.Controls.Add(label7);
            uiGroupBox3.Controls.Add(TxtNombreProd);
            uiGroupBox3.Controls.Add(label8);
            uiGroupBox3.Controls.Add(TxtPrecioVenta);
            uiGroupBox3.Controls.Add(label10);
            uiGroupBox3.Controls.Add(TxtStock);
            uiGroupBox3.Controls.Add(label12);
            uiGroupBox3.Controls.Add(TxtCantidad);
            uiGroupBox3.FillColor = Color.White;
            uiGroupBox3.FillColor2 = Color.White;
            uiGroupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiGroupBox3.Location = new Point(28, 420);
            uiGroupBox3.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox3.MinimumSize = new Size(1, 1);
            uiGroupBox3.Name = "uiGroupBox3";
            uiGroupBox3.Radius = 10;
            uiGroupBox3.RectColor = Color.FromArgb(221, 228, 227);
            uiGroupBox3.Size = new Size(404, 222);
            uiGroupBox3.TabIndex = 24;
            uiGroupBox3.Text = null;
            uiGroupBox3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chip3
            // 
            chip3.BackColor = Color.White;
            chip3.FillColor = Color.FromArgb(223, 243, 239);
            chip3.FillColor2 = Color.FromArgb(223, 243, 239);
            chip3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chip3.ForeColor = Color.FromArgb(11, 94, 88);
            chip3.Location = new Point(14, 11);
            chip3.Margin = new Padding(0);
            chip3.MinimumSize = new Size(1, 1);
            chip3.Name = "chip3";
            chip3.Radius = 12;
            chip3.RectColor = Color.FromArgb(223, 243, 239);
            chip3.Size = new Size(24, 24);
            chip3.Style = Sunny.UI.UIStyle.Custom;
            chip3.TabIndex = 25;
            chip3.Text = "3";
            chip3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(20, 32, 30);
            label5.Location = new Point(46, 10);
            label5.Name = "label5";
            label5.Size = new Size(300, 24);
            label5.TabIndex = 26;
            label5.Text = "Producto";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(70, 86, 79);
            label6.Location = new Point(16, 42);
            label6.Name = "label6";
            label6.Size = new Size(200, 18);
            label6.TabIndex = 27;
            label6.Text = "Código del producto";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtcodProd
            // 
            TxtcodProd.BackColor = Color.White;
            TxtcodProd.Cursor = Cursors.IBeam;
            TxtcodProd.FillDisableColor = Color.White;
            TxtcodProd.FillReadOnlyColor = Color.White;
            TxtcodProd.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtcodProd.ForeColor = Color.FromArgb(20, 32, 30);
            TxtcodProd.Location = new Point(16, 60);
            TxtcodProd.Margin = new Padding(3, 2, 3, 2);
            TxtcodProd.MinimumSize = new Size(1, 16);
            TxtcodProd.Name = "TxtcodProd";
            TxtcodProd.Padding = new Padding(5);
            TxtcodProd.Radius = 6;
            TxtcodProd.RectColor = Color.FromArgb(201, 211, 209);
            TxtcodProd.ShowText = false;
            TxtcodProd.Size = new Size(324, 34);
            TxtcodProd.Style = Sunny.UI.UIStyle.Custom;
            TxtcodProd.TabIndex = 28;
            TxtcodProd.TextAlignment = ContentAlignment.MiddleLeft;
            TxtcodProd.Watermark = "Ej: P0001";
            TxtcodProd.KeyDown += TxtcodProd_KeyDown;
            // 
            // BtnBuscarProd
            // 
            BtnBuscarProd.BackColor = Color.White;
            BtnBuscarProd.Cursor = Cursors.Hand;
            BtnBuscarProd.FillColor = Color.White;
            BtnBuscarProd.FillDisableColor = Color.FromArgb(230, 236, 235);
            BtnBuscarProd.FillHoverColor = Color.FromArgb(238, 246, 245);
            BtnBuscarProd.FillPressColor = Color.FromArgb(223, 243, 239);
            BtnBuscarProd.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarProd.ForeColor = Color.FromArgb(20, 32, 30);
            BtnBuscarProd.ForeDisableColor = Color.FromArgb(95, 111, 107);
            BtnBuscarProd.ForeHoverColor = Color.FromArgb(20, 32, 30);
            BtnBuscarProd.ForePressColor = Color.FromArgb(20, 32, 30);
            BtnBuscarProd.Location = new Point(348, 60);
            BtnBuscarProd.MinimumSize = new Size(1, 1);
            BtnBuscarProd.Name = "BtnBuscarProd";
            BtnBuscarProd.Radius = 6;
            BtnBuscarProd.RectColor = Color.FromArgb(201, 211, 209);
            BtnBuscarProd.RectDisableColor = Color.FromArgb(221, 228, 227);
            BtnBuscarProd.RectHoverColor = Color.FromArgb(15, 118, 110);
            BtnBuscarProd.RectPressColor = Color.FromArgb(8, 76, 71);
            BtnBuscarProd.RectSelectedColor = Color.FromArgb(201, 211, 209);
            BtnBuscarProd.Size = new Size(40, 34);
            BtnBuscarProd.Style = Sunny.UI.UIStyle.Custom;
            BtnBuscarProd.Symbol = 61442;
            BtnBuscarProd.SymbolColor = Color.FromArgb(15, 118, 110);
            BtnBuscarProd.SymbolHoverColor = Color.FromArgb(15, 118, 110);
            BtnBuscarProd.SymbolPressColor = Color.FromArgb(15, 118, 110);
            BtnBuscarProd.SymbolSize = 18;
            BtnBuscarProd.TabIndex = 29;
            BtnBuscarProd.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarProd.Click += BtnBuscarProd_Click;
            // 
            // TxtidProd
            // 
            TxtidProd.Location = new Point(300, 12);
            TxtidProd.Name = "TxtidProd";
            TxtidProd.Size = new Size(40, 25);
            TxtidProd.TabIndex = 30;
            TxtidProd.Visible = false;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(70, 86, 79);
            label7.Location = new Point(16, 100);
            label7.Name = "label7";
            label7.Size = new Size(200, 18);
            label7.TabIndex = 31;
            label7.Text = "Producto";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNombreProd
            // 
            TxtNombreProd.BackColor = Color.White;
            TxtNombreProd.Cursor = Cursors.IBeam;
            TxtNombreProd.FillDisableColor = Color.White;
            TxtNombreProd.FillReadOnlyColor = Color.White;
            TxtNombreProd.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombreProd.ForeColor = Color.FromArgb(20, 32, 30);
            TxtNombreProd.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtNombreProd.ImeMode = ImeMode.Disable;
            TxtNombreProd.Location = new Point(16, 118);
            TxtNombreProd.Margin = new Padding(3, 2, 3, 2);
            TxtNombreProd.MinimumSize = new Size(1, 16);
            TxtNombreProd.Name = "TxtNombreProd";
            TxtNombreProd.Padding = new Padding(5);
            TxtNombreProd.Radius = 6;
            TxtNombreProd.ReadOnly = true;
            TxtNombreProd.RectColor = Color.FromArgb(201, 211, 209);
            TxtNombreProd.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtNombreProd.ShowText = false;
            TxtNombreProd.Size = new Size(372, 34);
            TxtNombreProd.Style = Sunny.UI.UIStyle.Custom;
            TxtNombreProd.TabIndex = 32;
            TxtNombreProd.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombreProd.Watermark = "Autogenerado";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(70, 86, 79);
            label8.Location = new Point(16, 158);
            label8.Name = "label8";
            label8.Size = new Size(116, 18);
            label8.TabIndex = 33;
            label8.Text = "Precio";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtPrecioVenta
            // 
            TxtPrecioVenta.BackColor = Color.White;
            TxtPrecioVenta.Cursor = Cursors.IBeam;
            TxtPrecioVenta.FillDisableColor = Color.White;
            TxtPrecioVenta.FillReadOnlyColor = Color.White;
            TxtPrecioVenta.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecioVenta.ForeColor = Color.FromArgb(20, 32, 30);
            TxtPrecioVenta.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtPrecioVenta.ImeMode = ImeMode.Disable;
            TxtPrecioVenta.Location = new Point(16, 176);
            TxtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            TxtPrecioVenta.MinimumSize = new Size(1, 16);
            TxtPrecioVenta.Name = "TxtPrecioVenta";
            TxtPrecioVenta.Padding = new Padding(5);
            TxtPrecioVenta.Radius = 6;
            TxtPrecioVenta.ReadOnly = true;
            TxtPrecioVenta.RectColor = Color.FromArgb(201, 211, 209);
            TxtPrecioVenta.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtPrecioVenta.ShowText = false;
            TxtPrecioVenta.Size = new Size(116, 34);
            TxtPrecioVenta.Style = Sunny.UI.UIStyle.Custom;
            TxtPrecioVenta.TabIndex = 34;
            TxtPrecioVenta.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPrecioVenta.Watermark = "Auto";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(70, 86, 79);
            label10.Location = new Point(144, 158);
            label10.Name = "label10";
            label10.Size = new Size(116, 18);
            label10.TabIndex = 35;
            label10.Text = "Stock";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtStock
            // 
            TxtStock.BackColor = Color.White;
            TxtStock.Cursor = Cursors.IBeam;
            TxtStock.FillDisableColor = Color.White;
            TxtStock.FillReadOnlyColor = Color.White;
            TxtStock.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtStock.ForeColor = Color.FromArgb(20, 32, 30);
            TxtStock.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtStock.ImeMode = ImeMode.Disable;
            TxtStock.Location = new Point(144, 176);
            TxtStock.Margin = new Padding(3, 2, 3, 2);
            TxtStock.MinimumSize = new Size(1, 16);
            TxtStock.Name = "TxtStock";
            TxtStock.Padding = new Padding(5);
            TxtStock.Radius = 6;
            TxtStock.ReadOnly = true;
            TxtStock.RectColor = Color.FromArgb(201, 211, 209);
            TxtStock.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtStock.ShowText = false;
            TxtStock.Size = new Size(116, 34);
            TxtStock.Style = Sunny.UI.UIStyle.Custom;
            TxtStock.TabIndex = 36;
            TxtStock.TextAlignment = ContentAlignment.MiddleLeft;
            TxtStock.Watermark = "Auto";
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(70, 86, 79);
            label12.Location = new Point(272, 158);
            label12.Name = "label12";
            label12.Size = new Size(116, 18);
            label12.TabIndex = 37;
            label12.Text = "Cantidad*";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCantidad
            // 
            TxtCantidad.BackColor = Color.White;
            TxtCantidad.BorderStyle = BorderStyle.FixedSingle;
            TxtCantidad.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCantidad.Location = new Point(272, 179);
            TxtCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(116, 26);
            TxtCantidad.TabIndex = 38;
            TxtCantidad.TextAlign = HorizontalAlignment.Right;
            TxtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.KeyDown += TxtCantidad_KeyDown;
            // 
            // BtnAgregarProd
            // 
            BtnAgregarProd.BackColor = Color.FromArgb(242, 245, 245);
            BtnAgregarProd.Cursor = Cursors.Hand;
            BtnAgregarProd.FillColor = Color.FromArgb(15, 118, 110);
            BtnAgregarProd.FillDisableColor = Color.FromArgb(230, 236, 235);
            BtnAgregarProd.FillHoverColor = Color.FromArgb(11, 94, 88);
            BtnAgregarProd.FillPressColor = Color.FromArgb(8, 76, 71);
            BtnAgregarProd.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregarProd.ForeDisableColor = Color.FromArgb(95, 111, 107);
            BtnAgregarProd.Location = new Point(28, 654);
            BtnAgregarProd.MinimumSize = new Size(1, 1);
            BtnAgregarProd.Name = "BtnAgregarProd";
            BtnAgregarProd.Radius = 6;
            BtnAgregarProd.RectColor = Color.FromArgb(15, 118, 110);
            BtnAgregarProd.RectDisableColor = Color.FromArgb(230, 236, 235);
            BtnAgregarProd.RectHoverColor = Color.FromArgb(11, 94, 88);
            BtnAgregarProd.RectPressColor = Color.FromArgb(8, 76, 71);
            BtnAgregarProd.RectSelectedColor = Color.FromArgb(15, 118, 110);
            BtnAgregarProd.Size = new Size(404, 44);
            BtnAgregarProd.Style = Sunny.UI.UIStyle.Custom;
            BtnAgregarProd.Symbol = 61543;
            BtnAgregarProd.SymbolSize = 18;
            BtnAgregarProd.TabIndex = 39;
            BtnAgregarProd.Text = "Agregar a la venta";
            BtnAgregarProd.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregarProd.Click += BtnAgregarProd_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.BackColor = Color.FromArgb(242, 245, 245);
            uiPanel1.Controls.Add(lblGridTitulo);
            uiPanel1.Controls.Add(DgvData);
            uiPanel1.Controls.Add(linePie);
            uiPanel1.Controls.Add(label15);
            uiPanel1.Controls.Add(TxtTotalPago);
            uiPanel1.Controls.Add(label20);
            uiPanel1.Controls.Add(TxtPagaCon);
            uiPanel1.Controls.Add(label21);
            uiPanel1.Controls.Add(TxtCambio);
            uiPanel1.Controls.Add(BtnCrearVenta);
            uiPanel1.FillColor = Color.White;
            uiPanel1.FillColor2 = Color.White;
            uiPanel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiPanel1.Location = new Point(444, 76);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.FromArgb(221, 228, 227);
            uiPanel1.Size = new Size(844, 622);
            uiPanel1.TabIndex = 40;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblGridTitulo
            // 
            lblGridTitulo.BackColor = Color.White;
            lblGridTitulo.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGridTitulo.ForeColor = Color.FromArgb(20, 32, 30);
            lblGridTitulo.Location = new Point(20, 14);
            lblGridTitulo.Name = "lblGridTitulo";
            lblGridTitulo.Size = new Size(400, 24);
            lblGridTitulo.TabIndex = 41;
            lblGridTitulo.Text = "Productos de la venta";
            lblGridTitulo.TextAlign = ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvData.BackgroundColor = Color.White;
            DgvData.BorderStyle = BorderStyle.None;
            DgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(70, 86, 79);
            DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvData.ColumnHeadersHeight = 44;
            DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, BtnEliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvData.DefaultCellStyle = dataGridViewCellStyle3;
            DgvData.EnableHeadersVisualStyles = false;
            DgvData.Font = new Font("Segoe UI", 9.5F);
            DgvData.GridColor = Color.White;
            DgvData.HeaderBack = Color.FromArgb(246, 248, 248);
            DgvData.LineColor = Color.FromArgb(221, 228, 227);
            DgvData.Location = new Point(8, 48);
            DgvData.MultiSelect = false;
            DgvData.MutedColor = Color.FromArgb(70, 86, 79);
            DgvData.Name = "DgvData";
            DgvData.ReadOnly = true;
            DgvData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvData.RowHeadersVisible = false;
            DgvData.RowRadius = 6;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvData.RowTemplate.Height = 56;
            DgvData.SelectionColor = Color.FromArgb(223, 243, 239);
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvData.ShowCellToolTips = false;
            DgvData.Size = new Size(828, 482);
            DgvData.TabIndex = 42;
            DgvData.CellClick += DgvData_CellClick;
            // 
            // IdProducto
            // 
            IdProducto.FillWeight = 60F;
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
            SubTotal.FillWeight = 90F;
            SubTotal.HeaderText = "Sub total";
            SubTotal.MinimumWidth = 90;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // BtnEliminar
            // 
            BtnEliminar.FillWeight = 60F;
            BtnEliminar.HeaderText = "";
            BtnEliminar.MinimumWidth = 60;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.ReadOnly = true;
            BtnEliminar.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // linePie
            // 
            linePie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linePie.BackColor = Color.FromArgb(221, 228, 227);
            linePie.Location = new Point(1, 534);
            linePie.Name = "linePie";
            linePie.Size = new Size(842, 1);
            linePie.TabIndex = 43;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(70, 86, 79);
            label15.Location = new Point(20, 546);
            label15.Name = "label15";
            label15.Size = new Size(150, 18);
            label15.TabIndex = 44;
            label15.Text = "Total a pagar";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTotalPago
            // 
            TxtTotalPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtTotalPago.BackColor = Color.White;
            TxtTotalPago.Cursor = Cursors.IBeam;
            TxtTotalPago.FillReadOnlyColor = Color.White;
            TxtTotalPago.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTotalPago.ForeColor = Color.FromArgb(20, 32, 30);
            TxtTotalPago.ForeReadOnlyColor = Color.FromArgb(11, 94, 88);
            TxtTotalPago.ImeMode = ImeMode.Disable;
            TxtTotalPago.Location = new Point(20, 566);
            TxtTotalPago.Margin = new Padding(3, 2, 3, 2);
            TxtTotalPago.MinimumSize = new Size(1, 16);
            TxtTotalPago.Name = "TxtTotalPago";
            TxtTotalPago.Padding = new Padding(5);
            TxtTotalPago.Radius = 6;
            TxtTotalPago.ReadOnly = true;
            TxtTotalPago.RectColor = Color.FromArgb(201, 211, 209);
            TxtTotalPago.RectReadOnlyColor = Color.White;
            TxtTotalPago.ShowText = false;
            TxtTotalPago.Size = new Size(150, 40);
            TxtTotalPago.Style = Sunny.UI.UIStyle.Custom;
            TxtTotalPago.TabIndex = 45;
            TxtTotalPago.Text = "0.00";
            TxtTotalPago.TextAlignment = ContentAlignment.MiddleLeft;
            TxtTotalPago.Watermark = "";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label20.BackColor = Color.White;
            label20.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(70, 86, 79);
            label20.Location = new Point(190, 546);
            label20.Name = "label20";
            label20.Size = new Size(140, 18);
            label20.TabIndex = 46;
            label20.Text = "Paga con";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtPagaCon
            // 
            TxtPagaCon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtPagaCon.BackColor = Color.White;
            TxtPagaCon.Cursor = Cursors.IBeam;
            TxtPagaCon.FillDisableColor = Color.White;
            TxtPagaCon.FillReadOnlyColor = Color.White;
            TxtPagaCon.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPagaCon.ForeColor = Color.FromArgb(20, 32, 30);
            TxtPagaCon.Location = new Point(190, 568);
            TxtPagaCon.Margin = new Padding(3, 2, 3, 2);
            TxtPagaCon.MinimumSize = new Size(1, 16);
            TxtPagaCon.Name = "TxtPagaCon";
            TxtPagaCon.Padding = new Padding(5);
            TxtPagaCon.Radius = 6;
            TxtPagaCon.RectColor = Color.FromArgb(201, 211, 209);
            TxtPagaCon.ShowText = false;
            TxtPagaCon.Size = new Size(140, 36);
            TxtPagaCon.Style = Sunny.UI.UIStyle.Custom;
            TxtPagaCon.TabIndex = 47;
            TxtPagaCon.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPagaCon.Watermark = "Ej: 50";
            TxtPagaCon.TextChanged += TxtPagaCon_TextChanged;
            TxtPagaCon.KeyDown += TxtPagaCon_KeyDown;
            TxtPagaCon.KeyPress += TxtPagaCon_KeyPress;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label21.BackColor = Color.White;
            label21.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(70, 86, 79);
            label21.Location = new Point(350, 546);
            label21.Name = "label21";
            label21.Size = new Size(140, 18);
            label21.TabIndex = 48;
            label21.Text = "Cambio";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtCambio
            // 
            TxtCambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TxtCambio.BackColor = Color.White;
            TxtCambio.Cursor = Cursors.IBeam;
            TxtCambio.FillDisableColor = Color.White;
            TxtCambio.FillReadOnlyColor = Color.White;
            TxtCambio.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCambio.ForeColor = Color.FromArgb(20, 32, 30);
            TxtCambio.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtCambio.ImeMode = ImeMode.Disable;
            TxtCambio.Location = new Point(350, 568);
            TxtCambio.Margin = new Padding(3, 2, 3, 2);
            TxtCambio.MinimumSize = new Size(1, 16);
            TxtCambio.Name = "TxtCambio";
            TxtCambio.Padding = new Padding(5);
            TxtCambio.Radius = 6;
            TxtCambio.ReadOnly = true;
            TxtCambio.RectColor = Color.FromArgb(201, 211, 209);
            TxtCambio.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtCambio.ShowText = false;
            TxtCambio.Size = new Size(140, 36);
            TxtCambio.Style = Sunny.UI.UIStyle.Custom;
            TxtCambio.TabIndex = 49;
            TxtCambio.Text = "0.00";
            TxtCambio.TextAlignment = ContentAlignment.MiddleLeft;
            TxtCambio.Watermark = "";
            // 
            // BtnCrearVenta
            // 
            BtnCrearVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnCrearVenta.BackColor = Color.White;
            BtnCrearVenta.Cursor = Cursors.Hand;
            BtnCrearVenta.FillColor = Color.FromArgb(15, 118, 110);
            BtnCrearVenta.FillDisableColor = Color.FromArgb(230, 236, 235);
            BtnCrearVenta.FillHoverColor = Color.FromArgb(11, 94, 88);
            BtnCrearVenta.FillPressColor = Color.FromArgb(8, 76, 71);
            BtnCrearVenta.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCrearVenta.ForeDisableColor = Color.FromArgb(95, 111, 107);
            BtnCrearVenta.Location = new Point(616, 562);
            BtnCrearVenta.MinimumSize = new Size(1, 1);
            BtnCrearVenta.Name = "BtnCrearVenta";
            BtnCrearVenta.Radius = 6;
            BtnCrearVenta.RectColor = Color.FromArgb(15, 118, 110);
            BtnCrearVenta.RectDisableColor = Color.FromArgb(230, 236, 235);
            BtnCrearVenta.RectHoverColor = Color.FromArgb(11, 94, 88);
            BtnCrearVenta.RectPressColor = Color.FromArgb(8, 76, 71);
            BtnCrearVenta.RectSelectedColor = Color.FromArgb(15, 118, 110);
            BtnCrearVenta.Size = new Size(208, 48);
            BtnCrearVenta.Style = Sunny.UI.UIStyle.Custom;
            BtnCrearVenta.Symbol = 61452;
            BtnCrearVenta.SymbolSize = 18;
            BtnCrearVenta.TabIndex = 50;
            BtnCrearVenta.Text = "Crear venta";
            BtnCrearVenta.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCrearVenta.Click += BtnCrearVenta_Click;
            // 
            // FrmSales
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(242, 245, 245);
            ClientSize = new Size(1316, 721);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(uiGroupBox1);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox3);
            Controls.Add(BtnAgregarProd);
            Controls.Add(uiPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSales";
            Text = "FrmSales";
            Load += FrmSales_Load;
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox3.ResumeLayout(false);
            uiGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).EndInit();
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Sunny.UI.UIPanel uiGroupBox1;
        private Sunny.UI.UIPanel chip1;
        private Label lblTituloGrupo1;
        private Label label2;
        private Sunny.UI.UITextBox TxtFecha;
        private Label label3;
        private Sunny.UI.UIComboBox CbTipodeDocumento;
        private Sunny.UI.UIPanel uiGroupBox2;
        private Sunny.UI.UIPanel chip2;
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
        private Sunny.UI.UIPanel uiGroupBox3;
        private Sunny.UI.UIPanel chip3;
        private Label label5;
        private Label label6;
        private Sunny.UI.UITextBox TxtcodProd;
        private Sunny.UI.UISymbolButton BtnBuscarProd;
        private TextBox TxtidProd;
        private Label label7;
        private Sunny.UI.UITextBox TxtNombreProd;
        private Label label8;
        private Sunny.UI.UITextBox TxtPrecioVenta;
        private Label label10;
        private Sunny.UI.UITextBox TxtStock;
        private Label label12;
        private NumericUpDown TxtCantidad;
        private Sunny.UI.UISymbolButton BtnAgregarProd;
        private Sunny.UI.UIPanel uiPanel1;
        private Label lblGridTitulo;
        private ModernControls.ModernGrid DgvData;
        private Label linePie;
        private Label label15;
        private Sunny.UI.UITextBox TxtTotalPago;
        private Label label20;
        private Sunny.UI.UITextBox TxtPagaCon;
        private Label label21;
        private Sunny.UI.UITextBox TxtCambio;
        private Sunny.UI.UISymbolButton BtnCrearVenta;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn BtnEliminar;
    }
}