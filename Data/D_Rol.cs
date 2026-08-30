using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class D_Rol
    {

            public List<Entidad_Rol> Lister()
            {
                List<Entidad_Rol> Lista = new List<Entidad_Rol>();

                using (SqlConnection oconnect = new SqlConnection(Connection.DB))
                {
                    try
                    {
                        StringBuilder queryPermisos = new StringBuilder();
                        queryPermisos.AppendLine("select IdRol, Descripcion from Rol p");

                        SqlCommand cm = new SqlCommand(queryPermisos.ToString(), oconnect);
                        cm.CommandType = CommandType.Text;

                        oconnect.Open();

                        using (SqlDataReader rd = cm.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                Lista.Add(new Entidad_Rol()
                                {
                                    IdRol = Convert.ToInt32(rd["IdRol"]),
                                    Descripcion = rd["Descripcion"].ToString()
                                });
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Lista = new List<Entidad_Rol>();
                    }

                    return Lista;


                }
            }
        }
    }

