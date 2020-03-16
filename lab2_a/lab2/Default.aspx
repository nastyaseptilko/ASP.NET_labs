<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Get" Width="100" runat="server" OnClick="Button1_Click" Text="Get" />
        <asp:Button ID="Post" Width="100" runat="server" OnClick="Post_Click" Text="Post"/>
        <asp:Button ID="Put" Width="100" runat="server" OnClick="Put_Click" Text="Put" />
        <asp:Button ID="ERROR" Width="100" runat="server" OnClick="ERROR_Click" Text="Error" />
    </div>
    &nbsp;
</asp:Content>
