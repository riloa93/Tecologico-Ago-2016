<%@ Page Title="" Language="C#" MasterPageFile="~/Fabrica.master" AutoEventWireup="true" CodeFile="MenuFabricaaspx.aspx.cs" Inherits="MenuFabricaaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 130px;
        }
        .auto-style2 {
            width: 448px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
        <table style="width: 100%;">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">Linea ID</td>
            <td>
                <asp:TextBox ID="txtLineaID" runat="server" OnTextChanged="TextBox1_TextChanged" Width="134px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                Nombre</td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="299px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">
                SBU</td>
            <td>
                <asp:DropDownList ID="cmbSBU" runat="server" Width="150px" AutoPostBack="True">
                    <asp:ListItem Value="1">Pruebas</asp:ListItem>
                    <asp:ListItem Value="2">Produccion</asp:ListItem>
                    <asp:ListItem Value="3">Empaque</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;
            </td>
            <td class="auto-style1">
            </td>
            <td>                
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"/>
            </td>
        </tr>
                        <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:GridView ID="grdDatos" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
                </td>
            </tr>
    </table>
</asp:Content>
