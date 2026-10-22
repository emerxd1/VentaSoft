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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            PnlDetails = new Sunny.UI.UIPanel();
            cbRol = new Sunny.UI.UIComboBox();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            uiTextBox4 = new Sunny.UI.UITextBox();
            uiTextBox3 = new Sunny.UI.UITextBox();
            label6 = new Label();
            PB = new Sunny.UI.UITextBox();
            label5 = new Label();
            label3 = new Label();
            txtCheckPassword = new Sunny.UI.UITextBox();
            label4 = new Label();
            txtPassword = new Sunny.UI.UITextBox();
            label2 = new Label();
            txtIndice = new Sunny.UI.UITextBox();
            btnClear = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            cbEstado = new Sunny.UI.UIComboBox();
            label21 = new Label();
            label22 = new Label();
            txtTelefono = new Sunny.UI.UITextBox();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panelGradient2.SuspendLayout();
            PnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnDetails);
            panel2.Controls.Add(dgvUsers);
            panel2.Controls.Add(panelGradient2);
            panel2.Controls.Add(panelGradient1);
            panel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(7, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 731);
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
            btnDetails.Location = new Point(545, -6);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.ColumnHeadersHeight = 30;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { btnSeleccion, IdUsuario, DNI, Name1, Name2, LastName1, LastName2, Email, Password, Id_Rol, Rol, EstadoValor, Estado });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle5;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.Black;
            dgvUsers.Location = new Point(-6, 149);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            panelGradient2.Location = new Point(-70, 38);
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
            label12.Size = new Size(175, 25);
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
            cbSearch.Size = new Size(143, 25);
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
            txtSearch.Size = new Size(179, 25);
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
            label13.Size = new Size(74, 17);
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
            panelGradient1.Location = new Point(-10, 191);
            panelGradient1.Name = "panelGradient1";
            panelGradient1.Size = new Size(809, 367);
            panelGradient1.TabIndex = 55;
            // 
            // PnlDetails
            // 
            PnlDetails.Anchor = AnchorStyles.Top;
            PnlDetails.BackColor = Color.White;
            PnlDetails.Controls.Add(cbRol);
            PnlDetails.Controls.Add(label14);
            PnlDetails.Controls.Add(label11);
            PnlDetails.Controls.Add(label10);
            PnlDetails.Controls.Add(label7);
            PnlDetails.Controls.Add(uiTextBox4);
            PnlDetails.Controls.Add(uiTextBox3);
            PnlDetails.Controls.Add(label6);
            PnlDetails.Controls.Add(PB);
            PnlDetails.Controls.Add(label5);
            PnlDetails.Controls.Add(label3);
            PnlDetails.Controls.Add(txtCheckPassword);
            PnlDetails.Controls.Add(label4);
            PnlDetails.Controls.Add(txtPassword);
            PnlDetails.Controls.Add(label2);
            PnlDetails.Controls.Add(txtIndice);
            PnlDetails.Controls.Add(btnClear);
            PnlDetails.Controls.Add(btnAdd);
            PnlDetails.Controls.Add(cbEstado);
            PnlDetails.Controls.Add(label21);
            PnlDetails.Controls.Add(label22);
            PnlDetails.Controls.Add(txtTelefono);
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
            PnlDetails.Location = new Point(822, 14);
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
            // cbRol
            // 
            cbRol.Cursor = Cursors.Hand;
            cbRol.DataSource = null;
            cbRol.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbRol.FillColor = Color.White;
            cbRol.Font = new Font("Microsoft Sans Serif", 12F);
            cbRol.ItemHoverColor = Color.FromArgb(201, 228, 217);
            cbRol.ItemRectColor = Color.FromArgb(57, 79, 71);
            cbRol.ItemSelectBackColor = Color.Silver;
            cbRol.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            cbRol.Location = new Point(223, 435);
            cbRol.Margin = new Padding(4, 5, 4, 5);
            cbRol.MinimumSize = new Size(63, 0);
            cbRol.Name = "cbRol";
            cbRol.Padding = new Padding(0, 0, 30, 2);
            cbRol.RectColor = Color.Silver;
            cbRol.Size = new Size(190, 35);
            cbRol.Style = Sunny.UI.UIStyle.Custom;
            cbRol.StyleDropDown = Sunny.UI.UIStyle.Custom;
            cbRol.SymbolSize = 24;
            cbRol.TabIndex = 98;
            cbRol.TextAlignment = ContentAlignment.MiddleLeft;
            cbRol.Watermark = "Seleccione un rol";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(57, 79, 71);
            label14.Location = new Point(223, 413);
            label14.Name = "label14";
            label14.Size = new Size(33, 17);
            label14.TabIndex = 97;
            label14.Text = "Rol*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(50, 76);
            label11.Name = "label11";
            label11.Size = new Size(131, 17);
            label11.TabIndex = 96;
            label11.Text = "Informacion Personal";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(40, 478);
            label10.Name = "label10";
            label10.Size = new Size(60, 17);
            label10.TabIndex = 95;
            label10.Text = "Contacto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(31, 324);
            label7.Name = "label7";
            label7.Size = new Size(159, 17);
            label7.TabIndex = 94;
            label7.Text = "Seguridad y Autenticacion";
            // 
            // uiTextBox4
            // 
            uiTextBox4.Enabled = false;
            uiTextBox4.FillDisableColor = Color.White;
            uiTextBox4.FillReadOnlyColor = Color.White;
            uiTextBox4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox4.ForeColor = Color.FromArgb(97, 157, 135);
            uiTextBox4.ForeDisableColor = Color.FromArgb(97, 157, 135);
            uiTextBox4.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            uiTextBox4.Location = new Point(15, 478);
            uiTextBox4.Margin = new Padding(4, 5, 4, 5);
            uiTextBox4.MinimumSize = new Size(1, 16);
            uiTextBox4.Name = "uiTextBox4";
            uiTextBox4.Padding = new Padding(5);
            uiTextBox4.Radius = 0;
            uiTextBox4.ReadOnly = true;
            uiTextBox4.RectColor = Color.White;
            uiTextBox4.RectDisableColor = Color.White;
            uiTextBox4.RectReadOnlyColor = Color.White;
            uiTextBox4.ScrollBarColor = Color.White;
            uiTextBox4.ScrollBarStyleInherited = false;
            uiTextBox4.ShowText = false;
            uiTextBox4.Size = new Size(37, 22);
            uiTextBox4.Symbol = 57382;
            uiTextBox4.TabIndex = 92;
            uiTextBox4.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox4.Watermark = "";
            // 
            // uiTextBox3
            // 
            uiTextBox3.Enabled = false;
            uiTextBox3.FillDisableColor = Color.White;
            uiTextBox3.FillReadOnlyColor = Color.White;
            uiTextBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox3.ForeColor = Color.FromArgb(97, 157, 135);
            uiTextBox3.ForeDisableColor = Color.FromArgb(97, 157, 135);
            uiTextBox3.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            uiTextBox3.Location = new Point(5, 322);
            uiTextBox3.Margin = new Padding(4, 5, 4, 5);
            uiTextBox3.MinimumSize = new Size(1, 16);
            uiTextBox3.Name = "uiTextBox3";
            uiTextBox3.Padding = new Padding(5);
            uiTextBox3.Radius = 0;
            uiTextBox3.ReadOnly = true;
            uiTextBox3.RectColor = Color.White;
            uiTextBox3.RectDisableColor = Color.White;
            uiTextBox3.RectReadOnlyColor = Color.White;
            uiTextBox3.ScrollBarColor = Color.White;
            uiTextBox3.ScrollBarStyleInherited = false;
            uiTextBox3.ShowText = false;
            uiTextBox3.Size = new Size(37, 22);
            uiTextBox3.Symbol = 558154;
            uiTextBox3.TabIndex = 89;
            uiTextBox3.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox3.Watermark = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(57, 79, 71);
            label6.Location = new Point(52, 324);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 90;
            // 
            // PB
            // 
            PB.Enabled = false;
            PB.FillDisableColor = Color.White;
            PB.FillReadOnlyColor = Color.White;
            PB.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PB.ForeColor = Color.FromArgb(97, 157, 135);
            PB.ForeDisableColor = Color.FromArgb(97, 157, 135);
            PB.ForeReadOnlyColor = Color.FromArgb(97, 157, 135);
            PB.Location = new Point(6, 75);
            PB.Margin = new Padding(4, 5, 4, 5);
            PB.MinimumSize = new Size(1, 16);
            PB.Name = "PB";
            PB.Padding = new Padding(5);
            PB.Radius = 0;
            PB.ReadOnly = true;
            PB.RectColor = Color.White;
            PB.RectDisableColor = Color.White;
            PB.RectReadOnlyColor = Color.White;
            PB.ScrollBarColor = Color.White;
            PB.ScrollBarStyleInherited = false;
            PB.ShowText = false;
            PB.Size = new Size(37, 22);
            PB.Symbol = 358686;
            PB.TabIndex = 64;
            PB.TextAlignment = ContentAlignment.MiddleLeft;
            PB.Watermark = "";
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
            label3.Location = new Point(220, 351);
            label3.Name = "label3";
            label3.Size = new Size(147, 17);
            label3.TabIndex = 85;
            label3.Text = "Confirmar Contraseña*";
            // 
            // txtCheckPassword
            // 
            txtCheckPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtCheckPassword.Location = new Point(220, 373);
            txtCheckPassword.Margin = new Padding(4, 5, 4, 5);
            txtCheckPassword.MinimumSize = new Size(1, 16);
            txtCheckPassword.Name = "txtCheckPassword";
            txtCheckPassword.Padding = new Padding(5);
            txtCheckPassword.Radius = 10;
            txtCheckPassword.RectColor = Color.Silver;
            txtCheckPassword.ShowText = false;
            txtCheckPassword.Size = new Size(193, 35);
            txtCheckPassword.Style = Sunny.UI.UIStyle.Custom;
            txtCheckPassword.SymbolColor = Color.FromArgb(57, 79, 71);
            txtCheckPassword.TabIndex = 86;
            txtCheckPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtCheckPassword.Watermark = "Confirme la contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(57, 79, 71);
            label4.Location = new Point(20, 351);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 83;
            label4.Text = "Contraseña*";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 12F);
            txtPassword.Location = new Point(20, 373);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(5);
            txtPassword.Radius = 10;
            txtPassword.RectColor = Color.Silver;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(190, 35);
            txtPassword.Style = Sunny.UI.UIStyle.Custom;
            txtPassword.SymbolColor = Color.FromArgb(57, 79, 71);
            txtPassword.TabIndex = 84;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "Ingrese la contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(320, 20);
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
            btnClear.RectColor = Color.Silver;
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
            cbEstado.Font = new Font("Microsoft Sans Serif", 12F);
            cbEstado.ItemHoverColor = Color.FromArgb(201, 228, 217);
            cbEstado.ItemRectColor = Color.FromArgb(57, 79, 71);
            cbEstado.ItemSelectBackColor = Color.Silver;
            cbEstado.ItemSelectForeColor = Color.FromArgb(57, 79, 71);
            cbEstado.Location = new Point(20, 435);
            cbEstado.Margin = new Padding(4, 5, 4, 5);
            cbEstado.MinimumSize = new Size(63, 0);
            cbEstado.Name = "cbEstado";
            cbEstado.Padding = new Padding(0, 0, 30, 2);
            cbEstado.RectColor = Color.Silver;
            cbEstado.Size = new Size(197, 35);
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
            label21.Location = new Point(20, 413);
            label21.Name = "label21";
            label21.Size = new Size(55, 17);
            label21.TabIndex = 77;
            label21.Text = "Estado*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label22.ForeColor = Color.FromArgb(57, 79, 71);
            label22.Location = new Point(20, 572);
            label22.Name = "label22";
            label22.Size = new Size(65, 17);
            label22.TabIndex = 75;
            label22.Text = "Telefono*";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 12F);
            txtTelefono.Location = new Point(20, 594);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MinimumSize = new Size(1, 16);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(5);
            txtTelefono.Radius = 10;
            txtTelefono.RectColor = Color.Silver;
            txtTelefono.ShowText = false;
            txtTelefono.Size = new Size(190, 35);
            txtTelefono.Style = Sunny.UI.UIStyle.Custom;
            txtTelefono.SymbolColor = Color.FromArgb(57, 79, 71);
            txtTelefono.TabIndex = 76;
            txtTelefono.TextAlignment = ContentAlignment.MiddleLeft;
            txtTelefono.TouchPressClick = true;
            txtTelefono.Watermark = "Ej: 88888945";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label20.ForeColor = Color.FromArgb(57, 79, 71);
            label20.Location = new Point(20, 505);
            label20.Name = "label20";
            label20.Size = new Size(125, 17);
            label20.TabIndex = 73;
            label20.Text = "Correo electronico*";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(20, 532);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.Radius = 10;
            txtEmail.RectColor = Color.Silver;
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(393, 35);
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
            txtLastName2.Font = new Font("Microsoft Sans Serif", 12F);
            txtLastName2.Location = new Point(220, 268);
            txtLastName2.Margin = new Padding(4, 5, 4, 5);
            txtLastName2.MinimumSize = new Size(1, 16);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.Padding = new Padding(5);
            txtLastName2.Radius = 10;
            txtLastName2.RectColor = Color.Silver;
            txtLastName2.ShowText = false;
            txtLastName2.Size = new Size(190, 35);
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
            txtLastName1.Font = new Font("Microsoft Sans Serif", 12F);
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
            txtName2.Font = new Font("Microsoft Sans Serif", 12F);
            txtName2.Location = new Point(220, 190);
            txtName2.Margin = new Padding(4, 5, 4, 5);
            txtName2.MinimumSize = new Size(1, 16);
            txtName2.Name = "txtName2";
            txtName2.Padding = new Padding(5);
            txtName2.Radius = 10;
            txtName2.RectColor = Color.Silver;
            txtName2.ShowText = false;
            txtName2.Size = new Size(190, 35);
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
            txtName1.Font = new Font("Microsoft Sans Serif", 12F);
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
            label1.Location = new Point(20, 106);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 61;
            label1.Text = "DNI*";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F);
            txtDni.Location = new Point(20, 128);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.MinimumSize = new Size(1, 16);
            txtDni.Name = "txtDni";
            txtDni.Padding = new Padding(5);
            txtDni.Radius = 10;
            txtDni.RectColor = Color.Silver;
            txtDni.ShowText = false;
            txtDni.Size = new Size(393, 35);
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
            label9.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(20, 30);
            label9.Name = "label9";
            label9.Size = new Size(214, 17);
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
            // Frm_Users
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1316, 721);
            Controls.Add(PnlDetails);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Users";
            Text = "Frm_Category";
            Load += Frm_Users_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panelGradient2.ResumeLayout(false);
            panelGradient2.PerformLayout();
            PnlDetails.ResumeLayout(false);
            PnlDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Sunny.UI.UITextBox txtCheckPassword;
        private Label label4;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox PB;
        private Label label5;
        private Sunny.UI.UITextBox uiTextBox3;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label7;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UIComboBox cbRol;
        private Label label14;
    }
}