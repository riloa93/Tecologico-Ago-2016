using System;
using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for ClsCarreras
/// </summary>
public class ClsCarreras
{
    public static DataTable leeCarreras()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Carreras";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}