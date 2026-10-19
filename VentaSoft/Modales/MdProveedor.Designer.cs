namespace Main.Modales
{
    partial class MdProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdProveedor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            label13 = new Label();
            btnbuscar = new Button();
            btneliminar = new Button();
            DvgMduser = new DataGridView();
            IdProveedor = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DvgMduser).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(12, 89);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 23);
            txtSearch.TabIndex = 61;
            // 
            // cbSearch
            // 
            cbSearch.BackColor = Color.White;
            cbSearch.Cursor = Cursors.Hand;
            cbSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearch.FormattingEnabled = true;
            cbSearch.Location = new Point(12, 62);
            cbSearch.Margin = new Padding(3, 2, 3, 2);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(125, 23);
            cbSearch.TabIndex = 63;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Cyan;
            label13.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 37);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 62;
            label13.Text = "Buscar por.";
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.CornflowerBlue;
            btnbuscar.Image = (Image)resources.GetObject("btnbuscar.Image");
            btnbuscar.Location = new Point(143, 52);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(36, 33);
            btnbuscar.TabIndex = 64;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.CornflowerBlue;
            btneliminar.Image = Properties.Resources.recargar;
            btneliminar.Location = new Point(185, 52);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(32, 33);
            btneliminar.TabIndex = 65;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // DvgMduser
            // 
            DvgMduser.AllowUserToAddRows = false;
            DvgMduser.BackgroundColor = Color.White;
            DvgMduser.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Cyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DvgMduser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DvgMduser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DvgMduser.Columns.AddRange(new DataGridViewColumn[] { IdProveedor, RUC, RazonSocial });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DvgMduser.DefaultCellStyle = dataGridViewCellStyle2;
            DvgMduser.EnableHeadersVisualStyles = false;
            DvgMduser.GridColor = Color.White;
            DvgMduser.Location = new Point(223, 37);
            DvgMduser.Name = "DvgMduser";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DvgMduser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DvgMduser.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            DvgMduser.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            DvgMduser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DvgMduser.Size = new Size(295, 226);
            DvgMduser.TabIndex = 66;
            DvgMduser.CellDoubleClick += DvgMduser_CellDoubleClick;
            // 
            // IdProveedor
            // 
            IdProveedor.HeaderText = "Id";
            IdProveedor.Name = "IdProveedor";
            IdProveedor.Visible = false;
            // 
            // RUC
            // 
            RUC.HeaderText = "RUC";
            RUC.Name = "RUC";
            RUC.Width = 150;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            // 
            // label1
            // 
            label1.BackColor = Color.SandyBrown;
            label1.Location = new Point(-9, -6);
            label1.Name = "label1";
            label1.Size = new Size(541, 40);
            label1.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 69;
            label2.Text = "Lista de Proveedores\r\n";
            // 
            // MdProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(518, 269);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DvgMduser);
            Controls.Add(btneliminar);
            Controls.Add(btnbuscar);
            Controls.Add(txtSearch);
            Controls.Add(cbSearch);
            Controls.Add(label13);
            Name = "MdProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MdProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)DvgMduser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private ComboBox cbSearch;
        private Label label13;
        private Button btnbuscar;
        private Button btneliminar;
        private DataGridView DvgMduser;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn IdProveedor;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn RazonSocial;
    }
}