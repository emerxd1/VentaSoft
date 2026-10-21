namespace Main
{
    partial class FrmCategory
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
            panel1 = new Panel();
            PnlDetails = new Sunny.UI.UIPanel();
            label2 = new Label();
            txtIndice = new Sunny.UI.UITextBox();
            btnClear = new Sunny.UI.UISymbolButton();
            btnAdd = new Sunny.UI.UISymbolButton();
            cbEstado = new Sunny.UI.UIComboBox();
            label21 = new Label();
            label16 = new Label();
            txtDescripcion = new Sunny.UI.UITextBox();
            label1 = new Label();
            txtName = new Sunny.UI.UITextBox();
            txtId = new Sunny.UI.UITextBox();
            label9 = new Label();
            label8 = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            dgvCategory = new ModernControls.ModernGrid();
            txtSearch = new Sunny.UI.UITextBox();
            uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            label15 = new Label();
            label13 = new Label();
            cbSearch = new ReaLTaiizor.Controls.AloneComboBox();
            label12 = new Label();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            elipseControl1 = new ElipseControlLib.ElipseControl();
            elipseControl2 = new ElipseControlLib.ElipseControl();
            btnSeleccionar = new DataGridViewButtonColumn();
            IdCategory = new DataGridViewTextBoxColumn();
            NameCategory = new DataGridViewTextBoxColumn();
            DescripcionCategory = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            PnlDetails.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(PnlDetails);
            panel1.Controls.Add(uiPanel1);
            panel1.Controls.Add(bigLabel2);
            panel1.Controls.Add(bigLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(31, 45, 56);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1316, 721);
            panel1.TabIndex = 8;
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
            PnlDetails.Controls.Add(label16);
            PnlDetails.Controls.Add(txtDescripcion);
            PnlDetails.Controls.Add(label1);
            PnlDetails.Controls.Add(txtName);
            PnlDetails.Controls.Add(txtId);
            PnlDetails.Controls.Add(label9);
            PnlDetails.Controls.Add(label8);
            PnlDetails.FillColor = Color.White;
            PnlDetails.Font = new Font("Microsoft Sans Serif", 12F);
            PnlDetails.Location = new Point(869, 61);
            PnlDetails.Margin = new Padding(4, 5, 4, 5);
            PnlDetails.MinimumSize = new Size(1, 1);
            PnlDetails.Name = "PnlDetails";
            PnlDetails.Radius = 12;
            PnlDetails.RectColor = Color.Silver;
            PnlDetails.Size = new Size(434, 609);
            PnlDetails.TabIndex = 64;
            PnlDetails.Text = null;
            PnlDetails.TextAlignment = ContentAlignment.MiddleCenter;
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
            btnClear.Location = new Point(224, 554);
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
            btnClear.Click += btnClear_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.FillColor = Color.FromArgb(11, 127, 87);
            btnAdd.FillDisableColor = Color.FromArgb(224, 224, 224);
            btnAdd.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnAdd.FillPressColor = Color.Silver;
            btnAdd.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(29, 554);
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
            cbEstado.Location = new Point(29, 375);
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
            label21.Location = new Point(29, 353);
            label21.Name = "label21";
            label21.Size = new Size(55, 17);
            label21.TabIndex = 77;
            label21.Text = "Estado*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(57, 79, 71);
            label16.Location = new Point(20, 180);
            label16.Name = "label16";
            label16.Size = new Size(83, 17);
            label16.TabIndex = 65;
            label16.Text = "Descripcion*";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 12F);
            txtDescripcion.Location = new Point(20, 202);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MinimumSize = new Size(1, 16);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(5);
            txtDescripcion.Radius = 10;
            txtDescripcion.RectColor = Color.Silver;
            txtDescripcion.ShowText = false;
            txtDescripcion.Size = new Size(393, 135);
            txtDescripcion.Style = Sunny.UI.UIStyle.Custom;
            txtDescripcion.SymbolColor = Color.FromArgb(57, 79, 71);
            txtDescripcion.TabIndex = 66;
            txtDescripcion.TextAlignment = ContentAlignment.MiddleLeft;
            txtDescripcion.Watermark = "Ej: Arroz Faisan 800gr...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(57, 79, 71);
            label1.Location = new Point(20, 84);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 61;
            label1.Text = "Nombre*";
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 12F);
            txtName.Location = new Point(20, 106);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MinimumSize = new Size(1, 16);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(5);
            txtName.Radius = 10;
            txtName.RectColor = Color.Silver;
            txtName.ShowText = false;
            txtName.Size = new Size(393, 49);
            txtName.Style = Sunny.UI.UIStyle.Custom;
            txtName.Symbol = 61765;
            txtName.SymbolColor = Color.FromArgb(57, 79, 71);
            txtName.TabIndex = 64;
            txtName.TextAlignment = ContentAlignment.MiddleLeft;
            txtName.Watermark = "Ej: Granos basicos";
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
            label9.Size = new Size(243, 17);
            label9.TabIndex = 62;
            label9.Text = "Complete la informacion de la categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(57, 79, 71);
            label8.Location = new Point(20, 9);
            label8.Name = "label8";
            label8.Size = new Size(174, 21);
            label8.TabIndex = 61;
            label8.Text = "Detalles de Categorias";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top;
            uiPanel1.Controls.Add(dgvCategory);
            uiPanel1.Controls.Add(txtSearch);
            uiPanel1.Controls.Add(uiSymbolButton1);
            uiPanel1.Controls.Add(uiSymbolButton2);
            uiPanel1.Controls.Add(label15);
            uiPanel1.Controls.Add(label13);
            uiPanel1.Controls.Add(cbSearch);
            uiPanel1.Controls.Add(label12);
            uiPanel1.FillColor = Color.White;
            uiPanel1.FillColor2 = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(27, 61);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.Silver;
            uiPanel1.Size = new Size(823, 609);
            uiPanel1.TabIndex = 63;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeColumns = false;
            dgvCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.BackgroundColor = Color.White;
            dgvCategory.BorderStyle = BorderStyle.None;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 116, 146);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 116, 146);
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.ColumnHeadersHeight = 44;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, IdCategory, NameCategory, DescripcionCategory, EstadoValor, Estado });
            dgvCategory.CornerRadius = 5;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.Font = new Font("Segoe UI", 9.5F);
            dgvCategory.GridColor = Color.White;
            dgvCategory.Location = new Point(11, 87);
            dgvCategory.MultiSelect = false;
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCategory.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle6.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCategory.RowTemplate.Height = 56;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.ShowCellToolTips = false;
            dgvCategory.Size = new Size(799, 448);
            dgvCategory.TabIndex = 83;
            dgvCategory.CellClick += dgvCategory_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.Location = new Point(249, 49);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.Radius = 10;
            txtSearch.RectColor = Color.Silver;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(277, 26);
            txtSearch.Style = Sunny.UI.UIStyle.Custom;
            txtSearch.Symbol = 61442;
            txtSearch.SymbolColor = Color.FromArgb(57, 79, 71);
            txtSearch.TabIndex = 65;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Escriba para buscar...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.FillColor = Color.White;
            uiSymbolButton1.FillDisableColor = Color.FromArgb(224, 224, 224);
            uiSymbolButton1.FillHoverColor = Color.Silver;
            uiSymbolButton1.FillPressColor = Color.Silver;
            uiSymbolButton1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiSymbolButton1.ForeColor = Color.FromArgb(255, 128, 128);
            uiSymbolButton1.ForePressColor = Color.Black;
            uiSymbolButton1.Location = new Point(7, 557);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Radius = 15;
            uiSymbolButton1.RectColor = Color.FromArgb(255, 128, 128);
            uiSymbolButton1.RectDisableColor = Color.White;
            uiSymbolButton1.RectHoverColor = Color.White;
            uiSymbolButton1.RectPressColor = Color.White;
            uiSymbolButton1.RectSelectedColor = Color.White;
            uiSymbolButton1.ShowFocusLine = true;
            uiSymbolButton1.Size = new Size(149, 42);
            uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton1.Symbol = 61460;
            uiSymbolButton1.SymbolColor = Color.FromArgb(255, 128, 128);
            uiSymbolButton1.SymbolPressColor = Color.Black;
            uiSymbolButton1.SymbolSelectedColor = Color.FromArgb(255, 128, 128);
            uiSymbolButton1.TabIndex = 82;
            uiSymbolButton1.Text = "Eliminar";
            uiSymbolButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiSymbolButton1.Click += uiSymbolButton1_Click;
            // 
            // uiSymbolButton2
            // 
            uiSymbolButton2.FillColor = Color.White;
            uiSymbolButton2.FillDisableColor = Color.FromArgb(224, 224, 224);
            uiSymbolButton2.FillHoverColor = Color.FromArgb(8, 92, 63);
            uiSymbolButton2.FillPressColor = Color.Silver;
            uiSymbolButton2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiSymbolButton2.ForeColor = Color.FromArgb(57, 79, 71);
            uiSymbolButton2.ForePressColor = Color.Black;
            uiSymbolButton2.Location = new Point(170, 557);
            uiSymbolButton2.MinimumSize = new Size(1, 1);
            uiSymbolButton2.Name = "uiSymbolButton2";
            uiSymbolButton2.Radius = 15;
            uiSymbolButton2.RectColor = Color.Silver;
            uiSymbolButton2.RectDisableColor = Color.White;
            uiSymbolButton2.RectHoverColor = Color.White;
            uiSymbolButton2.RectPressColor = Color.Silver;
            uiSymbolButton2.RectSelectedColor = Color.White;
            uiSymbolButton2.ShowFocusLine = true;
            uiSymbolButton2.Size = new Size(149, 42);
            uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton2.Symbol = 61504;
            uiSymbolButton2.SymbolColor = Color.FromArgb(57, 79, 71);
            uiSymbolButton2.TabIndex = 82;
            uiSymbolButton2.Text = "Actualizar";
            uiSymbolButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            uiSymbolButton2.Click += uiSymbolButton2_Click;
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
            label12.Location = new Point(302, 22);
            label12.Name = "label12";
            label12.Size = new Size(0, 25);
            label12.TabIndex = 43;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Gray;
            bigLabel2.Location = new Point(42, 39);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(316, 17);
            bigLabel2.TabIndex = 62;
            bigLabel2.Text = "Gestiona y organiza las categorías de tus productos.";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(57, 79, 71);
            bigLabel1.Location = new Point(41, 9);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(122, 30);
            bigLabel1.TabIndex = 61;
            bigLabel1.Text = "Categorias ";
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 30;
            elipseControl1.TargetControl = null;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 5;
            elipseControl2.TargetControl = null;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.DefaultCellStyle = dataGridViewCellStyle3;
            btnSeleccionar.FillWeight = 117F;
            btnSeleccionar.HeaderText = "Cargar Datos";
            btnSeleccionar.MinimumWidth = 117;
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Resizable = DataGridViewTriState.True;
            btnSeleccionar.Visible = false;
            // 
            // IdCategory
            // 
            IdCategory.HeaderText = "IdCategoria";
            IdCategory.Name = "IdCategory";
            IdCategory.ReadOnly = true;
            IdCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdCategory.Visible = false;
            // 
            // NameCategory
            // 
            NameCategory.FillWeight = 79F;
            NameCategory.HeaderText = "Nombre";
            NameCategory.MinimumWidth = 79;
            NameCategory.Name = "NameCategory";
            NameCategory.ReadOnly = true;
            NameCategory.Resizable = DataGridViewTriState.False;
            NameCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DescripcionCategory
            // 
            DescripcionCategory.FillWeight = 104F;
            DescripcionCategory.HeaderText = "Descripcion";
            DescripcionCategory.MinimumWidth = 104;
            DescripcionCategory.Name = "DescripcionCategory";
            DescripcionCategory.ReadOnly = true;
            DescripcionCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // FrmCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1316, 721);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCategory";
            Text = "Form1";
            Load += FrmCategory_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PnlDetails.ResumeLayout(false);
            PnlDetails.PerformLayout();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ElipseControlLib.ElipseControl elipseControl1;
        private ElipseControlLib.ElipseControl elipseControl2;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Sunny.UI.UIPanel uiPanel1;
        private ModernControls.ModernGrid dgvCategory;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Label label15;
        private Label label13;
        private ReaLTaiizor.Controls.AloneComboBox cbSearch;
        private Label label12;
        private Sunny.UI.UIPanel PnlDetails;
        private Label label2;
        private Sunny.UI.UITextBox txtIndice;
        private Sunny.UI.UISymbolButton btnClear;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UIComboBox cbEstado;
        private Label label21;
        private Label label16;
        private Sunny.UI.UITextBox txtDescripcion;
        private Label label1;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UITextBox txtId;
        private Label label9;
        private Label label8;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn IdCategory;
        private DataGridViewTextBoxColumn NameCategory;
        private DataGridViewTextBoxColumn DescripcionCategory;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}