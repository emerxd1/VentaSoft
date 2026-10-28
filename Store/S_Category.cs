using Data;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Store
{
    public class S_Category
    {
        private D_Category d_Category = new D_Category();

        // Solo letras (incluye tildes y ñ) y espacios
        private static readonly Regex RegexSoloLetras = new Regex(@"^[a-zA-ZÁÉÍÓÚáéíóúÑñ\s]+$");

        // Permite letras, números, espacios y la mayoría de signos de puntuación comunes
        private static readonly Regex RegexDescripcion = new Regex(@"^[\p{L}\p{N}\p{P}\p{Zs}]+$");

        public List<Entidad_Categoria> Lister()
        {
            return d_Category.Lister();
        }

        public int Register(Entidad_Categoria oCategoria, out string Mensaje, int valorEstado)
        {
            if (!Validar(oCategoria, out Mensaje, valorEstado))
                return 0;

            return d_Category.RegisterCategory(oCategoria, out Mensaje);
        }


        public bool Edit(Entidad_Categoria oCategoria, out string Mensaje, int valorEstado)
        {
            if (!Validar(oCategoria, out Mensaje, valorEstado))
                return false;

            return d_Category.UpdateCategory(oCategoria, out Mensaje);
        }

        public bool Delete(Entidad_Categoria oCategoria, out string Mensaje)
        {
            return d_Category.DeleteCategory(oCategoria, out Mensaje);
        }

  

        //   null  -> no se valida el estado (comportamiento original)
        //   -1    -> el usuario no seleccionó estado -> se acumula el error
        //   0 o 1 -> valor válido, no se genera error
        public bool Validar(Entidad_Categoria oCategoria, out string Mensaje, int? valorEstado)
        {
            Mensaje = string.Empty;
            string errores = string.Empty;

            if (oCategoria == null)
            {
                Mensaje = "No se recibió información de la categoría.";
                return false;
            }

            // ---- Nombre ----
            if (string.IsNullOrWhiteSpace(oCategoria.Nombre))
                errores += "El Nombre es obligatorio.\n";
            else if (!RegexSoloLetras.IsMatch(oCategoria.Nombre.Trim()))
                errores += "El campo Nombre solo debe contener letras.\n";

            // ---- Descripción (obligatorio) ----
            if (string.IsNullOrWhiteSpace(oCategoria.Descripcion))
                errores += "La Descripción es obligatoria.\n";
            else if (!RegexDescripcion.IsMatch(oCategoria.Descripcion.Trim()))
                errores += "La Descripción solo debe contener letras, números y espacios.\n";

            // ---- Estado (solo si se proporcionó valorEstado) ----
            if (valorEstado.HasValue && valorEstado.Value == -1)
                errores += "Debe seleccionar un estado.\n";

            if (!string.IsNullOrEmpty(errores))
            {
                Mensaje = "Se encontraron los siguientes errores:\n" + errores;
                return false;
            }

            return true;
        }
    }
}
