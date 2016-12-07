<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMaster.master" AutoEventWireup="true" CodeFile="Departamentos.aspx.cs" Inherits="AdminForms_Departamentos" %>

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

    <div class="row" style="margin-left: 40%; margin-top:9%">
        <asp:Label ID="lblPresentacion" runat="server" Text="Departamentos" Font-Bold="True" Font-Names="Calibri" Font-Size="40pt"></asp:Label>

        <div class="row" style="margin-left:5%;">
            <asp:Label ID="lblID" runat="server" Text="Role ID: " CssClass="label" Font-Size="15pt" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtID" runat="server" CssClass="form-control" Width="50px"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblRoleD" runat="server" Text="Role: " CssClass="label" Font-Size="15pt" ForeColor="Black"></asp:Label>&nbsp;<asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control" Width="150px"></asp:TextBox>
        </div>
        <div class="row" style="margin-left:10%; margin-top:4%;">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" /> &nbsp;
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
        </div>
    </div>

    <div class="row" style="margin-left:42%; margin-top:5%;">
        <asp:GridView ID="grdData" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="grdData_SelectedIndexChanging">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True">
                <ControlStyle CssClass="btn btn-info" />
                <HeaderStyle CssClass="label-primary" HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                </asp:CommandField>
                <asp:BoundField DataField="dDepartamentoID" HeaderText="Role ID">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="dDescripcion" HeaderText="Role">
                <HeaderStyle CssClass="label-primary" Font-Size="13pt" HorizontalAlign="Center" VerticalAlign="Middle" ForeColor="White" />
                <ItemStyle HorizontalAlign="Center" Width="150px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

