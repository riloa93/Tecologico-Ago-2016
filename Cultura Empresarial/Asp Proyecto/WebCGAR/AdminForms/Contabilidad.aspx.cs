using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminForms_Contabilidad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grdData.DataSource = ClsContabilidad.leeContabilidad();
        grdData.DataBind();
    }

    protected void grdData_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        cmbTipoOrden.SelectedIndex = cmbTipoOrden.Items.IndexOf(cmbTipoOrden.Items.FindByText(grdData.Rows[e.NewSelectedIndex].Cells[1].Text));
        txtPO.Text = grdData.Rows[e.NewSelectedIndex].Cells[2].Text;
        txtNoOrden.Text = grdData.Rows[e.NewSelectedIndex].Cells[3].Text;
        txtSemana.Text = grdData.Rows[e.NewSelectedIndex].Cells[4].Text;
        txtAsignado.Text = grdData.Rows[e.NewSelectedIndex].Cells[5].Text;
        txtVendedor.Text = grdData.Rows[e.NewSelectedIndex].Cells[6].Text;
        txtEmpresa.Text = grdData.Rows[e.NewSelectedIndex].Cells[7].Text;
        txtCliente.Text = grdData.Rows[e.NewSelectedIndex].Cells[8].Text;
        txtProyecto.Text = grdData.Rows[e.NewSelectedIndex].Cells[9].Text;
        txtCantidad.Text = grdData.Rows[e.NewSelectedIndex].Cells[10].Text;
        txtPrecioUnitario.Text = grdData.Rows[e.NewSelectedIndex].Cells[19].Text;
        txtPrecioTotal.Text = grdData.Rows[e.NewSelectedIndex].Cells[20].Text;
        txtFechaReq.Text = Convert.ToDateTime(grdData.Rows[e.NewSelectedIndex].Cells[17].Text).ToShortDateString();
        txtFechaEntrega.Text = grdData.Rows[e.NewSelectedIndex].Cells[18].Text;
        cmbStatusCont.SelectedIndex = cmbStatusCont.Items.IndexOf(cmbStatusCont.Items.FindByText(grdData.Rows[e.NewSelectedIndex].Cells[21].Text));
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        if (txtProyecto.Text != "" || txtVendedor.Text != "" || txtAsignado.Text != "" || txtCliente.Text != "" || txtEmpresa.Text != "" || txtPO.Text != "")
        {
            grdData.DataSource = ClsContabilidad.buscaPoNombreByLike(txtProyecto.Text, txtVendedor.Text, txtAsignado.Text, txtCliente.Text, txtEmpresa.Text, txtPO.Text);
            grdData.DataBind();
        }
        else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa el nombre del proyecto, el vendedor, la asignación, el cliente, "+
            "la empresa o el No. de PO que deseas buscar.');", true);
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtPO.Text != "")
        {
            DataTable T = ClsContabilidad.buscaPoID(txtPO.Text);
            if (T.Rows.Count == 0)
            {
                if (txtPO.Text != "" && txtNoOrden.Text != "" && txtSemana.Text != "" && txtAsignado.Text != "" && txtVendedor.Text !="" &&
                    txtEmpresa.Text != "" && txtCliente.Text != "" && txtProyecto.Text != "" && txtCantidad.Text != "" && txtFechaReq.Text != "" &&
                    txtFechaEntrega.Text != "" && txtPrecioUnitario.Text != "" && txtPrecioTotal.Text != "")
                {
                    ClsContabilidad.insertaPo(cmbTipoOrden.SelectedItem.Text.Trim(), txtPO.Text, txtNoOrden.Text, txtSemana.Text, txtAsignado.Text, txtVendedor.Text, txtEmpresa.Text, txtCliente.Text, txtProyecto.Text,
                        txtCantidad.Text, txtFechaReq.Text, txtFechaEntrega.Text, txtPrecioUnitario.Text, txtPrecioTotal.Text, cmbStatusCont.SelectedItem.Text.Trim());
                    txtPO.Text = ""; txtNoOrden.Text = ""; txtSemana.Text = ""; txtAsignado.Text = ""; txtVendedor.Text = ""; txtEmpresa.Text = ""; txtCliente.Text = ""; txtProyecto.Text = ""; txtCantidad.Text = ""; txtFechaReq.Text = ""; txtFechaEntrega.Text = ""; txtPrecioUnitario.Text = ""; txtPrecioTotal.Text = "";
                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa todos los campos requeridos.');", true);
            }
            else
            {
                if (txtPO.Text != "" && txtNoOrden.Text != "" && txtSemana.Text != "" && txtAsignado.Text != "" && txtVendedor.Text != "" &&
                    txtEmpresa.Text != "" && txtCliente.Text != "" && txtProyecto.Text != "" && txtCantidad.Text != "" && txtFechaReq.Text != "" &&
                    txtFechaEntrega.Text != "" && txtPrecioUnitario.Text != "" && txtPrecioTotal.Text != "")
                {
                    if (txtFechaReq.Text != "" && txtFechaEntrega.Text != "")
                    {
                        ClsContabilidad.modificaPo(cmbTipoOrden.SelectedItem.Text.Trim(), txtPO.Text, txtNoOrden.Text, txtSemana.Text, txtAsignado.Text, txtVendedor.Text, txtEmpresa.Text, txtCliente.Text, txtProyecto.Text,
                            txtCantidad.Text, txtFechaReq.Text, txtFechaEntrega.Text, txtPrecioUnitario.Text, txtPrecioTotal.Text, cmbStatusCont.SelectedItem.Text.Trim());
                        txtPO.Text = ""; txtNoOrden.Text = ""; txtSemana.Text = ""; txtAsignado.Text = ""; txtVendedor.Text = ""; txtEmpresa.Text = ""; txtCliente.Text = ""; txtProyecto.Text = ""; txtCantidad.Text = ""; txtFechaReq.Text = "";
                        txtFechaEntrega.Text = ""; txtPrecioUnitario.Text = ""; txtPrecioTotal.Text = "";
                    }
                    else
                        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Verifica las fechas del PO.');", true);
                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa todos los campos requeridos.');", true);
            }
            grdData.DataSource = ClsContabilidad.leeContabilidad();
            grdData.DataBind();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El Po ha sido guardado.');", true);
        }
        else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Verifique que el campo No. Po contenga información.');", true);
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtPO.Text != "")
        {
            ClsContabilidad.eliminaPo(txtPO.Text);
            grdData.DataSource = ClsContabilidad.leeContabilidad();
            grdData.DataBind();
            txtPO.Text = ""; txtNoOrden.Text = ""; txtSemana.Text = ""; txtAsignado.Text = ""; txtVendedor.Text = ""; txtEmpresa.Text = ""; txtCliente.Text = ""; txtProyecto.Text = ""; txtCantidad.Text = ""; txtFechaReq.Text = "";
            txtFechaEntrega.Text = ""; txtPrecioUnitario.Text = ""; txtPrecioTotal.Text = "";
            grdData.SelectedIndex = -1;
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El PO ha sido eliminado.');", true);
        }
        else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Selecciona el Número de PO que deseas eliminar.');", true);
    }

    protected void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
    {
        txtPrecioTotal.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecioUnitario.Text)).ToString();
    }
}