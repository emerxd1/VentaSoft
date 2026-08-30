using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Compra
    {
        public int IdCompra { get; set; }// Identificador único de la compra
        public Entidad_Usuario Usuario { get; set; }// Usuario que realizó la compra
        public Entidad_Proveedor Proveedor { get; set; }// Proveedor de la compra
        public Entidad_Factura NumeroFactura { get; set; }// Número de factura de la compra  
        public  decimal MontoTotal { get; set; }// Total de la compra
        public List<Entidad_DetalleCompra> DetalleCompra { get; set; }// Lista de detalles de la compra
        public string FechaCreacion { get; set; }// Fecha de creación de la compra
    }
}
