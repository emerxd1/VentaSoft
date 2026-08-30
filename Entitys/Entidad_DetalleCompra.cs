using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_DetalleCompra
    {
        public int IdDetalleCompra { get; set; }// Identificador único del detalle de compra
        public Entidad_Producto IdProducto { get; set; }// Producto asociado al detalle de compra
        public decimal PrecioCompra { get; set; }   // Precio de compra del producto
        public decimal PrecioVenta { get; set; }   // Precio de venta del producto
        public int Cantidad { get; set; } // Cantidad de productos comprados
        public decimal MontoTotal { get; set; } // Monto total del detalle de compra (PrecioCompra * Cantidad)
        public string FechaCreacion { get; set; }// Fecha de creación del detalle de compra

    }


}
