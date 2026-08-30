using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloEntidades
{
    public class Entidad_Usuario
    {
        public int IdUsuario { get; set; }// Identificador único del usuario
        public String DNI { get; set; }// Documento Nacional de Identidad del usuario

        public string Nombre1 { get; set; }// Nombre del usuario
        public string Nombre2 { get; set; }// Segundo nombre del usuario
        public string Apellido1 { get; set; }// Primer apellido del usuario
        public string Apellido2 { get; set; }// Segundo apellido del usuario
        public string Correo { get; set; }// Correo electrónico del usuario
        public string Clave { get; set; }// Contraseña del usuario
        public Entidad_Rol Rol { get; set; }// Rol del usuario
        public bool Estado { get; set; }// Estado del usuario (activo/inactivo)
        public string FechaCreacion { get; set; }// Fecha de creacion del usuario
    }
}
