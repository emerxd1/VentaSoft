namespace Main
{
    partial class FrmDetallesVentas
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            uiGroupBox2 = new Sunny.UI.UIPanel();
            label6 = new Label();
            txtnumerodocumento = new TextBox();
            label11 = new Label();
            TxtDocCliente = new Sunny.UI.UITextBox();
            label5 = new Label();
            TxtNombre1Cli = new Sunny.UI.UITextBox();
            label17 = new Label();
            TxtNombre2Cli = new Sunny.UI.UITextBox();
            label19 = new Label();
            TxtApellido1Cli = new Sunny.UI.UITextBox();
            label18 = new Label();
            TxtApellido2Cli = new Sunny.UI.UITextBox();
            uiPanel1 = new Sunny.UI.UIPanel();
            lblGridTitulo = new Label();
            DgvData = new ModernControls.ModernGrid();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            linePie = new Label();
            btndescargarpdff = new Sunny.UI.UISymbolButton();
            label8 = new Label();
            label9 = new Label();
            TxtMontoPago = new Sunny.UI.UITextBox();
            label12 = new Label();
            TxtMontoCambio = new Sunny.UI.UITextBox();
            TxtMontoTotal = new Sunny.UI.UITextBox();
            cardBusqueda.SuspendLayout();
            groupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(242, 245, 245);
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(20, 32, 30);
            lblTitulo.Location = new Point(28, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1345, 34);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Detalle de la venta";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.FromArgb(242, 245, 245);
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(70, 86, 79);
            lblSubtitulo.Location = new Point(30, 46);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(1357, 20);
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
            label16.Text = "Número de la venta";
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
            txtbusquedaa.Watermark = "EJ: V0001";
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
            lblTituloGrupo1.Text = "Información de la venta";
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
            // uiGroupBox2
            // 
            uiGroupBox2.BackColor = Color.FromArgb(242, 245, 245);
            uiGroupBox2.Controls.Add(label6);
            uiGroupBox2.Controls.Add(txtnumerodocumento);
            uiGroupBox2.Controls.Add(label11);
            uiGroupBox2.Controls.Add(TxtDocCliente);
            uiGroupBox2.Controls.Add(label5);
            uiGroupBox2.Controls.Add(TxtNombre1Cli);
            uiGroupBox2.Controls.Add(label17);
            uiGroupBox2.Controls.Add(TxtNombre2Cli);
            uiGroupBox2.Controls.Add(label19);
            uiGroupBox2.Controls.Add(TxtApellido1Cli);
            uiGroupBox2.Controls.Add(label18);
            uiGroupBox2.Controls.Add(TxtApellido2Cli);
            uiGroupBox2.FillColor = Color.White;
            uiGroupBox2.FillColor2 = Color.White;
            uiGroupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiGroupBox2.Location = new Point(28, 336);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Radius = 10;
            uiGroupBox2.RectColor = Color.FromArgb(221, 228, 227);
            uiGroupBox2.Size = new Size(404, 222);
            uiGroupBox2.TabIndex = 16;
            uiGroupBox2.Text = null;
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(20, 32, 30);
            label6.Location = new Point(16, 10);
            label6.Name = "label6";
            label6.Size = new Size(372, 24);
            label6.TabIndex = 17;
            label6.Text = "Cliente";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(300, 10);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(40, 25);
            txtnumerodocumento.TabIndex = 18;
            txtnumerodocumento.Visible = false;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(70, 86, 79);
            label11.Location = new Point(16, 40);
            label11.Name = "label11";
            label11.Size = new Size(372, 18);
            label11.TabIndex = 19;
            label11.Text = "DNI";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtDocCliente
            // 
            TxtDocCliente.BackColor = Color.White;
            TxtDocCliente.Cursor = Cursors.IBeam;
            TxtDocCliente.FillReadOnlyColor = Color.White;
            TxtDocCliente.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDocCliente.ForeColor = Color.FromArgb(20, 32, 30);
            TxtDocCliente.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtDocCliente.ImeMode = ImeMode.Disable;
            TxtDocCliente.Location = new Point(16, 58);
            TxtDocCliente.Margin = new Padding(3, 2, 3, 2);
            TxtDocCliente.MinimumSize = new Size(1, 16);
            TxtDocCliente.Name = "TxtDocCliente";
            TxtDocCliente.Padding = new Padding(5);
            TxtDocCliente.Radius = 6;
            TxtDocCliente.ReadOnly = true;
            TxtDocCliente.RectColor = Color.FromArgb(201, 211, 209);
            TxtDocCliente.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtDocCliente.ShowText = false;
            TxtDocCliente.Size = new Size(372, 34);
            TxtDocCliente.Style = Sunny.UI.UIStyle.Custom;
            TxtDocCliente.TabIndex = 20;
            TxtDocCliente.TextAlignment = ContentAlignment.MiddleLeft;
            TxtDocCliente.Watermark = "";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(70, 86, 79);
            label5.Location = new Point(16, 98);
            label5.Name = "label5";
            label5.Size = new Size(178, 18);
            label5.TabIndex = 21;
            label5.Text = "Primer nombre";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNombre1Cli
            // 
            TxtNombre1Cli.BackColor = Color.White;
            TxtNombre1Cli.Cursor = Cursors.IBeam;
            TxtNombre1Cli.FillReadOnlyColor = Color.White;
            TxtNombre1Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre1Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtNombre1Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtNombre1Cli.ImeMode = ImeMode.Disable;
            TxtNombre1Cli.Location = new Point(16, 116);
            TxtNombre1Cli.Margin = new Padding(3, 2, 3, 2);
            TxtNombre1Cli.MinimumSize = new Size(1, 16);
            TxtNombre1Cli.Name = "TxtNombre1Cli";
            TxtNombre1Cli.Padding = new Padding(5);
            TxtNombre1Cli.Radius = 6;
            TxtNombre1Cli.ReadOnly = true;
            TxtNombre1Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtNombre1Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtNombre1Cli.ShowText = false;
            TxtNombre1Cli.Size = new Size(178, 34);
            TxtNombre1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre1Cli.TabIndex = 22;
            TxtNombre1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre1Cli.Watermark = "";
            // 
            // label17
            // 
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(70, 86, 79);
            label17.Location = new Point(210, 98);
            label17.Name = "label17";
            label17.Size = new Size(178, 18);
            label17.TabIndex = 23;
            label17.Text = "Segundo nombre";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtNombre2Cli
            // 
            TxtNombre2Cli.BackColor = Color.White;
            TxtNombre2Cli.Cursor = Cursors.IBeam;
            TxtNombre2Cli.FillReadOnlyColor = Color.White;
            TxtNombre2Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre2Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtNombre2Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtNombre2Cli.ImeMode = ImeMode.Disable;
            TxtNombre2Cli.Location = new Point(210, 116);
            TxtNombre2Cli.Margin = new Padding(3, 2, 3, 2);
            TxtNombre2Cli.MinimumSize = new Size(1, 16);
            TxtNombre2Cli.Name = "TxtNombre2Cli";
            TxtNombre2Cli.Padding = new Padding(5);
            TxtNombre2Cli.Radius = 6;
            TxtNombre2Cli.ReadOnly = true;
            TxtNombre2Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtNombre2Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtNombre2Cli.ShowText = false;
            TxtNombre2Cli.Size = new Size(178, 34);
            TxtNombre2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre2Cli.TabIndex = 24;
            TxtNombre2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre2Cli.Watermark = "";
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(70, 86, 79);
            label19.Location = new Point(16, 156);
            label19.Name = "label19";
            label19.Size = new Size(178, 18);
            label19.TabIndex = 25;
            label19.Text = "Primer apellido";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtApellido1Cli
            // 
            TxtApellido1Cli.BackColor = Color.White;
            TxtApellido1Cli.Cursor = Cursors.IBeam;
            TxtApellido1Cli.FillReadOnlyColor = Color.White;
            TxtApellido1Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido1Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtApellido1Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtApellido1Cli.ImeMode = ImeMode.Disable;
            TxtApellido1Cli.Location = new Point(16, 174);
            TxtApellido1Cli.Margin = new Padding(3, 2, 3, 2);
            TxtApellido1Cli.MinimumSize = new Size(1, 16);
            TxtApellido1Cli.Name = "TxtApellido1Cli";
            TxtApellido1Cli.Padding = new Padding(5);
            TxtApellido1Cli.Radius = 6;
            TxtApellido1Cli.ReadOnly = true;
            TxtApellido1Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtApellido1Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtApellido1Cli.ShowText = false;
            TxtApellido1Cli.Size = new Size(178, 34);
            TxtApellido1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido1Cli.TabIndex = 26;
            TxtApellido1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido1Cli.Watermark = "";
            // 
            // label18
            // 
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(70, 86, 79);
            label18.Location = new Point(210, 156);
            label18.Name = "label18";
            label18.Size = new Size(178, 18);
            label18.TabIndex = 27;
            label18.Text = "Segundo apellido";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtApellido2Cli
            // 
            TxtApellido2Cli.BackColor = Color.White;
            TxtApellido2Cli.Cursor = Cursors.IBeam;
            TxtApellido2Cli.FillReadOnlyColor = Color.White;
            TxtApellido2Cli.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido2Cli.ForeColor = Color.FromArgb(20, 32, 30);
            TxtApellido2Cli.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtApellido2Cli.ImeMode = ImeMode.Disable;
            TxtApellido2Cli.Location = new Point(210, 174);
            TxtApellido2Cli.Margin = new Padding(3, 2, 3, 2);
            TxtApellido2Cli.MinimumSize = new Size(1, 16);
            TxtApellido2Cli.Name = "TxtApellido2Cli";
            TxtApellido2Cli.Padding = new Padding(5);
            TxtApellido2Cli.Radius = 6;
            TxtApellido2Cli.ReadOnly = true;
            TxtApellido2Cli.RectColor = Color.FromArgb(201, 211, 209);
            TxtApellido2Cli.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtApellido2Cli.ShowText = false;
            TxtApellido2Cli.Size = new Size(178, 34);
            TxtApellido2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido2Cli.TabIndex = 28;
            TxtApellido2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido2Cli.Watermark = "";
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.BackColor = Color.FromArgb(242, 245, 245);
            uiPanel1.Controls.Add(lblGridTitulo);
            uiPanel1.Controls.Add(DgvData);
            uiPanel1.Controls.Add(linePie);
            uiPanel1.Controls.Add(btndescargarpdff);
            uiPanel1.Controls.Add(label8);
            uiPanel1.Controls.Add(TxtMontoTotal);
            uiPanel1.Controls.Add(label9);
            uiPanel1.Controls.Add(TxtMontoPago);
            uiPanel1.Controls.Add(label12);
            uiPanel1.Controls.Add(TxtMontoCambio);
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
            uiPanel1.TabIndex = 29;
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
            lblGridTitulo.TabIndex = 30;
            lblGridTitulo.Text = "Productos de la venta";
            lblGridTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DgvData
            // 
            DgvData.AllowUserToAddRows = false;
            DgvData.AllowUserToDeleteRows = false;
            DgvData.AllowUserToResizeColumns = false;
            DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle9.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            DgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvData.BackgroundColor = Color.White;
            DgvData.BorderStyle = BorderStyle.None;
            DgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(70, 86, 79);
            dataGridViewCellStyle10.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(246, 248, 248);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(70, 86, 79);
            DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DgvData.ColumnHeadersHeight = 44;
            DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvData.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, SubTotal });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle11.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            DgvData.DefaultCellStyle = dataGridViewCellStyle11;
            DgvData.EnableHeadersVisualStyles = false;
            DgvData.Font = new Font("Segoe UI", 9.5F);
            DgvData.GridColor = Color.White;
            DgvData.HeaderBack = Color.FromArgb(246, 248, 248);
            DgvData.LineColor = Color.FromArgb(221, 228, 227);
            DgvData.Location = new Point(8, 48);
            DgvData.MultiSelect = false;
            DgvData.MutedColor = Color.FromArgb(70, 86, 79);
            DgvData.Name = "DgvData";
            DgvData.ReadOnly = true;
            DgvData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvData.RowHeadersVisible = false;
            DgvData.RowRadius = 6;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle12.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(223, 243, 239);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            DgvData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            DgvData.RowTemplate.Height = 56;
            DgvData.SelectionColor = Color.FromArgb(223, 243, 239);
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvData.ShowCellToolTips = false;
            DgvData.Size = new Size(828, 428);
            DgvData.TabIndex = 31;
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
            // Precio
            // 
            Precio.FillWeight = 70F;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 70;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            linePie.TabIndex = 32;
            // 
            // btndescargarpdff
            // 
            btndescargarpdff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btndescargarpdff.BackColor = Color.Transparent;
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
            btndescargarpdff.Size = new Size(176, 50);
            btndescargarpdff.Style = Sunny.UI.UIStyle.Custom;
            btndescargarpdff.Symbol = 61465;
            btndescargarpdff.SymbolColor = Color.FromArgb(180, 35, 24);
            btndescargarpdff.SymbolHoverColor = Color.FromArgb(180, 35, 24);
            btndescargarpdff.SymbolPressColor = Color.FromArgb(180, 35, 24);
            btndescargarpdff.SymbolSize = 18;
            btndescargarpdff.TabIndex = 33;
            btndescargarpdff.Text = "Descargar PDF";
            btndescargarpdff.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(70, 86, 79);
            label8.Location = new Point(240, 490);
            label8.Name = "label8";
            label8.Size = new Size(180, 18);
            label8.TabIndex = 34;
            label8.Text = "Monto total";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(70, 86, 79);
            label9.Location = new Point(440, 490);
            label9.Name = "label9";
            label9.Size = new Size(180, 18);
            label9.TabIndex = 36;
            label9.Text = "Monto pago";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtMontoPago
            // 
            TxtMontoPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TxtMontoPago.BackColor = Color.White;
            TxtMontoPago.Cursor = Cursors.IBeam;
            TxtMontoPago.FillReadOnlyColor = Color.White;
            TxtMontoPago.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMontoPago.ForeColor = Color.FromArgb(20, 32, 30);
            TxtMontoPago.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtMontoPago.ImeMode = ImeMode.Disable;
            TxtMontoPago.Location = new Point(440, 510);
            TxtMontoPago.Margin = new Padding(3, 2, 3, 2);
            TxtMontoPago.MinimumSize = new Size(1, 16);
            TxtMontoPago.Name = "TxtMontoPago";
            TxtMontoPago.Padding = new Padding(5);
            TxtMontoPago.Radius = 6;
            TxtMontoPago.ReadOnly = true;
            TxtMontoPago.RectColor = Color.FromArgb(201, 211, 209);
            TxtMontoPago.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtMontoPago.ShowText = false;
            TxtMontoPago.Size = new Size(180, 36);
            TxtMontoPago.Style = Sunny.UI.UIStyle.Custom;
            TxtMontoPago.TabIndex = 37;
            TxtMontoPago.TextAlignment = ContentAlignment.MiddleLeft;
            TxtMontoPago.Watermark = "";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(70, 86, 79);
            label12.Location = new Point(640, 490);
            label12.Name = "label12";
            label12.Size = new Size(180, 18);
            label12.TabIndex = 38;
            label12.Text = "Monto cambio";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TxtMontoCambio
            // 
            TxtMontoCambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TxtMontoCambio.BackColor = Color.White;
            TxtMontoCambio.Cursor = Cursors.IBeam;
            TxtMontoCambio.FillReadOnlyColor = Color.White;
            TxtMontoCambio.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMontoCambio.ForeColor = Color.FromArgb(20, 32, 30);
            TxtMontoCambio.ForeReadOnlyColor = Color.FromArgb(70, 86, 79);
            TxtMontoCambio.ImeMode = ImeMode.Disable;
            TxtMontoCambio.Location = new Point(640, 510);
            TxtMontoCambio.Margin = new Padding(3, 2, 3, 2);
            TxtMontoCambio.MinimumSize = new Size(1, 16);
            TxtMontoCambio.Name = "TxtMontoCambio";
            TxtMontoCambio.Padding = new Padding(5);
            TxtMontoCambio.Radius = 6;
            TxtMontoCambio.ReadOnly = true;
            TxtMontoCambio.RectColor = Color.FromArgb(201, 211, 209);
            TxtMontoCambio.RectReadOnlyColor = Color.FromArgb(221, 228, 227);
            TxtMontoCambio.ShowText = false;
            TxtMontoCambio.Size = new Size(180, 36);
            TxtMontoCambio.Style = Sunny.UI.UIStyle.Custom;
            TxtMontoCambio.TabIndex = 39;
            TxtMontoCambio.TextAlignment = ContentAlignment.MiddleLeft;
            TxtMontoCambio.Watermark = "";
            // 
            // TxtMontoTotal
            // 
            TxtMontoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TxtMontoTotal.BackColor = Color.White;
            TxtMontoTotal.Cursor = Cursors.IBeam;
            TxtMontoTotal.FillReadOnlyColor = Color.White;
            TxtMontoTotal.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMontoTotal.ForeColor = Color.FromArgb(20, 32, 30);
            TxtMontoTotal.ForeReadOnlyColor = Color.FromArgb(11, 94, 88);
            TxtMontoTotal.ImeMode = ImeMode.Disable;
            TxtMontoTotal.Location = new Point(240, 508);
            TxtMontoTotal.Margin = new Padding(3, 2, 3, 2);
            TxtMontoTotal.MinimumSize = new Size(1, 16);
            TxtMontoTotal.Name = "TxtMontoTotal";
            TxtMontoTotal.Padding = new Padding(5);
            TxtMontoTotal.Radius = 6;
            TxtMontoTotal.ReadOnly = true;
            TxtMontoTotal.RectColor = Color.FromArgb(201, 211, 209);
            TxtMontoTotal.RectDisableColor = Color.White;
            TxtMontoTotal.RectReadOnlyColor = Color.White;
            TxtMontoTotal.ShowText = false;
            TxtMontoTotal.Size = new Size(180, 40);
            TxtMontoTotal.Style = Sunny.UI.UIStyle.Custom;
            TxtMontoTotal.TabIndex = 35;
            TxtMontoTotal.TextAlignment = ContentAlignment.MiddleLeft;
            TxtMontoTotal.Watermark = "";
            // 
            // FrmDetallesVentas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(242, 245, 245);
            ClientSize = new Size(1316, 721);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(cardBusqueda);
            Controls.Add(groupBox1);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDetallesVentas";
            Text = "FrmDetallesVentas";
            Load += FrmDetallesVentas_Load;
            cardBusqueda.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox2.PerformLayout();
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
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
        private Sunny.UI.UIPanel uiGroupBox2;
        private Label label6;
        private TextBox txtnumerodocumento;
        private Label label11;
        private Sunny.UI.UITextBox TxtDocCliente;
        private Label label5;
        private Sunny.UI.UITextBox TxtNombre1Cli;
        private Label label17;
        private Sunny.UI.UITextBox TxtNombre2Cli;
        private Label label19;
        private Sunny.UI.UITextBox TxtApellido1Cli;
        private Label label18;
        private Sunny.UI.UITextBox TxtApellido2Cli;
        private Sunny.UI.UIPanel uiPanel1;
        private Label lblGridTitulo;
        private ModernControls.ModernGrid DgvData;
        private Label linePie;
        private Sunny.UI.UISymbolButton btndescargarpdff;
        private Label label8;
        private Label label9;
        private Sunny.UI.UITextBox TxtMontoPago;
        private Label label12;
        private Sunny.UI.UITextBox TxtMontoCambio;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Sunny.UI.UITextBox TxtMontoTotal;
    }
}