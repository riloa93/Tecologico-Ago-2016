using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ClsRoles
/// </summary>
public class ClsRoles
{
    public static void leeRoles()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText ="SELECT * FROM Roles";
        clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}