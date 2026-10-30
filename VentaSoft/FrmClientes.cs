using Data;
using Main.Utilities;
using ModuloEntidades;
using Store;


namespace Main
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            new EscaladoProporcional(this);
        }

        // Handlers vacíos: se conservan porque el diseñador puede referenciarlos.
        // Si ya no los necesitas, quita primero el enlace en el diseñador.
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {
        }

        // Verifica en el diseñador que este método esté enlazado al evento Load de FrmClientes.
        private void Frm_Users_Load(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";
            //cbEstado.SelectedIndex = 0;

            // Cargar combo de búsqueda (según columnas visibles del grid)
            foreach (DataGridViewColumn Columna in dgvClients.Columns)
            {
                if (Columna.Visible && Columna.Name != "btnSeleccion")
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

            CargarClientes();
        }

        // Carga (o recarga) el grid desde la base de datos.
        private void CargarClientes()
        {
            dgvClients.Rows.Clear();

            List<Entidad_Cliente> listClient = new S_Clients().Lister()
                .OrderBy(c => c.Nombre1)
                .ThenBy(c => c.Apellido1)
                .ToList();

            foreach (Entidad_Cliente item in listClient)
            {
                int fila = dgvClients.Rows.Add();
                DataGridViewRow row = dgvClients.Rows[fila];

                // Se guarda el cliente completo en la fila: al seleccionarla se leen
                // de aquí los nombres, apellidos y teléfono (el grid solo muestra algunos).
                row.Tag = item;

                row.Cells["IdCliente"].Value = item.IdCliente;
                row.Cells["DNI"].Value = item.DNI;

                // Mostrar Nombre1 y Apellido2 en una sola columna
                row.Cells["Cliente"].Value = string.Join(" ",
                    new[] { item.Nombre1, item.Apellido2 }
                        .Where(nombre => !string.IsNullOrWhiteSpace(nombre)));

                row.Cells["Email"].Value = item.Correo;
                row.Cells["NumTelefono"].Value = item.Telefono;
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";
            }
        }


        // Limpia los campos del formulario.
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtName1.Clear();
            txtName2.Clear();
            txtLastName1.Clear();
            txtLastName2.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            cbEstado.Text = "Seleccione un estado";
            cbEstado.ForeColor = Color.Gray;
            txtId.Text = "ID#";
            txtDni.Clear();
        }

        // Devuelve el Id numérico mostrado en txtId ("ID#5" -> 5). Devuelve 0 si no hay ninguno.
        // Úsalo al actualizar o eliminar.
        private int ObtenerIdSeleccionado()
        {
            return int.TryParse(txtId.Text.Replace("ID#", "").Trim(), out int id) ? id : 0;
        }

        // Aplica el filtro de búsqueda sobre el grid según la columna elegida.
        // Con el texto vacío, todas las filas vuelven a mostrarse.
        private void AplicarFiltro()
        {
            if (cbSearch.SelectedItem == null)
            {
                return;
            }

            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearch.SelectedItem).valor);
            string texto = txtSearch.Text.Trim().ToUpper();

            // Una fila con la celda actual seleccionada no se puede ocultar (lanza InvalidOperationException).
            dgvClients.CurrentCell = null;

            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                // Value puede ser null (por ejemplo Name2 / LastName2 vacíos).
                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }


        /*BOTON PARA AGREGAR UN CLIENTE*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // as devuelve null (en vez de lanzar error) si no hay nada seleccionado
                var estadoSeleccionado = cbEstado.SelectedItem as OptionsComboBox;

                // Al agregar no se lee el Id del formulario: lo genera la base de datos.
                Entidad_Cliente oCliente = new Entidad_Cliente()
                {
                    DNI = txtDni.Text.Trim(),
                    Nombre1 = txtName1.Text.Trim(),
                    Nombre2 = txtName2.Text.Trim(),
                    Apellido1 = txtLastName1.Text.Trim(),
                    Apellido2 = txtLastName2.Text.Trim(),
                    Correo = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Estado = estadoSeleccionado != null && Convert.ToInt32(estadoSeleccionado.valor) == 1
                };

                var servicio = new S_Clients();

                // Validar ANTES de registrar, juntando también el error del estado
                bool valido = servicio.Validar(oCliente, out string errores);

                if (estadoSeleccionado == null)
                {
                    if (valido)
                        errores = "Se encontraron los siguientes errores:\n";

                    errores += "Debe seleccionar un estado.\n";
                    valido = false;
                }

                if (!valido)
                {
                    MessageBox.Show(errores, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Solo llega aquí si todo es válido
                int idGenerated = servicio.Register(oCliente, out string Mensaje);

                // Id distinto de 0 = registro exitoso.
                if (idGenerated != 0)
                {
                    // Se recarga el grid desde la BD en lugar de duplicar el llenado de celdas.
                    CargarClientes();

                    MessageBox.Show("Cliente registrado correctamente.", "Mensaje",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                // Cualquier error inesperado (conexión, SP, etc.) se muestra sin tumbar el formulario.
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }
        /*BOTON PARA LIMPIAR TEXTBOXES
         */
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void PnlDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                // as devuelve null (en vez de lanzar error) si no hay nada seleccionado
                var estadoSeleccionado = cbEstado.SelectedItem as OptionsComboBox;

                Entidad_Cliente oCliente = new Entidad_Cliente()
                {
                    IdCliente = ObtenerIdSeleccionado(),
                    DNI = txtDni.Text.Trim(),
                    Nombre1 = txtName1.Text.Trim(),
                    Nombre2 = txtName2.Text.Trim(),
                    Apellido1 = txtLastName1.Text.Trim(),
                    Apellido2 = txtLastName2.Text.Trim(),
                    Correo = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Estado = estadoSeleccionado != null && Convert.ToInt32(estadoSeleccionado.valor) == 1
                };

                var servicio = new S_Clients();

                // Validar ANTES de registrar, juntando también el error del estado
                bool valido = servicio.Validar(oCliente, out string errores);

                if (estadoSeleccionado == null)
                {
                    if (valido)
                        errores = "Se encontraron los siguientes errores:\n";

                    errores += "Debe seleccionar un estado.\n";
                    valido = false;
                }

                if (!valido)
                {
                    MessageBox.Show(errores, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                    return;

                }

                int idCliente = ObtenerIdSeleccionado();

                if (txtIndice.Text == "-1" || idCliente == 0)
                {
                    MessageBox.Show("Debe seleccionar un cliente para actualizar.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                bool isUpdated = servicio.Edit(oCliente, out string Mensaje);

                // Id distinto de 0 = registro exitoso.
                if (isUpdated)
                {
                    // Se recarga el grid desde la BD en lugar de duplicar el llenado de celdas.
                    CargarClientes();

                    MessageBox.Show("Cliente actualizado correctamente.", "Mensaje",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                // Cualquier error inesperado (conexión, SP, etc.) se muestra sin tumbar el formulario.
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvClients.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvClients.Rows[e.RowIndex];

            // El cliente completo se guardó en Tag al cargar el grid
            if (!(row.Tag is Entidad_Cliente cliente)) return;

            txtIndice.Text = e.RowIndex.ToString();

            // ID con prefijo: ID#5
            txtId.Text = "ID#" + cliente.IdCliente;

            // Mostrar textos en los textbox
            txtDni.Text = cliente.DNI;
            txtName1.Text = cliente.Nombre1;
            txtName2.Text = cliente.Nombre2;
            txtLastName1.Text = cliente.Apellido1;
            txtLastName2.Text = cliente.Apellido2;
            txtEmail.Text = cliente.Correo;
            txtTelefono.Text = cliente.Telefono;

            // Mostrar el Estado en el combobox
            int valorEstado = cliente.Estado ? 1 : 0;
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text.Replace("ID#", "").Trim(), out int idCliente) || idCliente == 0)
            {
                MessageBox.Show("Seleccione un Cliente de la lista para eliminar.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Cliente?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Entidad_Cliente oCliente = new Entidad_Cliente()
                {
                    IdCliente = idCliente
                };

                bool result = new S_Clients().Delete(oCliente, out string Mensaje);

                if (result)
                {
                    int indice = Convert.ToInt32(txtIndice.Text);

                    if (indice >= 0 && indice < dgvClients.Rows.Count)
                    {
                        dgvClients.Rows.RemoveAt(indice);
                    }

                    MessageBox.Show("Cliente eliminado correctamente.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}