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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtSearchProve = new TextBox();
            cbSearchProve = new ComboBox();
            label13 = new Label();
            btnbuscar = new Button();
            btneliminar = new Button();
            DvgMduser = new DataGridView();
            IdProveedor = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)DvgMduser).BeginInit();
            SuspendLayout();
            // 
            // txtSearchProve
            // 
            txtSearchProve.BackColor = Color.White;
            txtSearchProve.BorderStyle = BorderStyle.FixedSingle;
            txtSearchProve.Cursor = Cursors.IBeam;
            txtSearchProve.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchProve.Location = new Point(1, 93);
            txtSearchProve.Margin = new Padding(3, 2, 3, 2);
            txtSearchProve.Name = "txtSearchProve";
            txtSearchProve.PlaceholderText = "EJ: 008-092008-0989Z";
            txtSearchProve.Size = new Size(205, 29);
            txtSearchProve.TabIndex = 61;
            txtSearchProve.TextChanged += cbSearchProve_TabIndexChanged;
            txtSearchProve.KeyDown += txtSearchProve_KeyDown;
            // 
            // cbSearchProve
            // 
            cbSearchProve.BackColor = Color.White;
            cbSearchProve.Cursor = Cursors.Hand;
            cbSearchProve.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchProve.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearchProve.ForeColor = Color.Black;
            cbSearchProve.FormattingEnabled = true;
            cbSearchProve.Location = new Point(1, 62);
            cbSearchProve.Margin = new Padding(3, 2, 3, 2);
            cbSearchProve.Name = "cbSearchProve";
            cbSearchProve.Size = new Size(125, 28);
            cbSearchProve.TabIndex = 63;
            cbSearchProve.SelectedIndexChanged += cbSearchProve_TabIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 37);
            label13.Name = "label13";
            label13.Size = new Size(102, 21);
            label13.TabIndex = 62;
            label13.Text = "Buscar por*";
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.Transparent;
            btnbuscar.FlatAppearance.BorderSize = 0;
            btnbuscar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.Transparent;
            btnbuscar.Image = (Image)resources.GetObject("btnbuscar.Image");
            btnbuscar.Location = new Point(130, 50);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(45, 41);
            btnbuscar.TabIndex = 64;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Transparent;
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatAppearance.MouseOverBackColor = Color.SeaGreen;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Image = Properties.Resources.recargar;
            btneliminar.Location = new Point(176, 50);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(45, 41);
            btneliminar.TabIndex = 65;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // DvgMduser
            // 
            DvgMduser.AllowUserToAddRows = false;
            DvgMduser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            DvgMduser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DvgMduser.BackgroundColor = Color.White;
            DvgMduser.BorderStyle = BorderStyle.None;
            DvgMduser.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(8, 92, 63);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DvgMduser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DvgMduser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DvgMduser.Columns.AddRange(new DataGridViewColumn[] { IdProveedor, RUC, RazonSocial });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DvgMduser.DefaultCellStyle = dataGridViewCellStyle3;
            DvgMduser.EnableHeadersVisualStyles = false;
            DvgMduser.GridColor = Color.White;
            DvgMduser.Location = new Point(0, 125);
            DvgMduser.Name = "DvgMduser";
            DvgMduser.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DvgMduser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DvgMduser.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumSpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            DvgMduser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            DvgMduser.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DvgMduser.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.MediumSpringGreen;
            DvgMduser.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            DvgMduser.RowTemplate.Height = 36;
            DvgMduser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DvgMduser.Size = new Size(562, 306);
            DvgMduser.TabIndex = 66;
            DvgMduser.CellDoubleClick += DvgMduser_CellDoubleClick;
            // 
            // IdProveedor
            // 
            IdProveedor.HeaderText = "Id";
            IdProveedor.Name = "IdProveedor";
            IdProveedor.ReadOnly = true;
            IdProveedor.Visible = false;
            // 
            // RUC
            // 
            RUC.HeaderText = "RUC";
            RUC.Name = "RUC";
            RUC.ReadOnly = true;
            RUC.Width = 160;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 400;
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.FromArgb(8, 92, 63);
            bigLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(1, 1);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(657, 36);
            bigLabel1.TabIndex = 71;
            bigLabel1.Text = "Lista de Proveedores*";
            // 
            // MdProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(564, 430);
            Controls.Add(bigLabel1);
            Controls.Add(DvgMduser);
            Controls.Add(btneliminar);
            Controls.Add(btnbuscar);
            Controls.Add(txtSearchProve);
            Controls.Add(cbSearchProve);
            Controls.Add(label13);
            ForeColor = Color.Black;
            Name = "MdProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MdProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)DvgMduser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchProve;
        private ComboBox cbSearchProve;
        private Label label13;
        private Button btnbuscar;
        private Button btneliminar;
        private DataGridView DvgMduser;
        private DataGridViewTextBoxColumn IdProveedor;
        private DataGridViewTextBoxColumn RUC;
        private DataGridViewTextBoxColumn RazonSocial;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}