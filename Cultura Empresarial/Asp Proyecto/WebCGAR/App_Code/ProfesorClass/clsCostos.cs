using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Collections;

/// <summary>
/// Summary description for clsCostos
/// </summary>
public class clsCostos
{
    public static void insertaCostos(string CostoID, string cCompraUni, string cPosesionUni, string cProduccionUni, string cEnvioUni, string cCostoPedido, string cLanzamientoProd, string cExpedicion, string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Costos VALUES('"+CostoID+"','"+cCompraUni+"','"+cPosesionUni+ "','"+
            cProduccionUni+ "','"+cEnvioUni+ "','"+cCostoPedido+ "','"+cLanzamientoProd+ "','"+cExpedicion+"','"+UsuarioID+"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void eliminarCostos(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Costos WHERE UsuarioID='" + UsuarioID +"'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable leerCostosPred(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Costos WHERE UsuarioID='"+UsuarioID+"'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static string ultimoCostosID()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT TOP 1 CostoID FROM Costos ORDER BY CostoID DESC";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        int id;
        if (T.Rows.Count > 0)
        {
            DataRow dt = T.Rows[0];
            id = Convert.ToInt32(dt["CostoID"].ToString());
            id++;
        }
        else id= 1;

        return id.ToString();
    }
}