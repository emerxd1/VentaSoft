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
                    string query = "select IdUsuario,DNI,Nombre1,Nombre2,Correo,Clave,Estado from Usuario ";
                    
                    SqlCommand cm = new SqlCommand(query, oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                    cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cm.ExecuteReader()) {

                        while (rd.Read()) {
                            Lista.Add(new Entidad_Usuario() { 

                                IdUsuario = Convert.ToInt32(rd["IdUsuario"]),
                                DNI= rd["DNI"].ToString(),
                                Nombre1 = rd["Nombre1"].ToString(),
                                Nombre2= rd["Nombre2"].ToString(),
                                Correo= rd["Correo"].ToString(),
                                Clave = rd["Clave"].ToString(),
                                Estado= Convert.ToBoolean(rd["Estado"])

                                

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
