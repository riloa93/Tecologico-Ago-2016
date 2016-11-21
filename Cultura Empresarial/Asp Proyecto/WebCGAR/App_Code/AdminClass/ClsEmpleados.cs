using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Web.Security;

public class ClsEmpleados
{
    public static string CheckPassword(string Password, string Usuario)
    {// "SELECT rNombre,UsuarioID,uNombre,uPwr FROM Usuarios U, Roles R WHERE UsuarioID = '" + Usuario + "' AND U.RoleID = R.RoleID";
        string Result;

        DbCommand comm = clsGenericDataAccess.CreateCommand();
        comm.CommandText = "SELECT rDescripcion,EmpleadoID,sNombre,sPswd FROM Solicitudes U, Roles R WHERE sCorreo ='"+ Usuario +"' AND 1 = R.rRoleID";
        DataTable T = clsGenericDataAccess.ExecuteSelectCommand(comm);
        if (T.Rows.Count > 0)
        {
            String passwordHash = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Trim(), "SHA1");
            //if (passwordHash == T.Rows[0][3].ToString())
            if(Password == T.Rows[0][3].ToString())
            {
                return Result = T.Rows[0][0].ToString() + "," + T.Rows[0][1].ToString() + "," + T.Rows[0][3].ToString() + ",T," + T.Rows[0][2].ToString();
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