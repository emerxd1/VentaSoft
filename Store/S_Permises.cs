using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using Store;
using ModuloEntidades;
using Data;


namespace Store

{
    public class S_Permises
    {
        public D_Permisos d_Permisos = new D_Permisos();//Instancia de la clase D_Users para poder llamar al metodo Lister
       public List<Entidad_Permiso> Lister(int IdUsuario)
        {
            return d_Permisos.Lister(IdUsuario);
        }
    }
}
