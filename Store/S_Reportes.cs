using System;
using System.Collections.Generic;
using System.Text;
using Entitys;
using Data; 

namespace Store
{
    public class S_Reportes
    {
        private D_Reports O_Reportes = new D_Reports();

        public List<ReporteCompra> Compra(string FechaInicio, string FechaFin, int IdProveedor)
        {
            return O_Reportes.Compra(FechaInicio, FechaFin, IdProveedor);
        }

        public List<ReporteVentas> Venta(string FechaInicio, string FechaFin)
        {
            return O_Reportes.Venta(FechaInicio, FechaFin);
        }
    }
}