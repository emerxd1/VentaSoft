using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using Store;
using ModuloEntidades;
using Data;

namespace Store
{
    public class S_Users
    {
        private D_Users d_Users = new D_Users();

        // Solo letras (incluye tildes y ñ) y espacios
        private static readonly Regex RegexSoloLetras = new Regex(@"^[a-zA-ZÁÉÍÓÚáéíóúÑñ\s]+$");

        // Letras, números y guiones (para DNI)
        private static readonly Regex RegexDni = new Regex(@"^[a-zA-Z0-9\-]+$");

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

            return d_Users.RegisterUser(oUsuario, out Message);
        }

        public bool Edit(Entidad_Usuario oUsuario, out string Message)
        {
            if (!Validar(oUsuario, out Message))
                return false;

            return d_Users.UpdateUser(oUsuario, out Message);
        }



        public bool Delete(Entidad_Usuario oUsuario, out string Message)
        {
            return d_Users.DeleteUser(oUsuario, out Message);
        }

        private bool Validar(Entidad_Usuario oUsuario, out string Message)
        {
            Message = string.Empty;
            string errores = string.Empty;

            if (oUsuario == null)
            {
                Message = "No se recibio información del usuario.";
                return false;
            }

            // ---- DNI ----
            if (string.IsNullOrWhiteSpace(oUsuario.DNI))
                errores += "El DNI es obligatorio.\n";
            else if (!RegexDni.IsMatch(oUsuario.DNI.Trim()))
                errores += "El campo DNI solo debe contener letras, numeros y guiones.\n";

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
                errores += "El  Correo es obligatorio.\n";
            else if (!RegexCorreo.IsMatch(oUsuario.Correo.Trim()))
                errores += "El Correo no tiene un formato valido.\n";

            // ---- Clave ----
            if (string.IsNullOrWhiteSpace(oUsuario.Clave))
                errores += "La Clave es obligatorio.\n";

            if (!string.IsNullOrEmpty(errores))
            {
                Message = "Se encontraron los siguientes errores:\n" + errores;
                return false;
            }

            return true;
        }
    }
}