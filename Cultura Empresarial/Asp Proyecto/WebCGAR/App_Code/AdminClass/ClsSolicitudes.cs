using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Web.Security;

public class ClsSolicitudes
{
    public static DataTable leerSolicitudes()
    {
        DataTable T;
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "Select * from Solicitudes";
        return T = clsGenericDataAccess.ExecuteSelectCommand(comm);
    }

    public static void insertaEmpleado(string EmpleadoID, string eNombre, string eSeguro, string eDireccion, string eTelefono, string eCorreo, string ePwr, string eRoleID, string eDepartamentoID)
    {
        string passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(ePwr.Trim(), "SHA1");

        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Empleados (EmpleadoID,eNombre,eSeguro,eDireccion,eTelefono,eCorreo,eFechaIngreso,eRoleID,eDepartamentoID,ePswd,eStatus) " +
          "VALUES('" + EmpleadoID + "','" + eNombre + "','" + eSeguro + "'," + eDireccion + ",'" + eTelefono + "','"+ eCorreo + "','" + DateTime.Now.ToString("s") + "','" +
          "','" + eRoleID +"','" + eDepartamentoID + "','" + passwordHash + "','" + "A" +"')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void eliminaUsuario(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Usuarios WHERE UsuarioID = '" + UsuarioID + "'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void modificaUsuario(string EmpleadoID, string eNombre, string eSeguro, string eDireccion, string eTelefono, string eCorreo, string ePwr, string eRoleID, string eDepartamentoID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        if (ePwr != "")
        {
            String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(ePwr.Trim(), "SHA1");
            comm.CommandText = "UPDATE Empleados SET eNombre = '" + eNombre + "',ePswd = '" + passwordHash + "',eSeguro= '"+ eSeguro +"', eDireccion='"+ eDireccion +"', eTelefono='"+ eTelefono +"', eCorreo='" +
                eCorreo + "', eRoleID = " + eRoleID + ",eDepartamentoID = '" + eDepartamentoID + "' WHERE EmpleadoID = '" + EmpleadoID.Trim() + "'";
        }
        else
        {
            comm.CommandText = "UPDATE Empleados SET eNombre = '" + eNombre + "',eSeguro= '" + eSeguro + "', eDireccion='" + eDireccion + "', eTelefono='" + eTelefono + "', eCorreo='" +
               eCorreo + "', eRoleID = " + eRoleID + ",eDepartamentoID = '" + eDepartamentoID + "' WHERE EmpleadoID = '" + EmpleadoID.Trim() + "'";
        }
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }
}