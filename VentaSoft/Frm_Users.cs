using Main.Utilities;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Store;

namespace Main
{
    public partial class Frm_Users : Form
    {
        public Frm_Users()
        {
            InitializeComponent();
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


            if (dgvUsers.Columns.Contains("Id_Rol"))
            {
                dgvUsers.Columns["Id_Rol"].Visible = false;
            }

            // Cargar usuarios en el DataGridView (asignación por NOMBRE de columna, no por posición)
            List<Entidad_Usuario> listUsuario = new S_Users().Lister();

            foreach (Entidad_Usuario item in listUsuario)
            {
                int fila = dgvUsers.Rows.Add(); // agrega una fila vacía y devuelve su índice
                DataGridViewRow row = dgvUsers.Rows[fila];

                row.Cells["IdUsuario"].Value = item.IdUsuario;
                row.Cells["DNI"].Value = item.DNI;
                row.Cells["Name1"].Value = item.Nombre1;
                row.Cells["Name2"].Value = item.Nombre2;
                row.Cells["LastName1"].Value = item.Apellido1;
                row.Cells["LastName2"].Value = item.Apellido2;
                row.Cells["Email"].Value = item.Correo;
                row.Cells["Password"].Value = item.Clave;
                row.Cells["Id_Rol"].Value = item.oRol.IdRol; // oculta, para comparaciones internas
                row.Cells["Rol"].Value = item.oRol.Descripcion; // visible, se muestra al usuario
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";


            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Entidad_Usuario oUsuario = new Entidad_Usuario() // instancia de la entidad usuario, para enviar a la capa de negocio
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                DNI = txtDni.Text,
                Nombre1 = txtName1.Text,
                Nombre2 = txtName2.Text,
                Apellido1 = txtLastName1.Text,
                Apellido2 = txtLastName2.Text,
                Correo = txtEmail.Text,
                Clave = txtPassword.Text,
                oRol = new Entidad_Rol() { IdRol = Convert.ToInt32(((OptionsComboBox)cbRol.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1 ? true : false
            };


            int idUserGenerated = new S_Users().Register(oUsuario, out string Message);

            // Si el id generado es distinto de 0, significa que se registró correctamente, entonces se agrega al DataGridView
            if (idUserGenerated != 0)
            {

                var rolSeleccionado = (OptionsComboBox)cbRol.SelectedItem;
                var estadoSeleccionado = (OptionsComboBox)cbEstado.SelectedItem;

                // Se agrega la fila vacía y se asignan los valores por NOMBRE de columna
                // (evita el desfase que ocurría con Rows.Add(object[]) por posición)
                int fila = dgvUsers.Rows.Add();
                DataGridViewRow row = dgvUsers.Rows[fila];

                row.Cells["IdUsuario"].Value = idUserGenerated;
                row.Cells["DNI"].Value = txtDni.Text;
                row.Cells["Name1"].Value = txtName1.Text;
                row.Cells["Name2"].Value = txtName2.Text;
                row.Cells["LastName1"].Value = txtLastName1.Text;
                row.Cells["LastName2"].Value = txtLastName2.Text;
                row.Cells["Email"].Value = txtEmail.Text;
                row.Cells["Password"].Value = txtPassword.Text;
                row.Cells["Id_Rol"].Value = rolSeleccionado.valor;
                row.Cells["Rol"].Value = rolSeleccionado.texto;
                row.Cells["EstadoValor"].Value = estadoSeleccionado.valor;
                row.Cells["Estado"].Value = estadoSeleccionado.texto;

                MessageBox.Show("Usuario registrado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Limpiar();

        }


        //METODO PARA LIMPIAR LOS CAMPOS DEL FORMULARIO
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtDni.Text = "";
            txtName1.Clear();
            txtName2.Clear();
            txtLastName1.Clear();
            txtLastName2.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtCheckPassword.Clear();
            cbRol.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            txtId.Clear();
        }


        //btn de busqueda por filtro
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearch.SelectedItem).valor);

            if (dgvUsers.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
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

        /*Btn para borrar el filtro de búsqueda*/
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                row.Visible = true;
            }
        }



        private void btnLimpiarTxt_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnUpdatee_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Esta seguro que desea actualizar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            else
            {
                if (txtIndice.Text == "-1")
                {
                    MessageBox.Show("Debe seleccionar un usuario para actualizar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            Entidad_Usuario oUsuario = new Entidad_Usuario() // instancia de la entidad usuario, para enviar a la capa de negocio
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                DNI = txtDni.Text,
                Nombre1 = txtName1.Text,
                Nombre2 = txtName2.Text,
                Apellido1 = txtLastName1.Text,
                Apellido2 = txtLastName2.Text,
                Correo = txtEmail.Text,
                Clave = txtPassword.Text,
                oRol = new Entidad_Rol() { IdRol = Convert.ToInt32(((OptionsComboBox)cbRol.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1 ? true : false
            };
            MessageBox.Show($"IdUsuario: '{oUsuario.IdUsuario}' - DNI: '{oUsuario.DNI}'");
            bool result = new S_Users().Edit(oUsuario, out string Message);

            // Si la actualizacion fue exitosa, se refleja el cambio en el DataGridView
            if (result)
            {
                var rolSeleccionado = (OptionsComboBox)cbRol.SelectedItem;
                var estadoSeleccionado = (OptionsComboBox)cbEstado.SelectedItem;

                DataGridViewRow row = dgvUsers.Rows[Convert.ToInt32(txtIndice.Text)];

                row.Cells["IdUsuario"].Value = oUsuario.IdUsuario;
                row.Cells["DNI"].Value = txtDni.Text;
                row.Cells["Name1"].Value = txtName1.Text;
                row.Cells["Name2"].Value = txtName2.Text;
                row.Cells["LastName1"].Value = txtLastName1.Text;
                row.Cells["LastName2"].Value = txtLastName2.Text;
                row.Cells["Email"].Value = txtEmail.Text;
                row.Cells["Password"].Value = txtPassword.Text;
                row.Cells["Id_Rol"].Value = rolSeleccionado.valor; // se guarda el valor real, no el .ToString()
                row.Cells["Rol"].Value = rolSeleccionado.texto;
                row.Cells["EstadoValor"].Value = estadoSeleccionado.valor; // se guarda el valor real, no el .ToString()
                row.Cells["Estado"].Value = estadoSeleccionado.texto;

                MessageBox.Show("Usuario actualizado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validación segura: evita la excepción de Convert.ToInt32("") cuando no hay selección
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out int idUsuario) || idUsuario == 0)
            {
                MessageBox.Show("Seleccione un usuario de la lista para eliminar.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Entidad_Usuario oUsuario = new Entidad_Usuario() // instancia de la entidad usuario, para enviar a la capa de negocio
                {
                    IdUsuario = idUsuario
                };

                bool result = new S_Users().Delete(oUsuario, out string Message);

                if (result)
                {
                    dgvUsers.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    MessageBox.Show("Usuario eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            // si dr == DialogResult.No, simplemente no se hace nada (el usuario canceló)
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Valida si y solo si se selecciona el btn seleccionar, muestra los datos con respecto al índice
            if (dgvUsers.Columns[e.ColumnIndex].Name != "btnSeleccion") return;

            int indice = e.RowIndex;
            if (indice < 0) return;
            {
                txtIndice.Text = indice.ToString();

                // Mostrar textos en los textbox
                txtId.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["IdUsuario"].Value);
                txtDni.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["DNI"].Value);
                txtName1.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["Name1"].Value);
                txtName2.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["Name2"].Value);
                txtLastName1.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["LastName1"].Value);
                txtLastName2.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["LastName2"].Value);
                txtEmail.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["Email"].Value);
                txtPassword.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["Password"].Value);
                txtCheckPassword.Text = Convert.ToString(dgvUsers.Rows[indice].Cells["Password"].Value);
            }
            // Mostrar dato de Rol en el combobox
            // Protección contra DBNull: si la celda no tiene valor, se usa 0 en vez de intentar convertir DBNull
            object valorIdRol = dgvUsers.Rows[indice].Cells["Id_Rol"].Value;
            int idRolFila = (valorIdRol == null || valorIdRol == DBNull.Value) ? 0 : Convert.ToInt32(valorIdRol);

            foreach (OptionsComboBox oc in cbRol.Items)
            {
                if (Convert.ToInt32(oc.valor) == idRolFila)
                {
                    cbRol.SelectedIndex = cbRol.Items.IndexOf(oc);
                    break;
                }
            }

            // Mostrar dato de Estado en el combobox
            // Protección contra DBNull: si la celda no tiene valor, se usa 0 en vez de intentar convertir DBNull
            object valorEstado = dgvUsers.Rows[indice].Cells["EstadoValor"].Value;
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

        private void dgvUsers_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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


        //CAMBIA COLOR DEPENDE DEL ESTADO DEL USUARIO
        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvUsers.Columns[e.ColumnIndex].Name == "Estado")
            {
                e.CellStyle.BackColor = e.Value.ToString() == "Activo" ? Color.LightGreen : Color.Salmon;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLastName1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
