using Entitys;
using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace Data
{
    public class D_Reports
    {
        // Convierte el texto del DatePicker (formato de la cultura actual) a DateTime,
        // para enviarlo a SQL Server como DATE y no depender del formato del texto.
        private static DateTime ParseFecha(string texto)
        {
            return DateTime.Parse(texto, CultureInfo.CurrentCulture).Date;
        }

        public List<ReporteCompra> Compra(string FechaInicio, string FechaFin, int IdProveedor)
        {
            List<ReporteCompra> Lista = new List<ReporteCompra>();

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            using (SqlCommand cm = new SqlCommand("sp_ReporteCompras", oconnect))
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@fechainicio", SqlDbType.Date).Value = ParseFecha(FechaInicio);
                cm.Parameters.Add("@fechafin", SqlDbType.Date).Value = ParseFecha(FechaFin);
                cm.Parameters.Add("@idproveedor", SqlDbType.Int).Value = IdProveedor;

                oconnect.Open();

                using (SqlDataReader rd = cm.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Lista.Add(new ReporteCompra()
                        {
                            FechaRegistro = rd["FechaRegistro"].ToString(),
                            TipoDocumento = rd["TipoDocumento"].ToString(),
                            NumeroDocumento = rd["NumeroDocumento"].ToString(),
                            UsuarioRegistro = rd["UsuarioRegistro"].ToString(),
                            DocumentoProveedor = rd["RUCProveedor"].ToString(),
                            RazonSocial = rd["RazonSocial"].ToString(),
                            CodigoProducto = rd["CodigoProducto"].ToString(),
                            NombreProducto = rd["NombreProducto"].ToString(),
                            Categoria = rd["Categoria"].ToString(),
                            PrecioCompra = rd["PrecioCompra"].ToString(),
                            PrecioVenta = rd["PrecioVenta"].ToString(),
                            Cantidad = rd["Cantidad"].ToString(),
                            SubTotal = rd["SubTotal"].ToString()
                        });
                    }
                }
            }

            return Lista; // Los errores se propagan: el formulario los captura y los muestra
        }

        public List<ReporteVentas> Venta(string FechaInicio, string FechaFin)
        {
            List<ReporteVentas> Lista = new List<ReporteVentas>();

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            using (SqlCommand cm = new SqlCommand("sp_ReporteVentas", oconnect))
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add("@fechainicio", SqlDbType.Date).Value = ParseFecha(FechaInicio);
                cm.Parameters.Add("@fechafin", SqlDbType.Date).Value = ParseFecha(FechaFin);

                oconnect.Open();

                using (SqlDataReader rd = cm.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Lista.Add(new ReporteVentas()
                        {
                            FechaRegistro = rd["FechaRegistro"].ToString(),
                            TipoDocumento = rd["TipoDocumento"].ToString(),   
                            NumeroDocumento = rd["NumeroDocumento"].ToString(),
                            UsuarioRegistro = rd["UsuarioRegistro"].ToString(),
                            NombreCliente = rd["NombreCliente"].ToString(),
                            CodigoProducto = rd["CodigoProducto"].ToString(),
                            NombreProducto = rd["NombreProducto"].ToString(),
                            Categoria = rd["Categoria"].ToString(),
                            PrecioVenta = rd["PrecioVenta"].ToString(),
                            Cantidad = rd["Cantidad"].ToString(),
                            SubTotal = rd["MontoTotal"].ToString()
                        });
                    }
                }
            }

            return Lista;
        }
    }
}