using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Web.Security;

public class ClsEmpleados
{
    //public static bool comboDepartamento = false;
    public static string CheckPassword(string Password, string Usuario)
    {   // "SELECT rNombre,UsuarioID,uNombre,uPwr FROM Usuarios U, Roles R WHERE UsuarioID = '" + Usuario + "' AND U.RoleID = R.RoleID";
        string Result;

        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT eDepartamento,EmpleadoID,eNombre,ePswd,eStatus FROM Empleados U, Departamentos R WHERE eCorreo ='"+ Usuario +"' AND U.eDepartamento = R.dDescripcion";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        if (T.Rows.Count > 0)
        {
            String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Trim(), "SHA1");
            if (passwordHash == T.Rows[0][3].ToString())
            //if(Password == T.Rows[0][3].ToString())
            {
                return Result = T.Rows[0][0].ToString() + "," + T.Rows[0][1].ToString() + "," + T.Rows[0][3].ToString() + "," + T.Rows[0][4].ToString().Trim()+ "," + T.Rows[0][2].ToString();
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

    public static DataTable leeEmpleados()
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select * from Empleados";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static DataTable buscaEmpleadoNombreByLike(string eNombre)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT EmpleadoID,eNombre,eSeguro,eDireccion,eTelefono,eCorreo,eFechaIngreso,eFechaSalida,eDepartamento,ePswd FROM Empleados E WHERE eNombre LIKE '%" + eNombre + "%'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static DataTable buscaEmpleadoID(string EmpleadoID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Empleados WHERE EmpleadoID = '" + EmpleadoID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
    }
    public static void eliminaEmpleado(string EmpleadoID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Empleados WHERE EmpleadoID = '" + EmpleadoID + "'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
    public static void insertaEmpleado(string EmpleadoID, string eNombre,string eSeguro, string eDireccion, string eTelefono, string eCorreo, string fechaIng, string dDepartamento, string ePswd)
    {
        String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(ePswd.Trim(), "SHA1");

        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Empleados(EmpleadoID,eNombre,eSeguro,eDireccion,eTelefono,eCorreo,eFechaIngreso,eDepartamento,ePswd,eStatus) VALUES(" + EmpleadoID + ",'" + eNombre + "','" + eSeguro + "','" + eDireccion + "','" + eTelefono + "','" + eCorreo + "','" + fechaIng + "','" + dDepartamento + "','" + passwordHash + "','A')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void modificaEmpleado(string EmpleadoID, string eNombre, string eSeguro, string eDireccion, string eTelefono,string eCorreo, string eFechaIngreso, string eFechaSalida, string eDepartamento, string ePswd)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        if (eFechaSalida != "")
        {
            if (ePswd != "")
            {
                String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(ePswd.Trim(), "SHA1");
                comm.CommandText = "UPDATE Empleados SET eNombre = '" + eNombre + "', eSeguro='" + eSeguro + "', eDireccion='" + eDireccion + "', eTelefono='" + eTelefono + "', eCorreo='" + eCorreo +
                "', eFechaIngreso='" + eFechaIngreso + "',eFechaSalida='" + eFechaSalida + "', eDepartamento='" + eDepartamento + "',ePswd = '" + passwordHash + "', eStatus='I' WHERE EmpleadoID="+EmpleadoID;
            }
            else
            {
                comm.CommandText = "UPDATE Empleados SET eNombre = '" + eNombre + "', eSeguro='" + eSeguro + "', eDireccion='" + eDireccion + "', eTelefono='" + eTelefono + "', eCorreo='" + eCorreo +
                "', eFechaIngreso='" + eFechaIngreso + "',eFechaSalida='" + eFechaSalida + "', eDepartamento='" + eDepartamento + "', eStatus='I' WHERE EmpleadoID=" + EmpleadoID;
            }
        }
        else
        {
            if (ePswd != "")
            {
                String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(ePswd.Trim(), "SHA1");
                comm.CommandText = "UPDATE Empleados SET eNombre = '" + eNombre + "', eSeguro='" + eSeguro + "', eDireccion='" + eDireccion + "', eTelefono='" + eTelefono + "', eCorreo='" + eCorreo +
                "', eFechaIngreso='" + eFechaIngreso + "', eDepartamento='" + eDepartamento + "', ePswd='" + passwordHash + "' WHERE EmpleadoID=" + EmpleadoID;
            }
            else
            {
                comm.CommandText = "UPDATE Empleados SET eNombre = '" + eNombre + "', eSeguro='" + eSeguro + "', eDireccion='" + eDireccion + "', eTelefono='" + eTelefono + "', eCorreo='" + eCorreo +
                "', eFechaIngreso='" + eFechaIngreso + "', eDepartamento='" + eDepartamento + "' WHERE EmpleadoID = "+EmpleadoID;
            }
        }
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
}