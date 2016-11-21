using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;
using System.Collections;

/// <summary>
/// Summary description for clsDatosIniciales
/// </summary>
public class clsDatosIniciales
{
    public static void insertaDatosIniciales(string rol, string dCapacidad,string dOrdenes, string dEmpresaID, string UsuarioID,string inventario)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO DatosIniciales VALUES('"+rol+"','"+Convert.ToInt32(dCapacidad)+"','"+Convert.ToInt32(dOrdenes)+
            "','"+dEmpresaID+ "','"+UsuarioID+"','"+inventario+"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void eliminaDatosIniciales(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM DatosIniciales WHERE UsuarioID='"+UsuarioID+"'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static bool buscarExistencia(string UsuarioID)
    {
        bool existe = false;
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM DatosIniciales WHERE UsuarioID='"+UsuarioID+"'";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);

        if (T.Rows.Count - 1 >= 0) existe = true;
        else existe = false;

        return existe;
    }
    //Actualizaciones
    public static DataTable cargaEmpresasMP(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT EmpresaID,eNombre FROM EmpresasMP WHERE UsuarioID='"+UsuarioID +"' ORDER BY EmpresaID";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable cargaEmpresasPT(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT EmpresaID,eNombre FROM EmpresasPT WHERE UsuarioID='" + UsuarioID + "' ORDER BY EmpresaID";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaDatosIniciales(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM DatosIniciales WHERE UsuarioID='" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}