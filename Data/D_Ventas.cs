using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class D_Ventas
    {
        // Numero de la proxima venta 
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Venta");
                    SqlCommand cm = new SqlCommand(query.ToString(), oconnect);
                    cm.CommandType = CommandType.Text;

                    oconnect.Open();
                    idcorrelativo = Convert.ToInt32(cm.ExecuteScalar());
                }
                catch (Exception)
                {
                    idcorrelativo = 0;
                }
            }
            return idcorrelativo;
        }

        // llama a sp_RegistrarVenta y los detalles viajan  como tabla Structured
        public bool Registrar(Entidad_Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Repuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_RegistrarVenta", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@IdUsuario", obj.Usuario.IdUsuario);
                    cm.Parameters.AddWithValue("@IdCliente", obj.Cliente.IdCliente);
                    cm.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cm.Parameters.AddWithValue("@NumeroFactura", obj.NumeroFactura);
                    cm.Parameters.AddWithValue("@MontoPago", obj.MontoPago);
                    cm.Parameters.AddWithValue("@MontoCambio", obj.MontoCambio);
                    cm.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);

                    SqlParameter pDetalle = cm.Parameters.Add("@DetalleVenta", SqlDbType.Structured);
                    pDetalle.TypeName = "dbo.EDetalle_Venta";
                    pDetalle.Value = DetalleVenta;

                    cm.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    Repuesta = Convert.ToBoolean(cm.Parameters["@Resultado"].Value);
                    Mensaje = cm.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Repuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Repuesta;
        }

        // busaca una venta por codigo ej 00001 consulta 1
        public Entidad_Venta ObtenerVenta(string numero)
        {
            Entidad_Venta obj = new Entidad_Venta();

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT v.IdVenta,");
                    query.AppendLine("u.Nombre1 AS UsuNombre1, u.Apellido1 AS UsuApellido1,");
                    query.AppendLine("c.DNI AS DNICliente,");
                    query.AppendLine("c.Nombre1 AS CliNombre1, c.Nombre2 AS CliNombre2,");
                    query.AppendLine("c.Apellido1 AS CliApellido1, c.Apellido2 AS CliApellido2,");
                    query.AppendLine("v.TipoDocumento, v.NumeroFactura,");
                    query.AppendLine("v.MontoPago, v.MontoCambio, v.MontoTotal,");
                    query.AppendLine("CONVERT(char(10), v.FechaRegistro, 103) AS FechaRegistro");
                    query.AppendLine("FROM Venta v");
                    query.AppendLine("INNER JOIN Usuario u ON u.IdUsuario = v.IdUsuario");
                    query.AppendLine("INNER JOIN Cliente c ON c.IdCliente = v.IdCliente");
                    query.AppendLine("WHERE v.NumeroFactura = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconnect);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconnect.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            obj = new Entidad_Venta()
                            {
                                IdVenta = Convert.ToInt32(rd["IdVenta"]),
                                Usuario = new Entidad_Usuario()
                                {
                                    Nombre1 = rd["UsuNombre1"].ToString(),
                                    Apellido1 = rd["UsuApellido1"].ToString()
                                },
                                Cliente = new Entidad_Cliente()
                                {
                                    DNI = rd["DNICliente"].ToString(),
                                    Nombre1 = rd["CliNombre1"].ToString(),
                                    Nombre2 = rd["CliNombre2"].ToString(),
                                    Apellido1 = rd["CliApellido1"].ToString(),
                                    Apellido2 = rd["CliApellido2"].ToString()
                                },
                                TipoDocumento = rd["TipoDocumento"].ToString(),
                                NumeroFactura = rd["NumeroFactura"].ToString(),
                                MontoPago = Convert.ToDecimal(rd["MontoPago"]),
                                MontoCambio = Convert.ToDecimal(rd["MontoCambio"]),
                                MontoTotal = Convert.ToDecimal(rd["MontoTotal"]),
                                FechaCreacion = rd["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en ObtenerVenta(): " + ex.Message);
                    obj = new Entidad_Venta(); // venta vacia
                }
            }

            return obj;
        }

        // producto de una venta es la consulta 2
        public List<Entidad_DetalleVenta> ObtenerDetalleVenta(int idventa)
        {
            List<Entidad_DetalleVenta> oLista = new List<Entidad_DetalleVenta>();

            try
            {
                using (SqlConnection oconnect = new SqlConnection(Connection.DB))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal");
                    query.AppendLine("FROM DetalleVenta dv");
                    query.AppendLine("INNER JOIN Producto p ON p.IdProducto = dv.IdProducto");
                    query.AppendLine("WHERE dv.IdVenta = @idventa");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconnect);
                    cmd.Parameters.AddWithValue("@idventa", idventa);
                    cmd.CommandType = CommandType.Text;

                    oconnect.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            oLista.Add(new Entidad_DetalleVenta()
                            {
                                Producto = new Entidad_Producto() { Nombre = rd["Nombre"].ToString() },
                                PrecioVenta = Convert.ToDecimal(rd["PrecioVenta"]),
                                Cantidad = Convert.ToInt32(rd["Cantidad"]),
                                Subtotal = Convert.ToDecimal(rd["SubTotal"])
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                oLista = new List<Entidad_DetalleVenta>();
            }

            return oLista;
        }
    }
}