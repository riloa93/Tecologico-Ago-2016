<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="tipo_contenido" content="text/html;" http-equiv="content-type" charset="utf-8" />
    <title>Login</title>
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body class="backgnd_Login">
    <form id="form1" runat="server">
        <div class="hero">
            <img class="logos" src="img/CAAR.jpg" />
            <hgroup>
                <h1>Somos Creativos</h1>
                <h3>Infórmate de nuestros proyectos</h3>
            </hgroup>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <span class="glyphicon glyphicon-lock"></span>&nbsp;Iniciar Sesión
                        </div>
                        <div class="panel-body">
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                                </div>
                            </div><br /><br />
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <asp:TextBox ID="txtPsw" runat="server" CssClass="form-control" TextMode="Password" placeholder="Contraseña"></asp:TextBox>
                                </div>
                            </div>
                            <br /><br />
                            <div class="form-group last">
                                <div class="col-sm-offset-3 col-sm-9">
                                    <asp:Button ID="btnSuccess" runat="server" Text="Ingresar" CssClass="btn btn-success btn-sm" OnClick="btnSuccess_Click" />
                                    <asp:Button ID="btnChange" runat="server" Text="Cambiar Contraseña" CssClass="btn btn-default btn-sm" />
                                </div><br />
                            </div>
                        </div>
                        <div class="panel-footer">
                            No eres usuario? <asp:LinkButton ID="lnkRegistrarse" runat="server">Regístrate aquí</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="js/jquery-1.10.2.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
