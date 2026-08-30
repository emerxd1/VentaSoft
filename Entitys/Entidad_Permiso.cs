using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Permiso
    {
        public int IdPermiso { get; set; }// Identificador único del permiso
        public Entidad_Rol oRol { get; set; } // Relación con la entidad Entidad_Rol
        public String NombreMenu { get; set; }// Nombre de menu al que pertenece el permiso
        public String FechaCreacion { get; set; }// Fecha de creacion del permiso



    }
}
