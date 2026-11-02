using ClosedXML.Excel;
using Data;
using Entitys;
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
    public partial class FrmReporteCompra : Form
    {
        // Rango amplio: una fecha vacía significa "sin límite" en ese extremo
        // (static readonly: se crean una sola vez, no se parsean en cada clic)
        private static readonly DateTime FechaMin = new DateTime(2000, 1, 1);
        private static readonly DateTime FechaMax = new DateTime(2099, 12, 31);

        // Al abrir el formulario se cargan solo los últimos N días (0 = todo el historial)
        private const int DiasIniciales = 30;

        // Indica si hay filas ocultas por el filtro (evita recorrer el grid sin necesidad)
        private bool _filtroAplicado;

        // Pausa al escribir: filtra 250 ms después de la última tecla
        private readonly System.Windows.Forms.Timer _tmrFiltro = new System.Windows.Forms.Timer { Interval = 250 };

        public FrmReporteCompra()
        {
            InitializeComponent();
            new EscaladoProporcional(this);

            _tmrFiltro.Tick += (s, e) =>
            {
                _tmrFiltro.Stop();
                AplicarFiltro();
            };
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _tmrFiltro.Stop();
            _tmrFiltro.Dispose();
            base.OnFormClosed(e);
        }

        private void FrmReporteCompra_Load(object sender, EventArgs e)
        {
            // Proveedores
            List<Entidad_Proveedor> lista = new S_Proveedor().Lister();

            cbProveedores.Items.Add(new OptionsComboBox() { valor = 0, texto = "Todos los Proveedores" });

            foreach (Entidad_Proveedor item in lista)
            {
                cbProveedores.Items.Add(new OptionsComboBox() { valor = item.IdProveedor, texto = item.RazonSocial });
            }
            cbProveedores.DisplayMember = "texto";
            cbProveedores.ValueMember = "valor";
            cbProveedores.SelectedIndex = 0; // "Todos los Proveedores"

            // Columnas para el filtro de texto
            foreach (DataGridViewColumn columna in dgvReportCompra.Columns)
            {
                if (columna.Visible == true)
                {
                    cbFiltro.Items.Add(new OptionsComboBox() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbFiltro.DisplayMember = "texto";
            cbFiltro.ValueMember = "valor";
            if (cbFiltro.Items.Count > 0)
                cbFiltro.SelectedIndex = 0;

            // Al abrir: compras recientes de todos los proveedores (no todo el historial)
            string desde = DiasIniciales > 0
                ? DateTime.Today.AddDays(-DiasIniciales).ToString("yyyy-MM-dd")
                : FechaMin.ToString("yyyy-MM-dd");
            string hasta = DiasIniciales > 0
                ? DateTime.Today.ToString("yyyy-MM-dd")
                : FechaMax.ToString("yyyy-MM-dd");

            CargarReporte(desde, hasta, 0);
        }

        // Consulta la BD y llena el DataGridView. Devuelve la cantidad de filas (-1 si hubo error)
        private int CargarReporte(string fechaInicio, string fechaFin, int idProveedor)
        {
            try
            {
                List<ReporteCompra> listaReporte = new S_Reportes().Compra(
                    fechaInicio,
                    fechaFin,
                    idProveedor
                );

                dgvReportCompra.Rows.Clear();
                _filtroAplicado = false; // las filas nuevas nacen visibles

                // Se arman todas las filas y se agregan de una sola vez
                var filas = new DataGridViewRow[listaReporte.Count];
                for (int i = 0; i < filas.Length; i++)
                {
                    ReporteCompra item = listaReporte[i];
                    var row = new DataGridViewRow();
                    row.CreateCells(dgvReportCompra,
                        item.FechaRegistro,
                        item.TipoDocumento,
                        item.NumeroDocumento,
                        item.UsuarioRegistro,
                        item.DocumentoProveedor,
                        item.RazonSocial,
                        item.CodigoProducto,
                        item.NombreProducto,
                        item.Categoria,
                        item.PrecioCompra,
                        item.PrecioVenta,
                        item.Cantidad,
                        item.SubTotal);
                    filas[i] = row;
                }
                dgvReportCompra.Rows.AddRange(filas);

                AplicarFiltro(); // mantiene el filtro de texto después de cada consulta

                return listaReporte.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // error: ya se avisó, no mostrar "no se encontró"
            }
        }

        // Botón Buscar: usa las fechas de los DatePicker y el proveedor elegido
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbProveedores.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un proveedor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fecha vacía = sin límite en ese extremo
            DateTime inicio = FechaMin;
            DateTime fin = FechaMax;

            if (!string.IsNullOrWhiteSpace(dpInicio.Text) && !DateTime.TryParse(dpInicio.Text, out inicio))
            {
                MessageBox.Show("La fecha de inicio no es válida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(dpFin.Text) && !DateTime.TryParse(dpFin.Text, out fin))
            {
                MessageBox.Show("La fecha final no es válida.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProveedor = Convert.ToInt32(((OptionsComboBox)cbProveedores.SelectedItem).valor);

            int total = CargarReporte(inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"), idProveedor);

            if (total == 0)
            {
                MessageBox.Show("No se encontró ningún reporte para el proveedor y el rango de fechas seleccionados.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Búsqueda en vivo: espera 250 ms desde la última tecla antes de filtrar
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _tmrFiltro.Stop();
            _tmrFiltro.Start();
        }

        // Al cambiar la columna por la que se filtra, se vuelve a aplicar
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        // Oculta las filas que no contienen el texto en la columna elegida
        private void AplicarFiltro()
        {
            string texto = txtSearch.Text.Trim();

            // Con menos de 3 letras (o sin columna elegida) se muestran todas las filas
            bool filtrar = texto.Length >= 3 && cbFiltro.SelectedItem != null;

            // Sin filtro activo y sin filas ocultas: no hay nada que hacer
            if (!filtrar && !_filtroAplicado) return;

            // Índice de la columna resuelto una sola vez (no por cada fila)
            int col = filtrar
                ? dgvReportCompra.Columns[((OptionsComboBox)cbFiltro.SelectedItem).valor.ToString()].Index
                : -1;

            dgvReportCompra.CurrentCell = null; // necesario para poder ocultar la fila seleccionada
            dgvReportCompra.SuspendLayout();
            try
            {
                foreach (DataGridViewRow row in dgvReportCompra.Rows)
                {
                    if (row.IsNewRow) continue;

                    bool visible = !filtrar ||
                        (row.Cells[col].Value?.ToString() ?? "").IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;

                    if (row.Visible != visible) row.Visible = visible; // solo si cambia
                }
            }
            finally
            {
                dgvReportCompra.ResumeLayout();
            }

            _filtroAplicado = filtrar;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (dgvReportCompra.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();
            List<int> colIndexes = new List<int>();

            foreach (DataGridViewColumn column in dgvReportCompra.Columns)
            {
                if (!(column is DataGridViewButtonColumn))
                {
                    string encabezado = string.IsNullOrEmpty(column.HeaderText) ? column.Name : column.HeaderText;
                    dt.Columns.Add(encabezado, typeof(string));
                    colIndexes.Add(column.Index);
                }
            }

            // Solo las filas visibles: respeta el filtro de texto aplicado
            foreach (DataGridViewRow row in dgvReportCompra.Rows)
            {
                if (!row.IsNewRow && row.Visible)
                {
                    object[] values = new object[colIndexes.Count];
                    for (int i = 0; i < colIndexes.Count; i++)
                    {
                        values[i] = row.Cells[colIndexes[i]].Value?.ToString() ?? "";
                    }
                    dt.Rows.Add(values);
                }
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var savefile = new SaveFileDialog())
            {
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyy_HHmmss"));
                savefile.Filter = "Excel Files (*.xlsx)|*.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var hoja = wb.Worksheets.Add(dt, "Informe");
                            hoja.ColumnsUsed().AdjustToContents(1, 200); // mide solo las primeras 200 filas
                            wb.SaveAs(savefile.FileName);
                            MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar reporte: " + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        // Handler vacío: se conserva por si el Designer lo tiene enlazado
        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}