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
                row.Cells["Rol"].Value = item.oRol.Descripcion; // visible, se muestra al usuario
                row.Cells["EstadoValor"].Value = item.Estado ? 1 : 0;
                row.Cells["Estado"].Value = item.Estado ? "Activo" : "No Activo";


            }
        }
    }
}
