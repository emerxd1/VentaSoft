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
        }

        //-------------------btn pra actualizar una categoria------------------------//
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea actualizar la categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            else
            {
                if (txtIndice.Text == "-1")
                {
                    MessageBox.Show("Debe seleccionar una categoria para actualizar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Entidad_Categoria oCategoria = new Entidad_Categoria() // instancia de la entidad categoria, para enviar a la capa de negocio
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Nombre = txtName.Text,
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1 ? true : false
            };

            MessageBox.Show($"IdCategoria: '{oCategoria.IdCategoria}' - Nombre: '{oCategoria.Nombre}'");
            bool result = new S_Category().Edit(oCategoria, out string Mensaje);

            // Si la actualizacion fue exitosa, se refleja el cambio en el DataGridView
            if (result)
            {
                var estadoSeleccionado = (OptionsComboBox)cbEstado.SelectedItem;

                DataGridViewRow row = dgvCategory.Rows[Convert.ToInt32(txtIndice.Text)];

                row.Cells["IdCategory"].Value = oCategoria.IdCategoria;
                row.Cells["NameCategory"].Value = oCategoria.Nombre;
                row.Cells["DescripcionCategory"].Value = oCategoria.Descripcion;
                row.Cells["EstadoValor"].Value = estadoSeleccionado.valor; // se guarda el valor real, no el .ToString()
                row.Cells["Estado"].Value = estadoSeleccionado.texto;

                MessageBox.Show("Categoria actualizada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Limpiar();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Entidad_Categoria oCategoria = new Entidad_Categoria() // instancia de la entidad Categoria, para enviar a la capa de negocio
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Nombre = txtName.Text,
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1 ? true : false
            };

            int idCategoryGenerated = new S_Category().Register(oCategoria, out string Mensaje);

            // Si el id generado es distinto de 0, significa que se registró correctamente, entonces se agrega al DataGridView
            if (idCategoryGenerated != 0)
            {

                var estadoSeleccionado = (OptionsComboBox)cbEstado.SelectedItem;

                // Se agrega la fila vacía y se asignan los valores por NOMBRE de columna
                // (evita el desfase que ocurría con Rows.Add(object[]) por posición)
                int fila = dgvCategory.Rows.Add();
                DataGridViewRow row = dgvCategory.Rows[fila];

                row.Cells["IdCategory"].Value = idCategoryGenerated;
                row.Cells["NameCategory"].Value = txtName.Text;
                row.Cells["DescripcionCategory"].Value = lblDescripcion.Text;
                row.Cells["EstadoValor"].Value = estadoSeleccionado.valor;
                row.Cells["Estado"].Value = estadoSeleccionado.texto;

                MessageBox.Show("Categoria registrada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Limpiar();
        }


        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtDescripcion.Text = "";
            txtName.Text = "";
            cbEstado.SelectedIndex = 0;
            txtId.Clear();
        }

        private void FrmCategory_Load_1(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });

            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";
            cbEstado.SelectedIndex = 0;


            // Cargar combo de búsqueda (según columnas visibles del grid)
            foreach (DataGridViewColumn Columna in dgvCategory.Columns)
            {
                if (Columna.Visible == true && Columna.Name != "btnSeleccionar")
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

            // Cargar usuarios en el DataGridView (asignación por NOMBRE de columna, no por posición)
            List<Entidad_Categoria> listCategoria = new S_Category().Lister();

            foreach (Entidad_Categoria item in listCategoria)
            {
                int fila = dgvCategory.Rows.Add(); // agrega una fila vacía y devuelve su índice
                DataGridViewRow row = dgvCategory.Rows[fila];

                row.Cells["IdCategory"].Value = item.IdCategoria;
                row.Cells["NameCategory"].Value = item.Nombre;
                row.Cells["DescripcionCategory"].Value = item.Descripcion;
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";


            }

        }

        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvCategory.Columns[e.ColumnIndex].Name == "Estado")
            {
                e.CellStyle.BackColor = e.Value.ToString() == "Activo" ? Color.LightGreen : Color.Salmon;
            }
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valida si y solo si se selecciona el btn seleccionar, muestra los datos con respecto al índice
            if (dgvCategory.Columns[e.ColumnIndex].Name != "btnSeleccionar") return;

            int indice = e.RowIndex;
            if (indice < 0) return;
            {
                txtIndice.Text = indice.ToString();

                // Mostrar textos en los textbox
                txtId.Text = Convert.ToString(dgvCategory.Rows[indice].Cells["IdCategory"].Value);
                txtName.Text = Convert.ToString(dgvCategory.Rows[indice].Cells["NameCategory"].Value);
                txtDescripcion.Text = Convert.ToString(dgvCategory.Rows[indice].Cells["DescripcionCategory"].Value);
            }

            // Mostrar dato de Estado en el combobox
            // Protección contra DBNull: si la celda no tiene valor, se usa 0 en vez de intentar convertir DBNull
            object valorEstado = dgvCategory.Rows[indice].Cells["EstadoValor"].Value;
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

        private void dgvCategory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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


        //BOTON PARA LIMPIAR TEXTOBOX DE DETALLES DE CATEGORIA
        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validación segura: evita la excepción de Convert.ToInt32("") cuando no hay selección
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int idCategoria) || idCategoria == 0)
            {
                MessageBox.Show("Seleccione una Categoria de la lista para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta Categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Entidad_Categoria oCategoria = new Entidad_Categoria() // instancia de la entidad categoria, para enviar a la capa de negocio
                {
                    IdCategoria = idCategoria
                };

                bool result = new S_Category().Delete(oCategoria, out string Mensaje);

                if (result)
                {
                    dgvCategory.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    MessageBox.Show("Categoria eliminada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            // si dr == DialogResult.No, simplemente no se hace nada (el usuario canceló)
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearch.SelectedItem).valor);

            if (dgvCategory.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCategory.Rows)
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

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Entidad_Categoria oCategoria = new Entidad_Categoria() // instancia de la entidad Categoria, para enviar a la capa de negocio
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Nombre = txtName.Text,
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1 ? true : false
            };

            int idCategoryGenerated = new S_Category().Register(oCategoria, out string Mensaje);

            // Si el id generado es distinto de 0, significa que se registró correctamente, entonces se agrega al DataGridView
            if (idCategoryGenerated != 0)
            {

                var estadoSeleccionado = (OptionsComboBox)cbEstado.SelectedItem;

                // Se agrega la fila vacía y se asignan los valores por NOMBRE de columna
                // (evita el desfase que ocurría con Rows.Add(object[]) por posición)
                int fila = dgvCategory.Rows.Add();
                DataGridViewRow row = dgvCategory.Rows[fila];

                row.Cells["IdCategory"].Value = idCategoryGenerated;
                row.Cells["NameCategory"].Value = txtName.Text;
                row.Cells["DescripcionCategory"].Value = lblDescripcion.Text;
                row.Cells["EstadoValor"].Value = estadoSeleccionado.valor;
                row.Cells["Estado"].Value = estadoSeleccionado.texto;

                MessageBox.Show("Categoria registrada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Limpiar();
        }

    }
}

