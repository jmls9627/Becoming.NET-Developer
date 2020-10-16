<%@ Page Title="" Language="C#" MasterPageFile="~/DinerMax3000MasterPage.master" AutoEventWireup="true" CodeFile="Menus.aspx.cs" Inherits="Menus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" Runat="Server">
   
    <asp:GridView ID="gvMenu" OnRowDataBound="gvMenu_RowDataBound" AutoGenerateColumns="false" DataSourceID="odsMenu" runat="server">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <%#Eval("Name") %>
                <asp:GridView ID="gvMenuItems" runat="server"></asp:GridView>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>

    </asp:GridView>
    
    <asp:ObjectDataSource ID="odsMenu" runat="server" SelectMethod="GetAllMenus" TypeName="DinerMax3000.Business.Menu"></asp:ObjectDataSource>
    <p>
    </p>
</asp:Content>

