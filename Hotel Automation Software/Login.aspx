<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hotel_Automation_Software.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
     <div class="row">
    
      <div class="row">
        <div class="input-field col s6">
          <asp:Label ID="lbl_username" runat="server">Username</asp:Label>
          <asp:TextBox id="username" runat="server" CssClass="validate"/>
          <asp:RequiredFieldValidator ID="uservalid" ControlToValidate="username" runat="server" ErrorMessage="Username cannot be empty"/>
        </div>
      </div>


    <div class="row">
        <div class="input-field col s6">
          <asp:Label ID="lbl_Passowrd" runat="server">Password</asp:Label>
          <asp:TextBox id="password" type="password" runat="server" CssClass="validate"/>
          <asp:RequiredFieldValidator ID="passvalid" ControlToValidate="password" runat="server" ErrorMessage="Password cannot be empty"/>
        </div>
      </div>
      
     &nbsp;&nbsp;

      
      
     <asp:CheckBoxList runat="server" ID="admin" OnSelectedIndexChanged="selection">
         <asp:ListItem Text="Admin" Value="admin"></asp:ListItem>
         <asp:ListItem Text="Customer" Value="customer"></asp:ListItem>
         <asp:ListItem Text="Catering Staff" Value="catering"></asp:ListItem>
     </asp:CheckBoxList>
         <br/>
         <br/>
    <asp:Label runat="server" ID="lbl"/>  
         &nbsp;
     <asp:Button Cssclass="btn waves-effect waves-light" text="Submit" ID="login_btn" runat="server" OnClick="submit_login"/>
     
      
    
  </div>
</asp:Content>
