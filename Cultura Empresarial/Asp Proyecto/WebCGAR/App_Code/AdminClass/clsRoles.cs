using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;

public class clsRoles
{
    public static DataTable buscaRole()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select * from Roles";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaRolesIdNombre()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT RoleID,rNombre FROM Roles ORDER BY rNombre ";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaRole(string RoleID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Roles WHERE RoleID = " + RoleID;
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable buscaRoleEnTablas(string RoleID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Usuarios WHERE RoleID = " + RoleID;
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static int eliminaRole(string RoleID)
    {
        DataTable T = buscaRoleEnTablas(RoleID);
        if (T.Rows.Count == 0)
        {
            DbCommand comm = clsGenericDataAccess.CreateCommand();
            comm.CommandText = "DELETE FROM Roles WHERE RoleID = " + RoleID;
            return clsGenericDataAccess.ExecuteNonQuery(comm);
        }
        else return 0;
    }
    public static void insertaRole(string RoleID, string rNombre,string rActivo)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
           comm.CommandText = "INSERT INTO Roles (RoleID,rNombre,rActivo,rFecha) VALUES(" + RoleID + ",'" + rNombre + "','" + rActivo + "','" + DateTime.Now.ToString("s") + "')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void modificaRole(string RoleID, string rNombre, string rActivo)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "UPDATE Roles SET rNombre = '" + rNombre + "', rActivo = '" + rActivo + "' WHERE RoleID = " + RoleID;
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
}