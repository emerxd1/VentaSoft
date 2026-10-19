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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurchase));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label12 = new Label();
            groupBox1 = new GroupBox();
            CbTipodeDocumento = new ComboBox();
            TxtFecha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TxtidProv = new TextBox();
            BtnsearchPro = new Button();
            TxtnameProveedor = new TextBox();
            TxtdocProveedor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            DgvData = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Canti = new DataGridViewTextBoxColumn();
            Subto = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            BtnAgregarProd = new Button();
            label10 = new Label();
            TxtTotalPago = new TextBox();
            groupBox3 = new GroupBox();
            TxtCantidad = new NumericUpDown();
            TxtPrecioVenta = new TextBox();
            TxtPrecioCompra = new TextBox();
            TxtNombreProd = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            BtnBuscarProd = new Button();
            TxtidProd = new TextBox();
            label5 = new Label();
            TxtcodProd = new TextBox();
            BtnRegistrer = new Button();
            panelGraDi = new Gradient.PanelGradient();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).BeginInit();
            panelGraDi.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 9);
            label12.Name = "label12";
            label12.Size = new Size(181, 25);
            label12.TabIndex = 33;
            label12.Text = "Registro de Compra";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(CbTipodeDocumento);
            groupBox1.Controls.Add(TxtFecha);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(3, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 130);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacíon de la Compra";
            // 
            // CbTipodeDocumento
            // 
            CbTipodeDocumento.BackColor = Color.White;
            CbTipodeDocumento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CbTipodeDocumento.FormattingEnabled = true;
            CbTipodeDocumento.Location = new Point(9, 100);
            CbTipodeDocumento.Name = "CbTipodeDocumento";
            CbTipodeDocumento.Size = new Size(187, 25);
            CbTipodeDocumento.TabIndex = 36;
            // 
            // TxtFecha
            // 
            TxtFecha.BackColor = Color.White;
            TxtFecha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtFecha.Location = new Point(9, 38);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(122, 33);
            TxtFecha.TabIndex = 35;
            TxtFecha.TextChanged += TxtFecha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 80);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 1;
            label2.Text = "Tipo de Documento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(TxtidProv);
            groupBox2.Controls.Add(BtnsearchPro);
            groupBox2.Controls.Add(TxtnameProveedor);
            groupBox2.Controls.Add(TxtdocProveedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(3, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(217, 167);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información del Proveedor";
            // 
            // TxtidProv
            // 
            TxtidProv.Location = new Point(118, 104);
            TxtidProv.Name = "TxtidProv";
            TxtidProv.Size = new Size(27, 28);
            TxtidProv.TabIndex = 39;
            TxtidProv.Visible = false;
            // 
            // BtnsearchPro
            // 
            BtnsearchPro.Anchor = AnchorStyles.Top;
            BtnsearchPro.BackColor = Color.Transparent;
            BtnsearchPro.Cursor = Cursors.Hand;
            BtnsearchPro.FlatAppearance.BorderSize = 0;
            BtnsearchPro.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnsearchPro.FlatStyle = FlatStyle.Flat;
            BtnsearchPro.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnsearchPro.Image = (Image)resources.GetObject("BtnsearchPro.Image");
            BtnsearchPro.Location = new Point(146, 64);
            BtnsearchPro.Name = "BtnsearchPro";
            BtnsearchPro.Size = new Size(32, 29);
            BtnsearchPro.TabIndex = 38;
            BtnsearchPro.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnsearchPro.UseVisualStyleBackColor = false;
            BtnsearchPro.Click += BtnsearchPro_Click;
            // 
            // TxtnameProveedor
            // 
            TxtnameProveedor.BackColor = Color.White;
            TxtnameProveedor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtnameProveedor.Location = new Point(0, 135);
            TxtnameProveedor.Multiline = true;
            TxtnameProveedor.Name = "TxtnameProveedor";
            TxtnameProveedor.PlaceholderText = "\"AUTOGENERADO\"";
            TxtnameProveedor.Size = new Size(211, 26);
            TxtnameProveedor.TabIndex = 37;
            // 
            // TxtdocProveedor
            // 
            TxtdocProveedor.BackColor = Color.White;
            TxtdocProveedor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtdocProveedor.Location = new Point(6, 68);
            TxtdocProveedor.Name = "TxtdocProveedor";
            TxtdocProveedor.PlaceholderText = "\"AUTOGENERADO\"";
            TxtdocProveedor.Size = new Size(139, 25);
            TxtdocProveedor.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Aquamarine;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 48);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 2;
            label4.Text = "RUC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 109);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 1;
            label3.Text = "Razón Social:";
            // 
            // DgvData
            // 
            DgvData.AllowUserToAddRows = false;
            DgvData.BackgroundColor = Color.White;
            DgvData.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, Producto, PrecioCompra, PrecioVenta, Canti, Subto, BtnEliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvData.DefaultCellStyle = dataGridViewCellStyle2;
            DgvData.EnableHeadersVisualStyles = false;
            DgvData.GridColor = Color.White;
            DgvData.Location = new Point(226, 37);
            DgvData.Name = "DgvData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvData.Size = new Size(733, 516);
            DgvData.TabIndex = 37;
            DgvData.CellContentClick += DgvData_CellContentClick;
            DgvData.CellPainting += DgvData_CellPainting;
            DgvData.RowsAdded += DgvData_RowsAdded;
            DgvData.RowsRemoved += DgvData_RowsRemoved;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "";
            idProducto.MinimumWidth = 6;
            idProducto.Name = "idProducto";
            idProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 200;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 120;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Width = 120;
            // 
            // Canti
            // 
            Canti.HeaderText = "Cantidad";
            Canti.MinimumWidth = 6;
            Canti.Name = "Canti";
            // 
            // Subto
            // 
            Subto.HeaderText = "Sub Total";
            Subto.MinimumWidth = 6;
            Subto.Name = "Subto";
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "";
            BtnEliminar.MinimumWidth = 6;
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Width = 50;
            // 
            // BtnAgregarProd
            // 
            BtnAgregarProd.BackColor = Color.White;
            BtnAgregarProd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarProd.ForeColor = Color.FromArgb(0, 64, 64);
            BtnAgregarProd.Image = Properties.Resources.plus;
            BtnAgregarProd.ImageAlign = ContentAlignment.TopCenter;
            BtnAgregarProd.Location = new Point(226, 556);
            BtnAgregarProd.Name = "BtnAgregarProd";
            BtnAgregarProd.Size = new Size(80, 57);
            BtnAgregarProd.TabIndex = 38;
            BtnAgregarProd.Text = "Agregar";
            BtnAgregarProd.TextAlign = ContentAlignment.BottomCenter;
            BtnAgregarProd.UseVisualStyleBackColor = false;
            BtnAgregarProd.Click += BtnAgregarProd_Click;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(757, 564);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 39;
            label10.Text = "Total a Pagar:";
            // 
            // TxtTotalPago
            // 
            TxtTotalPago.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtTotalPago.Location = new Point(859, 559);
            TxtTotalPago.Name = "TxtTotalPago";
            TxtTotalPago.Size = new Size(100, 25);
            TxtTotalPago.TabIndex = 40;
            TxtTotalPago.Text = "0";
            TxtTotalPago.TextChanged += TxtTotalPago_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(TxtCantidad);
            groupBox3.Controls.Add(TxtPrecioVenta);
            groupBox3.Controls.Add(TxtPrecioCompra);
            groupBox3.Controls.Add(TxtNombreProd);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(BtnBuscarProd);
            groupBox3.Controls.Add(TxtidProd);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(TxtcodProd);
            groupBox3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(3, 346);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 267);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información del Producto";
            // 
            // TxtCantidad
            // 
            TxtCantidad.BackColor = Color.White;
            TxtCantidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCantidad.Location = new Point(144, 229);
            TxtCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            TxtCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(53, 25);
            TxtCantidad.TabIndex = 49;
            TxtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            TxtCantidad.KeyDown += TxtCantidad_KeyDown;
            // 
            // TxtPrecioVenta
            // 
            TxtPrecioVenta.BackColor = Color.White;
            TxtPrecioVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPrecioVenta.Location = new Point(142, 188);
            TxtPrecioVenta.Name = "TxtPrecioVenta";
            TxtPrecioVenta.PlaceholderText = "EJ: 2";
            TxtPrecioVenta.Size = new Size(51, 25);
            TxtPrecioVenta.TabIndex = 48;
            TxtPrecioVenta.KeyDown += TxtPrecioVenta_KeyDown;
            TxtPrecioVenta.KeyPress += TxtPrecioVenta_KeyPress;
            // 
            // TxtPrecioCompra
            // 
            TxtPrecioCompra.BackColor = Color.White;
            TxtPrecioCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPrecioCompra.Location = new Point(143, 156);
            TxtPrecioCompra.Name = "TxtPrecioCompra";
            TxtPrecioCompra.PlaceholderText = "Ej: 23";
            TxtPrecioCompra.Size = new Size(50, 25);
            TxtPrecioCompra.TabIndex = 47;
            TxtPrecioCompra.KeyDown += TxtPrecioCompra_KeyDown;
            TxtPrecioCompra.KeyPress += TxtPrecioCompra_KeyPress;
            // 
            // TxtNombreProd
            // 
            TxtNombreProd.BackColor = Color.White;
            TxtNombreProd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNombreProd.Location = new Point(9, 115);
            TxtNombreProd.Name = "TxtNombreProd";
            TxtNombreProd.PlaceholderText = "AUTOGENERADO";
            TxtNombreProd.Size = new Size(208, 25);
            TxtNombreProd.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Aquamarine;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(71, 234);
            label9.Name = "label9";
            label9.Size = new Size(67, 17);
            label9.TabIndex = 45;
            label9.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Aquamarine;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 193);
            label8.Name = "label8";
            label8.Size = new Size(123, 17);
            label8.TabIndex = 44;
            label8.Text = "Precio de la Venta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Aquamarine;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 164);
            label7.Name = "label7";
            label7.Size = new Size(136, 17);
            label7.TabIndex = 43;
            label7.Text = "Precio de la Compra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Aquamarine;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 96);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 42;
            label6.Text = "Producto:";
            // 
            // BtnBuscarProd
            // 
            BtnBuscarProd.Anchor = AnchorStyles.Top;
            BtnBuscarProd.BackColor = Color.Transparent;
            BtnBuscarProd.Cursor = Cursors.Hand;
            BtnBuscarProd.FlatAppearance.BorderSize = 0;
            BtnBuscarProd.FlatAppearance.MouseOverBackColor = Color.Silver;
            BtnBuscarProd.FlatStyle = FlatStyle.Flat;
            BtnBuscarProd.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarProd.Image = (Image)resources.GetObject("BtnBuscarProd.Image");
            BtnBuscarProd.Location = new Point(151, 53);
            BtnBuscarProd.Name = "BtnBuscarProd";
            BtnBuscarProd.Size = new Size(32, 29);
            BtnBuscarProd.TabIndex = 41;
            BtnBuscarProd.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscarProd.UseVisualStyleBackColor = false;
            BtnBuscarProd.Click += BtnBuscarProd_Click;
            // 
            // TxtidProd
            // 
            TxtidProd.Location = new Point(137, 20);
            TxtidProd.Name = "TxtidProd";
            TxtidProd.Size = new Size(27, 28);
            TxtidProd.TabIndex = 40;
            TxtidProd.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Aquamarine;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 41);
            label5.Name = "label5";
            label5.Size = new Size(125, 17);
            label5.TabIndex = 38;
            label5.Text = "Cod. Del Producto:";
            // 
            // TxtcodProd
            // 
            TxtcodProd.BackColor = Color.White;
            TxtcodProd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtcodProd.Location = new Point(6, 59);
            TxtcodProd.Name = "TxtcodProd";
            TxtcodProd.PlaceholderText = "EJ: \"P0001\" O \"AUTO\"";
            TxtcodProd.Size = new Size(139, 25);
            TxtcodProd.TabIndex = 37;
            TxtcodProd.KeyDown += TxtcodProd_KeyDown;
            // 
            // BtnRegistrer
            // 
            BtnRegistrer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrer.ForeColor = Color.Black;
            BtnRegistrer.Image = Properties.Resources.register;
            BtnRegistrer.ImageAlign = ContentAlignment.TopCenter;
            BtnRegistrer.Location = new Point(684, 556);
            BtnRegistrer.Name = "BtnRegistrer";
            BtnRegistrer.Size = new Size(67, 57);
            BtnRegistrer.TabIndex = 41;
            BtnRegistrer.Text = "Registrar";
            BtnRegistrer.TextAlign = ContentAlignment.BottomCenter;
            BtnRegistrer.UseVisualStyleBackColor = true;
            BtnRegistrer.Click += button1_Click;
            // 
            // panelGraDi
            // 
            panelGraDi.BackColor = Color.FromArgb(0, 192, 192);
            panelGraDi.Controls.Add(BtnRegistrer);
            panelGraDi.Controls.Add(groupBox3);
            panelGraDi.Controls.Add(TxtTotalPago);
            panelGraDi.Controls.Add(label10);
            panelGraDi.Controls.Add(BtnAgregarProd);
            panelGraDi.Controls.Add(DgvData);
            panelGraDi.Controls.Add(groupBox2);
            panelGraDi.Controls.Add(groupBox1);
            panelGraDi.Controls.Add(label12);
            panelGraDi.Dock = DockStyle.Fill;
            panelGraDi.ForeColor = Color.Black;
            panelGraDi.GradientBottomColor = Color.FromArgb(192, 255, 255);
            panelGraDi.GradientTopColor = Color.FromArgb(0, 192, 192);
            panelGraDi.Location = new Point(0, 0);
            panelGraDi.Name = "panelGraDi";
            panelGraDi.Size = new Size(988, 627);
            panelGraDi.TabIndex = 55;
            panelGraDi.Paint += panelGraDi_Paint;
            // 
            // FrmPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 627);
            Controls.Add(panelGraDi);
            Name = "FrmPurchase";
            Text = "FrmPurchase";
            Load += FrmPurchase_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtCantidad).EndInit();
            panelGraDi.ResumeLayout(false);
            panelGraDi.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label12;
        private GroupBox groupBox1;
        private ComboBox CbTipodeDocumento;
        private TextBox TxtFecha;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TxtidProv;
        private Button BtnsearchPro;
        private TextBox TxtnameProveedor;
        private TextBox TxtdocProveedor;
        private Label label4;
        private Label label3;
        private DataGridView DgvData;
        private Button BtnAgregarProd;
        private Label label10;
        private TextBox TxtTotalPago;
        private GroupBox groupBox3;
        private NumericUpDown TxtCantidad;
        private TextBox TxtPrecioVenta;
        private TextBox TxtPrecioCompra;
        private TextBox TxtNombreProd;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button BtnBuscarProd;
        private TextBox TxtidProd;
        private Label label5;
        private TextBox TxtcodProd;
        private Button BtnRegistrer;
        private Gradient.PanelGradient panelGraDi;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Canti;
        private DataGridViewTextBoxColumn Subto;
        private DataGridViewButtonColumn BtnEliminar;
    }
}