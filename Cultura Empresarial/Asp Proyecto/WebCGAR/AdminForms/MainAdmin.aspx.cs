using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AdminForms_MainAdmin : System.Web.UI.Page
{
    public int totalSeleccionados = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable T = ClsSolicitudes.leerSolicitudes();

        if (T.Rows.Count > 0)
        {
            grd_Solicitudes.DataSource = T;
            grd_Solicitudes.DataBind();

            for (int i = 0; i < T.Rows.Count; i++)
            {
                grd_Solicitudes.Rows[i].Cells[2].Text = T.Rows[i][0].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[3].Text = T.Rows[i][1].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[4].Text = T.Rows[i][2].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[5].Text = T.Rows[i][3].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[6].Text = T.Rows[i][4].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[7].Text = T.Rows[i][5].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[8].Text = T.Rows[i][6].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[9].Text = T.Rows[i][8].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[10].Text = T.Rows[i][9].ToString().Trim();
                grd_Solicitudes.Rows[i].Cells[11].Text = T.Rows[i][10].ToString().Trim();
            }
        }
    }

    protected void grd_Solicitudes_DataBound(object sender, EventArgs e)
    {

    }

    protected void cmbPaginacion_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void grd_Solicitudes_PreRender(object sender, EventArgs e)
    {
        lblTotalClientes.Text = Convert.ToString(grd_Solicitudes.Rows.Count);
    }

    /*protected void btnQuitarSeleccionados_Click(object sender, EventArgs e)
    {
        CheckBox chkE;

        for (int i = 0; i < grd_Solicitudes.Rows.Count; i++)
        {
            chkE = (CheckBox)grd_Solicitudes.Rows[i].FindControl("chkEliminar");

            if (chkE.Checked == true)
            {
                grd_Solicitudes.DeleteRow(i);
            }
        }
    }*/

    protected void grd_Solicitudes_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        CheckBox chkN;
        DataRow R;

        DataTable T = new DataTable();
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");
        T.Columns.Add("");

        for (int x = 0; x < grd_Solicitudes.Rows.Count; x++)
        {
            if (x != e.RowIndex)
            {
                chkN = (CheckBox)grd_Solicitudes.Rows[x].FindControl("chkEliminar");

                R = T.NewRow();
                R[0] = chkN.Text; //grd_Solicitudes.Rows[x].Cells[0].Text;
                R[1] = grd_Solicitudes.Rows[x].Cells[2].Text;
                R[2] = grd_Solicitudes.Rows[x].Cells[3].Text;
                R[3] = grd_Solicitudes.Rows[x].Cells[4].Text;
                R[4] = grd_Solicitudes.Rows[x].Cells[5].Text;
                R[5] = grd_Solicitudes.Rows[x].Cells[6].Text;
                R[6] = grd_Solicitudes.Rows[x].Cells[7].Text;
                R[7] = grd_Solicitudes.Rows[x].Cells[8].Text;
                R[8] = grd_Solicitudes.Rows[x].Cells[9].Text;
                R[9] = grd_Solicitudes.Rows[x].Cells[10].Text;
                R[10] = grd_Solicitudes.Rows[x].Cells[11].Text;
                T.Rows.Add(R);
            }
        }
        grd_Solicitudes.DataSource = T;
        grd_Solicitudes.DataBind();

        for (int x = 0; x < T.Rows.Count; x++)
        {
            chkN = (CheckBox)grd_Solicitudes.Rows[x].FindControl("chkEliminar");
            grd_Solicitudes.Rows[x].Cells[2].Text = T.Rows[x][1].ToString();
            grd_Solicitudes.Rows[x].Cells[3].Text = T.Rows[x][2].ToString();
            grd_Solicitudes.Rows[x].Cells[4].Text = T.Rows[x][3].ToString();
            grd_Solicitudes.Rows[x].Cells[5].Text = T.Rows[x][4].ToString();
            grd_Solicitudes.Rows[x].Cells[6].Text = T.Rows[x][5].ToString();
            grd_Solicitudes.Rows[x].Cells[7].Text = T.Rows[x][6].ToString();
            grd_Solicitudes.Rows[x].Cells[8].Text = T.Rows[x][7].ToString();
            grd_Solicitudes.Rows[x].Cells[9].Text = T.Rows[x][8].ToString();
            grd_Solicitudes.Rows[x].Cells[10].Text = T.Rows[x][9].ToString();
            grd_Solicitudes.Rows[x].Cells[11].Text = T.Rows[x][10].ToString();
        }
    }

    protected void btnAceptarSeleccionados_Click(object sender, EventArgs e)
    {
        DataTable T = ClsDepartamentos.buscaDepartamento();
        string idDep;

        if (T.Rows.Count > 0)
        {
            for (int i = 0; i < T.Rows.Count; i++)
            {
                if (grd_Solicitudes.Rows[i].Cells[10].ToString().Trim() == T.Rows[i][1].ToString().Trim())
                {
                    idDep = T.Rows[i][0].ToString().Trim();
                }
            }
        }


        foreach (GridViewRow row in grd_Solicitudes.Rows)
        {
            CheckBox chk = (CheckBox)row.FindControl("chkEliminar");

            if (chk.Checked)
            {
                lblinfo.Text = " ¡Solicitud Aceptada! "; lblinfo.CssClass = "label label-success";
            }
            else
            {
                lblinfo.Text = " ¡Se ha producido un error al intentar modificar la solicitud! "; lblinfo.CssClass = "label label-danger";
            }
        }
        /*for (int i = 0; i < grd_Solicitudes.Rows.Count; i++)
        {
            CheckBox chk = (CheckBox)grd_Solicitudes.Rows[i].FindControl("chkEliminar");
            if (chk.Checked)
            {
                lblinfo.Text = " ¡Solicitud Aceptada! "; lblinfo.CssClass = "label label-success";
            }
            else
            {
                lblinfo.Text = " ¡Se ha producido un error al intentar modificar la solicitud! "; lblinfo.CssClass = "label label-danger";
            }
        }*/
        //lblinfo.Text = " ¡Solicitud Aceptada! "; lblinfo.CssClass = "label label-success";

        //lblinfo.Text = " ¡Se ha producido un error al intentar modificar la solicitud! "; lblinfo.CssClass = "label label-danger";
    }
}