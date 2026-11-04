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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            txtSearch = new TextBox();
            cbSearchClientes = new ComboBox();
            label13 = new Label();
            dgvClients = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            lblSubtitulo = new Label();
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
            txtSearch.Size = new Size(312, 29);
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
            cbSearchClientes.Size = new Size(205, 28);
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
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.BackgroundColor = Color.White;
            dgvClients.BorderStyle = BorderStyle.None;
            dgvClients.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { IdCliente, DNI, Cliente });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.GridColor = Color.White;
            dgvClients.Location = new Point(-2, 131);
            dgvClients.Name = "dgvClients";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvClients.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dgvClients.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvClients.RowTemplate.Height = 36;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(933, 456);
            dgvClients.TabIndex = 76;
            dgvClients.CellContentClick += dgvClients_CellContentClick;
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
            lblSubtitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(-2, 590);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(569, 31);
            lblSubtitulo.TabIndex = 77;
            lblSubtitulo.Text = "Has doble click sobre el DNI o CLIENTE";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MdClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 118, 110);
            ClientSize = new Size(933, 630);
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
        private Label lblSubtitulo;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Cliente;
    }
}