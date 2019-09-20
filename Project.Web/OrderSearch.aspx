<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainTemplate.Master" AutoEventWireup="true"
    CodeBehind="OrderSearch.aspx.cs" Inherits="Project.Web.OrderSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        Order Search</h3>
    <p>
        <asp:TextBox ID="uxCustomerID" runat="server" />
        <asp:Button ID="uxSearch" runat="server" OnClick="uxSearch_Click" Text="Search" /></p>
    <asp:GridView ID="uxCustomerOrders" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:hyperlinkfield datatextfield="OrderID" datanavigateurlfields="OrderID" datanavigateurlformatstring="~\OrderDetails.aspx?OrderID={0}" headertext="Order ID" />
            <asp:BoundField DataField="OrderDate" HeaderText="Order Date" DataFormatString="{0:MM-dd-yyyy}" />
            <asp:BoundField DataField="RequiredDate" HeaderText="Required Date" DataFormatString="{0:MM-dd-yyyy}" />
            <asp:BoundField DataField="ShippedDate" HeaderText="Shipped Date" DataFormatString="{0:MM-dd-yyyy}" />
            <asp:BoundField DataField="ShippersName" HeaderText="Shippers Name" />
        </Columns>
    </asp:GridView>
</asp:Content>
