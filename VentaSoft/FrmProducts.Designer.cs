namespace Main
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btbExcel = new Button();
            btnClearSearch = new Button();
            btnSearch = new Button();
            panel4 = new Panel();
            button9 = new Button();
            btnnew = new Button();
            txtDescripcion = new TextBox();
            label6 = new Label();
            txtPrecioV = new TextBox();
            label5 = new Label();
            btnClean = new Button();
            btnAdd = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            txtIndice = new TextBox();
            label14 = new Label();
            btnLimpiarTxt = new Button();
            txtIdProducto = new TextBox();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cbEstado = new ComboBox();
            cbCategoria = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtPrecioC = new TextBox();
            label3 = new Label();
            txtNameProducto = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            dgvProducto = new DataGridView();
            btnSeleccion = new DataGridViewButtonColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            NameCategoria = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btbExcel);
            panel2.Controls.Add(btnClearSearch);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(cbSearch);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(dgvProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1298, 633);
            panel2.TabIndex = 1;
            // 
            // btbExcel
            // 
            btbExcel.Anchor = AnchorStyles.Top;
            btbExcel.BackColor = Color.White;
            btbExcel.Cursor = Cursors.Hand;
            btbExcel.FlatAppearance.BorderSize = 0;
            btbExcel.FlatAppearance.MouseOverBackColor = Color.Silver;
            btbExcel.FlatStyle = FlatStyle.Flat;
            btbExcel.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btbExcel.Image = (Image)resources.GetObject("btbExcel.Image");
            btbExcel.Location = new Point(545, 526);
            btbExcel.Name = "btbExcel";
            btbExcel.Size = new Size(131, 43);
            btbExcel.TabIndex = 56;
            btbExcel.Text = "Exportar Excel";
            btbExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btbExcel.UseVisualStyleBackColor = false;
            btbExcel.Click += btbExcel_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Anchor = AnchorStyles.Top;
            btnClearSearch.BackColor = Color.Transparent;
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = (Image)resources.GetObject("btnClearSearch.Image");
            btnClearSearch.Location = new Point(810, 34);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(24, 24);
            btnClearSearch.TabIndex = 55;
            btnClearSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(768, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(24, 24);
            btnSearch.TabIndex = 54;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button9);
            panel4.Controls.Add(btnnew);
            panel4.Controls.Add(txtDescripcion);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtPrecioV);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(btnClean);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(txtIndice);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(btnLimpiarTxt);
            panel4.Controls.Add(txtIdProducto);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(cbEstado);
            panel4.Controls.Add(cbCategoria);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtStock);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtPrecioC);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtNameProducto);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtCodigo);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(923, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 633);
            panel4.TabIndex = 8;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button9.BackColor = Color.White;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 213, 255);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(185, 545);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(129, 35);
            button9.TabIndex = 49;
            button9.Text = "Limpiar";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btnnew
            // 
            btnnew.Anchor = AnchorStyles.Top;
            btnnew.BackColor = Color.White;
            btnnew.Cursor = Cursors.Hand;
            btnnew.FlatAppearance.BorderSize = 0;
            btnnew.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnnew.FlatStyle = FlatStyle.Flat;
            btnnew.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnnew.Image = (Image)resources.GetObject("btnnew.Image");
            btnnew.Location = new Point(31, 545);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(129, 35);
            btnnew.TabIndex = 48;
            btnnew.Text = "Registrar";
            btnnew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnew.UseVisualStyleBackColor = false;
            btnnew.Click += button8_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Century Gothic", 9.75F);
            txtDescripcion.Location = new Point(16, 339);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ej:\"Pan Bimbo 24 piezas\"";
            txtDescripcion.Size = new Size(173, 147);
            txtDescripcion.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(16, 314);
            label6.Name = "label6";
            label6.Size = new Size(77, 17);
            label6.TabIndex = 42;
            label6.Text = "Descripcion";
            // 
            // txtPrecioV
            // 
            txtPrecioV.Font = new Font("Century Gothic", 9.75F);
            txtPrecioV.Location = new Point(200, 208);
            txtPrecioV.Name = "txtPrecioV";
            txtPrecioV.PlaceholderText = "Ej:\"27.36\"";
            txtPrecioV.Size = new Size(146, 23);
            txtPrecioV.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(200, 182);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 40;
            label5.Text = "Precio Venta";
            // 
            // btnClean
            // 
            btnClean.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClean.BackColor = Color.White;
            btnClean.Cursor = Cursors.Hand;
            btnClean.FlatAppearance.BorderSize = 0;
            btnClean.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnClean.FlatStyle = FlatStyle.Flat;
            btnClean.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnClean.Image = (Image)resources.GetObject("btnClean.Image");
            btnClean.Location = new Point(226, 1008);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(120, 43);
            btnClean.TabIndex = 38;
            btnClean.Text = "Limpiar";
            btnClean.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClean.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(55, 1008);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 43);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Registrar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 213, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(202, 1524);
            button4.Name = "button4";
            button4.Size = new Size(168, 51);
            button4.TabIndex = 34;
            button4.Text = "Limpiar";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.BackColor = Color.White;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ControlText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(35, 1524);
            button5.Name = "button5";
            button5.Size = new Size(160, 51);
            button5.TabIndex = 33;
            button5.Text = "Eliminar";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.White;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(202, 1453);
            button6.Name = "button6";
            button6.Size = new Size(168, 51);
            button6.TabIndex = 32;
            button6.Text = "Actualizar";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button7.BackColor = Color.White;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(35, 1453);
            button7.Name = "button7";
            button7.Size = new Size(160, 51);
            button7.TabIndex = 31;
            button7.Text = "Registrar";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // txtIndice
            // 
            txtIndice.BackColor = Color.White;
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIndice.ForeColor = Color.Silver;
            txtIndice.Location = new Point(8, 71);
            txtIndice.Name = "txtIndice";
            txtIndice.PlaceholderText = "Automatico";
            txtIndice.ReadOnly = true;
            txtIndice.Size = new Size(106, 23);
            txtIndice.TabIndex = 30;
            txtIndice.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.Location = new Point(247, 52);
            label14.Name = "label14";
            label14.Size = new Size(99, 17);
            label14.TabIndex = 29;
            label14.Text = "Id de Producto";
            // 
            // btnLimpiarTxt
            // 
            btnLimpiarTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiarTxt.BackColor = Color.White;
            btnLimpiarTxt.Cursor = Cursors.Hand;
            btnLimpiarTxt.FlatAppearance.BorderSize = 0;
            btnLimpiarTxt.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 213, 255);
            btnLimpiarTxt.FlatStyle = FlatStyle.Flat;
            btnLimpiarTxt.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnLimpiarTxt.Image = (Image)resources.GetObject("btnLimpiarTxt.Image");
            btnLimpiarTxt.Location = new Point(202, 2067);
            btnLimpiarTxt.Name = "btnLimpiarTxt";
            btnLimpiarTxt.Size = new Size(168, 51);
            btnLimpiarTxt.TabIndex = 28;
            btnLimpiarTxt.Text = "Limpiar";
            btnLimpiarTxt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarTxt.UseVisualStyleBackColor = false;
            // 
            // txtIdProducto
            // 
            txtIdProducto.BackColor = Color.White;
            txtIdProducto.BorderStyle = BorderStyle.FixedSingle;
            txtIdProducto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.ForeColor = Color.Silver;
            txtIdProducto.Location = new Point(274, 72);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.PlaceholderText = "0";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(40, 23);
            txtIdProducto.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(69, 15);
            label11.Name = "label11";
            label11.Size = new Size(198, 25);
            label11.TabIndex = 25;
            label11.Text = "Detalles de Productos";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(35, 2067);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 24;
            button1.Text = "Eliminar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(202, 1995);
            button2.Name = "button2";
            button2.Size = new Size(168, 51);
            button2.TabIndex = 23;
            button2.Text = "Actualizar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(35, 1995);
            button3.Name = "button3";
            button3.Size = new Size(160, 51);
            button3.TabIndex = 22;
            button3.Text = "Registrar";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Century Gothic", 9.75F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(200, 271);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(146, 25);
            cbEstado.TabIndex = 21;
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.Font = new Font("Century Gothic", 9.75F);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(209, 374);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(131, 25);
            cbCategoria.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(200, 245);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(209, 352);
            label9.Name = "label9";
            label9.Size = new Size(66, 17);
            label9.TabIndex = 17;
            label9.Text = "Categoria";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Century Gothic", 9.75F);
            txtStock.Location = new Point(16, 271);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "Ej:\"56\"";
            txtStock.Size = new Size(130, 23);
            txtStock.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(16, 245);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 7;
            label4.Text = "Stock";
            // 
            // txtPrecioC
            // 
            txtPrecioC.Font = new Font("Century Gothic", 9.75F);
            txtPrecioC.Location = new Point(16, 208);
            txtPrecioC.Name = "txtPrecioC";
            txtPrecioC.PlaceholderText = "Ej:\"25.36\"";
            txtPrecioC.Size = new Size(130, 23);
            txtPrecioC.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(16, 182);
            label3.Name = "label3";
            label3.Size = new Size(97, 17);
            label3.TabIndex = 5;
            label3.Text = "Precio Compra";
            // 
            // txtNameProducto
            // 
            txtNameProducto.Font = new Font("Century Gothic", 9.75F);
            txtNameProducto.Location = new Point(200, 131);
            txtNameProducto.Name = "txtNameProducto";
            txtNameProducto.PlaceholderText = "Ej: \"Pan Bimbo\"";
            txtNameProducto.Size = new Size(146, 23);
            txtNameProducto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(200, 111);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 3;
            label2.Text = "Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Century Gothic", 9.75F);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Location = new Point(16, 130);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "AUTOGENERADO";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(130, 23);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(16, 111);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 1;
            label1.Text = "Codigo";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(103, 526);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 43);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(309, 526);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 43);
            btnUpdate.TabIndex = 47;
            btnUpdate.Text = "Actualizar";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(558, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(204, 22);
            txtSearch.TabIndex = 51;
            // 
            // cbSearch
            // 
            cbSearch.Anchor = AnchorStyles.Top;
            cbSearch.Cursor = Cursors.Hand;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(386, 33);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(163, 24);
            cbSearch.TabIndex = 53;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(293, 33);
            label13.Name = "label13";
            label13.Size = new Size(74, 17);
            label13.TabIndex = 52;
            label13.Text = "Buscar por:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(74, 31);
            label12.Name = "label12";
            label12.Size = new Size(168, 25);
            label12.TabIndex = 50;
            label12.Text = "Lista de Productos";
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.AllowUserToResizeColumns = false;
            dgvProducto.AllowUserToResizeRows = false;
            dgvProducto.Anchor = AnchorStyles.Top;
            dgvProducto.BackgroundColor = Color.White;
            dgvProducto.BorderStyle = BorderStyle.None;
            dgvProducto.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { btnSeleccion, IdProducto, Codigo, NombreProducto, Descripcion, PrecioVenta, PrecioCompra, Stock, IdCategoria, NameCategoria, EstadoValor, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducto.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducto.EnableHeadersVisualStyles = false;
            dgvProducto.GridColor = Color.White;
            dgvProducto.Location = new Point(74, 111);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProducto.RowHeadersVisible = false;
            dgvProducto.RowHeadersWidth = 51;
            dgvProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(761, 375);
            dgvProducto.TabIndex = 49;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            dgvProducto.CellFormatting += dgvProducto_CellFormatting;
            dgvProducto.CellPainting += dgvProducto_CellPainting;
            // 
            // btnSeleccion
            // 
            btnSeleccion.HeaderText = "";
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.ReadOnly = true;
            btnSeleccion.Width = 35;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Id";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Resizable = DataGridViewTriState.True;
            IdProducto.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 125;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Producto";
            NombreProducto.MinimumWidth = 6;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Width = 125;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Visible = false;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 125;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PrecioCompra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Visible = false;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.MinimumWidth = 6;
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            IdCategoria.Width = 125;
            // 
            // NameCategoria
            // 
            NameCategoria.HeaderText = "Categoria";
            NameCategoria.Name = "NameCategoria";
            NameCategoria.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 633);
            Controls.Add(panel2);
            Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmProducts";
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private Label label13;
        private Label label12;
        private DataGridView dgvProducto;
        private DataGridViewButtonColumn btnSeleccion;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn NameCategoria;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Button btnClearSearch;
        private Button btnSearch;
        private Button btbExcel;
        private Panel panel4;
        private TextBox txtDescripcion;
        private Label label6;
        private TextBox txtPrecioV;
        private Label label5;
        private Button btnClean;
        private Button btnAdd;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txtIndice;
        private Label label14;
        private Button btnLimpiarTxt;
        private TextBox txtIdProducto;
        private Label label11;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cbEstado;
        private ComboBox cbCategoria;
        private Label label10;
        private Label label9;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrecioC;
        private Label label3;
        private TextBox txtNameProducto;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Button btnnew;
        private Button button9;
    }
}