using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_DetalleVenta
    {
        public int IdDetalleVenta { get; set; }// Identificador único del detalle de venta
        public Entidad_Producto Producto { get; set; }// Producto asociado al detalle de venta
        public decimal PrecioVenta { get; set; }// Precio de venta del producto en el detalle de venta
        public int Cantidad { get; set; }// Cantidad del producto en el detalle de venta

        public decimal Subtotal { get; set; }// Subtotal del detalle de venta (PrecioVenta * Cantidad)
        public Entidad_Factura NumeroFactura { get; set; }// numero de factura asociado al detalle de venta

        public string FechaCreacion { get; set; }// Fecha de creación del detalle de venta
    }
}
