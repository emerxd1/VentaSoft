namespace Main
{
    partial class FrmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnDelete = new Button();
            BtnUpdate = new Button();
            panel1 = new Panel();
            btnClearSearch = new Button();
            panelGradient3 = new Gradient.PanelGradient();
            btnClear = new Button();
            label11 = new Label();
            btnRegister = new Button();
            label1 = new Label();
            txtIndice = new TextBox();
            txtName = new TextBox();
            label14 = new Label();
            lblDescripcion = new Label();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            label10 = new Label();
            cbEstado = new ComboBox();
            btnDetails = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            dgvCategory = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdCategory = new DataGridViewButtonColumn();
            NameCategory = new DataGridViewTextBoxColumn();
            DescripcionCategory = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            panelGradient1 = new Gradient.PanelGradient();
            panelGradient2 = new Gradient.PanelGradient();
            elipseControl1 = new ElipseControl.ElipseControl();
            panel1.SuspendLayout();
            panelGradient3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(710, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 48);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BtnUpdate.BackColor = Color.White;
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            BtnUpdate.Image = (Image)resources.GetObject("BtnUpdate.Image");
            BtnUpdate.Location = new Point(710, 333);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(145, 48);
            BtnUpdate.TabIndex = 32;
            BtnUpdate.Text = "Actualizar";
            BtnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnClearSearch);
            panel1.Controls.Add(panelGradient3);
            panel1.Controls.Add(btnDetails);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cbSearch);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dgvCategory);
            panel1.Controls.Add(panelGradient1);
            panel1.Controls.Add(panelGradient2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 723);
            panel1.TabIndex = 8;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = (Image)resources.GetObject("btnClearSearch.Image");
            btnClearSearch.Location = new Point(801, 46);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(43, 43);
            btnClearSearch.TabIndex = 48;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // panelGradient3
            // 
            panelGradient3.BackColor = SystemColors.WindowFrame;
            panelGradient3.BorderStyle = BorderStyle.FixedSingle;
            panelGradient3.Controls.Add(btnClear);
            panelGradient3.Controls.Add(label11);
            panelGradient3.Controls.Add(btnRegister);
            panelGradient3.Controls.Add(label1);
            panelGradient3.Controls.Add(txtIndice);
            panelGradient3.Controls.Add(txtName);
            panelGradient3.Controls.Add(label14);
            panelGradient3.Controls.Add(lblDescripcion);
            panelGradient3.Controls.Add(txtId);
            panelGradient3.Controls.Add(txtDescripcion);
            panelGradient3.Controls.Add(label10);
            panelGradient3.Controls.Add(cbEstado);
            panelGradient3.Dock = DockStyle.Right;
            panelGradient3.ForeColor = Color.Black;
            panelGradient3.GradientBottomColor = Color.White;
            panelGradient3.GradientTopColor = Color.White;
            panelGradient3.Location = new Point(919, 0);
            panelGradient3.Name = "panelGradient3";
            panelGradient3.Size = new Size(338, 723);
            panelGradient3.TabIndex = 52;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(197, 553);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 48);
            btnClear.TabIndex = 64;
            btnClear.Text = "Limpiar";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(79, 17);
            label11.Name = "label11";
            label11.Size = new Size(224, 32);
            label11.TabIndex = 59;
            label11.Text = "Detalles Categorias";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegister.BackColor = Color.White;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(21, 553);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 48);
            btnRegister.TabIndex = 63;
            btnRegister.Text = "Registrar";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(9, 127);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 54;
            label1.Text = "Nombre";
            // 
            // txtIndice
            // 
            txtIndice.BackColor = Color.White;
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIndice.ForeColor = Color.Silver;
            txtIndice.Location = new Point(9, 82);
            txtIndice.Name = "txtIndice";
            txtIndice.ReadOnly = true;
            txtIndice.Size = new Size(93, 27);
            txtIndice.TabIndex = 62;
            txtIndice.Text = "Automatico";
            txtIndice.Visible = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Century Gothic", 9.75F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(9, 145);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ej: \"Enlatados\"";
            txtName.Size = new Size(164, 27);
            txtName.TabIndex = 53;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.Location = new Point(175, 49);
            label14.Name = "label14";
            label14.Size = new Size(125, 23);
            label14.TabIndex = 61;
            label14.Text = "Id de categoria";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.White;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDescripcion.Location = new Point(9, 198);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(98, 23);
            lblDescripcion.TabIndex = 56;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Gray;
            txtId.Location = new Point(282, 49);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(26, 20);
            txtId.TabIndex = 60;
            txtId.Text = "0";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Century Gothic", 9.75F);
            txtDescripcion.Location = new Point(15, 224);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Ej: \"Productos enlatados........\"";
            txtDescripcion.Size = new Size(293, 88);
            txtDescripcion.TabIndex = 55;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(16, 336);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 57;
            label10.Text = "Estado";
            // 
            // cbEstado
            // 
            cbEstado.BackColor = Color.White;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Century Gothic", 9.75F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(16, 357);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 29);
            cbEstado.TabIndex = 58;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.White;
            btnDetails.Cursor = Cursors.Hand;
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDetails.Image = (Image)resources.GetObject("btnDetails.Image");
            btnDetails.Location = new Point(211, 125);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(242, 38);
            btnDetails.TabIndex = 49;
            btnDetails.Text = "Detalles de Empleados";
            btnDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(740, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(43, 43);
            btnSearch.TabIndex = 47;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(192, 255, 255);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(533, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 29);
            txtSearch.TabIndex = 44;
            // 
            // cbSearch
            // 
            cbSearch.BackColor = Color.FromArgb(192, 255, 255);
            cbSearch.Cursor = Cursors.Hand;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FlatStyle = FlatStyle.Flat;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(382, 54);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(143, 29);
            cbSearch.TabIndex = 46;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(192, 255, 255);
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(287, 54);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 45;
            label13.Text = "Buscar por:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(192, 255, 255);
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(44, 54);
            label12.Name = "label12";
            label12.Size = new Size(221, 32);
            label12.TabIndex = 43;
            label12.Text = "Lista de Categorias";
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeColumns = false;
            dgvCategory.AllowUserToResizeRows = false;
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.BorderStyle = BorderStyle.None;
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.ColumnHeadersHeight = 29;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdCategory, NameCategory, DescripcionCategory, Estado, EstadoValor });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.GridColor = Color.White;
            dgvCategory.Location = new Point(84, 184);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(544, 367);
            dgvCategory.TabIndex = 39;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            dgvCategory.CellFormatting += dgvCategory_CellFormatting;
            dgvCategory.CellPainting += dgvCategory_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.MinimumWidth = 6;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 35;
            // 
            // IdCategory
            // 
            IdCategory.HeaderText = "id";
            IdCategory.MinimumWidth = 6;
            IdCategory.Name = "IdCategory";
            IdCategory.ReadOnly = true;
            IdCategory.Text = "";
            IdCategory.Visible = false;
            IdCategory.Width = 35;
            // 
            // NameCategory
            // 
            NameCategory.HeaderText = "Nombre";
            NameCategory.MinimumWidth = 6;
            NameCategory.Name = "NameCategory";
            NameCategory.ReadOnly = true;
            NameCategory.Width = 125;
            // 
            // DescripcionCategory
            // 
            DescripcionCategory.HeaderText = "Descripcion";
            DescripcionCategory.MinimumWidth = 6;
            DescripcionCategory.Name = "DescripcionCategory";
            DescripcionCategory.ReadOnly = true;
            DescripcionCategory.Width = 300;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.MinimumWidth = 6;
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            EstadoValor.Width = 125;
            // 
            // panelGradient1
            // 
            panelGradient1.BackColor = Color.White;
            panelGradient1.ForeColor = Color.Black;
            panelGradient1.GradientBottomColor = Color.FromArgb(192, 255, 255);
            panelGradient1.GradientTopColor = Color.FromArgb(192, 255, 255);
            panelGradient1.Location = new Point(82, 169);
            panelGradient1.Name = "panelGradient1";
            panelGradient1.Size = new Size(547, 403);
            panelGradient1.TabIndex = 50;
            // 
            // panelGradient2
            // 
            panelGradient2.BackColor = Color.White;
            panelGradient2.ForeColor = Color.Black;
            panelGradient2.GradientBottomColor = Color.FromArgb(192, 255, 255);
            panelGradient2.GradientTopColor = Color.FromArgb(192, 255, 255);
            panelGradient2.Location = new Point(37, 28);
            panelGradient2.Name = "panelGradient2";
            panelGradient2.Size = new Size(831, 75);
            panelGradient2.TabIndex = 53;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 55;
            elipseControl1.TargetControl = dgvCategory;
            // 
            // FrmCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1257, 723);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmCategory";
            Text = "Form1";
            Load += FrmCategory_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGradient3.ResumeLayout(false);
            panelGradient3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnDelete;
        private Button BtnUpdate;
        private Panel panel1;
        private Button btnDetails;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private DataGridView dgvCategory;
        private Label label12;
        private Label label13;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewButtonColumn IdCategory;
        private DataGridViewTextBoxColumn NameCategory;
        private DataGridViewTextBoxColumn DescripcionCategory;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
        private Gradient.PanelGradient panelGradient1;
        public ElipseControl.ElipseControl elipseControl1;
        private Gradient.PanelGradient panelGradient3;
        private Button btnClear;
        private Label label11;
        private Button btnRegister;
        private Label label1;
        private TextBox txtIndice;
        private TextBox txtName;
        private Label label14;
        private Label lblDescripcion;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private Label label10;
        private ComboBox cbEstado;
        private Button btnClearSearch;
        private Gradient.PanelGradient panelGradient2;
    }
}