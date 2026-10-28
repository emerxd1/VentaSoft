using Entitys;
using Microsoft.Data.SqlClient;
using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class D_Reports
    {
            public List<ReporteCompra> Compra(string FechaInicio, string FechaFin, int IdProveedor)
            {
                List<ReporteCompra> Lista = new List<ReporteCompra>();//Lista de tipo reporte compra para almacenar los datos de la tabla Categoria

                using (SqlConnection oconnect = new SqlConnection(Connection.DB))
                {
                    try
                    {
                        StringBuilder query = new StringBuilder();
                        SqlCommand cm = new SqlCommand("sp_ReporteCompras", oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                        cm.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                        cm.Parameters.AddWithValue("@FechaFin", FechaFin);
                        cm.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                        cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                        oconnect.Open();//Abrimos la conexion a la base de datos

                        using (SqlDataReader rd = cm.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                Lista.Add(new ReporteCompra()
                                {
                                    FechaRegistro = rd["FechaRegistro"].ToString(),
                                    TipoDocumento = rd["TipoDocumento"].ToString(),
                                    NumeroDocumento = rd["NumeroDocumento"].ToString(),
                                    UsuarioRegistro = rd["UsuarioRegistro"].ToString(),
                                    DocumentoProveedor = rd["DocumentoProveedor"].ToString(),
                                    RazonSocial = rd["RazonSocial"].ToString(),
                                    CodigoProducto = rd["CodigoProducto"].ToString(),
                                    NombreProducto = rd["NombreProducto"].ToString(),
                                    Categoria = rd["Categoria"].ToString(),
                                    PrecioCompra = rd["PrecioCompra"].ToString(),
                                    PrecioVenta = rd["PrecioVenta"].ToString(),
                                    Cantidad = rd["Cantidad"].ToString(),
                                    SubTotal = rd["SubTotal"].ToString()
                                });//Agregamos los datos de la tabla Categoria a la lista de tipo reporte compra

                        }



                        }
                    }
                    catch (Exception)
                    {

                        Lista = new List<ReporteCompra>();//Si ocurre un error, se devuelve una lista vacía (corregido)

                    }
                }


                return Lista;//Devolvemos la lista de tipo ReporteCompra con los datos de la tabla Categoria
            }


        public List<ReporteVentas> Venta(string FechaInicio, string FechaFin)
        {
            List<ReporteVentas> Lista = new List<ReporteVentas>();//Lista de tipo reporte venta para almacenar los datos de la tabla Categoria

            using (SqlConnection oconnect = new SqlConnection(Connection.DB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    SqlCommand cm = new SqlCommand("sp_ReporteCompras", oconnect);//Instancia de la clase SqlCommand para ejecutar la consulta a la base de datos
                    cm.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                    cm.Parameters.AddWithValue("@FechaFin", FechaFin);
                    cm.CommandType = CommandType.Text;//Tipo de comando a ejecutar

                    oconnect.Open();//Abrimos la conexion a la base de datos

                    using (SqlDataReader rd = cm.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Lista.Add(new ReporteVentas()
                            {
                                FechaRegistro = rd["FechaRegistro"].ToString(),
                                TipoDocumento = rd["TipoDocumento"].ToString(),
                                NumeroDocumento = rd["NumeroDocumento"].ToString(),
                                UsuarioRegistro = rd["UsuarioRegistro"].ToString(),
                                DocumentoCliente = rd["DocumentoCliente"].ToString(),
                                NombreCliente = rd["NombreCliente"].ToString(),
                                CodigoProducto = rd["CodigoProducto"].ToString(),
                                NombreProducto = rd["NombreProducto"].ToString(),
                                Categoria = rd["Categoria"].ToString(),
                                PrecioVenta = rd["PrecioVenta"].ToString(),
                                Cantidad = rd["Cantidad"].ToString(),
                                SubTotal = rd["SubTotal"].ToString()
                            });//Agregamos los datos de la tabla Categoria a la lista de tipo reporte compra

                        }



                    }
                }
                catch (Exception)
                {

                    Lista = new List<ReporteVentas>();//Si ocurre un error, se devuelve una lista vacía (corregido)

                }
            }


            return Lista;//Devolvemos la lista de tipo ReporteCompra con los datos de la tabla Categoria
        }





    }
}
