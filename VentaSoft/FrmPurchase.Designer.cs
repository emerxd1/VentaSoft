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
            groupBox1 = new Sunny.UI.UIPanel();
            lblTituloGrupo1 = new Label();
            label2 = new Label();
            TxtFecha = new Sunny.UI.UITextBox();
            label1 = new Label();
            CbTipodeDocumento = new Sunny.UI.UIComboBox();
            groupBox2 = new Sunny.UI.UIPanel();
            lblTituloGrupo2 = new Label();
            label3 = new Label();
            TxtdocProveedor = new Sunny.UI.UITextBox();
            BtnsearchPro = new Sunny.UI.UISymbolButton();
            label4 = new Label();
            TxtnameProveedor = new Sunny.UI.UITextBox();
            TxtidProv = new TextBox();
            groupBox3 = new Sunny.UI.UIPanel();
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
            uiPanelGrid = new Sunny.UI.UIPanel();
            DgvData = new ModernControls.ModernGrid();
            idProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Canti = new DataGridViewTextBoxColumn();
            Subto = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewTextBoxColumn();
            BtnAgregarProd = new Sunny.UI.UISymbolButton();
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
            lblTitulo.BackColor = Color.FromArgb(8, 92, 63);
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(8, 0, 0, 0);
            lblTitulo.Size = new Size(976, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Compra";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(lblTituloGrupo1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CbTipodeDocumento);
            groupBox1.FillColor = Color.White;
            groupBox1.FillColor2 = Color.White;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Radius = 12;
            groupBox1.RectColor = Color.Silver;
            groupBox1.Size = new Size(348, 96);
            groupBox1.TabIndex = 1;
            groupBox1.Text = null;
            groupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrupo1
            // 
            lblTituloGrupo1.BackColor = Color.FromArgb(8, 92, 63);
            lblTituloGrupo1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrupo1.ForeColor = Color.White;
            lblTituloGrupo1.Location = new Point(3, 1);
            lblTituloGrupo1.Name = "lblTituloGrupo1";
            lblTituloGrupo1.Padding = new Padding(8, 0, 0, 0);
            lblTituloGrupo1.Size = new Size(342, 22);
            lblTituloGrupo1.TabIndex = 0;
            lblTituloGrupo1.Text = "Información de la Compra";
            lblTituloGrupo1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(31, 58, 48);
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha*";
            // 
            // TxtFecha
            // 
            TxtFecha.Cursor = Cursors.IBeam;
            TxtFecha.FillReadOnlyColor = Color.White;
            TxtFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFecha.ForeReadOnlyColor = Color.White;
            TxtFecha.Location = new Point(14, 52);
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
            TxtFecha.TabIndex = 2;
            TxtFecha.TextAlignment = ContentAlignment.MiddleLeft;
            TxtFecha.Watermark = "";
            TxtFecha.TextChanged += TxtFecha_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(31, 58, 48);
            label1.Location = new Point(176, 30);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Documento*";
            // 
            // CbTipodeDocumento
            // 
            CbTipodeDocumento.BackgroundImageLayout = ImageLayout.Center;
            CbTipodeDocumento.Cursor = Cursors.HSplit;
            CbTipodeDocumento.DataSource = null;
            CbTipodeDocumento.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            CbTipodeDocumento.FillColor = Color.White;
            CbTipodeDocumento.Font = new Font("Microsoft Sans Serif", 12F);
            CbTipodeDocumento.ItemHoverColor = Color.FromArgb(201, 228, 217);
            CbTipodeDocumento.ItemRectColor = Color.FromArgb(57, 79, 71);
            CbTipodeDocumento.ItemSelectBackColor = Color.Silver;
            CbTipodeDocumento.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            CbTipodeDocumento.Location = new Point(176, 51);
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
            CbTipodeDocumento.TabIndex = 4;
            CbTipodeDocumento.TextAlignment = ContentAlignment.MiddleLeft;
            CbTipodeDocumento.Watermark = "";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblTituloGrupo2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TxtdocProveedor);
            groupBox2.Controls.Add(BtnsearchPro);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtnameProveedor);
            groupBox2.Controls.Add(TxtidProv);
            groupBox2.FillColor = Color.White;
            groupBox2.FillColor2 = Color.White;
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(12, 154);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.MinimumSize = new Size(1, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Radius = 12;
            groupBox2.RectColor = Color.Silver;
            groupBox2.Size = new Size(348, 150);
            groupBox2.TabIndex = 2;
            groupBox2.Text = null;
            groupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrupo2
            // 
            lblTituloGrupo2.BackColor = Color.FromArgb(8, 92, 63);
            lblTituloGrupo2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrupo2.ForeColor = Color.White;
            lblTituloGrupo2.Location = new Point(3, 0);
            lblTituloGrupo2.Name = "lblTituloGrupo2";
            lblTituloGrupo2.Padding = new Padding(8, 0, 0, 0);
            lblTituloGrupo2.Size = new Size(342, 22);
            lblTituloGrupo2.TabIndex = 0;
            lblTituloGrupo2.Text = "Información del Proveedor";
            lblTituloGrupo2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(31, 58, 48);
            label3.Location = new Point(14, 30);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 1;
            label3.Text = "RUC*";
            // 
            // TxtdocProveedor
            // 
            TxtdocProveedor.Cursor = Cursors.IBeam;
            TxtdocProveedor.FillReadOnlyColor = Color.White;
            TxtdocProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtdocProveedor.Location = new Point(14, 52);
            TxtdocProveedor.Margin = new Padding(3, 2, 3, 2);
            TxtdocProveedor.MinimumSize = new Size(1, 16);
            TxtdocProveedor.Name = "TxtdocProveedor";
            TxtdocProveedor.Padding = new Padding(5);
            TxtdocProveedor.Radius = 10;
            TxtdocProveedor.ReadOnly = true;
            TxtdocProveedor.RectColor = Color.Silver;
            TxtdocProveedor.ShowText = false;
            TxtdocProveedor.Size = new Size(270, 28);
            TxtdocProveedor.Style = Sunny.UI.UIStyle.Custom;
            TxtdocProveedor.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtdocProveedor.TabIndex = 2;
            TxtdocProveedor.TextAlignment = ContentAlignment.MiddleLeft;
            TxtdocProveedor.Watermark = "AUTOGENERADO";
            // 
            // BtnsearchPro
            // 
            BtnsearchPro.BackColor = Color.Transparent;
            BtnsearchPro.FillColor = Color.FromArgb(0, 192, 0);
            BtnsearchPro.FillColor2 = Color.FromArgb(11, 127, 87);
            BtnsearchPro.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnsearchPro.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnsearchPro.FillPressColor = Color.Silver;
            BtnsearchPro.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnsearchPro.Location = new Point(292, 50);
            BtnsearchPro.MinimumSize = new Size(1, 1);
            BtnsearchPro.Name = "BtnsearchPro";
            BtnsearchPro.Radius = 12;
            BtnsearchPro.RectColor = Color.White;
            BtnsearchPro.RectDisableColor = Color.White;
            BtnsearchPro.RectHoverColor = Color.White;
            BtnsearchPro.RectPressColor = Color.White;
            BtnsearchPro.RectSelectedColor = Color.White;
            BtnsearchPro.ShowFocusLine = true;
            BtnsearchPro.Size = new Size(44, 32);
            BtnsearchPro.Style = Sunny.UI.UIStyle.Custom;
            BtnsearchPro.Symbol = 61442;
            BtnsearchPro.TabIndex = 3;
            BtnsearchPro.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnsearchPro.Click += BtnsearchPro_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(31, 58, 48);
            label4.Location = new Point(14, 90);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 4;
            label4.Text = "Razón Social*";
            // 
            // TxtnameProveedor
            // 
            TxtnameProveedor.Cursor = Cursors.IBeam;
            TxtnameProveedor.FillReadOnlyColor = Color.White;
            TxtnameProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtnameProveedor.Location = new Point(14, 112);
            TxtnameProveedor.Margin = new Padding(3, 2, 3, 2);
            TxtnameProveedor.MinimumSize = new Size(1, 16);
            TxtnameProveedor.Name = "TxtnameProveedor";
            TxtnameProveedor.Padding = new Padding(5);
            TxtnameProveedor.Radius = 10;
            TxtnameProveedor.ReadOnly = true;
            TxtnameProveedor.RectColor = Color.Silver;
            TxtnameProveedor.ShowText = false;
            TxtnameProveedor.Size = new Size(322, 28);
            TxtnameProveedor.Style = Sunny.UI.UIStyle.Custom;
            TxtnameProveedor.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtnameProveedor.TabIndex = 5;
            TxtnameProveedor.TextAlignment = ContentAlignment.MiddleLeft;
            TxtnameProveedor.Watermark = "AUTOGENERADO";
            // 
            // TxtidProv
            // 
            TxtidProv.Location = new Point(244, 81);
            TxtidProv.Name = "TxtidProv";
            TxtidProv.Size = new Size(40, 26);
            TxtidProv.TabIndex = 6;
            TxtidProv.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
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
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox3.Location = new Point(12, 312);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.MinimumSize = new Size(1, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Radius = 12;
            groupBox3.RectColor = Color.Silver;
            groupBox3.Size = new Size(348, 232);
            groupBox3.TabIndex = 3;
            groupBox3.Text = null;
            groupBox3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrupo3
            // 
            lblTituloGrupo3.BackColor = Color.FromArgb(8, 92, 63);
            lblTituloGrupo3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrupo3.ForeColor = Color.White;
            lblTituloGrupo3.Location = new Point(3, 1);
            lblTituloGrupo3.Name = "lblTituloGrupo3";
            lblTituloGrupo3.Padding = new Padding(8, 0, 0, 0);
            lblTituloGrupo3.Size = new Size(342, 22);
            lblTituloGrupo3.TabIndex = 0;
            lblTituloGrupo3.Text = "Información del Producto";
            lblTituloGrupo3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(31, 58, 48);
            label5.Location = new Point(14, 30);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 1;
            label5.Text = "Cód. del Producto";
            // 
            // TxtcodProd
            // 
            TxtcodProd.Cursor = Cursors.IBeam;
            TxtcodProd.FillReadOnlyColor = Color.White;
            TxtcodProd.Font = new Font("Segoe UI", 9F);
            TxtcodProd.Location = new Point(14, 52);
            TxtcodProd.Margin = new Padding(3, 2, 3, 2);
            TxtcodProd.MinimumSize = new Size(1, 16);
            TxtcodProd.Name = "TxtcodProd";
            TxtcodProd.Padding = new Padding(5);
            TxtcodProd.Radius = 10;
            TxtcodProd.RectColor = Color.Silver;
            TxtcodProd.ShowText = false;
            TxtcodProd.Size = new Size(270, 28);
            TxtcodProd.Style = Sunny.UI.UIStyle.Custom;
            TxtcodProd.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtcodProd.TabIndex = 2;
            TxtcodProd.TextAlignment = ContentAlignment.MiddleLeft;
            TxtcodProd.Watermark = "EJ: \"P0001\" ";
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
            BtnBuscarProd.Location = new Point(292, 50);
            BtnBuscarProd.MinimumSize = new Size(1, 1);
            BtnBuscarProd.Name = "BtnBuscarProd";
            BtnBuscarProd.Radius = 12;
            BtnBuscarProd.RectColor = Color.White;
            BtnBuscarProd.RectDisableColor = Color.White;
            BtnBuscarProd.RectHoverColor = Color.White;
            BtnBuscarProd.RectPressColor = Color.White;
            BtnBuscarProd.RectSelectedColor = Color.White;
            BtnBuscarProd.ShowFocusLine = true;
            BtnBuscarProd.Size = new Size(44, 32);
            BtnBuscarProd.Style = Sunny.UI.UIStyle.Custom;
            BtnBuscarProd.Symbol = 61442;
            BtnBuscarProd.TabIndex = 3;
            BtnBuscarProd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnBuscarProd.Click += BtnBuscarProd_Click;
            // 
            // TxtidProd
            // 
            TxtidProd.Location = new Point(244, 26);
            TxtidProd.Name = "TxtidProd";
            TxtidProd.Size = new Size(40, 26);
            TxtidProd.TabIndex = 4;
            TxtidProd.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(31, 58, 48);
            label6.Location = new Point(14, 90);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Producto";
            // 
            // TxtNombreProd
            // 
            TxtNombreProd.Cursor = Cursors.IBeam;
            TxtNombreProd.FillReadOnlyColor = Color.White;
            TxtNombreProd.Font = new Font("Segoe UI", 9F);
            TxtNombreProd.Location = new Point(14, 112);
            TxtNombreProd.Margin = new Padding(3, 2, 3, 2);
            TxtNombreProd.MinimumSize = new Size(1, 16);
            TxtNombreProd.Name = "TxtNombreProd";
            TxtNombreProd.Padding = new Padding(5);
            TxtNombreProd.Radius = 10;
            TxtNombreProd.ReadOnly = true;
            TxtNombreProd.RectColor = Color.Silver;
            TxtNombreProd.ShowText = false;
            TxtNombreProd.Size = new Size(322, 28);
            TxtNombreProd.Style = Sunny.UI.UIStyle.Custom;
            TxtNombreProd.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtNombreProd.TabIndex = 6;
            TxtNombreProd.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombreProd.Watermark = "AUTOGENERADO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(31, 58, 48);
            label7.Location = new Point(14, 152);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 7;
            label7.Text = "P. Compra*";
            // 
            // TxtPrecioCompra
            // 
            TxtPrecioCompra.Cursor = Cursors.IBeam;
            TxtPrecioCompra.FillReadOnlyColor = Color.White;
            TxtPrecioCompra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TxtPrecioCompra.Location = new Point(14, 174);
            TxtPrecioCompra.Margin = new Padding(3, 2, 3, 2);
            TxtPrecioCompra.MinimumSize = new Size(1, 16);
            TxtPrecioCompra.Name = "TxtPrecioCompra";
            TxtPrecioCompra.Padding = new Padding(5);
            TxtPrecioCompra.Radius = 10;
            TxtPrecioCompra.RectColor = Color.Silver;
            TxtPrecioCompra.ShowText = false;
            TxtPrecioCompra.Size = new Size(100, 28);
            TxtPrecioCompra.Style = Sunny.UI.UIStyle.Custom;
            TxtPrecioCompra.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtPrecioCompra.TabIndex = 8;
            TxtPrecioCompra.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPrecioCompra.Watermark = "Ej: 23";
            TxtPrecioCompra.KeyDown += TxtPrecioCompra_KeyDown;
            TxtPrecioCompra.KeyPress += TxtPrecioCompra_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(31, 58, 48);
            label8.Location = new Point(124, 152);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 9;
            label8.Text = "P. Venta*";
            // 
            // TxtPrecioVenta
            // 
            TxtPrecioVenta.Cursor = Cursors.IBeam;
            TxtPrecioVenta.FillReadOnlyColor = Color.White;
            TxtPrecioVenta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            TxtPrecioVenta.Location = new Point(124, 174);
            TxtPrecioVenta.Margin = new Padding(3, 2, 3, 2);
            TxtPrecioVenta.MinimumSize = new Size(1, 16);
            TxtPrecioVenta.Name = "TxtPrecioVenta";
            TxtPrecioVenta.Padding = new Padding(5);
            TxtPrecioVenta.Radius = 10;
            TxtPrecioVenta.RectColor = Color.Silver;
            TxtPrecioVenta.ShowText = false;
            TxtPrecioVenta.Size = new Size(100, 28);
            TxtPrecioVenta.Style = Sunny.UI.UIStyle.Custom;
            TxtPrecioVenta.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtPrecioVenta.TabIndex = 10;
            TxtPrecioVenta.TextAlignment = ContentAlignment.MiddleLeft;
            TxtPrecioVenta.Watermark = "Ej: 2";
            TxtPrecioVenta.KeyDown += TxtPrecioVenta_KeyDown;
            TxtPrecioVenta.KeyPress += TxtPrecioVenta_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(31, 58, 48);
            label9.Location = new Point(234, 152);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 11;
            label9.Text = "Cantidad*";
            // 
            // TxtCantidad
            // 
            TxtCantidad.BackColor = Color.White;
            TxtCantidad.BorderStyle = BorderStyle.FixedSingle;
            TxtCantidad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCantidad.Location = new Point(234, 175);
            TxtCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            TxtCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(100, 27);
            TxtCantidad.TabIndex = 12;
            TxtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.KeyDown += TxtCantidad_KeyDown;
            // 
            // uiPanelGrid
            // 
            uiPanelGrid.BackColor = Color.White;
            uiPanelGrid.Controls.Add(DgvData);
            uiPanelGrid.FillColor = Color.White;
            uiPanelGrid.FillColor2 = Color.White;
            uiPanelGrid.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanelGrid.Location = new Point(372, 50);
            uiPanelGrid.Margin = new Padding(4, 5, 4, 5);
            uiPanelGrid.MinimumSize = new Size(1, 1);
            uiPanelGrid.Name = "uiPanelGrid";
            uiPanelGrid.Radius = 12;
            uiPanelGrid.RectColor = Color.Silver;
            uiPanelGrid.Size = new Size(616, 494);
            uiPanelGrid.TabIndex = 4;
            uiPanelGrid.Text = null;
            uiPanelGrid.TextAlignment = ContentAlignment.MiddleCenter;
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
            DgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, Producto, PrecioCompra, PrecioVenta, Canti, Subto, BtnEliminar });
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
            DgvData.LineColor = Color.FromArgb(200, 208, 204);
            DgvData.Location = new Point(9, 1);
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
            DgvData.Size = new Size(604, 482);
            DgvData.TabIndex = 0;
            DgvData.CellClick += DgvData_CellClick;
            DgvData.CellValueChanged += DgvData_CellClick;
            // 
            // idProducto
            // 
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
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 122;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVenta
            // 
            PrecioVenta.FillWeight = 110F;
            PrecioVenta.HeaderText = "Precio Venta";
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
            Subto.HeaderText = "Sub Total";
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
            // BtnAgregarProd
            // 
            BtnAgregarProd.BackColor = Color.Transparent;
            BtnAgregarProd.FillColor = Color.FromArgb(0, 192, 0);
            BtnAgregarProd.FillColor2 = Color.FromArgb(11, 127, 87);
            BtnAgregarProd.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnAgregarProd.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnAgregarProd.FillPressColor = Color.Silver;
            BtnAgregarProd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarProd.Location = new Point(12, 556);
            BtnAgregarProd.MinimumSize = new Size(1, 1);
            BtnAgregarProd.Name = "BtnAgregarProd";
            BtnAgregarProd.Radius = 15;
            BtnAgregarProd.RectColor = Color.White;
            BtnAgregarProd.RectDisableColor = Color.White;
            BtnAgregarProd.RectHoverColor = Color.White;
            BtnAgregarProd.RectPressColor = Color.White;
            BtnAgregarProd.RectSelectedColor = Color.White;
            BtnAgregarProd.ShowFocusLine = true;
            BtnAgregarProd.Size = new Size(348, 40);
            BtnAgregarProd.Style = Sunny.UI.UIStyle.Custom;
            BtnAgregarProd.Symbol = 61543;
            BtnAgregarProd.TabIndex = 5;
            BtnAgregarProd.Text = "Agregar producto";
            BtnAgregarProd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnAgregarProd.Click += BtnAgregarProd_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(57, 79, 71);
            label10.Location = new Point(372, 566);
            label10.Name = "label10";
            label10.Size = new Size(114, 21);
            label10.TabIndex = 6;
            label10.Text = "Total a Pagar:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtTotalPago
            // 
            TxtTotalPago.BackColor = Color.White;
            TxtTotalPago.Cursor = Cursors.IBeam;
            TxtTotalPago.FillReadOnlyColor = Color.White;
            TxtTotalPago.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTotalPago.Location = new Point(496, 560);
            TxtTotalPago.Margin = new Padding(3, 2, 3, 2);
            TxtTotalPago.MinimumSize = new Size(1, 16);
            TxtTotalPago.Name = "TxtTotalPago";
            TxtTotalPago.Padding = new Padding(5);
            TxtTotalPago.Radius = 10;
            TxtTotalPago.ReadOnly = true;
            TxtTotalPago.RectColor = Color.Silver;
            TxtTotalPago.ShowText = false;
            TxtTotalPago.Size = new Size(170, 32);
            TxtTotalPago.Style = Sunny.UI.UIStyle.Custom;
            TxtTotalPago.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtTotalPago.TabIndex = 7;
            TxtTotalPago.Text = "0";
            TxtTotalPago.TextAlignment = ContentAlignment.MiddleLeft;
            TxtTotalPago.Watermark = "";
            TxtTotalPago.TextChanged += TxtTotalPago_TextChanged;
            // 
            // BtnRegistrer
            // 
            BtnRegistrer.BackColor = Color.Transparent;
            BtnRegistrer.FillColor = Color.FromArgb(0, 192, 0);
            BtnRegistrer.FillColor2 = Color.FromArgb(11, 127, 87);
            BtnRegistrer.FillDisableColor = Color.FromArgb(224, 224, 224);
            BtnRegistrer.FillHoverColor = Color.FromArgb(8, 92, 63);
            BtnRegistrer.FillPressColor = Color.Silver;
            BtnRegistrer.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrer.Location = new Point(788, 556);
            BtnRegistrer.MinimumSize = new Size(1, 1);
            BtnRegistrer.Name = "BtnRegistrer";
            BtnRegistrer.Radius = 15;
            BtnRegistrer.RectColor = Color.White;
            BtnRegistrer.RectDisableColor = Color.White;
            BtnRegistrer.RectHoverColor = Color.White;
            BtnRegistrer.RectPressColor = Color.White;
            BtnRegistrer.RectSelectedColor = Color.White;
            BtnRegistrer.ShowFocusLine = true;
            BtnRegistrer.Size = new Size(200, 40);
            BtnRegistrer.Style = Sunny.UI.UIStyle.Custom;
            BtnRegistrer.Symbol = 61639;
            BtnRegistrer.TabIndex = 8;
            BtnRegistrer.Text = "Registrar compra";
            BtnRegistrer.TipsFont = new Font("Microsoft Sans Serif", 9F);
            BtnRegistrer.Click += BtnRegistrer_Click;
            // 
            // FrmPurchase
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(239, 239, 239);
            ClientSize = new Size(1000, 608);
            Controls.Add(BtnRegistrer);
            Controls.Add(TxtTotalPago);
            Controls.Add(label10);
            Controls.Add(BtnAgregarProd);
            Controls.Add(uiPanelGrid);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "FrmPurchase";
            Text = "FrmPurchase";
            Load += FrmPurchase_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).EndInit();
            uiPanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Sunny.UI.UIPanel groupBox1;
        private Label lblTituloGrupo1;
        private Label label2;
        private Sunny.UI.UITextBox TxtFecha;
        private Label label1;
        private Sunny.UI.UIComboBox CbTipodeDocumento;
        private Sunny.UI.UIPanel groupBox2;
        private Label lblTituloGrupo2;
        private Label label3;
        private Sunny.UI.UITextBox TxtdocProveedor;
        private Sunny.UI.UISymbolButton BtnsearchPro;
        private Label label4;
        private Sunny.UI.UITextBox TxtnameProveedor;
        private TextBox TxtidProv;
        private Sunny.UI.UIPanel groupBox3;
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
        private Sunny.UI.UIPanel uiPanelGrid;
        private ModernControls.ModernGrid DgvData;
        private Sunny.UI.UISymbolButton BtnAgregarProd;
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