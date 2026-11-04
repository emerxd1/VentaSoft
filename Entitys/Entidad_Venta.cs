using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Venta

    {
        public int IdVenta { get; set; }// Identificador único de la venta
        public Entidad_Usuario? Usuario { get; set; }// Usuario asociado a la venta

        public Entidad_Cliente? Cliente { get; set; }/// Cliente asociado a la venta

        public string TipoDocumento { get; set; } = string.Empty;// Boleta o Factura (igual que en Entidad_Compra)

        public string NumeroFactura { get; set; } = string.Empty;// Numero de factura de la venta

        public decimal MontoPago { get; set; }// Monto pago de la venta

        public decimal MontoCambio { get; set; }// Monto cambio de la venta
        public decimal MontoTotal { get; set; }// Monto total de la venta
        public List<Entidad_DetalleVenta> DetalleVenta { get; set; } = new List<Entidad_DetalleVenta>();// Lista de detalles de la venta    

        public string FechaCreacion { get; set; } = string.Empty;// Fecha de creación de la venta


    }
}