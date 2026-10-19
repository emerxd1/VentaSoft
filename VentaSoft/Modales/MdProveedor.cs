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

namespace Main.Modales
{
    public partial class MdProveedor : Form
    {
        //caja de datos para el formulario para guardar un proovedor seleccionado
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Entidad_Proveedor _Entidad_Proveedor { get; set; }

        public MdProveedor()
        {
            InitializeComponent();
        }

        // Busqueda y oculta las filas que no coinciden  y muestra las que si tienen texto
        private void btnbuscar_Click(object sender, EventArgs e)
        {

            if (cbSearch.SelectedItem == null) return;

            string columnFiltro = Convert.ToString(((OptionsComboBox)cbSearch.SelectedItem).valor);
            string texto = txtSearch.Text.Trim().ToUpper();

            foreach (DataGridViewRow row in DvgMduser.Rows)
            {
                if (row.IsNewRow) continue; // filtrador de cuando muestra y cuando oculta

                string valor = row.Cells[columnFiltro].Value?.ToString() ?? "";
                row.Visible = valor.Trim().ToUpper().Contains(texto);
            }
        }

        private void MdProveedor_Load(object sender, EventArgs e)
        {
            //Menu desplegable para -  Buscar por:
            foreach (DataGridViewColumn columna in DvgMduser.Columns)
            {
                if (columna.Visible == true)
                {
                    cbSearch.Items.Add(new OptionsComboBox() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbSearch.DisplayMember = "texto"; // cm se comporta el menu desplegable
            cbSearch.ValueMember = "valor";
            cbSearch.SelectedIndex = 0;

            //Traemos la lista completa de los proveedores registrados y lo muestra en la tabla
            List<Entidad_Proveedor> lista = new S_Proveedor().Lister();

            foreach (Entidad_Proveedor item in lista)
            {
                DvgMduser.Rows.Add(new object[] { item.IdProveedor, item.RUC, item.RazonSocial });
            }
        }

        //propiedades celldoubleclick 
        private void DvgMduser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = DvgMduser.Rows[e.RowIndex];

            // Guarda los datos del proveedor ya seleccionado
            if (fila.IsNewRow || fila.Cells["IdProveedor"].Value == null) return;

            _Entidad_Proveedor = new Entidad_Proveedor()
            {
                IdProveedor = Convert.ToInt32(fila.Cells["IdProveedor"].Value),
                RUC = fila.Cells["RUC"].Value?.ToString() ?? "",
                RazonSocial = fila.Cells["RazonSocial"].Value?.ToString() ?? ""
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        // Borra lo que el usuario escribío
        private void btneliminar_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            foreach (DataGridViewRow row in DvgMduser.Rows)
            {
                row.Visible = true;
            }
        }
    }
    
}
