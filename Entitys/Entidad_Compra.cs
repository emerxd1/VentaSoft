using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Compra
    {
        public int IdCompra { get; set; }// Identificador único de la compra
        public Entidad_Usuario? Usuario { get; set; }// Usuario que realizó la compra
        public Entidad_Proveedor? Proveedor { get; set; }// Proveedor de la compra
        public  decimal MontoTotal { get; set; }// Total de la compra
        public string TipoDocumento { get; set; } = string.Empty;// Tipo de documento
        public string NumeroDocumento { get; set; } = string.Empty;// nmr. del documento
        public List<Entidad_DetalleCompra> DetalleCompra { get; set; } = new List<Entidad_DetalleCompra>();// Lista de detalles de la compra
        public string FechaCreacion { get; set; } = string.Empty;// Fecha de creación de la compra
    }
}
