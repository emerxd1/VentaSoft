using Data;
using Main.Utilities;
using ModuloEntidades;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main.Modales
{
    public partial class MdClientes : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Entidad_Cliente _Entidad_Cliente { get; set; }

        public MdClientes()
        {
            InitializeComponent();

            new EscaladoProporcional(this); // mandamos a llamar escalado proporcional para el auto escalado en auto para cualquier pantalla

            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void MdClientes_Load(object sender, EventArgs e)
        {
            // cbox,Buscar por las columnas visibles de la tablas
            foreach (DataGridViewColumn columna in dgvClients.Columns)
            {
                if (columna.Visible == true)
                {
                    cbSearchClientes.Items.Add(new OptionsComboBox() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbSearchClientes.DisplayMember = "texto";
            cbSearchClientes.ValueMember = "valor";
            if (cbSearchClientes.Items.Count > 0) cbSearchClientes.SelectedIndex = 0;

            // Lista de los clientes solo los activos
            List<Entidad_Cliente> lista = new S_Clients().Lister();

            foreach (Entidad_Cliente item in lista)
            {
                if (!item.Estado) continue;

                // aqui mostramos el nombre completo sin espacios de ms cuando un nombre o apellido viene vacio
                string nombreCompleto = string.Join(" ",
                    new[] { item.Nombre1, item.Nombre2, item.Apellido1, item.Apellido2 }
                    .Where(s => !string.IsNullOrWhiteSpace(s)));

                // se llena por nombre de columna, no por posicion para evitar errores
                int fila = dgvClients.Rows.Add();
                DataGridViewRow row = dgvClients.Rows[fila];
                row.Cells["IdCliente"].Value = item.IdCliente;
                row.Cells["DNI"].Value = item.DNI;
                row.Cells["Cliente"].Value = nombreCompleto;

                // el cliente completo se guarda en la fila para devolverlo con doble clic
                row.Tag = item;
            }
        }

        // doble clic en una fila para mostrar
        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvClients.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            if (row.Tag is Entidad_Cliente cliente)
            {
                _Entidad_Cliente = cliente;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                row.Visible = true;
            }
        }

        // comentarios de textos dependiendo lo que seleccione el usuario
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionsComboBox opcionSeleccionada = (OptionsComboBox)cbSearchClientes.SelectedItem;
            string textoOpcion = opcionSeleccionada.texto;//convertimos el obj seleccionado al tipo de nuestra clse otioncomboBox
            //añadimos los textos
            if (textoOpcion == "DNI")
            {
                txtSearch.PlaceholderText = "EJ: 001-092008-1234X";
            }
            else if (textoOpcion == "Cliente")
            {
                txtSearch.PlaceholderText = "EJ: Juan Caldera";
            }
            else
            {
                txtSearch.PlaceholderText = "Buscar...";
            }
        }

        // la misma logica del botn buscar, pero en un método que se puede reutilizar
        private void AplicarFiltro()
        {
            if (cbSearchClientes.SelectedItem == null) return;

            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearchClientes.SelectedItem).valor);
            string texto = txtSearch.Text.Trim().ToUpper();

            dgvClients.CurrentCell = null; //evita el error al ocultar la fila actual

            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                if (row.IsNewRow) continue;

                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }

        //el evento que filtra mientras se escribe

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
    }
}