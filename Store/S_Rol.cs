using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Text;
using static Store.S_Rol;
using Data;

namespace Store
{
    public class S_Rol
    {

        private D_Rol d_rol = new D_Rol();  // <-- referencia a la clase de DATOS, no a sí misma

        public List<Entidad_Rol> Lister()
            {
                return d_rol.Lister();
            }
        }
    }

