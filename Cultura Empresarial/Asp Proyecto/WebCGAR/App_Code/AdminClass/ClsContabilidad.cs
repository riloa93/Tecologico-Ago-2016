using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Web.Security;

/// <summary>
/// Summary description for ClsContabilidad
/// </summary>
public class ClsContabilidad
{
    public static DataTable leeContabilidad()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select * from Listas";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static void eliminaPo(string PoID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Listas WHERE lPo= '" + PoID + "'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static void insertaPo(string lTipoOrd, string lPo, string lNoOrden, string lSemana, string lAsignado, string lVendedor, string lEmpresa, string lCliente, string lProyecto, string lCantidad,
        string lFechaRequisision, string lFechaEntrega, string lPrecioUnitario, string lPrecioTotal, string lStatusCont)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Listas(lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente,lProyecto,lCantidad,lFechaRequisision,lFechaEntrega,lPrecioUnitario,lPrecioTotal,lStatusCont) VALUES('" 
            + lTipoOrd + "'," + lPo + ",'" + lNoOrden + "','" + lSemana + "','" + lAsignado + "','" + lVendedor + "','" + lEmpresa + "','" + lCliente + "','" + lProyecto + "','" + lCantidad + "','" + lFechaRequisision 
            + "','" + lFechaEntrega + "','" + Convert.ToDouble(lPrecioUnitario) + "','" + Convert.ToDouble(lPrecioTotal) + "','" + lStatusCont + "')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    //string lsVentas, string lsCompras, string lsDiseno, string lsProd, string lsEnsamble, string lsCalidad, 
    public static void modificaPo(string lTipoOrd, string lPo, string lNoOrden, string lSemana, string lAsignado, string lVendedor, string lEmpresa, string lCliente, string lProyecto, string lCantidad, 
        string lFechaRequisision, string lFechaEntrega, string lPrecioUnitario, string lPrecioTotal, string lStatusCont)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();

        comm.CommandText = "UPDATE Listas SET  lTipoOrd='" + lTipoOrd + "', lNoOrden='" + lNoOrden + "', lSemana='" + lSemana + "', lAsignado='" + lAsignado + "', lVendedor='" + lVendedor +
        "', lEmpresa='" + lEmpresa + "',lCliente='" + lCliente + "', lProyecto='" + lProyecto + "',lCantidad= '" + lCantidad + "', lFechaRequisision='"+ lFechaRequisision+ "', lFechaEntrega='" + lFechaEntrega +
        "', lPrecioUnitario='" + lPrecioUnitario + "', lPrecioTotal='"+ lPrecioTotal + "', lStatusCont='" + lStatusCont + "' WHERE lPo=" + lPo;
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable buscaPoNombreByLike(string lProyecto, string lVendedor, string lAsignado, string lCliente, string lEmpresa, string lPo)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        if (lProyecto != "")
        {
            /* comm.CommandText = "SELECT lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente,lProyecto,lCantidad,lFechaRequisision,lFechaEntrega,lPrecioUnitario,lPrecioTotal,lStatusCont "+
                 "FROM Listas WHERE lProyecto LIKE '%" + lProyecto + "%'";*/
            comm.CommandText = "SELECT * FROM Listas WHERE lProyecto LIKE '%" + lProyecto + "%'";
        }
        else if (lVendedor != "")
        {
            //comm.CommandText = "SELECT lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente,lProyecto,lCantidad,lFechaRequisision,lFechaEntrega,lPrecioUnitario,lPrecioTotal,lStatusCont " +
            //"FROM Listas WHERE lVendedor LIKE '%" + lVendedor + "%'";
            comm.CommandText = "SELECT * FROM Listas WHERE lVendedor LIKE '%" + lVendedor + "%'";
        }
        else if (lAsignado !="")
        {
            //comm.CommandText = "SELECT lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente,lProyecto,lCantidad,lFechaRequisision,lFechaEntrega,lPrecioUnitario,lPrecioTotal,lStatusCont " +
            //"FROM Listas WHERE lProyecto LIKE '%" + lProyecto + "%'";
            comm.CommandText = "SELECT * FROM Listas WHERE lAsignado LIKE '%" + lAsignado + "%'";
        }
        else if (lCliente != "")
        {
            //comm.CommandText = "SELECT lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente,lProyecto,lCantidad,lFechaRequisision,lFechaEntrega,lPrecioUnitario,lPrecioTotal,lStatusCont " +
            //"FROM Listas WHERE lAsignado LIKE '%" + lAsignado + "%'";
            comm.CommandText = "SELECT * FROM Listas WHERE lCliente LIKE '%" + lCliente + "%'";
        }
        else if (lEmpresa != "")
        {
            //comm.CommandText = "SELECT lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente,lProyecto,lCantidad,lFechaRequisision,lFechaEntrega,lPrecioUnitario,lPrecioTotal,lStatusCont " +
            //"FROM Listas WHERE lEmpresa LIKE '%" + lEmpresa + "%'";
            comm.CommandText = "SELECT * FROM Listas WHERE lEmpresa LIKE '%" + lEmpresa + "%'";
        }
        else if (lPo != "")
        {
            //comm.CommandText = "SELECT lTipoOrd,lPo,lNoOrden,lSemana,lAsignado,lVendedor,lEmpresa,lCliente,lProyecto,lCantidad,lFechaRequisision,lFechaEntrega,lPrecioUnitario,lPrecioTotal,lStatusCont " +
            //"FROM Listas WHERE lPo LIKE '%" + lPo + "%'";
            comm.CommandText = "SELECT * FROM Listas WHERE lPo LIKE '%" + lPo + "%'";
        }
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable buscaPoID(string PoID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Listas WHERE lPo = '" + PoID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}