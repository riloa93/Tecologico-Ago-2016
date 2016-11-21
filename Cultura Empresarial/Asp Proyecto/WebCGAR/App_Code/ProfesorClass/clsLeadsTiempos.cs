using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for clsLeadsTiempos
/// </summary>
public class clsLeadsTiempos
{
    public static void insertaCostos(string dTiempoPedido, string dTiempoProd, string dTiempoServicio, string UsuarioID,string Semanas)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO LeadsJuego VALUES('" + dTiempoPedido + "','" + dTiempoProd + "','" + dTiempoServicio + "','" + UsuarioID + "','"+Semanas+"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void eliminarCostos(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM LeadsJuego WHERE dUsuarioID='" + UsuarioID + "'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable leerCostosPred(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM LeadsJuego WHERE dUsuarioID='" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}