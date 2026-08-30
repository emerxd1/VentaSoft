using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using Store;
using ModuloEntidades;

namespace Store
{
    public class S_Users
    {
        private S_Users d_Users = new S_Users();//Instancia de la clase D_Users para poder llamar al metodo Lister
        List<Entidad_Usuario> Lister()
        {
            return d_Users.Lister();
        }

    }
}
