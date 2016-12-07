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
    public static DataTable leeDepartamentos()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select * from Departamentos";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static int eliminaDepartamento(string DeptID)
    {
        DataTable T = buscaDepartamentoEnTablas(DeptID);
        if (T.Rows.Count == 0)
        {
            DbCommand comm = clsGenericDataAccess.CreateCommand();
            comm.CommandText = "DELETE FROM Departamentos WHERE dDepartamentoID = " + DeptID;
            return clsGenericDataAccess.ExecuteNonQuery(comm);
        }
        else return 0;
    }

    public static DataTable buscaDepartamentoEnTablas(string DeptID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Empleados WHERE eDepartamentoID = " + DeptID;
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaDepartamento(string DeptID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Departamentos WHERE dDepartamentoID = " + DeptID;
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static void insertaDepartamento(string DeptID,string dDescripcion)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Departamentos VALUES("+ DeptID +",'" + dDescripcion + "')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void modificaDepartamento(string DeptID, string dDescripcion)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "UPDATE Departamentos SET dDescripcion = '" + dDescripcion + "' WHERE dDepartamentoID = " + DeptID;
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable buscaDepartamentoIdNombre()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Departamentos ORDER BY dDescripcion";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
}