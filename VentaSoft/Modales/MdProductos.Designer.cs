namespace Main.Modales
{
    partial class MdProductos
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
            cbSearchPr = new ComboBox();
            label13 = new Label();
            btnClearSearch = new Button();
            txtSearchPr = new TextBox();
            dgvProducto = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            lblSubtitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // cbSearchPr
            // 
            cbSearchPr.Cursor = Cursors.Hand;
            cbSearchPr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchPr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearchPr.FormattingEnabled = true;
            cbSearchPr.Location = new Point(0, 68);
            cbSearchPr.Name = "cbSearchPr";
            cbSearchPr.Size = new Size(148, 28);
            cbSearchPr.TabIndex = 55;
            cbSearchPr.SelectedIndexChanged += cbSearchPr_TabIndexChanged;
            cbSearchPr.TabIndexChanged += cbSearchPr_TabIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 43);
            label13.Name = "label13";
            label13.Size = new Size(95, 20);
            label13.TabIndex = 54;
            label13.Text = "Buscar por*";
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Transparent;
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Image = Properties.Resources.recargar;
            btnClearSearch.ImageAlign = ContentAlignment.MiddleRight;
            btnClearSearch.Location = new Point(154, 64);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(94, 32);
            btnClearSearch.TabIndex = 58;
            btnClearSearch.Text = "Limpiar";
            btnClearSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnClearSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtSearchPr
            // 
            txtSearchPr.BorderStyle = BorderStyle.FixedSingle;
            txtSearchPr.Cursor = Cursors.IBeam;
            txtSearchPr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPr.Location = new Point(0, 98);
            txtSearchPr.Name = "txtSearchPr";
            txtSearchPr.PlaceholderText = "Ecribe para Buscar";
            txtSearchPr.Size = new Size(255, 29);
            txtSearchPr.TabIndex = 56;
            txtSearchPr.Tag = "";
            txtSearchPr.TextChanged += txtSearchPr_TextChanged;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducto.BackgroundColor = Color.White;
            dgvProducto.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Nombre, Categoria, Stock, PrecioCompra, PrecioVenta });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducto.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducto.EnableHeadersVisualStyles = false;
            dgvProducto.GridColor = Color.White;
            dgvProducto.Location = new Point(0, 133);
            dgvProducto.Name = "dgvProducto";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProducto.RowHeadersVisible = false;
            dgvProducto.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvProducto.RowTemplate.Height = 36;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(538, 330);
            dgvProducto.TabIndex = 59;
            dgvProducto.CellDoubleClick += dgvProducto_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 10;
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 10;
            Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 10;
            Categoria.Name = "Categoria";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Visible = false;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Visible = false;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.FromArgb(15, 118, 110);
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(0, -3);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(657, 36);
            bigLabel1.TabIndex = 71;
            bigLabel1.Text = "Lista de Productos*";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(0, 466);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(569, 20);
            lblSubtitulo.TabIndex = 78;
            lblSubtitulo.Text = "Has doble click en cualquier espacio seleccionado";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MdProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 118, 110);
            ClientSize = new Size(539, 491);
            Controls.Add(lblSubtitulo);
            Controls.Add(bigLabel1);
            Controls.Add(dgvProducto);
            Controls.Add(btnClearSearch);
            Controls.Add(txtSearchPr);
            Controls.Add(cbSearchPr);
            Controls.Add(label13);
            Name = "MdProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MdProductos";
            Load += MdProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbSearchPr;
        private Label label13;
        private Button btnClearSearch;
        private TextBox txtSearchPr;
        private DataGridView dgvProducto;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label lblSubtitulo;
    }
}