using System;
using System.Data;
using System.Data.Common;
using System.Web.Security;

public class clsUsuarios
{
    public static DataTable buscaUsuarioIDAllTables(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * from Usuarios U WHERE U.UsuarioID = '" + UsuarioID + "' AND (EXISTS(SELECT * FROM EmpresasMP WHERE UsuarioID = U.UsuarioID) " +
        "OR EXISTS(SELECT * FROM EmpresasPT WHERE UsuarioID = U.UsuarioID) OR EXISTS(SELECT * FROM Costos WHERE UsuarioID = U.UsuarioID) " +
        "OR EXISTS(SELECT * FROM CostosJuego WHERE UsuarioID = U.UsuarioID) OR EXISTS(SELECT * FROM DatosIniciales WHERE UsuarioID = U.UsuarioID) " +
        "OR EXISTS(SELECT * FROM DatosJuego WHERE UsuarioID = U.UsuarioID) OR EXISTS(SELECT * FROM JuegoControl WHERE UsuarioID = U.UsuarioID) " + 
        "OR EXISTS(SELECT * FROM LeadsJuego WHERE dUsuarioID = U.UsuarioID) OR EXISTS(SELECT * FROM Red WHERE UsuarioID = U.UsuarioID) " +
        "OR EXISTS(SELECT * FROM Semanas WHERE UsuarioID = U.UsuarioID) OR EXISTS(SELECT * FROM Tiempos WHERE UsuarioID = U.UsuarioID))";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable buscaUsuarioNombreByLike(string uNombre)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT UsuarioID,uNombre,rNombre,uActivo,uFechaAlta,uUltimoAcceso,uPWr FROM Usuarios U, Roles R WHERE uNombre LIKE '%" + uNombre + "%' AND U.RoleID = R.RoleID";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable leeUsuarios()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT UsuarioID,uNombre,rNombre,uActivo,uFechaAlta,uUltimoAcceso,uPWr FROM Roles R,Usuarios U WHERE U.RoleID = R.RoleID ORDER BY uNombre ";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaUsuarioNombre(string uNombre)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Usuarios WHERE uNombre = '" + uNombre + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaUsuarioID(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Usuarios WHERE UsuarioID = '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static void eliminaUsuario(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Usuarios WHERE UsuarioID = '" + UsuarioID + "'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static void insertaUsuario(string UsuarioID, string uNombre, string uPwr, string RoleID, string rActivo)
    {
        String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(uPwr.Trim(),"SHA1");
        
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Usuarios (UsuarioID,uNombre,uPwr,RoleID,uActivo,uUltimoAcceso,uFechaAlta) " +
          "VALUES('" + UsuarioID + "','" + uNombre + "','" + passwordHash + "'," + RoleID + ",'" + rActivo + "','" + DateTime.Now.ToString("s") + "','" + DateTime.Now.ToString("s") + "')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void modificaUsuario(string UsuarioID, string uNombre, string uPwr, string RoleID, string uActivo)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        if (uPwr != "")
        {
            String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(uPwr.Trim(), "SHA1");
            comm.CommandText = "UPDATE Usuarios SET uNombre = '" + uNombre + "',uPwr = '" + passwordHash + "',RoleID = " + RoleID + ",uActivo = '" + uActivo + "' WHERE UsuarioID = '" + UsuarioID.Trim() + "'";
        }
        else
        {
            comm.CommandText = "UPDATE Usuarios SET uNombre = '" + uNombre + "',RoleID = " + RoleID + ",uActivo = '" + uActivo + "' WHERE UsuarioID = '" + UsuarioID + "'";
        }
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static string CheckPassword(string Password, string UsuarioID)
    {
        string Result;

        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT rNombre,UsuarioID,uNombre,uPwr FROM Usuarios U, Roles R WHERE UsuarioID = '" + UsuarioID + "' AND U.RoleID = R.RoleID";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        if (T.Rows.Count > 0)
        {
            String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Trim(), "SHA1");
            if (passwordHash == T.Rows[0][3].ToString())
            {
                return Result = T.Rows[0][0].ToString() + "," + T.Rows[0][1].ToString() + "," + T.Rows[0][3].ToString() +",T," + T.Rows[0][2].ToString();
            }
            else
            {
                return "";
            }
        }
        else
        {
            return "";
        }
    }
}