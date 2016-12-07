using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;

public partial class SalesForms_MainSales : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable T = ClsEmpleados.buscaEmpleadoID(HttpContext.Current.User.Identity.Name);
            lblNameSes.Text = T.Rows[0][1].ToString();
            lblUsrSes.Text = T.Rows[0][5].ToString();
        }
    }

    protected void lnkSes_Click(object sender, EventArgs e)
    {
        HttpCookie myCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
        if (myCookie != null)
        {
            myCookie.Expires = DateTime.Now;
            Response.Cookies.Set(myCookie);
            Response.Redirect("~/Default.aspx");
        }
    }
}
