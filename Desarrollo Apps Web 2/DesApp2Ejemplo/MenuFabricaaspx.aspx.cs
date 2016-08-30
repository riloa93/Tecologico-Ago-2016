using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class MenuFabricaaspx : System.Web.UI.Page
{
    DataTable T = clsLinea.buscaLineas();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (T.Rows.Count > 0)
            {
                grdDatos.DataSource = T;
                grdDatos.DataBind();
            }
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtLineaID.Text == "" && txtNombre.Text == "" && cmbSBU.Text == "")
        {

        }
        else
        {
            clsLinea.inserta_linea(txtLineaID.Text, txtNombre.Text, cmbSBU.Text);
            txtLineaID.Text = ""; txtNombre.Text = ""; cmbSBU.SelectedValue = "1";
            grdDatos.DataSource = T;
            grdDatos.DataBind();
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtLineaID.Text == "" && txtNombre.Text == "" && cmbSBU.Text == "")
        {

        }
        else
        {
            clsLinea.elimina_linea(txtLineaID.Text);
            txtLineaID.Text = ""; txtNombre.Text = ""; cmbSBU.SelectedValue = "1";
            grdDatos.DataSource = T;
            grdDatos.DataBind();
        }
    }

    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        if (txtLineaID.Text == "" && txtNombre.Text == "" && cmbSBU.Text == "")
        {

        }
        else
        {
            clsLinea.actualiza_linea(txtLineaID.Text,txtNombre.Text,cmbSBU.SelectedValue);
            txtLineaID.Text = ""; txtNombre.Text = ""; cmbSBU.SelectedValue = "1";
            grdDatos.DataSource = T;
            grdDatos.DataBind();
        }
    }
}