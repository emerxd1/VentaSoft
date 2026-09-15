
using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class D_Category
    {
        public List<Entidad_Categoria> Lister()
        {
            List<Entidad_Categoria> Lista = new List<Entidad_Categoria>();//Lista de tipo Entidad_Categoria para almacenar los datos de la tabla Categoria

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCategoria, Nombre, Descripcion, Estado FROM Categoria"); // Agregado IdCategoria
                    SqlCommand cm = new SqlCommand(query.ToString(), oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                    cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cm.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Lista.Add(new Entidad_Categoria()
                            {
                                IdCategoria = Convert.ToInt32(rd["IdCategoria"]),
                                Nombre = (rd["Nombre"]).ToString(),
                                Descripcion = (rd["Descripcion"]).ToString(),
                                Estado = Convert.ToBoolean(rd["Estado"])
                            });//Agregamos los datos de la tabla Categoria a la lista de tipo Entidad_Categoria

                        }



                    }
                }
                catch (Exception)
                {

                    Lista = new List<Entidad_Categoria>();//Si ocurre un error, se devuelve una lista vacía (corregido)

                }
            }


            return Lista;//Devolvemos la lista de tipo Entidad_Categoria con los datos de la tabla Categoria
        }



        //METODO PARA REGISTRAR USUARIOS EN LA BASE DE DATOS//
        public int RegisterCategory(Entidad_Categoria oCategoria, out string Mensaje)
        {

            Mensaje = string.Empty;
            int Resultado = 0;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {

                    SqlCommand cm = new SqlCommand("SP_RegisterCategory", oconnect);

                    //Agregamos los parametros a la consulta SQL para evitar inyecciones SQL

                    cm.Parameters.AddWithValue("Nombre", oCategoria.Nombre);
                    cm.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);
                    cm.Parameters.AddWithValue("Estado", oCategoria.Estado);
                    cm.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    Resultado = Convert.ToInt32(cm.Parameters["@Resultado"].Value);
                    Mensaje = cm.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Resultado = 0;
                    Mensaje = ex.Message;
                }
            }

            return Resultado;
        }



        //METODO PARA ACTUALIZAR UN USUARIO//

        public bool UpdateCategory(Entidad_Categoria oCategoria, out string Mensaje)
        {
            Mensaje = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("SP_UpdateCategory", oconnect);

                    cm.Parameters.AddWithValue("@IdCategoria", oCategoria.IdCategoria);
                    cm.Parameters.AddWithValue("@Nombre", oCategoria.Nombre);
                    cm.Parameters.AddWithValue("@Descripcion", oCategoria.Descripcion);
                    cm.Parameters.AddWithValue("@Estado", oCategoria.Estado);

                    SqlParameter pResultado = cm.Parameters.Add("@Resultado", SqlDbType.Bit);
                    pResultado.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    // Protección extra por si acaso queda DBNull
                    result = pResultado.Value != DBNull.Value && Convert.ToBoolean(pResultado.Value);
                    Mensaje = pMensaje.Value == DBNull.Value ? "" : pMensaje.Value.ToString();
                }
                catch (Exception ex)
                {
                    result = false;
                    Mensaje = ex.Message;
                }
            }

            return result;
        }


        //METODO PARA ELIMINAR UN USUARIO//

        public bool DeleteCategory(Entidad_Categoria oCategoria, out string Mensaje)
        {
            Mensaje = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {


                    SqlCommand cm = new SqlCommand("SP_DeleteCategory", oconnect);

                    //Agregamos los parametros a la consulta SQL para evitar inyecciones SQL

                    cm.Parameters.AddWithValue("IdCategoria", oCategoria.IdCategoria);
                    cm.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cm.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;//Tipo de comando a ejecutar

                    oconnect.Open();//abre la conexion

                    cm.ExecuteNonQuery();

                    result = Convert.ToBoolean(cm.Parameters["Resultado"].Value);
                    Mensaje = cm.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    result = false;
                    Mensaje  = ex.Message;
                }
            }

            return result;
        }
    }
}
