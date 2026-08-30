using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace ModuloEntidades
{
    public class Entidad_Cliente
    {
        public int IdCliente { get; set; }// Identificador único del cliente
        public string DNI { get; set; }// Documento de identidad del cliente    
        public string Nombre1 { get; set; }// Primer nombre del cliente
        public string Nombre2 { get; set; }// Segundo nombre del cliente
        public string Apellido1 { get; set; } // Primer apellido del cliente
        public string Apellido2 { get; set; }// Segundo apellido del cliente
        public string Correo { get; set; }// Correo electrónico del cliente 
        public string Telefono { get; set; }// Número de teléfono del cliente   
        public bool Estado { get; set; }// Estado del cliente (activo/inactivo)
       public string FechaCreacion { get; set; }// Fecha de creación del cliente    


    }
}
