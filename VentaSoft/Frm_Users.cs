using Main.Utilities;
using ModuloEntidades;
using Store;
using System.Data;
using System.Text;

namespace Main
{
    public partial class Frm_Users : Form
    {
        private readonly S_Users _servicio = new S_Users();
        private bool passwordVisible = false;


        public Frm_Users()
        {
            InitializeComponent();
            ApplyPasswordState1(); // estado inicial coherente
            ApplyPasswordState2(); // estado inicial coherente

        }
        private void ApplyPasswordState1()
        {
            txtPassword.PasswordChar = passwordVisible ? '\0' : '●';
            txtPassword.ButtonSymbol = passwordVisible

                ? 61550  // ojo abierto (contraseña visible)
                : 61552; // ojo cerrado (contraseña oculta)
        }
        private void ApplyPasswordState2()
        {
            // '\0' = sin máscara (se ve el texto); '●' = oculto
            txtCheckPassword.PasswordChar = passwordVisible ? '\0' : '●';
            txtCheckPassword.ButtonSymbol = passwordVisible
                ? 61550  // ojo abierto (contraseña visible)
                : 61552; // ojo cerrado (contraseña oculta)
        }

        // Devuelve el Id numérico mostrado en txtId ("ID#5" -> 5). Devuelve 0 si no hay ninguno.
        private int ObtenerIdSeleccionado()
        {
            return int.TryParse(txtId.Text.Replace("ID#", "").Trim(), out int id) ? id : 0;
        }

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";
            cbEstado.SelectedIndex = 0;

            // Cargar combo de Rol
            List<Entidad_Rol> listRol = new S_Rol().Lister();
            foreach (Entidad_Rol item in listRol)
            {
                cbRol.Items.Add(new OptionsComboBox() { valor = item.IdRol, texto = item.Descripcion });
            }
            cbRol.ValueMember = "valor";
            cbRol.DisplayMember = "texto";
            if (cbRol.Items.Count > 0)
            {
                cbRol.SelectedIndex = 0;
            }

            // Cargar combo de búsqueda (según columnas visibles del grid)
            foreach (DataGridViewColumn Columna in dgvUsers.Columns)
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

            if (dgvUsers.Columns.Contains("Id_Rol"))
            {
                dgvUsers.Columns["Id_Rol"].Visible = false;
            }

            CargarUsuarios();
        }

        // Carga (o recarga) el grid desde la base de datos.
        private void CargarUsuarios()
        {
            dgvUsers.CurrentCell = null;
            dgvUsers.Rows.Clear();

            List<Entidad_Usuario> listUsuario = _servicio.Lister()
                .OrderBy(u => u.Nombre1)
                .ThenBy(u => u.Apellido1)
                .ToList();

            foreach (Entidad_Usuario item in listUsuario)
            {
                int fila = dgvUsers.Rows.Add();
                DataGridViewRow row = dgvUsers.Rows[fila];

                // Se guarda el usuario completo en la fila: al seleccionarla se leen de aquí
                // los datos que el grid no muestra (nombres, apellidos, clave).
                row.Tag = item;

                row.Cells["IdUsuario"].Value = item.IdUsuario;
                row.Cells["DNI"].Value = item.DNI;

                // Nombre y primer apellido en una sola columna
                row.Cells["Cliente"].Value = string.Join(" ",
                    new[] { item.Nombre1, item.Apellido1 }
                        .Where(texto => !string.IsNullOrWhiteSpace(texto)));

                row.Cells["Name1"].Value = item.Nombre1;
                row.Cells["Name2"].Value = item.Nombre2;
                row.Cells["LastName1"].Value = item.Apellido1;
                row.Cells["LastName2"].Value = item.Apellido2;
                row.Cells["Email"].Value = item.Correo;
                row.Cells["Password"].Value = item.Clave;
                row.Cells["Id_Rol"].Value = item.oRol?.IdRol ?? 0; // oculta, para comparaciones internas
                row.Cells["Rol"].Value = item.oRol?.Descripcion ?? ""; // visible
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
            txtDni.Clear();
            txtName1.Clear();
            txtName2.Clear();
            txtLastName1.Clear();
            txtLastName2.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtPassword.Clear();
            txtCheckPassword.Clear();

            cbRol.SelectedIndex = -1;
            cbRol.Text = "Seleccione un rol";
            cbRol.ForeColor = Color.Gray;

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
            dgvUsers.CurrentCell = null;

            foreach (DataGridViewRow row in dgvUsers.Rows)
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

        // Lee el formulario, lo valida (servicio + rol, estado y confirmación de clave)
        // y devuelve la entidad lista para enviar. Si hay errores los muestra y devuelve false.
        // idUsuario = 0 al registrar (lo genera la base de datos).
        private bool TryLeerFormulario(int idUsuario, out Entidad_Usuario oUsuario)
        {
            // as devuelve null (en vez de lanzar error) si no hay nada seleccionado
            var estadoSeleccionado = cbEstado.SelectedItem as OptionsComboBox;
            var rolSeleccionado = cbRol.SelectedItem as OptionsComboBox;

            // Nota: Telefono (txtTelefono) no se envía porque Entidad_Usuario / D_Users / los SP
            // de usuario no lo contemplan todavía.
            oUsuario = new Entidad_Usuario()
            {
                IdUsuario = idUsuario,
                DNI = txtDni.Text.Trim(),
                Nombre1 = txtName1.Text.Trim(),
                Nombre2 = txtName2.Text.Trim(),
                Apellido1 = txtLastName1.Text.Trim(),
                Apellido2 = txtLastName2.Text.Trim(),
                Correo = txtEmail.Text.Trim(),
                Clave = txtPassword.Text,
                oRol = new Entidad_Rol()
                {
                    IdRol = rolSeleccionado != null ? Convert.ToInt32(rolSeleccionado.valor) : 0
                },
                Estado = estadoSeleccionado != null && Convert.ToInt32(estadoSeleccionado.valor) == 1
            };

            bool valido = _servicio.Validar(oUsuario, out string errores);

            var extras = new StringBuilder();
            if (rolSeleccionado == null)
                extras.Append("Debe seleccionar un rol.\n");
            if (estadoSeleccionado == null)
                extras.Append("Debe seleccionar un estado.\n");
            if (txtPassword.Text != txtCheckPassword.Text)
                extras.Append("La Clave y su confirmación no coinciden.\n");

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

        /* BOTON PARA REGISTRAR UN USUARIO */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!TryLeerFormulario(0, out Entidad_Usuario oUsuario))
                    return;

                int idUserGenerated = _servicio.Register(oUsuario, out string Message);

                // Id distinto de 0 = registro exitoso.
                if (idUserGenerated != 0)
                {
                    // Se recarga el grid desde la BD en lugar de duplicar el llenado de celdas.
                    CargarUsuarios();

                    MessageBox.Show("Usuario registrado correctamente.", "Mensaje",
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
                // Cualquier error inesperado (conexión, SP, etc.) se muestra sin tumbar el formulario.
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        /* BOTON PARA ACTUALIZAR UN USUARIO */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = ObtenerIdSeleccionado();

                if (txtIndice.Text == "-1" || idUsuario == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario para actualizar.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!TryLeerFormulario(idUsuario, out Entidad_Usuario oUsuario))
                    return;

                bool isUpdated = _servicio.Edit(oUsuario, out string Message);

                if (isUpdated)
                {
                    CargarUsuarios();

                    MessageBox.Show("Usuario actualizado correctamente.", "Mensaje",
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
                MessageBox.Show("Ocurrió un error al actualizar el usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        /* BOTON PARA ELIMINAR UN USUARIO */
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = ObtenerIdSeleccionado();

                if (idUsuario == 0)
                {
                    MessageBox.Show("Seleccione un Usuario de la lista para eliminar.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Usuario?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr != DialogResult.Yes)
                    return;

                bool result = _servicio.Delete(new Entidad_Usuario() { IdUsuario = idUsuario }, out string Message);

                if (result)
                {
                    CargarUsuarios();

                    MessageBox.Show("Usuario eliminado correctamente.", "Mensaje",
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
                MessageBox.Show("Ocurrió un error al eliminar el usuario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvUsers.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            // El usuario completo se guardó en Tag al cargar el grid
            if (!(row.Tag is Entidad_Usuario usuario)) return;

            txtIndice.Text = e.RowIndex.ToString();
            txtId.Text = "ID#" + usuario.IdUsuario;

            txtDni.Text = usuario.DNI;
            txtName1.Text = usuario.Nombre1;
            txtName2.Text = usuario.Nombre2;
            txtLastName1.Text = usuario.Apellido1;
            txtLastName2.Text = usuario.Apellido2;
            txtEmail.Text = usuario.Correo;
            txtPassword.Text = usuario.Clave;
            txtCheckPassword.Text = usuario.Clave;

            // Rol
            cbRol.SelectedIndex = -1;
            int idRol = usuario.oRol?.IdRol ?? 0;
            foreach (OptionsComboBox oc in cbRol.Items)
            {
                if (Convert.ToInt32(oc.valor) == idRol)
                {
                    cbRol.SelectedItem = oc;
                    break;
                }
            }

            // Estado
            cbEstado.SelectedIndex = -1;
            int valorEstado = usuario.Estado ? 1 : 0;
            foreach (OptionsComboBox oc in cbEstado.Items)
            {
                if (Convert.ToInt32(oc.valor) == valorEstado)
                {
                    cbEstado.SelectedItem = oc;
                    break;
                }
            }

            // Limpiar() deja los combos en gris; aquí se restaura el color normal
            cbRol.ForeColor = Color.Black;
            cbEstado.ForeColor = Color.Black;
        }

        private void txtCheckPassword_ButtonClick(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            ApplyPasswordState2();

        }

        private void txtPassword_ButtonClick(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            ApplyPasswordState1();
        }
    }
}