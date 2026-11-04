using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Categoria
    {
        public int IdCategoria { get; set; }// Identificador único de la categoría
        public string Nombre { get; set; } = string.Empty;// Nombre de la categoría
        public string Descripcion { get; set; } = string.Empty;// Descripción de la categoría

        public bool Estado { get; set; }// Estado de la categoría (activo/inactivo)

        public string FechaCreacion { get; set; } = string.Empty;// Fecha de creación de la categoría   
    }

}
