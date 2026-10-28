using System;
using System.Collections.Generic;
using System.Text;
using Entitys;

namespace Store
{
    public class S_Reportes
    {
        private S_Reportes O_Reportes = new S_Reportes();

        public List<ReporteCompra> Compras(string FechaInicio, string FechaFin, int IdProveedor)
        {
            return O_Reportes.Compras(FechaInicio, FechaFin, IdProveedor);
        }

        public List<ReporteVentas> Ventas(string FechaInicio, string FechaFin)
        {
            return O_Reportes.Ventas(FechaInicio, FechaFin);
        }
    }
}
