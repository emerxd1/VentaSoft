using Data;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Store
{
    public class S_Clients
    {
        private CD_Cliente d_Client = new CD_Cliente();

        // Solo letras (incluye tildes y ñ) y espacios
        private static readonly Regex RegexSoloLetras = new Regex(@"^[a-zA-ZÁÉÍÓÚáéíóúÑñ\s]+$");

        // Cédula nicaragüense: 3 dígitos - 6 dígitos - 4 dígitos + 1 letra
        // Ej: 008-021194-5592M
        private static readonly Regex RegexDni = new Regex(@"^\d{3}-\d{6}-\d{4}[A-Za-z]$");

        // Formato de correo básico
        private static readonly Regex RegexCorreo = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        // Teléfono: +505 seguido de 8 dígitos (Nicaragua), o solo 8 dígitos
        private static readonly Regex RegexTelefono = new Regex(@"^(\+505)?\d{8}$");

        public List<Entidad_Cliente> Lister()
        {
            return d_Client.Lister();
        }

        public int Register(Entidad_Cliente oCliente, out string Mensaje)
        {
            if (!Validar(oCliente, out Mensaje))
                return 0;

            return d_Client.RegisterUser(oCliente, out Mensaje);
        }

        public bool Edit(Entidad_Cliente oCliente, out string Mensaje)
        {
            if (!Validar(oCliente, out Mensaje))
                return false;

            return d_Client.UpdateUser(oCliente, out Mensaje);
        }

        public bool Delete(Entidad_Cliente oCliente, out string Mensaje)
        {
            return d_Client.DeleteUser(oCliente, out Mensaje);
        }

        private bool Validar(Entidad_Cliente oCliente, out string Mensaje)
        {
            Mensaje = string.Empty;
            string errores = string.Empty;

            if (oCliente == null)
            {
                Mensaje = "No se recibió información del usuario.";
                return false;
            }

            // ---- DNI ----
            if (string.IsNullOrWhiteSpace(oCliente.DNI))
                errores += "El DNI es obligatorio.\n";
            else if (!RegexDni.IsMatch(oCliente.DNI.Trim()))
                errores += "El DNI debe tener el formato 000-000000-0000L (ej: 008-021194-5592M).\n";

            // ---- Nombre1 (obligatorio) ----
            if (string.IsNullOrWhiteSpace(oCliente.Nombre1))
                errores += "El Primer Nombre es obligatorio.\n";
            else if (!RegexSoloLetras.IsMatch(oCliente.Nombre1.Trim()))
                errores += "El Primer Nombre solo debe contener letras.\n";

            // ---- Nombre2 (opcional, pero si viene, se valida formato) ----
            if (!string.IsNullOrWhiteSpace(oCliente.Nombre2) && !RegexSoloLetras.IsMatch(oCliente.Nombre2.Trim()))
                errores += "El Segundo Nombre solo debe contener letras.\n";

            // ---- Apellido1 (obligatorio) ----
            if (string.IsNullOrWhiteSpace(oCliente.Apellido1))
                errores += "El Primer Apellido es obligatorio.\n";
            else if (!RegexSoloLetras.IsMatch(oCliente.Apellido1.Trim()))
                errores += "El Primer Apellido solo debe contener letras.\n";

            // ---- Apellido2 (opcional, pero si viene, se valida formato) ----
            if (!string.IsNullOrWhiteSpace(oCliente.Apellido2) && !RegexSoloLetras.IsMatch(oCliente.Apellido2.Trim()))
                errores += "El Segundo Apellido solo debe contener letras.\n";

            // ---- Correo ----
            if (string.IsNullOrWhiteSpace(oCliente.Correo))
                errores += "El Correo es obligatorio.\n";
            else if (!RegexCorreo.IsMatch(oCliente.Correo.Trim()))
                errores += "El Correo no tiene un formato válido.\n";

            // ---- Teléfono ----
            if (string.IsNullOrWhiteSpace(oCliente.Telefono))
                errores += "El Teléfono es obligatorio.\n";
            else if (!RegexTelefono.IsMatch(oCliente.Telefono.Trim()))
                errores += "El Teléfono debe tener el formato +50555001205 u 8 dígitos.\n";


            if (!string.IsNullOrEmpty(errores))
            {
                Mensaje = "Se encontraron los siguientes errores:\n" + errores;
                return false;
            }

            return true;
        }
    }
}