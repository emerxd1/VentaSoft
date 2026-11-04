using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Usuario
    {
        public int IdUsuario { get; set; }// Identificador único del usuario
        public string DNI { get; set; } = string.Empty;// Documento Nacional de Identidad del usuario

        public string Telefono { get; set; } = string.Empty;// Número de teléfono del usuario
        public string Nombre1 { get; set; } = string.Empty;// Nombre del usuario
        public string Nombre2 { get; set; } = string.Empty;// Segundo nombre del usuario
        public string Apellido1 { get; set; } = string.Empty;// Primer apellido del usuario
        public string Apellido2 { get; set; } = string.Empty;// Segundo apellido del usuario
        public string Correo { get; set; } = string.Empty;// Correo electrónico del usuario
        public string Clave { get; set; } = string.Empty;// Contraseña del usuario
        public Entidad_Rol? oRol { get; set; }// Rol del usuario
        public bool Estado { get; set; }// Estado del usuario (activo/inactivo)
        public string FechaCreacion { get; set; } = string.Empty;// Fecha de creacion del usuario
    }
}
