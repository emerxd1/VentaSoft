using Data;
using ModuloEntidades;
using System.Collections.Generic;
using System.Data;

namespace Store
{
    public class S_Ventas
    {
        private D_Ventas d_Ventas = new D_Ventas();

        public int ObtenerCorrelativo()
        {
            return d_Ventas.ObtenerCorrelativo();
        }

        public bool Registrar(Entidad_Venta obj, DataTable detalle, out string Mensaje)
        {
            return d_Ventas.Registrar(obj, detalle, out Mensaje);
        }

        // busca la venta y si existe le agrega los detalles delos productos
        public Entidad_Venta ObtenerVenta(string numero)
        {
            Entidad_Venta oVenta = d_Ventas.ObtenerVenta(numero);

            if (oVenta.IdVenta != 0)
            {
                oVenta.DetalleVenta = d_Ventas.ObtenerDetalleVenta(oVenta.IdVenta);
            }

            return oVenta;
        }
    }
}