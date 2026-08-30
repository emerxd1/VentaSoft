using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Producto
    {
        public int IdProducto { get; set; }// Identificador único del producto
        public string Codigo { get; set; }// Código del producto         
        public string Nombre { get; set; }// Nombre del producto
        public string Descripcion { get; set; }// Descripción del producto
        public decimal PrecioCompra { get; set; }// Precio de compra del producto
        public decimal PrecioVenta { get; set; }// Precio de venta del producto             
        public Entidad_Categoria IdCategoria { get; set; }// Identificador de la categoría del producto   

        public int Stock { get; set; }// Cantidad en stock del producto
        public bool Estado { get; set; }// Estado del producto (activo/inactivo)
        public string FechaCreacion { get; set; }// Fecha de creación del producto
    }
}
