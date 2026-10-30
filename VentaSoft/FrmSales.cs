using Main.Modales;
using Main.Utilities;
using ModuloEntidades;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging; //para añadir colores a los iconos
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class FrmSales : Form
    {
        private readonly TextBox TxtidCliente = new TextBox();//idcliente
        private Entidad_Usuario _usuario;


        public FrmSales(Entidad_Usuario ousuario = null)
        {
            _usuario = ousuario;
            InitializeComponent();
            new EscaladoProporcional(this); // mandamos a llamar escalado proporcional para el auto escalado en auto para cualquier pantalla

            // enlazamos los eventos por código para evitar que esten duplicadas si ya estan el el diseñador
            DgvData.CellClick -= DgvData_CellClick;
            DgvData.CellClick += DgvData_CellClick;

            TxtPagaCon.TextChanged -= TxtPagaCon_TextChanged;
            TxtPagaCon.TextChanged += TxtPagaCon_TextChanged;

            TxtPagaCon.KeyPress -= TxtPagaCon_KeyPress;
            TxtPagaCon.KeyPress += TxtPagaCon_KeyPress;

            TxtPagaCon.KeyDown -= TxtPagaCon_KeyDown;
            TxtPagaCon.KeyDown += TxtPagaCon_KeyDown;
        }

        // enter para , Paga con, calcula el cambio y deja el cursor en Crear Venta
        private void TxtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evitamos el sonido de wind
                CalcularCambio();
                BtnCrearVenta.Focus();     // y con otro enter se crea la venta como btn
            }
        }
        private void lblTituloGrupo1_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName1_TextChanged(object sender, EventArgs e)
        {

        }

        // este Load es para preparar un icono, combo, fecha y los ids ocultos del data editado por codigo
        private void FrmSales_Load(object sender, EventArgs e)
        {
            DataGridViewColumn colEliminar = DgvData.Columns["BtnEliminar"];
            Image iconoEliminar = Properties.Resources.dgvdelate;
            if (colEliminar != null && iconoEliminar != null)
            {
                colEliminar.Tag = ColorearIcono(iconoEliminar, Color.Red);//podemos añadir un icono con el nombre
            }

            CbTipodeDocumento.Items.Add(new OptionsComboBox() { valor = "Boleta", texto = "Boleta" });
            CbTipodeDocumento.Items.Add(new OptionsComboBox() { valor = "Factura", texto = "Factura" });
            CbTipodeDocumento.ValueMember = "valor";
            CbTipodeDocumento.DisplayMember = "texto";
            CbTipodeDocumento.SelectedIndex = 0;

            TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            TxtidCliente.Text = "0";
            TxtidProd.Text = "0";
            TxtTotalPago.Text = "0.00";
            TxtCambio.Text = "0.00";
        }

        // CLIENTE
        //aqui abrimos el modalprodudtos o MdClientes para mostrar los los clientes , documento etc que ya estan guardados
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new MdClientes())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtidCliente.Text = modal._Entidad_Cliente.IdCliente.ToString();
                    TxtDocCliente.Text = modal._Entidad_Cliente.DNI;
                    TxtNombre1Cli.Text = modal._Entidad_Cliente.Nombre1; // tenemos nombre1,2 etc pero en el modal se muestra como un solo nombre completo
                    TxtNombre2Cli.Text = modal._Entidad_Cliente.Nombre2;
                    TxtApellido1Cli.Text = modal._Entidad_Cliente.Apellido1;
                    TxtApellido2Cli.Text = modal._Entidad_Cliente.Apellido2;

                    TxtcodProd.Select();
                }
                else
                {
                    TxtDocCliente.Select();
                }
            }
        }

        // PRODUCTO
        //aqui abrimos el modalprodudtos o MdProductos para mostrar los productos,precio etc que ya estan guardados
        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            using (var modal = new MdProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarProducto(modal._Entidad_Producto);
                }
                else
                {
                    TxtcodProd.Select();
                }
            }
        }

        // usamo keydown para precionar enter y buscar cono boton
        private void TxtcodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                Entidad_Producto oproducto = new S_Product().Lister()
                    .Where(p => p.Codigo == TxtcodProd.Text.Trim() && p.Estado == true)
                    .FirstOrDefault();

                if (oproducto != null)
                {
                    TxtcodProd.BackColor = Color.Honeydew;
                    CargarProducto(oproducto);
                }
                else
                {
                    TxtcodProd.BackColor = Color.MistyRose;
                    TxtidProd.Text = "0";
                    TxtNombreProd.Text = "";
                    TxtPrecioVenta.Text = "";
                    TxtStock.Text = "";
                }
            }
        }

        // aqui pasamos los datos delos producto a los cuadros y dejamos el cursor en Cantidad para mas facil el uso
        private void CargarProducto(Entidad_Producto p)
        {
            TxtidProd.Text = p.IdProducto.ToString();
            TxtcodProd.Text = p.Codigo;
            TxtNombreProd.Text = p.Nombre;
            TxtPrecioVenta.Text = p.PrecioVenta.ToString("0.00");
            TxtStock.Text = p.Stock.ToString();

            TxtCantidad.Value = 1;
            TxtCantidad.Focus();
            TxtCantidad.Select(0, TxtCantidad.Text.Length);
        }

        private void TxtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnAgregarProd.PerformClick();
            }
        }


        //es necesario seleccionar un producto 
        private void BtnAgregarProd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtidProd.Text, out int idProducto) || idProducto == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(TxtPrecioVenta.Text, out decimal precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int.TryParse(TxtStock.Text, out int stock);
            int cantidad = (int)TxtCantidad.Value;

            // para no vender mas de lo que hay
            if (stock <= 0)
            {
                MessageBox.Show("El producto no tiene stock disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cantidad > stock)
            {
                MessageBox.Show("La cantidad (" + cantidad + ") supera el stock disponible (" + stock + ")", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCantidad.Focus();
                return;
            }

            // para no repetir el producto en la tabla
            foreach (DataGridViewRow fila in DgvData.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells["IdProducto"].Value?.ToString() == TxtidProd.Text)
                {
                    MessageBox.Show("Ese producto ya esta en la venta. Elimínelo de la tabla si quiere cambiar la cantidad.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // Orden de columnas, IdProducto, Producto, Precio, Cantidad, SubTotal y el BtnEliminar para limpiar
            DgvData.Rows.Add(new object[]
            {
                TxtidProd.Text,
                TxtNombreProd.Text,
                precio.ToString("0.00"),
                cantidad.ToString(),
                (cantidad * precio).ToString("0.00")
            });

            CalcularTotal();
            LimpiarProducto();
            TxtPagaCon.Focus();
        }

        //metodo para limpiar

        private void LimpiarProducto()
        {
            TxtidProd.Text = "0";
            TxtcodProd.Text = "";
            TxtcodProd.BackColor = Color.White;
            TxtNombreProd.Text = "";
            TxtPrecioVenta.Text = "";
            TxtStock.Text = "";
            TxtCantidad.Value = 1;
        }

        // se puede seleccionar en cualquie cuadro
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (!string.Equals(DgvData.Columns[e.ColumnIndex].Name, "BtnEliminar", StringComparison.OrdinalIgnoreCase)) return;
            if (DgvData.Rows[e.RowIndex].IsNewRow) return;

            DgvData.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
        }

        private void CalcularTotal() // calculamos el total
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DgvData.Rows)
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }

            TxtTotalPago.Text = total.ToString("0.00");
            CalcularCambio();
        }

        // cambio
        private void CalcularCambio()
        {
            decimal.TryParse(TxtTotalPago.Text, out decimal total); // la paga va a ser la paga con - el total
            decimal.TryParse(TxtPagaCon.Text, out decimal pagaCon);

            TxtCambio.Text = (total > 0 && pagaCon >= total) ? (pagaCon - total).ToString("0.00") : "0.00";// si la paga no se al canza o no hay nada queda en 0
        }

        private void TxtPagaCon_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        // aqui hacemos que solo se escriba en digitos y un punto 
        private void TxtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;

            bool esPunto = e.KeyChar == '.';
            bool yaTienePunto = TxtPagaCon.Text.Contains(".");
            bool vacio = TxtPagaCon.Text.Trim().Length == 0;

            e.Handled = !(esPunto && !yaTienePunto && !vacio);
        }

        // btn para crear la venta
        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            if (_usuario == null)
            {
                MessageBox.Show("No se recibió el usuario que realiza la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TxtidCliente.Text, out int idCliente) || idCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // el datable debe tener las columnas en el mimmo orden que dbo.EDetalle_Venta
            DataTable detalle_venta = new DataTable();
            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in DgvData.Rows)
            {
                if (row.IsNewRow) continue;

                detalle_venta.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["IdProducto"].Value),
                    Convert.ToDecimal(row.Cells["Precio"].Value),
                    Convert.ToInt32(row.Cells["Cantidad"].Value),
                    Convert.ToDecimal(row.Cells["SubTotal"].Value)
                });
            }

            if (detalle_venta.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal total = Convert.ToDecimal(TxtTotalPago.Text);

            if (!decimal.TryParse(TxtPagaCon.Text, out decimal pagaCon) || pagaCon < total)
            {
                MessageBox.Show("El monto con el que paga no alcanza para cubrir el total", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPagaCon.Focus();
                return;
            }

            int idcorrelativo = new S_Ventas().ObtenerCorrelativo();
            string numeroFactura = "V" + idcorrelativo.ToString("0000"); // codigo para ventas V0001, V0002...

            Entidad_Venta oVenta = new Entidad_Venta()
            {
                Usuario = new Entidad_Usuario() { IdUsuario = _usuario.IdUsuario },
                Cliente = new Entidad_Cliente() { IdCliente = idCliente },
                TipoDocumento = ((OptionsComboBox)CbTipodeDocumento.SelectedItem).texto,
                NumeroFactura = numeroFactura,
                MontoPago = pagaCon,
                MontoCambio = pagaCon - total,
                MontoTotal = total
            };

            bool respuesta = new S_Ventas().Registrar(oVenta, detalle_venta, out string mensaje);

            if (respuesta)
            {
                MessageBox.Show("Número de venta generado:\n" + numeroFactura + "\nCambio: " + oVenta.MontoCambio.ToString("0.00"),
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarVenta();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deja el formulario listo para la siguiente venta
        private void LimpiarVenta()
        {
            DgvData.Rows.Clear();

            TxtidCliente.Text = "0";
            TxtDocCliente.Clear();
            TxtNombre1Cli.Clear();
            TxtNombre2Cli.Clear();
            TxtApellido1Cli.Clear();
            TxtApellido2Cli.Clear();

            LimpiarProducto();
            TxtPagaCon.Text = string.Empty;
            TxtTotalPago.Text = "0.00";
            TxtCambio.Text = "0.00";

            TxtDocCliente.Focus();
        }

        // repinta un icono de un solo color conservando su forma y transparencia
        private static Bitmap ColorearIcono(Image origen, Color color)
        {
            var bmp = new Bitmap(origen.Width, origen.Height);
            using (var g = Graphics.FromImage(bmp))
            using (var ia = new ImageAttributes())
            {
                var cm = new ColorMatrix(new float[][]
                {
                    new float[] { 0, 0, 0, 0, 0 },
                    new float[] { 0, 0, 0, 0, 0 },
                    new float[] { 0, 0, 0, 0, 0 },
                    new float[] { 0, 0, 0, 1, 0 },
                    new float[] { color.R / 255f, color.G / 255f, color.B / 255f, 0, 1 }
                });
                ia.SetColorMatrix(cm);
                g.DrawImage(origen, new Rectangle(0, 0, bmp.Width, bmp.Height),
                            0, 0, origen.Width, origen.Height, GraphicsUnit.Pixel, ia);
            }
            return bmp;
        }

        private void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtDocCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita el sonido ding de wind

                string dni = TxtDocCliente.Text.Trim();
                if (dni == string.Empty) return;

                Entidad_Cliente ocliente = new S_Clients().Lister()
                    .Where(c => string.Equals(c.DNI?.Trim(), dni, StringComparison.OrdinalIgnoreCase))
                    .FirstOrDefault();

                if (ocliente == null)
                {
                    // si no existe se limpian los datos para no vender a un cliente anterior
                    TxtDocCliente.BackColor = Color.MistyRose;
                    TxtidCliente.Text = "0";
                    TxtNombre1Cli.Clear();
                    TxtNombre2Cli.Clear();
                    TxtApellido1Cli.Clear();
                    TxtApellido2Cli.Clear();
                    return;
                }

                if (!ocliente.Estado)
                {
                    MessageBox.Show("El cliente está inactivo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TxtDocCliente.BackColor = Color.Honeydew;
                TxtidCliente.Text = ocliente.IdCliente.ToString();
                TxtNombre1Cli.Text = ocliente.Nombre1;
                TxtNombre2Cli.Text = ocliente.Nombre2;
                TxtApellido1Cli.Text = ocliente.Apellido1;
                TxtApellido2Cli.Text = ocliente.Apellido2;

                TxtcodProd.Select(); // sigue con el producto
            }
        }

        private void TxtcodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiGroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}