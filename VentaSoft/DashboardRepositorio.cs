using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Main
{
    public class ResumenDashboard
    {
        public decimal VentasHoy;
        public int TotalProductos;
        public int StockBajo;
        public int TotalClientes;
        public int TotalProveedores;
        public string[] Dias;
        public double[] VentasSemana;
        public List<KeyValuePair<string, double>> VentasPorCategoria;
        public DataTable ProductosStockBajo;
    }

    public class DashboardRepositorio
    {
        private static readonly string[] NombresDias = { "Dom", "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb" };

        private readonly string _cadena;

        public DashboardRepositorio()
        {
            _cadena = ConfigurationManager.ConnectionStrings["connect_db"].ConnectionString;
        }

        public ResumenDashboard ObtenerResumen(int diasCategoria = 30)
        {
            var r = new ResumenDashboard();

            const string sql = @"
        -- 0) Conteos en una sola pasada por Producto
        SELECT COUNT(*)                                          AS Total,
               SUM(CASE WHEN Stock <= StockMinimo THEN 1 ELSE 0 END) AS Bajo
        FROM Producto WHERE Estado = 1;

        -- 1) Clientes y proveedores
        SELECT (SELECT COUNT(*) FROM Cliente   WHERE Estado = 1),
               (SELECT COUNT(*) FROM Proveedor WHERE Estado = 1);

        -- 2) Ventas por día (últimos 7); 'hoy' sale de aquí
        SELECT CAST(FechaRegistro AS date), SUM(MontoTotal)
        FROM Venta
        WHERE FechaRegistro >= DATEADD(day, -6, CAST(GETDATE() AS date))
          AND FechaRegistro <  DATEADD(day,  1, CAST(GETDATE() AS date))
        GROUP BY CAST(FechaRegistro AS date);

        -- 3) Ventas por categoría
        SELECT c.Nombre, SUM(dv.SubTotal) AS Total
        FROM Venta v
        JOIN DetalleVenta dv ON dv.IdVenta = v.IdVenta
        JOIN Producto p      ON p.IdProducto = dv.IdProducto
        JOIN Categoria c     ON c.IdCategoria = p.IdCategoria
        WHERE v.FechaRegistro >= DATEADD(day, -@dias, CAST(GETDATE() AS date))
        GROUP BY c.Nombre
        ORDER BY Total DESC;

        -- 4) Stock bajo
        SELECT TOP 20 Codigo AS [Código], Nombre AS Producto, Stock, StockMinimo AS [Mínimo]
        FROM Producto
        WHERE Estado = 1 AND Stock <= StockMinimo
        ORDER BY (Stock * 1.0 / NULLIF(StockMinimo, 0)), Nombre;";

            using (var cn = new SqlConnection(_cadena))
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@dias", SqlDbType.Int).Value = diasCategoria;
                cn.Open();

                using (var rd = cmd.ExecuteReader())
                {
                    // 0) Productos
                    rd.Read();
                    r.TotalProductos = rd.GetInt32(0);
                    r.StockBajo = rd.IsDBNull(1) ? 0 : rd.GetInt32(1);

                    // 1) Clientes / proveedores
                    rd.NextResult(); rd.Read();
                    r.TotalClientes = rd.GetInt32(0);
                    r.TotalProveedores = rd.GetInt32(1);

                    // 2) Ventas por día
                    rd.NextResult();
                    var porDia = new Dictionary<DateTime, double>();
                    while (rd.Read())
                        porDia[rd.GetDateTime(0).Date] = Convert.ToDouble(rd.GetValue(1));

                    DateTime hoy = DateTime.Today;
                    r.Dias = new string[7];
                    r.VentasSemana = new double[7];
                    for (int i = 0; i < 7; i++)
                    {
                        DateTime d = hoy.AddDays(i - 6);
                        r.Dias[i] = NombresDias[(int)d.DayOfWeek];
                        r.VentasSemana[i] = porDia.TryGetValue(d, out double v) ? v : 0;
                    }
                    r.VentasHoy = (decimal)r.VentasSemana[6];   // ya no hay consulta aparte

                    // 3) Categorías
                    rd.NextResult();
                    r.VentasPorCategoria = new List<KeyValuePair<string, double>>();
                    while (rd.Read())
                        r.VentasPorCategoria.Add(new KeyValuePair<string, double>(
                            rd.GetString(0), Convert.ToDouble(rd.GetValue(1))));

                    // 4) Stock bajo
                    rd.NextResult();
                    r.ProductosStockBajo = new DataTable();
                    r.ProductosStockBajo.Load(rd);
                }
            }

            return r;
        }
    }
}