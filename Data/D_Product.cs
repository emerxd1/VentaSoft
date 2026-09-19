using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class D_Product
    {
        public List<Entidad_Producto> Lister()
        {
            List<Entidad_Producto> Lista = new List<Entidad_Producto>();//Lista de tipo Entidad_Producto para almacenar los datos de la tabla Producto

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProducto, Codigo, p.Nombre, p.Descripcion, c.Idcategoria, c.Nombre[Categoria], Stock,");
                    query.AppendLine("PrecioCompra,PrecioVenta,p.Estado FROM Producto p");
                    query.AppendLine("INNER JOIN Categoria c on c.IdCategoria = p.IdCategoria");


                    SqlCommand cm = new SqlCommand(query.ToString(), oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                    cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cm.ExecuteReader())
                    {

                        while (rd.Read())
                        {
                            Lista.Add(new Entidad_Producto()
                            {

                                IdProducto = Convert.ToInt32(rd["IdProducto"]),
                                Codigo = rd["Codigo"].ToString(),
                                Nombre = rd["Nombre"].ToString(),
                                Descripcion = rd["Descripcion"].ToString(),
                                oCategoria = new Entidad_Categoria()
                                {
                                    IdCategoria = Convert.ToInt32(rd["IdCategoria"]),
                                    Nombre = rd["Categoria"].ToString()
                                },
                                Stock = Convert.ToInt32(rd["Stock"]),
                                PrecioCompra = Convert.ToDecimal(rd["PrecioCompra"]),
                                PrecioVenta = Convert.ToDecimal(rd["PrecioVenta"]),
                                // Protección contra DBNull: si Estado es NULL en la BD, se asume false
                                Estado = rd["Estado"] == DBNull.Value ? false : Convert.ToBoolean(rd["Estado"])

                            });//Agregamos los datos de la tabla producto a la lista de tipo Entidad_Producto

                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Entidad_Producto>();
                    System.Diagnostics.Debug.WriteLine("Error en Lister: " + ex.Message);
                    // o incluso: throw; (mientras depurás, para verlo con el debugger)
                }


            }

                return Lista;//Devolvemos la lista de tipo Entidad_Usuario con los datos de la tabla Usuario

            }
        
        //METODO PARA REGISTRAR USUARIOS EN LA BASE DE DATOS//
        public int RegisterProduct(Entidad_Producto oProducto, out string Message)
        {

            Message = string.Empty;
            int resultId = 0;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {

                    SqlCommand cm = new SqlCommand("SP_REGISTERPRODUCT", oconnect);

                    //Agregamos los parametros a la consulta SQL para evitar inyecciones SQL

                    cm.Parameters.AddWithValue("Nombre", oProducto.Nombre);
                    cm.Parameters.AddWithValue("Descripcion", oProducto.Descripcion);
                    cm.Parameters.AddWithValue("PrecioCompra", oProducto.PrecioCompra);
                    cm.Parameters.AddWithValue("PrecioVenta", oProducto.PrecioVenta);
                    cm.Parameters.AddWithValue("Stock", oProducto.Stock);
                    cm.Parameters.AddWithValue("Estado", oProducto.Estado);
                    cm.Parameters.AddWithValue("Idcategoria", oProducto.oCategoria.IdCategoria);
                    cm.Parameters.Add("@IdResult", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    resultId = Convert.ToInt32(cm.Parameters["@IdResult"].Value);
                    Message = cm.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    resultId = 0;
                    Message = ex.Message;
                }
            }

            return resultId;
        }


        //METODO PARA ACTUALIZAR UN USUARIO//

        public bool UpdateProduct(Entidad_Producto oProducto, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("SP_UPDATEPRODUCT", oconnect);

                    cm.Parameters.AddWithValue("@IdProducto", oProducto.IdProducto);
                    cm.Parameters.AddWithValue("@Nombre", oProducto.Nombre);
                    cm.Parameters.AddWithValue("@Descripcion", oProducto.Descripcion);
                    cm.Parameters.AddWithValue("@IdCategoria", oProducto.oCategoria.IdCategoria);
                    cm.Parameters.AddWithValue("@Estado", oProducto.Estado);
                    cm.Parameters.AddWithValue("@Stock", oProducto.Stock);
                    cm.Parameters.AddWithValue("@PrecioCompra", oProducto.PrecioCompra);
                    cm.Parameters.AddWithValue("@PrecioVenta", oProducto.PrecioVenta);

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    Message = pMensaje.Value == DBNull.Value ? "" : pMensaje.Value.ToString();

                    // El SP no devuelve un booleano/id de éxito, solo el mensaje.
                    // Se considera éxito únicamente cuando el mensaje coincide con el de actualización correcta.
                    result = Message == "Producto actualizado correctamente";
                }
                catch (Exception ex)
                {
                    result = false;
                    Message = ex.Message;
                }
            }

            return result;
        }
        //METODO PARA ELIMINAR UN USUARIO//

        public bool DeleteProduct(Entidad_Producto oProducto, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("SP_DELETEPRODUCT", oconnect);

                    //Agregamos los parametros a la consulta SQL para evitar inyecciones SQL

                    cm.Parameters.AddWithValue("@IdProducto", oProducto.IdProducto);

                    SqlParameter pRespuesta = cm.Parameters.Add("@Respuesta", SqlDbType.Bit);
                    pRespuesta.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;//Tipo de comando a ejecutar

                    oconnect.Open();//abre la conexion

                    cm.ExecuteNonQuery();

                    result = pRespuesta.Value != DBNull.Value && Convert.ToBoolean(pRespuesta.Value);
                    Message = pMensaje.Value == DBNull.Value ? "" : pMensaje.Value.ToString();
                }
                catch (Exception ex)
                {
                    result = false;
                    Message = ex.Message;
                }
            }

            return result;
        }


    }
}

