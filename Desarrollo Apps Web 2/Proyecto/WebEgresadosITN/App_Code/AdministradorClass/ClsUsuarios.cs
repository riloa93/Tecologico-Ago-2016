using System;
using System.Data.Common;
using System.Web.Security;

/// <summary>
/// Summary description for ClsUsuarios
/// </summary>
public class ClsUsuarios
{
    public static void AgregarSolicitud(string sNoControl, string sNombre, string sCarreraID, string sFechaIngreso, string sFechaEgreso, string sTitulado, string sTrabaja, 
        string sEmpresa, string sPuesto, string sContacto, string sCorreo, string sPswd, string sRoleID)
    {
        String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(sPswd.Trim(), "SHA1");

        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "INSERT INTO Solicitudes(sNoControl,sNombre,sCarreraID,sFechaIngreso,sFechaEgreso,sTitulado,sTrabaja,sEmpresa,sPuesto,sContacto,sCorreo,sPswd,sRoleID,sAceptado) VALUES(" + 
            sNoControl + ",'" + sNombre + "'," + sCarreraID + ",'" + sFechaIngreso + "','" + sFechaEgreso + "','" + sTitulado + "','" + sTrabaja + "','" + sEmpresa + "','" + sPuesto + "','" + sContacto +
            "','" + sCorreo + "','" + passwordHash + "'," + sRoleID + ",'P')";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    /*public static void eliminaEmpleado(string EmpleadoID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "DELETE FROM Empleados WHERE EmpleadoID = '" + EmpleadoID + "'";
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static void modificaEmpleado(string EmpleadoID, string eNombre, string eSeguro, string eDireccion, string eTelefono, string eCorreo, string eFechaIngreso, string eFechaSalida, string eDepartamento, string ePswd)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        if (eFechaSalida != "")
        {
            if (ePswd != "")
            {
                String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(ePswd.Trim(), "SHA1");
                comm.CommandText = "UPDATE Empleados SET eNombre = '" + eNombre + "', eSeguro='" + eSeguro + "', eDireccion='" + eDireccion + "', eTelefono='" + eTelefono + "', eCorreo='" + eCorreo +
                "', eFechaIngreso='" + eFechaIngreso + "',eFechaSalida='" + eFechaSalida + "', eDepartamento='" + eDepartamento + "',ePswd = '" + passwordHash + "', eStatus='I' WHERE EmpleadoID=" + EmpleadoID;
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
                "', eFechaIngreso='" + eFechaIngreso + "', eDepartamento='" + eDepartamento + "' WHERE EmpleadoID = " + EmpleadoID;
            }
        }
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }*/
}