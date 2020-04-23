<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<%@ Register TagPrefix="chn" TagName="WebUserControl" Src="./WebUserControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lab3_e</title>
</head>
<body>
    <form id="form1" runat="server" >
       <chn:WebUserControl runat="server"  Surname="Септилко" Name="Анастасия" Fathername="Антоновна" Input="Otpravit" />
    </form>
</body>
</html>

