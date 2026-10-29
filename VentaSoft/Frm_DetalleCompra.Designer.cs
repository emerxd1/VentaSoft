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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            cardBusqueda = new Sunny.UI.UIPanel();
            label16 = new Label();
            txtbusquedaa = new Sunny.UI.UITextBox();
            btnbuscarr = new Sunny.UI.UISymbolButton();
            btnlimpiarr = new Sunny.UI.UISymbolButton();
            groupBox1 = new Sunny.UI.UIPanel();
            lblTituloGrupo1 = new Label();
            label2 = new Label();
            txtFechaa = new Sunny.UI.UITextBox();
            label3 = new Label();
            txtTipodedocumentoo = new Sunny.UI.UITextBox();
            label10 = new Label();
            txtUsuarioo = new Sunny.UI.UITextBox();
            groupBox2 = new Sunny.UI.UIPanel();
            lblTituloGrupo2 = new Label();
            label11 = new Label();
            txtdocproveedoorr = new Sunny.UI.UITextBox();
            label12 = new Label();
            txtnombreproveedoorr = new Sunny.UI.UITextBox();
            txtnumerodocumentoo = new TextBox();
            uiPanel1 = new Sunny.UI.UIPanel();
            lblGridTitulo = new Label();
            dataGridView1 = new ModernControls.ModernGrid();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            linePie = new Label();
            btndescargarpdff = new Sunny.UI.UISymbolButton();
            label4 = new Label();
            txtmontototall = new Sunny.UI.UITextBox();
            cardBusqueda.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(242, 245, 245);
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(20, 32, 30);
            lblTitulo.Location = new Point(28, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1373, 34);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Detalle de la compra";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.FromArgb(242, 245, 245);
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(70, 86, 79);
            lblSubtitulo.Location = new Point(30, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(1563, 20);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Consulta un documento registrado y descárgalo en PDF.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cardBusqueda
            // 
            cardBusqueda.BackColor = Color.FromArgb(242, 245, 245);
            cardBusqueda.Controls.Add(label16);
            cardBusqueda.Controls.Add(txtbusquedaa);
            cardBusqueda.Controls.Add(btnbuscarr);
            cardBusqueda.Controls.Add(btnlimpiarr);
            cardBusqueda.FillColor = Color.White;
            cardBusqueda.FillColor2 = Color.White;
            cardBusqueda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardBusqueda.Location = new Point(28, 76);
            cardBusqueda.Margin = new Padding(4, 5, 4, 5);
            cardBusqueda.MinimumSize = new Size(1, 1);
            cardBusqueda.Name = "cardBusqueda";
            cardBusqueda.Radius = 10;
            cardBusqueda.RectColor = Color.FromArgb(221, 228, 227);
            cardBusqueda.Size = new Size(404, 80);
            cardBusqueda.TabIndex = 3;
            cardBusqueda.Text = null;
            cardBusqueda.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(70, 86, 79);
            label16.Location = new Point(16, 10);
            label16.Name = "label16";
            label16.Size = new Size(372, 18);
            label16.TabIndex = 4;
            label16.Text = "Número de la compra";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtbusquedaa
            // 
            txtbusquedaa.BackColor = Color.White;
            txtbusquedaa.Cursor = Cursors.IBeam;
            txtbusquedaa.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbusquedaa.ForeColor = Color.FromArgb(20, 32, 30);
            txtbusquedaa.Location = new Point(16, 32);
            txtbusquedaa.Margin = new Padding(3, 2, 3, 2);
            txtbusquedaa.MinimumSize = new Size(1, 16);
            txtbusquedaa.Name = "txtbusquedaa";
            txtbusquedaa.Padding = new Padding(5);
            txtbusquedaa.Radius = 6;
            txtbusquedaa.RectColor = Color.FromArgb(201, 211, 209);
            txtbusquedaa.ShowText = false;
            txtbusquedaa.Size = new Size(170, 34);
            txtbusquedaa.Style = Sunny.UI.UIStyle.Custom;
            txtbusquedaa.TabIndex = 5;
            txtbusquedaa.TextAlignment = ContentAlignment.MiddleLeft;
            txtbusquedaa.Watermark = "EJ: C0001";
            txtbusquedaa.KeyDown += txtbusquedaa_KeyDown;
            // 
            // btnbuscarr
            // 
            btnbuscarr.BackColor = Color.White;
            btnbuscarr.Cursor = Cursors.Hand;
            btnbuscarr.FillColor = Color.FromArgb(15, 118, 110);
            btnbuscarr.FillDisableColor = Color.FromArgb(230, 236, 235);
            btnbuscarr.FillHoverColor = Color.FromArgb(11, 94, 88);
            btnbuscarr.FillPressColor = Color.FromArgb(8, 76, 71);
            btnbuscarr.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbuscarr.ForeDisableColor = Color.FromArgb(95, 111, 107);
            btnbuscarr.Location = new Point(194, 32);
            btnbuscarr.MinimumSize = new Size(1, 1);
            btnbuscarr.Name = "btnbuscarr";
            btnbuscarr.Radius = 6;
            btnbuscarr.RectColor = Color.FromArgb(15, 118, 110);
            btnbuscarr.RectDisableColor = Color.FromArgb(230, 236, 235);
            btnbuscarr.RectHoverColor = Color.FromArgb(11, 94, 88);
            btnbuscarr.RectPressColor = Color.FromArgb(8, 76, 71);
            btnbuscarr.RectSelectedColor = Color.FromArgb(15, 118, 110);
            btnbuscarr.Size = new Size(96, 34);
            btnbuscarr.Style = Sunny.UI.UIStyle.Custom;
            btnbuscarr.Symbol = 61442;
            btnbuscarr.SymbolSize = 18;
            btnbuscarr.TabIndex = 6;
            btnbuscarr.Text = "Buscar";
            btnbuscarr.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnbuscarr.Click += btnbuscarr_Click;
            // 
            // btnlimpiarr
            // 
            btnlimpiarr.BackColor = Color.White;
            btnlimpiarr.Cursor = Cursors.Hand;
            btnlimpiarr.FillColor = Color.White;
            btnlimpiarr.FillDisableColor = Color.FromArgb(230, 236, 235);
            btnlimpiarr.FillHoverColor = Color.FromArgb(238, 246, 245);
            btnlimpiarr.FillPressColor = Color.FromArgb(223, 243, 239);
            btnlimpiarr.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlimpiarr.ForeColor = Color.FromArgb(20, 32, 30);
            btnlimpiarr.ForeDisableColor = Color.FromArgb(95, 111, 107);
            btnlimpiarr.ForeHoverColor = Color.FromArgb(20, 32, 30);
            btnlimpiarr.ForePressColor = Color.FromArgb(20, 32, 30);
            btnlimpiarr.Location = new Point(298, 32);
            btnlimpiarr.MinimumSize = new Size(1, 1);
            btnlimpiarr.Name = "btnlimpiarr";
            btnlimpiarr.Radius = 6;
            btnlimpiarr.RectColor = Color.FromArgb(201, 211, 209);
            btnlimpiarr.RectDisableColor = Color.FromArgb(221, 228, 227);
            btnlimpiarr.RectHoverColor = Color.FromArgb(15, 118, 110);
            btnlimpiarr.RectPressColor = Color.FromArgb(8, 76, 71);
            btnlimpiarr.RectSelectedColor = Color.FromArgb(201, 211, 209);
            btnlimpiarr.Size = new Size(90, 34);
            btnlimpiarr.Style = Sunny.UI.UIStyle.Custom;
            btnlimpiarr.Symbol = 61741;
            btnlimpiarr.SymbolColor = Color.FromArgb(15, 118, 110);
            btnlimpiarr.SymbolHoverColor = Color.FromArgb(15, 118, 110);
            btnlimpiarr.SymbolPressColor = Color.FromArgb(15, 118, 110);
            btnlimpiarr.SymbolSize = 18;
            btnlimpiarr.TabIndex = 7;
            btnlimpiarr.Text = "Limpiar";
            btnlimpiarr.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlimpiarr.Click += btnlimpiarr_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(242, 245, 245);
            groupBox1.Controls.Add(lblTituloGrupo1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtFechaa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTipodedocumentoo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtUsuarioo);
            groupBox1.FillColor = Color.White;
            groupBox1.FillColor2 = Color.White;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 164);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Radius = 10;
            groupBox1.RectColor = Color.FromArgb(221, 228, 227);
            groupBox1.Size = new Size(404, 164);
            groupBox1.TabIndex = 8;
            groupBox1.Text = null;
            groupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrupo1
            // 
            lblTituloGrupo1.BackColor = Color.White;
            lblTituloGrupo1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloGrupo1.ForeColor = Color.FromArgb(20, 32, 30);
            lblTituloGrupo1.Location = new Point(16, 10);
            lblTituloGrupo1.Name = "lblTituloGrupo1";
            lblTituloGrupo1.Size = new Size(372, 24);
            lblTituloGrupo1.TabIndex = 9;
            lblTituloGrupo1.Text = "Información de la compra";
            lblTituloGrupo1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(70, 86, 79);
            label2.Location = new Point(16, 40);
            label2.Name = "label2";
            label2.Size = new Size(178, 18);
            label2.TabIndex = 10;
            label2.Text = "Fecha";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFechaa
            // 
            txtFechaa.BackColor = Color.White;
            txtFechaa.Cursor = Cursors.IBeam;
            txtFechaa.FillReadOnlyColor = Color.White;
            txtFechaa.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaa.ForeColor = Color.FromArgb(20, 32, 30);
            txtFechaa.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            txtFechaa.ImeMode = ImeMode.Disable;
            txtFechaa.Location = new Point(16, 58);
            txtFechaa.Margin = new Padding(3, 2, 3, 2);
            txtFechaa.MinimumSize = new Size(1, 16);
            txtFechaa.Name = "txtFechaa";
            txtFechaa.Padding = new Padding(5);
            txtFechaa.Radius = 6;
            txtFechaa.ReadOnly = true;
            txtFechaa.RectColor = Color.FromArgb(201, 211, 209);
            txtFechaa.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            txtFechaa.ShowText = false;
            txtFechaa.Size = new Size(178, 34);
            txtFechaa.Style = Sunny.UI.UIStyle.Custom;
            txtFechaa.TabIndex = 11;
            txtFechaa.TextAlignment = ContentAlignment.MiddleLeft;
            txtFechaa.Watermark = "";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(70, 86, 79);
            label3.Location = new Point(210, 40);
            label3.Name = "label3";
            label3.Size = new Size(178, 18);
            label3.TabIndex = 12;
            label3.Text = "Tipo de documento";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTipodedocumentoo
            // 
            txtTipodedocumentoo.BackColor = Color.White;
            txtTipodedocumentoo.Cursor = Cursors.IBeam;
            txtTipodedocumentoo.FillReadOnlyColor = Color.White;
            txtTipodedocumentoo.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipodedocumentoo.ForeColor = Color.FromArgb(20, 32, 30);
            txtTipodedocumentoo.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            txtTipodedocumentoo.ImeMode = ImeMode.Disable;
            txtTipodedocumentoo.Location = new Point(210, 58);
            txtTipodedocumentoo.Margin = new Padding(3, 2, 3, 2);
            txtTipodedocumentoo.MinimumSize = new Size(1, 16);
            txtTipodedocumentoo.Name = "txtTipodedocumentoo";
            txtTipodedocumentoo.Padding = new Padding(5);
            txtTipodedocumentoo.Radius = 6;
            txtTipodedocumentoo.ReadOnly = true;
            txtTipodedocumentoo.RectColor = Color.FromArgb(201, 211, 209);
            txtTipodedocumentoo.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            txtTipodedocumentoo.ShowText = false;
            txtTipodedocumentoo.Size = new Size(178, 34);
            txtTipodedocumentoo.Style = Sunny.UI.UIStyle.Custom;
            txtTipodedocumentoo.TabIndex = 13;
            txtTipodedocumentoo.TextAlignment = ContentAlignment.MiddleLeft;
            txtTipodedocumentoo.Watermark = "";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(70, 86, 79);
            label10.Location = new Point(16, 98);
            label10.Name = "label10";
            label10.Size = new Size(372, 18);
            label10.TabIndex = 14;
            label10.Text = "Usuario";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsuarioo
            // 
            txtUsuarioo.BackColor = Color.White;
            txtUsuarioo.Cursor = Cursors.IBeam;
            txtUsuarioo.FillReadOnlyColor = Color.White;
            txtUsuarioo.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuarioo.ForeColor = Color.FromArgb(20, 32, 30);
            txtUsuarioo.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            txtUsuarioo.ImeMode = ImeMode.Disable;
            txtUsuarioo.Location = new Point(16, 116);
            txtUsuarioo.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioo.MinimumSize = new Size(1, 16);
            txtUsuarioo.Name = "txtUsuarioo";
            txtUsuarioo.Padding = new Padding(5);
            txtUsuarioo.Radius = 6;
            txtUsuarioo.ReadOnly = true;
            txtUsuarioo.RectColor = Color.FromArgb(201, 211, 209);
            txtUsuarioo.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            txtUsuarioo.ShowText = false;
            txtUsuarioo.Size = new Size(372, 34);
            txtUsuarioo.Style = Sunny.UI.UIStyle.Custom;
            txtUsuarioo.TabIndex = 15;
            txtUsuarioo.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsuarioo.Watermark = "";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(242, 245, 245);
            groupBox2.Controls.Add(lblTituloGrupo2);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtdocproveedoorr);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtnombreproveedoorr);
            groupBox2.Controls.Add(txtnumerodocumentoo);
            groupBox2.FillColor = Color.White;
            groupBox2.FillColor2 = Color.White;
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 336);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.MinimumSize = new Size(1, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Radius = 10;
            groupBox2.RectColor = Color.FromArgb(221, 228, 227);
            groupBox2.Size = new Size(404, 164);
            groupBox2.TabIndex = 16;
            groupBox2.Text = null;
            groupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTituloGrupo2
            // 
            lblTituloGrupo2.BackColor = Color.White;
            lblTituloGrupo2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloGrupo2.ForeColor = Color.FromArgb(20, 32, 30);
            lblTituloGrupo2.Location = new Point(16, 10);
            lblTituloGrupo2.Name = "lblTituloGrupo2";
            lblTituloGrupo2.Size = new Size(372, 24);
            lblTituloGrupo2.TabIndex = 17;
            lblTituloGrupo2.Text = "Proveedor";
            lblTituloGrupo2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(70, 86, 79);
            label11.Location = new Point(16, 40);
            label11.Name = "label11";
            label11.Size = new Size(372, 18);
            label11.TabIndex = 18;
            label11.Text = "RUC";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtdocproveedoorr
            // 
            txtdocproveedoorr.BackColor = Color.White;
            txtdocproveedoorr.Cursor = Cursors.IBeam;
            txtdocproveedoorr.FillReadOnlyColor = Color.White;
            txtdocproveedoorr.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdocproveedoorr.ForeColor = Color.FromArgb(20, 32, 30);
            txtdocproveedoorr.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            txtdocproveedoorr.ImeMode = ImeMode.Disable;
            txtdocproveedoorr.Location = new Point(16, 58);
            txtdocproveedoorr.Margin = new Padding(3, 2, 3, 2);
            txtdocproveedoorr.MinimumSize = new Size(1, 16);
            txtdocproveedoorr.Name = "txtdocproveedoorr";
            txtdocproveedoorr.Padding = new Padding(5);
            txtdocproveedoorr.Radius = 6;
            txtdocproveedoorr.ReadOnly = true;
            txtdocproveedoorr.RectColor = Color.FromArgb(201, 211, 209);
            txtdocproveedoorr.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            txtdocproveedoorr.ShowText = false;
            txtdocproveedoorr.Size = new Size(372, 34);
            txtdocproveedoorr.Style = Sunny.UI.UIStyle.Custom;
            txtdocproveedoorr.TabIndex = 19;
            txtdocproveedoorr.TextAlignment = ContentAlignment.MiddleLeft;
            txtdocproveedoorr.Watermark = "";
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(70, 86, 79);
            label12.Location = new Point(16, 98);
            label12.Name = "label12";
            label12.Size = new Size(372, 18);
            label12.TabIndex = 20;
            label12.Text = "Razón social";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtnombreproveedoorr
            // 
            txtnombreproveedoorr.BackColor = Color.White;
            txtnombreproveedoorr.Cursor = Cursors.IBeam;
            txtnombreproveedoorr.FillReadOnlyColor = Color.White;
            txtnombreproveedoorr.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombreproveedoorr.ForeColor = Color.FromArgb(20, 32, 30);
            txtnombreproveedoorr.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            txtnombreproveedoorr.ImeMode = ImeMode.Disable;
            txtnombreproveedoorr.Location = new Point(16, 116);
            txtnombreproveedoorr.Margin = new Padding(3, 2, 3, 2);
            txtnombreproveedoorr.MinimumSize = new Size(1, 16);
            txtnombreproveedoorr.Name = "txtnombreproveedoorr";
            txtnombreproveedoorr.Padding = new Padding(5);
            txtnombreproveedoorr.Radius = 6;
            txtnombreproveedoorr.ReadOnly = true;
            txtnombreproveedoorr.RectColor = Color.FromArgb(201, 211, 209);
            txtnombreproveedoorr.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            txtnombreproveedoorr.ShowText = false;
            txtnombreproveedoorr.Size = new Size(372, 34);
            txtnombreproveedoorr.Style = Sunny.UI.UIStyle.Custom;
            txtnombreproveedoorr.TabIndex = 21;
            txtnombreproveedoorr.TextAlignment = ContentAlignment.MiddleLeft;
            txtnombreproveedoorr.Watermark = "";
            // 
            // txtnumerodocumentoo
            // 
            txtnumerodocumentoo.Location = new Point(300, 10);
            txtnumerodocumentoo.Name = "txtnumerodocumentoo";
            txtnumerodocumentoo.Size = new Size(40, 25);
            txtnumerodocumentoo.TabIndex = 22;
            txtnumerodocumentoo.Visible = false;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.BackColor = Color.FromArgb(242, 245, 245);
            uiPanel1.Controls.Add(lblGridTitulo);
            uiPanel1.Controls.Add(dataGridView1);
            uiPanel1.Controls.Add(linePie);
            uiPanel1.Controls.Add(btndescargarpdff);
            uiPanel1.Controls.Add(label4);
            uiPanel1.Controls.Add(txtmontototall);
            uiPanel1.FillColor = Color.White;
            uiPanel1.FillColor2 = Color.White;
            uiPanel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiPanel1.Location = new Point(444, 76);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 10;
            uiPanel1.RectColor = Color.FromArgb(221, 228, 227);
            uiPanel1.Size = new Size(844, 564);
            uiPanel1.TabIndex = 23;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblGridTitulo
            // 
            lblGridTitulo.BackColor = Color.White;
            lblGridTitulo.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGridTitulo.ForeColor = Color.FromArgb(20, 32, 30);
            lblGridTitulo.Location = new Point(20, 14);
            lblGridTitulo.Name = "lblGridTitulo";
            lblGridTitulo.Size = new Size(400, 24);
            lblGridTitulo.TabIndex = 24;
            lblGridTitulo.Text = "Productos de la compra";
            lblGridTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(70, 86, 79);
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 44;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("Segoe UI", 9.5F);
            dataGridView1.GridColor = Color.White;
            dataGridView1.HeaderBack = Color.FromArgb(246, 248, 248);
            dataGridView1.LineColor = Color.FromArgb(221, 228, 227);
            dataGridView1.Location = new Point(8, 48);
            dataGridView1.MultiSelect = false;
            dataGridView1.MutedColor = Color.FromArgb(70, 86, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowRadius = 6;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 56;
            dataGridView1.SelectionColor = Color.FromArgb(223, 243, 239);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.Size = new Size(828, 428);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged_1;
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
            PrecioCompra.FillWeight = 140F;
            PrecioCompra.HeaderText = "Precio de compra";
            PrecioCompra.MinimumWidth = 140;
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
            SubTotal.HeaderText = "Sub total";
            SubTotal.MinimumWidth = 90;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // linePie
            // 
            linePie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linePie.BackColor = Color.FromArgb(221, 228, 227);
            linePie.Location = new Point(1, 480);
            linePie.Name = "linePie";
            linePie.Size = new Size(842, 1);
            linePie.TabIndex = 26;
            // 
            // btndescargarpdff
            // 
            btndescargarpdff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btndescargarpdff.BackColor = Color.White;
            btndescargarpdff.Cursor = Cursors.Hand;
            btndescargarpdff.FillColor = Color.FromArgb(192, 255, 192);
            btndescargarpdff.FillDisableColor = Color.FromArgb(230, 236, 235);
            btndescargarpdff.FillHoverColor = Color.FromArgb(238, 246, 245);
            btndescargarpdff.FillPressColor = Color.FromArgb(223, 243, 239);
            btndescargarpdff.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndescargarpdff.ForeColor = Color.FromArgb(20, 32, 30);
            btndescargarpdff.ForeDisableColor = Color.FromArgb(95, 111, 107);
            btndescargarpdff.ForeHoverColor = Color.FromArgb(20, 32, 30);
            btndescargarpdff.ForePressColor = Color.FromArgb(20, 32, 30);
            btndescargarpdff.Location = new Point(20, 498);
            btndescargarpdff.MinimumSize = new Size(1, 1);
            btndescargarpdff.Name = "btndescargarpdff";
            btndescargarpdff.Radius = 6;
            btndescargarpdff.RectColor = Color.FromArgb(201, 211, 209);
            btndescargarpdff.RectDisableColor = Color.FromArgb(221, 228, 227);
            btndescargarpdff.RectHoverColor = Color.FromArgb(15, 118, 110);
            btndescargarpdff.RectPressColor = Color.FromArgb(8, 76, 71);
            btndescargarpdff.RectSelectedColor = Color.FromArgb(201, 211, 209);
            btndescargarpdff.Size = new Size(176, 44);
            btndescargarpdff.Style = Sunny.UI.UIStyle.Custom;
            btndescargarpdff.Symbol = 61465;
            btndescargarpdff.SymbolColor = Color.FromArgb(180, 35, 24);
            btndescargarpdff.SymbolHoverColor = Color.FromArgb(180, 35, 24);
            btndescargarpdff.SymbolPressColor = Color.FromArgb(180, 35, 24);
            btndescargarpdff.SymbolSize = 18;
            btndescargarpdff.TabIndex = 27;
            btndescargarpdff.Text = "Descargar PDF";
            btndescargarpdff.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndescargarpdff.Click += btndescargarpdff_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(70, 86, 79);
            label4.Location = new Point(620, 490);
            label4.Name = "label4";
            label4.Size = new Size(204, 18);
            label4.TabIndex = 28;
            label4.Text = "Monto total";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtmontototall
            // 
            txtmontototall.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtmontototall.BackColor = Color.White;
            txtmontototall.Cursor = Cursors.IBeam;
            txtmontototall.FillReadOnlyColor = Color.White;
            txtmontototall.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmontototall.ForeColor = Color.FromArgb(20, 32, 30);
            txtmontototall.ForeReadOnlyColor = Color.FromArgb(11, 94, 88);
            txtmontototall.ImeMode = ImeMode.Disable;
            txtmontototall.Location = new Point(620, 508);
            txtmontototall.Margin = new Padding(3, 2, 3, 2);
            txtmontototall.MinimumSize = new Size(1, 16);
            txtmontototall.Name = "txtmontototall";
            txtmontototall.Padding = new Padding(5);
            txtmontototall.Radius = 6;
            txtmontototall.ReadOnly = true;
            txtmontototall.RectColor = Color.FromArgb(201, 211, 209);
            txtmontototall.RectReadOnlyColor = Color.White;
            txtmontototall.ShowText = false;
            txtmontototall.Size = new Size(204, 40);
            txtmontototall.Style = Sunny.UI.UIStyle.Custom;
            txtmontototall.TabIndex = 29;
            txtmontototall.Text = "0";
            txtmontototall.TextAlignment = ContentAlignment.MiddleRight;
            txtmontototall.Watermark = "";
            // 
            // Frm_DetalleCompra
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(242, 245, 245);
            ClientSize = new Size(1316, 721);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(cardBusqueda);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(uiPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_DetalleCompra";
            Text = "Frm_DetalleCompra";
            Load += Frm_DetalleCompra_Load;
            cardBusqueda.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Sunny.UI.UIPanel cardBusqueda;
        private Label label16;
        private Sunny.UI.UITextBox txtbusquedaa;
        private Sunny.UI.UISymbolButton btnbuscarr;
        private Sunny.UI.UISymbolButton btnlimpiarr;
        private Sunny.UI.UIPanel groupBox1;
        private Label lblTituloGrupo1;
        private Label label2;
        private Sunny.UI.UITextBox txtFechaa;
        private Label label3;
        private Sunny.UI.UITextBox txtTipodedocumentoo;
        private Label label10;
        private Sunny.UI.UITextBox txtUsuarioo;
        private Sunny.UI.UIPanel groupBox2;
        private Label lblTituloGrupo2;
        private Label label11;
        private Sunny.UI.UITextBox txtdocproveedoorr;
        private Label label12;
        private Sunny.UI.UITextBox txtnombreproveedoorr;
        private TextBox txtnumerodocumentoo;
        private Sunny.UI.UIPanel uiPanel1;
        private Label lblGridTitulo;
        private ModernControls.ModernGrid dataGridView1;
        private Label linePie;
        private Sunny.UI.UISymbolButton btndescargarpdff;
        private Label label4;
        private Sunny.UI.UITextBox txtmontototall;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}