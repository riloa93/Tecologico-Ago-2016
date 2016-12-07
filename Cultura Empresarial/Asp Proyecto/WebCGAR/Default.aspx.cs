using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSuccess_Click(object sender, EventArgs e)
    {
        string ChkPwr = ClsEmpleados.CheckPassword(txtPsw.Text, txtEmail.Text);
        if (ChkPwr != "")
        {
            string[] R = ChkPwr.Split(',');
            if (R[3] == "A")
            {
                FormsAuthenticationTicket Authticket = new FormsAuthenticationTicket(1,
                R[1], DateTime.Now, DateTime.Now.AddMinutes(10), false, R[0], FormsAuthentication.FormsCookiePath);

                string encTicket = FormsAuthentication.Encrypt(Authticket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                if (R[0] == "IT") Response.Redirect("~/AdminForms/MainAdmin.aspx");
                else if (R[0] == "Ensamble") Response.Redirect("~/AssemblyForms/MainAssembly.aspx");
                else if (R[0] == "Contabilidad") Response.Redirect("~/ContabilityForms/MainContability.aspx");
                else if (R[0] == "Diseño") Response.Redirect("~/DesignForms/MainDesign.aspx");
                else if (R[0] == "Produccion") Response.Redirect("~/Production/MainProduction.aspx");
                else if (R[0] == "Compras") Response.Redirect("~/PurchaseForms/MainPurchase.aspx");
                else if (R[0] == "Calidad") Response.Redirect("~/QualityForms/MainQuiality.aspx");
                else if (R[0] == "Ventas") Response.Redirect("~/SalesForms/MainSales.aspx");
            }
            else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: El usuario no está autorizado para acceder.');", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: El usuario y/o contraseña no son correctos.');", true);
        }
    }
}