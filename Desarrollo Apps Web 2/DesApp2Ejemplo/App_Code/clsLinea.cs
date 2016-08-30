using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for Linea
/// </summary>
public class clsLinea
{
    public static DataTable buscaLineas()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Linea ORDER BY Nombre";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static void inserta_linea(string lineaID, string nombre, string sbu)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Linea VALUES('"+lineaID+"','"+nombre+"','"+sbu+"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void elimina_linea(string lineaID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Linea WHERE LineaID=" +lineaID;
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void actualiza_linea(string lineaID, string nombre, string sbu)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "UPDATE Linea SET Nombre='"+nombre+"', SBU='"+sbu+"' WHERE LineaID="+lineaID;
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
}