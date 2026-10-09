using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Proveedor
    {
        public int IdProveedor { get; set; }                      // Identificador único del proveedor (autogenerado por SQL con IDENTITY)

        public string RUC { get; set; } = string.Empty;           // Documento de identidad del proveedor
                                                                  // <-- ESTA ERA LA PROPIEDAD QUE FALTABA.
                                                                  // Sin ella, D_Proveedor.cs daba los 3 errores (líneas 36, 68 y 110)

        public string RazonSocial { get; set; } = string.Empty;   // Razón social del proveedor

        public string Correo { get; set; } = string.Empty;        // Correo electrónico (opcional; vacío se guarda como NULL en SQL)

        public string Telefono { get; set; } = string.Empty;      // Número de teléfono del proveedor

        public bool Estado { get; set; }                          // Estado del proveedor (true = activo, false = inactivo)

        public string FechaCreacion { get; set; } = string.Empty; // Fecha de creación (la genera SQL con GETDATE(); solo se lee, no se envía)
    }
}