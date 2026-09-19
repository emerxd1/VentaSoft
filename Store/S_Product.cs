using Data;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Store
{
    public class S_Product
    {
        private D_Product d_Product = new D_Product();

        // Solo letras (incluye tildes y ñ) y espacios
        private static readonly Regex RegexSoloLetras = new Regex(@"^[a-zA-ZÁÉÍÓÚáéíóúÑñ\s]+$");

        // Permite letras, números, espacios y la mayoría de signos de puntuación comunes
        private static readonly Regex RegexDescripcion = new Regex(@"^[\p{L}\p{N}\p{P}\p{Zs}]+$");

        public List<Entidad_Producto> Lister()
        {
            return d_Product.Lister();
        }

        public int Register(Entidad_Producto oProducto, out string Mensaje)
        {
            if (!Validar(oProducto, out Mensaje))
                return 0;

            return d_Product.RegisterProduct(oProducto, out Mensaje);
        }

        public bool Edit(Entidad_Producto oProducto, out string Mensaje)
        {
            if (!Validar(oProducto, out Mensaje))
                return false;

            return d_Product.UpdateProduct(oProducto, out Mensaje);
        }

        public bool Delete(Entidad_Producto oProducto, out string Mensaje)
        {
            return d_Product.DeleteProduct(oProducto, out Mensaje);
        }

        private bool Validar(Entidad_Producto oProducto, out string Mensaje)
        {
            Mensaje = string.Empty;
            string errores = string.Empty;

            if (oProducto == null)
            {
                Mensaje = "No se recibio información del producto.";
                return false;
            }

            // ---- Nombre ----
            if (string.IsNullOrWhiteSpace(oProducto.Nombre))
                errores += "El Nombre es obligatorio.\n";
            else if (!RegexSoloLetras.IsMatch(oProducto.Nombre.Trim()))
                errores += "El campo Nombre solo debe contener letras.\n";
            else if (oProducto.Nombre.Trim().Length > 30)
                errores += "El Nombre no debe superar los 30 caracteres.\n";

            // ---- Descripción (obligatorio) ----
            if (string.IsNullOrWhiteSpace(oProducto.Descripcion))
                errores += "La Descripción es obligatoria.\n";
            else if (!RegexDescripcion.IsMatch(oProducto.Descripcion.Trim()))
                errores += "La Descripción solo debe contener letras, números y espacios.\n";

            // ---- Categoría ----
            if (oProducto.oCategoria == null || oProducto.oCategoria.IdCategoria <= 0)
                errores += "Debe seleccionar una Categoría válida.\n";

            // ---- Stock ----
            if (oProducto.Stock < 0)
                errores += "El Stock no puede ser negativo.\n";

            // ---- Precio de compra ----
            if (oProducto.PrecioCompra <= 0)
                errores += "El Precio de Compra debe ser mayor a cero.\n";

            // ---- Precio de venta ----
            if (oProducto.PrecioVenta <= 0)
                errores += "El Precio de Venta debe ser mayor a cero.\n";

            // ---- Regla de negocio: venta no puede ser menor o igual a la compra ----
            if (oProducto.PrecioCompra > 0 && oProducto.PrecioVenta > 0
                && oProducto.PrecioVenta <= oProducto.PrecioCompra)
                errores += "El Precio de Venta debe ser mayor al Precio de Compra.\n";

            if (!string.IsNullOrEmpty(errores))
            {
                Mensaje = "Se encontraron los siguientes errores:\n" + errores;
                return false;
            }

            return true;
        }
    }
}