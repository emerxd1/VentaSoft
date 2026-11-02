using Main.Utilities;
using ModuloEntidades;
using Store;
using System.Text;

namespace Main
{
    public partial class Frm_Proveedor : Form
    {
        private readonly S_Proveedor _servicio = new S_Proveedor();

        public Frm_Proveedor()
        {
            InitializeComponent();
            new EscaladoProporcional(this);
        }

        // Devuelve el Id numérico mostrado en txtId ("ID# 5" -> 5). Devuelve 0 si no hay ninguno.
        private int ObtenerIdSeleccionado()
        {
            return int.TryParse(txtId.Text.Replace("ID#", "").Trim(), out int id) ? id : 0;
        }

        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";

            // Cargar combo de búsqueda (según columnas visibles del grid)
            foreach (DataGridViewColumn Columna in dgvProveedor.Columns)
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

            CargarProveedores();
        }

        // Carga (o recarga) el grid desde la base de datos.
        private void CargarProveedores()
        {
            dgvProveedor.CurrentCell = null;
            dgvProveedor.Rows.Clear();

            List<Entidad_Proveedor> lista = _servicio.Lister()
                .OrderBy(p => p.RazonSocial)
                .ToList();

            foreach (Entidad_Proveedor item in lista)
            {
                int fila = dgvProveedor.Rows.Add();
                DataGridViewRow row = dgvProveedor.Rows[fila];

                // Se guarda el proveedor completo en la fila: al seleccionarla se leen de aquí los datos.
                row.Tag = item;

                row.Cells["IdProveedor"].Value = item.IdProveedor;
                row.Cells["ruc"].Value = item.RUC;
                row.Cells["Name1"].Value = item.RazonSocial;
                row.Cells["Email"].Value = item.Correo;
                row.Cells["NumTelefono"].Value = item.Telefono;
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";
            }

            // Si hay texto en la búsqueda, se vuelve a aplicar sobre los datos recargados.
            AplicarFiltro();
        }

        // METODO PARA LIMPIAR LOS CAMPOS DEL FORMULARIO
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "ID#";
            txtRUC.Clear();
            txtName1.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();

            cbEstado.SelectedIndex = -1;
            cbEstado.Text = "Seleccione un estado";
            cbEstado.ForeColor = Color.Gray;

            txtRUC.Focus();
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
            dgvProveedor.CurrentCell = null;

            foreach (DataGridViewRow row in dgvProveedor.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }

        // Lee el formulario, lo valida y devuelve la entidad lista para enviar.
        // Si hay errores los muestra y devuelve false.
        // idProveedor = 0 al registrar (lo genera la base de datos).
        private bool TryLeerFormulario(int idProveedor, out Entidad_Proveedor oProveedor)
        {
            // as devuelve null (en vez de lanzar error) si no hay nada seleccionado
            var estadoSeleccionado = cbEstado.SelectedItem as OptionsComboBox;

            oProveedor = new Entidad_Proveedor()
            {
                IdProveedor = idProveedor,
                RUC = txtRUC.Text.Trim(),
                RazonSocial = txtName1.Text.Trim(),
                Correo = txtEmail.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Estado = estadoSeleccionado != null && Convert.ToInt32(estadoSeleccionado.valor) == 1
            };

            bool valido = _servicio.Validar(oProveedor, out string errores);

            var extras = new StringBuilder();
            if (estadoSeleccionado == null)
                extras.Append("Debe seleccionar un estado.\n");

            if (extras.Length > 0)
            {
                if (valido)
                    errores = "Se encontraron los siguientes errores:\n";

                errores += extras.ToString();
                valido = false;
            }

            if (!valido)
            {
                MessageBox.Show(errores, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        /* BOTON PARA REGISTRAR UN PROVEEDOR */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryLeerFormulario(0, out Entidad_Proveedor oProveedor))
                    return;

                int idGenerado = _servicio.Register(oProveedor, out string Message);

                // Id distinto de 0 = registro exitoso.
                if (idGenerado != 0)
                {
                    CargarProveedores();

                    MessageBox.Show("Proveedor registrado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el proveedor: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        /* BOTON PARA ACTUALIZAR UN PROVEEDOR */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idProveedor = ObtenerIdSeleccionado();

                if (txtIndice.Text == "-1" || idProveedor == 0)
                {
                    MessageBox.Show("Debe seleccionar un proveedor para actualizar.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!TryLeerFormulario(idProveedor, out Entidad_Proveedor oProveedor))
                    return;

                bool isUpdated = _servicio.Edit(oProveedor, out string Message);

                if (isUpdated)
                {
                    CargarProveedores();

                    MessageBox.Show("Proveedor actualizado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el proveedor: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }


        /* BOTON PARA LIMPIAR EL FORMULARIO */
        private void btnClear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Búsqueda en vivo: se filtra mientras se escribe.
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        // Al hacer clic en una fila se cargan sus datos en el formulario.
        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProveedor.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];

            // El proveedor completo se guardó en Tag al cargar el grid
            if (!(row.Tag is Entidad_Proveedor proveedor)) return;

            txtIndice.Text = e.RowIndex.ToString();
            txtId.Text = "ID# " + proveedor.IdProveedor;

            txtRUC.Text = proveedor.RUC;
            txtName1.Text = proveedor.RazonSocial;
            txtEmail.Text = proveedor.Correo;
            txtTelefono.Text = proveedor.Telefono;

            // Estado
            cbEstado.SelectedIndex = -1;
            int valorEstado = proveedor.Estado ? 1 : 0;
            foreach (OptionsComboBox oc in cbEstado.Items)
            {
                if (Convert.ToInt32(oc.valor) == valorEstado)
                {
                    cbEstado.SelectedItem = oc;
                    break;
                }
            }

            // Limpiar() deja el combo en gris; aquí se restaura el color normal
            cbEstado.ForeColor = Color.Black;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idProveedor = ObtenerIdSeleccionado();

                if (idProveedor == 0)
                {
                    MessageBox.Show("Seleccione un proveedor de la lista para eliminar.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este proveedor?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                    return;

                bool result = _servicio.Delete(new Entidad_Proveedor() { IdProveedor = idProveedor }, out string Message);

                if (result)
                {
                    CargarProveedores();

                    MessageBox.Show("Proveedor eliminado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el proveedor: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}