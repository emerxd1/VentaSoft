using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public  class Entidad_Proveedor
    {
        public int IdProveedor { get; set; }// Identificador único del proveedor
        public string RazonSocial { get; set; }// Razón social del proveedor

        public string Correo { get; set; }// Correo electrónico del proveedor
        public string Telefono { get; set; }// Número de teléfono del proveedor

        public bool Estado { get; set; }// Estado del proveedor (activo/inactivo)   
        public string FechaCreacion { get; set; }// Fecha de creación del proveedor

    }
}
