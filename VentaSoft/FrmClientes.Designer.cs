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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label13 = new Label();
            label12 = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            dgvClients = new ModernControls.ModernGrid();
            btnSeleccion = new DataGridViewImageColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Name2 = new DataGridViewTextBoxColumn();
            LastName1 = new DataGridViewTextBoxColumn();
            LastName2 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NumTelefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtSearch = new Sunny.UI.UITextBox();
            btnDelete = new Sunny.UI.UISymbolButton();
            btnUpdate = new Sunny.UI.UISymbolButton();
            label15 = new Label();
            cbSearch = new ReaLTaiizor.Controls.AloneComboBox();
            PnlDetails = new Sunny.UI.UIPanel();
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
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            PnlDetails.SuspendLayout();
            SuspendLayout();
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
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(26, 22);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 43;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(dgvClients);
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
            uiPanel1.Location = new Point(21, 88);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.Silver;
            uiPanel1.Size = new Size(823, 609);
            uiPanel1.TabIndex = 50;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AllowUserToResizeColumns = false;
            dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.BackgroundColor = Color.White;
            dgvClients.BorderStyle = BorderStyle.None;
            dgvClients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 116, 146);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 116, 146);
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClients.ColumnHeadersHeight = 44;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { btnSeleccion, IdCliente, DNI, Cliente, Name1, Name2, LastName1, LastName2, Email, NumTelefono, EstadoValor, Estado });
            dgvClients.CornerRadius = 10;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvClients.DefaultCellStyle = dataGridViewCellStyle4;
            dgvClients.EnableHeadersVisualStyles = false;
            dgvClients.Font = new Font("Segoe UI", 9.5F);
            dgvClients.GridColor = Color.White;
            dgvClients.Location = new Point(11, 87);
            dgvClients.MultiSelect = false;
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvClients.RowHeadersVisible = false;
            dgvClients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle6.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClients.RowTemplate.Height = 56;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.ShowCellToolTips = false;
            dgvClients.Size = new Size(799, 448);
            dgvClients.TabIndex = 83;
            dgvClients.CellClick += dgvClients_CellClick;
            // 
            // btnSeleccion
            // 
            btnSeleccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnSeleccion.DefaultCellStyle = dataGridViewCellStyle3;
            btnSeleccion.FillWeight = 117F;
            btnSeleccion.HeaderText = "Cargar Datos";
            btnSeleccion.Image = Properties.Resources.Check;
            btnSeleccion.MinimumWidth = 117;
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.ReadOnly = true;
            btnSeleccion.Resizable = DataGridViewTriState.False;
            btnSeleccion.Visible = false;
            btnSeleccion.Width = 117;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "IdCliente";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            IdCliente.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdCliente.Visible = false;
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
            Cliente.FillWeight = 74F;
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 74;
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
            txtSearch.TextChanged += txtSearch_TextChanged_1;
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
            btnDelete.Location = new Point(7, 557);
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
            btnUpdate.Location = new Point(170, 557);
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
            label15.Location = new Point(245, 22);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 55;
            label15.Text = "Busqueda";
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
            // PnlDetails
            // 
            PnlDetails.Anchor = AnchorStyles.Top;
            PnlDetails.BackColor = Color.White;
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
            PnlDetails.Location = new Point(859, 21);
            PnlDetails.Margin = new Padding(4, 5, 4, 5);
            PnlDetails.MinimumSize = new Size(1, 1);
            PnlDetails.Name = "PnlDetails";
            PnlDetails.Radius = 12;
            PnlDetails.RectColor = Color.Silver;
            PnlDetails.Size = new Size(434, 676);
            PnlDetails.TabIndex = 58;
            PnlDetails.Text = null;
            PnlDetails.TextAlignment = ContentAlignment.MiddleCenter;
            PnlDetails.Click += PnlDetails_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 128);
            label2.Location = new Point(20, 64);
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
            btnClear.Location = new Point(224, 577);
            btnClear.MinimumSize = new Size(1, 1);
            btnClear.Name = "btnClear";
            btnClear.Radius = 15;
            btnClear.RectColor = Color.Silver;
            btnClear.RectDisableColor = Color.White;
            btnClear.RectHoverColor = Color.White;
            btnClear.RectPressColor = Color.Silver;
            btnClear.RectSelectedColor = Color.White;
            btnClear.ShowFocusColor = true;
            btnClear.ShowFocusLine = true;
            btnClear.Size = new Size(189, 45);
            btnClear.Style = Sunny.UI.UIStyle.Custom;
            btnClear.Symbol = 61741;
            btnClear.SymbolColor = Color.FromArgb(57, 79, 71);
            btnClear.TabIndex = 81;
            btnClear.Text = "Limpiar";
            btnClear.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnClear.Click += uiSymbolButton1_Click;
            // 
            // btnAdd
            // 
            btnAdd.FillColor = Color.FromArgb(11, 127, 87);
            btnAdd.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnAdd.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnAdd.FillPressColor = Color.Silver;
            btnAdd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(29, 577);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Radius = 15;
            btnAdd.RectColor = Color.White;
            btnAdd.RectDisableColor = Color.White;
            btnAdd.RectHoverColor = Color.White;
            btnAdd.RectPressColor = Color.White;
            btnAdd.RectSelectedColor = Color.White;
            btnAdd.ShowFocusLine = true;
            btnAdd.Size = new Size(189, 45);
            btnAdd.Style = Sunny.UI.UIStyle.Custom;
            btnAdd.Symbol = 62004;
            btnAdd.TabIndex = 80;
            btnAdd.Text = "Registrar";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnLogin_Click;
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
            cbEstado.Location = new Point(220, 474);
            cbEstado.Margin = new Padding(4, 5, 4, 5);
            cbEstado.MinimumSize = new Size(63, 0);
            cbEstado.Name = "cbEstado";
            cbEstado.Padding = new Padding(0, 0, 30, 2);
            cbEstado.RectColor = Color.Silver;
            cbEstado.Size = new Size(193, 49);
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
            label21.Location = new Point(220, 452);
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
            label22.Location = new Point(20, 452);
            label22.Name = "label22";
            label22.Size = new Size(65, 17);
            label22.TabIndex = 75;
            label22.Text = "Telefono*";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 12F);
            txtTelefono.Location = new Point(20, 474);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.MinimumSize = new Size(1, 16);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(5);
            txtTelefono.Radius = 10;
            txtTelefono.RectColor = Color.Silver;
            txtTelefono.ShowText = false;
            txtTelefono.Size = new Size(189, 49);
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
            label20.Location = new Point(20, 360);
            label20.Name = "label20";
            label20.Size = new Size(125, 17);
            label20.TabIndex = 73;
            label20.Text = "Correo electronico*";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(20, 382);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(5);
            txtEmail.Radius = 10;
            txtEmail.RectColor = Color.Silver;
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(393, 49);
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
            label18.Location = new Point(220, 272);
            label18.Name = "label18";
            label18.Size = new Size(115, 17);
            label18.TabIndex = 71;
            label18.Text = "Segundo Apellido";
            // 
            // txtLastName2
            // 
            txtLastName2.Font = new Font("Microsoft Sans Serif", 12F);
            txtLastName2.Location = new Point(220, 294);
            txtLastName2.Margin = new Padding(4, 5, 4, 5);
            txtLastName2.MinimumSize = new Size(1, 16);
            txtLastName2.Name = "txtLastName2";
            txtLastName2.Padding = new Padding(5);
            txtLastName2.Radius = 10;
            txtLastName2.RectColor = Color.Silver;
            txtLastName2.ShowText = false;
            txtLastName2.Size = new Size(193, 49);
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
            label19.Location = new Point(20, 272);
            label19.Name = "label19";
            label19.Size = new Size(107, 17);
            label19.TabIndex = 69;
            label19.Text = "Primer Apellido*";
            // 
            // txtLastName1
            // 
            txtLastName1.Font = new Font("Microsoft Sans Serif", 12F);
            txtLastName1.Location = new Point(20, 294);
            txtLastName1.Margin = new Padding(4, 5, 4, 5);
            txtLastName1.MinimumSize = new Size(1, 16);
            txtLastName1.Name = "txtLastName1";
            txtLastName1.Padding = new Padding(5);
            txtLastName1.Radius = 10;
            txtLastName1.RectColor = Color.Silver;
            txtLastName1.ShowText = false;
            txtLastName1.Size = new Size(189, 49);
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
            label17.Location = new Point(220, 180);
            label17.Name = "label17";
            label17.Size = new Size(116, 17);
            label17.TabIndex = 67;
            label17.Text = "Segundo Nombre";
            // 
            // txtName2
            // 
            txtName2.Font = new Font("Microsoft Sans Serif", 12F);
            txtName2.Location = new Point(220, 202);
            txtName2.Margin = new Padding(4, 5, 4, 5);
            txtName2.MinimumSize = new Size(1, 16);
            txtName2.Name = "txtName2";
            txtName2.Padding = new Padding(5);
            txtName2.Radius = 10;
            txtName2.RectColor = Color.Silver;
            txtName2.ShowText = false;
            txtName2.Size = new Size(193, 49);
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
            label16.Location = new Point(20, 180);
            label16.Name = "label16";
            label16.Size = new Size(108, 17);
            label16.TabIndex = 65;
            label16.Text = "Primer Nombre*";
            // 
            // txtName1
            // 
            txtName1.Font = new Font("Microsoft Sans Serif", 12F);
            txtName1.Location = new Point(20, 202);
            txtName1.Margin = new Padding(4, 5, 4, 5);
            txtName1.MinimumSize = new Size(1, 16);
            txtName1.Name = "txtName1";
            txtName1.Padding = new Padding(5);
            txtName1.Radius = 10;
            txtName1.RectColor = Color.Silver;
            txtName1.ShowText = false;
            txtName1.Size = new Size(189, 49);
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
            label1.Location = new Point(20, 84);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 61;
            label1.Text = "DNI*";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Microsoft Sans Serif", 12F);
            txtDni.Location = new Point(20, 106);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.MinimumSize = new Size(1, 16);
            txtDni.Name = "txtDni";
            txtDni.Padding = new Padding(5);
            txtDni.Radius = 10;
            txtDni.RectColor = Color.Silver;
            txtDni.ShowText = false;
            txtDni.Size = new Size(393, 49);
            txtDni.Style = Sunny.UI.UIStyle.Custom;
            txtDni.Symbol = 62146;
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
            label8.Size = new Size(154, 21);
            label8.TabIndex = 61;
            label8.Text = "Detalles de Clientes";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Gray;
            bigLabel2.Location = new Point(50, 47);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(312, 17);
            bigLabel2.TabIndex = 60;
            bigLabel2.Text = "Administracion y Lista de los clientes de su negocio ";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(57, 79, 71);
            bigLabel1.Location = new Point(49, 21);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(90, 30);
            bigLabel1.TabIndex = 59;
            bigLabel1.Text = "Clientes";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 721);
            Controls.Add(bigLabel2);
            Controls.Add(bigLabel1);
            Controls.Add(PnlDetails);
            Controls.Add(uiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += Frm_Users_Load;
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            PnlDetails.ResumeLayout(false);
            PnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private Label label12;
        private Sunny.UI.UIPanel uiPanel1;
        private ReaLTaiizor.Controls.AloneComboBox cbSearch;
        private ReaLTaiizor.Controls.HopePictureBox icoLupa;
        private Sunny.UI.UIPanel PnlDetails;
        private Label label9;
        private Label label8;
        private Label label15;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Sunny.UI.UITextBox txtId;
        private Sunny.UI.UITextBox txtDni;
        private Label label1;
        private Label label16;
        private Sunny.UI.UITextBox txtName1;
        private Label label20;
        private Sunny.UI.UITextBox txtEmail;
        private Label label18;
        private Sunny.UI.UITextBox txtLastName2;
        private Label label19;
        private Sunny.UI.UITextBox txtLastName1;
        private Label label17;
        private Sunny.UI.UITextBox txtName2;
        private Label label21;
        private Label label22;
        private Sunny.UI.UITextBox txtTelefono;
        private Sunny.UI.UIComboBox cbEstado;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISymbolButton btnDelete;
        private Sunny.UI.UISymbolButton btnUpdate;
        private Sunny.UI.UITextBox txtIndice;
        private Label label2;
        private Sunny.UI.UITextBox txtSearch;
        private ModernControls.ModernGrid dgvClients;
        private DataGridViewImageColumn btnSeleccion;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Cliente;
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