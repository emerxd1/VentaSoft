using Main.Utilities;
using ModuloEntidades;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Main.Modales
{
    public partial class MdProductos : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Entidad_Producto _Entidad_Producto { get; set; }

        public MdProductos()
        {
            InitializeComponent();
        }

        private void MdProductos_Load(object sender, EventArgs e)
        {
            // Combo "Buscar por" según las columnas visibles de la tabla
            foreach (DataGridViewColumn columna in dgvProducto.Columns)
            {
                if (columna.Visible == true)
                {
                    cbSearch.Items.Add(new OptionsComboBox() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbSearch.DisplayMember = "texto";
            cbSearch.ValueMember = "valor";
            if (cbSearch.Items.Count > 0) cbSearch.SelectedIndex = 0;

            // Lista de productos (solo activos)
            List<Entidad_Producto> lista = new S_Product().Lister();

            foreach (Entidad_Producto item in lista)
            {
                if (!item.Estado) continue;


                int index = dgvProducto.Rows.Add(new object[] {
                    item.IdProducto, item.Codigo, item.Nombre,
                    item.oCategoria?.Nombre ?? "",
                    item.PrecioCompra, item.PrecioVenta
                });

                // se guarda el producto en la fila para leer stock y precios al hacer doble clic
                dgvProducto.Rows[index].Tag = item;
            }
        }

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvProducto.Rows[e.RowIndex];
            if (fila.IsNewRow || fila.Cells[0].Value == null) return;


            Entidad_Producto seleccionado = fila.Tag as Entidad_Producto;
            if (seleccionado == null) return;

            _Entidad_Producto = new Entidad_Producto()
            {
                IdProducto = Convert.ToInt32(fila.Cells[0].Value),
                Codigo = fila.Cells[1].Value?.ToString() ?? "",
                Nombre = fila.Cells[2].Value?.ToString() ?? "",
                Stock = seleccionado.Stock,
                PrecioCompra = seleccionado.PrecioCompra,
                PrecioVenta = seleccionado.PrecioVenta
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSearch.SelectedItem == null) return;

            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearch.SelectedItem).valor);
            string texto = txtSearch.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                if (row.IsNewRow) continue; // filtrador de cuando muestra y cuando oculta

                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                row.Visible = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}