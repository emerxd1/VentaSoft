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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            IdUsuario = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
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
            PnlDetails = new Sunny.UI.UIPanel();
            txtCheckPassword = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            cbRol = new Sunny.UI.UIComboBox();
            label22 = new Label();
            txtTelefono = new Sunny.UI.UITextBox();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtIndice = new Sunny.UI.UITextBox();
            btnClear = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            cbEstado = new Sunny.UI.UIComboBox();
            label21 = new Label();
            label20 = new Label();
            txtEmail = new Sunny.UI.UITextBox();
            label18 = new Label();
            txtLastName2 = new Sunny.UI.UITextBox();
            label19 = new Label();
            txtLastName1 = new Sunny.UI.UITextBox();
            label17 = new Label();
            txtName2 = new Sunny.UI.UITextBox();
            label16 = new Label();
            txtName1 = new Sunny.UI.UITextBox();
            label1 = new Label();
            txtDni = new Sunny.UI.UITextBox();
            txtId = new Sunny.UI.UITextBox();
            label9 = new Label();
            label8 = new Label();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            dgvUsers = new ModernControls.ModernGrid();
            txtSearch = new Sunny.UI.UITextBox();
            btnDelete = new Sunny.UI.UISymbolButton();
            btnUpdate = new Sunny.UI.UISymbolButton();
            label15 = new Label();
            label13 = new Label();
            cbSearch = new ReaLTaiizor.Controls.AloneComboBox();
            label12 = new Label();
            PnlDetails.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdUsuario.Visible = false;
            // 
            // DNI
            // 
            DNI.FillWeight = 60F;
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 60;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cliente
            // 
            Cliente.FillWeight = 79F;
            Cliente.HeaderText = "Nombre";
            Cliente.MinimumWidth = 79;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Resizable = DataGridViewTriState.False;
            Cliente.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Name1
            // 
            Name1.HeaderText = "Primer Nombre";
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            Name1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Name1.Visible = false;
            // 
            // Name2
            // 
            Name2.HeaderText = "Segundo Nombre";
            Name2.Name = "Name2";
            Name2.ReadOnly = true;
            Name2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Name2.Visible = false;
            // 
            // LastName1
            // 
            LastName1.HeaderText = "Primer Apellido";
            LastName1.Name = "LastName1";
            LastName1.ReadOnly = true;
            LastName1.SortMode = DataGridViewColumnSortMode.NotSortable;
            LastName1.Visible = false;
            // 
            // LastName2
            // 
            LastName2.HeaderText = "Segundo Apellido";
            LastName2.Name = "LastName2";
            LastName2.ReadOnly = true;
            LastName2.SortMode = DataGridViewColumnSortMode.NotSortable;
            LastName2.Visible = false;
            // 
            // Email
            // 
            Email.FillWeight = 76F;
            Email.HeaderText = "Correo";
            Email.MinimumWidth = 76;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.SortMode = DataGridViewColumnSortMode.NotSortable;
            Password.Visible = false;
            // 
            // Id_Rol
            // 
            Id_Rol.HeaderText = "Id_Rol";
            Id_Rol.Name = "Id_Rol";
            Id_Rol.ReadOnly = true;
            Id_Rol.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id_Rol.Visible = false;
            // 
            // Rol
            // 
            Rol.FillWeight = 60F;
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 60;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.SortMode = DataGridViewColumnSortMode.NotSortable;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.FillWeight = 74F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 74;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PnlDetails
            // 
            PnlDetails.Anchor = AnchorStyles.Top;
            PnlDetails.BackColor = Color.White;
            PnlDetails.Controls.Add(txtCheckPassword);
            PnlDetails.Controls.Add(txtPassword);
            PnlDetails.Controls.Add(cbRol);
            PnlDetails.Controls.Add(label22);
            PnlDetails.Controls.Add(txtTelefono);
            PnlDetails.Controls.Add(label14);
            PnlDetails.Controls.Add(label11);
            PnlDetails.Controls.Add(label10);
            PnlDetails.Controls.Add(label7);
            PnlDetails.Controls.Add(label6);
            PnlDetails.Controls.Add(label5);
            PnlDetails.Controls.Add(label3);
            PnlDetails.Controls.Add(label4);
            PnlDetails.Controls.Add(label2);
            PnlDetails.Controls.Add(txtIndice);
            PnlDetails.Controls.Add(btnClear);
            PnlDetails.Controls.Add(btnAdd);
            PnlDetails.Controls.Add(cbEstado);
            PnlDetails.Controls.Add(label21);
            PnlDetails.Controls.Add(label20);
            PnlDetails.Controls.Add(txtEmail);
            PnlDetails.Controls.Add(label18);
            PnlDetails.Controls.Add(txtLastName2);
            PnlDetails.Controls.Add(label19);
            PnlDetails.Controls.Add(txtLastName1);
            PnlDetails.Controls.Add(label17);
            PnlDetails.Controls.Add(txtName2);
            PnlDetails.Controls.Add(label16);
            PnlDetails.Controls.Add(txtName1);
            PnlDetails.Controls.Add(label1);
            PnlDetails.Controls.Add(txtDni);
            PnlDetails.Controls.Add(txtId);
            PnlDetails.Controls.Add(label9);
            PnlDetails.Controls.Add(label8);
            PnlDetails.FillColor = Color.White;
            PnlDetails.Font = new Font("Microsoft Sans Serif", 12F);
            PnlDetails.Location = new Point(869, 14);
            PnlDetails.Margin = new Padding(4, 5, 4, 5);
            PnlDetails.MinimumSize = new Size(1, 1);
            PnlDetails.Name = "PnlDetails";
            PnlDetails.Radius = 12;
            PnlDetails.RectColor = Color.Silver;
            PnlDetails.Size = new Size(434, 702);
            PnlDetails.TabIndex = 59;
            PnlDetails.Text = null;
            PnlDetails.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtCheckPassword
            // 
            txtCheckPassword.ButtonFillColor = Color.White;
            txtCheckPassword.ButtonFillHoverColor = Color.Transparent;
            txtCheckPassword.ButtonFillPressColor = Color.White;
            txtCheckPassword.ButtonForeColor = Color.Gray;
            txtCheckPassword.ButtonForeHoverColor = Color.Gray;
            txtCheckPassword.ButtonForePressColor = Color.Black;
            txtCheckPassword.ButtonRectColor = Color.Transparent;
            txtCheckPassword.ButtonRectHoverColor = Color.White;
            txtCheckPassword.ButtonRectPressColor = Color.White;
            txtCheckPassword.ButtonStyleInherited = false;
            txtCheckPassword.ButtonSymbol = 61550;
            txtCheckPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCheckPassword.ImeMode = ImeMode.Disable;
            txtCheckPassword.Location = new Point(224, 360);
            txtCheckPassword.Margin = new Padding(4, 5, 4, 5);
            txtCheckPassword.MinimumSize = new Size(1, 16);
            txtCheckPassword.Name = "txtCheckPassword";
            txtCheckPassword.Padding = new Padding(5);
            txtCheckPassword.PasswordChar = '*';
            txtCheckPassword.Radius = 10;
            txtCheckPassword.RectColor = Color.Silver;
            txtCheckPassword.ScrollBarBackColor = Color.FromArgb(192, 255, 192);
            txtCheckPassword.ScrollBarColor = Color.FromArgb(192, 255, 192);
            txtCheckPassword.ScrollBarStyleInherited = false;
            txtCheckPassword.ShowButton = true;
            txtCheckPassword.ShowText = false;
            txtCheckPassword.Size = new Size(190, 35);
            txtCheckPassword.Style = Sunny.UI.UIStyle.Custom;
            txtCheckPassword.SymbolColor = Color.FromArgb(20, 81, 59);
            txtCheckPassword.TabIndex = 99;
            txtCheckPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtCheckPassword.Watermark = "Confirme su contraseña";
            txtCheckPassword.ButtonClick += txtCheckPassword_ButtonClick;
            // 
            // txtPassword
            // 
            txtPassword.ButtonFillColor = Color.White;
            txtPassword.ButtonFillHoverColor = Color.Transparent;
            txtPassword.ButtonFillPressColor = Color.White;
            txtPassword.ButtonForeColor = Color.Gray;
            txtPassword.ButtonForeHoverColor = Color.Gray;
            txtPassword.ButtonForePressColor = Color.Black;
            txtPassword.ButtonRectColor = Color.Transparent;
            txtPassword.ButtonRectHoverColor = Color.White;
            txtPassword.ButtonRectPressColor = Color.White;
            txtPassword.ButtonStyleInherited = false;
            txtPassword.ButtonSymbol = 61550;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ImeMode = ImeMode.Disable;
            txtPassword.Location = new Point(20, 360);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.PasswordChar = '*';
            txtPassword.Radius = 10;
            txtPassword.RectColor = Color.Silver;
            txtPassword.ScrollBarBackColor = Color.FromArgb(192, 255, 192);
            txtPassword.ScrollBarColor = Color.FromArgb(192, 255, 192);
            txtPassword.ScrollBarStyleInherited = false;
            txtPassword.ShowButton = true;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(190, 35);
            txtPassword.Style = Sunny.UI.UIStyle.Custom;
            txtPassword.SymbolColor = Color.FromArgb(20, 81, 59);
            txtPassword.TabIndex = 64;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Ingrese su contraseña";
            txtPassword.ButtonClick += txtPassword_ButtonClick;
            // 
            // cbRol
            // 
            cbRol.Cursor = Cursors.Hand;
            cbRol.DataSource = null;
            cbRol.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbRol.FillColor = Color.White;
            cbRol.Font = new Font("Segoe UI", 11.25F);
            cbRol.ItemHoverColor = Color.FromArgb(201, 228, 217);
            cbRol.ItemRectColor = Color.FromArgb(57, 79, 71);
            cbRol.ItemSelectBackColor = Color.Silver;
            cbRol.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            cbRol.Location = new Point(224, 432);
            cbRol.Margin = new Padding(4, 5, 4, 5);
            cbRol.MinimumSize = new Size(63, 0);
            cbRol.Name = "cbRol";
            cbRol.Padding = new Padding(0, 0, 30, 2);
            cbRol.RectColor = Color.Silver;
            cbRol.Size = new Size(186, 35);
            cbRol.Style = Sunny.UI.UIStyle.Custom;
            cbRol.StyleDropDown = Sunny.UI.UIStyle.Custom;
            cbRol.SymbolSize = 24;
            cbRol.TabIndex = 98;
            cbRol.TextAlignment = ContentAlignment.MiddleLeft;
            cbRol.Watermark = "Seleccione un rol";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label22.ForeColor = Color.FromArgb(57, 79, 71);
            label22.Location = new Point(20, 500);
            label22.Name = "label22";
            label22.Size = new Size(65, 17);
            label22.TabIndex = 75;
            label22.Text = "Telefono*";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F);
            txtTelefono.Location = new Point(21, 526);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MinimumSize = new Size(1, 16);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(5);
            txtTelefono.Radius = 10;
            txtTelefono.RectColor = Color.Silver;
            txtTelefono.ShowText = false;
            txtTelefono.Size = new Size(189, 35);
            txtTelefono.Style = Sunny.UI.UIStyle.Custom;
            txtTelefono.SymbolColor = Color.FromArgb(57, 79, 71);
            txtTelefono.TabIndex = 76;
            txtTelefono.TextAlignment = ContentAlignment.MiddleLeft;
            txtTelefono.TouchPressClick = true;
            txtTelefono.Watermark = "Ej: 88888945";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(57, 79, 71);
            label14.Location = new Point(224, 410);
            label14.Name = "label14";
            label14.Size = new Size(33, 17);
            label14.TabIndex = 97;
            label14.Text = "Rol*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(20, 77);
            label11.Name = "label11";
            label11.Size = new Size(122, 16);
            label11.TabIndex = 96;
            label11.Text = "Informacion Personal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(20, 475);
            label10.Name = "label10";
            label10.Size = new Size(59, 16);
            label10.TabIndex = 95;
            label10.Text = "Contacto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(21, 308);
            label7.Name = "label7";
            label7.Size = new Size(150, 16);
            label7.TabIndex = 94;
            label7.Text = "Seguridad y Autenticacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(57, 79, 71);
            label6.Location = new Point(52, 306);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 90;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(57, 79, 71);
            label5.Location = new Point(53, 77);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 87;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(57, 79, 71);
            label3.Location = new Point(220, 338);
            label3.Name = "label3";
            label3.Size = new Size(147, 17);
            label3.TabIndex = 85;
            label3.Text = "Confirmar Contraseña*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(57, 79, 71);
            label4.Location = new Point(21, 338);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 83;
            label4.Text = "Contraseña*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(287, 17);
            label2.TabIndex = 82;
            label2.Text = "Los campos marcados por \"*\" son obligatorios.";
            // 
            // txtIndice
            // 
            txtIndice.FillColor = Color.FromArgb(201, 228, 217);
            txtIndice.FillDisableColor = Color.FromArgb(201, 228, 217);
            txtIndice.FillReadOnlyColor = Color.FromArgb(201, 228, 217);
            txtIndice.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIndice.ForeColor = Color.FromArgb(97, 157, 135);
            txtIndice.ForeDisableColor = Color.FromArgb(97, 157, 135);
            txtIndice.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            txtIndice.ImeMode = ImeMode.Disable;
            txtIndice.Location = new Point(290, 18);
            txtIndice.Margin = new Padding(4, 5, 4, 5);
            txtIndice.MinimumSize = new Size(1, 16);
            txtIndice.Name = "txtIndice";
            txtIndice.Padding = new Padding(5);
            txtIndice.Radius = 15;
            txtIndice.ReadOnly = true;
            txtIndice.RectColor = Color.White;
            txtIndice.RectDisableColor = Color.White;
            txtIndice.RectReadOnlyColor = Color.White;
            txtIndice.ScrollBarColor = Color.White;
            txtIndice.ScrollBarStyleInherited = false;
            txtIndice.ShowText = false;
            txtIndice.Size = new Size(52, 29);
            txtIndice.TabIndex = 64;
            txtIndice.TextAlignment = ContentAlignment.MiddleLeft;
            txtIndice.Visible = false;
            txtIndice.Watermark = "Indice";
            // 
            // btnClear
            // 
            btnClear.FillColor = Color.White;
            btnClear.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnClear.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnClear.FillPressColor = Color.Silver;
            btnClear.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(57, 79, 71);
            btnClear.Location = new Point(223, 658);
            btnClear.MinimumSize = new Size(1, 1);
            btnClear.Name = "btnClear";
            btnClear.Radius = 10;
            btnClear.RectColor = Color.FromArgb(11, 127, 87);
            btnClear.RectDisableColor = Color.White;
            btnClear.RectHoverColor = Color.White;
            btnClear.RectPressColor = Color.Silver;
            btnClear.RectSelectedColor = Color.White;
            btnClear.ShowFocusColor = true;
            btnClear.ShowFocusLine = true;
            btnClear.Size = new Size(189, 34);
            btnClear.Style = Sunny.UI.UIStyle.Custom;
            btnClear.Symbol = 61741;
            btnClear.SymbolColor = Color.FromArgb(57, 79, 71);
            btnClear.TabIndex = 81;
            btnClear.Text = "Limpiar";
            btnClear.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.FillColor = Color.FromArgb(11, 127, 87);
            btnAdd.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnAdd.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnAdd.FillPressColor = Color.Silver;
            btnAdd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(28, 658);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Radius = 10;
            btnAdd.RectColor = Color.White;
            btnAdd.RectDisableColor = Color.White;
            btnAdd.RectHoverColor = Color.White;
            btnAdd.RectPressColor = Color.White;
            btnAdd.RectSelectedColor = Color.White;
            btnAdd.ShowFocusLine = true;
            btnAdd.Size = new Size(189, 34);
            btnAdd.Style = Sunny.UI.UIStyle.Custom;
            btnAdd.Symbol = 62004;
            btnAdd.TabIndex = 80;
            btnAdd.Text = "Registrar";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // cbEstado
            // 
            cbEstado.Cursor = Cursors.Hand;
            cbEstado.DataSource = null;
            cbEstado.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbEstado.FillColor = Color.White;
            cbEstado.Font = new Font("Segoe UI", 11.25F);
            cbEstado.ItemHoverColor = Color.FromArgb(201, 228, 217);
            cbEstado.ItemRectColor = Color.FromArgb(57, 79, 71);
            cbEstado.ItemSelectBackColor = Color.Silver;
            cbEstado.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            cbEstado.Location = new Point(21, 432);
            cbEstado.Margin = new Padding(4, 5, 4, 5);
            cbEstado.MinimumSize = new Size(63, 0);
            cbEstado.Name = "cbEstado";
            cbEstado.Padding = new Padding(0, 0, 30, 2);
            cbEstado.RectColor = Color.Silver;
            cbEstado.Size = new Size(190, 35);
            cbEstado.Style = Sunny.UI.UIStyle.Custom;
            cbEstado.StyleDropDown = Sunny.UI.UIStyle.Custom;
            cbEstado.SymbolSize = 24;
            cbEstado.TabIndex = 78;
            cbEstado.TextAlignment = ContentAlignment.MiddleLeft;
            cbEstado.Watermark = "Seleccione un estado";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(57, 79, 71);
            label21.Location = new Point(21, 410);
            label21.Name = "label21";
            label21.Size = new Size(55, 17);
            label21.TabIndex = 77;
            label21.Text = "Estado*";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(57, 79, 71);
            label20.Location = new Point(21, 564);
            label20.Name = "label20";
            label20.Size = new Size(125, 17);
            label20.TabIndex = 73;
            label20.Text = "Correo electronico*";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(21, 591);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.Radius = 10;
            txtEmail.RectColor = Color.Silver;
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(389, 35);
            txtEmail.Style = Sunny.UI.UIStyle.Custom;
            txtEmail.Symbol = 61664;
            txtEmail.SymbolColor = Color.FromArgb(57, 79, 71);
            txtEmail.TabIndex = 74;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "Ej: juanjo34@gmail.com";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(57, 79, 71);
            label18.Location = new Point(220, 246);
            label18.Name = "label18";
            label18.Size = new Size(115, 17);
            label18.TabIndex = 71;
            label18.Text = "Segundo Apellido";
            // 
            // txtLastName2
            // 
            txtLastName2.Font = new Font("Segoe UI", 11.25F);
            txtLastName2.Location = new Point(224, 268);
            txtLastName2.Margin = new Padding(4, 5, 4, 5);
            txtLastName2.MinimumSize = new Size(1, 16);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.Padding = new Padding(5);
            txtLastName2.Radius = 10;
            txtLastName2.RectColor = Color.Silver;
            txtLastName2.ShowText = false;
            txtLastName2.Size = new Size(186, 35);
            txtLastName2.Style = Sunny.UI.UIStyle.Custom;
            txtLastName2.SymbolColor = Color.FromArgb(57, 79, 71);
            txtLastName2.TabIndex = 72;
            txtLastName2.TextAlignment = ContentAlignment.MiddleLeft;
            txtLastName2.Watermark = "Ej: Lopez";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(57, 79, 71);
            label19.Location = new Point(20, 246);
            label19.Name = "label19";
            label19.Size = new Size(107, 17);
            label19.TabIndex = 69;
            label19.Text = "Primer Apellido*";
            // 
            // txtLastName1
            // 
            txtLastName1.Font = new Font("Segoe UI", 11.25F);
            txtLastName1.Location = new Point(20, 268);
            txtLastName1.Margin = new Padding(4, 5, 4, 5);
            txtLastName1.MinimumSize = new Size(1, 16);
            txtLastName1.Name = "txtLastName1";
            txtLastName1.Padding = new Padding(5);
            txtLastName1.Radius = 10;
            txtLastName1.RectColor = Color.Silver;
            txtLastName1.ShowText = false;
            txtLastName1.Size = new Size(190, 35);
            txtLastName1.Style = Sunny.UI.UIStyle.Custom;
            txtLastName1.SymbolColor = Color.FromArgb(57, 79, 71);
            txtLastName1.TabIndex = 70;
            txtLastName1.TextAlignment = ContentAlignment.MiddleLeft;
            txtLastName1.Watermark = "Ej: Perez";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(57, 79, 71);
            label17.Location = new Point(220, 168);
            label17.Name = "label17";
            label17.Size = new Size(116, 17);
            label17.TabIndex = 67;
            label17.Text = "Segundo Nombre";
            // 
            // txtName2
            // 
            txtName2.Font = new Font("Segoe UI", 11.25F);
            txtName2.Location = new Point(224, 190);
            txtName2.Margin = new Padding(4, 5, 4, 5);
            txtName2.MinimumSize = new Size(1, 16);
            txtName2.Name = "txtName2";
            txtName2.Padding = new Padding(5);
            txtName2.Radius = 10;
            txtName2.RectColor = Color.Silver;
            txtName2.ShowText = false;
            txtName2.Size = new Size(186, 35);
            txtName2.Style = Sunny.UI.UIStyle.Custom;
            txtName2.SymbolColor = Color.FromArgb(57, 79, 71);
            txtName2.TabIndex = 68;
            txtName2.TextAlignment = ContentAlignment.MiddleLeft;
            txtName2.Watermark = "Ej: Jose";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(57, 79, 71);
            label16.Location = new Point(20, 168);
            label16.Name = "label16";
            label16.Size = new Size(108, 17);
            label16.TabIndex = 65;
            label16.Text = "Primer Nombre*";
            // 
            // txtName1
            // 
            txtName1.Font = new Font("Segoe UI", 11.25F);
            txtName1.Location = new Point(20, 190);
            txtName1.Margin = new Padding(4, 5, 4, 5);
            txtName1.MinimumSize = new Size(1, 16);
            txtName1.Name = "txtName1";
            txtName1.Padding = new Padding(5);
            txtName1.Radius = 10;
            txtName1.RectColor = Color.Silver;
            txtName1.ShowText = false;
            txtName1.Size = new Size(190, 35);
            txtName1.Style = Sunny.UI.UIStyle.Custom;
            txtName1.SymbolColor = Color.FromArgb(57, 79, 71);
            txtName1.TabIndex = 66;
            txtName1.TextAlignment = ContentAlignment.MiddleLeft;
            txtName1.Watermark = "Ej: Juan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(57, 79, 71);
            label1.Location = new Point(20, 99);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 61;
            label1.Text = "DNI*";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 11.25F);
            txtDni.Location = new Point(21, 121);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.MinimumSize = new Size(1, 16);
            txtDni.Name = "txtDni";
            txtDni.Padding = new Padding(5);
            txtDni.Radius = 10;
            txtDni.RectColor = Color.Silver;
            txtDni.ShowText = false;
            txtDni.Size = new Size(389, 35);
            txtDni.Style = Sunny.UI.UIStyle.Custom;
            txtDni.Symbol = 62147;
            txtDni.SymbolColor = Color.FromArgb(57, 79, 71);
            txtDni.TabIndex = 64;
            txtDni.TextAlignment = ContentAlignment.MiddleLeft;
            txtDni.Watermark = "Ej: 001-120403-9078P";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.FillColor = Color.FromArgb(201, 228, 217);
            txtId.FillDisableColor = Color.FromArgb(201, 228, 217);
            txtId.FillReadOnlyColor = Color.FromArgb(201, 228, 217);
            txtId.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(97, 157, 135);
            txtId.ForeDisableColor = Color.FromArgb(97, 157, 135);
            txtId.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            txtId.ImeMode = ImeMode.Disable;
            txtId.Location = new Point(350, 18);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.MinimumSize = new Size(1, 16);
            txtId.Name = "txtId";
            txtId.Padding = new Padding(5);
            txtId.Radius = 15;
            txtId.ReadOnly = true;
            txtId.RectColor = Color.White;
            txtId.RectDisableColor = Color.White;
            txtId.RectReadOnlyColor = Color.White;
            txtId.ScrollBarColor = Color.White;
            txtId.ScrollBarStyleInherited = false;
            txtId.ShowText = false;
            txtId.Size = new Size(63, 29);
            txtId.TabIndex = 63;
            txtId.TextAlignment = ContentAlignment.MiddleLeft;
            txtId.Watermark = "ID#";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(20, 30);
            label9.Name = "label9";
            label9.Size = new Size(193, 16);
            label9.TabIndex = 62;
            label9.Text = "Complete la informacion del cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(57, 79, 71);
            label8.Location = new Point(20, 9);
            label8.Name = "label8";
            label8.Size = new Size(175, 21);
            label8.TabIndex = 61;
            label8.Text = "Detalles de Empleados";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Gray;
            bigLabel2.Location = new Point(44, 25);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(313, 17);
            bigLabel2.TabIndex = 63;
            bigLabel2.Text = "Administración y control del personal de su negocio";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(57, 79, 71);
            bigLabel1.Location = new Point(43, -1);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(119, 30);
            bigLabel1.TabIndex = 62;
            bigLabel1.Text = "Empleados";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(dgvUsers);
            uiPanel1.Controls.Add(txtSearch);
            uiPanel1.Controls.Add(btnDelete);
            uiPanel1.Controls.Add(btnUpdate);
            uiPanel1.Controls.Add(label15);
            uiPanel1.Controls.Add(label13);
            uiPanel1.Controls.Add(cbSearch);
            uiPanel1.Controls.Add(label12);
            uiPanel1.FillColor = Color.White;
            uiPanel1.FillColor2 = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(15, 66);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.Silver;
            uiPanel1.Size = new Size(823, 650);
            uiPanel1.TabIndex = 61;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 116, 146);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 116, 146);
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 44;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, DNI, Cliente, Name1, Name2, LastName1, LastName2, Email, Password, Id_Rol, Rol, EstadoValor, Estado });
            dgvUsers.CornerRadius = 10;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.Font = new Font("Segoe UI", 9.5F);
            dgvUsers.GridColor = Color.White;
            dgvUsers.Location = new Point(11, 87);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvUsers.RowTemplate.Height = 56;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ShowCellToolTips = false;
            dgvUsers.Size = new Size(799, 496);
            dgvUsers.TabIndex = 83;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.ButtonFillColor = Color.White;
            txtSearch.ButtonFillHoverColor = Color.White;
            txtSearch.ButtonFillPressColor = Color.White;
            txtSearch.ButtonForeColor = Color.FromArgb(57, 79, 71);
            txtSearch.ButtonRectColor = Color.White;
            txtSearch.ButtonRectHoverColor = Color.White;
            txtSearch.ButtonRectPressColor = Color.White;
            txtSearch.ButtonStyleInherited = false;
            txtSearch.ButtonSymbol = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.IconSize = 20;
            txtSearch.Location = new Point(249, 49);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.Radius = 10;
            txtSearch.RectColor = Color.Silver;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(338, 26);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.Symbol = 61442;
            txtSearch.SymbolColor = Color.FromArgb(57, 79, 71);
            txtSearch.TabIndex = 65;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Escriba para buscar...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.FillColor = Color.White;
            btnDelete.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnDelete.FillHoverColor = Color.Silver;
            btnDelete.FillPressColor = Color.Silver;
            btnDelete.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FromArgb(255, 128, 128);
            btnDelete.ForePressColor = Color.Black;
            btnDelete.Location = new Point(11, 598);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Radius = 15;
            btnDelete.RectColor = Color.FromArgb(255, 128, 128);
            btnDelete.RectDisableColor = Color.White;
            btnDelete.RectHoverColor = Color.White;
            btnDelete.RectPressColor = Color.White;
            btnDelete.RectSelectedColor = Color.White;
            btnDelete.ShowFocusLine = true;
            btnDelete.Size = new Size(149, 42);
            btnDelete.Style = Sunny.UI.UIStyle.Custom;
            btnDelete.Symbol = 61460;
            btnDelete.SymbolColor = Color.FromArgb(255, 128, 128);
            btnDelete.SymbolPressColor = Color.Black;
            btnDelete.SymbolSelectedColor = Color.FromArgb(255, 128, 128);
            btnDelete.TabIndex = 82;
            btnDelete.Text = "Eliminar";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.FillColor = Color.White;
            btnUpdate.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnUpdate.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnUpdate.FillPressColor = Color.Silver;
            btnUpdate.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(57, 79, 71);
            btnUpdate.ForePressColor = Color.Black;
            btnUpdate.Location = new Point(174, 598);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Radius = 15;
            btnUpdate.RectColor = Color.Silver;
            btnUpdate.RectDisableColor = Color.White;
            btnUpdate.RectHoverColor = Color.White;
            btnUpdate.RectPressColor = Color.Silver;
            btnUpdate.RectSelectedColor = Color.White;
            btnUpdate.ShowFocusLine = true;
            btnUpdate.Size = new Size(149, 42);
            btnUpdate.Style = Sunny.UI.UIStyle.Custom;
            btnUpdate.Symbol = 61504;
            btnUpdate.SymbolColor = Color.FromArgb(57, 79, 71);
            btnUpdate.TabIndex = 82;
            btnUpdate.Text = "Actualizar";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(57, 79, 71);
            label15.Location = new Point(245, 23);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 55;
            label15.Text = "Busqueda";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(57, 79, 71);
            label13.Location = new Point(32, 27);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 45;
            label13.Text = "Filtrar por";
            // 
            // cbSearch
            // 
            cbSearch.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.EnabledCalc = true;
            cbSearch.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearch.FormattingEnabled = true;
            cbSearch.ItemHeight = 20;
            cbSearch.Location = new Point(32, 49);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(210, 26);
            cbSearch.TabIndex = 46;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(302, 22);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 43;
            // 
            // Frm_Users
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1316, 721);
            Controls.Add(uiPanel1);
            Controls.Add(bigLabel2);
            Controls.Add(bigLabel1);
            Controls.Add(PnlDetails);
            Font = new Font("Segoe UI", 11.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Users";
            Text = "Frm_Category";
            Load += Frm_Users_Load;
            PnlDetails.ResumeLayout(false);
            PnlDetails.PerformLayout();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIPanel PnlDetails;
        private Label label2;
        private Sunny.UI.UITextBox txtIndice;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UIComboBox cbEstado;
        private Label label21;
        private Label label22;
        private Sunny.UI.UITextBox txtTelefono;
        private Label label20;
        private Sunny.UI.UITextBox txtEmail;
        private Label label18;
        private Sunny.UI.UITextBox txtLastName2;
        private Label label19;
        private Sunny.UI.UITextBox txtLastName1;
        private Label label17;
        private Sunny.UI.UITextBox txtName2;
        private Label label16;
        private Sunny.UI.UITextBox txtName1;
        private Label label1;
        private Sunny.UI.UITextBox txtDni;
        private Sunny.UI.UITextBox txtId;
        private Label label9;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label10;
        private Sunny.UI.UIComboBox cbRol;
        private Label label14;
        private Label label11;
        private Label label7;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private ModernControls.ModernGrid dgvUsers;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Label label15;
        private Label label13;
        private ReaLTaiizor.Controls.AloneComboBox cbSearch;
        private Label label12;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Cliente;
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
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtCheckPassword;
    }
}