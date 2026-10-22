using ModuloEntidades;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iText.Html2pdf;
using System.IO;

namespace Main
{
    public partial class Frm_DetalleCompra : Form
    {
        public Frm_DetalleCompra()
        {
            InitializeComponent();
        }

        private void btnbuscarr_Click(object sender, EventArgs e)
        {
            Entidad_Compra oEntidad_Compra = new S_Compras().ObtenerCompra(txtbusquedaa.Text.Trim());

            if (oEntidad_Compra.IdCompra != 0)
            {
                txtnumerodocumentoo.Text = oEntidad_Compra.NumeroDocumento;

                txtFechaa.Text = oEntidad_Compra.FechaCreacion;
                txtTipodedocumentoo.Text = oEntidad_Compra.TipoDocumento;
                txtdocproveedoorr.Text = oEntidad_Compra.Proveedor.RUC;

                txtUsuarioo.Text = oEntidad_Compra.Usuario.Nombre1 + " " + oEntidad_Compra.Usuario.Apellido1;
                txtnombreproveedoorr.Text = oEntidad_Compra.Proveedor.RazonSocial;

                dataGridView1.Rows.Clear();
                foreach (Entidad_DetalleCompra d in oEntidad_Compra.DetalleCompra)
                {
                    // se llena por NOMBRE de columna
                    int fila = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[fila];
                    row.Cells["Producto"].Value = d.IdProducto.Nombre;
                    row.Cells["PrecioCompra"].Value = d.PrecioCompra;
                    row.Cells["Cantidad"].Value = d.Cantidad;
                    row.Cells["SubTotal"].Value = d.MontoTotal;
                }

                txtmontototall.Text = oEntidad_Compra.MontoTotal.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No se encontró la compra.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Frm_DetalleCompra_Load(object sender, EventArgs e)
        {

            dataGridView1.HeaderBack = Color.FromArgb(11, 127, 87);   // fondo donde están los nombres
            dataGridView1.MutedColor = Color.White;    // texto de los nombres
            dataGridView1.LineColor = Color.FromArgb(200, 208, 204);    // color de las líneas
            dataGridView1.ShowColumnDividers = true;                    // líneas verticales
            dataGridView1.Invalidate();
        }

        // método del botón Limpiar
        private void btnlimpiarr_Click(object sender, EventArgs e)
        {
            txtbusquedaa.Clear();
            txtnumerodocumentoo.Clear();
            txtFechaa.Clear();
            txtTipodedocumentoo.Clear();
            txtUsuarioo.Clear();
            txtdocproveedoorr.Clear();
            txtnombreproveedoorr.Clear();
            dataGridView1.Rows.Clear();
            txtmontototall.Text = "0";
            txtbusquedaa.Focus();
        }

        private void btndescargarpdff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumerodocumentoo.Text))
            {
                MessageBox.Show("Primero busque una compra.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //editar nombre , direccion y ruc o documento del negocoi
            string nombreNegocio = "VentaSoft";
            string docNegocio = "000-000000-0000X";
            string direcNegocio = "Managua, Nicaragua, del barrio villa nueva 3km.S";
            string telNegocio = "8888-8888"; // telefono del negocio

            string rutaPlantilla = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantilla", "PlantillaCompra.html");

            // elige la plantilla segun el tipo de documento Factura o Boleta
            bool esFactura = string.Equals(txtTipodedocumentoo.Text.Trim(), "Factura", StringComparison.OrdinalIgnoreCase);
            string archivoPlantilla = esFactura ? "PlantillaFactura.html" : "PlantillaBoleta.html";
            rutaPlantilla = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantilla", archivoPlantilla);

            if (!File.Exists(rutaPlantilla))
            {
                MessageBox.Show("No se encontró la plantilla en: " + rutaPlantilla, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string html = File.ReadAllText(rutaPlantilla);

            string archivoLogo = "logo.png"; // podes cambiar de logo solo cambiando el nombre
            int anchoLogo = 80;              // editar el ancho del logo en el pdf

            string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantilla", archivoLogo);
            string logoHtml = string.Empty;

            if (File.Exists(rutaLogo))
            {
                string tipoLogo = archivoLogo.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ? "image/png" : "image/jpeg";
                string base64 = Convert.ToBase64String(File.ReadAllBytes(rutaLogo));
                logoHtml = "<img src=\"data:" + tipoLogo + ";base64," + base64 + "\" style=\"width:" + anchoLogo + "px;\" />";
            }
            html = html.Replace("@logo", logoHtml);

            html = html.Replace("@nombrenegocio", nombreNegocio);
            html = html.Replace("@docnegocio", docNegocio);
            html = html.Replace("@direcnegocio", direcNegocio);
            html = html.Replace("@telnegocio", telNegocio); // teléfono solo la boleta lo usa
            html = html.Replace("@tipodocumento", txtTipodedocumentoo.Text);
            html = html.Replace("@numerodocumento", txtnumerodocumentoo.Text);
            html = html.Replace("@docproveedor", txtdocproveedoorr.Text);
            html = html.Replace("@nombreproveedor", txtnombreproveedoorr.Text);
            html = html.Replace("@fecharegistro", txtFechaa.Text);
            html = html.Replace("@usuarioregistro", txtUsuarioo.Text);
            html = html.Replace("@montototal", txtmontototall.Text);
            html = html.Replace("@subtotal", txtmontototall.Text); // sin IVA, el subtotal es igual al total

            string filas = string.Empty;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value + "</td>";
                filas += "</tr>";
            }

            // las filas cambian según el tipo se vuelven a armar a partir del mismo grid
            filas = string.Empty;
            int numFila = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                numFila++;

                if (esFactura)
                {
                    // factura, 4 columnas con fila alterna (gris claro en las impares) y números a la derecha
                    string fondo = (numFila % 2 == 1) ? "background-color:#F1F5F3;" : "";
                    string est = fondo + "padding:8px;font-size:12px;";
                    filas += "<tr>";
                    filas += "<td style=\"" + est + "text-align:left\">" + row.Cells["Producto"].Value + "</td>";
                    filas += "<td style=\"" + est + "text-align:right\">" + row.Cells["PrecioCompra"].Value + "</td>";
                    filas += "<td style=\"" + est + "text-align:right\">" + row.Cells["Cantidad"].Value + "</td>";
                    filas += "<td style=\"" + est + "text-align:right\">" + row.Cells["SubTotal"].Value + "</td>";
                    filas += "</tr>";
                }
                else
                {
                    //boleta, cada producto en dos líneas (nombre y total, luego cantidad x precio)
                    filas += "<tr>";
                    filas += "<td style=\"text-align:left;font-size:12px;padding-top:6px\">" + row.Cells["Producto"].Value + "</td>";
                    filas += "<td style=\"text-align:right;font-size:12px;padding-top:6px\">" + row.Cells["SubTotal"].Value + "</td>";
                    filas += "</tr>";
                    filas += "<tr>";
                    filas += "<td colspan=\"2\" style=\"text-align:left;font-size:11px;color:#6B7570\">" + row.Cells["Cantidad"].Value + " x " + row.Cells["PrecioCompra"].Value + "</td>";
                    filas += "</tr>";
                }
            }
            html = html.Replace("@filas", filas);

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = string.Format("Compra_{0}.pdf", txtnumerodocumentoo.Text);
            guardar.Filter = "PDF (*.pdf)|*.pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        HtmlConverter.ConvertToPdf(html, stream);
                    }
                    MessageBox.Show("PDF generado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // abre el PDF al terminar para ver el resultado
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(guardar.FileName) { UseShellExecute = true });
                }
                catch (IOException) // archivo abierto en otro programa
                {
                    MessageBox.Show("El PDF está abierto en otro programa. Ciérrelo e intente de nuevo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnbuscarr_KeyDown(object sender, KeyEventArgs e)
        {

        }

        //buscar precionando enter
        private void txtbusquedaa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnbuscarr.PerformClick();
            }
        }

        private void txtFechaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}