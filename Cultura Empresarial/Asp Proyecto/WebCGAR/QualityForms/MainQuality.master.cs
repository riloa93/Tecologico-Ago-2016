using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class QualityForms_MainQuality : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
