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

            using (SqlConnection oconnect = new SqlConnection(Connection.DB)) {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUsuario,u.DNI,u.Nombre1,u.Nombre2,u.Apellido1,u.Apellido2,u.Correo,u.Clave,u.Estado, r.IdRol,r.Descripcion from Usuario u");
                    query.AppendLine("inner join Rol r on r.IdRol = u.IdRol");

                    
                    SqlCommand cm = new SqlCommand(query.ToString(), oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                    cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cm.ExecuteReader()) {

                        while (rd.Read()) {
                            Lista.Add(new Entidad_Usuario() {

                                IdUsuario = Convert.ToInt32(rd["IdUsuario"]),
                                DNI = rd["DNI"].ToString(),
                                Nombre1 = rd["Nombre1"].ToString(),
                                Nombre2 = rd["Nombre2"].ToString(),
                                Apellido1 = rd["Apellido1"].ToString(),
                                Apellido2 = rd["Apellido2"].ToString(),
                                Correo = rd["Correo"].ToString(),
                                Clave = rd["Clave"].ToString(),
                                Estado = Convert.ToBoolean(rd["Estado"]),
                                oRol = new Entidad_Rol() { IdRol = Convert.ToInt32(rd["IdRol"]), Descripcion = rd["Descripcion"].ToString() }




                            });//Agregamos los datos de la tabla Usuario a la lista de tipo Entidad_Usuario


                        }
                    
                    
                    
                    }



                }
                catch (Exception ) {

                    Lista = new List<Entidad_Usuario>();//Si ocurre un error, se devuelve una lista vacía

                }

               return Lista;//Devolvemos la lista de tipo Entidad_Usuario con los datos de la tabla Usuario



            }
        }

    }
}
