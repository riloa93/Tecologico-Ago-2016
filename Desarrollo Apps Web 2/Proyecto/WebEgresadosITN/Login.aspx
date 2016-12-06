<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="css/style.css"/>
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css"/>
</head>

<body>
    <header>
        <div style="text-align: center;">
            <img src="img/Logos.jpg" style="width: 80%;" />
        </div>
    </header>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row" id="pwd-container">
                <div class="col-md-4"></div>

                <div class="col-md-4">
                    <section class="login-form">
                            <asp:TextBox ID="txtcontrol" runat="server" CssClass="form-control form_cntrl input-lg" placeholder="No. Control"></asp:TextBox>
                            <asp:TextBox ID="txtPassw" runat="server" CssClass="form-control form_cntrl input-lg" placeholder="Contraseña" TextMode="Password" Style="left: 0px; top: 0px"></asp:TextBox>
                            <asp:Button ID="btnSsn" runat="server" Text="Iniciar Sesión" CssClass="btn btn-lg btn-primary btn_ses btn-block" OnClick="btnSsn_Click"/>
                            <br />
                            <div class="text-center">
                                <asp:HyperLink ID="hplCrear" runat="server" CssClass="links_a">Crear cuenta</asp:HyperLink>&nbsp; |
                                <asp:HyperLink ID="hplPass" runat="server" CssClass="links_a">Olvidé mi contraseña</asp:HyperLink>
                            </div>
                        <!--MODAL ENVIAR SOLICITUD-->
                        <div>
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:Panel ID="ModalRegistro" runat="server" CssClass="modal-content body_modal">
                                <div class="modalpopup">
                                    <asp:Button ID="btnClose" runat="server" Text="X" CssClass="close"></asp:Button>
                                    <asp:Label ID="lblTitulo" runat="server" Text="&lt;span&gt;&lt;i class=&quot;glyphicon glyphicon-user&quot;&gt;&lt;/i&gt;&lt;/span&gt;&amp;nbsp;  Enviar Solicitud" CssClass="encabezado_modal"></asp:Label>
                                </div>
                                <br />
                                <div class="container">
                                    <div class="row" style="padding: 19px;">
                                        <div class="col-xs-12 col-sm-12 col-md-12 modal_content">
                                            <!--ESTA SECCION ES DE LA INFORMACION UNIVERSITARIA-->
                                            <div class="text-center">
                                                <asp:Label ID="lblUni" runat="server" Text="Información universitaria"></asp:Label>
                                            </div>

                                            <div class="col-xs-6 col-md-6">
                                                <asp:TextBox ID="txtNoControl" placeholder="No. Control" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-xs-6 col-md-6">
                                                <asp:TextBox ID="txtNombre" placeholder="Nombre Completo" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>

                                            <div class="col-xs-3 col-md-3">
                                                <asp:Label ID="lblCarrera" runat="server" Text="Carrera"></asp:Label>
                                            </div>
                                            <div class="col-xs-3 col-md-3">
                                                <asp:Label ID="lblTitulado" runat="server" Text="Titulado"></asp:Label>
                                            </div>
                                            <div class="col-xs-3 col-md-3">
                                                <asp:Label ID="LblIngreso" runat="server" Text="Fecha de ingreso"></asp:Label>
                                            </div>
                                            <div class="col-xs-3 col-md-3">
                                                <asp:Label ID="lblEgreso" runat="server" Text="Fecha de egreso"></asp:Label>
                                            </div>

                                            <div class="col-xs-3 col-md-3">
                                                <!--Carrera ID y Nombre DropDownList-->
                                                <asp:DropDownList ID="cmbCarrera" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <div class="col-xs-3 col-md-3">
                                                <!--Titulado DropDownList-->
                                                <asp:DropDownList ID="cmbTitlulado" runat="server" CssClass="form-control">
                                                    <asp:ListItem Value="0">Si</asp:ListItem>
                                                    <asp:ListItem Value="1">No</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-xs-1 col-md-1">
                                                <!--Fecha Ingreso-->
                                                <asp:DropDownList ID="cmbDiaIng" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <div class="col-xs-1 col-md-1">
                                                <asp:DropDownList ID="cmbMesIng" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <div class="col-xs-1 col-md-1">
                                                <asp:DropDownList ID="cmbAnoIng" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>

                                            <div class="col-xs-1 col-md-1">
                                                <!--Fecha Egreso-->
                                                <asp:DropDownList ID="cmbDiaEgr" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <div class="col-xs-1 col-md-1">
                                                <asp:DropDownList ID="cmbMesEgr" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <div class="col-xs-1 col-md-1">
                                                <asp:DropDownList ID="cmbAnoEgr" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>

                                            <!--SECCION PROFESIONAL-->
                                            <div class="text-center">
                                                <asp:Label ID="lblEmpresas" runat="server" Text="Información profesional"></asp:Label>
                                            </div>
                                            <div class="col-xs-12 col-md-12">
                                                <asp:Label ID="lblTrabaja" runat="server" Text="Trabaja"></asp:Label>
                                            </div>
                                            <div class="col-xs-1 col-md-1">
                                                <!--Trabaja DropDownList-->
                                                <asp:DropDownList ID="cmbTrabaja" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <div class="col-xs-4 col-md-4">
                                                <asp:TextBox ID="txtEmpresa" placeholder="Empresa" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-xs-3 col-md-3">
                                                <asp:TextBox ID="txtPuesto" placeholder="Puesto" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-xs-4 col-md-4">
                                                <asp:TextBox ID="txtContacto" placeholder="Contacto" runat="server" CssClass="form-control"></asp:TextBox>
                                            </div>
                                            <div class="col-xs-2 col-md-2"></div>
                                            <div class="col-xs-3 col-md-3">
                                                <asp:TextBox ID="txtTelefono" placeholder="Teléfono" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                                            </div>
                                            <div class="col-xs-5 col-md-5">
                                                <asp:TextBox ID="txtCorreo" placeholder="Correo electrónico" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                                            </div>
                                            <div class="col-xs-2 col-md-2"></div>
                                            <br />
                                            <div class="col-xs-12 col-md-12">
                                                <asp:Label ID="lblAccess" runat="server" Text="Acceso al sistema"></asp:Label>
                                            </div>
                                            <div class="col-xs-12 col-md-12">
                                                <asp:Label ID="lblRoles" runat="server" Text="Role en el sistema"></asp:Label>
                                            </div>
                                            <div class="col-xs-5 col-md-5">
                                                <asp:DropDownList ID="cmbRoles" runat="server" CssClass="form-control"></asp:DropDownList>
                                            </div>
                                            <div class="col-xs-4 col-md-4">
                                                <asp:TextBox ID="txtPaswd" placeholder="Clave de acceso" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                            </div>
                                            <div class="col-xs-4 col-md-4">
                                                
                                            </div>
                                            <!--RoleID Enviarlo-->
                                            <!--Aceptada o no la solicitud-->
                                        </div>
                                    </div>
                                    <div class="col-xs-3 col-md-3"></div>
                                    <div class="col-xs-6 col-md-6">
                                        <asp:Button ID="btnRegistrarse" runat="server" Text="Enviar Solicitud" CssClass="btn btn-lg btn-primary btn_ses btn-block" OnClick="btnRegistrarse_Click"></asp:Button>&nbsp;
                                    </div>
                                    <div class="col-xs-3 col-md-3"></div>
                                </div>
                            </asp:Panel>
                            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" CancelControlID="btnClose" PopupControlID="ModalRegistro" TargetControlID="hplCrear" BackgroundCssClass="modal_bkgrd"></ajaxToolkit:ModalPopupExtender>
                        </div>

                        <!--MODAL OLVIDE CONTRASENA-->
                        <div>
                            <asp:Panel ID="Modal_OlvidarC" runat="server" CssClass="modal-content body_modal">
                                <div class="modalpopup">
                                    <asp:Button ID="btnCerrarOlv" runat="server" Text="X" CssClass="close"></asp:Button>
                                    <asp:Label ID="lblTitOlvidar" runat="server" Text="&lt;span class=&quot;glyphicon glyphicon-question-sign&quot;&gt;&lt;/span&gt;&amp;nbsp; Olvidé Contraseña" CssClass="encabezado_modal"></asp:Label>
                                </div>
                                <br />
                                <div class="container">
                                    <div class="row" style="padding: 19px;">
                                        <div class="col-xs-12 col-sm-12 col-md-12 modal_content">
                                            <div>
                                                <!--ESTA SECCION ES DEL USUARIO-->
                                                <div class="col-xs-12 col-md-12 text-center">
                                                    <asp:Label ID="lblPreguntaOlv" runat="server" Text="Elige tú pregunta de seguridad"></asp:Label>
                                                </div>
                                                <div class="col-xs-6 col-md-6" style="margin-left:7%">
                                                    <!--Pregunta de seguridad-->
                                                    <asp:DropDownList ID="cmbPregSegOlv" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </div>
                                                <!--Respuesta-->
                                                <div class="col-xs-4 col-md-4">
                                                    <asp:TextBox ID="txtRespuestaSegOlv" placeholder="Respuesta" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                                <div class="col-xs-5 col-md-5" style="margin-left:7%">
                                                    <asp:TextBox ID="txtNoCtrlOlv" placeholder="No. Control" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                                <!--Nueva Contraseña-->
                                                <div class="col-xs-5 col-md-5">
                                                    <asp:TextBox ID="txtNuevaContraseña" placeholder="Nueva Contraseña" runat="server" CssClass="form-control"></asp:TextBox>
                                                </div>
                                                <!--RoleID Enviarlo-->
                                                <!--Aceptada o no la solicitud-->
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-xs-3 col-md-3"></div>
                                    <div class="col-xs-6 col-md-6">
                                        <asp:Button ID="btnRestablecer" runat="server" Text="Restablecer Contraseña" CssClass="btn btn-lg btn-primary btn_ses btn-block" OnClick="btnRestablecer_Click"></asp:Button>&nbsp;
                                    </div>
                                    <div class="col-xs-3 col-md-3"></div>
                                </div>
                            </asp:Panel>
                            <ajaxToolkit:ModalPopupExtender ID="ModalOlvidar" runat="server" CancelControlID="btnCerrarOlv" PopupControlID="Modal_OlvidarC" TargetControlID="hplPass" BackgroundCssClass="modal_bkgrd"></ajaxToolkit:ModalPopupExtender>
                        </div>
                         <!--FINAL MODAL OLVIDE CONTRASENA-->
                        <div class="form-links">
                            <a href="http://www.itnogales.edu.mx/">Tecnológico de Nogales</a>
                        </div>
                    </section>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>

    <script type="text/javascript" scr="js/login.js"></script>
    <script type="text/javascript" src="js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
</body>
</html>
