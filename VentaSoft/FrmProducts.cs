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
        public FrmProducts()
        {
            InitializeComponent();
        }

        /*==========================CARGAR PRODUCTOS EN EVENTO LOAD==========================*/
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";
            cbEstado.SelectedIndex = 0;

            // Cargar combo de Categoria
            List<Entidad_Categoria> listCategory = new S_Category().Lister();
            foreach (Entidad_Categoria item in listCategory)
            {
                cbCategoria.Items.Add(new OptionsComboBox() { valor = item.IdCategoria, texto = item.Nombre });
            }
            cbCategoria.ValueMember = "valor";
            cbCategoria.DisplayMember = "texto";
            if (cbCategoria.Items.Count > 0)
            {
                cbCategoria.SelectedIndex = 0;
            }

            // Cargar combo de búsqueda (según columnas visibles del grid)
            foreach (DataGridViewColumn Columna in dgvProducto.Columns)
            {
                if (Columna.Visible == true && Columna.Name != "btnSeleccion")
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

            // Carga inicial de productos
            RecargarGrid();
        }

        /*===========RECARGA EL GRID DESDE LA BASE DE DATOS (incluye columnas calculadas como Codigo)===========*/
        private void RecargarGrid()
        {
            dgvProducto.Rows.Clear();

            List<Entidad_Producto> listProduct = new S_Product().Lister();

            foreach (Entidad_Producto item in listProduct)
            {
                int fila = dgvProducto.Rows.Add(); // agrega una fila vacía y devuelve su índice
                DataGridViewRow row = dgvProducto.Rows[fila];
                row.Cells["IdProducto"].Value = item.IdProducto;
                row.Cells["Codigo"].Value = item.Codigo;
                row.Cells["NombreProducto"].Value = item.Nombre;
                row.Cells["Descripcion"].Value = item.Descripcion;
                row.Cells["PrecioVenta"].Value = item.PrecioVenta;
                row.Cells["PrecioCompra"].Value = item.PrecioCompra;
                row.Cells["Stock"].Value = item.Stock;
                row.Cells["IdCategoria"].Value = item.oCategoria.IdCategoria; // oculta, para comparaciones internas
                row.Cells["NameCategoria"].Value = item.oCategoria.Nombre; // visible, se muestra al usuario
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";
            }
        }

        /*=====MÉTODO PARA VALIDAR Y OBTENER LOS DATOS NUMÉRICOS DEL FORMULARIO=====*/
        // Convierte los TextBox de texto a los tipos correctos (decimal/int) de forma segura.
        // Si algún campo no es válido, muestra un aviso, enfoca el campo y devuelve false
        // para que el método que lo llama pueda cancelar la operación (return) sin crashear.
        private bool TryObtenerDatosFormulario(out decimal precioCompra, out decimal precioVenta, out int stock)
        {
            precioCompra = 0;
            precioVenta = 0;
            stock = 0;

            if (!decimal.TryParse(txtPrecioC.Text, out precioCompra))
            {
                MessageBox.Show("El Precio de Compra debe ser un número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioC.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrecioV.Text, out precioVenta))
            {
                MessageBox.Show("El Precio de Venta debe ser un número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioV.Focus();
                return false;
            }

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("El Stock debe ser un número entero válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return false;
            }

            return true;
        }

        /*===================AGREGAR PRODUCTOS=======================================*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryObtenerDatosFormulario(out decimal precioCompra, out decimal precioVenta, out int stock))
                return;

            // NOTA: no se asigna Codigo aquí porque es una columna calculada en la base de datos;
            // la genera SQL Server automáticamente al insertar, no el usuario.
            Entidad_Producto oProducto = new Entidad_Producto()
            {
                Nombre = txtNameProducto.Text,
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Stock = stock,
                Descripcion = txtDescripcion.Text,
                oCategoria = new Entidad_Categoria() { IdCategoria = Convert.ToInt32(((OptionsComboBox)cbCategoria.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1
            };

            int idGenerated = new S_Product().Register(oProducto, out string Mensaje);

            // Si el id generado es distinto de 0, significa que se registró correctamente
            if (idGenerated != 0)
            {
                MessageBox.Show("Producto registrado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se recarga el grid desde la base de datos en vez de armar la fila a mano,
                // así se refleja el Codigo real generado por la columna calculada.
                RecargarGrid();
            }
            else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Limpiar();
        }

        //METODO PARA LIMPIAR LOS CAMPOS DEL FORMULARIO
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtIdProducto.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecioC.Clear();
            txtPrecioV.Clear();
            txtStock.Clear();
            txtNameProducto.Clear();
            cbCategoria.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
        }
        /*=================METODO PARA LIMPIAR TEXTBOX============================*/

        private void btnClean_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        /*boton para hcer busqueda por filtros*/
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearch.SelectedItem).valor);

            if (dgvProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (row.Cells[columnFiltro].Value.ToString().Trim().ToUpper().Contains(txtSearch.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }

                    else
                    {
                        row.Visible = false;
                    }

                }

            }
        }

        /*BOTON PARA ACTUALIZAR UN PRODUCTO*/
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtIndice.Text == "-1")
            {
                MessageBox.Show("Debe seleccionar un usuario para actualizar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!TryObtenerDatosFormulario(out decimal precioCompra, out decimal precioVenta, out int stock))
                return;

            if (!int.TryParse(txtIdProducto.Text, out int idProducto))
            {
                MessageBox.Show("No se pudo determinar el Id del producto a actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Entidad_Producto oProduct = new Entidad_Producto() // instancia de la entidad producto, para enviar a la capa de negocio
            {
                IdProducto = idProducto,
                Nombre = txtNameProducto.Text,
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta,
                Stock = stock,
                Descripcion = txtDescripcion.Text,
                oCategoria = new Entidad_Categoria() { IdCategoria = Convert.ToInt32(((OptionsComboBox)cbCategoria.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1
            };
            bool result = new S_Product().Edit(oProduct, out string Mensaje);

            // Si la actualizacion fue exitosa, se refleja el cambio en el DataGridView
            if (result)
            {
                DialogResult dr = MessageBox.Show("Esta seguro que desea actualizar el Producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;

                RecargarGrid();

                MessageBox.Show("Usuario actualizado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Limpiar();

        }

        /*ROJO SI ES ESTADO ESTA INACTIVO O VERDE EN CASO CONTRARIO Y TAMBIEN
         SI EL ESTOCK ES MENOR A 5 PINTA DE ROJO*/
        private void dgvProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvProducto.Columns[e.ColumnIndex].Name == "Estado")
            {
                e.CellStyle.BackColor = e.Value.ToString() == "Activo" ? Color.LightGreen : Color.Salmon;
            }

            if (this.dgvProducto.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int stock))
                {
                    e.CellStyle.BackColor = stock > 5 ? Color.LightGreen : Color.Salmon;
                }
            }
        }

        private void dgvProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // para ignorar el header

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valida si y solo si se selecciona el btn seleccionar, muestra los datos con respecto al índice
            if (dgvProducto.Columns[e.ColumnIndex].Name != "btnSeleccion") return;

            int indice = e.RowIndex;
            if (indice < 0) return;
            {
                txtIndice.Text = indice.ToString();

                // Mostrar textos en los textbox
                txtIdProducto.Text = Convert.ToString(dgvProducto.Rows[indice].Cells["IdProducto"].Value);
                txtCodigo.Text = Convert.ToString(dgvProducto.Rows[indice].Cells["Codigo"].Value);
                txtNameProducto.Text = Convert.ToString(dgvProducto.Rows[indice].Cells["NombreProducto"].Value);
                txtDescripcion.Text = Convert.ToString(dgvProducto.Rows[indice].Cells["Descripcion"].Value);
                txtPrecioV.Text = Convert.ToString(dgvProducto.Rows[indice].Cells["PrecioVenta"].Value);
                txtPrecioC.Text = Convert.ToString(dgvProducto.Rows[indice].Cells["PrecioCompra"].Value);
                txtStock.Text = Convert.ToString(dgvProducto.Rows[indice].Cells["Stock"].Value);
            }

            // Protección contra DBNull: si la celda no tiene valor, se usa 0 en vez de intentar convertir DBNull
            object valorIdCategoria = dgvProducto.Rows[indice].Cells["IdCategoria"].Value;
            int idRolFila = (valorIdCategoria == null || valorIdCategoria == DBNull.Value) ? 0 : Convert.ToInt32(valorIdCategoria);

            foreach (OptionsComboBox oc in cbCategoria.Items)
            {
                if (Convert.ToInt32(oc.valor) == idRolFila)
                {
                    cbCategoria.SelectedIndex = cbCategoria.Items.IndexOf(oc);
                    break;
                }
            }

            // Mostrar dato de Estado en el combobox
            // Protección contra DBNull: si la celda no tiene valor, se usa 0 en vez de intentar convertir DBNull
            object valorEstado = dgvProducto.Rows[indice].Cells["EstadoValor"].Value;
            int idEstadoFila = (valorEstado == null || valorEstado == DBNull.Value) ? 0 : Convert.ToInt32(valorEstado);

            foreach (OptionsComboBox oc1 in cbEstado.Items)
            {
                if (Convert.ToInt32(oc1.valor) == idEstadoFila)
                {
                    cbEstado.SelectedIndex = cbEstado.Items.IndexOf(oc1);
                    break;
                }

            }
        }
        /*BOTON PARA LIMPIAR BUSQUEDA Y RESTAURAR DATAGRIDVIEW*/
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in dgvProducto.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validación segura: evita la excepción de Convert.ToInt32("") cuando no hay selección
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text) || !int.TryParse(txtIdProducto.Text, out int idProducto) || idProducto == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Entidad_Producto oProducto = new Entidad_Producto() // instancia de la entidad producto, para enviar a la capa de negocio
                {
                    IdProducto = idProducto
                };

                bool result = new S_Product().Delete(oProducto, out string Mensaje);

                if (result)
                {
                    dgvProducto.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    MessageBox.Show("Producto eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            // si dr == DialogResult.No, simplemente no se hace nada (el usuario canceló)
        }
    }
}