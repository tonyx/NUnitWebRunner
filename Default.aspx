<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="NunitWebRunner._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Nunit Test Results</h2>
    <asp:Panel ID="TestNamesPanel" runat="server">
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
    </asp:Panel>
    <asp:Table ID="Table1" runat="server">
    </asp:Table>

<%--    <asp:Label ID="Label1" runat="server" Text="TheLabel"></asp:Label>--%><%--    <asp:Image ID="Image1" runat="server" ImageUrl="~/img/passed.png" --%><%--        style="height: 16px" />--%>

    <asp:Table ID="Table" runat="server">
    </asp:Table>
</asp:Content>
