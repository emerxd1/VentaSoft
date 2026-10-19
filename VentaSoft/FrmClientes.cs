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
            this.Shown += FrmClientes_Shown;   // diagnóstico temporal de bordes (borrar al terminar)
        }

        // DIAGNÓSTICO TEMPORAL: se ejecuta cuando el formulario ya se mostró y el grid ya tiene filas.
        // Cuando resuelvas lo de las líneas, borra este método y la línea "this.Shown += ..." del constructor.
        private void FrmClientes_Shown(object sender, EventArgs e)
        {
            var g = dgvClients;   // tu ModernGrid
            var a = g.AdvancedCellBorderStyle;
            var h = g.AdvancedColumnHeadersBorderStyle;

            string divCol = g.Columns.Count > 0 ? g.Columns[0].DividerWidth.ToString() : "sin columnas";
            string divFila = g.Rows.Count > 0 ? g.Rows[0].DividerHeight.ToString() : "sin filas";

            MessageBox.Show(
                "Celdas  L/T/R/B: " + a.Left + " / " + a.Top + " / " + a.Right + " / " + a.Bottom + "\n" +
                "Cabecera L/T/R/B: " + h.Left + " / " + h.Top + " / " + h.Right + " / " + h.Bottom + "\n" +
                "ColumnHeadersBorderStyle: " + g.ColumnHeadersBorderStyle + "\n" +
                "RowHeadersBorderStyle: " + g.RowHeadersBorderStyle + "\n" +
                "BorderStyle: " + g.BorderStyle + "\n" +
                "DividerWidth col0: " + divCol + "\n" +
                "DividerHeight fila0: " + divFila);
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
                }
            }
            catch (Exception ex)
            {
                // Cualquier error inesperado (conexión, SP, etc.) se muestra sin tumbar el formulario.
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
            }
            catch (Exception ex)
            {
                // Cualquier error inesperado (conexión, SP, etc.) se muestra sin tumbar el formulario.
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Valida si y solo si se selecciona el btn seleccionar, muestra los datos con respecto al índice
            if (dgvClients.Columns[e.ColumnIndex].Name != "btnSeleccion") return;

            int indice = e.RowIndex;
            if (indice < 0) return;
            {
                txtIndice.Text = indice.ToString();

                // Mostrar textos en los textbox
                txtId.Text = Convert.ToString(dgvClients.Rows[indice].Cells["IdCliente"].Value);
                txtDni.Text = Convert.ToString(dgvClients.Rows[indice].Cells["DNI"].Value);
                txtName1.Text = Convert.ToString(dgvClients.Rows[indice].Cells["Name1"].Value);
                txtName2.Text = Convert.ToString(dgvClients.Rows[indice].Cells["Name2"].Value);
                txtLastName1.Text = Convert.ToString(dgvClients.Rows[indice].Cells["LastName1"].Value);
                txtLastName2.Text = Convert.ToString(dgvClients.Rows[indice].Cells["LastName2"].Value);
                txtEmail.Text = Convert.ToString(dgvClients.Rows[indice].Cells["Email"].Value);
            }


            // Mostrar dato de Estado en el combobox
            // Protección contra DBNull: si la celda no tiene valor, se usa 0 en vez de intentar convertir DBNull
            object valorEstado = dgvClients.Rows[indice].Cells["EstadoValor"].Value;
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

        private void dgvClients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // para ignorar el header

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
    }
}