using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for clsRed
/// </summary>
public class clsRed
{
    public static void insertaEmpRed(string UsuarioID, string EmpresaID, string ProveedorID1, string ProveedorID2, string ClienteID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Red (UsuarioID,EmpresaID,ProveedorID1,ProveedorID2,ClienteID,rFecha) VALUES('" + UsuarioID + "'," + EmpresaID + "," + ProveedorID1 + "," + ProveedorID2 + "," + ClienteID + ",'" + DateTime.Now.ToString("s") + "')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static DataTable leeRed(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Red WHERE UsuarioID = '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static int eliminaRed(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Red WHERE UsuarioID = '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static int eliminaRedEmpresa(string UsuarioID,string EmpresaID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Red WHERE UsuarioID = '" + UsuarioID + "' AND EmpresaID = " + EmpresaID;
        return clsGenericDataAccess.ExecuteNonQuery(comm);
    }
}