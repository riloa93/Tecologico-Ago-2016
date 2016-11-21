using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for clsMateriaPrima
/// </summary>

public class clsMateriaPrima
{
    public static void insertaEmpMateriaPrima(string EmpresaID, string eNombre, string eUsuario, string ePassword,string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO EmpresasMP (EmpresaID,eNombre,eUsuario,ePassword,UsuarioID,eFecha) VALUES(" + EmpresaID + ",'" + eNombre + "','" + eUsuario + "','" + ePassword + "','" + UsuarioID + "','" + DateTime.Now.ToString("s") + "')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
     public static DataTable leeEmpNombre(string UsuarioID, string EmpresaID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT EmpresaID,eNombre FROM EmpresasMP WHERE UsuarioID = '" + UsuarioID + "' AND EmpresaID =" + EmpresaID;
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable buscaEmpresa(string eUsuario)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM EmpresasMP WHERE eUsuario = '" + eUsuario + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable leeEmpMateriaPrima(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM EmpresasMP WHERE UsuarioID = '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static int eliminaEmpMateriaPrima(string UsuarioID,string EmpresaID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM EmpresasMP WHERE UsuarioID = '" + UsuarioID + "' AND EmpresaID = " + EmpresaID;
        return clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static int eliminaDatosInicialesEmpresa(string UsuarioID, string EmpresaID,string dRol)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM DatosIniciales WHERE UsuarioID = '" + UsuarioID + "' AND dEmpresaID = " + EmpresaID + " AND dRol = " + dRol;
        return clsGenericDataAccess.ExecuteNonQuery(comm);
    }
}