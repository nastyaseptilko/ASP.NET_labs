<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FFF.aspx.cs" Inherits="Lab3_c.FFF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lab3_c</title>
    <style type="text/css">
        #Select1 {
            width: 166px;
        }
        #Button_View{
            
            background: #fcd1eb;
            border-radius: 20px;
        }
         #ButtonChangeRotator{
            
            background: #b7efa0;
            border-radius: 20px;
        }
        .bgwizard {
           
            background-size: cover;
            background-repeat: no-repeat;
            background-position: 50% 50%;
        }

        .menuclass {
            font-size:1em;
            background-color: mediumpurple
        }
    </style>
</head>
<body>
    <form runat="server">
     <div>
        <asp:MultiView ID="MultiView" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                 <asp:Label ID="Label1" runat="server" Text="View1"></asp:Label>
                 <asp:Wizard ID="Wizard1" runat="server" Width="578px"
                         OnNextButtonClick="Wizard1_OnNextButtonClick" ActiveStepIndex="1" Height="230px" BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em">
                        <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Left" />
                        <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                        <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                        <SideBarStyle BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" BackColor="#7C6F57" />
                        <StepStyle BorderWidth="0px" ForeColor="#5D7B9D" />
                        <WizardSteps>
                            <asp:WizardStep ID="WizardStep1" runat="server" Title="TextBox">
                                <table class="bgwizard" style="min-width: 500px; min-height: 500px;">
                                    <tr>
                                        <td>Textbox</td>
                                        <td>
                                            <asp:TextBox runat="server" ID="WizardTextbox"></asp:TextBox></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="RadioButtonList">
                                <table>
                                    <tr>
                                        <td>RadioButtonList</td>
                                        <td>
                                            <asp:RadioButtonList runat="server" ID="WizardRadioButtonList">
                                                <asp:ListItem Selected="True" Text="Variant 1" Value="Variant 1" />
                                                <asp:ListItem Selected="False" Text="Variant 2" Value="Variant 2" />
                                                <asp:ListItem Selected="False" Text="Variant 3" Value="Variant 3" />
                                                <asp:ListItem Selected="False" Text="Variant 4" Value="Variant 4" />
                                                <asp:ListItem Selected="False" Text="Variant 5" Value="Variant 5" />
                                            </asp:RadioButtonList></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="CheckBoxList">
                                <table>
                                    <tr>
                                        <td>CheckBoxList</td>
                                        <td>
                                            <asp:CheckBoxList runat="server" ID="WizardCheckBoxList">
                                                <asp:ListItem Selected="True" Text="Variant 1" Value="Variant 1" />
                                                <asp:ListItem Selected="False" Text="Variant 2" Value="Variant 2" />
                                                <asp:ListItem Selected="False" Text="Variant 3" Value="Variant 3" />
                                                <asp:ListItem Selected="False" Text="Variant 4" Value="Variant 4" />
                                                <asp:ListItem Selected="False" Text="Variant 5" Value="Variant 5" />
                                            </asp:CheckBoxList></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="ListBox">
                                <table>
                                    <tr>
                                        <td>ListBox</td>
                                        <td>
                                            <asp:ListBox runat="server" ID="WizardListBox">
                                                <asp:ListItem Text="Variant 1" Value="Variant 1" />
                                                <asp:ListItem Text="Variant 2" Value="Variant 2" />
                                                <asp:ListItem Text="Variant 3" Value="Variant 3" />
                                                <asp:ListItem Text="Variant 4" Value="Variant 4" />
                                                <asp:ListItem Text="Variant 5" Value="Variant 5" />
                                            </asp:ListBox></td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Calendar">
                                <table>
                                    <tr>
                                        <td>Calendar</td>
                                        <td>
                                            <asp:Calendar runat="server" ID="WizardCalendar" 
                                                BackColor="#fcd1eb" BorderColor="Black"
                                                Height="250px" NextPrevFormat="FullMonth" Width="300px"></asp:Calendar>
                                        </td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Calendars">
                                <table>
                                    <tr>
                                        <td>ListBox</td>
                                        <td>
                                            <asp:Calendar runat="server" ID="WizardCalendars" OnDayRender="Calendars_DayRender" OnSelectionChanged="WizardCalendars_OnSelectionChanged" 
                                                BackColor="#fcd1eb" BorderColor="Black"
                                                Height="250px" NextPrevFormat="FullMonth" Width="300px"></asp:Calendar>
                                        </td>
                                    </tr>
                                </table>
                            </asp:WizardStep>
                            <asp:WizardStep runat="server" Title="Result">
                                <asp:Label runat="server" ID="WizardResult"></asp:Label>
                            </asp:WizardStep>


                        </WizardSteps>
                        <SideBarStyle VerticalAlign="Top" />

                    </asp:Wizard>

            </asp:View>
            <asp:View ID="View2" runat="server">
                 <asp:Label ID="Label2" runat="server" Text="View2"></asp:Label>
                 <asp:TreeView ID="TreeView" runat="server" ShowLines="True" 
                              OnSelectedNodeChanged="TreeView_OnSelectedNodeChanged">
                    <Nodes>
                        <asp:TreeNode Expanded="True" Text="1" Value="1" ShowCheckBox="False">
                            <asp:TreeNode Text="1.1" Value="1.1">
                                <asp:TreeNode ShowCheckBox="True" Text="1.1.1" Value="1.1.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.1.2" Value="1.1.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.1.3" Value="1.1.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode ImageUrl="../Images/Banners/4.jpg" Value="1.2">
                                <asp:TreeNode ShowCheckBox="True" Text="1.2.1" Value="1.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.2.2" Value="1.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.2.3" Value="1.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="1.3" Value="1.3">
                                <asp:TreeNode ShowCheckBox="True" Text="1.3.1" Value="1.3.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.3.2" Value="1.3.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="1.3.3" Value="1.3.3"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Expanded="True" Text="2" Value="2" ShowCheckBox="False">
                            <asp:TreeNode ShowCheckBox="True" Text="2.1" Value="2.1">
                                <asp:TreeNode ShowCheckBox="True" Text="2.1.1" Value="2.1.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.1.2" Value="2.1.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.1.3" Value="2.1.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode ShowCheckBox="True" Text="2.2" Value="2.2">
                                <asp:TreeNode ShowCheckBox="True" Text="2.2.1" Value="2.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.2.2" Value="2.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.2.3" Value="2.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode ShowCheckBox="True" Text="2.3" Value="2.3">
                                <asp:TreeNode ShowCheckBox="True" Text="2.3.1" Value="2.3.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.3.2" Value="2.3.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="2.3.3" Value="2.3.3"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Expanded="True" Text="3" ToolTip="Узел 3" Value="3" ShowCheckBox="False">
                            <asp:TreeNode Text="3.1" ToolTip="Узел 3.1" Value="3.1">
                                <asp:TreeNode ShowCheckBox="True" Text="3.1.1" Value="3.1.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.1.2" Value="3.1.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.1.3" Value="3.1.3"></asp:TreeNode>
                                </asp:TreeNode>
                            <asp:TreeNode Text="3.2" ToolTip="Узел 3.2" Value="3.2">
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.1" Value="3.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.2" Value="3.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.3" Value="3.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="3.3" ToolTip="Узел 3.3" Value="3.3">
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.1" Value="3.2.1"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.2" Value="3.2.2"></asp:TreeNode>
                                <asp:TreeNode ShowCheckBox="True" Text="3.2.3" Value="3.2.3"></asp:TreeNode>
                            </asp:TreeNode>
                        </asp:TreeNode>
                    </Nodes>
                </asp:TreeView>
                <asp:Button runat="server" ID="TreeViewButton" OnClick="TreeViewButton_OnClick" Text="Write selected"/>
                <asp:Label runat="server" ID="TreeViewResult"></asp:Label>

            </asp:View>
            <asp:View ID="View3" runat="server">
                 <asp:Label ID="Label3" runat="server" Text="View3"></asp:Label>
                 <asp:Menu runat="server" ID="Menu" CssClass="menuclass" StaticDisplayLevels="2" Font-Names="Verdana" Font-Size="1em" ForeColor="#284E98" OnMenuItemClick="Menu_itemClick" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Height="200px" StaticSubMenuIndent="10px">
                     <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                     <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                     <DynamicMenuStyle BackColor="#B5C7DE" />
                     <DynamicSelectedStyle BackColor="#507CD1" />
                     <Items>
                         <asp:MenuItem Text="Var 1">
                             <asp:MenuItem Text="Var 1.1" Value="Var 1.1">
                                 <asp:MenuItem Text="1.1.1" Value="1.1.1"></asp:MenuItem>
                                 <asp:MenuItem Text="1.1.2" Value="1.1.2"></asp:MenuItem>
                                 <asp:MenuItem Text="1.1.3" Value="1.1.3"></asp:MenuItem>
                             </asp:MenuItem>
                             <asp:MenuItem Text="Var 1.2" Value="Var 1.2">
                                 <asp:MenuItem Text="1.2.1" Value="1.2.1"></asp:MenuItem>
                                 <asp:MenuItem Text="1.2.2" Value="1.2.2"></asp:MenuItem>
                                 <asp:MenuItem Text="1.2.3" Value="1.2.3"></asp:MenuItem>
                             </asp:MenuItem>
                             <asp:MenuItem Text="Var 1.3" Value="Var 1.3"></asp:MenuItem>
                         </asp:MenuItem>
                         <asp:MenuItem Text="Var 2">
                             <asp:MenuItem Text="Var 2.1" Value="Var 2.1">
                                 <asp:MenuItem Text="2.1.1" Value="2.1.1"></asp:MenuItem>
                                 <asp:MenuItem Text="2.1.2" Value="2.1.2"></asp:MenuItem>
                                 <asp:MenuItem Text="2.1.3" Value="2.1.3"></asp:MenuItem>
                             </asp:MenuItem>
                             <asp:MenuItem Text="Var 2.2" Value="Var 2.2">
                                 <asp:MenuItem Text="2.2.1" Value="2.2.1"></asp:MenuItem>
                                 <asp:MenuItem Text="2.2.2" Value="2.2.2"></asp:MenuItem>
                                 <asp:MenuItem Text="2.2.3" Value="2.2.3"></asp:MenuItem>
                             </asp:MenuItem>
                         </asp:MenuItem>
                     </Items>
                     <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                     <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                     <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
                <asp:Label runat="server" ID="MenuResult" BackColor="#6699FF"></asp:Label>

            </asp:View>
        </asp:MultiView>
     </div>
    <div>
        <asp:Button Text="View_Click" Id="Button_View" runat="server" OnClick="View_Click" Height="40px" Width="160px" />
    </div>
         <br/>
        
        <div>
            <asp:AdRotator ID="AdRotator" style="width: 400px; height: 400px;" runat="server" AdvertisementFile="~/Rotator/AddRotator.xml" />
            <br />
            <asp:Button ID="ButtonChangeRotator" runat="server" Text="Change rotation" OnClick="ButtonChangeRotator_Click" Height="40px" Width="160px" />
        </div>
    </form>
</body>
</html>
