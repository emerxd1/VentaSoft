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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DetalleCompra));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtbusquedaa = new TextBox();
            btnbuscarr = new Button();
            btnlimpiarr = new Button();
            groupBox1 = new GroupBox();
            txtUsuarioo = new TextBox();
            txtTipodedocumentoo = new TextBox();
            label6 = new Label();
            txtFechaa = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtnumerodocumentoo = new TextBox();
            txtnombreproveedoorr = new TextBox();
            txtdocproveedoorr = new TextBox();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txtmontototall = new TextBox();
            btndescargarpdff = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Cyan;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, -1);
            label1.Name = "label1";
            label1.Size = new Size(610, 576);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSeaGreen;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, -1);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 1;
            label2.Text = "Detalle de la Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightSeaGreen;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 55);
            label3.Name = "label3";
            label3.Size = new Size(161, 17);
            label3.TabIndex = 2;
            label3.Text = "Número del Documento:";
            // 
            // txtbusquedaa
            // 
            txtbusquedaa.BorderStyle = BorderStyle.FixedSingle;
            txtbusquedaa.Cursor = Cursors.IBeam;
            txtbusquedaa.Location = new Point(246, 49);
            txtbusquedaa.Margin = new Padding(3, 2, 3, 2);
            txtbusquedaa.Name = "txtbusquedaa";
            txtbusquedaa.PlaceholderText = "EJ: 00001 O \"AUTO\"";
            txtbusquedaa.Size = new Size(141, 23);
            txtbusquedaa.TabIndex = 60;
            txtbusquedaa.KeyDown += txtbusquedaa_KeyDown;
            // 
            // btnbuscarr
            // 
            btnbuscarr.BackColor = Color.LightSeaGreen;
            btnbuscarr.Image = Properties.Resources.lupa;
            btnbuscarr.ImageAlign = ContentAlignment.MiddleLeft;
            btnbuscarr.Location = new Point(393, 41);
            btnbuscarr.Name = "btnbuscarr";
            btnbuscarr.Size = new Size(92, 34);
            btnbuscarr.TabIndex = 61;
            btnbuscarr.Text = "Buscar";
            btnbuscarr.UseVisualStyleBackColor = false;
            btnbuscarr.Click += btnbuscarr_Click;
            btnbuscarr.KeyDown += btnbuscarr_KeyDown;
            // 
            // btnlimpiarr
            // 
            btnlimpiarr.BackColor = Color.LightSeaGreen;
            btnlimpiarr.Image = Properties.Resources.limpiar;
            btnlimpiarr.ImageAlign = ContentAlignment.MiddleLeft;
            btnlimpiarr.Location = new Point(491, 41);
            btnlimpiarr.Name = "btnlimpiarr";
            btnlimpiarr.Size = new Size(101, 34);
            btnlimpiarr.TabIndex = 62;
            btnlimpiarr.Text = "Limpiar";
            btnlimpiarr.UseVisualStyleBackColor = false;
            btnlimpiarr.Click += btnlimpiarr_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUsuarioo);
            groupBox1.Controls.Add(txtTipodedocumentoo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFechaa);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 100);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de la Compra";
            // 
            // txtUsuarioo
            // 
            txtUsuarioo.BorderStyle = BorderStyle.FixedSingle;
            txtUsuarioo.Cursor = Cursors.IBeam;
            txtUsuarioo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtUsuarioo.Location = new Point(326, 42);
            txtUsuarioo.Margin = new Padding(3, 2, 3, 2);
            txtUsuarioo.Name = "txtUsuarioo";
            txtUsuarioo.Size = new Size(141, 23);
            txtUsuarioo.TabIndex = 66;
            // 
            // txtTipodedocumentoo
            // 
            txtTipodedocumentoo.BorderStyle = BorderStyle.FixedSingle;
            txtTipodedocumentoo.Cursor = Cursors.IBeam;
            txtTipodedocumentoo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtTipodedocumentoo.Location = new Point(170, 42);
            txtTipodedocumentoo.Margin = new Padding(3, 2, 3, 2);
            txtTipodedocumentoo.Name = "txtTipodedocumentoo";
            txtTipodedocumentoo.Size = new Size(141, 23);
            txtTipodedocumentoo.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSeaGreen;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(326, 25);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 65;
            label6.Text = "Usuario:";
            // 
            // txtFechaa
            // 
            txtFechaa.BorderStyle = BorderStyle.FixedSingle;
            txtFechaa.Cursor = Cursors.IBeam;
            txtFechaa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtFechaa.Location = new Point(14, 42);
            txtFechaa.Margin = new Padding(3, 2, 3, 2);
            txtFechaa.Name = "txtFechaa";
            txtFechaa.Size = new Size(141, 23);
            txtFechaa.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightSeaGreen;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(170, 25);
            label5.Name = "label5";
            label5.Size = new Size(135, 17);
            label5.TabIndex = 65;
            label5.Text = "Tipo de Documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSeaGreen;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 25);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 0;
            label4.Text = "Fecha:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtnumerodocumentoo);
            groupBox2.Controls.Add(txtnombreproveedoorr);
            groupBox2.Controls.Add(txtdocproveedoorr);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(23, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(569, 100);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información de la Compra";
            // 
            // txtnumerodocumentoo
            // 
            txtnumerodocumentoo.BorderStyle = BorderStyle.FixedSingle;
            txtnumerodocumentoo.Cursor = Cursors.IBeam;
            txtnumerodocumentoo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtnumerodocumentoo.Location = new Point(486, 42);
            txtnumerodocumentoo.Margin = new Padding(3, 2, 3, 2);
            txtnumerodocumentoo.Name = "txtnumerodocumentoo";
            txtnumerodocumentoo.Size = new Size(52, 23);
            txtnumerodocumentoo.TabIndex = 65;
            txtnumerodocumentoo.Visible = false;
            // 
            // txtnombreproveedoorr
            // 
            txtnombreproveedoorr.BorderStyle = BorderStyle.FixedSingle;
            txtnombreproveedoorr.Cursor = Cursors.IBeam;
            txtnombreproveedoorr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtnombreproveedoorr.Location = new Point(179, 42);
            txtnombreproveedoorr.Margin = new Padding(3, 2, 3, 2);
            txtnombreproveedoorr.Name = "txtnombreproveedoorr";
            txtnombreproveedoorr.Size = new Size(265, 23);
            txtnombreproveedoorr.TabIndex = 66;
            // 
            // txtdocproveedoorr
            // 
            txtdocproveedoorr.BorderStyle = BorderStyle.FixedSingle;
            txtdocproveedoorr.Cursor = Cursors.IBeam;
            txtdocproveedoorr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtdocproveedoorr.Location = new Point(14, 42);
            txtdocproveedoorr.Margin = new Padding(3, 2, 3, 2);
            txtdocproveedoorr.Name = "txtdocproveedoorr";
            txtdocproveedoorr.Size = new Size(157, 23);
            txtdocproveedoorr.TabIndex = 64;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightSeaGreen;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(179, 23);
            label8.Name = "label8";
            label8.Size = new Size(89, 17);
            label8.TabIndex = 65;
            label8.Text = "Razón Social:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightSeaGreen;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 25);
            label9.Name = "label9";
            label9.Size = new Size(157, 17);
            label9.TabIndex = 0;
            label9.Text = "Número de Documento:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(23, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 223);
            dataGridView1.TabIndex = 65;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 200;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio de la Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 110;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 110;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 105;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSeaGreen;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 537);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 66;
            label7.Text = "Monto Total:";
            // 
            // txtmontototall
            // 
            txtmontototall.BorderStyle = BorderStyle.FixedSingle;
            txtmontototall.Cursor = Cursors.IBeam;
            txtmontototall.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmontototall.Location = new Point(117, 531);
            txtmontototall.Margin = new Padding(3, 2, 3, 2);
            txtmontototall.Name = "txtmontototall";
            txtmontototall.Size = new Size(85, 23);
            txtmontototall.TabIndex = 67;
            txtmontototall.Text = "0";
            // 
            // btndescargarpdff
            // 
            btndescargarpdff.BackColor = Color.LightSeaGreen;
            btndescargarpdff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndescargarpdff.Image = (Image)resources.GetObject("btndescargarpdff.Image");
            btndescargarpdff.ImageAlign = ContentAlignment.MiddleLeft;
            btndescargarpdff.Location = new Point(467, 531);
            btndescargarpdff.Name = "btndescargarpdff";
            btndescargarpdff.Size = new Size(125, 32);
            btndescargarpdff.TabIndex = 68;
            btndescargarpdff.Text = "Descargar PDF";
            btndescargarpdff.UseVisualStyleBackColor = false;
            btndescargarpdff.Click += btndescargarpdff_Click;
            // 
            // Frm_DetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 575);
            Controls.Add(btndescargarpdff);
            Controls.Add(txtmontototall);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnlimpiarr);
            Controls.Add(btnbuscarr);
            Controls.Add(txtbusquedaa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_DetalleCompra";
            Text = "Frm_DetalleCompra";
            Load += Frm_DetalleCompra_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtbusquedaa;
        private Button btnbuscarr;
        private Button btnlimpiarr;
        private GroupBox groupBox1;
        private TextBox txtUsuarioo;
        private TextBox txtTipodedocumentoo;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtFechaa;
        private GroupBox groupBox2;
        private TextBox txtnumerodocumentoo;
        private TextBox txtnombreproveedoorr;
        private TextBox txtdocproveedoorr;
        private Label label8;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Label label7;
        private TextBox txtmontototall;
        private Button btndescargarpdff;
    }
}