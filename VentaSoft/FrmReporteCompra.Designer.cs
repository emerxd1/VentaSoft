namespace Main
{
    partial class FrmReporteCompra
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            btnBuscar = new Sunny.UI.UISymbolButton();
            cbProveedores = new Sunny.UI.UIComboBox();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            dpFin = new AntdUI.DatePicker();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            dpInicio = new AntdUI.DatePicker();
            uiPanel2 = new Sunny.UI.UIPanel();
            btnExportar = new Sunny.UI.UISymbolButton();
            cbFiltro = new Sunny.UI.UIComboBox();
            bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            txtSearch = new Sunny.UI.UITextBox();
            dgvReportCompra = new ModernControls.ModernGrid();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumDocumento = new DataGridViewTextBoxColumn();
            User_registro = new DataGridViewTextBoxColumn();
            Ruc = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProduct = new DataGridViewTextBoxColumn();
            NameProduct = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportCompra).BeginInit();
            SuspendLayout();
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Gray;
            bigLabel2.Location = new Point(36, 35);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(585, 17);
            bigLabel2.TabIndex = 65;
            bigLabel2.Text = "Consulta las compras registradas por rango de fechas y proveedor, y exporta el resultado a Excel.";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(57, 79, 71);
            bigLabel1.Location = new Point(35, 9);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(210, 30);
            bigLabel1.TabIndex = 64;
            bigLabel1.Text = "Reporte de compras";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnBuscar);
            uiPanel1.Controls.Add(cbProveedores);
            uiPanel1.Controls.Add(bigLabel5);
            uiPanel1.Controls.Add(bigLabel4);
            uiPanel1.Controls.Add(dpFin);
            uiPanel1.Controls.Add(bigLabel3);
            uiPanel1.Controls.Add(dpInicio);
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(36, 65);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel1.Size = new Size(1250, 89);
            uiPanel1.TabIndex = 66;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            btnBuscar.FillColor = Color.FromArgb(15, 118, 110);
            btnBuscar.FillHoverColor = Color.FromArgb(10, 78, 73);
            btnBuscar.FillPressColor = Color.Gray;
            btnBuscar.FillSelectedColor = Color.FromArgb(10, 78, 73);
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(1128, 45);
            btnBuscar.MinimumSize = new Size(1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Radius = 10;
            btnBuscar.RectColor = Color.White;
            btnBuscar.RectDisableColor = Color.White;
            btnBuscar.RectHoverColor = Color.White;
            btnBuscar.RectPressColor = Color.White;
            btnBuscar.RectSelectedColor = Color.White;
            btnBuscar.Size = new Size(100, 35);
            btnBuscar.Symbol = 61442;
            btnBuscar.TabIndex = 79;
            btnBuscar.Text = "Buscar";
            btnBuscar.TipsFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbProveedores
            // 
            cbProveedores.BackColor = Color.White;
            cbProveedores.DataSource = null;
            cbProveedores.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbProveedores.FillColor = Color.White;
            cbProveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProveedores.ItemHoverColor = Color.FromArgb(223, 243, 239);
            cbProveedores.ItemRectColor = Color.FromArgb(15, 118, 110);
            cbProveedores.ItemSelectBackColor = Color.FromArgb(95, 163, 158);
            cbProveedores.ItemSelectForeColor = Color.FromArgb(64, 64, 64);
            cbProveedores.Location = new Point(534, 40);
            cbProveedores.Margin = new Padding(4, 5, 4, 5);
            cbProveedores.MinimumSize = new Size(63, 0);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Padding = new Padding(0, 0, 30, 2);
            cbProveedores.Radius = 15;
            cbProveedores.RectColor = Color.FromArgb(224, 224, 224);
            cbProveedores.Size = new Size(240, 38);
            cbProveedores.SymbolSize = 24;
            cbProveedores.TabIndex = 77;
            cbProveedores.TextAlignment = ContentAlignment.MiddleLeft;
            cbProveedores.Watermark = "Seleccione un proveedor";
            // 
            // bigLabel5
            // 
            bigLabel5.AutoSize = true;
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel5.ForeColor = Color.FromArgb(20, 32, 30);
            bigLabel5.Location = new Point(534, 18);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(82, 17);
            bigLabel5.TabIndex = 76;
            bigLabel5.Text = "Proveedores";
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel4.ForeColor = Color.FromArgb(20, 32, 30);
            bigLabel4.Location = new Point(280, 18);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(61, 17);
            bigLabel4.TabIndex = 74;
            bigLabel4.Text = "Fecha Fin";
            // 
            // dpFin
            // 
            dpFin.Font = new Font("Segoe UI", 12F);
            dpFin.Format = "dd-MM-yyyy";
            dpFin.IconRatio = 0.8F;
            dpFin.Location = new Point(280, 38);
            dpFin.Name = "dpFin";
            dpFin.PlaceholderText = "Seleccione fecha final";
            dpFin.Size = new Size(240, 43);
            dpFin.TabIndex = 73;
            dpFin.ValueTimeHorizontal = true;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.FromArgb(20, 32, 30);
            bigLabel3.Location = new Point(30, 18);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(75, 17);
            bigLabel3.TabIndex = 72;
            bigLabel3.Text = "Fecha Inicio";
            // 
            // dpInicio
            // 
            dpInicio.Font = new Font("Segoe UI", 12F);
            dpInicio.Format = "dd-MM-yyyy";
            dpInicio.IconRatio = 0.8F;
            dpInicio.Location = new Point(30, 38);
            dpInicio.Name = "dpInicio";
            dpInicio.PlaceholderText = "Seleccione fecha inical";
            dpInicio.Size = new Size(240, 43);
            dpInicio.TabIndex = 71;
            dpInicio.ValueTimeHorizontal = true;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(btnExportar);
            uiPanel2.Controls.Add(cbFiltro);
            uiPanel2.Controls.Add(bigLabel7);
            uiPanel2.Controls.Add(txtSearch);
            uiPanel2.Controls.Add(dgvReportCompra);
            uiPanel2.Controls.Add(bigLabel6);
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(35, 183);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 10;
            uiPanel2.RectColor = Color.FromArgb(224, 224, 224);
            uiPanel2.Size = new Size(1250, 507);
            uiPanel2.TabIndex = 67;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnExportar
            // 
            btnExportar.FillColor = Color.White;
            btnExportar.FillHoverColor = Color.FromArgb(91, 137, 133);
            btnExportar.FillPressColor = Color.Gray;
            btnExportar.FillSelectedColor = Color.FromArgb(91, 137, 133);
            btnExportar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = Color.FromArgb(10, 78, 73);
            btnExportar.ForeDisableColor = Color.FromArgb(10, 78, 73);
            btnExportar.Location = new Point(31, 43);
            btnExportar.MinimumSize = new Size(1, 1);
            btnExportar.Name = "btnExportar";
            btnExportar.Radius = 10;
            btnExportar.RectColor = Color.FromArgb(10, 78, 73);
            btnExportar.RectDisableColor = Color.White;
            btnExportar.RectHoverColor = Color.White;
            btnExportar.RectPressColor = Color.White;
            btnExportar.RectSelectedColor = Color.White;
            btnExportar.Size = new Size(152, 35);
            btnExportar.Symbol = 61891;
            btnExportar.SymbolColor = Color.FromArgb(15, 118, 110);
            btnExportar.TabIndex = 82;
            btnExportar.Text = "Descargar excel";
            btnExportar.TipsFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.Click += uiSymbolButton1_Click;
            // 
            // cbFiltro
            // 
            cbFiltro.BackColor = Color.White;
            cbFiltro.DataSource = null;
            cbFiltro.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbFiltro.FillColor = Color.White;
            cbFiltro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFiltro.ItemHoverColor = Color.FromArgb(223, 243, 239);
            cbFiltro.ItemRectColor = Color.FromArgb(15, 118, 110);
            cbFiltro.ItemSelectBackColor = Color.FromArgb(95, 163, 158);
            cbFiltro.ItemSelectForeColor = Color.FromArgb(64, 64, 64);
            cbFiltro.Location = new Point(472, 43);
            cbFiltro.Margin = new Padding(4, 5, 4, 5);
            cbFiltro.MinimumSize = new Size(63, 0);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Padding = new Padding(0, 0, 30, 2);
            cbFiltro.Radius = 15;
            cbFiltro.RectColor = Color.FromArgb(224, 224, 224);
            cbFiltro.Size = new Size(340, 32);
            cbFiltro.SymbolSize = 24;
            cbFiltro.TabIndex = 81;
            cbFiltro.TextAlignment = ContentAlignment.MiddleLeft;
            cbFiltro.Watermark = "Seleccione categoria a filtrar";
            cbFiltro.SelectedIndexChanged += cbFiltro_SelectedIndexChanged;
            // 
            // bigLabel7
            // 
            bigLabel7.AutoSize = true;
            bigLabel7.BackColor = Color.Transparent;
            bigLabel7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel7.ForeColor = Color.FromArgb(20, 32, 30);
            bigLabel7.Location = new Point(472, 21);
            bigLabel7.Name = "bigLabel7";
            bigLabel7.Size = new Size(66, 17);
            bigLabel7.TabIndex = 80;
            bigLabel7.Text = "Filtrar por";
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
            txtSearch.Location = new Point(820, 43);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.Radius = 10;
            txtSearch.RectColor = Color.Silver;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(409, 32);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.Symbol = 61442;
            txtSearch.SymbolColor = Color.FromArgb(57, 79, 71);
            txtSearch.TabIndex = 79;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Escriba para buscar...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvReportCompra
            // 
            dgvReportCompra.AllowUserToAddRows = false;
            dgvReportCompra.AllowUserToDeleteRows = false;
            dgvReportCompra.AllowUserToResizeColumns = false;
            dgvReportCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvReportCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvReportCompra.AutoFitColumns = false;
            dgvReportCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportCompra.BackgroundColor = Color.White;
            dgvReportCompra.BorderStyle = BorderStyle.None;
            dgvReportCompra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(100, 116, 146);
            dataGridViewCellStyle6.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(100, 116, 146);
            dgvReportCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvReportCompra.ColumnHeadersHeight = 44;
            dgvReportCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReportCompra.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumDocumento, User_registro, Ruc, RazonSocial, CodigoProduct, NameProduct, Category, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle7.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgvReportCompra.DefaultCellStyle = dataGridViewCellStyle7;
            dgvReportCompra.EnableHeadersVisualStyles = false;
            dgvReportCompra.Font = new Font("Segoe UI", 9.5F);
            dgvReportCompra.GridColor = Color.White;
            dgvReportCompra.Location = new Point(19, 96);
            dgvReportCompra.MultiSelect = false;
            dgvReportCompra.Name = "dgvReportCompra";
            dgvReportCompra.ReadOnly = true;
            dgvReportCompra.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReportCompra.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle8.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvReportCompra.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvReportCompra.RowTemplate.Height = 56;
            dgvReportCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportCompra.ShowCellToolTips = false;
            dgvReportCompra.Size = new Size(1217, 383);
            dgvReportCompra.TabIndex = 78;
            // 
            // FechaRegistro
            // 
            FechaRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FechaRegistro.FillWeight = 123F;
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 123;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.SortMode = DataGridViewColumnSortMode.NotSortable;
            FechaRegistro.Width = 123;
            // 
            // TipoDocumento
            // 
            TipoDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TipoDocumento.FillWeight = 150F;
            TipoDocumento.HeaderText = "Tipo de documento";
            TipoDocumento.MinimumWidth = 120;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            TipoDocumento.SortMode = DataGridViewColumnSortMode.NotSortable;
            TipoDocumento.Width = 120;
            // 
            // NumDocumento
            // 
            NumDocumento.FillWeight = 175F;
            NumDocumento.HeaderText = "# de documento";
            NumDocumento.MinimumWidth = 120;
            NumDocumento.Name = "NumDocumento";
            NumDocumento.ReadOnly = true;
            NumDocumento.SortMode = DataGridViewColumnSortMode.NotSortable;
            NumDocumento.Visible = false;
            // 
            // User_registro
            // 
            User_registro.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            User_registro.FillWeight = 137F;
            User_registro.HeaderText = "Usuario registro";
            User_registro.MinimumWidth = 137;
            User_registro.Name = "User_registro";
            User_registro.ReadOnly = true;
            User_registro.SortMode = DataGridViewColumnSortMode.NotSortable;
            User_registro.Width = 137;
            // 
            // Ruc
            // 
            Ruc.FillWeight = 123F;
            Ruc.HeaderText = "Ruc Proveedor";
            Ruc.MinimumWidth = 123;
            Ruc.Name = "Ruc";
            Ruc.ReadOnly = true;
            Ruc.SortMode = DataGridViewColumnSortMode.NotSortable;
            Ruc.Visible = false;
            // 
            // RazonSocial
            // 
            RazonSocial.FillWeight = 113F;
            RazonSocial.HeaderText = "Proveedor";
            RazonSocial.MinimumWidth = 113;
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CodigoProduct
            // 
            CodigoProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CodigoProduct.FillWeight = 140F;
            CodigoProduct.HeaderText = "Codigo producto";
            CodigoProduct.MinimumWidth = 140;
            CodigoProduct.Name = "CodigoProduct";
            CodigoProduct.ReadOnly = true;
            CodigoProduct.SortMode = DataGridViewColumnSortMode.NotSortable;
            CodigoProduct.Width = 140;
            // 
            // NameProduct
            // 
            NameProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NameProduct.FillWeight = 144F;
            NameProduct.HeaderText = "Nombre Producto";
            NameProduct.MinimumWidth = 144;
            NameProduct.Name = "NameProduct";
            NameProduct.ReadOnly = true;
            NameProduct.SortMode = DataGridViewColumnSortMode.NotSortable;
            NameProduct.Width = 144;
            // 
            // Category
            // 
            Category.FillWeight = 93F;
            Category.HeaderText = "Categoria";
            Category.MinimumWidth = 93;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel6.ForeColor = Color.FromArgb(20, 32, 30);
            bigLabel6.Location = new Point(820, 21);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(65, 17);
            bigLabel6.TabIndex = 76;
            bigLabel6.Text = "Busqueda";
            // 
            // FrmReporteCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 721);
            Controls.Add(uiPanel2);
            Controls.Add(uiPanel1);
            Controls.Add(bigLabel2);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporteCompra";
            Text = "FrmReporteCompra";
            Load += FrmReporteCompra_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private AntdUI.DatePicker dpInicio;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private AntdUI.DatePicker dpFin;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private Sunny.UI.UIComboBox cbProveedores;
        private Sunny.UI.UISymbolButton btnBuscar;
        private Sunny.UI.UIPanel uiPanel2;
        private ModernControls.ModernGrid dgvReportCompra;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIComboBox cbFiltro;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private Sunny.UI.UISymbolButton btnExportar;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumDocumento;
        private DataGridViewTextBoxColumn User_registro;
        private DataGridViewTextBoxColumn Ruc;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProduct;
        private DataGridViewTextBoxColumn NameProduct;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}