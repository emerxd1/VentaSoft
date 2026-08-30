using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Categoria
    {
        public int IdCategoria { get; set; }// Identificador único de la categoría
        public string Nombre { get; set; }// Nombre de la categoría
        public string Descripcion { get; set; }// Descripción de la categoría

        public bool Estado { get; set; }// Estado de la categoría (activo/inactivo)

        public string FechaCreacion { get; set; }// Fecha de creación de la categoría   
    }

}
