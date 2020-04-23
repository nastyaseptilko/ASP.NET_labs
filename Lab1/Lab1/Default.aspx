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

    

  

</asp:Content>
