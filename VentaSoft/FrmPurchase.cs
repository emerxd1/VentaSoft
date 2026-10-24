using Data;
using Main.Modales;
using Main.Utilities;
using ModuloEntidades;
using SixLabors.Fonts;
using Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Main
{
    public partial class FrmPurchase : Form
    {
        //Recibe, almacena y prepara el formulario con los datos del usuario
        private Entidad_Usuario _usuario;

        public FrmPurchase(Entidad_Usuario ousuario = null)
        {
            _usuario = ousuario;
            InitializeComponent();
        }

        private void panelGraDi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegistrer_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtidProv.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in DgvData.Rows)
            {
                if (row.IsNewRow) continue;

                detalle_compra.Rows.Add(new object[]
                {
            Convert.ToInt32(row.Cells["idProducto"].Value),
            Convert.ToDecimal(row.Cells["PrecioCompra"].Value),
            Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
            Convert.ToInt32(row.Cells["Canti"].Value),
            Convert.ToDecimal(row.Cells["Subto"].Value)
                });
            }

            if (detalle_compra.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int idcorrelativo = new S_Compras().ObtenerCorrelativo();
            string numeroDocumento = "C" + idcorrelativo.ToString("0000"); // C0001, C0002 Para codigo Compra

            Entidad_Compra oCompra = new Entidad_Compra()
            {
                Usuario = new Entidad_Usuario() { IdUsuario = _usuario.IdUsuario },
                Proveedor = new Entidad_Proveedor() { IdProveedor = Convert.ToInt32(TxtidProv.Text) },
                TipoDocumento = ((OptionsComboBox)CbTipodeDocumento.SelectedItem).texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(TxtTotalPago.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new S_Compras().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Número de compra generado:\n" + numeroDocumento, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar el formulario
                DgvData.Rows.Clear();
                TxtTotalPago.Text = "0.00";
                TxtidProv.Text = "0";
                TxtdocProveedor.Clear();
                TxtnameProveedor.Clear();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtTotalPago_TextChanged(object sender, EventArgs e)
        {

        }
        //Inicia el menu desplegable del tipo de documento para las opciones Boleta y Factura
        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            DgvData.Columns["BtnEliminar"].Tag = ColorearIcono(Properties.Resources.borrar__1_, Color.Red); //icono de eliminar
            CbTipodeDocumento.Items.Add(new OptionsComboBox() { valor = "Boleta", texto = "Boleta" });

            CbTipodeDocumento.Items.Add(new OptionsComboBox() { valor = "Factura", texto = "Factura" });
            CbTipodeDocumento.ValueMember = "valor";
            CbTipodeDocumento.DisplayMember = "texto";
            CbTipodeDocumento.SelectedIndex = 0;

            TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); //Mostrar la fecha actual

            TxtidProd.Text = "0";
            TxtidProv.Text = "0";
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnsearchPro_Click(object sender, EventArgs e)
        {
            using (var modal = new MdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtidProv.Text = modal._Entidad_Proveedor.IdProveedor.ToString();
                    TxtdocProveedor.Text = modal._Entidad_Proveedor.RUC;
                    TxtnameProveedor.Text = modal._Entidad_Proveedor.RazonSocial;
                }
                else
                {
                    TxtdocProveedor.Select();
                }
            }
        }

        private void BtnBuscarProd_Click(object sender, EventArgs e)
        {
            using (var modal = new MdProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    TxtidProd.Text = modal._Entidad_Producto.IdProducto.ToString();
                    TxtcodProd.Text = modal._Entidad_Producto.Codigo;
                    TxtNombreProd.Text = modal._Entidad_Producto.Nombre;

                    TxtPrecioCompra.Clear();
                    TxtPrecioVenta.Clear();
                    TxtPrecioCompra.Focus();
                }
                else
                {
                    TxtcodProd.Select();
                }
            }
        }

        private void TxtcodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Entidad_Producto oproducto = new S_Product().Lister().Where(p => p.Codigo == TxtcodProd.Text && p.Estado == true).FirstOrDefault();

                if (oproducto != null)
                {
                    TxtcodProd.BackColor = Color.Honeydew;
                    TxtidProd.Text = oproducto.IdProducto.ToString();
                    TxtNombreProd.Text = oproducto.Nombre;
                    TxtPrecioCompra.Select();
                }
                else
                {
                    TxtcodProd.BackColor = Color.MistyRose;
                    TxtidProd.Text = "0";
                    TxtNombreProd.Text = "";
                }
            }
        }

        private void BtnAgregarProd_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(TxtidProd.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(TxtPrecioCompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(TxtPrecioVenta.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPrecioCompra.Select();
                return;
            }

            foreach (DataGridViewRow fila in DgvData.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells["idProducto"].Value?.ToString() == TxtidProd.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                DgvData.Rows.Add(new object[]
                {
                    TxtidProd.Text,
                    TxtNombreProd.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    TxtCantidad.Value.ToString(),
                    (TxtCantidad.Value * preciocompra).ToString("0.00")
                });

                calcularTotal();
                limapiarProducto();


            }


        }

        private void limapiarProducto()
        {
            TxtidProd.Text = "0";
            TxtcodProd.Text = "";
            TxtcodProd.BackColor = Color.White;
            TxtNombreProd.Text = "";
            TxtPrecioCompra.Text = "";
            TxtPrecioVenta.Text = "";
            TxtCantidad.Value = 1;
        }

        //Recorre los productos agregadas en las tabla de compra en el DgvData y muestra el monto final a pagar
        private void calcularTotal()
        {
            decimal total = 0; // variable acomuladora que inicia en 0

            foreach (DataGridViewRow row in DgvData.Rows) //recorre uno por uno los productos que el usuario ha agregado a la compra
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells["Subto"].Value);
            }

            TxtTotalPago.Text = total.ToString("0.00");
        }

        private void DgvData_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularTotal();
        }

        private void DgvData_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calcularTotal();
        }

        // Agremamos los saltos con enter par facilitar al momento de añadir
        private void TxtPrecioCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)          // se presionó Enter?
            {
                e.SuppressKeyPress = true;
                TxtPrecioVenta.Focus();           // mover el cursor
                TxtPrecioVenta.SelectAll();       // deja el texto seleccionado
            }

        }

        private void TxtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TxtCantidad.Focus();
                TxtCantidad.Select(0, TxtCantidad.Text.Length);
            }
        }

        private void TxtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnAgregarProd.PerformClick();
            }
        }

        private void DgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // para ignorar el header

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delate.Width;
                var h = Properties.Resources.delate.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delate, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        // CellClick responde en cualquier punto de la celda, aunque esté vacía
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (DgvData.Columns[e.ColumnIndex].Name != "BtnEliminar") return;
            if (DgvData.Rows[e.RowIndex].IsNewRow) return;

            DgvData.Rows.RemoveAt(e.RowIndex);
            calcularTotal();
        }


        private void TxtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void TxtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (TxtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //  repinta un icono de un solo color conservando su forma y transparencia
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
    }
}