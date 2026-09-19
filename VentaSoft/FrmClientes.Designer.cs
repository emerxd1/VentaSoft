namespace Main
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
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
            txtLastName2 = new TextBox();
            label5 = new Label();
            txtLastName1 = new TextBox();
            label4 = new Label();
            txtName2 = new TextBox();
            label3 = new Label();
            txtName1 = new TextBox();
            label2 = new Label();
            txtDni = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            btnDelete = new Button();
            btnUpdatee = new Button();
            label13 = new Label();
            label12 = new Label();
            dgvUsers = new DataGridView();
            btnClearSearch = new Button();
            btnSeleccion = new DataGridViewButtonColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            LastName1 = new DataGridViewTextBoxColumn();
            LastName2 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NumTelefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
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
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtLastName2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtLastName1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtName2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtName1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(893, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 562);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Century Gothic", 9.75F);
            textBox1.Location = new Point(3, 308);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ej: \"+50555001205\"";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(3, 293);
            label7.Name = "label7";
            label7.Size = new Size(59, 17);
            label7.TabIndex = 34;
            label7.Text = "Telefono";
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
            button1.Location = new Point(170, 443);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(129, 36);
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
            button2.Location = new Point(42, 443);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(122, 36);
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
            txtIndice.Location = new Point(3, 79);
            txtIndice.Margin = new Padding(3, 2, 3, 2);
            txtIndice.Name = "txtIndice";
            txtIndice.ReadOnly = true;
            txtIndice.Size = new Size(82, 23);
            txtIndice.TabIndex = 30;
            txtIndice.Text = "Automatico";
            txtIndice.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.Location = new Point(150, 64);
            label14.Name = "label14";
            label14.Size = new Size(84, 17);
            label14.TabIndex = 29;
            label14.Text = "Id de Cliente";
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
            btnLimpiarTxt.Location = new Point(155, 985);
            btnLimpiarTxt.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarTxt.Name = "btnLimpiarTxt";
            btnLimpiarTxt.Size = new Size(129, 36);
            btnLimpiarTxt.TabIndex = 28;
            btnLimpiarTxt.Text = "Limpiar";
            btnLimpiarTxt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarTxt.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Gray;
            txtId.Location = new Point(220, 64);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(81, 16);
            txtId.TabIndex = 26;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(55, 31);
            label11.Name = "label11";
            label11.Size = new Size(180, 25);
            label11.TabIndex = 25;
            label11.Text = "Detalles de Clientes";
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
            btnRegister.Location = new Point(27, 985);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 36);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Registrar";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            cbEstado.BackColor = Color.FromArgb(192, 255, 255);
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Century Gothic", 9.75F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(32, 376);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(133, 25);
            cbEstado.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(32, 361);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Century Gothic", 9.75F);
            txtEmail.Location = new Point(163, 250);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ej: \"juanmora1@gmail.com\"";
            txtEmail.Size = new Size(134, 23);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(163, 236);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // txtLastName2
            // 
            txtLastName2.BackColor = Color.White;
            txtLastName2.Font = new Font("Century Gothic", 9.75F);
            txtLastName2.Location = new Point(3, 254);
            txtLastName2.Margin = new Padding(3, 2, 3, 2);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.PlaceholderText = "Ej: \"Garcia\"";
            txtLastName2.Size = new Size(144, 23);
            txtLastName2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(1, 236);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 9;
            label5.Text = "Segundo Apellido";
            // 
            // txtLastName1
            // 
            txtLastName1.BackColor = Color.White;
            txtLastName1.Font = new Font("Century Gothic", 9.75F);
            txtLastName1.Location = new Point(163, 194);
            txtLastName1.Margin = new Padding(3, 2, 3, 2);
            txtLastName1.Name = "txtLastName1";
            txtLastName1.PlaceholderText = "Ej: \"Mora\"";
            txtLastName1.Size = new Size(134, 23);
            txtLastName1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(163, 176);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 7;
            label4.Text = "Primer Apellido";
            // 
            // txtName2
            // 
            txtName2.BackColor = Color.White;
            txtName2.Font = new Font("Century Gothic", 9.75F);
            txtName2.Location = new Point(3, 194);
            txtName2.Margin = new Padding(3, 2, 3, 2);
            txtName2.Name = "txtName2";
            txtName2.PlaceholderText = "Ej: \"Alberto\"";
            txtName2.Size = new Size(144, 23);
            txtName2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(3, 176);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 5;
            label3.Text = "Segundo Nombre";
            // 
            // txtName1
            // 
            txtName1.BackColor = Color.White;
            txtName1.Font = new Font("Century Gothic", 9.75F);
            txtName1.Location = new Point(163, 131);
            txtName1.Margin = new Padding(3, 2, 3, 2);
            txtName1.Name = "txtName1";
            txtName1.PlaceholderText = "Ej: \"Juan\"";
            txtName1.Size = new Size(134, 23);
            txtName1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(163, 116);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 3;
            label2.Text = "Primer Nombre";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.Font = new Font("Century Gothic", 9.75F);
            txtDni.ForeColor = Color.Black;
            txtDni.Location = new Point(3, 131);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ej: \"008-021194-5592M\"";
            txtDni.Size = new Size(144, 23);
            txtDni.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(18, 112);
            label1.Name = "label1";
            label1.Size = new Size(31, 17);
            label1.TabIndex = 1;
            label1.Text = "DNI";
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
            btnSearch.Location = new Point(763, 49);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(21, 18);
            btnSearch.TabIndex = 47;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(591, 49);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(157, 23);
            txtSearch.TabIndex = 44;
            // 
            // cbSearch
            // 
            cbSearch.Cursor = Cursors.Hand;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(459, 48);
            cbSearch.Margin = new Padding(3, 2, 3, 2);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(126, 23);
            cbSearch.TabIndex = 46;
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
            btnDelete.Location = new Point(46, 519);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 36);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
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
            btnUpdatee.Location = new Point(186, 519);
            btnUpdatee.Margin = new Padding(3, 2, 3, 2);
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Size = new Size(129, 36);
            btnUpdatee.TabIndex = 40;
            btnUpdatee.Text = "Actualizar";
            btnUpdatee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdatee.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(371, 48);
            label13.Name = "label13";
            label13.Size = new Size(74, 17);
            label13.TabIndex = 45;
            label13.Text = "Buscar por:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(136, 43);
            label12.Name = "label12";
            label12.Size = new Size(150, 25);
            label12.TabIndex = 43;
            label12.Text = "Lista de Clientes";
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvUsers.ColumnHeadersHeight = 30;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { btnSeleccion, IdCliente, DNI, Name1, Name2, LastName1, LastName2, Email, NumTelefono, EstadoValor, Estado });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle8;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(46, 111);
            dgvUsers.Margin = new Padding(3, 2, 3, 2);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvUsers.RowTemplate.Height = 28;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(818, 404);
            dgvUsers.TabIndex = 42;
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
            btnClearSearch.Location = new Point(804, 50);
            btnClearSearch.Margin = new Padding(3, 2, 3, 2);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(21, 18);
            btnClearSearch.TabIndex = 49;
            btnClearSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearSearch.UseVisualStyleBackColor = false;
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
            // IdCliente
            // 
            IdCliente.HeaderText = "IdCliente";
            IdCliente.MinimumWidth = 6;
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            IdCliente.Visible = false;
            IdCliente.Width = 125;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.Width = 120;
            // 
            // Name1
            // 
            Name1.HeaderText = "Primer Nombre";
            Name1.MinimumWidth = 6;
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            Name1.Width = 120;
            // 
            // Name2
            // 
            Name2.HeaderText = "Segundo Nombre";
            Name2.MinimumWidth = 6;
            Name2.Name = "Name2";
            Name2.ReadOnly = true;
            Name2.Visible = false;
            Name2.Width = 150;
            // 
            // LastName1
            // 
            LastName1.HeaderText = "Primer Apellido";
            LastName1.MinimumWidth = 6;
            LastName1.Name = "LastName1";
            LastName1.ReadOnly = true;
            LastName1.Width = 120;
            // 
            // LastName2
            // 
            LastName2.HeaderText = "Segundo Apellido";
            LastName2.MinimumWidth = 6;
            LastName2.Name = "LastName2";
            LastName2.ReadOnly = true;
            LastName2.Visible = false;
            LastName2.Width = 150;
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
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmClientes";
            Text = "FrmClientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
        private TextBox txtLastName2;
        private Label label5;
        private TextBox txtLastName1;
        private Label label4;
        private TextBox txtName2;
        private Label label3;
        private TextBox txtName1;
        private Label label2;
        private TextBox txtDni;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private Button btnDelete;
        private Button btnUpdatee;
        private Label label13;
        private Label label12;
        private DataGridView dgvUsers;
        private Button btnClearSearch;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label7;
        private DataGridViewButtonColumn btnSeleccion;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn LastName1;
        private DataGridViewTextBoxColumn LastName2;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NumTelefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}