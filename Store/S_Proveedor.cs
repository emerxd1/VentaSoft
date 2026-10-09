using Data;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Store
{
    public class S_Proveedor
    {
        // Capa de datos que hace el trabajo contra SQL Server
        private D_Proveedor d_Proveedor = new D_Proveedor();

        // RUC: letras, números y guiones
        private static readonly Regex RegexRUC = new Regex(@"^[a-zA-Z0-9\-]+$");

        // Teléfono: números, espacios, guiones, paréntesis y + (ej: 8888-8888, +505 8888 8888)
        private static readonly Regex RegexTelefono = new Regex(@"^[0-9\s\-\+\(\)]+$");

        // Formato de correo básico
        private static readonly Regex RegexCorreo = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        // LISTAR: antes devolvía List<Entidad_Usuario>, ahora List<Entidad_Proveedor>
        public List<Entidad_Proveedor> Lister()
        {
            return d_Proveedor.Lister();
        }

        // REGISTRAR: valida y luego llama a D_Proveedor.RegisterUser
        public int Register(Entidad_Proveedor oProveedor, out string Message)
        {
            if (!Validar(oProveedor, out Message))
                return 0;

            return d_Proveedor.RegisterUser(oProveedor, out Message);
        }

        // EDITAR: valida y luego llama a D_Proveedor.UpdateUser
        public bool Edit(Entidad_Proveedor oProveedor, out string Message)
        {
            if (!Validar(oProveedor, out Message))
                return false;

            return d_Proveedor.UpdateUser(oProveedor, out Message);
        }

        // ELIMINAR: no necesita validar campos, solo el Id.
        // Las reglas (existe / tiene compras) las valida el procedimiento en SQL.
        public bool Delete(Entidad_Proveedor oProveedor, out string Message)
        {
            return d_Proveedor.DeleteUser(oProveedor, out Message);
        }

        // VALIDACIONES antes de llegar a la base de datos
        private bool Validar(Entidad_Proveedor oProveedor, out string Message)
        {
            Message = string.Empty;
            string errores = string.Empty;

            if (oProveedor == null)
            {
                Message = "No se recibió información del proveedor.";
                return false;
            }

            // ---- RUC (obligatorio, máx. 50 según la columna) ----
            if (string.IsNullOrWhiteSpace(oProveedor.RUC))
                errores += "El RUC es obligatorio.\n";
            else if (!RegexRUC.IsMatch(oProveedor.RUC.Trim()))
                errores += "El campo RUC solo debe contener letras, números y guiones.\n";
            else if (oProveedor.RUC.Trim().Length > 50)
                errores += "El RUC no puede superar los 50 caracteres.\n";

            // ---- Razón Social (obligatoria, máx. 100) ----
            // No se limita a letras: una razón social puede llevar números, puntos, "&", etc.
            if (string.IsNullOrWhiteSpace(oProveedor.RazonSocial))
                errores += "La Razón Social es obligatoria.\n";
            else if (oProveedor.RazonSocial.Trim().Length > 100)
                errores += "La Razón Social no puede superar los 100 caracteres.\n";

            // ---- Teléfono (obligatorio en la tabla: NOT NULL, máx. 20) ----
            if (string.IsNullOrWhiteSpace(oProveedor.Telefono))
                errores += "El Teléfono es obligatorio.\n";
            else if (!RegexTelefono.IsMatch(oProveedor.Telefono.Trim()))
                errores += "El Teléfono solo debe contener números, espacios, guiones, paréntesis o +.\n";
            else if (oProveedor.Telefono.Trim().Length > 20)
                errores += "El Teléfono no puede superar los 20 caracteres.\n";

            // ---- Correo (OPCIONAL en la tabla: NULL; si viene, se valida formato) ----
            if (!string.IsNullOrWhiteSpace(oProveedor.Correo))
            {
                if (!RegexCorreo.IsMatch(oProveedor.Correo.Trim()))
                    errores += "El Correo no tiene un formato válido.\n";
                else if (oProveedor.Correo.Trim().Length > 100)
                    errores += "El Correo no puede superar los 100 caracteres.\n";
            }

            if (!string.IsNullOrEmpty(errores))
            {
                Message = "Se encontraron los siguientes errores:\n" + errores;
                return false;
            }

            return true;
        }
    }
}