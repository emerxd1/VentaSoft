using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class D_Proveedor
    {
        // LISTAR PROVEEDORES
        public List<Entidad_Proveedor> Lister()
        {
            List<Entidad_Proveedor> Lista = new List<Entidad_Proveedor>();

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdProveedor,RUC,RazonSocial,Correo,Telefono,Estado from Proveedor");

                    SqlCommand cm = new SqlCommand(query.ToString(), oconnect);
                    cm.CommandType = CommandType.Text;

                    oconnect.Open();

                    using (SqlDataReader rd = cm.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Lista.Add(new Entidad_Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(rd["IdProveedor"]),
                                RUC = rd["RUC"].ToString() ?? "",
                                RazonSocial = rd["RazonSocial"].ToString() ?? "",
                                Correo = rd["Correo"].ToString() ?? "",
                                Telefono = rd["Telefono"].ToString() ?? "",
                                Estado = rd["Estado"] != DBNull.Value && Convert.ToBoolean(rd["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en Lister(): " + ex.Message);
                    Lista = new List<Entidad_Proveedor>();
                }

                return Lista;
            }
        }

        // REGISTRAR PROVEEDOR -> sp_RegistrarProveedores
        public int RegisterUser(Entidad_Proveedor oProveedor, out string Message)
        {
            Message = string.Empty;
            int resultId = 0;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_RegistrarProveedores", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@RUC", oProveedor.RUC);
                    cm.Parameters.AddWithValue("@RazonSocial", oProveedor.RazonSocial);
                    cm.Parameters.AddWithValue("@Correo", oProveedor.Correo);
                    cm.Parameters.AddWithValue("@Telefono", oProveedor.Telefono);
                    cm.Parameters.AddWithValue("@Estado", oProveedor.Estado);

                    SqlParameter pResultado = cm.Parameters.Add("@Resultado", SqlDbType.Int);
                    pResultado.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    resultId = pResultado.Value == DBNull.Value ? 0 : Convert.ToInt32(pResultado.Value);
                    Message = pMensaje.Value == DBNull.Value ? "" : pMensaje.Value.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    resultId = 0;
                    Message = ex.Message;
                }
            }

            return resultId;
        }

        // ACTUALIZAR PROVEEDOR -> sp_ModificarProveedores
        public bool UpdateUser(Entidad_Proveedor oProveedor, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_ModificarProveedores", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@IdProveedor", oProveedor.IdProveedor);
                    cm.Parameters.AddWithValue("@RUC", oProveedor.RUC);
                    cm.Parameters.AddWithValue("@RazonSocial", oProveedor.RazonSocial);
                    cm.Parameters.AddWithValue("@Correo", oProveedor.Correo);
                    cm.Parameters.AddWithValue("@Telefono", oProveedor.Telefono);
                    cm.Parameters.AddWithValue("@Estado", oProveedor.Estado);

                    SqlParameter pResultado = cm.Parameters.Add("@Resultado", SqlDbType.Int);
                    pResultado.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    result = pResultado.Value != DBNull.Value && Convert.ToInt32(pResultado.Value) == 1;
                    Message = pMensaje.Value == DBNull.Value ? "" : pMensaje.Value.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    result = false;
                    Message = ex.Message;
                }
            }

            return result;
        }

        // ELIMINAR PROVEEDOR -> sp_EliminarProveedores
        public bool DeleteUser(Entidad_Proveedor oProveedor, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_EliminarProveedores", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@IdProveedor", oProveedor.IdProveedor);

                    SqlParameter pResultado = cm.Parameters.Add("@Resultado", SqlDbType.Bit);
                    pResultado.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    result = pResultado.Value != DBNull.Value && Convert.ToBoolean(pResultado.Value);
                    Message = pMensaje.Value == DBNull.Value ? "" : pMensaje.Value.ToString() ?? "";
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