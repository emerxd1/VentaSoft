namespace Main
{
    partial class FrmPurchase
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
            groupBox1 = new Sunny.UI.UIPanel();
            chip1 = new Sunny.UI.UIPanel();
            lblTituloGrupo1 = new Label();
            label2 = new Label();
            TxtFecha = new Sunny.UI.UITextBox();
            label1 = new Label();
            CbTipodeDocumento = new Sunny.UI.UIComboBox();
            groupBox2 = new Sunny.UI.UIPanel();
            chip2 = new Sunny.UI.UIPanel();
            lblTituloGrupo2 = new Label();
            label3 = new Label();
            TxtdocProveedor = new Sunny.UI.UITextBox();
            BtnsearchPro = new Sunny.UI.UISymbolButton();
            label4 = new Label();
            TxtnameProveedor = new Sunny.UI.UITextBox();
            TxtidProv = new TextBox();
            groupBox3 = new Sunny.UI.UIPanel();
            chip3 = new Sunny.UI.UIPanel();
            lblTituloGrupo3 = new Label();
            label5 = new Label();
            TxtcodProd = new Sunny.UI.UITextBox();
            BtnBuscarProd = new Sunny.UI.UISymbolButton();
            TxtidProd = new TextBox();
            label6 = new Label();
            TxtNombreProd = new Sunny.UI.UITextBox();
            label7 = new Label();
            TxtPrecioCompra = new Sunny.UI.UITextBox();
            label8 = new Label();
            TxtPrecioVenta = new Sunny.UI.UITextBox();
            label9 = new Label();
            TxtCantidad = new NumericUpDown();
            BtnAgregarProd = new Sunny.UI.UISymbolButton();
            uiPanelGrid = new Sunny.UI.UIPanel();
            lblGridTitulo = new Label();
            DgvData = new ModernControls.ModernGrid();
            idProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Canti = new DataGridViewTextBoxColumn();
            Subto = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewTextBoxColumn();
            linePie = new Label();
            lblHint = new Label();
            label10 = new Label();
            TxtTotalPago = new Sunny.UI.UITextBox();
            BtnRegistrer = new Sunny.UI.UISymbolButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).BeginInit();
            uiPanelGrid.SuspendLayout();
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
            lblTitulo.Size = new Size(1516, 34);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Registro de compra";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.FromArgb(242, 245, 245);
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(70, 86, 79);
            lblSubtitulo.Location = new Point(28, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(1561, 20);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Registra los productos recibidos de un proveedor y genera el documento de compra.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 245, 245);
            groupBox1.Controls.Add(chip1);
            groupBox1.Controls.Add(lblTituloGrupo1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CbTipodeDocumento);
            groupBox1.FillColor = Color.White;
            groupBox1.FillColor2 = Color.White;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 76);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Radius = 10;
            groupBox1.RectColor = Color.FromArgb(221, 228, 227);
            groupBox1.Size = new Size(404, 106);
            groupBox1.TabIndex = 3;
            groupBox1.Text = null;
            groupBox1.TextAlignment = ContentAlignment.MiddleCenter;
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
            lblTituloGrupo1.Text = "Datos de la compra";
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
            TxtFecha.TextChanged += TxtFecha_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(70, 86, 79);
            label1.Location = new Point(210, 42);
            label1.Name = "label1";
            label1.Size = new Size(178, 18);
            label1.TabIndex = 8;
            label1.Text = "Tipo de documento*";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 245, 245);
            groupBox2.Controls.Add(chip2);
            groupBox2.Controls.Add(lblTituloGrupo2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TxtdocProveedor);
            groupBox2.Controls.Add(BtnsearchPro);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtnameProveedor);
            groupBox2.Controls.Add(TxtidProv);
            groupBox2.FillColor = Color.White;
            groupBox2.FillColor2 = Color.White;
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 190);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.MinimumSize = new Size(1, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Radius = 10;
            groupBox2.RectColor = Color.FromArgb(221, 228, 227);
            groupBox2.Size = new Size(404, 162);
            groupBox2.TabIndex = 10;
            groupBox2.Text = null;
            groupBox2.TextAlignment = ContentAlignment.MiddleCenter;
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
            // lblTituloGrupo2
            // 
            lblTituloGrupo2.BackColor = Color.White;
            lblTituloGrupo2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloGrupo2.ForeColor = Color.FromArgb(20, 32, 30);
            lblTituloGrupo2.Location = new Point(46, 10);
            lblTituloGrupo2.Name = "lblTituloGrupo2";
            lblTituloGrupo2.Size = new Size(294, 24);
            lblTituloGrupo2.TabIndex = 12;
            lblTituloGrupo2.Text = "Proveedor";
            lblTituloGrupo2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(70, 86, 79);
            label3.Location = new Point(16, 42);
            label3.Name = "label3";
            label3.Size = new Size(200, 18);
            label3.TabIndex = 13;
            label3.Text = "RUC*";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtdocProveedor
            // 
            TxtdocProveedor.BackColor = Color.White;
            TxtdocProveedor.Cursor = Cursors.IBeam;
            TxtdocProveedor.FillColor2 = Color.White;
            TxtdocProveedor.FillReadOnlyColor = Color.White;
            TxtdocProveedor.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtdocProveedor.ForeColor = Color.FromArgb(20, 32, 30);
            TxtdocProveedor.ForeDisableColor = Color.Gray;
            TxtdocProveedor.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtdocProveedor.ImeMode = ImeMode.Disable;
            TxtdocProveedor.Location = new Point(16, 60);
            TxtdocProveedor.Margin = new Padding(3, 2, 3, 2);
            TxtdocProveedor.MinimumSize = new Size(1, 16);
            TxtdocProveedor.Name = "TxtdocProveedor";
            TxtdocProveedor.Padding = new Padding(5);
            TxtdocProveedor.Radius = 6;
            TxtdocProveedor.ReadOnly = true;
            TxtdocProveedor.RectColor = Color.FromArgb(201, 211, 209);
            TxtdocProveedor.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtdocProveedor.ShowText = false;
            TxtdocProveedor.Size = new Size(324, 34);
            TxtdocProveedor.Style = Sunny.UI.UIStyle.Custom;
            TxtdocProveedor.TabIndex = 14;
            TxtdocProveedor.TextAlignment = ContentAlignment.MiddleLeft;
            TxtdocProveedor.Watermark = "Autogenerado";
            // 
            // BtnsearchPro
            // 
            BtnsearchPro.BackColor = Color.White;
            BtnsearchPro.Cursor = Cursors.Hand;
            BtnsearchPro.FillColor = Color.White;
            BtnsearchPro.FillDisableColor = Color.FromArgb(230, 236, 235);
            BtnsearchPro.FillHoverColor = Color.FromArgb(238, 246, 245);
            BtnsearchPro.FillPressColor = Color.FromArgb(223, 243, 239);
            BtnsearchPro.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnsearchPro.ForeColor = Color.FromArgb(20, 32, 30);
            BtnsearchPro.ForeDisableColor = Color.FromArgb(95, 111, 107);
            BtnsearchPro.ForeHoverColor = Color.FromArgb(20, 32, 30);
            BtnsearchPro.ForePressColor = Color.FromArgb(20, 32, 30);
            BtnsearchPro.Location = new Point(348, 60);
            BtnsearchPro.MinimumSize = new Size(1, 1);
            BtnsearchPro.Name = "BtnsearchPro";
            BtnsearchPro.Radius = 6;
            BtnsearchPro.RectColor = Color.FromArgb(201, 211, 209);
            BtnsearchPro.RectDisableColor = Color.FromArgb(221, 228, 227);
            BtnsearchPro.RectHoverColor = Color.FromArgb(15, 118, 110);
            BtnsearchPro.RectPressColor = Color.FromArgb(8, 76, 71);
            BtnsearchPro.RectSelectedColor = Color.FromArgb(201, 211, 209);
            BtnsearchPro.Size = new Size(40, 34);
            BtnsearchPro.Style = Sunny.UI.UIStyle.Custom;
            BtnsearchPro.Symbol = 61442;
            BtnsearchPro.SymbolColor = Color.FromArgb(15, 118, 110);
            BtnsearchPro.SymbolHoverColor = Color.FromArgb(15, 118, 110);
            BtnsearchPro.SymbolPressColor = Color.FromArgb(15, 118, 110);
            BtnsearchPro.SymbolSize = 18;
            BtnsearchPro.TabIndex = 15;
            BtnsearchPro.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnsearchPro.Click += BtnsearchPro_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(70, 86, 79);
            label4.Location = new Point(16, 100);
            label4.Name = "label4";
            label4.Size = new Size(200, 18);
            label4.TabIndex = 16;
            label4.Text = "Razón social*";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtnameProveedor
            // 
            TxtnameProveedor.BackColor = Color.White;
            TxtnameProveedor.Cursor = Cursors.IBeam;
            TxtnameProveedor.FillReadOnlyColor = Color.White;
            TxtnameProveedor.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtnameProveedor.ForeColor = Color.FromArgb(20, 32, 30);
            TxtnameProveedor.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtnameProveedor.ImeMode = ImeMode.Disable;
            TxtnameProveedor.Location = new Point(16, 118);
            TxtnameProveedor.Margin = new Padding(3, 2, 3, 2);
            TxtnameProveedor.MinimumSize = new Size(1, 16);
            TxtnameProveedor.Name = "TxtnameProveedor";
            TxtnameProveedor.Padding = new Padding(5);
            TxtnameProveedor.Radius = 6;
            TxtnameProveedor.ReadOnly = true;
            TxtnameProveedor.RectColor = Color.FromArgb(201, 211, 209);
            TxtnameProveedor.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtnameProveedor.ShowText = false;
            TxtnameProveedor.Size = new Size(372, 33);
            TxtnameProveedor.Style = Sunny.UI.UIStyle.Custom;
            TxtnameProveedor.TabIndex = 17;
            TxtnameProveedor.TextAlignment = ContentAlignment.MiddleLeft;
            TxtnameProveedor.Watermark = "Autogenerado";
            // 
            // TxtidProv
            // 
            TxtidProv.Location = new Point(300, 12);
            TxtidProv.Name = "TxtidProv";
            TxtidProv.Size = new Size(40, 25);
            TxtidProv.TabIndex = 18;
            TxtidProv.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(242, 245, 245);
            groupBox3.Controls.Add(chip3);
            groupBox3.Controls.Add(lblTituloGrupo3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(TxtcodProd);
            groupBox3.Controls.Add(BtnBuscarProd);
            groupBox3.Controls.Add(TxtidProd);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TxtNombreProd);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(TxtPrecioCompra);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(TxtPrecioVenta);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(TxtCantidad);
            groupBox3.FillColor = Color.White;
            groupBox3.FillColor2 = Color.White;
            groupBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(28, 362);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.MinimumSize = new Size(1, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Radius = 10;
            groupBox3.RectColor = Color.FromArgb(221, 228, 227);
            groupBox3.Size = new Size(404, 222);
            groupBox3.TabIndex = 19;
            groupBox3.Text = null;
            groupBox3.TextAlignment = ContentAlignment.MiddleCenter;
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
            chip3.TabIndex = 20;
            chip3.Text = "3";
            chip3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrupo3
            // 
            lblTituloGrupo3.BackColor = Color.White;
            lblTituloGrupo3.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloGrupo3.ForeColor = Color.FromArgb(20, 32, 30);
            lblTituloGrupo3.Location = new Point(46, 10);
            lblTituloGrupo3.Name = "lblTituloGrupo3";
            lblTituloGrupo3.Size = new Size(300, 24);
            lblTituloGrupo3.TabIndex = 21;
            lblTituloGrupo3.Text = "Producto";
            lblTituloGrupo3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(70, 86, 79);
            label5.Location = new Point(16, 42);
            label5.Name = "label5";
            label5.Size = new Size(200, 18);
            label5.TabIndex = 22;
            label5.Text = "Código del producto";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtcodProd
            // 
            TxtcodProd.BackColor = Color.White;
            TxtcodProd.Cursor = Cursors.IBeam;
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
            TxtcodProd.TabIndex = 23;
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
            BtnBuscarProd.TabIndex = 24;
            BtnBuscarProd.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarProd.Click += BtnBuscarProd_Click;
            // 
            // TxtidProd
            // 
            TxtidProd.Location = new Point(300, 12);
            TxtidProd.Name = "TxtidProd";
            TxtidProd.Size = new Size(40, 25);
            TxtidProd.TabIndex = 25;
            TxtidProd.Visible = false;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(70, 86, 79);
            label6.Location = new Point(16, 100);
            label6.Name = "label6";
            label6.Size = new Size(200, 18);
            label6.TabIndex = 26;
            label6.Text = "Producto";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNombreProd
            // 
            TxtNombreProd.BackColor = Color.White;
            TxtNombreProd.Cursor = Cursors.IBeam;
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
            TxtNombreProd.TabIndex = 27;
            TxtNombreProd.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombreProd.Watermark = "Autogenerado";
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(70, 86, 79);
            label7.Location = new Point(16, 158);
            label7.Name = "label7";
            label7.Size = new Size(116, 18);
            label7.TabIndex = 28;
            label7.Text = "P. compra*";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtPrecioCompra
            // 
            TxtPrecioCompra.BackColor = Color.White;
            TxtPrecioCompra.Cursor = Cursors.IBeam;
            TxtPrecioCompra.FillReadOnlyColor = Color.White;
            TxtPrecioCompra.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecioCompra.ForeColor = Color.FromArgb(20, 32, 30);
            TxtPrecioCompra.Location = new Point(16, 176);
            TxtPrecioCompra.Margin = new Padding(3, 2, 3, 2);
            TxtPrecioCompra.MinimumSize = new Size(1, 16);
            TxtPrecioCompra.Name = "TxtPrecioCompra";
            TxtPrecioCompra.Padding = new Padding(5);
            TxtPrecioCompra.Radius = 6;
            TxtPrecioCompra.RectColor = Color.FromArgb(201, 211, 209);
            TxtPrecioCompra.ShowText = false;
            TxtPrecioCompra.Size = new Size(116, 29);
            TxtPrecioCompra.Style = Sunny.UI.UIStyle.Custom;
            TxtPrecioCompra.TabIndex = 29;
            TxtPrecioCompra.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPrecioCompra.Watermark = "Ej: 23";
            TxtPrecioCompra.KeyDown += TxtPrecioCompra_KeyDown;
            TxtPrecioCompra.KeyPress += TxtPrecioCompra_KeyPress;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(70, 86, 79);
            label8.Location = new Point(144, 158);
            label8.Name = "label8";
            label8.Size = new Size(116, 18);
            label8.TabIndex = 30;
            label8.Text = "P. venta*";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtPrecioVenta
            // 
            TxtPrecioVenta.BackColor = Color.White;
            TxtPrecioVenta.Cursor = Cursors.IBeam;
            TxtPrecioVenta.FillReadOnlyColor = Color.White;
            TxtPrecioVenta.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtPrecioVenta.ForeColor = Color.FromArgb(20, 32, 30);
            TxtPrecioVenta.Location = new Point(144, 176);
            TxtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            TxtPrecioVenta.MinimumSize = new Size(1, 16);
            TxtPrecioVenta.Name = "TxtPrecioVenta";
            TxtPrecioVenta.Padding = new Padding(5);
            TxtPrecioVenta.Radius = 6;
            TxtPrecioVenta.RectColor = Color.FromArgb(201, 211, 209);
            TxtPrecioVenta.ShowText = false;
            TxtPrecioVenta.Size = new Size(116, 29);
            TxtPrecioVenta.Style = Sunny.UI.UIStyle.Custom;
            TxtPrecioVenta.TabIndex = 31;
            TxtPrecioVenta.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPrecioVenta.Watermark = "Ej: 28";
            TxtPrecioVenta.KeyDown += TxtPrecioVenta_KeyDown;
            TxtPrecioVenta.KeyPress += TxtPrecioVenta_KeyPress;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(70, 86, 79);
            label9.Location = new Point(272, 158);
            label9.Name = "label9";
            label9.Size = new Size(116, 18);
            label9.TabIndex = 32;
            label9.Text = "Cantidad*";
            label9.TextAlign = ContentAlignment.MiddleLeft;
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
            TxtCantidad.TabIndex = 33;
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
            BtnAgregarProd.Location = new Point(28, 596);
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
            BtnAgregarProd.TabIndex = 34;
            BtnAgregarProd.Text = "Agregar a la compra";
            BtnAgregarProd.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregarProd.Click += BtnAgregarProd_Click;
            // 
            // uiPanelGrid
            // 
            uiPanelGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanelGrid.BackColor = Color.FromArgb(242, 245, 245);
            uiPanelGrid.Controls.Add(lblGridTitulo);
            uiPanelGrid.Controls.Add(DgvData);
            uiPanelGrid.Controls.Add(linePie);
            uiPanelGrid.Controls.Add(lblHint);
            uiPanelGrid.Controls.Add(label10);
            uiPanelGrid.Controls.Add(TxtTotalPago);
            uiPanelGrid.Controls.Add(BtnRegistrer);
            uiPanelGrid.FillColor = Color.White;
            uiPanelGrid.FillColor2 = Color.White;
            uiPanelGrid.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiPanelGrid.Location = new Point(444, 76);
            uiPanelGrid.Margin = new Padding(4, 5, 4, 5);
            uiPanelGrid.MinimumSize = new Size(1, 1);
            uiPanelGrid.Name = "uiPanelGrid";
            uiPanelGrid.Radius = 10;
            uiPanelGrid.RectColor = Color.FromArgb(221, 228, 227);
            uiPanelGrid.Size = new Size(844, 564);
            uiPanelGrid.TabIndex = 35;
            uiPanelGrid.Text = null;
            uiPanelGrid.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblGridTitulo
            // 
            lblGridTitulo.BackColor = Color.White;
            lblGridTitulo.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGridTitulo.ForeColor = Color.FromArgb(20, 32, 30);
            lblGridTitulo.Location = new Point(20, 14);
            lblGridTitulo.Name = "lblGridTitulo";
            lblGridTitulo.Size = new Size(400, 24);
            lblGridTitulo.TabIndex = 36;
            lblGridTitulo.Text = "Productos de la compra";
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
            DgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, Producto, PrecioCompra, PrecioVenta, Canti, Subto, BtnEliminar });
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
            DgvData.Size = new Size(828, 428);
            DgvData.TabIndex = 37;
            DgvData.CellClick += DgvData_CellClick;
            DgvData.CellValueChanged += DgvData_CellValueChanged;
            // 
            // idProducto
            // 
            idProducto.FillWeight = 60F;
            idProducto.HeaderText = "Id";
            idProducto.Name = "idProducto";
            idProducto.ReadOnly = true;
            idProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            idProducto.Visible = false;
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
            // PrecioCompra
            // 
            PrecioCompra.FillWeight = 122F;
            PrecioCompra.HeaderText = "Precio compra";
            PrecioCompra.MinimumWidth = 122;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVenta
            // 
            PrecioVenta.FillWeight = 110F;
            PrecioVenta.HeaderText = "Precio venta";
            PrecioVenta.MinimumWidth = 110;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Canti
            // 
            Canti.FillWeight = 89F;
            Canti.HeaderText = "Cantidad";
            Canti.MinimumWidth = 89;
            Canti.Name = "Canti";
            Canti.ReadOnly = true;
            Canti.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Subto
            // 
            Subto.FillWeight = 90F;
            Subto.HeaderText = "Sub total";
            Subto.MinimumWidth = 90;
            Subto.Name = "Subto";
            Subto.ReadOnly = true;
            Subto.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            linePie.Location = new Point(1, 480);
            linePie.Name = "linePie";
            linePie.Size = new Size(842, 1);
            linePie.TabIndex = 38;
            // 
            // lblHint
            // 
            lblHint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblHint.BackColor = Color.White;
            lblHint.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHint.ForeColor = Color.FromArgb(95, 111, 107);
            lblHint.Location = new Point(20, 502);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(380, 20);
            lblHint.TabIndex = 39;
            lblHint.Text = "Haz clic en la papelera de una fila para quitarla de la compra.";
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(70, 86, 79);
            label10.Location = new Point(400, 490);
            label10.Name = "label10";
            label10.Size = new Size(200, 18);
            label10.TabIndex = 40;
            label10.Text = "Total a pagar";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtTotalPago
            // 
            TxtTotalPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TxtTotalPago.BackColor = Color.White;
            TxtTotalPago.Cursor = Cursors.IBeam;
            TxtTotalPago.FillReadOnlyColor = Color.White;
            TxtTotalPago.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTotalPago.ForeColor = Color.FromArgb(20, 32, 30);
            TxtTotalPago.ForeReadOnlyColor = Color.FromArgb(11, 94, 88);
            TxtTotalPago.ImeMode = ImeMode.Disable;
            TxtTotalPago.Location = new Point(400, 508);
            TxtTotalPago.Margin = new Padding(3, 2, 3, 2);
            TxtTotalPago.MinimumSize = new Size(1, 16);
            TxtTotalPago.Name = "TxtTotalPago";
            TxtTotalPago.Padding = new Padding(5);
            TxtTotalPago.Radius = 6;
            TxtTotalPago.ReadOnly = true;
            TxtTotalPago.RectColor = Color.FromArgb(201, 211, 209);
            TxtTotalPago.RectReadOnlyColor = Color.White;
            TxtTotalPago.ShowText = false;
            TxtTotalPago.Size = new Size(200, 40);
            TxtTotalPago.Style = Sunny.UI.UIStyle.Custom;
            TxtTotalPago.TabIndex = 41;
            TxtTotalPago.Text = "0.00";
            TxtTotalPago.TextAlignment = ContentAlignment.MiddleRight;
            TxtTotalPago.Watermark = "";
            TxtTotalPago.TextChanged += TxtTotalPago_TextChanged;
            // 
            // BtnRegistrer
            // 
            BtnRegistrer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnRegistrer.BackColor = Color.White;
            BtnRegistrer.Cursor = Cursors.Hand;
            BtnRegistrer.FillColor = Color.FromArgb(15, 118, 110);
            BtnRegistrer.FillDisableColor = Color.FromArgb(230, 236, 235);
            BtnRegistrer.FillHoverColor = Color.FromArgb(11, 94, 88);
            BtnRegistrer.FillPressColor = Color.FromArgb(8, 76, 71);
            BtnRegistrer.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRegistrer.ForeDisableColor = Color.FromArgb(95, 111, 107);
            BtnRegistrer.Location = new Point(616, 502);
            BtnRegistrer.MinimumSize = new Size(1, 1);
            BtnRegistrer.Name = "BtnRegistrer";
            BtnRegistrer.Radius = 6;
            BtnRegistrer.RectColor = Color.FromArgb(15, 118, 110);
            BtnRegistrer.RectDisableColor = Color.FromArgb(230, 236, 235);
            BtnRegistrer.RectHoverColor = Color.FromArgb(11, 94, 88);
            BtnRegistrer.RectPressColor = Color.FromArgb(8, 76, 71);
            BtnRegistrer.RectSelectedColor = Color.FromArgb(15, 118, 110);
            BtnRegistrer.Size = new Size(208, 44);
            BtnRegistrer.Style = Sunny.UI.UIStyle.Custom;
            BtnRegistrer.Symbol = 61452;
            BtnRegistrer.SymbolSize = 18;
            BtnRegistrer.TabIndex = 42;
            BtnRegistrer.Text = "Registrar compra";
            BtnRegistrer.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRegistrer.Click += BtnRegistrer_Click;
            // 
            // FrmPurchase
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(242, 245, 245);
            ClientSize = new Size(1316, 721);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(BtnAgregarProd);
            Controls.Add(uiPanelGrid);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPurchase";
            Text = "FrmPurchase";
            Load += FrmPurchase_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).EndInit();
            uiPanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Sunny.UI.UIPanel groupBox1;
        private Sunny.UI.UIPanel chip1;
        private Label lblTituloGrupo1;
        private Label label2;
        private Sunny.UI.UITextBox TxtFecha;
        private Label label1;
        private Sunny.UI.UIComboBox CbTipodeDocumento;
        private Sunny.UI.UIPanel groupBox2;
        private Sunny.UI.UIPanel chip2;
        private Label lblTituloGrupo2;
        private Label label3;
        private Sunny.UI.UITextBox TxtdocProveedor;
        private Sunny.UI.UISymbolButton BtnsearchPro;
        private Label label4;
        private Sunny.UI.UITextBox TxtnameProveedor;
        private TextBox TxtidProv;
        private Sunny.UI.UIPanel groupBox3;
        private Sunny.UI.UIPanel chip3;
        private Label lblTituloGrupo3;
        private Label label5;
        private Sunny.UI.UITextBox TxtcodProd;
        private Sunny.UI.UISymbolButton BtnBuscarProd;
        private TextBox TxtidProd;
        private Label label6;
        private Sunny.UI.UITextBox TxtNombreProd;
        private Label label7;
        private Sunny.UI.UITextBox TxtPrecioCompra;
        private Label label8;
        private Sunny.UI.UITextBox TxtPrecioVenta;
        private Label label9;
        private NumericUpDown TxtCantidad;
        private Sunny.UI.UISymbolButton BtnAgregarProd;
        private Sunny.UI.UIPanel uiPanelGrid;
        private Label lblGridTitulo;
        private ModernControls.ModernGrid DgvData;
        private Label linePie;
        private Label lblHint;
        private Label label10;
        private Sunny.UI.UITextBox TxtTotalPago;
        private Sunny.UI.UISymbolButton BtnRegistrer;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Canti;
        private DataGridViewTextBoxColumn Subto;
        private DataGridViewTextBoxColumn BtnEliminar;
    }
}