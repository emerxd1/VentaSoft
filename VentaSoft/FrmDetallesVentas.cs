using iText.Html2pdf;//cargamos para poder ejecutar el pdf
using ModuloEntidades;
using Store;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Main
{
    public partial class FrmDetallesVentas : Form
    {
        public FrmDetallesVentas()
        {
            InitializeComponent();

            // enlaza los eventos por el codigo y evita que queden duplicados si luego los conectas con diseñador
            btnbuscarr.Click -= btnbuscarr_Click;
            btnbuscarr.Click += btnbuscarr_Click;

            btnlimpiarr.Click -= btnlimpiarr_Click;
            btnlimpiarr.Click += btnlimpiarr_Click;

            txtbusquedaa.KeyDown -= txtbusquedaa_KeyDown;
            txtbusquedaa.KeyDown += txtbusquedaa_KeyDown;

            btndescargarpdff.Click -= btndescargarpdff_Click; // NUEVO
            btndescargarpdff.Click += btndescargarpdff_Click; // NUEVO

            // en el detalle todo es solo para consultar
            txtFechaa.ReadOnly = true;
            txtTipodedocumentoo.ReadOnly = true;
            txtUsuarioo.ReadOnly = true;
            TxtDocCliente.ReadOnly = true;
            TxtNombre1Cli.ReadOnly = true;
            TxtNombre2Cli.ReadOnly = true;
            TxtApellido1Cli.ReadOnly = true;
            TxtApellido2Cli.ReadOnly = true;
            TxtMontoTotal.ReadOnly = true;
            TxtMontoPago.ReadOnly = true;
            TxtMontoCambio.ReadOnly = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FrmDetallesVentas_Load(object sender, EventArgs e)
        {
            txtbusquedaa.Focus();
        }

        // busaca la venta por el numero y llena el formulario
        private void btnbuscarr_Click(object sender, EventArgs e)
        {
            Entidad_Venta oVenta = new S_Ventas().ObtenerVenta(txtbusquedaa.Text.Trim());

            if (oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroFactura;

                txtFechaa.Text = oVenta.FechaCreacion;
                txtTipodedocumentoo.Text = oVenta.TipoDocumento;
                txtUsuarioo.Text = oVenta.Usuario.Nombre1 + " " + oVenta.Usuario.Apellido1;

                TxtDocCliente.Text = oVenta.Cliente.DNI;
                TxtNombre1Cli.Text = oVenta.Cliente.Nombre1;
                TxtNombre2Cli.Text = oVenta.Cliente.Nombre2;
                TxtApellido1Cli.Text = oVenta.Cliente.Apellido1;
                TxtApellido2Cli.Text = oVenta.Cliente.Apellido2;

                DgvData.Rows.Clear();
                foreach (Entidad_DetalleVenta d in oVenta.DetalleVenta)
                {
                    // se llena por nombre de columnas
                    int fila = DgvData.Rows.Add();
                    DataGridViewRow row = DgvData.Rows[fila];
                    row.Cells["Producto"].Value = d.Producto.Nombre;
                    row.Cells["Precio"].Value = d.PrecioVenta.ToString("0.00");
                    row.Cells["Cantidad"].Value = d.Cantidad;
                    row.Cells["SubTotal"].Value = d.Subtotal.ToString("0.00");
                }

                TxtMontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                TxtMontoPago.Text = oVenta.MontoPago.ToString("0.00");
                TxtMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");
            }
            else
            {
                MessageBox.Show("No se encontró la venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // dejamos el formulario vacio para otra compra
        private void btnlimpiarr_Click(object sender, EventArgs e)
        {
            txtbusquedaa.Clear();
            txtnumerodocumento.Clear();
            txtFechaa.Clear();
            txtTipodedocumentoo.Clear();
            txtUsuarioo.Clear();
            TxtDocCliente.Clear();
            TxtNombre1Cli.Clear();
            TxtNombre2Cli.Clear();
            TxtApellido1Cli.Clear();
            TxtApellido2Cli.Clear();
            DgvData.Rows.Clear();
            TxtMontoTotal.Text = "0.00";
            TxtMontoPago.Text = "0.00";
            TxtMontoCambio.Text = "0.00";
            txtbusquedaa.Focus();
        }

        // enter para buscar
        private void txtbusquedaa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnbuscarr.PerformClick();
            }
        }

        // genera el PDF de la venta cm la compra
        private void btndescargarpdff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnumerodocumento.Text))
            {
                MessageBox.Show("Primero busque una venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //editar el documento del pdf
            string nombreNegocio = "VentaSoft";
            string docNegocio = "000-000000-0000X";
            string direcNegocio = "Managua, Nicaragua, del barrio villa nueva 3km.S"; //la direccion
            string telNegocio = "8888-8888"; // telefono del negocio

            //elige la plantilla ven segun el tipo boleta o fact
            bool esFactura = string.Equals(txtTipodedocumentoo.Text.Trim(), "Factura", StringComparison.OrdinalIgnoreCase);
            string archivoPlantilla = esFactura ? "PlantillaVentaFactura.html" : "PlantillaVentaBoleta.html";
            string rutaPlantilla = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantilla", archivoPlantilla);

            if (!File.Exists(rutaPlantilla))
            {
                MessageBox.Show("No se encontró la plantilla en: " + rutaPlantilla, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string html = File.ReadAllText(rutaPlantilla);

            string archivoLogo = "logo.png"; // cambiar el logo sl con el name
            int anchoLogo = 80;              // el ancho del logo del pdf

            string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plantilla", archivoLogo);
            string logoHtml = string.Empty;

            if (File.Exists(rutaLogo))
            {
                string tipoLogo = archivoLogo.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ? "image/png" : "image/jpeg";
                string base64 = Convert.ToBase64String(File.ReadAllBytes(rutaLogo));
                logoHtml = "<img src=\"data:" + tipoLogo + ";base64," + base64 + "\" style=\"width:" + anchoLogo + "px;\" />";
            }
            html = html.Replace("@logo", logoHtml);

            // nombre completo del cliente
            string nombreCliente = string.Join(" ",
                new[] { TxtNombre1Cli.Text, TxtNombre2Cli.Text, TxtApellido1Cli.Text, TxtApellido2Cli.Text }
                .Where(s => !string.IsNullOrWhiteSpace(s)));

            html = html.Replace("@nombrenegocio", nombreNegocio);
            html = html.Replace("@docnegocio", docNegocio);
            html = html.Replace("@direcnegocio", direcNegocio);
            html = html.Replace("@telnegocio", telNegocio);
            html = html.Replace("@tipodocumento", txtTipodedocumentoo.Text);
            html = html.Replace("@numerodocumento", txtnumerodocumento.Text);
            html = html.Replace("@doccliente", TxtDocCliente.Text);
            html = html.Replace("@nombrecliente", nombreCliente);
            html = html.Replace("@fecharegistro", txtFechaa.Text);
            html = html.Replace("@usuarioregistro", txtUsuarioo.Text);
            html = html.Replace("@montototal", TxtMontoTotal.Text);
            html = html.Replace("@montopago", TxtMontoPago.Text);
            html = html.Replace("@montocambio", TxtMontoCambio.Text);
            html = html.Replace("@subtotal", TxtMontoTotal.Text); // el sub es igual al total

            // las filas cambian segun el tipo 
            string filas = string.Empty;
            int numFila = 0;
            foreach (DataGridViewRow row in DgvData.Rows)
            {
                if (row.IsNewRow) continue;
                numFila++;

                if (esFactura)
                {
                    //
                    // factura
                    //
                    string fondo = (numFila % 2 == 1) ? "background-color:#F1F5F3;" : "";
                    string est = fondo + "padding:8px;font-size:12px;";
                    filas += "<tr>";
                    filas += "<td style=\"" + est + "text-align:left\">" + row.Cells["Producto"].Value + "</td>";
                    filas += "<td style=\"" + est + "text-align:right\">" + row.Cells["Precio"].Value + "</td>";
                    filas += "<td style=\"" + est + "text-align:right\">" + row.Cells["Cantidad"].Value + "</td>";
                    filas += "<td style=\"" + est + "text-align:right\">" + row.Cells["SubTotal"].Value + "</td>";
                    filas += "</tr>";
                }
                else
                {
                    //
                    // boleta
                    //
                    filas += "<tr>";
                    filas += "<td style=\"text-align:left;font-size:12px;padding-top:6px\">" + row.Cells["Producto"].Value + "</td>";
                    filas += "<td style=\"text-align:right;font-size:12px;padding-top:6px\">" + row.Cells["SubTotal"].Value + "</td>";
                    filas += "</tr>";
                    filas += "<tr>";
                    filas += "<td colspan=\"2\" style=\"text-align:left;font-size:11px;color:#6B7570\">" + row.Cells["Cantidad"].Value + " x " + row.Cells["Precio"].Value + "</td>";
                    filas += "</tr>";
                }
            }
            html = html.Replace("@filas", filas);

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = string.Format("Venta_{0}.pdf", txtnumerodocumento.Text);
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
    }
}