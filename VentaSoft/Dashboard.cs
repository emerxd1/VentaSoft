using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;

namespace Main
{
    public partial class Dashboard : Form
    {
        // Paleta
        private static readonly Color ColorFondo = Color.FromArgb(244, 246, 248);
        private static readonly Color ColorTexto = Color.FromArgb(31, 41, 55);
        private static readonly Color ColorTextoSuave = Color.FromArgb(107, 114, 128);
        private static readonly Color ColorVerde = Color.FromArgb(46, 125, 91);
        private static readonly Color ColorAzul = Color.FromArgb(59, 130, 246);
        private static readonly Color ColorRojo = Color.FromArgb(220, 76, 64);
        private static readonly Color ColorMorado = Color.FromArgb(124, 77, 220);
        private static readonly Color ColorAmbar = Color.FromArgb(217, 119, 6);

        private TableLayoutPanel filaTarjetas;
        private CartesianChart graficoBarras;
        private PieChart graficoPastel;
        private DataGridView tablaStockBajo;

        public Dashboard()
        {
            InitializeComponent();

            Text = "Dashboard - Pulpería";
            BackColor = ColorFondo;
            Font = new Font("Segoe UI", 10);

            ConstruirInterfaz();
            CargarDatos();
        }

        private void ConstruirInterfaz()
        {
            // Contenedor principal: título, tarjetas, gráficos, tabla
            var raiz = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                ColumnCount = 1,
                RowCount = 4,
                BackColor = ColorFondo
            };
            raiz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 125));
            raiz.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            raiz.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Controls.Add(raiz);

            // ===== Fila 1: título =====
            var encabezado = new Panel { Dock = DockStyle.Fill, BackColor = Color.Transparent };

            var lblSubtitulo = new Label
            {
                Text = "Resumen del negocio  ·  " + DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", new CultureInfo("es-NI")),
                Dock = DockStyle.Top,
                Height = 24,
                ForeColor = ColorTextoSuave,
                Font = new Font("Segoe UI", 10)
            };
            var lblTitulo = new Label
            {
                Text = "Dashboard- Pulpería Oasis de Bendición",
                Dock = DockStyle.Top,
                Height = 40,
                ForeColor = ColorTexto,
                Font = new Font("Segoe UI Semibold", 22)
            };
            encabezado.Controls.Add(lblSubtitulo);
            encabezado.Controls.Add(lblTitulo);
            raiz.Controls.Add(encabezado, 0, 0);

            // ===== Fila 2: tarjetas de resumen (5 columnas iguales) =====
            filaTarjetas = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 5,
                RowCount = 1,
                BackColor = Color.Transparent
            };
            for (int i = 0; i < 5; i++)
                filaTarjetas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 5));
            raiz.Controls.Add(filaTarjetas, 0, 1);

            // ===== Fila 3: gráficos =====
            var filaGraficos = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.Transparent
            };
            filaGraficos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            filaGraficos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            raiz.Controls.Add(filaGraficos, 0, 2);

            graficoBarras = new CartesianChart { Dock = DockStyle.Fill, BackColor = Color.White };
            var cardBarras = CrearContenedor("Ventas de la semana", graficoBarras);
            filaGraficos.Controls.Add(cardBarras, 0, 0);

            graficoPastel = new PieChart { Dock = DockStyle.Fill, BackColor = Color.White };
            var cardPastel = CrearContenedor("Ventas por categoría", graficoPastel);
            filaGraficos.Controls.Add(cardPastel, 1, 0);

            // ===== Fila 4: tabla =====
            tablaStockBajo = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToResizeRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                EnableHeadersVisualStyles = false,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(235, 238, 242),
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                ColumnHeadersHeight = 40
            };
            tablaStockBajo.RowTemplate.Height = 36;

            tablaStockBajo.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            tablaStockBajo.ColumnHeadersDefaultCellStyle.ForeColor = ColorTextoSuave;
            tablaStockBajo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            tablaStockBajo.ColumnHeadersDefaultCellStyle.SelectionForeColor = ColorTextoSuave;
            tablaStockBajo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            tablaStockBajo.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            tablaStockBajo.DefaultCellStyle.BackColor = Color.White;
            tablaStockBajo.DefaultCellStyle.ForeColor = ColorTexto;
            tablaStockBajo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(222, 240, 231);
            tablaStockBajo.DefaultCellStyle.SelectionForeColor = ColorTexto;
            tablaStockBajo.DefaultCellStyle.Padding = new Padding(8, 0, 0, 0);

            var cardTabla = CrearContenedor("Productos con stock bajo", tablaStockBajo);
            raiz.Controls.Add(cardTabla, 0, 3);
        }

        // Tarjeta con título arriba y un control que ocupa el resto
        private CardPanel CrearContenedor(string titulo, Control contenido)
        {
            var card = new CardPanel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                Padding = new Padding(16, 14, 16, 14)
            };

            contenido.Dock = DockStyle.Fill;

            var lbl = new Label
            {
                Text = titulo,
                Dock = DockStyle.Top,
                Height = 32,
                ForeColor = ColorTexto,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Semibold", 12)
            };

            // Primero el control que llena, luego el título que se acopla arriba
            card.Controls.Add(contenido);
            card.Controls.Add(lbl);
            return card;
        }

        private CardPanel CrearTarjeta(string titulo, string valor, string detalle, Color acento)
        {
            var tarjeta = new CardPanel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                Accent = acento
            };

            var lblTitulo = new Label
            {
                Text = titulo,
                AutoSize = true,
                Location = new Point(20, 14),
                ForeColor = ColorTextoSuave,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 10)
            };
            var lblValor = new Label
            {
                Text = valor,
                AutoSize = true,
                Location = new Point(18, 36),
                ForeColor = ColorTexto,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI Semibold", 24)
            };
            var lblDetalle = new Label
            {
                Text = detalle,
                AutoSize = true,
                Location = new Point(20, 84),
                ForeColor = acento,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 9)
            };

            tarjeta.Controls.Add(lblTitulo);
            tarjeta.Controls.Add(lblValor);
            tarjeta.Controls.Add(lblDetalle);
            return tarjeta;
        }

        private void CargarDatos()
        {
            // ====== DATOS DE EJEMPLO ======
            // Reemplaza estos valores con consultas a tu base de datos.
            decimal ventasHoy = 4850.50m;
            int totalProductos = 128;
            int stockBajo = 7;
            int totalClientes = 56;
            int totalProveedores = 12;

            string[] dias = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };
            double[] ventasSemana = { 3200, 2800, 3500, 3100, 4200, 5600, 4850 };

            var ventasPorCategoria = new List<KeyValuePair<string, double>>
            {
                new KeyValuePair<string, double>("Abarrotes", 4500),
                new KeyValuePair<string, double>("Bebidas", 3200),
                new KeyValuePair<string, double>("Lácteos", 1800),
                new KeyValuePair<string, double>("Limpieza", 1200),
                new KeyValuePair<string, double>("Snacks", 900)
            };

            // ====== TARJETAS ======
            filaTarjetas.Controls.Clear();
            filaTarjetas.Controls.Add(CrearTarjeta("Ventas de hoy", "C$ " + ventasHoy.ToString("N2"), "Total vendido en el día", ColorVerde), 0, 0);
            filaTarjetas.Controls.Add(CrearTarjeta("Productos en inventario", totalProductos.ToString(), "Productos registrados", ColorAzul), 1, 0);
            filaTarjetas.Controls.Add(CrearTarjeta("Stock bajo", stockBajo.ToString(), "Requieren reabastecerse", ColorRojo), 2, 0);
            filaTarjetas.Controls.Add(CrearTarjeta("Clientes", totalClientes.ToString(), "Clientes registrados", ColorMorado), 3, 0);
            filaTarjetas.Controls.Add(CrearTarjeta("Proveedores", totalProveedores.ToString(), "Proveedores registrados", ColorAmbar), 4, 0);

            // ====== GRÁFICO DE BARRAS ======
            graficoBarras.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Name = "Ventas",
                    Values = ventasSemana,
                    Fill = new SolidColorPaint(SKColor.Parse("#2E7D5B")),
                    Rx = 6,
                    Ry = 6,
                    MaxBarWidth = 40
                }
            };
            graficoBarras.XAxes = new[]
            {
                new Axis
                {
                    Labels = dias,
                    LabelsPaint = new SolidColorPaint(SKColor.Parse("#6B7280")),
                    TextSize = 13
                }
            };
            graficoBarras.YAxes = new[]
            {
                new Axis
                {
                    MinLimit = 0,
                    Labeler = valor => "C$ " + valor.ToString("N0"),
                    LabelsPaint = new SolidColorPaint(SKColor.Parse("#6B7280")),
                    SeparatorsPaint = new SolidColorPaint(SKColor.Parse("#E5E7EB")),
                    TextSize = 12
                }
            };

            // ====== GRÁFICO DE DONA ======
            string[] colores = { "#2E7D5B", "#4CAF82", "#F2B134", "#3B82F6", "#E86A5E" };
            var series = new List<ISeries>();
            int i = 0;
            foreach (var item in ventasPorCategoria)
            {
                series.Add(new PieSeries<double>
                {
                    Name = item.Key,
                    Values = new double[] { item.Value },
                    InnerRadius = 55,
                    Fill = new SolidColorPaint(SKColor.Parse(colores[i % colores.Length]))
                });
                i++;
            }
            graficoPastel.Series = series;
            graficoPastel.LegendPosition = LegendPosition.Right;

            // ====== TABLA DE STOCK BAJO ======
            tablaStockBajo.Columns.Clear();
            tablaStockBajo.Columns.Add("Codigo", "Código");
            tablaStockBajo.Columns.Add("Producto", "Producto");
            tablaStockBajo.Columns.Add("Stock", "Stock");
            tablaStockBajo.Columns.Add("Minimo", "Mínimo");

            // Stock en rojo y negrita
            tablaStockBajo.Columns["Stock"].DefaultCellStyle.ForeColor = ColorRojo;
            tablaStockBajo.Columns["Stock"].DefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);

            tablaStockBajo.Rows.Clear();
            tablaStockBajo.Rows.Add("P-0012", "Arroz 1 lb", 5, 20);
            tablaStockBajo.Rows.Add("P-0034", "Aceite 1 L", 3, 10);
            tablaStockBajo.Rows.Add("P-0051", "Azúcar 1 lb", 4, 15);
            tablaStockBajo.Rows.Add("P-0078", "Leche en polvo", 2, 8);

            tablaStockBajo.ClearSelection();
        }
    }

    // Panel blanco con esquinas redondeadas y franja de color opcional a la izquierda
    public class CardPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Radius { get; set; } = 12;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Accent { get; set; } = Color.Empty;

        public CardPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Pinta el fondo del contenedor para que las esquinas se vean redondeadas
            Color fondo = Parent != null ? Parent.BackColor : SystemColors.Control;
            if (fondo == Color.Transparent) fondo = Color.FromArgb(244, 246, 248);
            e.Graphics.Clear(fondo);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = CrearRuta(rect, Radius))
            using (var relleno = new SolidBrush(Color.White))
            using (var borde = new Pen(Color.FromArgb(229, 231, 235)))
            {
                e.Graphics.FillPath(relleno, path);

                if (Accent != Color.Empty)
                {
                    e.Graphics.SetClip(path);
                    using (var b = new SolidBrush(Accent))
                        e.Graphics.FillRectangle(b, 0, 0, 6, Height);
                    e.Graphics.ResetClip();
                }

                e.Graphics.DrawPath(borde, path);
            }
        }

        private static GraphicsPath CrearRuta(Rectangle r, int radio)
        {
            int d = radio * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}