using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminForms_Departamentos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*if (!IsPostBack)
        {
            if (User.Identity.IsAuthenticated)
            {
                DataTable T = clsUsuarios.buscaUsuarioID(User.Identity.Name);
                this.Master.lblNombreControl.Text = T.Rows[0][1].ToString();
                grdData.DataSource = clsRoles.leeRoles();
                grdData.DataBind();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Usuario no identificado ');", true);
                Response.Redirect("Default.aspx");
            }
        }*/

        grdData.DataSource = ClsDepartamentos.leeDepartamentos();
        grdData.DataBind();
    }

    protected void grdData_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        txtID.Text = grdData.Rows[e.NewSelectedIndex].Cells[1].Text;
        txtDescripcion.Text = grdData.Rows[e.NewSelectedIndex].Cells[2].Text;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        bool id = false;
        if (txtID.Text != "" && txtDescripcion.Text != "")
        {
            DataTable T = ClsDepartamentos.buscaDepartamento(txtID.Text);
            if (T.Rows.Count == 0)
            {
                if (grdData.Rows.Count == Convert.ToInt32(txtID.Text) - 1)
                {
                    ClsDepartamentos.insertaDepartamento(txtID.Text, txtDescripcion.Text);
                    id = true;
                }
            }
            else
            {
                ClsDepartamentos.modificaDepartamento(txtID.Text, txtDescripcion.Text);
                id = true;
            }

            txtID.Text = "";
            grdData.DataSource = ClsDepartamentos.leeDepartamentos();
            grdData.DataBind();

            if (id) ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El departamento ha sido guardado.');", true);
            else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El ID del departamento no es consecutivo.');", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: No debe de haber campos vacíos.');", true);
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtID.Text != "" && txtDescripcion.Text != "")
        {
            int Row = ClsDepartamentos.eliminaDepartamento(txtID.Text);
            if (Row == 1)
            {
                grdData.DataSource = ClsDepartamentos.leeDepartamentos();
                grdData.DataBind();
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El departamento ha sido eliminado.');", true);
            }
            else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El departamento está siendo utilizado y no puede ser eliminado.');", true);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: No debe de haber campos vacíos.');", true);
        }
    }
}