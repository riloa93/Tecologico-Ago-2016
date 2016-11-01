using System;
using System.Data;
using System.Data.Common;
using System.Web.Security;

public class Users
{
    public static void Remove_User(string UserID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Usuario WHERE UsuarioID = '" + UserID + "'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void InsertUserProf(string UserID, string uName, string uDepartment, string uPwr, string RoleID)
    {
        String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(uPwr.Trim(), "SHA1");

        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Profesores VALUES('" + UserID + "','" + uName + "','" + uDepartment + "','" + passwordHash + "'," + RoleID +  "','" + DateTime.Now.ToString("s") + "')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void modificaUsuario(string UserID, string uName, string uDepartment, string uPwr, string RoleID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        if (uPwr != "")
        {
            String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(uPwr.Trim(), "SHA1");
            comm.CommandText = "UPDATE Usuarios SET uNombre = '" + uName + "',uPwr = '" + passwordHash + ",pDepartamentoID ='" + uDepartment + "',RoleID = " + RoleID  + "' WHERE UsuarioID = '" + UserID.Trim() + "'";
        }
        else
        {
            comm.CommandText = "UPDATE Usuarios SET uNombre = '" + uName + "',RoleID = " + RoleID + ",uActivo = '" + uActivo + "' WHERE UsuarioID = '" + UsuarioID + "'";
        }
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

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