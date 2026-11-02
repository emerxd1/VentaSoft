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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            PnlDetails = new Sunny.UI.UIPanel();
            label3 = new Label();
            txtName1 = new Sunny.UI.UITextBox();
            uiPanel3 = new Sunny.UI.UIPanel();
            chip1 = new Sunny.UI.UIPanel();
            label22 = new Label();
            txtTelefono = new Sunny.UI.UITextBox();
            label4 = new Label();
            label5 = new Label();
            label15 = new Label();
            label18 = new Label();
            txtIndice = new Sunny.UI.UITextBox();
            btnClear = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            cbEstado = new Sunny.UI.UIComboBox();
            label21 = new Label();
            label20 = new Label();
            txtEmail = new Sunny.UI.UITextBox();
            label26 = new Label();
            txtRUC = new Sunny.UI.UITextBox();
            txtId = new Sunny.UI.UITextBox();
            label27 = new Label();
            label28 = new Label();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            Proveedores = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            dgvProveedor = new ModernControls.ModernGrid();
            IdProveedor = new DataGridViewTextBoxColumn();
            ruc = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NumTelefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtSearch = new Sunny.UI.UITextBox();
            btnDelete = new Sunny.UI.UISymbolButton();
            btnUpdate = new Sunny.UI.UISymbolButton();
            label1 = new Label();
            label13 = new Label();
            cbSearch = new ReaLTaiizor.Controls.AloneComboBox();
            label12 = new Label();
            PnlDetails.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // PnlDetails
            // 
            PnlDetails.Anchor = AnchorStyles.Top;
            PnlDetails.BackColor = Color.White;
            PnlDetails.Controls.Add(label3);
            PnlDetails.Controls.Add(txtName1);
            PnlDetails.Controls.Add(uiPanel3);
            PnlDetails.Controls.Add(chip1);
            PnlDetails.Controls.Add(label22);
            PnlDetails.Controls.Add(txtTelefono);
            PnlDetails.Controls.Add(label4);
            PnlDetails.Controls.Add(label5);
            PnlDetails.Controls.Add(label15);
            PnlDetails.Controls.Add(label18);
            PnlDetails.Controls.Add(txtIndice);
            PnlDetails.Controls.Add(btnClear);
            PnlDetails.Controls.Add(btnAdd);
            PnlDetails.Controls.Add(cbEstado);
            PnlDetails.Controls.Add(label21);
            PnlDetails.Controls.Add(label20);
            PnlDetails.Controls.Add(txtEmail);
            PnlDetails.Controls.Add(label26);
            PnlDetails.Controls.Add(txtRUC);
            PnlDetails.Controls.Add(txtId);
            PnlDetails.Controls.Add(label27);
            PnlDetails.Controls.Add(label28);
            PnlDetails.FillColor = Color.White;
            PnlDetails.Font = new Font("Microsoft Sans Serif", 12F);
            PnlDetails.Location = new Point(873, 53);
            PnlDetails.Margin = new Padding(4, 5, 4, 5);
            PnlDetails.MinimumSize = new Size(1, 1);
            PnlDetails.Name = "PnlDetails";
            PnlDetails.Radius = 12;
            PnlDetails.RectColor = Color.Silver;
            PnlDetails.Size = new Size(434, 653);
            PnlDetails.TabIndex = 60;
            PnlDetails.Text = null;
            PnlDetails.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(57, 79, 71);
            label3.Location = new Point(21, 175);
            label3.Name = "label3";
            label3.Size = new Size(143, 17);
            label3.TabIndex = 103;
            label3.Text = "Razon social/Nombre*";
            // 
            // txtName1
            // 
            txtName1.Font = new Font("Segoe UI", 11.25F);
            txtName1.Location = new Point(22, 197);
            txtName1.Margin = new Padding(4, 5, 4, 5);
            txtName1.MinimumSize = new Size(1, 16);
            txtName1.Name = "txtName1";
            txtName1.Padding = new Padding(5);
            txtName1.Radius = 10;
            txtName1.RectColor = Color.Silver;
            txtName1.ShowText = false;
            txtName1.Size = new Size(389, 35);
            txtName1.Style = Sunny.UI.UIStyle.Custom;
            txtName1.SymbolColor = Color.FromArgb(57, 79, 71);
            txtName1.TabIndex = 104;
            txtName1.TextAlignment = ContentAlignment.MiddleLeft;
            txtName1.Watermark = "Ej: Coca Cola";
            // 
            // uiPanel3
            // 
            uiPanel3.BackColor = Color.White;
            uiPanel3.FillColor = Color.FromArgb(223, 243, 239);
            uiPanel3.FillColor2 = Color.FromArgb(223, 243, 239);
            uiPanel3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiPanel3.ForeColor = Color.FromArgb(11, 94, 88);
            uiPanel3.Location = new Point(22, 246);
            uiPanel3.Margin = new Padding(0);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Radius = 12;
            uiPanel3.RectColor = Color.FromArgb(223, 243, 239);
            uiPanel3.Size = new Size(24, 24);
            uiPanel3.Style = Sunny.UI.UIStyle.Custom;
            uiPanel3.TabIndex = 102;
            uiPanel3.Text = "2";
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // chip1
            // 
            chip1.BackColor = Color.White;
            chip1.FillColor = Color.FromArgb(223, 243, 239);
            chip1.FillColor2 = Color.FromArgb(223, 243, 239);
            chip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chip1.ForeColor = Color.FromArgb(11, 94, 88);
            chip1.Location = new Point(26, 75);
            chip1.Margin = new Padding(0);
            chip1.MinimumSize = new Size(1, 1);
            chip1.Name = "chip1";
            chip1.Radius = 12;
            chip1.RectColor = Color.FromArgb(223, 243, 239);
            chip1.Size = new Size(24, 24);
            chip1.Style = Sunny.UI.UIStyle.Custom;
            chip1.TabIndex = 100;
            chip1.Text = "1";
            chip1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label22.ForeColor = Color.FromArgb(57, 79, 71);
            label22.Location = new Point(27, 372);
            label22.Name = "label22";
            label22.Size = new Size(65, 17);
            label22.TabIndex = 75;
            label22.Text = "Telefono*";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F);
            txtTelefono.Location = new Point(20, 398);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MinimumSize = new Size(1, 16);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(5);
            txtTelefono.Radius = 10;
            txtTelefono.RectColor = Color.Silver;
            txtTelefono.ShowText = false;
            txtTelefono.Size = new Size(188, 35);
            txtTelefono.Style = Sunny.UI.UIStyle.Custom;
            txtTelefono.SymbolColor = Color.FromArgb(57, 79, 71);
            txtTelefono.TabIndex = 76;
            txtTelefono.TextAlignment = ContentAlignment.MiddleLeft;
            txtTelefono.TouchPressClick = true;
            txtTelefono.Watermark = "Ej: 88888945";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(53, 78);
            label4.Name = "label4";
            label4.Size = new Size(116, 16);
            label4.TabIndex = 96;
            label4.Text = "Datos del proveedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(47, 249);
            label5.Name = "label5";
            label5.Size = new Size(59, 16);
            label5.TabIndex = 95;
            label5.Text = "Contacto";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(57, 79, 71);
            label15.Location = new Point(53, 77);
            label15.Name = "label15";
            label15.Size = new Size(0, 17);
            label15.TabIndex = 87;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(255, 128, 128);
            label18.Location = new Point(20, 50);
            label18.Name = "label18";
            label18.Size = new Size(287, 17);
            label18.TabIndex = 82;
            label18.Text = "Los campos marcados por \"*\" son obligatorios.";
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
            btnClear.Location = new Point(223, 581);
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
            btnAdd.Location = new Point(28, 581);
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
            cbEstado.Location = new Point(223, 398);
            cbEstado.Margin = new Padding(4, 5, 4, 5);
            cbEstado.MinimumSize = new Size(63, 0);
            cbEstado.Name = "cbEstado";
            cbEstado.Padding = new Padding(0, 0, 30, 2);
            cbEstado.RectColor = Color.Silver;
            cbEstado.Size = new Size(187, 35);
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
            label21.Location = new Point(220, 376);
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
            label20.Location = new Point(22, 281);
            label20.Name = "label20";
            label20.Size = new Size(119, 17);
            label20.TabIndex = 73;
            label20.Text = "Correo electronico";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.25F);
            txtEmail.Location = new Point(22, 308);
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
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label26.ForeColor = Color.FromArgb(57, 79, 71);
            label26.Location = new Point(20, 104);
            label26.Name = "label26";
            label26.Size = new Size(39, 17);
            label26.TabIndex = 61;
            label26.Text = "RUC*";
            // 
            // txtRUC
            // 
            txtRUC.Font = new Font("Segoe UI", 11.25F);
            txtRUC.Location = new Point(21, 126);
            txtRUC.Margin = new Padding(4, 5, 4, 5);
            txtRUC.MinimumSize = new Size(1, 16);
            txtRUC.Name = "txtRUC";
            txtRUC.Padding = new Padding(5);
            txtRUC.Radius = 10;
            txtRUC.RectColor = Color.Silver;
            txtRUC.ShowText = false;
            txtRUC.Size = new Size(389, 35);
            txtRUC.Style = Sunny.UI.UIStyle.Custom;
            txtRUC.SymbolColor = Color.FromArgb(57, 79, 71);
            txtRUC.TabIndex = 64;
            txtRUC.TextAlignment = ContentAlignment.MiddleLeft;
            txtRUC.Watermark = "Ej: J031000000898";
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
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.Gray;
            label27.Location = new Point(20, 30);
            label27.Name = "label27";
            label27.Size = new Size(267, 16);
            label27.TabIndex = 62;
            label27.Text = "Complete la informacion del Proveedor a registrar";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.FromArgb(57, 79, 71);
            label28.Location = new Point(20, 9);
            label28.Name = "label28";
            label28.Size = new Size(188, 21);
            label28.TabIndex = 61;
            label28.Text = "Detalles de Proveedores";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Gray;
            bigLabel2.Location = new Point(29, 35);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(301, 17);
            bigLabel2.TabIndex = 71;
            bigLabel2.Text = "Control, registro y administración de proveedores";
            // 
            // Proveedores
            // 
            Proveedores.AutoSize = true;
            Proveedores.BackColor = Color.Transparent;
            Proveedores.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Proveedores.ForeColor = Color.FromArgb(57, 79, 71);
            Proveedores.Location = new Point(28, 9);
            Proveedores.Name = "Proveedores";
            Proveedores.Size = new Size(113, 30);
            Proveedores.TabIndex = 70;
            Proveedores.Text = "Productos";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(dgvProveedor);
            uiPanel1.Controls.Add(txtSearch);
            uiPanel1.Controls.Add(btnDelete);
            uiPanel1.Controls.Add(btnUpdate);
            uiPanel1.Controls.Add(label1);
            uiPanel1.Controls.Add(label13);
            uiPanel1.Controls.Add(cbSearch);
            uiPanel1.Controls.Add(label12);
            uiPanel1.FillColor = Color.White;
            uiPanel1.FillColor2 = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(10, 58);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.Silver;
            uiPanel1.Size = new Size(851, 641);
            uiPanel1.TabIndex = 69;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.AllowUserToResizeColumns = false;
            dgvProveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.BackgroundColor = Color.White;
            dgvProveedor.BorderStyle = BorderStyle.None;
            dgvProveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 116, 146);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 116, 146);
            dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedor.ColumnHeadersHeight = 44;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { IdProveedor, ruc, Name1, Email, NumTelefono, EstadoValor, Estado });
            dgvProveedor.CornerRadius = 10;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedor.EnableHeadersVisualStyles = false;
            dgvProveedor.Font = new Font("Segoe UI", 9.5F);
            dgvProveedor.GridColor = Color.White;
            dgvProveedor.Location = new Point(11, 87);
            dgvProveedor.MultiSelect = false;
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dgvProveedor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProveedor.RowHeadersVisible = false;
            dgvProveedor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProveedor.RowTemplate.Height = 56;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.ShowCellToolTips = false;
            dgvProveedor.Size = new Size(825, 486);
            dgvProveedor.TabIndex = 83;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
            // 
            // IdProveedor
            // 
            IdProveedor.HeaderText = "Id Proveedor";
            IdProveedor.Name = "IdProveedor";
            IdProveedor.ReadOnly = true;
            IdProveedor.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdProveedor.Visible = false;
            // 
            // ruc
            // 
            ruc.FillWeight = 60F;
            ruc.HeaderText = "RUC";
            ruc.MinimumWidth = 60;
            ruc.Name = "ruc";
            ruc.ReadOnly = true;
            ruc.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Name1
            // 
            Name1.FillWeight = 113F;
            Name1.HeaderText = "Razon Social";
            Name1.MinimumWidth = 113;
            Name1.Name = "Name1";
            Name1.ReadOnly = true;
            Name1.Resizable = DataGridViewTriState.False;
            Name1.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // NumTelefono
            // 
            NumTelefono.FillWeight = 87F;
            NumTelefono.HeaderText = "Telefono";
            NumTelefono.MinimumWidth = 87;
            NumTelefono.Name = "NumTelefono";
            NumTelefono.ReadOnly = true;
            NumTelefono.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            btnDelete.Location = new Point(11, 587);
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
            btnDelete.Click += btnDelete_Click;
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
            btnUpdate.Location = new Point(174, 587);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(57, 79, 71);
            label1.Location = new Point(245, 22);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 55;
            label1.Text = "Busqueda";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(57, 79, 71);
            label13.Location = new Point(32, 26);
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
            label12.Location = new Point(606, 22);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 43;
            // 
            // Frm_Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 721);
            Controls.Add(bigLabel2);
            Controls.Add(Proveedores);
            Controls.Add(uiPanel1);
            Controls.Add(PnlDetails);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Proveedor";
            Text = "Frm_Proveedor";
            Load += Frm_Proveedor_Load;
            PnlDetails.ResumeLayout(false);
            PnlDetails.PerformLayout();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Sunny.UI.UIPanel PnlDetails;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel chip1;
        private Label label3;
        private Sunny.UI.UITextBox txtName1;
        private Label label22;
        private Sunny.UI.UITextBox txtTelefono;
        private Label label4;
        private Label label5;
        private Label label15;
        private Label label18;
        private Sunny.UI.UITextBox txtIndice;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UIComboBox cbEstado;
        private Label label21;
        private Label label20;
        private Sunny.UI.UITextBox txtEmail;
        private Label label26;
        private Sunny.UI.UITextBox txtRUC;
        private Sunny.UI.UITextBox txtId;
        private Label label27;
        private Label label28;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel Proveedores;
        private Sunny.UI.UIPanel uiPanel1;
        private ModernControls.ModernGrid dgvProveedor;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Label label1;
        private Label label13;
        private ReaLTaiizor.Controls.AloneComboBox cbSearch;
        private Label label12;
        private DataGridViewTextBoxColumn IdProveedor;
        private DataGridViewTextBoxColumn ruc;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NumTelefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}