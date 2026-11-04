using System;
using System.Collections.Generic;
using System.Text;

namespace Entitys
{
    public  class ReporteCompra
    {
        public string FechaRegistro { get; set; }= string.Empty;
        public string TipoDocumento { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public string UsuarioRegistro { get; set; } = string.Empty;
        public string DocumentoProveedor { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public string Categoria { get; set; }= string.Empty;
        public string PrecioCompra { get; set; } = string.Empty;
        public string PrecioVenta { get; set; } = string.Empty;
        public string Cantidad { get; set; } = string.Empty;
        public string SubTotal { get; set; } = string.Empty;


    }
}
