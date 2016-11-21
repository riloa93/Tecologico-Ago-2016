using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for clsProductoTerminado
/// </summary>
public class clsProductoTerminado
{
    public static DataTable buscaEmpresa(string eUsuario)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM EmpresasPT WHERE eUsuario= '" + eUsuario + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static void insertaProductoTerminado(string EmpresaID, string eNombre,string eCargo, string eUsuario, string ePassword, string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        //string dateTime = DateTime.Now.ToShortDateString(), date = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd h:mm tt");
        comm.CommandText = "INSERT INTO EmpresasPT (EmpresaID,eNombre,eRol,eUsuario,ePassword,UsuarioID,eFecha) VALUES('"+EmpresaID+"','"+eNombre+"','"+eCargo+"','"+eUsuario+"','"+ePassword+"','"+UsuarioID+"','"+DateTime.Now.ToString("s") +"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static int eliminaProductoTerminado(string empresaID, string UsuarioID)
    {
            DbCommand comm = clsGenericDataAccess.CreateCommand();
            comm.CommandText = "DELETE FROM EmpresasPT WHERE EmpresaID=" + empresaID+" AND UsuarioID='"+UsuarioID.Trim()+"'";
            return clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable leeProductoTerminadoOrderDesc(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM EmpresasPT WHERE UsuarioID= '" + UsuarioID + "' order by EmpresaID desc";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable leeProductoTerminado(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM EmpresasPT WHERE UsuarioID= '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}