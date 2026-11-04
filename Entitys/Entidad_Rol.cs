using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Rol

    {
        public int IdRol { get; set; }// Identificador unico del rol
        public string Descripcion { get; set; } = string.Empty;// Descripcion del rol
        public string FechaCreacion { get; set; } = string.Empty;// Fecha de creacion del rol

    }
}
