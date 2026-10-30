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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            panel2 = new Panel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            btnExportar = new Sunny.UI.UISymbolButton();
            dgvProducto = new ModernControls.ModernGrid();
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
            txtSearch = new Sunny.UI.UITextBox();
            btnDelete = new Sunny.UI.UISymbolButton();
            btnUpdate = new Sunny.UI.UISymbolButton();
            label1 = new Label();
            label13 = new Label();
            cbSearch = new ReaLTaiizor.Controls.AloneComboBox();
            label12 = new Label();
            PnlDetails = new Sunny.UI.UIPanel();
            cbCategoria = new Sunny.UI.UIComboBox();
            label23 = new Label();
            label22 = new Label();
            txtStock = new Sunny.UI.UITextBox();
            label20 = new Label();
            txtPrecioV = new Sunny.UI.UITextBox();
            label19 = new Label();
            txtPrecioC = new Sunny.UI.UITextBox();
            label18 = new Label();
            txtCodigo = new Sunny.UI.UITextBox();
            cbEstado = new Sunny.UI.UIComboBox();
            uiTextBox3 = new Sunny.UI.UITextBox();
            label21 = new Label();
            lblTituloGrupo1 = new Label();
            label7 = new Label();
            txtIndice = new Sunny.UI.UITextBox();
            btnClear = new Sunny.UI.UISymbolButton();
            btnAgregar = new Sunny.UI.UISymbolButton();
            label16 = new Label();
            txtDescripcion = new Sunny.UI.UITextBox();
            label8 = new Label();
            txtNameProducto = new Sunny.UI.UITextBox();
            txtIdProducto = new Sunny.UI.UITextBox();
            label15 = new Label();
            label17 = new Label();
            btnClearSearch = new Button();
            btnSearch = new Button();
            panel2.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            PnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(bigLabel2);
            panel2.Controls.Add(bigLabel1);
            panel2.Controls.Add(uiPanel1);
            panel2.Controls.Add(PnlDetails);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1316, 721);
            panel2.TabIndex = 1;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Gray;
            bigLabel2.Location = new Point(33, 30);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(289, 17);
            bigLabel2.TabIndex = 68;
            bigLabel2.Text = "Control, registro y administración de productos.";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(57, 79, 71);
            bigLabel1.Location = new Point(32, 4);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(113, 30);
            bigLabel1.TabIndex = 67;
            bigLabel1.Text = "Productos";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(btnExportar);
            uiPanel1.Controls.Add(dgvProducto);
            uiPanel1.Controls.Add(txtSearch);
            uiPanel1.Controls.Add(btnDelete);
            uiPanel1.Controls.Add(btnUpdate);
            uiPanel1.Controls.Add(label1);
            uiPanel1.Controls.Add(label13);
            uiPanel1.Controls.Add(cbSearch);
            uiPanel1.Controls.Add(label12);
            uiPanel1.FillColor = Color.White;
            uiPanel1.FillColor2 = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(10, 53);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.Silver;
            uiPanel1.Size = new Size(851, 641);
            uiPanel1.TabIndex = 66;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnExportar
            // 
            btnExportar.FillColor = Color.White;
            btnExportar.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnExportar.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnExportar.FillPressColor = Color.Silver;
            btnExportar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.FromArgb(57, 79, 71);
            btnExportar.ForePressColor = Color.Black;
            btnExportar.Location = new Point(674, 587);
            btnExportar.MinimumSize = new Size(1, 1);
            btnExportar.Name = "btnExportar";
            btnExportar.Radius = 15;
            btnExportar.RectColor = Color.Silver;
            btnExportar.RectDisableColor = Color.White;
            btnExportar.RectHoverColor = Color.White;
            btnExportar.RectPressColor = Color.Silver;
            btnExportar.RectSelectedColor = Color.White;
            btnExportar.ShowFocusLine = true;
            btnExportar.Size = new Size(166, 42);
            btnExportar.Style = Sunny.UI.UIStyle.Custom;
            btnExportar.Symbol = 361891;
            btnExportar.SymbolColor = Color.FromArgb(57, 79, 71);
            btnExportar.TabIndex = 84;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnExportar.Click += btnExportar_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.AllowUserToResizeColumns = false;
            dgvProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.BackgroundColor = Color.White;
            dgvProducto.BorderStyle = BorderStyle.None;
            dgvProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 116, 146);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 116, 146);
            dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducto.ColumnHeadersHeight = 44;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Codigo, NombreProducto, Descripcion, PrecioVenta, PrecioCompra, Stock, IdCategoria, NameCategoria, EstadoValor, Estado });
            dgvProducto.CornerRadius = 10;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducto.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducto.EnableHeadersVisualStyles = false;
            dgvProducto.Font = new Font("Segoe UI", 9.5F);
            dgvProducto.GridColor = Color.White;
            dgvProducto.Location = new Point(11, 87);
            dgvProducto.MultiSelect = false;
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducto.RowHeadersVisible = false;
            dgvProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProducto.RowTemplate.Height = 56;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.ShowCellToolTips = false;
            dgvProducto.Size = new Size(825, 486);
            dgvProducto.TabIndex = 83;
            dgvProducto.CellClick += dgvProducto_CellClick_1;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Id Prodcuto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdProducto.Visible = false;
            // 
            // Codigo
            // 
            Codigo.FillWeight = 75F;
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 75;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NombreProducto
            // 
            NombreProducto.FillWeight = 92F;
            NombreProducto.HeaderText = "Producto";
            NombreProducto.MinimumWidth = 92;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            NombreProducto.Resizable = DataGridViewTriState.False;
            NombreProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Descripcion
            // 
            Descripcion.FillWeight = 104F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 104;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // PrecioCompra
            // 
            PrecioCompra.FillWeight = 122F;
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 122;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Stock
            // 
            Stock.FillWeight = 66F;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 66;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdCategoria.Visible = false;
            // 
            // NameCategoria
            // 
            NameCategoria.FillWeight = 93F;
            NameCategoria.HeaderText = "Categoria";
            NameCategoria.MinimumWidth = 93;
            NameCategoria.Name = "NameCategoria";
            NameCategoria.ReadOnly = true;
            NameCategoria.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.SortMode = DataGridViewColumnSortMode.NotSortable;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.FillWeight = 74F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 74;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSearch
            // 
            txtSearch.ButtonFillColor = Color.White;
            txtSearch.ButtonFillHoverColor = Color.White;
            txtSearch.ButtonFillPressColor = Color.White;
            txtSearch.ButtonForeColor = Color.FromArgb(57, 79, 71);
            txtSearch.ButtonRectColor = Color.White;
            txtSearch.ButtonRectHoverColor = Color.White;
            txtSearch.ButtonRectPressColor = Color.White;
            txtSearch.ButtonStyleInherited = false;
            txtSearch.ButtonSymbol = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.IconSize = 20;
            txtSearch.Location = new Point(249, 49);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.Radius = 10;
            txtSearch.RectColor = Color.Silver;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(338, 26);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.Symbol = 61442;
            txtSearch.SymbolColor = Color.FromArgb(57, 79, 71);
            txtSearch.TabIndex = 65;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Escriba para buscar...";
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // btnDelete
            // 
            btnDelete.FillColor = Color.White;
            btnDelete.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnDelete.FillHoverColor = Color.Silver;
            btnDelete.FillPressColor = Color.Silver;
            btnDelete.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(255, 128, 128);
            btnDelete.ForePressColor = Color.Black;
            btnDelete.Location = new Point(11, 587);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Radius = 15;
            btnDelete.RectColor = Color.FromArgb(255, 128, 128);
            btnDelete.RectDisableColor = Color.White;
            btnDelete.RectHoverColor = Color.White;
            btnDelete.RectPressColor = Color.White;
            btnDelete.RectSelectedColor = Color.White;
            btnDelete.ShowFocusLine = true;
            btnDelete.Size = new Size(149, 42);
            btnDelete.Style = Sunny.UI.UIStyle.Custom;
            btnDelete.Symbol = 61460;
            btnDelete.SymbolColor = Color.FromArgb(255, 128, 128);
            btnDelete.SymbolPressColor = Color.Black;
            btnDelete.SymbolSelectedColor = Color.FromArgb(255, 128, 128);
            btnDelete.TabIndex = 82;
            btnDelete.Text = "Eliminar";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.FillColor = Color.White;
            btnUpdate.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnUpdate.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnUpdate.FillPressColor = Color.Silver;
            btnUpdate.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(57, 79, 71);
            btnUpdate.ForePressColor = Color.Black;
            btnUpdate.Location = new Point(174, 587);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Radius = 15;
            btnUpdate.RectColor = Color.Silver;
            btnUpdate.RectDisableColor = Color.White;
            btnUpdate.RectHoverColor = Color.White;
            btnUpdate.RectPressColor = Color.Silver;
            btnUpdate.RectSelectedColor = Color.White;
            btnUpdate.ShowFocusLine = true;
            btnUpdate.Size = new Size(149, 42);
            btnUpdate.Style = Sunny.UI.UIStyle.Custom;
            btnUpdate.Symbol = 61504;
            btnUpdate.SymbolColor = Color.FromArgb(57, 79, 71);
            btnUpdate.TabIndex = 82;
            btnUpdate.Text = "Actualizar";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.Click += uiSymbolButton2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(57, 79, 71);
            label1.Location = new Point(259, 22);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 55;
            label1.Text = "Busqueda";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(57, 79, 71);
            label13.Location = new Point(46, 26);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 45;
            label13.Text = "Filtrar por";
            // 
            // cbSearch
            // 
            cbSearch.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.EnabledCalc = true;
            cbSearch.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearch.FormattingEnabled = true;
            cbSearch.ItemHeight = 20;
            cbSearch.Location = new Point(32, 49);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(210, 26);
            cbSearch.TabIndex = 46;
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(316, 22);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 43;
            // 
            // PnlDetails
            // 
            PnlDetails.Anchor = AnchorStyles.Top;
            PnlDetails.BackColor = Color.White;
            PnlDetails.Controls.Add(cbCategoria);
            PnlDetails.Controls.Add(label23);
            PnlDetails.Controls.Add(label22);
            PnlDetails.Controls.Add(txtStock);
            PnlDetails.Controls.Add(label20);
            PnlDetails.Controls.Add(txtPrecioV);
            PnlDetails.Controls.Add(label19);
            PnlDetails.Controls.Add(txtPrecioC);
            PnlDetails.Controls.Add(label18);
            PnlDetails.Controls.Add(txtCodigo);
            PnlDetails.Controls.Add(cbEstado);
            PnlDetails.Controls.Add(uiTextBox3);
            PnlDetails.Controls.Add(label21);
            PnlDetails.Controls.Add(lblTituloGrupo1);
            PnlDetails.Controls.Add(label7);
            PnlDetails.Controls.Add(txtIndice);
            PnlDetails.Controls.Add(btnClear);
            PnlDetails.Controls.Add(btnAgregar);
            PnlDetails.Controls.Add(label16);
            PnlDetails.Controls.Add(txtDescripcion);
            PnlDetails.Controls.Add(label8);
            PnlDetails.Controls.Add(txtNameProducto);
            PnlDetails.Controls.Add(txtIdProducto);
            PnlDetails.Controls.Add(label15);
            PnlDetails.Controls.Add(label17);
            PnlDetails.FillColor = Color.White;
            PnlDetails.Font = new Font("Microsoft Sans Serif", 12F);
            PnlDetails.Location = new Point(869, 46);
            PnlDetails.Margin = new Padding(4, 5, 4, 5);
            PnlDetails.MinimumSize = new Size(1, 1);
            PnlDetails.Name = "PnlDetails";
            PnlDetails.Radius = 12;
            PnlDetails.RectColor = Color.Silver;
            PnlDetails.Size = new Size(434, 650);
            PnlDetails.TabIndex = 65;
            PnlDetails.Text = null;
            PnlDetails.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // cbCategoria
            // 
            cbCategoria.Cursor = Cursors.Hand;
            cbCategoria.DataSource = null;
            cbCategoria.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbCategoria.FillColor = Color.White;
            cbCategoria.Font = new Font("Microsoft Sans Serif", 12F);
            cbCategoria.ItemHoverColor = Color.FromArgb(201, 228, 217);
            cbCategoria.ItemRectColor = Color.FromArgb(57, 79, 71);
            cbCategoria.ItemSelectBackColor = Color.Silver;
            cbCategoria.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            cbCategoria.Location = new Point(20, 396);
            cbCategoria.Margin = new Padding(4, 5, 4, 5);
            cbCategoria.MinimumSize = new Size(63, 0);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Padding = new Padding(0, 0, 30, 2);
            cbCategoria.RectColor = Color.Silver;
            cbCategoria.Size = new Size(393, 30);
            cbCategoria.Style = Sunny.UI.UIStyle.Custom;
            cbCategoria.StyleDropDown = Sunny.UI.UIStyle.Custom;
            cbCategoria.SymbolSize = 24;
            cbCategoria.TabIndex = 95;
            cbCategoria.TextAlignment = ContentAlignment.MiddleLeft;
            cbCategoria.Watermark = "Seleccione una categoria";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label23.ForeColor = Color.FromArgb(57, 79, 71);
            label23.Location = new Point(28, 376);
            label23.Name = "label23";
            label23.Size = new Size(66, 17);
            label23.TabIndex = 94;
            label23.Text = "Categoria";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label22.ForeColor = Color.FromArgb(57, 79, 71);
            label22.Location = new Point(20, 318);
            label22.Name = "label22";
            label22.Size = new Size(41, 17);
            label22.TabIndex = 92;
            label22.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft Sans Serif", 12F);
            txtStock.ImeMode = ImeMode.Disable;
            txtStock.Location = new Point(20, 340);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.MinimumSize = new Size(1, 16);
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(5);
            txtStock.Radius = 10;
            txtStock.RectColor = Color.Silver;
            txtStock.ShowText = false;
            txtStock.Size = new Size(190, 30);
            txtStock.Style = Sunny.UI.UIStyle.Custom;
            txtStock.SymbolColor = Color.FromArgb(57, 79, 71);
            txtStock.TabIndex = 93;
            txtStock.TextAlignment = ContentAlignment.MiddleLeft;
            txtStock.Watermark = "Ej: \"85\"";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(57, 79, 71);
            label20.Location = new Point(251, 252);
            label20.Name = "label20";
            label20.Size = new Size(83, 17);
            label20.TabIndex = 90;
            label20.Text = "Precio Venta";
            // 
            // txtPrecioV
            // 
            txtPrecioV.Font = new Font("Microsoft Sans Serif", 12F);
            txtPrecioV.ImeMode = ImeMode.Disable;
            txtPrecioV.Location = new Point(218, 274);
            txtPrecioV.Margin = new Padding(4, 5, 4, 5);
            txtPrecioV.MinimumSize = new Size(1, 16);
            txtPrecioV.Name = "txtPrecioV";
            txtPrecioV.Padding = new Padding(5);
            txtPrecioV.Radius = 10;
            txtPrecioV.RectColor = Color.Silver;
            txtPrecioV.ShowText = false;
            txtPrecioV.Size = new Size(195, 30);
            txtPrecioV.Style = Sunny.UI.UIStyle.Custom;
            txtPrecioV.SymbolColor = Color.FromArgb(57, 79, 71);
            txtPrecioV.TabIndex = 91;
            txtPrecioV.TextAlignment = ContentAlignment.MiddleLeft;
            txtPrecioV.Watermark = "Ej: \"25.00\"";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(57, 79, 71);
            label19.Location = new Point(20, 252);
            label19.Name = "label19";
            label19.Size = new Size(97, 17);
            label19.TabIndex = 88;
            label19.Text = "Precio Compra";
            // 
            // txtPrecioC
            // 
            txtPrecioC.Font = new Font("Microsoft Sans Serif", 12F);
            txtPrecioC.ImeMode = ImeMode.Disable;
            txtPrecioC.Location = new Point(20, 274);
            txtPrecioC.Margin = new Padding(4, 5, 4, 5);
            txtPrecioC.MinimumSize = new Size(1, 16);
            txtPrecioC.Name = "txtPrecioC";
            txtPrecioC.Padding = new Padding(5);
            txtPrecioC.Radius = 10;
            txtPrecioC.RectColor = Color.Silver;
            txtPrecioC.ShowText = false;
            txtPrecioC.Size = new Size(190, 30);
            txtPrecioC.Style = Sunny.UI.UIStyle.Custom;
            txtPrecioC.SymbolColor = Color.FromArgb(57, 79, 71);
            txtPrecioC.TabIndex = 89;
            txtPrecioC.TextAlignment = ContentAlignment.MiddleLeft;
            txtPrecioC.Watermark = "Ej: \"22.00\"";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(57, 79, 71);
            label18.Location = new Point(20, 124);
            label18.Name = "label18";
            label18.Size = new Size(133, 17);
            label18.TabIndex = 86;
            label18.Text = "Codigo del producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 12F);
            txtCodigo.ImeMode = ImeMode.Disable;
            txtCodigo.Location = new Point(20, 146);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.MinimumSize = new Size(1, 16);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(5);
            txtCodigo.Radius = 10;
            txtCodigo.ReadOnly = true;
            txtCodigo.RectColor = Color.Silver;
            txtCodigo.ShowText = false;
            txtCodigo.Size = new Size(150, 30);
            txtCodigo.Style = Sunny.UI.UIStyle.Custom;
            txtCodigo.SymbolColor = Color.FromArgb(57, 79, 71);
            txtCodigo.TabIndex = 87;
            txtCodigo.TextAlignment = ContentAlignment.MiddleLeft;
            txtCodigo.Watermark = "Autogenerado";
            // 
            // cbEstado
            // 
            cbEstado.Cursor = Cursors.Hand;
            cbEstado.DataSource = null;
            cbEstado.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbEstado.FillColor = Color.White;
            cbEstado.Font = new Font("Microsoft Sans Serif", 12F);
            cbEstado.ItemHoverColor = Color.FromArgb(201, 228, 217);
            cbEstado.ItemRectColor = Color.FromArgb(57, 79, 71);
            cbEstado.ItemSelectBackColor = Color.Silver;
            cbEstado.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            cbEstado.Location = new Point(218, 340);
            cbEstado.Margin = new Padding(4, 5, 4, 5);
            cbEstado.MinimumSize = new Size(63, 0);
            cbEstado.Name = "cbEstado";
            cbEstado.Padding = new Padding(0, 0, 30, 2);
            cbEstado.RectColor = Color.Silver;
            cbEstado.Size = new Size(195, 30);
            cbEstado.Style = Sunny.UI.UIStyle.Custom;
            cbEstado.StyleDropDown = Sunny.UI.UIStyle.Custom;
            cbEstado.SymbolSize = 24;
            cbEstado.TabIndex = 78;
            cbEstado.TextAlignment = ContentAlignment.MiddleLeft;
            cbEstado.Watermark = "Seleccione un estado";
            // 
            // uiTextBox3
            // 
            uiTextBox3.Enabled = false;
            uiTextBox3.FillColor = Color.FromArgb(201, 228, 217);
            uiTextBox3.FillDisableColor = Color.FromArgb(201, 228, 217);
            uiTextBox3.FillReadOnlyColor = Color.FromArgb(201, 228, 217);
            uiTextBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox3.ForeColor = Color.FromArgb(97, 157, 135);
            uiTextBox3.ForeDisableColor = Color.FromArgb(97, 157, 135);
            uiTextBox3.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            uiTextBox3.ImeMode = ImeMode.Disable;
            uiTextBox3.Location = new Point(20, 95);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.Radius = 15;
            uiTextBox3.ReadOnly = true;
            uiTextBox3.RectColor = Color.White;
            uiTextBox3.RectDisableColor = Color.White;
            uiTextBox3.RectReadOnlyColor = Color.White;
            uiTextBox3.ScrollBarColor = Color.White;
            uiTextBox3.ScrollBarStyleInherited = false;
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(24, 24);
            uiTextBox3.Symbol = 362566;
            uiTextBox3.SymbolOffset = new Point(-1, 0);
            uiTextBox3.SymbolSize = 20;
            uiTextBox3.TabIndex = 85;
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "ID#";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(57, 79, 71);
            label21.Location = new Point(226, 320);
            label21.Name = "label21";
            label21.Size = new Size(55, 17);
            label21.TabIndex = 77;
            label21.Text = "Estado*";
            // 
            // lblTituloGrupo1
            // 
            lblTituloGrupo1.BackColor = Color.White;
            lblTituloGrupo1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloGrupo1.ForeColor = Color.FromArgb(20, 32, 30);
            lblTituloGrupo1.Location = new Point(49, 94);
            lblTituloGrupo1.Name = "lblTituloGrupo1";
            lblTituloGrupo1.Size = new Size(300, 24);
            lblTituloGrupo1.TabIndex = 84;
            lblTituloGrupo1.Text = "Datos del Producto";
            lblTituloGrupo1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 128);
            label7.Location = new Point(20, 64);
            label7.Name = "label7";
            label7.Size = new Size(243, 20);
            label7.TabIndex = 82;
            label7.Text = "Todos los campos son obligatorios.";
            // 
            // txtIndice
            // 
            txtIndice.FillColor = Color.FromArgb(201, 228, 217);
            txtIndice.FillDisableColor = Color.FromArgb(201, 228, 217);
            txtIndice.FillReadOnlyColor = Color.FromArgb(201, 228, 217);
            txtIndice.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIndice.ForeColor = Color.FromArgb(97, 157, 135);
            txtIndice.ForeDisableColor = Color.FromArgb(97, 157, 135);
            txtIndice.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            txtIndice.ImeMode = ImeMode.Disable;
            txtIndice.Location = new Point(290, 18);
            txtIndice.Margin = new Padding(4, 5, 4, 5);
            txtIndice.MinimumSize = new Size(1, 16);
            txtIndice.Name = "txtIndice";
            txtIndice.Padding = new Padding(5);
            txtIndice.Radius = 15;
            txtIndice.ReadOnly = true;
            txtIndice.RectColor = Color.White;
            txtIndice.RectDisableColor = Color.White;
            txtIndice.RectReadOnlyColor = Color.White;
            txtIndice.ScrollBarColor = Color.White;
            txtIndice.ScrollBarStyleInherited = false;
            txtIndice.ShowText = false;
            txtIndice.Size = new Size(52, 29);
            txtIndice.TabIndex = 64;
            txtIndice.TextAlignment = ContentAlignment.MiddleLeft;
            txtIndice.Visible = false;
            txtIndice.Watermark = "Indice";
            // 
            // btnClear
            // 
            btnClear.FillColor = Color.White;
            btnClear.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnClear.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnClear.FillPressColor = Color.Silver;
            btnClear.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(57, 79, 71);
            btnClear.Location = new Point(224, 594);
            btnClear.MinimumSize = new Size(1, 1);
            btnClear.Name = "btnClear";
            btnClear.Radius = 15;
            btnClear.RectColor = Color.Silver;
            btnClear.RectDisableColor = Color.White;
            btnClear.RectHoverColor = Color.White;
            btnClear.RectPressColor = Color.Silver;
            btnClear.RectSelectedColor = Color.White;
            btnClear.ShowFocusColor = true;
            btnClear.ShowFocusLine = true;
            btnClear.Size = new Size(189, 45);
            btnClear.Style = Sunny.UI.UIStyle.Custom;
            btnClear.Symbol = 61741;
            btnClear.SymbolColor = Color.FromArgb(57, 79, 71);
            btnClear.TabIndex = 81;
            btnClear.Text = "Limpiar";
            btnClear.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClear.Click += btnClear_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FillColor = Color.FromArgb(11, 127, 87);
            btnAgregar.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnAgregar.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnAgregar.FillPressColor = Color.Silver;
            btnAgregar.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(29, 594);
            btnAgregar.MinimumSize = new Size(1, 1);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Radius = 15;
            btnAgregar.RectColor = Color.White;
            btnAgregar.RectDisableColor = Color.White;
            btnAgregar.RectHoverColor = Color.White;
            btnAgregar.RectPressColor = Color.White;
            btnAgregar.RectSelectedColor = Color.White;
            btnAgregar.ShowFocusLine = true;
            btnAgregar.Size = new Size(189, 45);
            btnAgregar.Style = Sunny.UI.UIStyle.Custom;
            btnAgregar.Symbol = 61975;
            btnAgregar.TabIndex = 80;
            btnAgregar.Text = "Agregar";
            btnAgregar.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(57, 79, 71);
            label16.Location = new Point(20, 440);
            label16.Name = "label16";
            label16.Size = new Size(83, 17);
            label16.TabIndex = 65;
            label16.Text = "Descripcion*";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 12F);
            txtDescripcion.Location = new Point(20, 462);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MinimumSize = new Size(1, 16);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(5);
            txtDescripcion.Radius = 10;
            txtDescripcion.RectColor = Color.Silver;
            txtDescripcion.ShowText = false;
            txtDescripcion.Size = new Size(393, 118);
            txtDescripcion.Style = Sunny.UI.UIStyle.Custom;
            txtDescripcion.SymbolColor = Color.FromArgb(57, 79, 71);
            txtDescripcion.TabIndex = 66;
            txtDescripcion.TextAlignment = ContentAlignment.MiddleLeft;
            txtDescripcion.Watermark = "Ej: Arroz Faisan 800gr...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(57, 79, 71);
            label8.Location = new Point(20, 187);
            label8.Name = "label8";
            label8.Size = new Size(146, 17);
            label8.TabIndex = 61;
            label8.Text = "Nombre del producto*";
            // 
            // txtNameProducto
            // 
            txtNameProducto.Font = new Font("Microsoft Sans Serif", 12F);
            txtNameProducto.Location = new Point(20, 209);
            txtNameProducto.Margin = new Padding(4, 5, 4, 5);
            txtNameProducto.MinimumSize = new Size(1, 16);
            txtNameProducto.Name = "txtNameProducto";
            txtNameProducto.Padding = new Padding(5);
            txtNameProducto.Radius = 10;
            txtNameProducto.RectColor = Color.Silver;
            txtNameProducto.ShowText = false;
            txtNameProducto.Size = new Size(393, 30);
            txtNameProducto.Style = Sunny.UI.UIStyle.Custom;
            txtNameProducto.SymbolColor = Color.FromArgb(57, 79, 71);
            txtNameProducto.TabIndex = 64;
            txtNameProducto.TextAlignment = ContentAlignment.MiddleLeft;
            txtNameProducto.Watermark = "Ej: Arroz 1 lb";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Enabled = false;
            txtIdProducto.FillColor = Color.FromArgb(201, 228, 217);
            txtIdProducto.FillDisableColor = Color.FromArgb(201, 228, 217);
            txtIdProducto.FillReadOnlyColor = Color.FromArgb(201, 228, 217);
            txtIdProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.ForeColor = Color.FromArgb(97, 157, 135);
            txtIdProducto.ForeDisableColor = Color.FromArgb(97, 157, 135);
            txtIdProducto.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            txtIdProducto.ImeMode = ImeMode.Disable;
            txtIdProducto.Location = new Point(350, 18);
            txtIdProducto.Margin = new Padding(4, 5, 4, 5);
            txtIdProducto.MinimumSize = new Size(1, 16);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Padding = new Padding(5);
            txtIdProducto.Radius = 15;
            txtIdProducto.ReadOnly = true;
            txtIdProducto.RectColor = Color.White;
            txtIdProducto.RectDisableColor = Color.White;
            txtIdProducto.RectReadOnlyColor = Color.White;
            txtIdProducto.ScrollBarColor = Color.White;
            txtIdProducto.ScrollBarStyleInherited = false;
            txtIdProducto.ShowText = false;
            txtIdProducto.Size = new Size(63, 29);
            txtIdProducto.TabIndex = 63;
            txtIdProducto.TextAlignment = ContentAlignment.MiddleLeft;
            txtIdProducto.Watermark = "ID#";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(20, 30);
            label15.Name = "label15";
            label15.Size = new Size(255, 17);
            label15.TabIndex = 62;
            label15.Text = "Complete la informacion de los productos";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(57, 79, 71);
            label17.Location = new Point(20, 9);
            label17.Name = "label17";
            label17.Size = new Size(170, 21);
            label17.TabIndex = 61;
            label17.Text = "Detalles de Productos";
            // 
            // btnClearSearch
            // 
            btnClearSearch.Anchor = AnchorStyles.Top;
            btnClearSearch.BackColor = Color.FromArgb(0, 192, 192);
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = (Image)resources.GetObject("btnClearSearch.Image");
            btnClearSearch.Location = new Point(711, 46);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(24, 24);
            btnClearSearch.TabIndex = 55;
            btnClearSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.FromArgb(0, 192, 192);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(53, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 24);
            btnSearch.TabIndex = 54;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 721);
            Controls.Add(panel2);
            Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            PnlDetails.ResumeLayout(false);
            PnlDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnClearSearch;
        private Button btnSearch;
        private Gradient.PanelGradient panelGradient1;
        private Sunny.UI.UIPanel PnlDetails;
        private Label label7;
        private Sunny.UI.UITextBox txtIndice;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISymbolButton btnAgregar;
        private Sunny.UI.UIComboBox cbEstado;
        private Label label21;
        private Label label16;
        private Sunny.UI.UITextBox txtDescripcion;
        private Label label8;
        private Sunny.UI.UITextBox txtNameProducto;
        private Sunny.UI.UITextBox txtIdProducto;
        private Label label15;
        private Label label17;
        private Sunny.UI.UITextBox uiTextBox3;
        private Label lblTituloGrupo1;
        private Label label18;
        private Sunny.UI.UITextBox txtCodigo;
        private Label label22;
        private Sunny.UI.UITextBox txtStock;
        private Label label20;
        private Sunny.UI.UITextBox txtPrecioV;
        private Label label19;
        private Sunny.UI.UITextBox txtPrecioC;
        private Sunny.UI.UIComboBox cbCategoria;
        private Label label23;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private ModernControls.ModernGrid dgvProducto;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Label label1;
        private Label label13;
        private ReaLTaiizor.Controls.AloneComboBox cbSearch;
        private Label label12;
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
        private Sunny.UI.UISymbolButton btnExportar;
    }
}