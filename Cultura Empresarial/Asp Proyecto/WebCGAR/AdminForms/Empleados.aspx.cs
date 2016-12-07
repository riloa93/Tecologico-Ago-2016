using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminForms_Empleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            cmbDepartamentos.DataTextField = "dDescripcion";
            cmbDepartamentos.DataValueField = "dDepartamentoID";
            cmbDepartamentos.DataSource = ClsDepartamentos.buscaDepartamentoIdNombre();
            cmbDepartamentos.DataBind();

            grdData.DataSource = ClsEmpleados.leeEmpleados();
            grdData.DataBind();
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtEmpleadoID.Text != "" && txtNombre.Text != "")
        {
            DataTable T = ClsEmpleados.buscaEmpleadoID(txtEmpleadoID.Text);
            if (T.Rows.Count == 0)
            {
                if (txtEmpleadoID.Text != "" && txtNombre.Text != "" && txtSeguro.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" &&
                    txtCorreo.Text != "" && txtFechaIngreso.Text != "" && txtPswd.Text != "" && cmbDepartamentos.Text != "")
                {
                    ClsEmpleados.insertaEmpleado(txtEmpleadoID.Text, txtNombre.Text, txtSeguro.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtFechaIngreso.Text, cmbDepartamentos.SelectedItem.Text, txtPswd.Text);
                    txtEmpleadoID.Text = ""; txtNombre.Text = ""; txtSeguro.Text = ""; txtDireccion.Text = ""; txtTelefono.Text = ""; txtCorreo.Text = "";
                    txtFechaIngreso.Text = ""; txtFehaSalida.Text = ""; txtPswd.Text = "";
                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa todos los campos requeridos.');", true);
            }
            else
            {
                if (txtEmpleadoID.Text != "" && txtNombre.Text != "" && txtSeguro.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" &&
                    txtCorreo.Text != "" && cmbDepartamentos.Text != "")
                {
                    if (txtFechaIngreso.Text != "")
                    {
                        ClsEmpleados.modificaEmpleado(txtEmpleadoID.Text, txtNombre.Text, txtSeguro.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, txtFechaIngreso.Text, txtFehaSalida.Text, cmbDepartamentos.SelectedItem.Text, txtPswd.Text);
                        txtEmpleadoID.Text = ""; txtNombre.Text = ""; txtSeguro.Text = ""; txtDireccion.Text = ""; txtTelefono.Text = ""; txtCorreo.Text = "";
                        txtFechaIngreso.Text = ""; txtFehaSalida.Text = ""; txtPswd.Text = "";
                    }
                    else
                        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Verifica la fecha de ingreso del empleado.');", true);
                }
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa todos los campos requeridos.');", true);
            }
            grdData.DataSource = ClsEmpleados.leeEmpleados();
            grdData.DataBind();
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El empleado ha sido guardado.');", true);
        }
        else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Verifique que los campos No. Empleado y Nombre contengan información.');", true);
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtEmpleadoID.Text != "")
        {
            ClsEmpleados.eliminaEmpleado(txtEmpleadoID.Text);
            grdData.DataSource = ClsEmpleados.leeEmpleados();
            grdData.DataBind();
            txtEmpleadoID.Text = ""; txtNombre.Text = ""; txtSeguro.Text = ""; txtDireccion.Text = ""; txtTelefono.Text = ""; txtCorreo.Text = "";
            txtFechaIngreso.Text = ""; txtFehaSalida.Text = ""; txtPswd.Text = "";
            grdData.SelectedIndex = -1;
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('El empleado ha sido eliminado.');", true);
        }
        else ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Selecciona al Empleado que deseas eliminar.');", true);
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        grdData.DataSource = ClsEmpleados.buscaEmpleadoNombreByLike(txtNombre.Text);
        grdData.DataBind();
    }

    protected void grdData_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        txtEmpleadoID.Text = grdData.Rows[e.NewSelectedIndex].Cells[1].Text;
        txtNombre.Text = grdData.Rows[e.NewSelectedIndex].Cells[2].Text;
        txtSeguro.Text = grdData.Rows[e.NewSelectedIndex].Cells[3].Text;
        txtDireccion.Text = grdData.Rows[e.NewSelectedIndex].Cells[4].Text;
        txtTelefono.Text = grdData.Rows[e.NewSelectedIndex].Cells[5].Text;
        txtCorreo.Text = grdData.Rows[e.NewSelectedIndex].Cells[6].Text;

        cmbDepartamentos.SelectedIndex = cmbDepartamentos.Items.IndexOf(cmbDepartamentos.Items.FindByText(grdData.Rows[e.NewSelectedIndex].Cells[3].Text));
    }
}