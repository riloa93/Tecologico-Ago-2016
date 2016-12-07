<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMaster.master" AutoEventWireup="true" CodeFile="Contabilidad.aspx.cs" Inherits="AdminForms_Contabilidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/Main_Admin.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
            <div class="panel-heading" style="text-align: center; font-family: Calibri; font-size: 20px;">Lista de contabilidad y producción de la empresa:</div>
            <div class="panel-body" style="margin-left: -13%;">
                <div class="row" style="margin-left: 23%; margin-top: 1%">
                    <div class="row" style="margin-left: -3%;">
                        <asp:Label ID="lblTipoOrd" runat="server" Text="Tipo de orden:" CssClass="label" Font-Names="Calibri" Font-Size="15pt" ForeColor="Black"></asp:Label>&nbsp;<asp:DropDownList ID="cmbTipoOrden" runat="server" CssClass="btn btn-default dropdown-toggle">
                            <asp:ListItem Value="0">PO</asp:ListItem>
                            <asp:ListItem Value="1">PP</asp:ListItem>
                            <asp:ListItem Value="2">GA-V</asp:ListItem>
                            <asp:ListItem Value="3">GA-D</asp:ListItem>
                            <asp:ListItem Value="4">GA-C</asp:ListItem>
                            <asp:ListItem Value="5">GA-P</asp:ListItem>
                            <asp:ListItem Value="6">GA-EM</asp:ListItem>
                            <asp:ListItem Value="7">GA-EE</asp:ListItem>
                            <asp:ListItem Value="8">GA-CA</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblPo" runat="server" Text="No. PO:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtPO" runat="server" CssClass="form-control" Width="80"></asp:TextBox>
                        <asp:Label ID="lblNoOrden" runat="server" Text="No. Orden:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtNoOrden" runat="server" CssClass="form-control" Width="80"></asp:TextBox>
                        <asp:Label ID="lblNoSemana" runat="server" Text="No. Semana:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtSemana" runat="server" CssClass="form-control" Width="80"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row" style="margin-left: -3%;">
                        <asp:Label ID="lblAsignadoA" runat="server" Text="Asignado a:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtAsignado" runat="server" CssClass="form-control" Width="305"></asp:TextBox>
                        <asp:Label ID="lblVendedor" runat="server" Text="Vendedor:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtVendedor" runat="server" CssClass="form-control" Width="291"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row" style="margin-left: -2.75%;">
                        <asp:Label ID="lblEmpresa" runat="server" Text="Empresa:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtEmpresa" runat="server" CssClass="form-control" Width="285px"></asp:TextBox>
                        <asp:Label ID="lblCliente" runat="server" Text="Cliente:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtCliente" runat="server" CssClass="form-control" Width="350px"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row" style="margin-left: -2.70%;">
                        <asp:Label ID="lblProyecto" runat="server" Text="Proyecto:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtProyecto" runat="server" CssClass="form-control" Width="536px"></asp:TextBox>
                        <asp:Label ID="lblCantidad" runat="server" Text="Cantidad:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtCantidad" runat="server" CssClass="form-control" Width="80px" TextMode="Number"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row" style="margin-left: -2.75%;">
                        <asp:Label ID="lblPrecioUn" runat="server" Text="Precio Unitario:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtPrecioUnitario" runat="server" CssClass="form-control" Width="126px" AutoPostBack="True" OnTextChanged="txtPrecioUnitario_TextChanged"></asp:TextBox>
                        <asp:Label ID="lblPrecioTo" runat="server" Text="Precio Total:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtPrecioTotal" runat="server" CssClass="form-control" Width="120px" AutoPostBack="True" ReadOnly="True"></asp:TextBox>
                        <asp:Label ID="lblStatus" runat="server" Text="Status Contable:" CssClass="label" Font-Names="Calibri" Font-Size="15pt" ForeColor="Black"></asp:Label>&nbsp;<asp:DropDownList ID="cmbStatusCont" runat="server" CssClass="btn btn-default dropdown-toggle">
                            <asp:ListItem Value="0">S. Facturar</asp:ListItem>
<asp:ListItem Value="1">Facturado</asp:ListItem>
                            <asp:ListItem Value="2"></asp:ListItem>
                            <asp:ListItem Value="3">Retenido</asp:ListItem>
                            <asp:ListItem Value="4">CanceladoFacturado P.</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br />
                    <div class="row" style="margin-left:6%;">
                        <asp:Label ID="lblFechaReq" runat="server" Text="Fecha Requisisión:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtFechaReq" runat="server" CssClass="form-control" Width="158px" TextMode="Date"></asp:TextBox>
                        <asp:Label ID="lblFechaEntrega" runat="server" Text="Fecha Entrega:" CssClass="label" Font-Names="Calibri" Font-Size="15" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtFechaEntrega" runat="server" CssClass="form-control" Width="158px" TextMode="Date"></asp:TextBox>
                    </div>
                    <br />
                    <div class="row" style="margin-left: 27%; margin-top: 2%; margin-bottom: 2%;">
                        <asp:LinkButton ID="btnGuardar" runat="server" CssClass="btn btn-primary" OnClick="btnGuardar_Click"><span class="glyphicon glyphicon-pencil"></span>Guardar</asp:LinkButton>&nbsp; &nbsp; &nbsp;<asp:LinkButton ID="btnEliminar" runat="server" CssClass="btn btn-danger" OnClick="btnEliminar_Click"><span class="glyphicon glyphicon-remove"></span>Eliminar</asp:LinkButton>
                        &nbsp; &nbsp; &nbsp;<asp:LinkButton ID="btnBuscar" runat="server" CssClass="btn btn-info" OnClick="btnBuscar_Click"><span class="glyphicon glyphicon-search"></span>Buscar</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="width: 105%; margin-left: -2%;">
        <asp:GridView ID="grdData" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="grdData_SelectedIndexChanging">
            <Columns>
                <asp:CommandField SelectText="Cargar" ShowSelectButton="True" ButtonType="Button">
                    <ControlStyle CssClass="btn btn-info" ForeColor="White"></ControlStyle>

                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="White"></HeaderStyle>

                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                </asp:CommandField>
                <asp:BoundField DataField="lTipoOrd" HeaderText="Tipo Orden">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle" Width="80px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lPo" HeaderText="PO">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" Width="265px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lNoOrden" HeaderText="No. Orden">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" Width="100px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lSemana" HeaderText="No. Semana">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" Width="250px" VerticalAlign="Middle"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lAsignado" HeaderText="Asignado">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lVendedor" HeaderText="Vendedor">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lEmpresa" HeaderText="Empresa">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lCliente" HeaderText="Cliente">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle" Width="100px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lProyecto" HeaderText="Proyecto">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lCantidad" HeaderText="Cantidad">
                    <HeaderStyle CssClass="label-primary" ForeColor="White" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lsVentas" HeaderText="Ventas">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lsCompras" HeaderText="Compras">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lsDiseno" HeaderText="Diseño">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lsProd" HeaderText="Producción">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lsEnsamble" HeaderText="Ensamble">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lsCalidad" HeaderText="Calidad">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lFechaRequisision" HeaderText="Fecha Requisisión" HtmlEncode="False">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lFechaEntrega" HeaderText="Fecha de Entrega" HtmlEncode="False">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="130px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lPrecioUnitario" HeaderText="Precio Unitario">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" Width="80px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lPrecioTotal" HeaderText="Precio Total">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="80px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lStatusCont" HeaderText="Status Contable">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="130px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

