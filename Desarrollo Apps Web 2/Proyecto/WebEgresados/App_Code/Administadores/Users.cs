using System.Collections;
using System.Data;
using System.Data.Common;

public class Users
{
    public static void Insert_Users(string information)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Profesores ";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable Select_Users()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Profesores ";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        return T;
    }
}