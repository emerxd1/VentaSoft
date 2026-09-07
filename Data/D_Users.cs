using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using ModuloEntidades;
namespace Data
{
    public class D_Users
    {
        public List<Entidad_Usuario> Lister()
        {
            List<Entidad_Usuario> Lista = new List<Entidad_Usuario>();//Lista de tipo Entidad_Usuario para almacenar los datos de la tabla Usuario

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUsuario,u.DNI,u.Nombre1,u.Nombre2,u.Apellido1,u.Apellido2,u.Correo,u.Clave,u.Estado, r.IdRol,r.Descripcion from Usuario u");
                    query.AppendLine("inner join Rol r on r.IdRol = u.IdRol");


                    SqlCommand cm = new SqlCommand(query.ToString(), oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                    cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cm.ExecuteReader())
                    {

                        while (rd.Read())
                        {
                            Lista.Add(new Entidad_Usuario()
                            {

                                IdUsuario = Convert.ToInt32(rd["IdUsuario"]),
                                DNI = rd["DNI"].ToString(),
                                Nombre1 = rd["Nombre1"].ToString(),
                                Nombre2 = rd["Nombre2"].ToString(),
                                Apellido1 = rd["Apellido1"].ToString(),
                                Apellido2 = rd["Apellido2"].ToString(),
                                Correo = rd["Correo"].ToString(),
                                Clave = rd["Clave"].ToString(),
                                // Protección contra DBNull: si Estado es NULL en la BD, se asume false
                                Estado = rd["Estado"] == DBNull.Value ? false : Convert.ToBoolean(rd["Estado"]),
                                oRol = new Entidad_Rol()
                                {
                                    // Protección contra DBNull en IdRol y Descripcion
                                    IdRol = rd["IdRol"] == DBNull.Value ? 0 : Convert.ToInt32(rd["IdRol"]),
                                    Descripcion = rd["Descripcion"] == DBNull.Value ? "" : rd["Descripcion"].ToString()
                                }

                            });//Agregamos los datos de la tabla Usuario a la lista de tipo Entidad_Usuario


                        }



                    }



                }
                catch (Exception ex)
                {
                    // muestra el error real en vez de ocultarlo, para poder diagnosticar
                    System.Windows.Forms.MessageBox.Show("Error en Lister(): " + ex.Message);

                    Lista = new List<Entidad_Usuario>();//Si ocurre un error, se devuelve una lista vacía

                }

                return Lista;//Devolvemos la lista de tipo Entidad_Usuario con los datos de la tabla Usuario



            }
        }


        //METODO PARA REGISTRAR USUARIOS EN LA BASE DE DATOS//
        public int RegisterUser(Entidad_Usuario oUsuario, out string Message)
        {

            Message = string.Empty;
            int resultId = 0;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {

                    SqlCommand cm = new SqlCommand("SP_REGISTERUSER", oconnect);

                    //Agregamos los parametros a la consulta SQL para evitar inyecciones SQL

                    cm.Parameters.AddWithValue("DNI", oUsuario.DNI);
                    cm.Parameters.AddWithValue("Nombre1", oUsuario.Nombre1);//
                    cm.Parameters.AddWithValue("Nombre2", oUsuario.Nombre2);
                    cm.Parameters.AddWithValue("Apellido1", oUsuario.Apellido1);
                    cm.Parameters.AddWithValue("Apellido2", oUsuario.Apellido2);
                    cm.Parameters.AddWithValue("Correo", oUsuario.Correo);
                    cm.Parameters.AddWithValue("Clave", oUsuario.Clave);
                    cm.Parameters.AddWithValue("Estado", oUsuario.Estado);
                    cm.Parameters.AddWithValue("IdRol", oUsuario.oRol.IdRol);
                    cm.Parameters.Add("@IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    resultId = Convert.ToInt32(cm.Parameters["@IdUsuarioResultado"].Value);
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

        public bool UpdateUser(Entidad_Usuario oUsuario, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("SP_EDITUSER", oconnect);

                    cm.Parameters.AddWithValue("@IdUsuario", oUsuario.IdUsuario);
                    cm.Parameters.AddWithValue("@DNI", oUsuario.DNI);
                    cm.Parameters.AddWithValue("@Nombre1", oUsuario.Nombre1);
                    cm.Parameters.AddWithValue("@Nombre2", oUsuario.Nombre2);
                    cm.Parameters.AddWithValue("@Apellido1", oUsuario.Apellido1);
                    cm.Parameters.AddWithValue("@Apellido2", oUsuario.Apellido2);
                    cm.Parameters.AddWithValue("@Correo", oUsuario.Correo);
                    cm.Parameters.AddWithValue("@Clave", oUsuario.Clave);
                    cm.Parameters.AddWithValue("@Estado", oUsuario.Estado);
                    cm.Parameters.AddWithValue("@IdRol", oUsuario.oRol.IdRol);

                    SqlParameter pError = cm.Parameters.Add("@Error", SqlDbType.Bit);
                    pError.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    // Protección extra por si acaso queda DBNull
                    result = pError.Value != DBNull.Value && Convert.ToBoolean(pError.Value);
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


        //METODO PARA ELIMINAR UN USUARIO//

        public bool DeleteUser(Entidad_Usuario oUsuario, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {


                    SqlCommand cm = new SqlCommand("SP_DELETEUSER", oconnect);

                    //Agregamos los parametros a la consulta SQL para evitar inyecciones SQL

                    cm.Parameters.AddWithValue("IdUsuario", oUsuario.IdUsuario);
                    cm.Parameters.Add("Error", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cm.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cm.CommandType = CommandType.StoredProcedure;//Tipo de comando a ejecutar

                    oconnect.Open();//abre la conexion

                    cm.ExecuteNonQuery();

                    result = Convert.ToBoolean(cm.Parameters["Error"].Value);
                    Message = cm.Parameters["Mensaje"].Value.ToString();

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
