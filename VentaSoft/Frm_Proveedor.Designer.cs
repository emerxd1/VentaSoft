namespace Main
{
    partial class Frm_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox1 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtIndice = new TextBox();
            label14 = new Label();
            btnLimpiarTxt = new Button();
            txtId = new TextBox();
            label11 = new Label();
            btnRegister = new Button();
            cbEstado = new ComboBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtName1 = new TextBox();
            btnClearSearch = new Button();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            btnDelete = new Button();
            btnUpdatee = new Button();
            label13 = new Label();
            label12 = new Label();
            txtRUC = new TextBox();
            label1 = new Label();
            dgvUsers = new DataGridView();
            btnSeleccion = new DataGridViewButtonColumn();
            Idproveedor = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NumTelefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Century Gothic", 9.75F);
            textBox1.Location = new Point(93, 412);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ej: \"+50555001205\"";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 33;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(130, 376);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 34;
            label7.Text = "Telefono";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 213, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(194, 1108);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 32;
            button1.Text = "Limpiar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(48, 1108);
            button2.Name = "button2";
            button2.Size = new Size(139, 48);
            button2.TabIndex = 31;
            button2.Text = "Registrar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // txtIndice
            // 
            txtIndice.BackColor = Color.White;
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIndice.ForeColor = Color.Silver;
            txtIndice.Location = new Point(3, 105);
            txtIndice.Name = "txtIndice";
            txtIndice.ReadOnly = true;
            txtIndice.Size = new Size(93, 27);
            txtIndice.TabIndex = 30;
            txtIndice.Text = "Automatico";
            txtIndice.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.Location = new Point(105, 55);
            label14.Name = "label14";
            label14.Size = new Size(124, 23);
            label14.TabIndex = 29;
            label14.Text = "Id de Provedor";
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
            btnLimpiarTxt.Location = new Point(177, 530);
            btnLimpiarTxt.Name = "btnLimpiarTxt";
            btnLimpiarTxt.Size = new Size(147, 48);
            btnLimpiarTxt.TabIndex = 28;
            btnLimpiarTxt.Text = "Limpiar";
            btnLimpiarTxt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarTxt.UseVisualStyleBackColor = false;
            btnLimpiarTxt.Click += btnLimpiarTxt_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Gray;
            txtId.Location = new Point(117, 92);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(93, 20);
            txtId.TabIndex = 26;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Center;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(37, 12);
            label11.Name = "label11";
            label11.Size = new Size(277, 32);
            label11.TabIndex = 25;
            label11.Text = "Detalles de Proveedores";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegister.BackColor = Color.White;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(3, 530);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(139, 48);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Registrar";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbEstado
            // 
            cbEstado.BackColor = Color.FromArgb(192, 255, 255);
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Century Gothic", 9.75F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(95, 495);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 29);
            cbEstado.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(135, 461);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Century Gothic", 9.75F);
            txtEmail.Location = new Point(95, 335);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ej: \"cocacola@gmail.com\"";
            txtEmail.Size = new Size(153, 27);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(130, 288);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            label6.Click += label6_Click;
            // 
            // txtName1
            // 
            txtName1.BackColor = Color.White;
            txtName1.Font = new Font("Century Gothic", 9.75F);
            txtName1.Location = new Point(93, 249);
            txtName1.Name = "txtName1";
            txtName1.PlaceholderText = "Ej: \"Coca Cola\"";
            txtName1.Size = new Size(153, 27);
            txtName1.TabIndex = 2;
            txtName1.TextChanged += txtName1_TextChanged;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.White;
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = (Image)resources.GetObject("btnClearSearch.Image");
            btnClearSearch.Location = new Point(840, 69);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(25, 24);
            btnClearSearch.TabIndex = 59;
            btnClearSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(122, 214);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 3;
            label2.Text = "Razon Social";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(800, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(18, 24);
            btnSearch.TabIndex = 58;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(611, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 27);
            txtSearch.TabIndex = 55;
            // 
            // cbSearch
            // 
            cbSearch.Cursor = Cursors.Hand;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(461, 66);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(125, 28);
            cbSearch.TabIndex = 57;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(37, 575);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 48);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdatee
            // 
            btnUpdatee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdatee.BackColor = Color.White;
            btnUpdatee.Cursor = Cursors.Hand;
            btnUpdatee.FlatAppearance.BorderSize = 0;
            btnUpdatee.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnUpdatee.FlatStyle = FlatStyle.Flat;
            btnUpdatee.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdatee.Image = (Image)resources.GetObject("btnUpdatee.Image");
            btnUpdatee.Location = new Point(233, 575);
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Size = new Size(136, 48);
            btnUpdatee.TabIndex = 51;
            btnUpdatee.Text = "Actualizar";
            btnUpdatee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdatee.UseVisualStyleBackColor = false;
            btnUpdatee.Click += btnRegister_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(360, 66);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 56;
            label13.Text = "Buscar por:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(91, 66);
            label12.Name = "label12";
            label12.Size = new Size(240, 32);
            label12.TabIndex = 54;
            label12.Text = "Lista de Proveedores\r\n";
            // 
            // txtRUC
            // 
            txtRUC.BackColor = Color.White;
            txtRUC.Font = new Font("Century Gothic", 9.75F);
            txtRUC.ForeColor = Color.Black;
            txtRUC.Location = new Point(95, 172);
            txtRUC.Name = "txtRUC";
            txtRUC.PlaceholderText = "Ej: \"008-021194-5592M\"";
            txtRUC.Size = new Size(164, 27);
            txtRUC.TabIndex = 1;
            txtRUC.TextChanged += txtRUC_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(135, 125);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 1;
            label1.Text = "RUC";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsers.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 30;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { btnSeleccion, Idproveedor, RUC, Name1, Email, NumTelefono, EstadoValor, Estado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(41, 97);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvUsers.RowTemplate.Height = 28;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(845, 468);
            dgvUsers.TabIndex = 53;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.CellPainting += dgvUsers_CellPainting;
            // 
            // btnSeleccion
            // 
            btnSeleccion.HeaderText = "";
            btnSeleccion.MinimumWidth = 6;
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.ReadOnly = true;
            btnSeleccion.Resizable = DataGridViewTriState.True;
            btnSeleccion.SortMode = DataGridViewColumnSortMode.Automatic;
            btnSeleccion.Width = 35;
            // 
            // Idproveedor
            // 
            Idproveedor.HeaderText = "Id Proveedor";
            Idproveedor.MinimumWidth = 6;
            Idproveedor.Name = "Idproveedor";
            Idproveedor.ReadOnly = true;
            Idproveedor.Width = 125;
            // 
            // RUC
            // 
            RUC.HeaderText = "RUC";
            RUC.MinimumWidth = 6;
            RUC.Name = "RUC";
            RUC.ReadOnly = true;
            RUC.Width = 120;
            // 
            // Name1
            // 
            Name1.HeaderText = "Razon Social";
            Name1.MinimumWidth = 6;
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            Name1.Width = 120;
            // 
            // Email
            // 
            Email.HeaderText = "Correo";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 170;
            // 
            // NumTelefono
            // 
            NumTelefono.HeaderText = "Telefono";
            NumTelefono.MinimumWidth = 6;
            NumTelefono.Name = "NumTelefono";
            NumTelefono.ReadOnly = true;
            NumTelefono.Width = 125;
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
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtIndice);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btnLimpiarTxt);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtName1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtRUC);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(888, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 619);
            panel1.TabIndex = 50;
            // 
            // Frm_Proveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdatee);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dgvUsers);
            Controls.Add(panel1);
            Name = "Frm_Proveedor";
            Text = "Frm_Proveedor";
            Load += Frm_Proveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label7;
        private Button button1;
        private Button button2;
        private TextBox txtIndice;
        private Label label14;
        private Button btnLimpiarTxt;
        private TextBox txtId;
        private Label label11;
        private Button btnRegister;
        private ComboBox cbEstado;
        private Label label10;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtName1;
        private Button btnClearSearch;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private Button btnDelete;
        private Button btnUpdatee;
        private Label label13;
        private Label label12;
        private TextBox txtRUC;
        private Label label1;
        private DataGridView dgvUsers;
        private Panel panel1;
        private DataGridViewButtonColumn btnSeleccion;
        private DataGridViewTextBoxColumn Idproveedor;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NumTelefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}