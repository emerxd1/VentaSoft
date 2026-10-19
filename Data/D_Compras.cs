using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class D_Compras
    {

        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");
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

        public bool Registrar(Entidad_Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Repuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_RegistrarCompra", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@IdUsuario", obj.Usuario.IdUsuario);
                    cm.Parameters.AddWithValue("@IdProveedor", obj.Proveedor.IdProveedor);
                    cm.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cm.Parameters.AddWithValue("@NumeroDocumento", obj.NumeroDocumento);
                    cm.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);

                    SqlParameter pDetalle = cm.Parameters.Add("@DetalleCompra", SqlDbType.Structured);
                    pDetalle.TypeName = "dbo.EDetalle_Compra";
                    pDetalle.Value = DetalleCompra;

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

        public Entidad_Compra ObtenerCompra(string numero)
        {
            Entidad_Compra obj = new Entidad_Compra();

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {

                try
                {
                    // el query se arma PRIMERO y es una variable local
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.IdCompra,");
                    query.AppendLine("u.Nombre1,u.Nombre2,u.Apellido1,u.Apellido2,");
                    query.AppendLine("pr.RUC,pr.RazonSocial,");
                    query.AppendLine("c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,convert(char(10), c.FechaRegistro, 103) AS FechaRegistro");
                    query.AppendLine("FROM Compra c");
                    query.AppendLine("inner join Usuario u on u.IdUsuario = c.IdUsuario");
                    query.AppendLine("inner join Proveedor pr on pr.IdProveedor = c.IdProveedor");
                    query.AppendLine("where c.NumeroDocumento = @numero");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconnect);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {

                        while (rd.Read())
                        {

                            
                            obj = new Entidad_Compra()
                            {
                                IdCompra = Convert.ToInt32(rd["IdCompra"]),
                                Usuario = new Entidad_Usuario()
                                {
                                    Nombre1 = rd["Nombre1"].ToString(),
                                    Nombre2 = rd["Nombre2"].ToString(),
                                    Apellido1 = rd["Apellido1"].ToString(),
                                    Apellido2 = rd["Apellido2"].ToString()
                                },
                                Proveedor = new Entidad_Proveedor()
                                {
                                    RUC = rd["RUC"].ToString(),
                                    RazonSocial = rd["RazonSocial"].ToString()
                                },
                                TipoDocumento = rd["TipoDocumento"].ToString(),
                                NumeroDocumento = rd["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(rd["MontoTotal"]),
                                FechaCreacion = rd["FechaRegistro"].ToString()
                            };


                        }



                    }


                }
                catch (Exception ex)
                {
                    // muestra el error real en vez de ocultarlo, para poder diagnosticar
                    System.Windows.Forms.MessageBox.Show("Error en ObtenerCompra(): " + ex.Message);

                    obj = new Entidad_Compra();//Si ocurre un error devuelve una compra vacia

                }

                return obj;
            }
        }

        public List<Entidad_DetalleCompra> ObtenerDetalleCompra(int idcompra)
        {
            List<Entidad_DetalleCompra> oLista = new List<Entidad_DetalleCompra>();

            try
            {
                using (SqlConnection oconnect = new SqlConnection(Connection.DB))
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Nombre,dc.PrecioCompra,dc.Cantidad,dc.Total AS MontoTotal from DetalleCompra dc");
                    query.AppendLine("inner join Producto p on p.IdProducto = dc.IdProducto");
                    query.AppendLine("where dc.IdCompra = @idcompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconnect);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = CommandType.Text;

                    oconnect.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            oLista.Add(new Entidad_DetalleCompra()
                            {
                                IdProducto = new Entidad_Producto() { Nombre = rd["Nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(rd["PrecioCompra"]),
                                Cantidad = Convert.ToInt32(rd["Cantidad"]),
                                MontoTotal = Convert.ToDecimal(rd["MontoTotal"])
                            });
                        }
                    }
                }
            }
            catch (Exception)
            {
                oLista = new List<Entidad_DetalleCompra>();
            }

            return oLista;
        }
    }
}