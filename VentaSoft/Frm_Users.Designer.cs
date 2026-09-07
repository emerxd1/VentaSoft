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
            panel1 = new Panel();
            btnLimpiarTxt = new Button();
            txtIndice = new TextBox();
            txtId = new TextBox();
            label11 = new Label();
            btnDelete = new Button();
            btnUpdatee = new Button();
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
            txtDni = new TextBox();
            label1 = new Label();
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
            label12 = new Label();
            label13 = new Label();
            cbSearch = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLimpiarTxt);
            panel1.Controls.Add(txtIndice);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdatee);
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
            panel1.Controls.Add(txtDni);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 749);
            panel1.TabIndex = 0;
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
            btnLimpiarTxt.Location = new Point(177, 510);
            btnLimpiarTxt.Name = "btnLimpiarTxt";
            btnLimpiarTxt.Size = new Size(147, 48);
            btnLimpiarTxt.TabIndex = 28;
            btnLimpiarTxt.Text = "Limpiar";
            btnLimpiarTxt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarTxt.UseVisualStyleBackColor = false;
            btnLimpiarTxt.Click += btnLimpiarTxt_Click_1;
            // 
            // txtIndice
            // 
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Location = new Point(247, 52);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(18, 23);
            txtIndice.TabIndex = 27;
            txtIndice.Text = "-1";
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(286, 52);
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 26;
            txtId.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(53, 9);
            label11.Name = "label11";
            label11.Size = new Size(205, 25);
            label11.TabIndex = 25;
            label11.Text = "Detalles de Empleados";
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
            btnDelete.Location = new Point(31, 510);
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
            btnUpdatee.Location = new Point(177, 442);
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Size = new Size(147, 48);
            btnUpdatee.TabIndex = 23;
            btnUpdatee.Text = "Actualizar";
            btnUpdatee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdatee.UseVisualStyleBackColor = false;
            btnUpdatee.Click += btnUpdatee_Click;
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
            btnRegister.Location = new Point(31, 442);
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
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Century Gothic", 9.75F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(197, 379);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 25);
            cbEstado.TabIndex = 21;
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.Font = new Font("Century Gothic", 9.75F);
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(14, 379);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(164, 25);
            cbRol.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(197, 358);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(14, 358);
            label9.Name = "label9";
            label9.Size = new Size(27, 17);
            label9.TabIndex = 17;
            label9.Text = "Rol";
            // 
            // txtCheckPassword
            // 
            txtCheckPassword.Font = new Font("Century Gothic", 9.75F);
            txtCheckPassword.Location = new Point(190, 309);
            txtCheckPassword.Name = "txtCheckPassword";
            txtCheckPassword.PasswordChar = '*';
            txtCheckPassword.Size = new Size(152, 23);
            txtCheckPassword.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(190, 289);
            label8.Name = "label8";
            label8.Size = new Size(141, 17);
            label8.TabIndex = 15;
            label8.Text = "Confirmar Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 9.75F);
            txtPassword.Location = new Point(7, 309);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(5, 289);
            label7.Name = "label7";
            label7.Size = new Size(77, 17);
            label7.TabIndex = 13;
            label7.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 9.75F);
            txtEmail.Location = new Point(190, 246);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(190, 226);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // txtLastName2
            // 
            txtLastName2.Font = new Font("Century Gothic", 9.75F);
            txtLastName2.Location = new Point(7, 246);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.Size = new Size(164, 23);
            txtLastName2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(5, 226);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 9;
            label5.Text = "Segundo Apellido";
            // 
            // txtLastName1
            // 
            txtLastName1.Font = new Font("Century Gothic", 9.75F);
            txtLastName1.Location = new Point(190, 179);
            txtLastName1.Name = "txtLastName1";
            txtLastName1.Size = new Size(152, 23);
            txtLastName1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(190, 156);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 7;
            label4.Text = "Primer Apellido";
            // 
            // txtName2
            // 
            txtName2.Font = new Font("Century Gothic", 9.75F);
            txtName2.Location = new Point(7, 179);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(164, 23);
            txtName2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(7, 156);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 5;
            label3.Text = "Segundo Nombre";
            // 
            // txtName1
            // 
            txtName1.Font = new Font("Century Gothic", 9.75F);
            txtName1.Location = new Point(190, 109);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(152, 23);
            txtName1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(190, 89);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 3;
            label2.Text = "Primer Nombre";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Century Gothic", 9.75F);
            txtDni.ForeColor = Color.Black;
            txtDni.Location = new Point(7, 109);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(164, 23);
            txtDni.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(7, 91);
            label1.Name = "label1";
            label1.Size = new Size(31, 17);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeight = 45;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { btnSeleccion, IdUsuario, DNI, Name1, Name2, LastName1, LastName2, Email, Password, Id_Rol, Rol, EstadoValor, Estado });
            dgvUsers.GridColor = Color.White;
            dgvUsers.Location = new Point(383, 209);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvUsers.RowTemplate.Height = 28;
            dgvUsers.Size = new Size(784, 484);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick_1;
            dgvUsers.CellPainting += dgvUsers_CellPainting;
            // 
            // btnSeleccion
            // 
            btnSeleccion.HeaderText = "";
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.ReadOnly = true;
            btnSeleccion.Resizable = DataGridViewTriState.True;
            btnSeleccion.SortMode = DataGridViewColumnSortMode.Automatic;
            btnSeleccion.Width = 35;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.Width = 150;
            // 
            // Name1
            // 
            Name1.HeaderText = "Primer Nombre";
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            // 
            // Name2
            // 
            Name2.HeaderText = "Segundo Nombre";
            Name2.Name = "Name2";
            Name2.ReadOnly = true;
            Name2.Visible = false;
            // 
            // LastName1
            // 
            LastName1.HeaderText = "Primer Apellido";
            LastName1.Name = "LastName1";
            LastName1.ReadOnly = true;
            // 
            // LastName2
            // 
            LastName2.HeaderText = "Segundo Apellido";
            LastName2.Name = "LastName2";
            LastName2.ReadOnly = true;
            LastName2.Visible = false;
            // 
            // Email
            // 
            Email.HeaderText = "Correo";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 150;
            // 
            // Password
            // 
            Password.HeaderText = "Contraseña";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            // 
            // Id_Rol
            // 
            Id_Rol.HeaderText = "IdRol";
            Id_Rol.Name = "Id_Rol";
            Id_Rol.ReadOnly = true;
            Id_Rol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(380, 78);
            label12.Name = "label12";
            label12.Size = new Size(175, 25);
            label12.TabIndex = 26;
            label12.Text = "Lista de Empleados";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(637, 84);
            label13.Name = "label13";
            label13.Size = new Size(74, 17);
            label13.TabIndex = 27;
            label13.Text = "Buscar por:";
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(718, 84);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(143, 25);
            cbSearch.TabIndex = 28;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(869, 85);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 23);
            txtSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 128);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(1078, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(43, 43);
            btnSearch.TabIndex = 29;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DodgerBlue;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.Location = new Point(1136, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(43, 43);
            btnClear.TabIndex = 30;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Frm_Users
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1205, 611);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(cbSearch);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dgvUsers);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Frm_Users";
            Text = "Frm_Users";
            Load += Frm_Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtDni;
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
        private DataGridView dgvUsers;
        private Label label12;
        private TextBox txtId;
        private Label label13;
        private ComboBox cbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClear;
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
        private TextBox txtIndice;
        private Button btnLimpiarTxt;
    }
}