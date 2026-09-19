using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace Data
{
    // Clase de acceso a datos (NO es un Form). El Form solo debe llamar a estos métodos.
    // Requiere que Entidad_Cliente tenga: IdCliente (int), DNI, Nombre1, Nombre2,
    // Apellido1, Apellido2, Correo, Telefono (string) y Estado (bool).
    public class CD_Cliente
    {
        // LISTAR CLIENTES
        public List<Entidad_Cliente> Lister()
        {
            List<Entidad_Cliente> Lista = new List<Entidad_Cliente>();

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    string query = "select IdCliente, DNI, Nombre1, Nombre2, Apellido1, Apellido2, " +
                                   "Correo, Telefono, Estado from Cliente";

                    SqlCommand cm = new SqlCommand(query, oconnect);
                    cm.CommandType = CommandType.Text;

                    oconnect.Open();

                    using (SqlDataReader rd = cm.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Lista.Add(new Entidad_Cliente()
                            {
                                IdCliente = Convert.ToInt32(rd["IdCliente"]),
                                DNI = rd["DNI"].ToString(),
                                Nombre1 = rd["Nombre1"].ToString(),
                                Nombre2 = rd["Nombre2"].ToString(),
                                Apellido1 = rd["Apellido1"].ToString(),
                                Apellido2 = rd["Apellido2"].ToString(),
                                Correo = rd["Correo"].ToString(),
                                Telefono = rd["Telefono"].ToString(),
                                Estado = rd["Estado"] != DBNull.Value && Convert.ToBoolean(rd["Estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error en Lister(): " + ex.Message);
                    Lista = new List<Entidad_Cliente>();
                }
            }

            return Lista;
        }

        // REGISTRAR CLIENTE -> sp_RegistrarCliente
        // Devuelve el Id generado (0 si falló o el DNI ya existe)
        public int RegisterUser(Entidad_Cliente oCliente, out string Message)
        {
            Message = string.Empty;
            int resultId = 0;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_RegistrarCliente", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@DNI", oCliente.DNI ?? string.Empty);
                    cm.Parameters.AddWithValue("@Nombre1", oCliente.Nombre1 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Nombre2", oCliente.Nombre2 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Apellido1", oCliente.Apellido1 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Apellido2", oCliente.Apellido2 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Correo", oCliente.Correo ?? string.Empty);
                    cm.Parameters.AddWithValue("@Telefono", oCliente.Telefono ?? string.Empty);
                    cm.Parameters.AddWithValue("@Estado", oCliente.Estado);

                    SqlParameter pResultado = cm.Parameters.Add("@Resultado", SqlDbType.Int);
                    pResultado.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100);
                    pMensaje.Direction = ParameterDirection.Output;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    resultId = pResultado.Value == DBNull.Value ? 0 : Convert.ToInt32(pResultado.Value);
                    Message = pMensaje.Value == DBNull.Value ? string.Empty : pMensaje.Value.ToString();
                }
                catch (Exception ex)
                {
                    resultId = 0;
                    Message = ex.Message;
                }
            }

            return resultId;
        }

        // MODIFICAR CLIENTE -> sp_ModificarCliente
        // Devuelve true si se actualizó. Si no existe, el DNI está repetido
        // o no hubo cambios, devuelve false y el motivo queda en Message.
        public bool UpdateUser(Entidad_Cliente oCliente, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_ModificarCliente", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@IdCliente", oCliente.IdCliente);
                    cm.Parameters.AddWithValue("@DNI", oCliente.DNI ?? string.Empty);
                    cm.Parameters.AddWithValue("@Nombre1", oCliente.Nombre1 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Nombre2", oCliente.Nombre2 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Apellido1", oCliente.Apellido1 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Apellido2", oCliente.Apellido2 ?? string.Empty);
                    cm.Parameters.AddWithValue("@Correo", oCliente.Correo ?? string.Empty);
                    cm.Parameters.AddWithValue("@Telefono", oCliente.Telefono ?? string.Empty);
                    cm.Parameters.AddWithValue("@Estado", oCliente.Estado);

                    // En SQL @Resultado es int, así que aquí también debe ser Int
                    SqlParameter pResultado = cm.Parameters.Add("@Resultado", SqlDbType.Int);
                    pResultado.Direction = ParameterDirection.Output;

                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 100);
                    pMensaje.Direction = ParameterDirection.Output;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    result = pResultado.Value != DBNull.Value && Convert.ToInt32(pResultado.Value) == 1;
                    Message = pMensaje.Value == DBNull.Value ? string.Empty : pMensaje.Value.ToString();
                }
                catch (Exception ex)
                {
                    result = false;
                    Message = ex.Message;
                }
            }

            return result;
        }

        // ELIMINAR CLIENTE -> sp_EliminarCliente
        // Devuelve true si se eliminó. Si no existe o tiene ventas, devuelve false
        // y el motivo queda en Message.
        public bool DeleteUser(Entidad_Cliente oCliente, out string Message)
        {
            Message = string.Empty;
            bool result = false;

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    SqlCommand cm = new SqlCommand("sp_EliminarCliente", oconnect);
                    cm.CommandType = CommandType.StoredProcedure;

                    cm.Parameters.AddWithValue("@IdCliente", oCliente.IdCliente);

                    SqlParameter pResultado = cm.Parameters.Add("@Resultado", SqlDbType.Int);
                    pResultado.Direction = ParameterDirection.Output;

                    // En SQL este mensaje es varchar(500)
                    SqlParameter pMensaje = cm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500);
                    pMensaje.Direction = ParameterDirection.Output;

                    oconnect.Open();
                    cm.ExecuteNonQuery();

                    result = pResultado.Value != DBNull.Value && Convert.ToInt32(pResultado.Value) == 1;
                    Message = pMensaje.Value == DBNull.Value ? string.Empty : pMensaje.Value.ToString();
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
