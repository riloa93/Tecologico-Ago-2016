using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;

/// <summary>
/// Summary description for clsDemanda
/// </summary>
public class clsDemanda
{
    public static void insertaFuncionDemanda(string UsuarioID,string dFuncion)
    {
        string id = buscaUltimoID();
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Demanda VALUES('"+id+"','"+dFuncion+ "','"+UsuarioID+"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static string buscaUltimoID()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT TOP 1 DemandaID FROM Demanda ORDER BY DemandaID DESC";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        int id;
        if (T.Rows.Count - 1 == 0)
        {
            DataRow row = T.Rows[0];
            id = Convert.ToInt32(row["DemandaID"].ToString());
            id++;
        }
        else id = 1;

        return id.ToString();
    }
}