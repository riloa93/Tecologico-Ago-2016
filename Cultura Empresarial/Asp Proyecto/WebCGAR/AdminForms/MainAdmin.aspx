<%@ Page Title="" Language="C#" MasterPageFile="~/AdminForms/AdminMaster.master" AutoEventWireup="true" CodeFile="MainAdmin.aspx.cs" Inherits="AdminForms_MainAdmin" %>

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

    <div class="row" style="margin-top:8%;">
        <h3>
            <span style="float:left"><asp:Label ID="lblinfo" runat="server"></asp:Label></span>
            <span style="float:right"><small>Total Solicitudes:</small><asp:Label ID="lblTotalClientes" runat="server" CssClass="label label-warning"></asp:Label></span>
        </h3>
        <p>&nbsp;</p><p>&nbsp;</p>
        <asp:GridView ID="grd_Solicitudes" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered bs-table" Font-Bold="False" OnDataBound="grd_Solicitudes_DataBound" OnPreRender="grd_Solicitudes_PreRender" OnRowDeleting="grd_Solicitudes_RowDeleting">
            <EditRowStyle BackColor="#FFFFCC" />
            <EmptyDataRowStyle CssClass="table table-bordered" ForeColor="Red" />
            <HeaderStyle BackColor="#337AB7" Font-Bold="True" ForeColor="White" />
            <emptydatatemplate>
            ¡No hay solicitudes seleccionadas!  
            </emptydatatemplate>

             <%--Paginador...--%>        
            <PagerTemplate>
                <div class="row" style="margin-top: 20px;">
                    <div class="col-lg-1" style="text-align: right;">
                        <h5><asp:Label ID="MessageLabel" Text="Ir a la pág." runat="server" /></h5>
                    </div>
                    <div class="col-lg-1" style="text-align: left;">
                        <h3><asp:DropDownList ID="cmbPaginacion" Width="50px" AutoPostBack="true" OnSelectedIndexChanged="cmbPaginacion_SelectedIndexChanged" runat="server" CssClass="form-control" /></h3>
                    </div>
                    <div class="col-lg-10" style="text-align: right;">
                        <h3><asp:Label ID="CurrentPageLabel" runat="server" CssClass="label label-warning" /></h3>
                    </div>
                </div>
            </PagerTemplate>  

            <Columns>
                <%--CheckBox para seleccionar varios registros...--%>
                <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="70px">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkEliminar" runat="server" AutoPostBack="False"/>
                    </ItemTemplate>
                    <HeaderStyle Width="70px"></HeaderStyle>
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                </asp:TemplateField>            
 
            <%--botones de acción sobre los registros...--%>
                
                <asp:CommandField ButtonType="Button" DeleteText="Negar" ShowCancelButton="False" ShowDeleteButton="True">
                <ControlStyle CssClass="btn btn-danger" />
                </asp:CommandField>

                <asp:TemplateField HeaderText="No. de empleado" ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="50px"></asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre completo" ItemStyle-HorizontalAlign="Center" HeaderStyle-Width="450px"></asp:TemplateField>
                <asp:TemplateField HeaderText="Seguro Social"></asp:TemplateField>
                <asp:TemplateField HeaderText="Dirección"></asp:TemplateField>
                <asp:TemplateField HeaderText="Télefono"></asp:TemplateField>
                <asp:TemplateField HeaderText="Correo Electrónico"></asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha de ingreso"></asp:TemplateField>
                <asp:TemplateField HeaderText="Contraseña"></asp:TemplateField>
                <asp:TemplateField HeaderText="Role"></asp:TemplateField>
                <asp:TemplateField HeaderText="Departamento"></asp:TemplateField>
            </Columns>
        </asp:GridView>

        <p style="text-align: center;">
            <asp:LinkButton ID="btnAceptarSeleccionados" runat="server" CssClass="btn btn-lg btn-info" OnClientClick="return confirm('¿Quitar cliente/s de la lista?');" OnClick="btnAceptarSeleccionados_Click"><span class="glyphicon glyphicon-ok"></span>&nbsp; Aceptar Solicitudes seleccionadas</asp:LinkButton>
        </p>
    </div>
</asp:Content>

