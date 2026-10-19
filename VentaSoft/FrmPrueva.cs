using ModernControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class FrmPrueva : Form
    {
        public FrmPrueva()
        {
            InitializeComponent();
            var g = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.None,
                GridColor = Color.White,
                RowHeadersVisible = false,
                AllowUserToAddRows = false
            };
            g.Columns.Add("dni", "DNI");
            g.Columns.Add("cliente", "Cliente");
            g.Columns.Add("correo", "Correo");
            g.Rows.Add("001-020202-1805P", "CLIENTE TEST", "cliente1@gmail.com");
            g.Rows.Add("001-181104-1040M", "Emer Castellon", "emercastellon26@gmail.com");
            Controls.Add(g);
        }

        private void FrmPrueva_Load(object sender, EventArgs e)
        {

        }
    }
}
