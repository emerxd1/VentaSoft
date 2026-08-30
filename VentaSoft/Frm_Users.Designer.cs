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
            IdUsuario = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            LastName1 = new DataGridViewTextBoxColumn();
            LastName2 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 9.75F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 561);
            panel1.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(250, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(29, 25);
            txtId.TabIndex = 26;
            txtId.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(52, 20);
            label11.Name = "label11";
            label11.Size = new Size(205, 25);
            label11.TabIndex = 25;
            label11.Text = "Detalles de Empleados";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(27, 486);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(252, 42);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdatee
            // 
            btnUpdatee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdatee.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdatee.Cursor = Cursors.Hand;
            btnUpdatee.FlatAppearance.BorderSize = 0;
            btnUpdatee.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnUpdatee.FlatStyle = FlatStyle.Flat;
            btnUpdatee.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdatee.Image = (Image)resources.GetObject("btnUpdatee.Image");
            btnUpdatee.Location = new Point(27, 438);
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Size = new Size(252, 42);
            btnUpdatee.TabIndex = 23;
            btnUpdatee.Text = "Actualizar";
            btnUpdatee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdatee.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRegister.BackColor = Color.FromArgb(192, 255, 192);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(27, 390);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(252, 42);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Registrar";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(172, 334);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(133, 25);
            cbEstado.TabIndex = 21;
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(12, 334);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(144, 25);
            cbRol.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.Location = new Point(172, 316);
            label10.Name = "label10";
            label10.Size = new Size(48, 17);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(12, 316);
            label9.Name = "label9";
            label9.Size = new Size(27, 17);
            label9.TabIndex = 17;
            label9.Text = "Rol";
            // 
            // txtCheckPassword
            // 
            txtCheckPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCheckPassword.Location = new Point(166, 273);
            txtCheckPassword.Name = "txtCheckPassword";
            txtCheckPassword.Size = new Size(133, 25);
            txtCheckPassword.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(166, 255);
            label8.Name = "label8";
            label8.Size = new Size(139, 17);
            label8.TabIndex = 15;
            label8.Text = "Confirmar Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(6, 273);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(144, 25);
            txtPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(6, 255);
            label7.Name = "label7";
            label7.Size = new Size(77, 17);
            label7.TabIndex = 13;
            label7.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(166, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 25);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(166, 199);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 11;
            label6.Text = "Correo:";
            // 
            // txtLastName2
            // 
            txtLastName2.BorderStyle = BorderStyle.FixedSingle;
            txtLastName2.Location = new Point(6, 217);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.Size = new Size(144, 25);
            txtLastName2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(6, 199);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 9;
            label5.Text = "Segundo Apellido:";
            // 
            // txtLastName1
            // 
            txtLastName1.BorderStyle = BorderStyle.FixedSingle;
            txtLastName1.Location = new Point(166, 158);
            txtLastName1.Name = "txtLastName1";
            txtLastName1.Size = new Size(133, 25);
            txtLastName1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(172, 138);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 7;
            label4.Text = "Primer Apellido:";
            // 
            // txtName2
            // 
            txtName2.BorderStyle = BorderStyle.FixedSingle;
            txtName2.Location = new Point(6, 158);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(144, 25);
            txtName2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 5;
            label3.Text = "Segundo Nombre:";
            // 
            // txtName1
            // 
            txtName1.BorderStyle = BorderStyle.FixedSingle;
            txtName1.Location = new Point(166, 96);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(133, 25);
            txtName1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(172, 74);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 3;
            label2.Text = "Primer Nombre:";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Location = new Point(6, 96);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(144, 25);
            txtDni.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, Name1, Name2, LastName1, LastName2, Email, Password, Rol, Estado });
            dgvUsers.GridColor = Color.White;
            dgvUsers.Location = new Point(320, 148);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvUsers.RowTemplate.Height = 28;
            dgvUsers.Size = new Size(743, 150);
            dgvUsers.TabIndex = 1;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
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
            // 
            // Email
            // 
            Email.HeaderText = "Correo";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Contraseña";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(334, 93);
            label12.Name = "label12";
            label12.Size = new Size(714, 25);
            label12.TabIndex = 26;
            label12.Text = "Lista de Empleados";
            // 
            // Frm_Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 561);
            Controls.Add(label12);
            Controls.Add(dgvUsers);
            Controls.Add(panel1);
            Name = "Frm_Users";
            Text = "Frm_Users";
            Load += Frm_Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Name2;
        private DataGridViewTextBoxColumn LastName1;
        private DataGridViewTextBoxColumn LastName2;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
    }
}