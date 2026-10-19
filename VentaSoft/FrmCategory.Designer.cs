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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnDelete = new Button();
            BtnUpdate = new Button();
            panel1 = new Panel();
            btnClearSearch = new Button();
            panelGradient3 = new Gradient.PanelGradient();
            txtDescripcion = new TextBoxRGB.TextBoxP();
            txtName = new TextBoxRGB.TextBoxP();
            btnClear = new Button();
            label11 = new Label();
            btnRegister = new Button();
            label1 = new Label();
            txtIndice = new TextBox();
            label14 = new Label();
            lblDescripcion = new Label();
            txtId = new TextBox();
            label10 = new Label();
            cbEstado = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            dgvCategory = new DataGridView();
            panelGradient1 = new Gradient.PanelGradient();
            panelGradient2 = new Gradient.PanelGradient();
            cbSearch = new WinFormsApp1.ComboBoxUp();
            btnSearch = new Button();
            txtSearch = new TextBoxRGB.TextBoxP();
            elipseControl1 = new ElipseControlLib.ElipseControl();
            elipseControl2 = new ElipseControlLib.ElipseControl();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdCategory = new DataGridViewButtonColumn();
            NameCategory = new DataGridViewTextBoxColumn();
            DescripcionCategory = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panelGradient3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panelGradient2.SuspendLayout();
            SuspendLayout();
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
            btnDelete.ForeColor = Color.FromArgb(31, 45, 56);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(41, 559);
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
            BtnUpdate.Anchor = AnchorStyles.Top;
            BtnUpdate.BackColor = Color.White;
            BtnUpdate.Cursor = Cursors.Hand;
            BtnUpdate.FlatAppearance.BorderSize = 0;
            BtnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            BtnUpdate.FlatStyle = FlatStyle.Flat;
            BtnUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            BtnUpdate.ForeColor = Color.FromArgb(31, 45, 56);
            BtnUpdate.Image = (Image)resources.GetObject("BtnUpdate.Image");
            BtnUpdate.Location = new Point(226, 559);
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
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(dgvCategory);
            panel1.Controls.Add(panelGradient1);
            panel1.Controls.Add(panelGradient2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(31, 45, 56);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 631);
            panel1.TabIndex = 8;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Anchor = AnchorStyles.Top;
            btnClearSearch.BackColor = Color.FromArgb(110, 151, 163);
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = (Image)resources.GetObject("btnClearSearch.Image");
            btnClearSearch.Location = new Point(770, 46);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(43, 43);
            btnClearSearch.TabIndex = 48;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // panelGradient3
            // 
            panelGradient3.Anchor = AnchorStyles.Top;
            panelGradient3.BackColor = SystemColors.WindowFrame;
            panelGradient3.BorderRadius = 0;
            panelGradient3.BorderStyle = BorderStyle.FixedSingle;
            panelGradient3.Controls.Add(txtDescripcion);
            panelGradient3.Controls.Add(txtName);
            panelGradient3.Controls.Add(btnClear);
            panelGradient3.Controls.Add(label11);
            panelGradient3.Controls.Add(btnRegister);
            panelGradient3.Controls.Add(label1);
            panelGradient3.Controls.Add(txtIndice);
            panelGradient3.Controls.Add(label14);
            panelGradient3.Controls.Add(lblDescripcion);
            panelGradient3.Controls.Add(txtId);
            panelGradient3.Controls.Add(label10);
            panelGradient3.Controls.Add(cbEstado);
            panelGradient3.ForeColor = Color.Black;
            panelGradient3.GradientBottomColor = Color.White;
            panelGradient3.GradientTopColor = Color.White;
            panelGradient3.Location = new Point(888, 0);
            panelGradient3.Name = "panelGradient3";
            panelGradient3.Size = new Size(338, 723);
            panelGradient3.TabIndex = 52;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Window;
            txtDescripcion.BorderColor = Color.FromArgb(110, 151, 163);
            txtDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Holdertext = "Ingrese una descripcion para la categoria";
            txtDescripcion.Location = new Point(9, 218);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(2);
            txtDescripcion.Size = new Size(284, 115);
            txtDescripcion.TabIndex = 66;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderColor = Color.FromArgb(110, 151, 163);
            txtName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.Black;
            txtName.Holdertext = "Ingrese nombre de la categoria";
            txtName.Location = new Point(9, 147);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(2);
            txtName.Size = new Size(284, 22);
            txtName.TabIndex = 65;
            txtName.Underlinedstyle = true;
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
            btnClear.ForeColor = Color.FromArgb(31, 45, 56);
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(182, 436);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 48);
            btnClear.TabIndex = 64;
            btnClear.Text = "Limpiar";
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(31, 45, 56);
            label11.Location = new Point(79, 17);
            label11.Name = "label11";
            label11.Size = new Size(177, 25);
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
            btnRegister.ForeColor = Color.FromArgb(31, 45, 56);
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(16, 436);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(111, 48);
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
            label1.ForeColor = Color.FromArgb(31, 45, 56);
            label1.Location = new Point(9, 127);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 54;
            label1.Text = "Nombre";
            // 
            // txtIndice
            // 
            txtIndice.BackColor = Color.White;
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIndice.ForeColor = Color.FromArgb(31, 45, 56);
            txtIndice.Location = new Point(9, 82);
            txtIndice.Name = "txtIndice";
            txtIndice.ReadOnly = true;
            txtIndice.Size = new Size(93, 23);
            txtIndice.TabIndex = 62;
            txtIndice.Text = "Automatico";
            txtIndice.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(31, 45, 56);
            label14.Location = new Point(175, 49);
            label14.Name = "label14";
            label14.Size = new Size(99, 17);
            label14.TabIndex = 61;
            label14.Text = "Id de categoria";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.White;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(31, 45, 56);
            lblDescripcion.Location = new Point(9, 198);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 17);
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
            txtId.Size = new Size(26, 16);
            txtId.TabIndex = 60;
            txtId.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(31, 45, 56);
            label10.Location = new Point(16, 336);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 57;
            label10.Text = "Estado";
            // 
            // cbEstado
            // 
            cbEstado.BackColor = Color.White;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Century Gothic", 9.75F);
            cbEstado.ForeColor = Color.FromArgb(31, 45, 56);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(16, 357);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 25);
            cbEstado.TabIndex = 58;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(110, 151, 163);
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.ForeColor = Color.FromArgb(31, 45, 56);
            label13.Location = new Point(256, 54);
            label13.Name = "label13";
            label13.Size = new Size(74, 17);
            label13.TabIndex = 45;
            label13.Text = "Buscar por:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(110, 151, 163);
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(31, 45, 56);
            label12.Location = new Point(13, 54);
            label12.Name = "label12";
            label12.Size = new Size(173, 25);
            label12.TabIndex = 43;
            label12.Text = "Lista de Categorias";
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeColumns = false;
            dgvCategory.AllowUserToResizeRows = false;
            dgvCategory.Anchor = AnchorStyles.Top;
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.BorderStyle = BorderStyle.None;
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(110, 151, 163);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 45, 56);
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(75, 105, 106);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 45, 56);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.ColumnHeadersHeight = 29;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdCategory, NameCategory, DescripcionCategory, Estado, EstadoValor });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(31, 45, 56);
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.GridColor = Color.White;
            dgvCategory.Location = new Point(30, 148);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(807, 367);
            dgvCategory.TabIndex = 39;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            dgvCategory.CellFormatting += dgvCategory_CellFormatting;
            dgvCategory.CellPainting += dgvCategory_CellPainting;
            // 
            // panelGradient1
            // 
            panelGradient1.Anchor = AnchorStyles.Top;
            panelGradient1.BackColor = Color.White;
            panelGradient1.ForeColor = Color.Black;
            panelGradient1.GradientBottomColor = Color.FromArgb(110, 151, 163);
            panelGradient1.GradientTopColor = Color.FromArgb(110, 151, 163);
            panelGradient1.Location = new Point(30, 175);
            panelGradient1.Name = "panelGradient1";
            panelGradient1.Size = new Size(806, 354);
            panelGradient1.TabIndex = 50;
            // 
            // panelGradient2
            // 
            panelGradient2.Anchor = AnchorStyles.Top;
            panelGradient2.BackColor = Color.FromArgb(110, 151, 163);
            panelGradient2.Controls.Add(cbSearch);
            panelGradient2.Controls.Add(btnSearch);
            panelGradient2.Controls.Add(txtSearch);
            panelGradient2.ForeColor = Color.Black;
            panelGradient2.GradientBottomColor = Color.FromArgb(110, 151, 163);
            panelGradient2.GradientTopColor = Color.FromArgb(110, 151, 163);
            panelGradient2.Location = new Point(6, 28);
            panelGradient2.Name = "panelGradient2";
            panelGradient2.Size = new Size(831, 75);
            panelGradient2.TabIndex = 53;
            // 
            // cbSearch
            // 
            cbSearch.BackColor = Color.FromArgb(110, 151, 163);
            cbSearch.BorderColor = Color.FromArgb(161, 186, 192);
            cbSearch.BorderSize = 2;
            cbSearch.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FlatStyle = FlatStyle.Flat;
            cbSearch.Font = new Font("Segoe UI", 10F);
            cbSearch.ForeColor = Color.FromArgb(31, 45, 56);
            cbSearch.FormattingEnabled = true;
            cbSearch.IconColor = Color.FromArgb(161, 186, 192);
            cbSearch.ItemHeight = 24;
            cbSearch.ListHighlightColor = Color.FromArgb(161, 186, 192);
            cbSearch.Location = new Point(330, 21);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(160, 30);
            cbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.FromArgb(110, 151, 163);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(715, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(43, 43);
            btnSearch.TabIndex = 47;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(110, 151, 163);
            txtSearch.BorderColor = Color.FromArgb(161, 186, 192);
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Holdertext = "Buscar";
            txtSearch.Location = new Point(497, 21);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(2);
            txtSearch.Size = new Size(216, 30);
            txtSearch.TabIndex = 66;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = dgvCategory;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 5;
            elipseControl2.TargetControl = btnRegister;
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
            IdCategory.HeaderText = "Id";
            IdCategory.MinimumWidth = 6;
            IdCategory.Name = "IdCategory";
            IdCategory.ReadOnly = true;
            IdCategory.Text = "";
            IdCategory.Width = 35;
            // 
            // NameCategory
            // 
            NameCategory.HeaderText = "Nombre";
            NameCategory.MinimumWidth = 6;
            NameCategory.Name = "NameCategory";
            NameCategory.ReadOnly = true;
            NameCategory.Width = 150;
            // 
            // DescripcionCategory
            // 
            DescripcionCategory.HeaderText = "Descripcion";
            DescripcionCategory.MinimumWidth = 6;
            DescripcionCategory.Name = "DescripcionCategory";
            DescripcionCategory.ReadOnly = true;
            DescripcionCategory.Width = 435;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 150;
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
            // FrmCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1194, 631);
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
            panelGradient2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDelete;
        private Button BtnUpdate;
        private Panel panel1;
        private Button btnSearch;
        private DataGridView dgvCategory;
        private Label label12;
        private Label label13;
        private Gradient.PanelGradient panelGradient1;
        private Gradient.PanelGradient panelGradient3;
        private Button btnClear;
        private Label label11;
        private Button btnRegister;
        private Label label1;
        private TextBox txtIndice;
        private Label label14;
        private Label lblDescripcion;
        private TextBox txtId;
        private Label label10;
        private ComboBox cbEstado;
        private Button btnClearSearch;
        private Gradient.PanelGradient panelGradient2;
        private ElipseControlLib.ElipseControl elipseControl1;
        private ElipseControlLib.ElipseControl elipseControl2;
        private WinFormsApp1.ComboBoxUp cbSearch;
        private TextBoxRGB.TextBoxP txtName;
        private TextBoxRGB.TextBoxP txtDescripcion;
        private TextBoxRGB.TextBoxP txtSearch;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewButtonColumn IdCategory;
        private DataGridViewTextBoxColumn NameCategory;
        private DataGridViewTextBoxColumn DescripcionCategory;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
    }
}