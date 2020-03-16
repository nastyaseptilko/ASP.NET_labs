<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_3a._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div>
      <p> Элемент HTMLInputReset&nbsp;
          <input id="Reset1" type="reset" value="reset"  runat="server" onserverclick="OnClick" />
      </p>  
    </div>

     <div>
      <p> Элемент HTMLInputButton&nbsp;
         <input id="button" type="button" value="button"  runat="server" onserverclick="OnClick" />
      </p>  
    </div>

     <div>
      <p> Элемент HTMLInputSubmit&nbsp;
         <input id="submit" type="submit" value="submit"  runat="server" onserverclick="OnClick" />
      </p>  
    </div>

     <div>
      <p> Элемент HTMLInputFile&nbsp;
          <input id="File1" type="file" />
      </p>  
    </div>

    <div>
      <p> Элемент HTMLInputText&nbsp;
          <input id="Text1" type="text"
               runat="server" onserverchange="Common_Onserverchange" onclick="return InputText_onclick()"/>
      </p>  
    </div>
    
    <div>
      <p> Элемент HTMLInputPassword&nbsp;
          <input id="Password1" type="password" runat="server" onserverchange="Common_Onserverchange" />
      </p>  
    </div>

    <div>
      <p> Элемент HTMLInputCheckBox&nbsp;
          <input id="Checkbox1" type="checkbox" runat="server" onserverchange="Common_Onserverchange" />
      </p>  
    </div>

    <div>
      <p> Элемент HTMLInputRadioButton&nbsp;
          <input id="Radio1" type="radio" runat="server" onserverchange="Common_Onserverchange" />
      </p>  
    </div>

    <div>
      <p> Элемент HTMLTextArea&nbsp;
         <textarea id="TextArea1" cols="20" rows="2"></textarea>
      </p>  
    </div>

    <div>
      <p> Элемент HTMLSelect&nbsp;
          <select id="Select1" runat="server" OnServerChange="Common_Onserverchange" >
              <option></option>

          </select>
      </p>  
    </div>

    

</asp:Content>
