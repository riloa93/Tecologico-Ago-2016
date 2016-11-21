using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;

/// <summary>
/// Summary description for clsTiempos
/// </summary>
public class clsTiempos
{
    public static DataTable buscaHorario(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Tiempos WHERE UsuarioID = '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static void insertaTiempos(string FechaPartida, string FechaFin, string UsuarioID)
    {
        string TiempoID = ultimoTiempoID();
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        DateTime FP = Convert.ToDateTime(FechaPartida);
        DateTime FF = Convert.ToDateTime(FechaFin);

        comm.CommandText = "INSERT INTO Tiempos VALUES('"+TiempoID+"','"+FP.ToString("s")+ "','" + FF.ToString("s") +"','"+UsuarioID+"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static DataTable validaHoraJuego(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Tiempos WHERE UsuarioID = '" + UsuarioID + "' AND GETDATE() BETWEEN FechaInicio AND FechaFinal";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static string ultimoTiempoID()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT TOP 1 TiempoID FROM Tiempos ORDER BY TiempoID DESC";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        int id;

        if (T.Rows.Count - 1 == 0)
        {
            DataRow row = T.Rows[0];

            id = Convert.ToInt32(row["TiempoID"].ToString());
            id++;
        }
        else id = 1;

        return id.ToString();
    }
}