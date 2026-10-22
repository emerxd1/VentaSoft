namespace Main
{
    partial class Frm_DetalleCompra
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            txtbusquedaa = new Sunny.UI.UITextBox();
            btnlimpiarr = new Sunny.UI.UISymbolButton();
            groupBox1 = new Sunny.UI.UIPanel();
            txtUsuarioo = new Sunny.UI.UITextBox();
            txtTipodedocumentoo = new Sunny.UI.UITextBox();
            label10 = new Label();
            txtFechaa = new Sunny.UI.UITextBox();
            label3 = new Label();
            label2 = new Label();
            lblTituloGrupo1 = new Label();
            groupBox2 = new Sunny.UI.UIPanel();
            label12 = new Label();
            txtnumerodocumentoo = new Sunny.UI.UITextBox();
            label11 = new Label();
            txtnombreproveedoorr = new Sunny.UI.UITextBox();
            txtdocproveedoorr = new Sunny.UI.UITextBox();
            lblTituloGrupo2 = new Label();
            txtmontototall = new Sunny.UI.UITextBox();
            btndescargarpdff = new Sunny.UI.UISymbolButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            label16 = new Label();
            label4 = new Label();
            btnbuscarr = new Sunny.UI.UISymbolButton();
            dataGridView1 = new ModernControls.ModernGrid();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -29);
            label1.Name = "label1";
            label1.Size = new Size(1147, 550);
            label1.TabIndex = 0;
            // 
            // txtbusquedaa
            // 
            txtbusquedaa.Cursor = Cursors.IBeam;
            txtbusquedaa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbusquedaa.Location = new Point(190, 44);
            txtbusquedaa.Margin = new Padding(3, 2, 3, 2);
            txtbusquedaa.MinimumSize = new Size(1, 16);
            txtbusquedaa.Name = "txtbusquedaa";
            txtbusquedaa.Padding = new Padding(5);
            txtbusquedaa.Radius = 10;
            txtbusquedaa.RectColor = Color.Silver;
            txtbusquedaa.ShowText = false;
            txtbusquedaa.Size = new Size(118, 30);
            txtbusquedaa.Style = Sunny.UI.UIStyle.Custom;
            txtbusquedaa.SymbolColor = Color.FromArgb(57, 79, 71);
            txtbusquedaa.TabIndex = 60;
            txtbusquedaa.TextAlignment = ContentAlignment.MiddleLeft;
            txtbusquedaa.Watermark = "EJ: 00001";
            txtbusquedaa.KeyDown += txtbusquedaa_KeyDown;
            // 
            // btnlimpiarr
            // 
            btnlimpiarr.BackColor = Color.Transparent;
            btnlimpiarr.FillColor = Color.FromArgb(0, 192, 0);
            btnlimpiarr.FillDisableColor = Color.FromArgb(11, 127, 87);
            btnlimpiarr.FillHoverColor = Color.FromArgb(8, 92, 63);
            btnlimpiarr.FillPressColor = Color.Silver;
            btnlimpiarr.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpiarr.ForeDisableColor = Color.White;
            btnlimpiarr.Location = new Point(418, 45);
            btnlimpiarr.MinimumSize = new Size(1, 1);
            btnlimpiarr.Name = "btnlimpiarr";
            btnlimpiarr.Radius = 15;
            btnlimpiarr.RectColor = Color.White;
            btnlimpiarr.RectDisableColor = Color.White;
            btnlimpiarr.RectHoverColor = Color.White;
            btnlimpiarr.RectPressColor = Color.Silver;
            btnlimpiarr.RectSelectedColor = Color.White;
            btnlimpiarr.ShowFocusColor = true;
            btnlimpiarr.ShowFocusLine = true;
            btnlimpiarr.Size = new Size(104, 30);
            btnlimpiarr.Style = Sunny.UI.UIStyle.Custom;
            btnlimpiarr.Symbol = 61741;
            btnlimpiarr.TabIndex = 62;
            btnlimpiarr.Text = "Limpiar";
            btnlimpiarr.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnlimpiarr.Click += btnlimpiarr_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtUsuarioo);
            groupBox1.Controls.Add(txtTipodedocumentoo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtFechaa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTituloGrupo1);
            groupBox1.FillColor = Color.White;
            groupBox1.FillColor2 = Color.White;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.ForeColor = Color.FromArgb(11, 46, 34);
            groupBox1.Location = new Point(2, 98);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Radius = 1;
            groupBox1.RectColor = Color.White;
            groupBox1.Size = new Size(520, 137);
            groupBox1.TabIndex = 63;
            groupBox1.Text = null;
            groupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtUsuarioo
            // 
            txtUsuarioo.Cursor = Cursors.IBeam;
            txtUsuarioo.Font = new Font("Segoe UI", 9F);
            txtUsuarioo.Location = new Point(324, 64);
            txtUsuarioo.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioo.MinimumSize = new Size(1, 16);
            txtUsuarioo.Name = "txtUsuarioo";
            txtUsuarioo.Padding = new Padding(5);
            txtUsuarioo.Radius = 10;
            txtUsuarioo.RectColor = Color.Silver;
            txtUsuarioo.ShowText = false;
            txtUsuarioo.Size = new Size(179, 30);
            txtUsuarioo.Style = Sunny.UI.UIStyle.Custom;
            txtUsuarioo.SymbolColor = Color.FromArgb(57, 79, 71);
            txtUsuarioo.TabIndex = 66;
            txtUsuarioo.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsuarioo.Watermark = "";
            // 
            // txtTipodedocumentoo
            // 
            txtTipodedocumentoo.Cursor = Cursors.IBeam;
            txtTipodedocumentoo.Font = new Font("Segoe UI", 9F);
            txtTipodedocumentoo.Location = new Point(144, 64);
            txtTipodedocumentoo.Margin = new Padding(3, 2, 3, 2);
            txtTipodedocumentoo.MinimumSize = new Size(1, 16);
            txtTipodedocumentoo.Name = "txtTipodedocumentoo";
            txtTipodedocumentoo.Padding = new Padding(5);
            txtTipodedocumentoo.Radius = 10;
            txtTipodedocumentoo.RectColor = Color.Silver;
            txtTipodedocumentoo.ShowText = false;
            txtTipodedocumentoo.Size = new Size(168, 30);
            txtTipodedocumentoo.Style = Sunny.UI.UIStyle.Custom;
            txtTipodedocumentoo.SymbolColor = Color.FromArgb(57, 79, 71);
            txtTipodedocumentoo.TabIndex = 66;
            txtTipodedocumentoo.TextAlignment = ContentAlignment.MiddleLeft;
            txtTipodedocumentoo.Watermark = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(326, 42);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 73;
            label10.Text = "Usuario*";
            // 
            // txtFechaa
            // 
            txtFechaa.Cursor = Cursors.IBeam;
            txtFechaa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaa.Location = new Point(0, 64);
            txtFechaa.Margin = new Padding(3, 2, 3, 2);
            txtFechaa.MinimumSize = new Size(1, 16);
            txtFechaa.Name = "txtFechaa";
            txtFechaa.Padding = new Padding(5);
            txtFechaa.Radius = 10;
            txtFechaa.RectColor = Color.Silver;
            txtFechaa.ShowText = false;
            txtFechaa.Size = new Size(138, 30);
            txtFechaa.Style = Sunny.UI.UIStyle.Custom;
            txtFechaa.SymbolColor = Color.FromArgb(57, 79, 71);
            txtFechaa.TabIndex = 64;
            txtFechaa.TextAlignment = ContentAlignment.MiddleLeft;
            txtFechaa.Watermark = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(144, 40);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 72;
            label3.Text = "Tipo de Documento*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 40);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 71;
            label2.Text = "Fecha*";
            // 
            // lblTituloGrupo1
            // 
            lblTituloGrupo1.BackColor = Color.FromArgb(8, 92, 63);
            lblTituloGrupo1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrupo1.ForeColor = Color.Transparent;
            lblTituloGrupo1.Location = new Point(-3, 0);
            lblTituloGrupo1.Name = "lblTituloGrupo1";
            lblTituloGrupo1.Size = new Size(524, 26);
            lblTituloGrupo1.TabIndex = 74;
            lblTituloGrupo1.Text = "Información de la Compra";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtnumerodocumentoo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtnombreproveedoorr);
            groupBox2.Controls.Add(txtdocproveedoorr);
            groupBox2.Controls.Add(lblTituloGrupo2);
            groupBox2.FillColor = Color.White;
            groupBox2.FillColor2 = Color.White;
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox2.Location = new Point(2, 239);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.MinimumSize = new Size(1, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Radius = 1;
            groupBox2.RectColor = Color.White;
            groupBox2.Size = new Size(520, 137);
            groupBox2.TabIndex = 64;
            groupBox2.Text = null;
            groupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            groupBox2.Click += groupBox2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(212, 34);
            label12.Name = "label12";
            label12.Size = new Size(103, 20);
            label12.TabIndex = 75;
            label12.Text = "Razón Social*";
            // 
            // txtnumerodocumentoo
            // 
            txtnumerodocumentoo.Cursor = Cursors.IBeam;
            txtnumerodocumentoo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnumerodocumentoo.Location = new Point(395, 27);
            txtnumerodocumentoo.Margin = new Padding(3, 2, 3, 2);
            txtnumerodocumentoo.MinimumSize = new Size(1, 16);
            txtnumerodocumentoo.Name = "txtnumerodocumentoo";
            txtnumerodocumentoo.Padding = new Padding(5);
            txtnumerodocumentoo.Radius = 10;
            txtnumerodocumentoo.RectColor = Color.Silver;
            txtnumerodocumentoo.ShowText = false;
            txtnumerodocumentoo.Size = new Size(52, 30);
            txtnumerodocumentoo.Style = Sunny.UI.UIStyle.Custom;
            txtnumerodocumentoo.SymbolColor = Color.FromArgb(57, 79, 71);
            txtnumerodocumentoo.TabIndex = 65;
            txtnumerodocumentoo.TextAlignment = ContentAlignment.MiddleLeft;
            txtnumerodocumentoo.Visible = false;
            txtnumerodocumentoo.Watermark = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(0, 34);
            label11.Name = "label11";
            label11.Size = new Size(185, 20);
            label11.TabIndex = 74;
            label11.Text = "Número del Documento*";
            // 
            // txtnombreproveedoorr
            // 
            txtnombreproveedoorr.Cursor = Cursors.IBeam;
            txtnombreproveedoorr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombreproveedoorr.Location = new Point(212, 61);
            txtnombreproveedoorr.Margin = new Padding(3, 2, 3, 2);
            txtnombreproveedoorr.MinimumSize = new Size(1, 16);
            txtnombreproveedoorr.Name = "txtnombreproveedoorr";
            txtnombreproveedoorr.Padding = new Padding(5);
            txtnombreproveedoorr.Radius = 10;
            txtnombreproveedoorr.RectColor = Color.Silver;
            txtnombreproveedoorr.ShowText = false;
            txtnombreproveedoorr.Size = new Size(235, 30);
            txtnombreproveedoorr.Style = Sunny.UI.UIStyle.Custom;
            txtnombreproveedoorr.SymbolColor = Color.FromArgb(57, 79, 71);
            txtnombreproveedoorr.TabIndex = 66;
            txtnombreproveedoorr.TextAlignment = ContentAlignment.MiddleLeft;
            txtnombreproveedoorr.Watermark = "";
            // 
            // txtdocproveedoorr
            // 
            txtdocproveedoorr.Cursor = Cursors.IBeam;
            txtdocproveedoorr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdocproveedoorr.Location = new Point(3, 61);
            txtdocproveedoorr.Margin = new Padding(3, 2, 3, 2);
            txtdocproveedoorr.MinimumSize = new Size(1, 16);
            txtdocproveedoorr.Name = "txtdocproveedoorr";
            txtdocproveedoorr.Padding = new Padding(5);
            txtdocproveedoorr.Radius = 10;
            txtdocproveedoorr.RectColor = Color.Silver;
            txtdocproveedoorr.ShowText = false;
            txtdocproveedoorr.Size = new Size(153, 30);
            txtdocproveedoorr.Style = Sunny.UI.UIStyle.Custom;
            txtdocproveedoorr.SymbolColor = Color.FromArgb(57, 79, 71);
            txtdocproveedoorr.TabIndex = 64;
            txtdocproveedoorr.TextAlignment = ContentAlignment.MiddleLeft;
            txtdocproveedoorr.Watermark = "";
            // 
            // lblTituloGrupo2
            // 
            lblTituloGrupo2.BackColor = Color.FromArgb(8, 92, 63);
            lblTituloGrupo2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrupo2.ForeColor = Color.White;
            lblTituloGrupo2.Location = new Point(0, 1);
            lblTituloGrupo2.Name = "lblTituloGrupo2";
            lblTituloGrupo2.Size = new Size(520, 21);
            lblTituloGrupo2.TabIndex = 76;
            // 
            // txtmontototall
            // 
            txtmontototall.BackColor = Color.White;
            txtmontototall.Cursor = Cursors.IBeam;
            txtmontototall.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmontototall.Location = new Point(294, 408);
            txtmontototall.Margin = new Padding(3, 2, 3, 2);
            txtmontototall.MinimumSize = new Size(1, 16);
            txtmontototall.Name = "txtmontototall";
            txtmontototall.Padding = new Padding(5);
            txtmontototall.Radius = 10;
            txtmontototall.RectColor = Color.Silver;
            txtmontototall.ShowText = false;
            txtmontototall.Size = new Size(85, 30);
            txtmontototall.Style = Sunny.UI.UIStyle.Custom;
            txtmontototall.SymbolColor = Color.FromArgb(57, 79, 71);
            txtmontototall.TabIndex = 67;
            txtmontototall.Text = "0";
            txtmontototall.TextAlignment = ContentAlignment.MiddleLeft;
            txtmontototall.Watermark = "";
            // 
            // btndescargarpdff
            // 
            btndescargarpdff.FillColor = Color.Red;
            btndescargarpdff.FillDisableColor = Color.FromArgb(224, 224, 224);
            btndescargarpdff.FillHoverColor = Color.FromArgb(8, 92, 63);
            btndescargarpdff.FillPressColor = Color.Silver;
            btndescargarpdff.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndescargarpdff.Location = new Point(395, 408);
            btndescargarpdff.MinimumSize = new Size(1, 1);
            btndescargarpdff.Name = "btndescargarpdff";
            btndescargarpdff.Radius = 15;
            btndescargarpdff.RectColor = Color.White;
            btndescargarpdff.RectDisableColor = Color.White;
            btndescargarpdff.RectHoverColor = Color.White;
            btndescargarpdff.RectPressColor = Color.White;
            btndescargarpdff.RectSelectedColor = Color.White;
            btndescargarpdff.ShowFocusLine = true;
            btndescargarpdff.Size = new Size(125, 30);
            btndescargarpdff.Style = Sunny.UI.UIStyle.Custom;
            btndescargarpdff.Symbol = 61889;
            btndescargarpdff.TabIndex = 68;
            btndescargarpdff.Text = "Descargar PDF";
            btndescargarpdff.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btndescargarpdff.Click += btndescargarpdff_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.FromArgb(8, 92, 63);
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(2, 1);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(521, 36);
            bigLabel1.TabIndex = 69;
            bigLabel1.Text = "Detalles de la Compra";
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.ImageAlign = ContentAlignment.MiddleLeft;
            label16.Location = new Point(2, 44);
            label16.Name = "label16";
            label16.Size = new Size(182, 31);
            label16.TabIndex = 70;
            label16.Text = "Número del Documento:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(57, 79, 71);
            label4.Location = new Point(179, 408);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 71;
            label4.Text = "Monto Total:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnbuscarr
            // 
            btnbuscarr.BackColor = Color.White;
            btnbuscarr.FillColor = Color.FromArgb(0, 192, 0);
            btnbuscarr.FillColor2 = Color.Chocolate;
            btnbuscarr.FillDisableColor = Color.White;
            btnbuscarr.FillHoverColor = Color.FromArgb(11, 127, 87);
            btnbuscarr.FillPressColor = Color.Silver;
            btnbuscarr.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuscarr.ForeColor = Color.Snow;
            btnbuscarr.Location = new Point(314, 44);
            btnbuscarr.MinimumSize = new Size(1, 1);
            btnbuscarr.Name = "btnbuscarr";
            btnbuscarr.Radius = 15;
            btnbuscarr.RectColor = Color.White;
            btnbuscarr.RectDisableColor = Color.White;
            btnbuscarr.RectHoverColor = Color.White;
            btnbuscarr.RectPressColor = Color.White;
            btnbuscarr.RectSelectedColor = Color.White;
            btnbuscarr.ShowFocusLine = true;
            btnbuscarr.Size = new Size(98, 31);
            btnbuscarr.Style = Sunny.UI.UIStyle.Custom;
            btnbuscarr.Symbol = 61442;
            btnbuscarr.TabIndex = 81;
            btnbuscarr.Text = "Buscar";
            btnbuscarr.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnbuscarr.Click += btnbuscarr_Click;
            btnbuscarr.KeyDown += btnbuscarr_KeyDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeight = 44;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dataGridView1.CornerRadius = 1;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle7.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("Segoe UI", 9.5F);
            dataGridView1.GridColor = Color.White;
            dataGridView1.HeaderBack = Color.FromArgb(8, 92, 63);
            dataGridView1.Location = new Point(2, 16);
            dataGridView1.MultiSelect = false;
            dataGridView1.MutedColor = Color.White;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowRadius = 1;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle8.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 56;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(611, 488);
            dataGridView1.TabIndex = 65;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // Producto
            // 
            Producto.FillWeight = 92F;
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 92;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioCompra
            // 
            PrecioCompra.FillWeight = 156F;
            PrecioCompra.HeaderText = "Precio de la Compra";
            PrecioCompra.MinimumWidth = 156;
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 89F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 89;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // SubTotal
            // 
            SubTotal.FillWeight = 90F;
            SubTotal.HeaderText = "Sub Total";
            SubTotal.MinimumWidth = 90;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.White;
            uiGroupBox1.Controls.Add(dataGridView1);
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(526, -15);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.RectColor = Color.Gray;
            uiGroupBox1.Size = new Size(616, 522);
            uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            uiGroupBox1.TabIndex = 82;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiGroupBox1.Click += uiGroupBox1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(8, 92, 63);
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 372);
            label5.Name = "label5";
            label5.Size = new Size(520, 23);
            label5.TabIndex = 83;
            // 
            // Frm_DetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 529);
            Controls.Add(label5);
            Controls.Add(uiGroupBox1);
            Controls.Add(btnbuscarr);
            Controls.Add(label4);
            Controls.Add(label16);
            Controls.Add(bigLabel1);
            Controls.Add(btndescargarpdff);
            Controls.Add(txtmontototall);
            Controls.Add(txtbusquedaa);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnlimpiarr);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_DetalleCompra";
            Text = "  ";
            Load += Frm_DetalleCompra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Sunny.UI.UITextBox txtbusquedaa;
        private Sunny.UI.UISymbolButton btnlimpiarr;
        private Sunny.UI.UIPanel groupBox1;
        private Label lblTituloGrupo1;
        private Sunny.UI.UITextBox txtUsuarioo;
        private Sunny.UI.UITextBox txtTipodedocumentoo;
        private Sunny.UI.UITextBox txtFechaa;
        private Sunny.UI.UIPanel groupBox2;
        private Sunny.UI.UITextBox txtnumerodocumentoo;
        private Sunny.UI.UITextBox txtnombreproveedoorr;
        private Sunny.UI.UITextBox txtdocproveedoorr;
        // private TextBox txtmontototall;
        private Sunny.UI.UITextBox txtmontototall;
        // private Button btndescargarpdff;
        private Sunny.UI.UISymbolButton btndescargarpdff; 
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Label label16;
        private Label label2;
        private Label label3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label4;
        private Sunny.UI.UISymbolButton btnbuscarr;
        private ModernControls.ModernGrid dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Label label5;
        private Label lblTituloGrupo2;
    }
}