<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Mult</h2>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        <button ID="Multi"  OnClick="SendAjaxPOST()" value="Mult">Mult</button>
    </p>

    <script>
        function SendAjaxPOST() {
            var xmlHttp;
            xmlHttp = null;

            xmlHttp = new XMLHttpRequest();

            var a = WebForm_GetElementById("MainContent_TextBox1").value;
            var b = WebForm_GetElementById("MainContent_TextBox2").value;
            if (xmlHttp != null) {
                xmlHttp.onreadystatechange = function () {
                    if (xmlHttp.readyState == 4) {
                        alert(xmlHttp.responseText);
                    }
                }

                xmlHttp.open("POST", "http://localhost:50311/multi.gso", true);
                xmlHttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
                xmlHttp.send('ParmA=' + a + '&ParmB=' + b);
                
            }
        }
    </script>
</asp:Content>
