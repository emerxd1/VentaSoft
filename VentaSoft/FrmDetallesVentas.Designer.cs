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
            label1 = new AntdUI.Label();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            btnbuscarr = new Sunny.UI.UISymbolButton();
            lblTituloGrupo1 = new Label();
            label16 = new Label();
            txtbusquedaa = new Sunny.UI.UITextBox();
            btnlimpiarr = new Sunny.UI.UISymbolButton();
            groupBox1 = new Sunny.UI.UIPanel();
            txtUsuarioo = new Sunny.UI.UITextBox();
            txtTipodedocumentoo = new Sunny.UI.UITextBox();
            label10 = new Label();
            txtFechaa = new Sunny.UI.UITextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            label6 = new Label();
            txtnumerodocumento = new TextBox();
            label18 = new Label();
            TxtApellido2Cli = new Sunny.UI.UITextBox();
            label19 = new Label();
            TxtApellido1Cli = new Sunny.UI.UITextBox();
            label17 = new Label();
            TxtNombre2Cli = new Sunny.UI.UITextBox();
            label5 = new Label();
            TxtNombre1Cli = new Sunny.UI.UITextBox();
            label11 = new Label();
            TxtDocCliente = new Sunny.UI.UITextBox();
            DgvData = new ModernControls.ModernGrid();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewTextBoxColumn();
            btndescargarpdff = new Sunny.UI.UISymbolButton();
            label13 = new Label();
            uiGroupBox4 = new Sunny.UI.UIGroupBox();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            TxtMontoCambio = new Sunny.UI.UITextBox();
            TxtMontoPago = new Sunny.UI.UITextBox();
            TxtMontoTotal = new Sunny.UI.UITextBox();
            label7 = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            label14 = new Label();
            uiGroupBox1.SuspendLayout();
            groupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
            uiGroupBox4.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(1092, 646);
            label1.TabIndex = 0;
            label1.Text = "";
            label1.Click += label1_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.White;
            uiGroupBox1.Controls.Add(btnbuscarr);
            uiGroupBox1.Controls.Add(lblTituloGrupo1);
            uiGroupBox1.Controls.Add(label16);
            uiGroupBox1.Controls.Add(txtbusquedaa);
            uiGroupBox1.Controls.Add(btnlimpiarr);
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox1.Location = new Point(3, 4);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.RectColor = Color.LightGray;
            uiGroupBox1.Size = new Size(520, 75);
            uiGroupBox1.TabIndex = 1;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
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
            btnbuscarr.Location = new Point(315, 32);
            btnbuscarr.MinimumSize = new Size(1, 1);
            btnbuscarr.Name = "btnbuscarr";
            btnbuscarr.Radius = 15;
            btnbuscarr.RectColor = Color.White;
            btnbuscarr.RectDisableColor = Color.White;
            btnbuscarr.RectHoverColor = Color.White;
            btnbuscarr.RectPressColor = Color.White;
            btnbuscarr.RectSelectedColor = Color.White;
            btnbuscarr.ShowFocusLine = true;
            btnbuscarr.Size = new Size(82, 31);
            btnbuscarr.Style = Sunny.UI.UIStyle.Custom;
            btnbuscarr.Symbol = 61442;
            btnbuscarr.TabIndex = 85;
            btnbuscarr.Text = "Buscar";
            btnbuscarr.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lblTituloGrupo1
            // 
            lblTituloGrupo1.BackColor = Color.FromArgb(8, 92, 63);
            lblTituloGrupo1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrupo1.ForeColor = Color.Transparent;
            lblTituloGrupo1.Location = new Point(0, 0);
            lblTituloGrupo1.Name = "lblTituloGrupo1";
            lblTituloGrupo1.Size = new Size(521, 26);
            lblTituloGrupo1.TabIndex = 75;
            lblTituloGrupo1.Text = "Detalle de la venta*";
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.ImageAlign = ContentAlignment.MiddleLeft;
            label16.Location = new Point(3, 32);
            label16.Name = "label16";
            label16.Size = new Size(182, 31);
            label16.TabIndex = 84;
            label16.Text = "Número de la Factura:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtbusquedaa
            // 
            txtbusquedaa.Cursor = Cursors.IBeam;
            txtbusquedaa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbusquedaa.Location = new Point(186, 32);
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
            txtbusquedaa.TabIndex = 82;
            txtbusquedaa.TextAlignment = ContentAlignment.MiddleLeft;
            txtbusquedaa.Watermark = "EJ: V0001";
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
            btnlimpiarr.Location = new Point(402, 33);
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
            btnlimpiarr.Size = new Size(93, 30);
            btnlimpiarr.Style = Sunny.UI.UIStyle.Custom;
            btnlimpiarr.Symbol = 61741;
            btnlimpiarr.TabIndex = 83;
            btnlimpiarr.Text = "Limpiar";
            btnlimpiarr.TipsFont = new Font("Microsoft Sans Serif", 9F);
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
            groupBox1.Controls.Add(label4);
            groupBox1.FillColor = Color.White;
            groupBox1.FillColor2 = Color.White;
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F);
            groupBox1.ForeColor = Color.FromArgb(11, 46, 34);
            groupBox1.Location = new Point(3, 89);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Radius = 1;
            groupBox1.RectColor = Color.LightGray;
            groupBox1.Size = new Size(520, 137);
            groupBox1.TabIndex = 64;
            groupBox1.Text = null;
            groupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtUsuarioo
            // 
            txtUsuarioo.BackColor = Color.White;
            txtUsuarioo.Cursor = Cursors.IBeam;
            txtUsuarioo.FillReadOnlyColor = Color.White;
            txtUsuarioo.Font = new Font("Microsoft Sans Serif", 12F);
            txtUsuarioo.Location = new Point(324, 64);
            txtUsuarioo.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioo.MinimumSize = new Size(1, 16);
            txtUsuarioo.Name = "txtUsuarioo";
            txtUsuarioo.Padding = new Padding(5);
            txtUsuarioo.Radius = 10;
            txtUsuarioo.ReadOnly = true;
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
            txtTipodedocumentoo.BackColor = Color.White;
            txtTipodedocumentoo.Cursor = Cursors.IBeam;
            txtTipodedocumentoo.FillReadOnlyColor = Color.White;
            txtTipodedocumentoo.Font = new Font("Microsoft Sans Serif", 12F);
            txtTipodedocumentoo.Location = new Point(144, 64);
            txtTipodedocumentoo.Margin = new Padding(3, 2, 3, 2);
            txtTipodedocumentoo.MinimumSize = new Size(1, 16);
            txtTipodedocumentoo.Name = "txtTipodedocumentoo";
            txtTipodedocumentoo.Padding = new Padding(5);
            txtTipodedocumentoo.Radius = 10;
            txtTipodedocumentoo.ReadOnly = true;
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
            txtFechaa.BackColor = Color.White;
            txtFechaa.Cursor = Cursors.IBeam;
            txtFechaa.FillReadOnlyColor = Color.White;
            txtFechaa.Font = new Font("Microsoft Sans Serif", 12F);
            txtFechaa.Location = new Point(0, 64);
            txtFechaa.Margin = new Padding(3, 2, 3, 2);
            txtFechaa.MinimumSize = new Size(1, 16);
            txtFechaa.Name = "txtFechaa";
            txtFechaa.Padding = new Padding(5);
            txtFechaa.Radius = 10;
            txtFechaa.ReadOnly = true;
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
            // label4
            // 
            label4.BackColor = Color.FromArgb(8, 92, 63);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(-3, 0);
            label4.Name = "label4";
            label4.Size = new Size(524, 26);
            label4.TabIndex = 74;
            label4.Text = "Información de la Venta*";
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(label6);
            uiGroupBox2.Controls.Add(txtnumerodocumento);
            uiGroupBox2.Controls.Add(label18);
            uiGroupBox2.Controls.Add(TxtApellido2Cli);
            uiGroupBox2.Controls.Add(label19);
            uiGroupBox2.Controls.Add(TxtApellido1Cli);
            uiGroupBox2.Controls.Add(label17);
            uiGroupBox2.Controls.Add(TxtNombre2Cli);
            uiGroupBox2.Controls.Add(label5);
            uiGroupBox2.Controls.Add(TxtNombre1Cli);
            uiGroupBox2.Controls.Add(label11);
            uiGroupBox2.Controls.Add(TxtDocCliente);
            uiGroupBox2.FillColor = Color.White;
            uiGroupBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox2.Location = new Point(3, 227);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.RectColor = Color.Gray;
            uiGroupBox2.Size = new Size(521, 216);
            uiGroupBox2.TabIndex = 65;
            uiGroupBox2.Text = null;
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(8, 92, 63);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(-3, 1);
            label6.Name = "label6";
            label6.Size = new Size(524, 26);
            label6.TabIndex = 90;
            label6.Text = "Información del Cliente*";
            // 
            // txtnumerodocumento
            // 
            txtnumerodocumento.Location = new Point(279, 49);
            txtnumerodocumento.Name = "txtnumerodocumento";
            txtnumerodocumento.Size = new Size(40, 26);
            txtnumerodocumento.TabIndex = 89;
            txtnumerodocumento.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(31, 58, 48);
            label18.Location = new Point(279, 148);
            label18.Name = "label18";
            label18.Size = new Size(132, 20);
            label18.TabIndex = 87;
            label18.Text = "Segundo Apellido";
            // 
            // TxtApellido2Cli
            // 
            TxtApellido2Cli.BackColor = Color.White;
            TxtApellido2Cli.FillReadOnlyColor = Color.White;
            TxtApellido2Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtApellido2Cli.ForeColor = Color.DimGray;
            TxtApellido2Cli.ForeReadOnlyColor = Color.Gray;
            TxtApellido2Cli.Location = new Point(279, 170);
            TxtApellido2Cli.Margin = new Padding(4, 5, 4, 5);
            TxtApellido2Cli.MinimumSize = new Size(1, 16);
            TxtApellido2Cli.Name = "TxtApellido2Cli";
            TxtApellido2Cli.Padding = new Padding(5);
            TxtApellido2Cli.Radius = 10;
            TxtApellido2Cli.ReadOnly = true;
            TxtApellido2Cli.RectColor = Color.Silver;
            TxtApellido2Cli.ShowText = false;
            TxtApellido2Cli.Size = new Size(193, 39);
            TxtApellido2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido2Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtApellido2Cli.TabIndex = 88;
            TxtApellido2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido2Cli.Watermark = "";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.White;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(31, 58, 48);
            label19.Location = new Point(6, 148);
            label19.Name = "label19";
            label19.Size = new Size(125, 20);
            label19.TabIndex = 85;
            label19.Text = "Primer Apellido*";
            // 
            // TxtApellido1Cli
            // 
            TxtApellido1Cli.BackColor = Color.White;
            TxtApellido1Cli.FillReadOnlyColor = Color.White;
            TxtApellido1Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtApellido1Cli.ForeColor = Color.DimGray;
            TxtApellido1Cli.Location = new Point(6, 170);
            TxtApellido1Cli.Margin = new Padding(4, 5, 4, 5);
            TxtApellido1Cli.MinimumSize = new Size(1, 16);
            TxtApellido1Cli.Name = "TxtApellido1Cli";
            TxtApellido1Cli.Padding = new Padding(5);
            TxtApellido1Cli.Radius = 10;
            TxtApellido1Cli.ReadOnly = true;
            TxtApellido1Cli.RectColor = Color.Silver;
            TxtApellido1Cli.ShowText = false;
            TxtApellido1Cli.Size = new Size(189, 39);
            TxtApellido1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtApellido1Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtApellido1Cli.TabIndex = 86;
            TxtApellido1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtApellido1Cli.Watermark = "";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(31, 58, 48);
            label17.Location = new Point(279, 84);
            label17.Name = "label17";
            label17.Size = new Size(132, 20);
            label17.TabIndex = 83;
            label17.Text = "Segundo Nombre";
            // 
            // TxtNombre2Cli
            // 
            TxtNombre2Cli.BackColor = Color.White;
            TxtNombre2Cli.FillReadOnlyColor = Color.White;
            TxtNombre2Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtNombre2Cli.ForeColor = Color.DimGray;
            TxtNombre2Cli.Location = new Point(279, 106);
            TxtNombre2Cli.Margin = new Padding(4, 5, 4, 5);
            TxtNombre2Cli.MinimumSize = new Size(1, 16);
            TxtNombre2Cli.Name = "TxtNombre2Cli";
            TxtNombre2Cli.Padding = new Padding(5);
            TxtNombre2Cli.Radius = 10;
            TxtNombre2Cli.ReadOnly = true;
            TxtNombre2Cli.RectColor = Color.Silver;
            TxtNombre2Cli.ShowText = false;
            TxtNombre2Cli.Size = new Size(193, 37);
            TxtNombre2Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre2Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtNombre2Cli.TabIndex = 84;
            TxtNombre2Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre2Cli.Watermark = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(31, 58, 48);
            label5.Location = new Point(6, 84);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 67;
            label5.Text = "Primer Nombre*";
            // 
            // TxtNombre1Cli
            // 
            TxtNombre1Cli.BackColor = Color.White;
            TxtNombre1Cli.FillReadOnlyColor = Color.White;
            TxtNombre1Cli.Font = new Font("Microsoft Sans Serif", 12F);
            TxtNombre1Cli.ForeColor = Color.DimGray;
            TxtNombre1Cli.Location = new Point(6, 106);
            TxtNombre1Cli.Margin = new Padding(4, 5, 4, 5);
            TxtNombre1Cli.MinimumSize = new Size(1, 16);
            TxtNombre1Cli.Name = "TxtNombre1Cli";
            TxtNombre1Cli.Padding = new Padding(5);
            TxtNombre1Cli.Radius = 10;
            TxtNombre1Cli.ReadOnly = true;
            TxtNombre1Cli.RectColor = Color.Silver;
            TxtNombre1Cli.ShowText = false;
            TxtNombre1Cli.Size = new Size(189, 37);
            TxtNombre1Cli.Style = Sunny.UI.UIStyle.Custom;
            TxtNombre1Cli.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtNombre1Cli.TabIndex = 68;
            TxtNombre1Cli.TextAlignment = ContentAlignment.MiddleLeft;
            TxtNombre1Cli.Watermark = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(6, 27);
            label11.Name = "label11";
            label11.Size = new Size(44, 20);
            label11.TabIndex = 76;
            label11.Text = "DNI*";
            // 
            // TxtDocCliente
            // 
            TxtDocCliente.BackColor = Color.White;
            TxtDocCliente.Cursor = Cursors.IBeam;
            TxtDocCliente.FillReadOnlyColor = Color.White;
            TxtDocCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtDocCliente.ForeColor = Color.DimGray;
            TxtDocCliente.Location = new Point(6, 49);
            TxtDocCliente.Margin = new Padding(3, 2, 3, 2);
            TxtDocCliente.MinimumSize = new Size(1, 16);
            TxtDocCliente.Name = "TxtDocCliente";
            TxtDocCliente.Padding = new Padding(5);
            TxtDocCliente.Radius = 10;
            TxtDocCliente.ReadOnly = true;
            TxtDocCliente.RectColor = Color.Gainsboro;
            TxtDocCliente.ShowText = false;
            TxtDocCliente.Size = new Size(189, 30);
            TxtDocCliente.Style = Sunny.UI.UIStyle.Custom;
            TxtDocCliente.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtDocCliente.TabIndex = 75;
            TxtDocCliente.TextAlignment = ContentAlignment.MiddleLeft;
            TxtDocCliente.Watermark = "";
            // 
            // DgvData
            // 
            DgvData.AllowUserToAddRows = false;
            DgvData.AllowUserToDeleteRows = false;
            DgvData.AllowUserToResizeColumns = false;
            DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvData.BackgroundColor = Color.White;
            DgvData.BorderStyle = BorderStyle.None;
            DgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 8.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvData.ColumnHeadersHeight = 44;
            DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, btneliminar });
            DgvData.CornerRadius = 5;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvData.DefaultCellStyle = dataGridViewCellStyle3;
            DgvData.EnableHeadersVisualStyles = false;
            DgvData.Font = new Font("Segoe UI", 9.5F);
            DgvData.GridColor = Color.White;
            DgvData.HeaderBack = Color.FromArgb(8, 92, 63);
            DgvData.LineColor = Color.FromArgb(200, 208, 204);
            DgvData.Location = new Point(3, 1);
            DgvData.MultiSelect = false;
            DgvData.MutedColor = Color.White;
            DgvData.Name = "DgvData";
            DgvData.ReadOnly = true;
            DgvData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DgvData.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.Padding = new Padding(14, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(228, 243, 234);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(16, 30, 24);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DgvData.RowTemplate.Height = 56;
            DgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvData.ShowCellToolTips = false;
            DgvData.ShowColumnDividers = true;
            DgvData.Size = new Size(551, 495);
            DgvData.TabIndex = 66;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.SortMode = DataGridViewColumnSortMode.NotSortable;
            IdProducto.Visible = false;
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
            SubTotal.FillWeight = 87F;
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 87;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            SubTotal.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btneliminar
            // 
            btneliminar.FillWeight = 60F;
            btneliminar.HeaderText = "";
            btneliminar.MinimumWidth = 60;
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            btneliminar.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btndescargarpdff
            // 
            btndescargarpdff.BackColor = Color.Transparent;
            btndescargarpdff.FillColor = Color.Red;
            btndescargarpdff.FillDisableColor = Color.FromArgb(224, 224, 224);
            btndescargarpdff.FillHoverColor = Color.FromArgb(8, 92, 63);
            btndescargarpdff.FillPressColor = Color.Silver;
            btndescargarpdff.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndescargarpdff.Location = new Point(370, 550);
            btndescargarpdff.MinimumSize = new Size(1, 1);
            btndescargarpdff.Name = "btndescargarpdff";
            btndescargarpdff.Radius = 15;
            btndescargarpdff.RectColor = Color.White;
            btndescargarpdff.RectDisableColor = Color.White;
            btndescargarpdff.RectHoverColor = Color.White;
            btndescargarpdff.RectPressColor = Color.White;
            btndescargarpdff.RectSelectedColor = Color.White;
            btndescargarpdff.ShowFocusLine = true;
            btndescargarpdff.Size = new Size(184, 44);
            btndescargarpdff.Style = Sunny.UI.UIStyle.Custom;
            btndescargarpdff.Symbol = 61889;
            btndescargarpdff.TabIndex = 69;
            btndescargarpdff.Text = "Descargar PDF";
            btndescargarpdff.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // label13
            // 
            label13.BackColor = Color.FromArgb(8, 92, 63);
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 499);
            label13.Name = "label13";
            label13.Padding = new Padding(8, 0, 0, 0);
            label13.Size = new Size(558, 32);
            label13.TabIndex = 67;
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox4
            // 
            uiGroupBox4.Controls.Add(label12);
            uiGroupBox4.Controls.Add(label9);
            uiGroupBox4.Controls.Add(label8);
            uiGroupBox4.Controls.Add(TxtMontoCambio);
            uiGroupBox4.Controls.Add(TxtMontoPago);
            uiGroupBox4.Controls.Add(TxtMontoTotal);
            uiGroupBox4.Controls.Add(label7);
            uiGroupBox4.FillColor = Color.White;
            uiGroupBox4.Font = new Font("Microsoft Sans Serif", 12F);
            uiGroupBox4.Location = new Point(7, 445);
            uiGroupBox4.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox4.MinimumSize = new Size(1, 1);
            uiGroupBox4.Name = "uiGroupBox4";
            uiGroupBox4.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox4.RectColor = Color.LightGray;
            uiGroupBox4.Size = new Size(517, 187);
            uiGroupBox4.TabIndex = 68;
            uiGroupBox4.Text = null;
            uiGroupBox4.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(31, 58, 48);
            label12.Location = new Point(353, 47);
            label12.Name = "label12";
            label12.Size = new Size(120, 20);
            label12.TabIndex = 70;
            label12.Text = "Monto Cambio*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(31, 58, 48);
            label9.Location = new Point(182, 47);
            label9.Name = "label9";
            label9.Size = new Size(102, 20);
            label9.TabIndex = 69;
            label9.Text = "Monto Pago*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(31, 58, 48);
            label8.Location = new Point(3, 47);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 68;
            label8.Text = "Monto Total*";
            // 
            // TxtMontoCambio
            // 
            TxtMontoCambio.BackColor = Color.White;
            TxtMontoCambio.Cursor = Cursors.IBeam;
            TxtMontoCambio.FillReadOnlyColor = Color.White;
            TxtMontoCambio.Font = new Font("Microsoft Sans Serif", 12F);
            TxtMontoCambio.Location = new Point(353, 69);
            TxtMontoCambio.Margin = new Padding(3, 2, 3, 2);
            TxtMontoCambio.MinimumSize = new Size(1, 16);
            TxtMontoCambio.Name = "TxtMontoCambio";
            TxtMontoCambio.Padding = new Padding(5);
            TxtMontoCambio.Radius = 10;
            TxtMontoCambio.ReadOnly = true;
            TxtMontoCambio.RectColor = Color.Silver;
            TxtMontoCambio.ShowText = false;
            TxtMontoCambio.Size = new Size(138, 30);
            TxtMontoCambio.Style = Sunny.UI.UIStyle.Custom;
            TxtMontoCambio.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtMontoCambio.TabIndex = 67;
            TxtMontoCambio.TextAlignment = ContentAlignment.MiddleLeft;
            TxtMontoCambio.Watermark = "";
            // 
            // TxtMontoPago
            // 
            TxtMontoPago.BackColor = Color.White;
            TxtMontoPago.Cursor = Cursors.IBeam;
            TxtMontoPago.FillReadOnlyColor = Color.White;
            TxtMontoPago.Font = new Font("Microsoft Sans Serif", 12F);
            TxtMontoPago.Location = new Point(182, 69);
            TxtMontoPago.Margin = new Padding(3, 2, 3, 2);
            TxtMontoPago.MinimumSize = new Size(1, 16);
            TxtMontoPago.Name = "TxtMontoPago";
            TxtMontoPago.Padding = new Padding(5);
            TxtMontoPago.Radius = 10;
            TxtMontoPago.ReadOnly = true;
            TxtMontoPago.RectColor = Color.Silver;
            TxtMontoPago.ShowText = false;
            TxtMontoPago.Size = new Size(138, 30);
            TxtMontoPago.Style = Sunny.UI.UIStyle.Custom;
            TxtMontoPago.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtMontoPago.TabIndex = 66;
            TxtMontoPago.TextAlignment = ContentAlignment.MiddleLeft;
            TxtMontoPago.Watermark = "";
            // 
            // TxtMontoTotal
            // 
            TxtMontoTotal.BackColor = Color.White;
            TxtMontoTotal.Cursor = Cursors.IBeam;
            TxtMontoTotal.FillReadOnlyColor = Color.White;
            TxtMontoTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMontoTotal.Location = new Point(2, 69);
            TxtMontoTotal.Margin = new Padding(3, 2, 3, 2);
            TxtMontoTotal.MinimumSize = new Size(1, 16);
            TxtMontoTotal.Name = "TxtMontoTotal";
            TxtMontoTotal.Padding = new Padding(5);
            TxtMontoTotal.Radius = 10;
            TxtMontoTotal.ReadOnly = true;
            TxtMontoTotal.RectColor = Color.Silver;
            TxtMontoTotal.ShowText = false;
            TxtMontoTotal.Size = new Size(138, 30);
            TxtMontoTotal.Style = Sunny.UI.UIStyle.Custom;
            TxtMontoTotal.SymbolColor = Color.FromArgb(57, 79, 71);
            TxtMontoTotal.TabIndex = 65;
            TxtMontoTotal.TextAlignment = ContentAlignment.MiddleLeft;
            TxtMontoTotal.Watermark = "";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(8, 92, 63);
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(-4, -5);
            label7.Name = "label7";
            label7.Padding = new Padding(8, 0, 0, 0);
            label7.Size = new Size(521, 32);
            label7.TabIndex = 3;
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(label13);
            uiPanel1.Controls.Add(DgvData);
            uiPanel1.Controls.Add(btndescargarpdff);
            uiPanel1.FillColor = Color.White;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(531, 35);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = Color.Silver;
            uiPanel1.Size = new Size(557, 597);
            uiPanel1.TabIndex = 70;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(8, 92, 63);
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(523, 4);
            label14.Name = "label14";
            label14.Size = new Size(566, 26);
            label14.TabIndex = 76;
            // 
            // FrmDetallesVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 637);
            Controls.Add(label14);
            Controls.Add(uiPanel1);
            Controls.Add(uiGroupBox4);
            Controls.Add(uiGroupBox2);
            Controls.Add(groupBox1);
            Controls.Add(uiGroupBox1);
            Controls.Add(label1);
            Name = "FrmDetallesVentas";
            Text = "FrmDetallesVentas";
            Load += FrmDetallesVentas_Load;
            uiGroupBox1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            uiGroupBox4.ResumeLayout(false);
            uiGroupBox4.PerformLayout();
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Label lblTituloGrupo1;
        private Sunny.UI.UISymbolButton btnbuscarr;
        private Label label16;
        private Sunny.UI.UITextBox txtbusquedaa;
        private Sunny.UI.UISymbolButton btnlimpiarr;
        private Sunny.UI.UIPanel groupBox1;
        private Sunny.UI.UITextBox txtUsuarioo;
        private Sunny.UI.UITextBox txtTipodedocumentoo;
        private Label label10;
        private Sunny.UI.UITextBox txtFechaa;
        private Label label3;
        private Label label2;
        private Label label4;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Label label18;
        private Sunny.UI.UITextBox TxtApellido2Cli;
        private Label label19;
        private Sunny.UI.UITextBox TxtApellido1Cli;
        private Label label17;
        private Sunny.UI.UITextBox TxtNombre2Cli;
        private Label label5;
        private Sunny.UI.UITextBox TxtNombre1Cli;
        private Label label11;
        private Sunny.UI.UITextBox TxtDocCliente;
        private TextBox txtnumerodocumento;
        private ModernControls.ModernGrid DgvData;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn btneliminar;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Label label6;
        private Label label7;
        private Label label12;
        private Label label9;
        private Label label8;
        private Sunny.UI.UITextBox TxtMontoCambio;
        private Sunny.UI.UITextBox TxtMontoPago;
        private Sunny.UI.UITextBox TxtMontoTotal;
        private Label label13;
        private Sunny.UI.UISymbolButton btndescargarpdff;
        private Sunny.UI.UIPanel uiPanel1;
        private Label label14;
    }
}