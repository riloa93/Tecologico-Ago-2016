using System;
using System.Data;
using System.Data.Common;
using System.Web.Security;

/// <summary>
/// Summary description for ClsUsuarios
/// </summary>
public class ClsUsuarios
{
    public static void AgregarSolicitud(string sNoControl, string sNombre, string sCarreraID, string sFechaIngreso, string sFechaEgreso, string sTitulado, string sTrabaja, 
        string sEmpresa, string sPuesto, string sTelefono, string sContacto, string sCorreo, string sPswd)
    {
        String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(sPswd.Trim(), "SHA1");
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        if (sTrabaja == "Si")
        {
            if (sFechaEgreso != "")
            {
                comm.CommandText = "INSERT INTO Solicitudes(sNoControl,sNombre,sCarreraID,sFechaIngreso,sFechaEgreso,sTitulado,sTrabaja,sEmpresa,sPuesto,sContacto,sTelefono,sCorreo,sPswd,sRoleID,sAceptado) VALUES(" +
                sNoControl + ",'" + sNombre + "'," + sCarreraID + ",'" + sFechaIngreso + "','" + sFechaEgreso + "','" + sTitulado + "','" + sTrabaja + "','" + sEmpresa + "','" + sPuesto + "','" + sContacto+ "','"
                + sTelefono +"','" + sCorreo + "','" + passwordHash + "',3,'P')";

            }
            else
            {
               comm.CommandText = "INSERT INTO Solicitudes(sNoControl,sNombre,sCarreraID,sFechaIngreso,sTitulado,sTrabaja,sEmpresa,sPuesto,sContacto,sTelefono,sCorreo,sPswd,sRoleID,sAceptado) VALUES(" +
               sNoControl + ",'" + sNombre + "'," + sCarreraID + ",'" + sFechaIngreso + "','" + sTitulado + "','" + sTrabaja + "','" + sEmpresa + "','" + sPuesto + "','" + sContacto + "','" + sTelefono +
               "','" + sCorreo + "','" + passwordHash + "',3,'P')";
            }
        }
        else
        {
            if (sFechaEgreso != "")
            {
                comm.CommandText = "INSERT INTO Solicitudes(sNoControl,sNombre,sCarreraID,sFechaIngreso,sFechaEgreso,sTitulado,sTrabaja,sTelefono,sCorreo,sPswd,sRoleID,sAceptado) VALUES(" +
                sNoControl + ",'" + sNombre + "'," + sCarreraID + ",'" + sFechaIngreso + "','" + sFechaEgreso + "','" + sTitulado + "','" + sTrabaja + "','" + sTelefono + "','" + sCorreo + "','"
                + passwordHash + "',3,'P')";
            }
            else
            {
                comm.CommandText = "INSERT INTO Solicitudes(sNoControl,sNombre,sCarreraID,sFechaIngreso,sTitulado,sTrabaja,sTelefono,sCorreo,sPswd,sRoleID,sAceptado) VALUES(" +
                sNoControl + ",'" + sNombre + "'," + sCarreraID + ",'" + sFechaIngreso + "','" + sTitulado + "','" + sTrabaja + "','" + sTelefono + "','" + sCorreo + "','"
                + passwordHash + "',3,'P')";
            }
        }
        clsGenericDataAccess.ExecuteNonQuery(comm);
    }

    public static DataTable buscaUsuarioSolicitudesID(string UsuarioID)
    {
        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT * FROM Solicitudes WHERE sNoControl = '" + UsuarioID + "'";
        return clsGenericDataAccess.ExecuteSelectCommand(comm);
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