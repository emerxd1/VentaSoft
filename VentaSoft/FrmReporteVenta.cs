using ClosedXML.Excel;
using Entitys;
using Main.Utilities;
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
    public partial class FrmReporteVenta : Form
    {
        // Rango amplio: una fecha vacía significa "sin límite" en ese extremo
        private const string FechaMinima = "2000-01-01";
        private const string FechaMaxima = "2099-12-31";
        public FrmReporteVenta()
        {
            InitializeComponent();
            // Columnas para el filtro de texto
            foreach (DataGridViewColumn columna in dgvReportVenta.Columns)
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
            // Al abrir: todas las ventas
            CargarReporte(FechaMinima, FechaMaxima);


        }

        private void CargarReporte(string fechaInicio, string fechaFin)
        {
            try
            {
                List<ReporteVentas> listaReporte = new S_Reportes().Venta(
                    fechaInicio,
                    fechaFin
                );

                dgvReportVenta.Rows.Clear();

                foreach (ReporteVentas item in listaReporte)
                {
                    dgvReportVenta.Rows.Add(new object[]
                    {
                        item.FechaRegistro,
                        item.TipoDocumento,
                        item.NumeroDocumento,
                        item.UsuarioRegistro,
                        item.NombreCliente,
                        item.CodigoProducto,
                        item.NombreProducto,
                        item.Categoria,
                        item.PrecioVenta,
                        item.Cantidad,
                        item.SubTotal
                    });
                }

                AplicarFiltro(); // mantiene el filtro de texto después de cada consulta
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el reporte: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltro()
        {
            string texto = txtSearch.Text.Trim();

            // Con menos de 3 letras (o sin columna elegida) se muestran todas las filas
            bool filtrar = texto.Length >= 3 && cbFiltro.SelectedItem != null;

            string columna = filtrar
                ? ((OptionsComboBox)cbFiltro.SelectedItem).valor.ToString()
                : null;

            dgvReportVenta.CurrentCell = null; // necesario para poder ocultar la fila seleccionada

            foreach (DataGridViewRow row in dgvReportVenta.Rows)
            {
                if (row.IsNewRow) continue;

                if (!filtrar)
                {
                    row.Visible = true;
                    continue;
                }

                string valor = row.Cells[columna].Value?.ToString() ?? "";
                row.Visible = valor.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Fecha vacía = sin límite en ese extremo
            DateTime inicio = DateTime.Parse(FechaMinima);
            DateTime fin = DateTime.Parse(FechaMaxima);

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

            CargarReporte(inicio.ToString("yyyy-MM-dd"), fin.ToString("yyyy-MM-dd"));

        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvReportVenta.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = new DataTable();
            List<int> colIndexes = new List<int>();

            foreach (DataGridViewColumn column in dgvReportVenta.Columns)
            {
                if (!(column is DataGridViewButtonColumn))
                {
                    string encabezado = string.IsNullOrEmpty(column.HeaderText) ? column.Name : column.HeaderText;
                    dt.Columns.Add(encabezado, typeof(string));
                    colIndexes.Add(column.Index);
                }
            }

            foreach (DataGridViewRow row in dgvReportVenta.Rows)
            {
                if (!row.IsNewRow)
                {
                    object[] values = new object[colIndexes.Count];
                    for (int i = 0; i < colIndexes.Count; i++)
                    {
                        values[i] = row.Cells[colIndexes[i]].Value?.ToString() ?? "";
                    }
                    dt.Rows.Add(values);
                }
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("ReporteVentas_{0}.xlsx", DateTime.Now.ToString("ddMMyyyy_HHmmss"));
            savefile.Filter = "Excel Files (*.xlsx)|*.xlsx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
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
}
