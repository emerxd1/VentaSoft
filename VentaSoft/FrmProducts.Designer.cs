namespace Main
{
    partial class FrmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            panel1 = new Panel();
            dgvProducto = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnRegister = new Button();
            btnUpdatee = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 15);
            panel1.TabIndex = 2;
            // 
            // dgvProducto
            // 
            dgvProducto.BackgroundColor = SystemColors.ButtonFace;
            dgvProducto.BorderStyle = BorderStyle.None;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Columns.AddRange(new DataGridViewColumn[] { Codigo, NombreProducto, IdCategoria, PrecioVenta, Stock, Estado });
            dgvProducto.Location = new Point(12, 204);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.Size = new Size(643, 150);
            dgvProducto.TabIndex = 3;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Producto";
            NombreProducto.Name = "NombreProducto";
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "Categoria";
            IdCategoria.Name = "IdCategoria";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(192, 255, 192);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.Location = new Point(699, 167);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Registrar";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnUpdatee
            // 
            btnUpdatee.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdatee.Cursor = Cursors.Hand;
            btnUpdatee.FlatAppearance.BorderSize = 0;
            btnUpdatee.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnUpdatee.FlatStyle = FlatStyle.Flat;
            btnUpdatee.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdatee.Image = (Image)resources.GetObject("btnUpdatee.Image");
            btnUpdatee.Location = new Point(699, 212);
            btnUpdatee.Name = "btnUpdatee";
            btnUpdatee.Size = new Size(122, 40);
            btnUpdatee.TabIndex = 5;
            btnUpdatee.Text = "Actualizar";
            btnUpdatee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdatee.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(699, 257);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // FrmProducts
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(850, 600);
            ControlBox = false;
            Controls.Add(btnDelete);
            Controls.Add(btnUpdatee);
            Controls.Add(btnRegister);
            Controls.Add(dgvProducto);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvProducto;
        private Button btnRegister;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Estado;
        private Button btnUpdatee;
        private Button btnDelete;
    }
}