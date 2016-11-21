using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;

/// <summary>
/// Summary description for clsSemanas
/// </summary>
public class clsSemanas
{
    public static void insertaSemanas(string Semana, string Lotes, string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Semanas VALUES('"+Semana+"','"+Lotes+"','"+UsuarioID+"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void eliminaSemanas(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Semanas WHERE UsuarioID='"+UsuarioID+"'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable leerSemanas(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Semanas WHERE UsuarioID='"+UsuarioID+"' ORDER BY Semana";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static int cantidadSemanas(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT dCantidadSemanas FROM LeadsJuego WHERE dUsuarioID='"+UsuarioID+"'";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        int semanas;

        if (T.Rows.Count > 0)
        {
            DataRow dt = T.Rows[0];
            semanas = Convert.ToInt32(dt["dCantidadSemanas"].ToString());
            return semanas;
        }
        else return semanas = 0;
    }
}