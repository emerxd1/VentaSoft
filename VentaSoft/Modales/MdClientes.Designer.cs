namespace Main.Modales
{
    partial class MdClientes
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            txtSearch = new TextBox();
            cbSearchClientes = new ComboBox();
            label13 = new Label();
            dgvClients = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            lblSubtitulo = new Label();
            btnClearSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.FromArgb(15, 118, 110);
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(-2, -1);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(657, 36);
            bigLabel1.TabIndex = 70;
            bigLabel1.Text = "Detalles de la Venta*";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(-2, 99);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Ecribe para Buscar";
            txtSearch.Size = new Size(246, 29);
            txtSearch.TabIndex = 73;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbSearchClientes
            // 
            cbSearchClientes.BackColor = SystemColors.Menu;
            cbSearchClientes.Cursor = Cursors.Hand;
            cbSearchClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearchClientes.FormattingEnabled = true;
            cbSearchClientes.Location = new Point(0, 68);
            cbSearchClientes.Name = "cbSearchClientes";
            cbSearchClientes.Size = new Size(124, 28);
            cbSearchClientes.TabIndex = 72;
            cbSearchClientes.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(-2, 41);
            label13.Name = "label13";
            label13.Size = new Size(102, 21);
            label13.TabIndex = 71;
            label13.Text = "Buscar por*";
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.BackgroundColor = Color.White;
            dgvClients.BorderStyle = BorderStyle.None;
            dgvClients.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { IdCliente, DNI, Cliente });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvClients.DefaultCellStyle = dataGridViewCellStyle8;
            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.GridColor = Color.White;
            dgvClients.Location = new Point(-2, 131);
            dgvClients.Name = "dgvClients";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvClients.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dgvClients.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvClients.RowTemplate.Height = 36;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(571, 294);
            dgvClients.TabIndex = 76;
            dgvClients.CellDoubleClick += dgvClients_CellDoubleClick;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "IdCliente";
            IdCliente.MinimumWidth = 10;
            IdCliente.Name = "IdCliente";
            IdCliente.Visible = false;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 10;
            DNI.Name = "DNI";
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 10;
            Cliente.Name = "Cliente";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(-2, 426);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(569, 20);
            lblSubtitulo.TabIndex = 77;
            lblSubtitulo.Text = "Has doble click sobre el DNI o CLIENTE";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Transparent;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Image = Properties.Resources.recargar;
            btnClearSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearSearch.Location = new Point(139, 68);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(92, 28);
            btnClearSearch.TabIndex = 78;
            btnClearSearch.Text = "Limpiar";
            btnClearSearch.TextAlign = ContentAlignment.MiddleRight;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // MdClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 118, 110);
            ClientSize = new Size(569, 461);
            Controls.Add(btnClearSearch);
            Controls.Add(lblSubtitulo);
            Controls.Add(dgvClients);
            Controls.Add(txtSearch);
            Controls.Add(cbSearchClientes);
            Controls.Add(label13);
            Controls.Add(bigLabel1);
            Name = "MdClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MdClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private TextBox txtSearch;
        private ComboBox cbSearchClientes;
        private Label label13;
        private DataGridView dgvClients;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Cliente;
        private Label lblSubtitulo;
        private Button btnClearSearch;
    }
}