using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Producto
    {
        public int IdProducto { get; set; }// Identificador único del producto
        public string Codigo { get; set; } = string.Empty;// Código del producto         
        public string Nombre { get; set; } = string.Empty;// Nombre del producto
        public string Descripcion { get; set; } = string.Empty;// Descripción del producto
        public decimal PrecioCompra { get; set; }// Precio de compra del producto
        public decimal PrecioVenta { get; set; }// Precio de venta del producto             
        public Entidad_Categoria? oCategoria { get; set; }// Identificador de la categoría del producto   

        public int Stock { get; set; }// Cantidad en stock del producto
        public bool Estado { get; set; }// Estado del producto (activo/inactivo)
        public string FechaCreacion { get; set; } = string.Empty;// Fecha de creación del producto
    }
}
