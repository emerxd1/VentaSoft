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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();

            // Asegura que el evento esté conectado aunque no esté en el diseñador
            dgvCategory.CellClick += dgvCategory_CellClick;
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtDescripcion.Text = "";
            txtName.Text = "";
            txtId.Clear();

            if (cbEstado.Items.Count > 0)
            {
                cbEstado.SelectedIndex = -1;
                cbEstado.Text = "Seleccione un estado";
                cbEstado.ForeColor = Color.Gray;
            }
        }

        private void FrmCategory_Load_1(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Clear();
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";

            // Cargar combo de búsqueda
            cbSearch.Items.Clear();
            foreach (DataGridViewColumn columna in dgvCategory.Columns)
            {
                if (columna.Visible && columna.Name != "btnSeleccionar")
                {
                    cbSearch.Items.Add(new OptionsComboBox()
                    {
                        valor = columna.Name,
                        texto = columna.HeaderText
                    });
                }
            }

            cbSearch.ValueMember = "valor";
            cbSearch.DisplayMember = "texto";

            if (cbSearch.Items.Count > 0)
            {
                cbSearch.SelectedIndex = 0;
            }

            // Cargar categorías desde la BD
            List<Entidad_Categoria> listCategoria = new S_Category().Lister();

            foreach (Entidad_Categoria item in listCategoria)
            {
                int fila = dgvCategory.Rows.Add();
                DataGridViewRow row = dgvCategory.Rows[fila];

                row.Tag = item; // importante para luego cargar la fila al hacer click

                row.Cells["IdCategory"].Value = item.IdCategoria;
                row.Cells["NameCategory"].Value = item.Nombre;
                row.Cells["DescripcionCategory"].Value = item.Descripcion;
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";
            }
        }

        private void dgvCategory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Check.Width;
                var h = Properties.Resources.Check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.Check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void AplicarFiltro()
        {
            if (cbSearch.SelectedItem == null)
            {
                return;
            }

            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearch.SelectedItem).valor);
            string texto = txtSearch.Text.Trim().ToUpper();

            dgvCategory.CurrentCell = null;

            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // CAMBIO: Se obtiene el valor del estado sin retornar anticipadamente.
                // Si no hay selección, se pasa -1 para que Validar() lo reporte junto
                // con los demás errores.
                var estadoSeleccionado = cbEstado.SelectedItem as OptionsComboBox;
                int valorEstado = -1;

                if (estadoSeleccionado != null)
                {
                    int.TryParse(estadoSeleccionado.valor.ToString(), out valorEstado);
                }

                Entidad_Categoria oCategoria = new Entidad_Categoria()
                {
                    Nombre = txtName.Text,
                    Descripcion = txtDescripcion.Text,
                    Estado = valorEstado == 1
                };

                var servicio = new S_Category();

                // CAMBIO: Se pasa valorEstado para que Validar() también verifique el estado.
                bool valido = servicio.Validar(oCategoria, out string errores, valorEstado);

                if (!valido)
                {
                    MessageBox.Show(errores, "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int idCategoryGenerated = servicio.Register(oCategoria, out string Mensaje, valorEstado);

                if (idCategoryGenerated > 0)
                {
                    int fila = dgvCategory.Rows.Add();
                    DataGridViewRow row = dgvCategory.Rows[fila];

                    row.Tag = new Entidad_Categoria()
                    {
                        IdCategoria = idCategoryGenerated,
                        Nombre = oCategoria.Nombre,
                        Descripcion = oCategoria.Descripcion,
                        Estado = oCategoria.Estado
                    };

                    row.Cells["IdCategory"].Value = idCategoryGenerated;
                    row.Cells["NameCategory"].Value = oCategoria.Nombre;
                    row.Cells["DescripcionCategory"].Value = oCategoria.Descripcion;
                    row.Cells["EstadoValor"].Value = valorEstado;
                    row.Cells["Estado"].Value = estadoSeleccionado.texto;

                    MessageBox.Show("Categoria registrada correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la categoria: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Limpiar();
            }
        }

        private int ObtenerIdSeleccionado()
        {
            // txtId viene como "ID#5"
            return int.TryParse(txtId.Text.Replace("ID#", "").Trim(), out int id) ? id : 0;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            int idCategoria = ObtenerIdSeleccionado();

            if (txtIndice.Text == "-1" || idCategoria == 0)
            {
                MessageBox.Show("Debe seleccionar una categoria para actualizar.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea actualizar la categoria?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                return;
            }

            // CAMBIO: Misma lógica que en btnAdd_Click para consistencia.
            var estadoSeleccionado = cbEstado.SelectedItem as OptionsComboBox;
            int valorEstado = -1;

            if (estadoSeleccionado != null)
            {
                int.TryParse(estadoSeleccionado.valor.ToString(), out valorEstado);
            }

            Entidad_Categoria oCategoria = new Entidad_Categoria()
            {
                IdCategoria = idCategoria,
                Nombre = txtName.Text,
                Descripcion = txtDescripcion.Text,
                Estado = valorEstado == 1
            };

            // CAMBIO: Se usa la sobrecarga con valorEstado.
            bool result = new S_Category().Edit(oCategoria, out string Mensaje, valorEstado);

            if (result)
            {
                int indice = Convert.ToInt32(txtIndice.Text);

                if (indice >= 0 && indice < dgvCategory.Rows.Count)
                {
                    DataGridViewRow row = dgvCategory.Rows[indice];

                    row.Tag = oCategoria;

                    row.Cells["IdCategory"].Value = oCategoria.IdCategoria;
                    row.Cells["NameCategory"].Value = oCategoria.Nombre;
                    row.Cells["DescripcionCategory"].Value = oCategoria.Descripcion;
                    row.Cells["EstadoValor"].Value = valorEstado;
                    row.Cells["Estado"].Value = estadoSeleccionado.texto;
                }

                MessageBox.Show("Categoria actualizada correctamente.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Replace("ID#", "").Trim(), out int idCategoria) || idCategoria == 0)
            {
                MessageBox.Show("Seleccione una Categoria de la lista para eliminar.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta Categoria?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Entidad_Categoria oCategoria = new Entidad_Categoria()
                {
                    IdCategoria = idCategoria
                };

                bool result = new S_Category().Delete(oCategoria, out string Mensaje);

                if (result)
                {
                    int indice = Convert.ToInt32(txtIndice.Text);

                    if (indice >= 0 && indice < dgvCategory.Rows.Count)
                    {
                        dgvCategory.Rows.RemoveAt(indice);
                    }

                    MessageBox.Show("Categoria eliminada correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCategory.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvCategory.Rows[e.RowIndex];

            if (row.Tag is not Entidad_Categoria categoria)
            {
                return;
            }

            txtIndice.Text = e.RowIndex.ToString();
            txtId.Text = "ID#" + categoria.IdCategoria;
            txtName.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;

            int valorEstado = categoria.Estado ? 1 : 0;

            foreach (OptionsComboBox oc in cbEstado.Items)
            {
                if (Convert.ToInt32(oc.valor) == valorEstado)
                {
                    cbEstado.SelectedItem = oc;
                    break;
                }
            }

            cbEstado.ForeColor = Color.Black;
        }
    }
}
