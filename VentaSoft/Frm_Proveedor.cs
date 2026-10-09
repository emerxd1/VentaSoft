using Data;
using ModuloEntidades;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Main.Utilities;

namespace Main
{
    public partial class Frm_Proveedor : Form
    {

        public Frm_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1, texto = "Activo" });
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0, texto = "No Activo" });
            cbEstado.DisplayMember = "texto";
            cbEstado.ValueMember = "valor";
            cbEstado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvUsers.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccion")
                {
                    cbSearch.Items.Add(new OptionsComboBox() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbSearch.DisplayMember = "texto";
            cbSearch.ValueMember = "valor";
            cbSearch.SelectedIndex = 0;

            //MOSTRAR TODOS LOS PROVEEDORES
            List<Entidad_Proveedor> lista = new S_Proveedor().Lister();

            foreach (Entidad_Proveedor item in lista)
            {
                dgvUsers.Rows.Add(new object[] {"",item.IdProveedor,item.RUC,item.RazonSocial,item.Correo,item.Telefono,
                   item.Estado == true ? 1 : 0 ,
                   item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Entidad_Proveedor obj = new Entidad_Proveedor()
            {
                IdProveedor = Convert.ToInt32(txtId.Text),
                RUC = txtRUC.Text,
                RazonSocial = txtName1.Text,
                Correo = txtEmail.Text,
                Telefono = textBox1.Text,
                Estado = Convert.ToInt32(((OptionsComboBox)cbEstado.SelectedItem).valor) == 1 ? true : false
            };

            if (obj.IdProveedor == 0)
            {
                int idgenerado = new S_Proveedor().Register(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvUsers.Rows.Add(new object[] {"",idgenerado,txtRUC.Text,txtName1.Text,txtEmail.Text,textBox1.Text,
                        ((OptionsComboBox)cbEstado.SelectedItem).valor.ToString(),
                        ((OptionsComboBox)cbEstado.SelectedItem).texto.ToString()
                    });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new S_Proveedor().Edit(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvUsers.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdProveedor"].Value = Convert.ToInt32(txtId.Text);
                    row.Cells["RUC"].Value = txtRUC.Text;
                    row.Cells["Name1"].Value = txtName1.Text;
                    row.Cells["Email"].Value = txtEmail.Text;
                    row.Cells["NumTelefono"].Value = textBox1.Text;
                    row.Cells["Estadovalor"].Value = ((OptionsComboBox)cbEstado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OptionsComboBox)cbEstado.SelectedItem).texto.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtRUC.Text = "";
            txtName1.Text = "";
            txtEmail.Text = "";
            textBox1.Text = "";
            cbEstado.SelectedIndex = 0;
            txtRUC.Select();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvUsers.Columns[e.ColumnIndex].Name == "btnSeleccion")
            {
                int indice = e.RowIndex;

                txtIndice.Text = indice.ToString();
                txtId.Text = dgvUsers.Rows[indice].Cells["IdProveedor"].Value?.ToString() ?? "0";
                txtRUC.Text = dgvUsers.Rows[indice].Cells["RUC"].Value?.ToString() ?? "";
                txtName1.Text = dgvUsers.Rows[indice].Cells["Name1"].Value?.ToString() ?? "";
                txtEmail.Text = dgvUsers.Rows[indice].Cells["Email"].Value?.ToString() ?? "";
                textBox1.Text = dgvUsers.Rows[indice].Cells["NumTelefono"].Value?.ToString() ?? "";

                foreach (OptionsComboBox oc in cbEstado.Items)
                {
                    if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvUsers.Rows[indice].Cells["Estadovalor"].Value))
                    {
                        int indice_combo = cbEstado.Items.IndexOf(oc);
                        cbEstado.SelectedIndex = indice_combo;
                        break;
                    }
                }
            }
        }

        private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Entidad_Proveedor obj = new Entidad_Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new S_Proveedor().Delete(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvUsers.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OptionsComboBox)cbSearch.SelectedItem).valor.ToString();

            if (dgvUsers.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    row.Visible = row.Cells[columnaFiltro].Value?.ToString()
                        .Trim().ToUpper().Contains(txtSearch.Text.Trim().ToUpper()) ?? false;
                }
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnLimpiarTxt_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}