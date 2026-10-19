using Data;
using ModuloEntidades;
using System.Collections.Generic;
using System.Data;

namespace Store
{
    public class S_Compras
    {
        private D_Compras d_Compras = new D_Compras();

        public int ObtenerCorrelativo()
        {
            return d_Compras.ObtenerCorrelativo();
        }

        public bool Registrar(Entidad_Compra obj, DataTable detalle, out string Mensaje)
        {
            return d_Compras.Registrar(obj, detalle, out Mensaje);
        }

        public Entidad_Compra ObtenerCompra(string numero)
        {
            Entidad_Compra oEntidad_Compra = d_Compras.ObtenerCompra(numero);

            if (oEntidad_Compra.IdCompra != 0)
            {
                List<Entidad_DetalleCompra> oentidad_DetalleCompras = d_Compras.ObtenerDetalleCompra(oEntidad_Compra.IdCompra);

                oEntidad_Compra.DetalleCompra = oentidad_DetalleCompras;
            }

            return oEntidad_Compra;
        }
    }
}