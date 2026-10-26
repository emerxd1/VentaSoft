using Data;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Store
{
    public class S_Users
    {
        private D_Users d_Users = new D_Users();

        // Solo letras (incluye tildes y ñ) y espacios
        private static readonly Regex RegexSoloLetras = new Regex(@"^[\p{L} ]+$");

        // Cédula nicaragüense: 3 dígitos - 6 dígitos - 4 dígitos + 1 letra (igual que S_Clients)
        // Ej: 008-021194-5592M
        private static readonly Regex RegexDni = new Regex(@"^\d{3}-\d{6}-\d{4}[A-Za-z]$");

        // Formato de correo básico
        private static readonly Regex RegexCorreo = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public List<Entidad_Usuario> Lister()
        {
            return d_Users.Lister();
        }

        public int Register(Entidad_Usuario oUsuario, out string Message)
        {
            if (!Validar(oUsuario, out Message))
                return 0;

            Normalizar(oUsuario);
            return d_Users.RegisterUser(oUsuario, out Message);
        }

        public bool Edit(Entidad_Usuario oUsuario, out string Message)
        {
            if (oUsuario == null || oUsuario.IdUsuario <= 0)
            {
                Message = "Debe seleccionar un usuario válido para actualizar.";
                return false;
            }

            if (!Validar(oUsuario, out Message))
                return false;

            Normalizar(oUsuario);
            return d_Users.UpdateUser(oUsuario, out Message);
        }

        public bool Delete(Entidad_Usuario oUsuario, out string Message)
        {
            if (oUsuario == null || oUsuario.IdUsuario <= 0)
            {
                Message = "Debe seleccionar un usuario válido para eliminar.";
                return false;
            }

            return d_Users.DeleteUser(oUsuario, out Message);
        }

        // Público para que el formulario pueda validar ANTES de registrar o actualizar
        public bool Validar(Entidad_Usuario oUsuario, out string Message)
        {
            Message = string.Empty;
            string errores = string.Empty;

            if (oUsuario == null)
            {
                Message = "No se recibió información del usuario.";
                return false;
            }

            // ---- DNI ----
            if (string.IsNullOrWhiteSpace(oUsuario.DNI))
                errores += "El DNI es obligatorio.\n";
            else if (!RegexDni.IsMatch(oUsuario.DNI.Trim()))
                errores += "El DNI debe tener el formato 000-000000-0000L (ej: 008-021194-5592M).\n";

            // ---- Nombre1 (obligatorio) ----
            if (string.IsNullOrWhiteSpace(oUsuario.Nombre1))
                errores += "El Primer Nombre es obligatorio.\n";
            else if (!RegexSoloLetras.IsMatch(oUsuario.Nombre1.Trim()))
                errores += "El Primer Nombre solo debe contener letras.\n";

            // ---- Nombre2 (opcional, pero si viene, se valida formato) ----
            if (!string.IsNullOrWhiteSpace(oUsuario.Nombre2) && !RegexSoloLetras.IsMatch(oUsuario.Nombre2.Trim()))
                errores += "El Segundo Nombre solo debe contener letras.\n";

            // ---- Apellido1 (obligatorio) ----
            if (string.IsNullOrWhiteSpace(oUsuario.Apellido1))
                errores += "El Primer Apellido es obligatorio.\n";
            else if (!RegexSoloLetras.IsMatch(oUsuario.Apellido1.Trim()))
                errores += "El Primer Apellido solo debe contener letras.\n";

            // ---- Apellido2 (opcional, pero si viene, se valida formato) ----
            if (!string.IsNullOrWhiteSpace(oUsuario.Apellido2) && !RegexSoloLetras.IsMatch(oUsuario.Apellido2.Trim()))
                errores += "El Segundo Apellido solo debe contener letras.\n";

            // ---- Correo ----
            if (string.IsNullOrWhiteSpace(oUsuario.Correo))
                errores += "El Correo es obligatorio.\n";
            else if (!RegexCorreo.IsMatch(oUsuario.Correo.Trim()))
                errores += "El Correo no tiene un formato válido.\n";

            // ---- Clave ----
            if (string.IsNullOrWhiteSpace(oUsuario.Clave))
                errores += "La Clave es obligatoria.\n";

            // ---- Rol ----
            if (oUsuario.oRol == null || oUsuario.oRol.IdRol <= 0)
                errores += "El Rol es obligatorio.\n";

            if (!string.IsNullOrEmpty(errores))
            {
                Message = "Se encontraron los siguientes errores:\n" + errores;
                return false;
            }

            return true;
        }

        // Limpia espacios y unifica mayúsculas/minúsculas antes de guardar.
        // Solo se llama después de que Validar haya pasado. La Clave no se modifica.
        private void Normalizar(Entidad_Usuario u)
        {
            u.DNI = u.DNI.Trim().ToUpper();
            u.Nombre1 = u.Nombre1.Trim();
            u.Nombre2 = u.Nombre2?.Trim() ?? string.Empty;
            u.Apellido1 = u.Apellido1.Trim();
            u.Apellido2 = u.Apellido2?.Trim() ?? string.Empty;
            u.Correo = u.Correo.Trim().ToLower();
        }
    }
}