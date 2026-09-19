namespace Main
{
    partial class Frm_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Users));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtDni = new TextBox();
            txtIndice = new TextBox();
            label14 = new Label();
            btnLimpiarTxt = new Button();
            txtId = new TextBox();
            label11 = new Label();
            btnRegister = new Button();
            cbEstado = new ComboBox();
            cbRol = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtCheckPassword = new TextBox();
            label8 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
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
            label1 = new Label();
            btnDelete = new Button();
            btnUpdatee = new Button();
            panel2 = new Panel();
            btnDetails = new Button();
            dgvUsers = new DataGridView();
            btnSeleccion = new DataGridViewButtonColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            LastName1 = new DataGridViewTextBoxColumn();
            LastName2 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Id_Rol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panelGradient2 = new Gradient.PanelGradient();
            label12 = new Label();
            cbSearch = new ComboBox();
            txtSearch = new TextBox();
            btnClearSearch = new Button();
            label13 = new Label();
            btnSearch = new Button();
            panelGradient1 = new Gradient.PanelGradient();
            elipseControl1 = new ElipseControl.ElipseControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panelGradient2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(txtIndice);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(btnLimpiarTxt);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(cbEstado);
            panel1.Controls.Add(cbRol);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtCheckPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label7);
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
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(874, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 749);
            panel1.TabIndex = 0;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.White;
            txtDni.Font = new Font("Century Gothic", 9.75F);
            txtDni.Location = new Point(7, 130);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ej: \"001-150212-22010J\"";
            txtDni.Size = new Size(164, 27);
            txtDni.TabIndex = 31;
            // 
            // txtIndice
            // 
            txtIndice.BackColor = Color.White;
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIndice.ForeColor = Color.Silver;
            txtIndice.Location = new Point(7, 67);
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
            label14.Location = new Point(182, 47);
            label14.Name = "label14";
            label14.Size = new Size(110, 23);
            label14.TabIndex = 29;
            label14.Text = "Id de usuario";
            label14.Click += label14_Click;
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
            btnLimpiarTxt.Location = new Point(182, 519);
            btnLimpiarTxt.Name = "btnLimpiarTxt";
            btnLimpiarTxt.Size = new Size(147, 48);
            btnLimpiarTxt.TabIndex = 28;
            btnLimpiarTxt.Text = "Limpiar";
            btnLimpiarTxt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarTxt.UseVisualStyleBackColor = false;
            btnLimpiarTxt.Click += btnLimpiarTxt_Click_1;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Gray;
            txtId.Location = new Point(247, 47);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(93, 20);
            txtId.TabIndex = 26;
            txtId.Text = "0";
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(67, 3);
            label11.Name = "label11";
            label11.Size = new Size(259, 32);
            label11.TabIndex = 25;
            label11.Text = "Detalles de Empleados";
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
            btnRegister.Location = new Point(36, 519);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 48);
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
            cbEstado.Location = new Point(197, 400);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 29);
            cbEstado.TabIndex = 21;
            // 
            // cbRol
            // 
            cbRol.BackColor = Color.FromArgb(192, 255, 255);
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.Font = new Font("Century Gothic", 9.75F);
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(14, 400);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(164, 29);
            cbRol.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(197, 379);
            label10.Name = "label10";
            label10.Size = new Size(61, 23);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(14, 379);
            label9.Name = "label9";
            label9.Size = new Size(35, 23);
            label9.TabIndex = 17;
            label9.Text = "Rol";
            // 
            // txtCheckPassword
            // 
            txtCheckPassword.BackColor = Color.White;
            txtCheckPassword.Font = new Font("Century Gothic", 9.75F);
            txtCheckPassword.Location = new Point(190, 330);
            txtCheckPassword.Name = "txtCheckPassword";
            txtCheckPassword.PasswordChar = '*';
            txtCheckPassword.PlaceholderText = "123";
            txtCheckPassword.Size = new Size(152, 27);
            txtCheckPassword.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(190, 310);
            label8.Name = "label8";
            label8.Size = new Size(179, 23);
            label8.TabIndex = 15;
            label8.Text = "Confirmar Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Century Gothic", 9.75F);
            txtPassword.Location = new Point(7, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "123";
            txtPassword.Size = new Size(164, 27);
            txtPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(5, 310);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 13;
            label7.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Century Gothic", 9.75F);
            txtEmail.Location = new Point(190, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ej: \"juanmora1@gmail.com\"";
            txtEmail.Size = new Size(152, 27);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(190, 247);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // txtLastName2
            // 
            txtLastName2.BackColor = Color.White;
            txtLastName2.Font = new Font("Century Gothic", 9.75F);
            txtLastName2.Location = new Point(7, 267);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.PlaceholderText = "Ej: \"Garcia\"";
            txtLastName2.Size = new Size(164, 27);
            txtLastName2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(5, 247);
            label5.Name = "label5";
            label5.Size = new Size(145, 23);
            label5.TabIndex = 9;
            label5.Text = "Segundo Apellido";
            // 
            // txtLastName1
            // 
            txtLastName1.BackColor = Color.White;
            txtLastName1.Font = new Font("Century Gothic", 9.75F);
            txtLastName1.Location = new Point(190, 200);
            txtLastName1.Name = "txtLastName1";
            txtLastName1.PlaceholderText = "Ej: \"Mora\"";
            txtLastName1.Size = new Size(152, 27);
            txtLastName1.TabIndex = 6;
            txtLastName1.TextChanged += txtLastName1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(190, 177);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 7;
            label4.Text = "Primer Apellido";
            // 
            // txtName2
            // 
            txtName2.BackColor = Color.White;
            txtName2.Font = new Font("Century Gothic", 9.75F);
            txtName2.Location = new Point(7, 200);
            txtName2.Name = "txtName2";
            txtName2.PlaceholderText = "Ej: \"Alberto\"";
            txtName2.Size = new Size(164, 27);
            txtName2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(7, 177);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 5;
            label3.Text = "Segundo Nombre";
            // 
            // txtName1
            // 
            txtName1.BackColor = Color.White;
            txtName1.Font = new Font("Century Gothic", 9.75F);
            txtName1.Location = new Point(190, 130);
            txtName1.Name = "txtName1";
            txtName1.PlaceholderText = "Ej: \"Juan\"";
            txtName1.Size = new Size(152, 27);
            txtName1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(190, 110);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 3;
            label2.Text = "Primer Nombre";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(7, 112);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 1;
            label1.Text = "DNI";
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
            btnDelete.Location = new Point(47, 601);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 48);
            btnDelete.TabIndex = 24;
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
            btnUpdatee.Location = new Point(203, 601);
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Size = new Size(147, 48);
            btnUpdatee.TabIndex = 23;
            btnUpdatee.Text = "Actualizar";
            btnUpdatee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdatee.UseVisualStyleBackColor = false;
            btnUpdatee.Click += btnUpdatee_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDetails);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdatee);
            panel2.Controls.Add(dgvUsers);
            panel2.Controls.Add(panelGradient2);
            panel2.Controls.Add(panelGradient1);
            panel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(874, 749);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnDetails
            // 
            btnDetails.Anchor = AnchorStyles.Top;
            btnDetails.BackColor = Color.White;
            btnDetails.Cursor = Cursors.Hand;
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDetails.Image = (Image)resources.GetObject("btnDetails.Image");
            btnDetails.Location = new Point(629, -6);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(242, 38);
            btnDetails.TabIndex = 39;
            btnDetails.Text = "Detalles de Empleados";
            btnDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Visible = false;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = AnchorStyles.Top;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvUsers.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 30;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { btnSeleccion, IdUsuario, DNI, Name1, Name2, LastName1, LastName2, Email, Password, Id_Rol, Rol, EstadoValor, Estado });
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
            dgvUsers.Location = new Point(31, 158);
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
            dgvUsers.Size = new Size(809, 387);
            dgvUsers.TabIndex = 32;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            dgvUsers.CellFormatting += dgvUsers_CellFormatting;
            dgvUsers.CellPainting += dgvUsers_CellPainting_1;
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
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            IdUsuario.Width = 125;
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
            // Password
            // 
            Password.HeaderText = "Contraseña";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            Password.Width = 125;
            // 
            // Id_Rol
            // 
            Id_Rol.HeaderText = "IdRol";
            Id_Rol.MinimumWidth = 6;
            Id_Rol.Name = "Id_Rol";
            Id_Rol.ReadOnly = true;
            Id_Rol.Visible = false;
            Id_Rol.Width = 125;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 120;
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
            // panelGradient2
            // 
            panelGradient2.Anchor = AnchorStyles.Top;
            panelGradient2.BackColor = Color.FromArgb(0, 192, 192);
            panelGradient2.Controls.Add(label12);
            panelGradient2.Controls.Add(cbSearch);
            panelGradient2.Controls.Add(txtSearch);
            panelGradient2.Controls.Add(btnClearSearch);
            panelGradient2.Controls.Add(label13);
            panelGradient2.Controls.Add(btnSearch);
            panelGradient2.ForeColor = Color.Black;
            panelGradient2.GradientBottomColor = Color.FromArgb(192, 255, 255);
            panelGradient2.GradientTopColor = Color.FromArgb(0, 192, 192);
            panelGradient2.Location = new Point(14, 38);
            panelGradient2.Name = "panelGradient2";
            panelGradient2.Size = new Size(853, 75);
            panelGradient2.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 18);
            label12.Name = "label12";
            label12.Size = new Size(222, 32);
            label12.TabIndex = 33;
            label12.Text = "Lista de Empleados";
            // 
            // cbSearch
            // 
            cbSearch.Anchor = AnchorStyles.Top;
            cbSearch.BackColor = Color.PaleTurquoise;
            cbSearch.Cursor = Cursors.Hand;
            cbSearch.FlatStyle = FlatStyle.Flat;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(417, 24);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(143, 29);
            cbSearch.TabIndex = 36;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.BackColor = Color.PaleTurquoise;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(566, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 29);
            txtSearch.TabIndex = 34;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Transparent;
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = (Image)resources.GetObject("btnClearSearch.Image");
            btnClearSearch.Location = new Point(807, 25);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(32, 32);
            btnClearSearch.TabIndex = 38;
            btnClearSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(316, 24);
            label13.Name = "label13";
            label13.Size = new Size(95, 23);
            label13.TabIndex = 35;
            label13.Text = "Buscar por:";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(761, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(32, 32);
            btnSearch.TabIndex = 37;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panelGradient1
            // 
            panelGradient1.Anchor = AnchorStyles.Top;
            panelGradient1.BackColor = Color.White;
            panelGradient1.ForeColor = Color.Black;
            panelGradient1.GradientBottomColor = Color.FromArgb(0, 192, 192);
            panelGradient1.GradientTopColor = Color.FromArgb(0, 192, 192);
            panelGradient1.Location = new Point(31, 141);
            panelGradient1.Name = "panelGradient1";
            panelGradient1.Size = new Size(809, 426);
            panelGradient1.TabIndex = 55;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 35;
            elipseControl1.TargetControl = dgvUsers;
            // 
            // Frm_Users
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1227, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Frm_Users";
            Text = "Frm_Category";
            Load += Frm_Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panelGradient2.ResumeLayout(false);
            panelGradient2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtName1;
        private Label label2;
        private TextBox txtLastName2;
        private Label label5;
        private TextBox txtLastName1;
        private Label label4;
        private TextBox txtName2;
        private Label label3;
        private Label label9;
        private TextBox txtCheckPassword;
        private Label label8;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private Label label10;
        private ComboBox cbEstado;
        private ComboBox cbRol;
        private Button btnDelete;
        private Button btnUpdatee;
        private Button btnRegister;
        private Label label11;
        private TextBox txtId;
        private Button btnLimpiarTxt;
        private Label label14;
        private TextBox txtIndice;
        private Panel panel2;
        private DataGridView dgvUsers;
        private Button btnDetails;
        private DataGridViewButtonColumn btnSeleccion;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn LastName1;
        private DataGridViewTextBoxColumn LastName2;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Id_Rol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private Gradient.PanelGradient panelGradient2;
        private Label label12;
        private ComboBox cbSearch;
        private TextBox txtSearch;
        private Button btnClearSearch;
        private Label label13;
        private Button btnSearch;
        private Gradient.PanelGradient panelGradient1;
        private ElipseControl.ElipseControl elipseControl1;
        private TextBox txtDni;
    }
}