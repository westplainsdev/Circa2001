<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MainTemplate.Master" AutoEventWireup="true"
    CodeBehind="EmployeeSearch.aspx.cs" Inherits="Project.Web.EmployeeSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>
        Employee Query</h3>
    <asp:TextBox ID="uxEmployeeNumber" runat="server" Width="35" />
    <asp:Button ID="uxSubmit" runat="server" Text="Submit" OnClick="uxSubmit_Onclick" />
    <asp:Button ID="uxReset" runat="server" Text="Reset" OnClick="uxReset_Onclick" />
    <asp:Panel ID="uxEmployeePanel" runat="server" Visible="false">
        <h3>
            Employee Details</h3>
        <asp:Literal ID="uxEmployeeDisplay" runat="server" />
    </asp:Panel>
    <asp:Literal ID="uxMessage" runat="server" />
</asp:Content>
