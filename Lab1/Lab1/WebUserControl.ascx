<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>

        <div style="display: flex; flex-direction: column; max-width: 200px; margin-bottom: 20px;">
    <asp:Label runat="server">Фамилия</asp:Label>
    <asp:TextBox runat="server" ID="surname" /><br />
    <asp:Label runat="server">Имя</asp:Label>
    <asp:TextBox runat="server" ID="name" /><br />
    <asp:Label runat="server">Отчество</asp:Label>
    <asp:TextBox runat="server" ID="father_name" /><br />
    <asp:Label runat="server">День рождения</asp:Label>
    <asp:TextBox runat="server" ID="birthday" /><br />
    <asp:Label runat="server">Пол</asp:Label>
    <asp:RadioButtonList ID="sex" runat="server">
        <asp:ListItem Value="1" runat="server" Text="мужской" />
        <asp:ListItem Value="0" runat="server" Text="женский" />
    </asp:RadioButtonList>
    <br />
    <asp:Label runat="server">Факультет</asp:Label>
    <asp:DropDownList runat="server" ID="faculties">
        <asp:ListItem>ФИТ</asp:ListItem>
        <asp:ListItem>ТОВ</asp:ListItem>
        <asp:ListItem>ХТиТ</asp:ListItem>
    </asp:DropDownList><br />
    <asp:Label runat="server">Группа</asp:Label>
    <asp:TextBox runat="server" ID="group" />
    <br />
    <asp:Label runat="server">Год поступления</asp:Label>
    <asp:TextBox runat="server" ID="year" />
    <asp:Button ID="submit" UseSubmitBehavior="false" ValidationGroup="v1" runat="server" Text="go"/>
    <asp:Button ID="cancel" UseSubmitBehavior="false" CausesValidation="false" runat="server" Text="Отмена" />
    
</div>

<asp:RequiredFieldValidator ID="RequiredFieldValidatorSName" runat="server" 
                            ErrorMessage="Введите фамилию"
                            ControlToValidate="surname"  
                            ValidationGroup="v1"
                            Display="None">
    
</asp:RequiredFieldValidator>
<asp:RangeValidator ID="RangeValidatorGroup" runat="server" 
                            ErrorMessage="Номер группы 1-100"
                            ControlToValidate="group" 
                            MaximumValue="100" 
                            MinimumValue="1" 
                            ValidationGroup="v1" 
                            Type="Integer" 
                            Display="None">
</asp:RangeValidator>
<asp:ValidationSummary ValidationGroup="v1"
                       DisplayMode="BulletList"
                       EnableClientScript="true"
                       HeaderText="Обнаружены ошибки в следующих полях:"
                       runat="server" />
  


