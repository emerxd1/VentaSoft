using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ModuloEntidades
{
    public class Entidad_Cliente
    {
        public int IdCliente { get; set; }// Identificador único del cliente
        public string DNI { get; set; } = string.Empty;// Documento de identidad del cliente    
        public string Nombre1 { get; set; } = string.Empty;// Primer nombre del cliente
        public string Nombre2 { get; set; } = string.Empty;// Segundo nombre del cliente
        public string Apellido1 { get; set; } = string.Empty; // Primer apellido del cliente
        public string Apellido2 { get; set; } = string.Empty;// Segundo apellido del cliente
        public string Correo { get; set; } = string.Empty;// Correo electrónico del cliente 
        public string Telefono { get; set; } = string.Empty;// Número de teléfono del cliente   
        public bool Estado { get; set; }// Estado del cliente (activo/inactivo)
       public string FechaCreacion { get; set; } = string.Empty;// Fecha de creación del cliente    


    }
}
