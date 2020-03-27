<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="Lab3_b.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <!------------------------------------------------ TASK #1 ---------------------------------------------------------------------------------------------------------->
       <p style="margin-left:30px">Task number 1</p>
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="120px" Height="20px" style="margin-left:30px" ValidationGroup="g1"></asp:TextBox>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"  Width="120px" Height="20px" style="margin-left:30px" ValidationGroup="g1" ></asp:DropDownList>
        </div>
       
        <div>
            <asp:Button ID="Button1" runat="server" Text="Click me"  Width="120px" Height="20px" style="background:lightpink; margin-left:30px" ValidationGroup="g1" />
        </div>
    
         <hr>
            <br/ >
        <div>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                 ErrorMessage="RequiredFieldValidator" 
                 ControlToValidate="DropDownList1" 
                 ValidationGroup="g1" ForeColor="Red">No value entered DropDownList1</asp:RequiredFieldValidator>
        
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                  ErrorMessage="RequiredFieldValidator"
                  ControlToValidate="TextBox1" 
                  ValidationGroup="g1" ForeColor="Red">No value entered TextBox1</asp:RequiredFieldValidator>
        </div>
   
        <!------------------------------------------------ TASK #2 ---------------------------------------------------------------------------------------------------------->
        <p style="margin-left:30px">Task number 2</p>
        <div>
            <asp:TextBox ID="TextBox2" runat="server" Width="120px" Height="20px" style="margin-left:30px" ValidationGroup="g2"></asp:TextBox>
        </div>

          <div>
            <asp:TextBox ID="TextBox3Date" runat="server" Width="120px" Height="20px" style="margin-left:30px" ValidationGroup="g2"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="Button2" runat="server" Text="Click me"  Width="120px" Height="20px" style="background:lightpink; margin-left:30px" ValidationGroup="g2" />
        </div>
       
         <hr>
          <br/ >
        <div>
            <asp:RangeValidator runat="server"
                                    ValidationGroup="g2"
                                    Display="Dynamic" 
                                    ControlToValidate="TextBox2"
                                    Type="Integer" 
                                    ErrorMessage="Error in number.Value range exceeded" 
                                    MinimumValue="100"
                                    MaximumValue="200"
                                    ForeColor="Red">
                </asp:RangeValidator>
        </div>
        <div>
            <asp:RangeValidator runat="server"
                                    ValidationGroup="g2" 
                                    Display="Dynamic"
                                    ControlToValidate="TextBox3Date"
                                    ErrorMessage="Error in date.Incorrect date" 
                                    ID="DateValidator"
                                    Type="Date"
                                    ForeColor="Red">
                </asp:RangeValidator>
        </div>
        <!------------------------------------------------ TASK #3 ---------------------------------------------------------------------------------------------------------->
        <p style="margin-left:30px">Task number 3</p>
        <div>
            <asp:TextBox ID="TextBox4" runat="server" Width="120px" Height="20px" style="margin-left:30px" ValidationGroup="g3"></asp:TextBox>
        </div>

          <div>
            <asp:TextBox ID="TextBox5" runat="server" Width="120px" Height="20px" style="margin-left:30px" ValidationGroup="g3"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="Button3" runat="server" Text="Click me"  Width="120px" Height="20px" style="background:lightpink; margin-left:30px" ValidationGroup="g3" />
        </div>
      
         <hr/>
           <br/ >
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="Error comparing TextBox4&TextBox5"
            Operator="LessThan"
            ValidationGroup="g3" 
            Display="Static" 
            ForeColor="Red"
            ControlToValidate="TextBox4" 
            ControlToCompare="TextBox5" 
            Type="Date"></asp:CompareValidator>
       <!------------------------------------------------ TASK #4 ---------------------------------------------------------------------------------------------------------->
        <p style="margin-left:30px">Task number 4</p>

         <div>
            <asp:TextBox ID="TextBox6" runat="server" Width="120px" Height="20px" style="margin-left:30px" Type="email" ValidationGroup="g4"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="Button4" runat="server" Text="Click me"  Width="120px" Height="20px" style="background:lightpink; margin-left:30px" ValidationGroup="g4" />
        </div>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="RegularExpressionValidator"
            ValidationGroup="g4" 
            ControlToValidate="TextBox6" 
            ValidationExpression="\S+@\S+\.\S+"
            Display="Static" 
            ForeColor="Red"></asp:RegularExpressionValidator>
          <hr/>
        <br />
     
        <!------------------------------------------------ TASK #5 ---------------------------------------------------------------------------------------------------------->
       <p style="margin-left:30px">Task number 5</p>

         <div>
            <asp:TextBox ID="TextBox7" runat="server" TextMode="SingleLine" Width="120px" Height="20px" style="margin-left:30px" ValidationGroup="g5"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="Button5" runat="server" Text="Click me"  Width="120px" Height="20px" style="background:lightpink; margin-left:30px" ValidationGroup="g5" />
        </div>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            ErrorMessage="CustomValidator"
            Display="Static" 
            ForeColor="Red"
            OnServerValidate="MyHandler"
            ValidationGroup="g5"
            ControlToValidate="TextBox7" ></asp:CustomValidator>
            <!--ClientValidationFun="MyHandler"-->
            
       <script type="text/javascript">
            function (a, b) {
                b.IsValid = (b.value%2===0)
            }
        </script>
        <br />
        <hr/>
        <div>
         <a href="BBB.aspx" style=" border: 3px solid #666; margin-left:30px; text-decoration: none">Task number 6</a>
        </div>
        <br />
    </form>
   
</body>
</html>
