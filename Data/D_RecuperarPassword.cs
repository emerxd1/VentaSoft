using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;

namespace Data
{
    public class D_RecuperarPassword
    {
        private SmtpClient? smtpClient;

        protected string remitenteCorreo { get; set; } = string.Empty;
        protected string password { get; set; } = string.Empty;
        protected string host { get; set; } = string.Empty;
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void InicializarSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
            smtpClient.Credentials = new System.Net.NetworkCredential(remitenteCorreo, password);
        }

        public SmtpClient? GetSmtpClient1()
        {
            return smtpClient;
        }

        public void sentEmail(string subject, string cuerpo, List<string> destinatarios, SmtpClient? smtpClient)
        {
            var mail = new MailMessage();
            try
            {
                mail.From = new MailAddress(remitenteCorreo, "Soporte VentaSoft");
                foreach (var destinatario in destinatarios)
                {
                    mail.To.Add(destinatario);
                }
                mail.Subject = subject;
                mail.Body = cuerpo;
                mail.Priority = MailPriority.Normal;
                smtpClient?.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al enviar el correo: " + ex.Message);
            }
            finally
            {
                mail.Dispose();
            }
        }

        public virtual string recoverPassword(string solicitudUser)
        {
            string connectionString = "Data Source=DESKTOP-DAOVEMQ;Initial Catalog=SistemaVentas;Integrated Security=True;Multiple Active Result Sets=True;Trust Server Certificate=True";

            using (var connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();

                    string query = "SELECT Correo, Clave, Nombre1 FROM Usuario WHERE Correo = @busqueda OR DNI = @busqueda";

                    using (SqlCommand cm = new SqlCommand(query, connect))
                    {
                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@busqueda", solicitudUser);

                        using (SqlDataReader reader = cm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string correoDestino = reader["Correo"].ToString();
                                string claveUsuario = reader["Clave"].ToString();
                                string nombreUsuario = reader["Nombre1"].ToString();

                                string asunto = "Recuperación de Contraseña - VentaSoft (Pulpería Oasis de Bendición)";
                                string cuerpo = $"Hola {nombreUsuario},\n\nHas solicitado recuperar tu contraseña.\nTu clave de acceso es: {claveUsuario}\n\nPor favor,Si desea pidele a tu administrador cambiar tu contraseña después de iniciar sesión.";

                                InicializarSmtpClient();
                                sentEmail(asunto, cuerpo, new List<string> { correoDestino }, GetSmtpClient1());

                                return "Correo de recuperación enviado exitosamente a " + correoDestino;
                            }
                            else
                            {
                                return "No se encontró ningún usuario registrado con ese dato.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Error al procesar la recuperación: " + ex.Message;
                }
            }
        }
    }
}