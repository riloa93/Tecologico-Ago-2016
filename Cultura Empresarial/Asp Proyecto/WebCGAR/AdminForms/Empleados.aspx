<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMaster.master" AutoEventWireup="true" CodeFile="Empleados.aspx.cs" Inherits="AdminForms_Empleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/Main_Admin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container" style="margin-left: 20%;">
        <div style="width: 150px; height: 150px; position: absolute; display: inline-block;">
            <asp:Image ID="imgEmpresa" runat="server" ImageUrl="~/img/CAAR.jpg" Width="150px" Height="150px" />
            <div class="row" style="position: absolute; margin-left: 120%; margin-top: -70%;">
                <asp:Label ID="lblNombreEmpresa" runat="server" Text="Este es el nombre de la empresa" Font-Bold="True" Width="500%" Font-Names="Calibri" Font-Size="30pt" ForeColor="Black"></asp:Label>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="panel panel-default" style="margin-top: 165px;">
            <div class="panel-heading" style="text-align: center; font-family: Calibri; font-size: 20px;">Datos del empleado:</div>
            <div class="panel-body" style="margin-left: -13%;">
                <div class="row" style="margin-left: 23%; margin-top: 1%">
                    <div class="row">
                        <asp:Label ID="lblEmpleadoID" runat="server" Text="No. de empleado:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtEmpleadoID" runat="server" CssClass="form-control" Width="58"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="revID" runat="server" ErrorMessage="El ID es númerico." ControlToValidate="txtEmpleadoID" ValidationExpression="^[0-9]*" ForeColor="White" CssClass="label label-danger" Font-Names="Calibri" Font-Size="12"></asp:RegularExpressionValidator>&nbsp;
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Width="374"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="lblNSS" runat="server" Text="No. Seguro Social:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtSeguro" runat="server" CssClass="form-control" Width="115"></asp:TextBox>&nbsp;
                        <asp:Label ID="lblDireccion" runat="server" Text="Dirección:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" Width="446"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="lblTelefono" runat="server" Text="Télefono:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Width="110px" TextMode="Phone"></asp:TextBox>
                        <asp:Label ID="lblCorreo" runat="server" Text="Correo:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" Width="250px" TextMode="Email"></asp:TextBox>
                        <asp:Label ID="lblFechaIn" runat="server" Text="Fecha Ingreso:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtFechaIngreso" runat="server" CssClass="form-control" Width="150px" TextMode="Date"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row">
                        <asp:Label ID="lblFechaSal" runat="server" Text="Fecha Salida:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtFehaSalida" runat="server" CssClass="form-control" Width="150px" TextMode="Date"></asp:TextBox>
                        <asp:Label ID="lblDepartamento" runat="server" Text="Departamento:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:DropDownList ID="cmbDepartamentos" runat="server" CssClass="btn btn-default dropdown-toggle" AutoPostBack="True">
                            <asp:ListItem Value="1">Administrador</asp:ListItem>
                            <asp:ListItem Value="2">Contabilidad</asp:ListItem>
                            <asp:ListItem Value="3">Gerencia</asp:ListItem>
                            <asp:ListItem Value="4">Ensamble</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblContrasena" runat="server" Text="Contraseña:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtPswd" runat="server" CssClass="form-control" Width="150px" TextMode="Password"></asp:TextBox>
                    </div>
                    <br />
                    <br />
                </div>
                <div class="row" style="margin-left:46%;">
                    <asp:LinkButton ID="btnGuardar" runat="server" CssClass="btn btn-primary" OnClick="btnGuardar_Click"><span class="glyphicon glyphicon-pencil"></span>Guardar</asp:LinkButton>&nbsp; &nbsp; &nbsp;<asp:LinkButton ID="btnEliminar" runat="server" CssClass="btn btn-danger" OnClick="btnEliminar_Click"><span class="glyphicon glyphicon-remove"></span>Eliminar</asp:LinkButton>
                    &nbsp; &nbsp; &nbsp;<asp:LinkButton ID="btnBuscar" runat="server" CssClass="btn btn-info" OnClick="btnBuscar_Click"><span class="glyphicon glyphicon-search"></span>Buscar</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    <div>
        <asp:GridView ID="grdData" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="grdData_SelectedIndexChanging">
            <Columns>
                <asp:CommandField SelectText="Cargar" ShowSelectButton="True" ButtonType="Button">
                    <ControlStyle CssClass="btn btn-info" />
                    <HeaderStyle CssClass="label-primary" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="80px"></ItemStyle>
                </asp:CommandField>
                <asp:BoundField DataField="EmpleadoID" HeaderText="No. Empleado">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle" Width="80px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eNombre" HeaderText="Nombre">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" Width="265px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eSeguro" HeaderText="Seguro Social">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" Width="100px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eDireccion" HeaderText="Direcci&#243;n">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" Width="250px" VerticalAlign="Middle"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eTelefono" HeaderText="Tel&#233;fono">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eCorreo" HeaderText="Correo electr&#243;nico">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eFechaIngreso" HeaderText="Ingreso">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eFechaSalida" HeaderText="Salida">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="eDepartamento" HeaderText="Departamento">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="ePswd" HeaderText="Contrase&#241;a">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

