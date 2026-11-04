using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class S_RecuperarPassword
    {
        public string recoverPassword(string solicitudUser)
        {
            // Usamos D_CorreoSoporte para que cargue las credenciales configuradas
            var dataAccess = new Data.D_CorreoSoporte();
            return dataAccess.recoverPassword(solicitudUser);
        }
    }
}