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
            // Combo Buscar por según las columnas visibles de la tabla
            foreach (DataGridViewColumn columna in dgvProducto.Columns)
            {
                if (columna.Visible == true)
                {
                    cbSearchPr.Items.Add(new OptionsComboBox() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbSearchPr.DisplayMember = "texto";
            cbSearchPr.ValueMember = "valor";
            if (cbSearchPr.Items.Count > 0) cbSearchPr.SelectedIndex = 0;

            // Lista de productos solo los activos
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
            if (cbSearchPr.SelectedItem == null) return;

            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearchPr.SelectedItem).valor);
            string texto = txtSearchPr.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                if (row.IsNewRow) continue; // filtrador de cuando muestra y cuando oculta

                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchPr.Clear();

            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                row.Visible = true;
            }
        }
        // comentarios de textos dependiendo lo que seleccione el usuario
        private void cbSearchPr_TabIndexChanged(object sender, EventArgs e)
        {
            OptionsComboBox variabletemporal = (OptionsComboBox)cbSearchPr.SelectedItem;//convertimos el obj seleccionado al tipo de nuestra clse otioncomboBox
            string nombcbbox = variabletemporal.texto;

            //pasamos los textos de la opcion elegida a Codigo etc para evaluar y cambiar el placeholdertext y enlazamos con el diseñador

            if (nombcbbox == "Codigo")
            {
                txtSearchPr.PlaceholderText = "EJ: P0001";
            }
            else if (nombcbbox == "Nombre")
            {
                txtSearchPr.PlaceholderText = "EJ: Arroz";

            }
            else if (nombcbbox == "Categoria")
            {
                txtSearchPr.PlaceholderText = "EJ: Granos Básicos";

            }
            else
            {
                txtSearchPr.PlaceholderText = "Buscar...";
            }
        }

        private void txtSearchPr_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnSearch.PerformClick();
                txtSearchPr.Focus();
            }
        }
    }
}