using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public  class Entidad_Factura
    {
        public int IdFactura { get; set; }// Identificador único de la factura

        public string NumeroFactura { get; set; }// Número de factura

        public Entidad_Cliente Cliente { get; set; }// Cliente asociado a la factura
        public Entidad_Usuario Usuario { get; set; }// Usuario asociado a la factura

        public string FechaCreacion { get; set; }// Fecha de creación de la factura

        public decimal Subtotal { get; set; }//subtotal de la factura
        public decimal Descuento { get; set; }//descuento de la factura 
        public decimal Total { get; set; }//total de la factura
        


    }
}
