using iText.Html2pdf;
using Main.Utilities;
using ModuloEntidades;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Frm_DetalleCompra : Form
    {
        // Datos fijos del negocio (editar aquí)
        private const string NombreReal = "Pulpería Oasis de Bendición";
        private const string NombreNegocio = "VentaSoft";
        private const string DocNegocio = "J0310000087654";
        private const string DirecNegocio = "4MJ7+G5, Cd. Sandino";
        private const string TelNegocio = "7522-8499";


        // Logo: se puede cambiar solo cambiando el nombre / ancho
        private const string ArchivoLogo = "logo.png";
        private const int AnchoLogo = 80;

        // Cache del logo en base64 (se lee del disco solo una vez)
        private static string _logoHtmlCache;

        public Frm_DetalleCompra()
        {
            InitializeComponent();
            new EscaladoProporcional(this);
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

                // índices de columna resueltos una sola vez
                int colProducto = dataGridView1.Columns["Producto"].Index;
                int colPrecio = dataGridView1.Columns["PrecioCompra"].Index;
                int colCantidad = dataGridView1.Columns["Cantidad"].Index;
                int colSubTotal = dataGridView1.Columns["SubTotal"].Index;

                dataGridView1.SuspendLayout();
                try
                {
                    dataGridView1.Rows.Clear();
                    foreach (Entidad_DetalleCompra d in oEntidad_Compra.DetalleCompra)
                    {
                        DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Add()];
                        row.Cells[colProducto].Value = d.IdProducto.Nombre;
                        row.Cells[colPrecio].Value = d.PrecioCompra;
                        row.Cells[colCantidad].Value = d.Cantidad;
                        row.Cells[colSubTotal].Value = d.MontoTotal;
                    }
                }
                finally
                {
                    dataGridView1.ResumeLayout();
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
            // Sin Invalidate(): el formulario ya se pinta solo al cargar.
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

        private async void btndescargarpdff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumerodocumentoo.Text))
            {
                MessageBox.Show("Primero busque una compra.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // elige la plantilla según el tipo de documento: Factura o Boleta
            bool esFactura = string.Equals(txtTipodedocumentoo.Text.Trim(), "Factura", StringComparison.OrdinalIgnoreCase);
            string archivoPlantilla = esFactura ? "PlantillaFactura.html" : "PlantillaBoleta.html";
            string rutaPlantilla = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantilla", archivoPlantilla);

            if (!File.Exists(rutaPlantilla))
            {
                MessageBox.Show("No se encontró la plantilla en: " + rutaPlantilla, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string html = File.ReadAllText(rutaPlantilla);

            // Reemplazos simples (sin el logo todavía, para no copiar el base64 en cada Replace)
            html = html.Replace("@nombrenegocio", NombreNegocio)
                
                
                       .Replace("@nombrereal", NombreReal) // ral name
                       .Replace("@docnegocio", DocNegocio)
                       .Replace("@direcnegocio", DirecNegocio)
                       .Replace("@telnegocio", TelNegocio) // teléfono solo la boleta lo usa
                       .Replace("@nombrereal", NombreReal) // ral name
                       .Replace("@telnegocio", TelNegocio) // teléfono solo la boleta lo usa
                       .Replace("@tipodocumento", txtTipodedocumentoo.Text)
                       .Replace("@numerodocumento", txtnumerodocumentoo.Text)
                       .Replace("@docproveedor", txtdocproveedoorr.Text)
                       .Replace("@nombreproveedor", txtnombreproveedoorr.Text)
                       .Replace("@fecharegistro", txtFechaa.Text)
                       .Replace("@usuarioregistro", txtUsuarioo.Text)
                       .Replace("@montototal", txtmontototall.Text)
                       .Replace("@subtotal", txtmontototall.Text); // sin IVA, el subtotal es igual al total

            // Filas: un solo recorrido, StringBuilder e índices de columna resueltos una vez
            int colProducto = dataGridView1.Columns["Producto"].Index;
            int colPrecio = dataGridView1.Columns["PrecioCompra"].Index;
            int colCantidad = dataGridView1.Columns["Cantidad"].Index;
            int colSubTotal = dataGridView1.Columns["SubTotal"].Index;

            var filas = new StringBuilder();
            int numFila = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                numFila++;

                object producto = row.Cells[colProducto].Value;
                object precio = row.Cells[colPrecio].Value;
                object cantidad = row.Cells[colCantidad].Value;
                object subtotal = row.Cells[colSubTotal].Value;

                if (esFactura)
                {
                    // factura: 4 columnas, fila alterna (gris claro en las impares), números a la derecha
                    string est = (numFila % 2 == 1 ? "background-color:#F1F5F3;" : "") + "padding:8px;font-size:12px;";
                    filas.Append("<tr><td style=\"").Append(est).Append("text-align:left\">").Append(producto)
                         .Append("</td><td style=\"").Append(est).Append("text-align:right\">").Append(precio)
                         .Append("</td><td style=\"").Append(est).Append("text-align:right\">").Append(cantidad)
                         .Append("</td><td style=\"").Append(est).Append("text-align:right\">").Append(subtotal)
                         .Append("</td></tr>");
                }
                else
                {
                    // boleta: cada producto en dos líneas (nombre y total, luego cantidad x precio)
                    filas.Append("<tr><td style=\"text-align:left;font-size:12px;padding-top:6px\">").Append(producto)
                         .Append("</td><td style=\"text-align:right;font-size:12px;padding-top:6px\">").Append(subtotal)
                         .Append("</td></tr><tr><td colspan=\"2\" style=\"text-align:left;font-size:11px;color:#6B7570\">")
                         .Append(cantidad).Append(" x ").Append(precio)
                         .Append("</td></tr>");
                }
            }
            html = html.Replace("@filas", filas.ToString());

            // El logo (base64 pesado) se inserta al final: ningún otro Replace lo copia
            html = html.Replace("@logo", ObtenerLogoHtml());

            string destino;
            using (var guardar = new SaveFileDialog())
            {
                guardar.FileName = string.Format("Compra_{0}.pdf", txtnumerodocumentoo.Text);
                guardar.Filter = "PDF (*.pdf)|*.pdf";

                if (guardar.ShowDialog() != DialogResult.OK) return;
                destino = guardar.FileName;
            }

            btndescargarpdff.Enabled = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                // la conversión pesada va en un hilo de fondo para no congelar la ventana
                string htmlFinal = html;
                await Task.Run(() =>
                {
                    using (var stream = new FileStream(destino, FileMode.Create))
                    {
                        HtmlConverter.ConvertToPdf(htmlFinal, stream);
                    }
                });

                MessageBox.Show("PDF generado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // abre el PDF al terminar para ver el resultado
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(destino) { UseShellExecute = true });
            }
            catch (IOException) // archivo abierto en otro programa
            {
                MessageBox.Show("El PDF está abierto en otro programa. Ciérrelo e intente de nuevo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                btndescargarpdff.Enabled = true;
            }
        }

        // Devuelve el <img> del logo en base64; se lee del disco solo la primera vez.
        private static string ObtenerLogoHtml()
        {
            if (_logoHtmlCache != null) return _logoHtmlCache;

            string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantilla", ArchivoLogo);
            if (!File.Exists(rutaLogo)) return string.Empty; // no se cachea: si luego se agrega el logo, se toma

            string tipoLogo = ArchivoLogo.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ? "image/png" : "image/jpeg";
            string base64 = Convert.ToBase64String(File.ReadAllBytes(rutaLogo));
            _logoHtmlCache = "<img src=\"data:" + tipoLogo + ";base64," + base64 + "\" style=\"width:" + AnchoLogo + "px;\" />";
            return _logoHtmlCache;
        }

        // buscar presionando enter
        private void txtbusquedaa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnbuscarr.PerformClick();
            }
        }

        private void btnbuscarr_KeyDown(object sender, KeyEventArgs e) { }
        private void txtFechaa_TextChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) { }
        private void uiGroupBox1_Click(object sender, EventArgs e) { }
        private void groupBox2_Click(object sender, EventArgs e) { }
        private void txtnombreproveedoorr_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e) { }
    }
}