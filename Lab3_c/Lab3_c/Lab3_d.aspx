<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab3_d.aspx.cs" Inherits="Lab3_c.Lab3_d" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" OnAsyncPostBackError="ScriptManager1_AsyncPostBackError" runat="server"></asp:ScriptManager>
        <script>
            const prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_initializeRequest(InitializeRequest);
            prm.add_endRequest(endRequest);

            function InitializeRequest(sender, args) {
                if (prm.get_isInAsyncPostBack()) {
                    args.set_cancel(true);
                }
            }

            function endRequest(sender, args) {
                if (args.get_error() != undefined) {
                    var errorMessage = args.get_error().message;
                    args.set_errorHandled(true);
                    alert(errorMessage);
                }
            }

            function AbortPostBack() {
                if (prm.get_isInAsyncPostBack()) {
                    prm.abortPostBack();
                }
            }
        </script>

        <asp:UpdatePanel runat="server" ID="UpdatePanel1">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" />
                <asp:Button ID="Button1" runat="server" Text="Get time" OnClick="Button1_OnClick"/>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdatePanel runat="server" ID="UpdatePanel2">
            <ContentTemplate>
                <asp:Label ID="Label2" Text="IsLong" runat="server" />
                <asp:CheckBox runat="server" ID="CheckBox1"/>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdatePanel runat="server" ID="UpdatePanel3">
            <ContentTemplate>
                <asp:RadioButtonList ID="Radio1" runat="server">
                    <asp:ListItem Value="1" Text="Date"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Time" Selected="True"></asp:ListItem>
                </asp:RadioButtonList>
            </ContentTemplate>
        </asp:UpdatePanel>

        <br/>


         <asp:UpdatePanel runat="server" ID="UpdatePanel5">
            <ContentTemplate>
                   <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                   <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                 <asp:Button ID="Button3" runat="server" Text=":)))))" OnClick="Button3_OnClick" />
            </ContentTemplate>
        </asp:UpdatePanel>

        <br/>


        Timers
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <asp:Timer ID="Timer1" runat="server" Interval="2000" OnTick="Timer1_Tick"></asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:Timer ID="Timer2" runat="server" Interval="4000" OnTick="Timer2_Tick"></asp:Timer>

        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer2" />
            </Triggers>
        </asp:UpdatePanel>
        
        <asp:UpdatePanel ID="UpdatePanel4" runat="server">
            <ContentTemplate>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_OnClick" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="UpdatePanel4">
            <ProgressTemplate>
                Loading...
                <input type="button" onclick="AbortPostBack()" value="отмена" />
            </ProgressTemplate>
        </asp:UpdateProgress>
    </form>
</body>
</html>
