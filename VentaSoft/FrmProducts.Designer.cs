namespace Main
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            button8 = new Button();
            button11 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            txtIndice = new TextBox();
            label14 = new Label();
            btnLimpiarTxt = new Button();
            txtId = new TextBox();
            label11 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            button9 = new Button();
            button10 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            btnDetails = new Button();
            btnClearSearch = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            dgvProducto = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(828, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 620);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(txtIndice);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(btnLimpiarTxt);
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(cbEstado);
            panel4.Controls.Add(cbRol);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtCheckPassword);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtLastName2);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtLastName1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtName2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtName1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtDni);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Right;
            panel4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(1, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 618);
            panel4.TabIndex = 8;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button8.BackColor = Color.White;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 213, 255);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(185, 473);
            button8.Name = "button8";
            button8.Size = new Size(105, 40);
            button8.TabIndex = 38;
            button8.Text = "Limpiar";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.BackColor = Color.White;
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.Location = new Point(34, 473);
            button11.Name = "button11";
            button11.Size = new Size(105, 40);
            button11.TabIndex = 35;
            button11.Text = "Registrar";
            button11.TextImageRelation = TextImageRelation.ImageBeforeText;
            button11.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(144, 213, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(177, 1036);
            button4.Name = "button4";
            button4.Size = new Size(147, 48);
            button4.TabIndex = 34;
            button4.Text = "Limpiar";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.BackColor = Color.White;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ControlText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(31, 1036);
            button5.Name = "button5";
            button5.Size = new Size(140, 48);
            button5.TabIndex = 33;
            button5.Text = "Eliminar";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.White;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(177, 968);
            button6.Name = "button6";
            button6.Size = new Size(147, 48);
            button6.TabIndex = 32;
            button6.Text = "Actualizar";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button7.BackColor = Color.White;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(31, 968);
            button7.Name = "button7";
            button7.Size = new Size(140, 48);
            button7.TabIndex = 31;
            button7.Text = "Registrar";
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
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
            txtIndice.Size = new Size(93, 23);
            txtIndice.TabIndex = 30;
            txtIndice.Text = "Automatico";
            txtIndice.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.Location = new Point(244, 47);
            label14.Name = "label14";
            label14.Size = new Size(88, 17);
            label14.TabIndex = 29;
            label14.Text = "Id de usuario";
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
            btnLimpiarTxt.Location = new Point(177, 1545);
            btnLimpiarTxt.Name = "btnLimpiarTxt";
            btnLimpiarTxt.Size = new Size(147, 48);
            btnLimpiarTxt.TabIndex = 28;
            btnLimpiarTxt.Text = "Limpiar";
            btnLimpiarTxt.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarTxt.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.Silver;
            txtId.Location = new Point(244, 67);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(93, 23);
            txtId.TabIndex = 26;
            txtId.Text = "Automatico";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(60, 14);
            label11.Name = "label11";
            label11.Size = new Size(198, 25);
            label11.TabIndex = 25;
            label11.Text = "Detalles de Productos";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(31, 1545);
            button1.Name = "button1";
            button1.Size = new Size(140, 48);
            button1.TabIndex = 24;
            button1.Text = "Eliminar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(177, 1477);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 23;
            button2.Text = "Actualizar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(31, 1477);
            button3.Name = "button3";
            button3.Size = new Size(140, 48);
            button3.TabIndex = 22;
            button3.Text = "Registrar";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.Font = new Font("Century Gothic", 9.75F);
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(197, 400);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 25);
            cbEstado.TabIndex = 21;
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.Font = new Font("Century Gothic", 9.75F);
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(14, 400);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(164, 25);
            cbRol.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label10.Location = new Point(197, 379);
            label10.Name = "label10";
            label10.Size = new Size(49, 17);
            label10.TabIndex = 19;
            label10.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label9.Location = new Point(14, 379);
            label9.Name = "label9";
            label9.Size = new Size(27, 17);
            label9.TabIndex = 17;
            label9.Text = "Rol";
            // 
            // txtCheckPassword
            // 
            txtCheckPassword.Font = new Font("Century Gothic", 9.75F);
            txtCheckPassword.Location = new Point(190, 330);
            txtCheckPassword.Name = "txtCheckPassword";
            txtCheckPassword.PasswordChar = '*';
            txtCheckPassword.Size = new Size(152, 23);
            txtCheckPassword.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label8.Location = new Point(190, 310);
            label8.Name = "label8";
            label8.Size = new Size(141, 17);
            label8.TabIndex = 15;
            label8.Text = "Confirmar Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 9.75F);
            txtPassword.Location = new Point(7, 330);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(5, 310);
            label7.Name = "label7";
            label7.Size = new Size(77, 17);
            label7.TabIndex = 13;
            label7.Text = "Contraseña";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Century Gothic", 9.75F);
            txtEmail.Location = new Point(190, 267);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(190, 247);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // txtLastName2
            // 
            txtLastName2.Font = new Font("Century Gothic", 9.75F);
            txtLastName2.Location = new Point(7, 267);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.Size = new Size(164, 23);
            txtLastName2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(5, 247);
            label5.Name = "label5";
            label5.Size = new Size(115, 17);
            label5.TabIndex = 9;
            label5.Text = "Segundo Apellido";
            // 
            // txtLastName1
            // 
            txtLastName1.Font = new Font("Century Gothic", 9.75F);
            txtLastName1.Location = new Point(190, 200);
            txtLastName1.Name = "txtLastName1";
            txtLastName1.Size = new Size(152, 23);
            txtLastName1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(190, 177);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 7;
            label4.Text = "Primer Apellido";
            // 
            // txtName2
            // 
            txtName2.Font = new Font("Century Gothic", 9.75F);
            txtName2.Location = new Point(7, 200);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(164, 23);
            txtName2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(7, 177);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 5;
            label3.Text = "Segundo Nombre";
            // 
            // txtName1
            // 
            txtName1.Font = new Font("Century Gothic", 9.75F);
            txtName1.Location = new Point(190, 130);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(152, 23);
            txtName1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(190, 110);
            label2.Name = "label2";
            label2.Size = new Size(102, 17);
            label2.TabIndex = 3;
            label2.Text = "Primer Nombre";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Century Gothic", 9.75F);
            txtDni.ForeColor = Color.Black;
            txtDni.Location = new Point(7, 130);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(164, 23);
            txtDni.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(7, 112);
            label1.Name = "label1";
            label1.Size = new Size(31, 17);
            label1.TabIndex = 1;
            label1.Text = "DNI";
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button9.BackColor = Color.White;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button9.ForeColor = SystemColors.ControlText;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(676, 281);
            button9.Name = "button9";
            button9.Size = new Size(115, 40);
            button9.TabIndex = 37;
            button9.Text = "Eliminar";
            button9.TextImageRelation = TextImageRelation.ImageBeforeText;
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button10.BackColor = Color.White;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(676, 218);
            button10.Name = "button10";
            button10.Size = new Size(115, 40);
            button10.TabIndex = 36;
            button10.Text = "Actualizar";
            button10.TextImageRelation = TextImageRelation.ImageBeforeText;
            button10.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 620);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDetails);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(btnClearSearch);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(cbSearch);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(dgvProducto);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 620);
            panel3.TabIndex = 9;
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
            btnDetails.Location = new Point(580, 4);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(242, 38);
            btnDetails.TabIndex = 49;
            btnDetails.Text = "Detalles de Empleados";
            btnDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Visible = false;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.White;
            btnClearSearch.Cursor = Cursors.Hand;
            btnClearSearch.FlatAppearance.BorderSize = 0;
            btnClearSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnClearSearch.FlatStyle = FlatStyle.Flat;
            btnClearSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnClearSearch.ForeColor = SystemColors.ControlText;
            btnClearSearch.Image = (Image)resources.GetObject("btnClearSearch.Image");
            btnClearSearch.Location = new Point(726, 50);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(40, 30);
            btnClearSearch.TabIndex = 48;
            btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Location = new Point(680, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 30);
            btnSearch.TabIndex = 47;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(495, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 23);
            txtSearch.TabIndex = 44;
            // 
            // cbSearch
            // 
            cbSearch.Cursor = Cursors.Hand;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(344, 54);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(143, 23);
            cbSearch.TabIndex = 46;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(263, 54);
            label13.Name = "label13";
            label13.Size = new Size(74, 17);
            label13.TabIndex = 45;
            label13.Text = "Buscar por:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 48);
            label12.Name = "label12";
            label12.Size = new Size(168, 25);
            label12.TabIndex = 43;
            label12.Text = "Lista de Productos";
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.AllowUserToResizeColumns = false;
            dgvProducto.AllowUserToResizeRows = false;
            dgvProducto.BackgroundColor = Color.White;
            dgvProducto.BorderStyle = BorderStyle.None;
            dgvProducto.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProducto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { Codigo, NombreProducto, IdCategoria, PrecioVenta, Stock, Estado });
            dgvProducto.EnableHeadersVisualStyles = false;
            dgvProducto.GridColor = Color.White;
            dgvProducto.Location = new Point(29, 189);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducto.RowHeadersVisible = false;
            dgvProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducto.Size = new Size(603, 150);
            dgvProducto.TabIndex = 39;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "Categoria";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 620);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmProducts";
            Text = "FrmProducts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnDetails;
        private Button btnClearSearch;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private Label label13;
        private Label label12;
        private DataGridView dgvProducto;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Estado;
        private Panel panel4;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txtIndice;
        private Label label14;
        private Button btnLimpiarTxt;
        private TextBox txtId;
        private Label label11;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cbEstado;
        private ComboBox cbRol;
        private Label label10;
        private Label label9;
        private TextBox txtCheckPassword;
        private Label label8;
        private TextBox txtPassword;
        private Label label7;
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
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}