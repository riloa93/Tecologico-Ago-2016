using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtNoCtrl.Value = "Hola Mundo";
        btnSesion.ServerClick += BtnSesion_ServerClick;
    }

    private void BtnSesion_ServerClick(object sender, EventArgs e)
    {
        password.Value = txtNoCtrl.Value;
    }
}