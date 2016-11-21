using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

/// <summary>
/// Summary description for ClsDepartamentos
/// </summary>
public class ClsDepartamentos
{
    public static DataTable buscaDepartamento()
    {
        DataTable T;
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select * from Departamentos";
        return T = clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}