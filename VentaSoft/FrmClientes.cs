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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            // Cargar combo de Estado
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";
            cbEstado.SelectedIndex = 0;

            // Cargar combo de búsqueda (según columnas visibles del grid)
            foreach (DataGridViewColumn Columna in dgvClients.Columns)
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

            CargarClientes();
        }

        // Extraído a método propio para poder recargar el grid después de agregar
        // un cliente, sin duplicar la lógica de carga.
        private void CargarClientes()
        {
            dgvClients.Rows.Clear();

            List<Entidad_Cliente> listClient = new S_Clients().Lister();

            foreach (Entidad_Cliente item in listClient)
            {
                int fila = dgvClients.Rows.Add();
                DataGridViewRow row = dgvClients.Rows[fila];

                row.Cells["IdCliente"].Value = item.IdCliente;
                row.Cells["DNI"].Value = item.DNI;
                row.Cells["Name1"].Value = item.Nombre1;
                row.Cells["Name2"].Value = item.Nombre2;
                row.Cells["LastName1"].Value = item.Apellido1;
                row.Cells["LastName2"].Value = item.Apellido2;
                row.Cells["Email"].Value = item.Correo;
                row.Cells["NumTelefono"].Value = item.Telefono;
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";
            }
        }

        /*BOTON PARA AGREGAR UN CLIENTE*/
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //  al AGREGAR un cliente nuevo no se debe leer el Id desde txtId.
                //    Antes se hacía Convert.ToInt32(txtId.Text), lo que revienta el
                //    formulario si txtId está vacío (caso normal al crear un cliente),
                //    y además no tiene sentido: el Id lo genera la base de datos.
                Entidad_Cliente oCliente = new Entidad_Cliente()
                {
                    DNI = txtDni.Text.Trim(),
                    Nombre1 = txtName1.Text.Trim(),
                    Nombre2 = txtName2.Text.Trim(),
                    Apellido1 = txtLastName1.Text.Trim(),
                    Apellido2 = txtLastName2.Text.Trim(),
                    Correo = txtEmail.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1
                };

                int idGenerated = new S_Clients().Register(oCliente, out string Mensaje);

                // Si el id generado es distinto de 0, significa que se registró correctamente,
                // entonces se agrega al DataGridView.
                if (idGenerated != 0)
                {
                    var estadoSeleccionado = (OptionsComboBox)cbEstado.SelectedItem;

                    int fila = dgvClients.Rows.Add();
                    DataGridViewRow row = dgvClients.Rows[fila];

                    row.Cells["IdCliente"].Value = idGenerated;
                    row.Cells["DNI"].Value = oCliente.DNI;
                    row.Cells["Name1"].Value = oCliente.Nombre1;
                    row.Cells["Name2"].Value = oCliente.Nombre2;
                    row.Cells["LastName1"].Value = oCliente.Apellido1;
                    row.Cells["LastName2"].Value = oCliente.Apellido2;
                    row.Cells["Email"].Value = oCliente.Correo;
                    row.Cells["NumTelefono"].Value = oCliente.Telefono;
                    row.Cells["EstadoValor"].Value = estadoSeleccionado.valor;
                    row.Cells["Estado"].Value = estadoSeleccionado.texto;

                    MessageBox.Show("Cliente registrado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                // 3) FIX: cualquier error inesperado (conexión, SP, etc.) ya no
                //    tumba el formulario, se muestra al usuario.
                MessageBox.Show("Ocurrió un error al registrar el cliente: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            txtTelefono.Clear();
            cbEstado.SelectedIndex = 0;
            txtId.Clear();
            txtDni.Focus();
        }
    }
}