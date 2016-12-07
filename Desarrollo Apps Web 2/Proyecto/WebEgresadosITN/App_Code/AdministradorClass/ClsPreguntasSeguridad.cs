using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClsPreguntasSeguridad
/// </summary>
public class ClsPreguntasSeguridad
{
    public static DataTable leePreguntas()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Preguntas";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}