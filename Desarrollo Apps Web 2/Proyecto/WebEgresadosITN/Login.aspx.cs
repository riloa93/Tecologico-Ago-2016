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
        if (!IsPostBack)
        {
            //cmbDepartamentos.DataTextField = "dDescripcion";
            //cmbDepartamentos.DataValueField = "dDepartamentoID";
            //cmbDepartamentos.DataSource = ClsDepartamentos.buscaDepartamentoIdNombre();
            //cmbDepartamentos.DataBind();
        }
    }

    protected void btnRegistrarse_Click(object sender, EventArgs e)
    {
        if (txtNoControl.Text != "" && txtNombre.Text != "")
        {
            //DataTable T = ClsEmpleados.buscaEmpleadoID(txtEmpleadoID.Text);
            //if (T.Rows.Count == 0)
            //{
            //    if (txtEmpleadoID.Text != "" && txtNombre.Text != "" && txtSeguro.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" &&
            //        txtCorreo.Text != "" && txtFechaIngreso.Text != "" && txtPswd.Text != "" && cmbDepartamentos.Text != "")
            //    {
            //        ClsEmpleados.insertaEmpleado(txtEmpleadoID.Text, txtNombre.Text, txtSeguro.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtFechaIngreso.Text, cmbDepartamentos.SelectedItem.Text, txtPswd.Text);
            //        txtEmpleadoID.Text = ""; txtNombre.Text = ""; txtSeguro.Text = ""; txtDireccion.Text = ""; txtTelefono.Text = ""; txtCorreo.Text = "";
            //        txtFechaIngreso.Text = ""; txtFehaSalida.Text = ""; txtPswd.Text = "";
            //    }
            //    else
            //        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa todos los campos requeridos.');", true);
            //}
            //else
            //{
            //    if (txtEmpleadoID.Text != "" && txtNombre.Text != "" && txtSeguro.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" &&
            //        txtCorreo.Text != "" && cmbDepartamentos.Text != "")
            //    {
            //        if (txtFechaIngreso.Text != "")
            //        {
            //            ClsEmpleados.modificaEmpleado(txtEmpleadoID.Text, txtNombre.Text, txtSeguro.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtFechaIngreso.Text, txtFehaSalida.Text, cmbDepartamentos.SelectedItem.Text, txtPswd.Text);
            //            txtEmpleadoID.Text = ""; txtNombre.Text = ""; txtSeguro.Text = ""; txtDireccion.Text = ""; txtTelefono.Text = ""; txtCorreo.Text = "";
            //            txtFechaIngreso.Text = ""; txtFehaSalida.Text = ""; txtPswd.Text = "";
            //        }
            //        else
            //            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Verifica la fecha de ingreso del empleado.');", true);
            //    }
            //    else
            //        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa todos los campos requeridos.');", true);
            //}
            //grdData.DataSource = ClsEmpleados.leeEmpleados();
            //grdData.DataBind();
            //ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El empleado ha sido guardado.');", true);
        }
        else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Verifique que los campos No. de Control y Nombre contengan información.');", true);
    }

    protected void btnRestablecer_Click(object sender, EventArgs e)
    {

    }

    protected void btnSsn_Click(object sender, EventArgs e)
    {

    }
}