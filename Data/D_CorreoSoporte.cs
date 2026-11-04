using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class D_CorreoSoporte : D_RecuperarPassword
    {
        public D_CorreoSoporte()
        {
            remitenteCorreo = "soporteventasosft@gmail.com";
            password = "lety tgfk yvme vxzg";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
        }
    }
}
