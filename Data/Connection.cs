using System;
using System.Collections.Generic;
using System.Text;

using System.Configuration;
namespace Data
{
    public class Connection
    {
        public static string DB = ConfigurationManager.ConnectionStrings["connect_db"].ToString();//Cadena de conexion a la base de datos


    }
}
