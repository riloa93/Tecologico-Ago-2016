using System;
using System.Collections.Generic;
using System.Data;
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
            cmbCarrera.DataTextField = "cNombre";
            cmbCarrera.DataValueField = "CarreraID";
            cmbCarrera.DataSource = ClsCarreras.leeCarreras();
            cmbCarrera.DataBind();

            cmbPreguntaSeguridad.DataTextField = "pDescripcion";
            cmbPreguntaSeguridad.DataValueField = "PreguntaID";
            cmbPreguntaSeguridad.DataSource = ClsPreguntasSeguridad.leePreguntas();
            cmbPreguntaSeguridad.DataBind();

            cmbPregSegOlv.DataTextField = "pDescripcion";
            cmbPregSegOlv.DataValueField = "PreguntaID";
            cmbPregSegOlv.DataSource = ClsPreguntasSeguridad.leePreguntas();
            cmbPregSegOlv.DataBind();
        }
    }

    protected void btnRegistrarse_Click(object sender, EventArgs e)
    {
        DataTable T = ClsUsuarios.buscaUsuarioSolicitudesID(txtNoControl.Text);
        if (T.Rows.Count == 0)
        {
            if (txtNoControl.Text != "" && txtNombre.Text != "" && txtFechaIngreso.Text != "" && cmbTitlulado.Text != "" &&
                txtCorreo.Text != "" && txtTelefono.Text != "" && txtPaswd.Text != "" && txtRespuesta.Text != "")
            {
                if (cmbTrabaja.SelectedValue == "0" && txtEmpresa.Text != "" && txtPuesto.Text != "" && txtContacto.Text != "")
                {
                   ClsUsuarios.AgregarSolicitud(txtNoControl.Text, txtNombre.Text, cmbCarrera.SelectedValue, txtFechaIngreso.Text, txtFechaEgreso.Text, cmbTitlulado.SelectedItem.ToString(),
                   cmbTrabaja.SelectedItem.ToString(), txtEmpresa.Text, txtPuesto.Text, txtTelefono.Text, txtContacto.Text, txtCorreo.Text, txtPaswd.Text);
                    txtNoControl.Text = ""; txtNombre.Text = ""; txtFechaIngreso.Text = ""; txtFechaEgreso.Text = ""; cmbTitlulado.SelectedValue = "0";
                    cmbTrabaja.SelectedValue = "0"; txtEmpresa.Text = ""; txtTelefono.Text = ""; txtCorreo.Text = ""; txtPaswd.Text = ""; txtPuesto.Text = "";
                    txtContacto.Text = ""; txtRespuesta.Text = "";

                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('La solicitud ha sido enviada; espera una respuesta.');", true);
                }
                else if(cmbTrabaja.SelectedValue == "1" && txtEmpresa.Text == "" && txtPuesto.Text == "" && txtContacto.Text == "")
                {
                   ClsUsuarios.AgregarSolicitud(txtNoControl.Text, txtNombre.Text, cmbCarrera.SelectedValue, txtFechaIngreso.Text, txtFechaEgreso.Text, cmbTitlulado.SelectedItem.ToString(),
                   cmbTrabaja.SelectedItem.ToString(), txtEmpresa.Text, txtPuesto.Text,txtTelefono.Text, txtContacto.Text, txtCorreo.Text, txtPaswd.Text);

                    txtNoControl.Text = ""; txtNombre.Text = ""; txtFechaIngreso.Text = ""; txtFechaEgreso.Text = ""; cmbTitlulado.SelectedValue = "0";
                    cmbTrabaja.SelectedValue = "0"; txtEmpresa.Text = ""; txtTelefono.Text = ""; txtCorreo.Text = ""; txtPaswd.Text = ""; txtPuesto.Text = "";
                    txtContacto.Text = ""; txtRespuesta.Text = "";

                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('La solicitud ha sido enviada; espera una respuesta.');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Debes llenar correctamente los campos requeridos.');", true);
                }
            }
            else
                //lblOperacion.CssClass = "label label-danger";
                //lblOperacion.Text = "<span class=\"glyphicon glyphicon-remove\"></span> &nbsp; Debes llenar correctamente los campos.";
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: Ingresa todos los campos requeridos.');", true);
        }
    }

    protected void btnRestablecer_Click(object sender, EventArgs e)
    {
        DataTable T = ClsUsuarios.buscaUsuarioSolicitudesID(txtNoControl.Text);
        if (T.Rows.Count == 0)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Error: El usuario no se ha encontrado en el sistema.');", true);
        }
    }

    protected void btnSsn_Click(object sender, EventArgs e)
    {

    }
}