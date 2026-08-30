using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Data;

namespace Data
{
    public class D_Permisos
    {
        public List<Entidad_Permiso> Lister(int IdUsuario)
        {
            List<Entidad_Permiso> Lista = new List<Entidad_Permiso>();//Lista de tipo Entidad_Usuario para almacenar los datos de la tabla Usuario

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {

                try
                {
                    StringBuilder queryPermisos = new StringBuilder();
                    queryPermisos.AppendLine("select p.IdRol, p.NombreMenu from Permiso p");
                    queryPermisos.AppendLine(" inner join Rol r ON r.IdRol = p.IdRol");
                    queryPermisos.AppendLine("inner join Usuario u on u.IdRol = r.IdRol");
                    queryPermisos.AppendLine("where u.IdUsuario= @IdUsuario");



                    string query = "select IdUsuario,DNI,Nombre1,Nombre2,Correo,Clave,Estado from Usuario ";

                    SqlCommand cm = new SqlCommand(queryPermisos.ToString(), oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                    cm.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                    cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cm.ExecuteReader())
                    {

                        while (rd.Read())
                        {
                            Lista.Add(new Entidad_Permiso()
                            {

                                oRol = new Entidad_Rol() { IdRol = Convert.ToInt32(rd["IdRol"]) },
                                NombreMenu = rd["NombreMenu"].ToString(),
                               




                            });//Agregamos los datos de la tabla Permiso a la lista


                        }



                    }



                }
                catch (Exception)
                {

                    Lista = new List<Entidad_Permiso>();//Si ocurre un error, se devuelve una lista vacía

                }

                return Lista;//Devolvemos la lista de tipo Entidad_Permiso con los datos de la tabla Permiso



            }
        }
    }
}
