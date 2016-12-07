<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMaster.master" AutoEventWireup="true" CodeFile="Produccion.aspx.cs" Inherits="AdminForms_Produccion" %>

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

    <div style="margin-top:12%;">
        <asp:GridView ID="grdData" runat="server" AutoGenerateColumns="False">
            <Columns>
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
                <asp:BoundField DataField="lFechaRequisision" HeaderText="Fecha Requisisión">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="lFechaEntrega" HeaderText="Fecha de Entrega">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Width="130px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

