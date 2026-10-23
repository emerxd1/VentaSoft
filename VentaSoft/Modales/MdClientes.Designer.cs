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
            btnClearSearch = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbSearchClientes = new ComboBox();
            label13 = new Label();
            dgvClients = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.FromArgb(8, 92, 63);
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(-2, -1);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(657, 36);
            bigLabel1.TabIndex = 70;
            bigLabel1.Text = "Detalles de la Venta*";
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Transparent;
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = Properties.Resources.recargar;
            btnClearSearch.Location = new Point(182, 60);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(44, 36);
            btnClearSearch.TabIndex = 75;
            btnClearSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImageLayout = ImageLayout.Center;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.Image = Properties.Resources.lupa;
            btnSearch.Location = new Point(130, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(46, 36);
            btnSearch.TabIndex = 74;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(-2, 99);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "EJ: 001-092008-1234X";
            txtSearch.Size = new Size(246, 29);
            txtSearch.TabIndex = 73;
            txtSearch.TextChanged += cbSearch_SelectedIndexChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // cbSearchClientes
            // 
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
            label13.ForeColor = Color.Black;
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
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClients.BackgroundColor = Color.White;
            dgvClients.BorderStyle = BorderStyle.None;
            dgvClients.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { IdCliente, DNI, Cliente });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
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
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvClients.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.MediumSpringGreen;
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
            DNI.Width = 250;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 10;
            Cliente.Name = "Cliente";
            Cliente.Width = 320;
            // 
            // MdClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(569, 426);
            Controls.Add(dgvClients);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cbSearchClientes);
            Controls.Add(label13);
            Controls.Add(bigLabel1);
            Name = "MdClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MdClientes";
            Load += MdClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Button btnClearSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbSearchClientes;
        private Label label13;
        private DataGridView dgvClients;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Cliente;
    }
}