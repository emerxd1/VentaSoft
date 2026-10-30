using ClosedXML.Excel;
using Data;
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

namespace Main
{
    public partial class FrmProducts : Form
    {
        private readonly S_Product _servicio = new S_Product();

        public FrmProducts()
        {
            InitializeComponent();
            new EscaladoProporcional(this);
        }

        /*==========================CARGAR DATOS EN EVENTO LOAD==========================*/
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";

            // Cargar combo de Categoria
            List<Entidad_Categoria> listCategory = new S_Category().Lister();
            foreach (Entidad_Categoria item in listCategory)
            {
                cbCategoria.Items.Add(new OptionsComboBox() { valor = item.IdCategoria, texto = item.Nombre });
            }
            cbCategoria.ValueMember = "valor";
            cbCategoria.DisplayMember = "texto";

            foreach (DataGridViewColumn Columna in dgvProducto.Columns)
            {
                if (Columna.Visible)
                {
                    cbSearch.Items.Add(new OptionsComboBox() { valor = Columna.Name, texto = Columna.HeaderText });
                }
            }
            cbSearch.ValueMember = "valor";
            cbSearch.DisplayMember = "texto";
            if (cbSearch.Items.Count > 0)
            {
                cbSearch.SelectedIndex = 0;
            }

            RecargarGrid();

            // Deja el formulario en su estado inicial (combos con texto guía en gris)
            Limpiar();
        }

        /*===========RECARGA EL GRID DESDE LA BASE DE DATOS (incluye columnas calculadas como Codigo)===========*/
        private void RecargarGrid()
        {
            dgvProducto.CurrentCell = null;
            dgvProducto.Rows.Clear();

            List<Entidad_Producto> listProduct = _servicio.Lister();

            foreach (Entidad_Producto item in listProduct)
            {
                int fila = dgvProducto.Rows.Add();
                DataGridViewRow row = dgvProducto.Rows[fila];

                // Se guarda el producto completo en la fila: al seleccionarla se leen de aquí los datos.
                row.Tag = item;

                row.Cells["IdProducto"].Value = item.IdProducto;
                row.Cells["Codigo"].Value = item.Codigo;
                row.Cells["NombreProducto"].Value = item.Nombre;
                row.Cells["Descripcion"].Value = item.Descripcion;
                row.Cells["PrecioVenta"].Value = item.PrecioVenta;
                row.Cells["PrecioCompra"].Value = item.PrecioCompra;
                row.Cells["Stock"].Value = item.Stock;
                row.Cells["IdCategoria"].Value = item.oCategoria?.IdCategoria ?? 0; // oculta, para comparaciones internas
                row.Cells["NameCategoria"].Value = item.oCategoria?.Nombre ?? "";   // visible
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";
            }

            // Si hay texto en la búsqueda, se vuelve a aplicar sobre los datos recargados.
            AplicarFiltro();
        }

        // Devuelve el Id del producto seleccionado. Devuelve 0 si no hay ninguno.
        private int ObtenerIdSeleccionado()
        {
            return int.TryParse(txtIdProducto.Text.Replace("ID#", "").Trim(), out int id) ? id : 0;
            return 0;
        }

        //METODO PARA LIMPIAR LOS CAMPOS DEL FORMULARIO
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtIdProducto.Clear();
            txtCodigo.Clear();
            txtNameProducto.Clear();
            txtDescripcion.Clear();
            txtPrecioC.Clear();
            txtPrecioV.Clear();
            txtStock.Clear();

            cbCategoria.SelectedIndex = -1;
            cbCategoria.Text = "Seleccione una categoría";
            cbCategoria.ForeColor = Color.Gray;

            cbEstado.SelectedIndex = -1;
            cbEstado.Text = "Seleccione un estado";
            cbEstado.ForeColor = Color.Gray;
        }

        // Aplica el filtro de búsqueda sobre el grid según la columna elegida.
        // Con el texto vacío, todas las filas vuelven a mostrarse.
        private void AplicarFiltro()
        {
            var columnaSeleccionada = cbSearch.SelectedItem as OptionsComboBox;
            if (columnaSeleccionada == null)
            {
                return;
            }

            string columnFiltro = Convert.ToString(columnaSeleccionada.valor);
            string texto = txtSearch.Text.Trim().ToUpper();

            // Una fila con la celda actual seleccionada no se puede ocultar (lanza InvalidOperationException).
            dgvProducto.CurrentCell = null;

            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }

        // Lee el formulario, lo valida (servicio: nombre, descripción, categoría, precios, stock y estado)
        // y devuelve la entidad lista para enviar. Si hay errores los muestra y devuelve false.
        // idProducto = 0 al registrar (lo genera la base de datos).
        private bool TryLeerFormulario(int idProducto, out Entidad_Producto oProducto, out int valorEstado)
        {
            oProducto = null;

            var estadoSeleccionado = cbEstado.SelectedItem as OptionsComboBox;
            var categoriaSeleccionada = cbCategoria.SelectedItem as OptionsComboBox;
            valorEstado = estadoSeleccionado == null ? -1 : Convert.ToInt32(estadoSeleccionado.valor);

            // Intentamos convertir, si falla (como en campos vacíos), asignamos 0.
            // Esto permite que el flujo continúe hacia el servicio.
            decimal.TryParse(txtPrecioC.Text, out decimal precioCompra);
            decimal.TryParse(txtPrecioV.Text, out decimal precioVenta);
            int.TryParse(txtStock.Text, out int stock);

            oProducto = new Entidad_Producto()
            {
                IdProducto = idProducto,
                Nombre = txtNameProducto.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Stock = stock,
                oCategoria = new Entidad_Categoria()
                {
                    IdCategoria = categoriaSeleccionada == null ? 0 : Convert.ToInt32(categoriaSeleccionada.valor)
                },
                Estado = valorEstado == 1
            };

            // AHORA SÍ: Todo se valida aquí y salen tus mensajes de S_Product
            if (!_servicio.Validar(oProducto, out string errores, valorEstado))
            {
                MessageBox.Show(errores, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryLeerFormulario(0, out Entidad_Producto oProducto, out int valorEstado))
                    return;

                int idGenerated = _servicio.Register(oProducto, out string Mensaje, valorEstado);

                // Si el id generado es distinto de 0, significa que se registró correctamente
                if (idGenerated != 0)
                {
                    // Se recarga el grid desde la BD para reflejar el Codigo real generado por la columna calculada.
                    RecargarGrid();

                    MessageBox.Show("Producto registrado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nombres de columnas a excluir del reporte
            string[] columnasExcluidas = { "IdCategoria", "EstadoValor" };

            DataTable dt = new DataTable();
            List<int> colIndexes = new List<int>();

            foreach (DataGridViewColumn column in dgvProducto.Columns)
            {
                if (!(column is DataGridViewButtonColumn) && !columnasExcluidas.Contains(column.Name))
                {
                    string encabezado = string.IsNullOrEmpty(column.HeaderText) ? column.Name : column.HeaderText;
                    dt.Columns.Add(encabezado, typeof(string));
                    colIndexes.Add(column.Index);
                }
            }

            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                if (!row.IsNewRow)
                {
                    object[] values = new object[colIndexes.Count];
                    for (int i = 0; i < colIndexes.Count; i++)
                    {
                        values[i] = row.Cells[colIndexes[i]].Value?.ToString() ?? "";
                    }
                    dt.Rows.Add(values);
                }
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyy_HHmmss"));
            savefile.Filter = "Excel Files (*.xlsx)|*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar reporte: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = ObtenerIdSeleccionado();

                if (txtIndice.Text == "-1" || idProducto == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto para actualizar.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!TryLeerFormulario(idProducto, out Entidad_Producto oProducto, out int valorEstado))
                    return;

                DialogResult dr = MessageBox.Show("¿Está seguro que desea actualizar el producto?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                    return;

                bool isUpdated = _servicio.Edit(oProducto, out string Mensaje, valorEstado);

                if (isUpdated)
                {
                    RecargarGrid();

                    MessageBox.Show("Producto actualizado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idProducto = ObtenerIdSeleccionado();

                if (idProducto == 0)
                {
                    MessageBox.Show("Seleccione un producto de la lista para eliminar.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el producto?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                    return;

                bool result = _servicio.Delete(new Entidad_Producto() { IdProducto = idProducto }, out string Mensaje);

                if (result)
                {
                    RecargarGrid();

                    MessageBox.Show("Producto eliminado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el producto: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void dgvProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProducto.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvProducto.Rows[e.RowIndex];

            // El producto completo se guardó en Tag al cargar el grid
            if (!(row.Tag is Entidad_Producto producto)) return;

            txtIndice.Text = e.RowIndex.ToString();
            txtIdProducto.Text = "ID# " + producto.IdProducto;
            txtCodigo.Text = producto.Codigo;
            txtNameProducto.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtPrecioV.Text = producto.PrecioVenta.ToString();
            txtPrecioC.Text = producto.PrecioCompra.ToString();
            txtStock.Text = producto.Stock.ToString();

            // Categoría
            cbCategoria.SelectedIndex = -1;
            int idCategoria = producto.oCategoria?.IdCategoria ?? 0;
            foreach (OptionsComboBox oc in cbCategoria.Items)
            {
                if (Convert.ToInt32(oc.valor) == idCategoria)
                {
                    cbCategoria.SelectedItem = oc;
                    break;
                }
            }

            // Estado
            cbEstado.SelectedIndex = -1;
            int valorEstado = producto.Estado ? 1 : 0;
            foreach (OptionsComboBox oc in cbEstado.Items)
            {
                if (Convert.ToInt32(oc.valor) == valorEstado)
                {
                    cbEstado.SelectedItem = oc;
                    break;
                }
            }

            // Limpiar() deja los combos en gris; aquí se restaura el color normal
            cbCategoria.ForeColor = Color.Black;
            cbEstado.ForeColor = Color.Black;

        }
    }
}