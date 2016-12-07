using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClsProduccion
/// </summary>
public class ClsProduccion
{
    public static DataTable leeProduccion()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente, lProyecto, lCantidad, lsVentas, lsCompras, lsDiseno, lsProd, lsEnsamble, lsCalidad, lFechaRequisision, lFechaEntrega from Listas";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}