<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="Lab3_b.BBB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            Inter your full name:
            <asp:TextBox ID="FIO" runat="server"></asp:TextBox>
        </div>
        <asp:RegularExpressionValidator
                              
                                ErrorMessage="Ошибка в ФИО"
                                ControlToValidate="FIO"
                                ValidationExpression="[а-яА-Я]+[а-яА-Я]+[а-яА-Я]"
                                runat="server"
                                Display="None"/>
                            <asp:RequiredFieldValidator runat="server" 
                                Display="None" 
                                ErrorMessage="Ошибка в ФИО" 
                                ControlToValidate="FIO"></asp:RequiredFieldValidator>

        <br />
        <div>
            Inter your Birthday:
            <asp:TextBox ID="birshtDay" runat="server"></asp:TextBox>
        </div>
        <asp:RangeValidator
                                ID="BirthdayValidator"
                                Text="Дата рождения"
                                ErrorMessage="Ошибка в дате рождения"
                                ControlToValidate="birshtDay"
                                runat="server" />
                            <asp:RequiredFieldValidator runat="server"
                                Display="None"
                                ErrorMessage="Дата рождения"
                                ControlToValidate="birshtDay"></asp:RequiredFieldValidator>
        <br />

        <div>
            Inter your email:
            <asp:TextBox ID="email" Type="email"  ValidationGroup="1" runat="server"></asp:TextBox>
        </div>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="RegularExpressionValidator"
            ValidationGroup="1" 
            ControlToValidate="email" 
            ValidationExpression="\S+@\S+\.\S+"
            Display="Static" 
            ForeColor="Red"></asp:RegularExpressionValidator>
        <br />

        <div>
             Inter your summa:
            <asp:TextBox ID="sum" runat="server"></asp:TextBox>
        </div>

        <asp:RangeValidator runat="server" ID="SumValidator" Type="Integer"
                                Display="Static" 
                                ControlToValidate="sum" 
                                ErrorMessage="Ошибка в сумме" 
                                MinimumValue="1000" MaximumValue="2000">  </asp:RangeValidator>   
         <asp:RequiredFieldValidator runat="server" 
                                 Display="None"
                                ErrorMessage="Ошибка в сумме" 
                                ControlToValidate="sum"></asp:RequiredFieldValidator>
        <br />
        <div>
             Inter your password:
            <asp:TextBox ID="password" Type="password" runat="server"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator runat="server" Display="None" 
                                    ErrorMessage="Ошибка в пароле" 
                                    ControlToValidate="password"></asp:RequiredFieldValidator>
        <asp:CustomValidator runat="server" 
                                    Display="None" 
                                    ErrorMessage="Ошибка в пароле" 
                                    ControlToValidate="password"
                                    OnServerValidate="OnServerValidate"></asp:CustomValidator>
        <br />
         <asp:Button ID="Button" Text="Submit" runat="server" Width="120px" Height="20px" style="background:lightpink; margin-left:30px" />
         <asp:ValidationSummary ID="valSum"
                                                   DisplayMode="BulletList"
                                                   EnableClientScript="true"
                                                   HeaderText="Обнаружены ошибки в следующих полях:"
                                                   runat="server" />
    </form>
</body>
</html>
