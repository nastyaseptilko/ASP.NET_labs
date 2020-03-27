<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <div>
            <asp:Button Text="Our new test button" runat="server" OnClick="TestButton_Click" Height="88px" Width="231px" />
        </div>
        
        <div>
            <asp:Label Text="Nothing yet" runat="server" ID="testLabel"/>
        </div>
        <div>
            <asp:TextBox runat="server"  Text="Hello world!" Height="20px" ID="textBox"/>
        </div>
        <div> 
            <asp:CheckBox Text="Check" runat="server" AutoPostBack="true" OnCheckedChanged="TestCheckbox_CheckedChanged" />
        </div>
        <div> 
            <asp:DropDownList runat="server" Height="40px" ID="values">
                <asp:ListItem Text="number 1" />
                <asp:ListItem Text="number 2 " />
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label Text="" runat="server" ID="stateLabel" />
        </div>
    </div>

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
