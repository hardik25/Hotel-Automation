<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.Master" AutoEventWireup="true" CodeBehind="catering.aspx.cs" Inherits="Hotel_Automation_Software.catering" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="input-field col s6">
          <asp:Label runat="server" ID="lblf"><b>Customer ID</b></asp:Label>
          <asp:TextBox runat="server" ID="custID"  Cssclass="validate"/>
          
        </div>
         </div>

    <div class="row">
        
        <div class="input-field col s6">
        <asp:Label runat="server" ID="quant" ><b>Type of Food</b></asp:Label>
        <asp:TextBox runat="server" ID="type" />
    
    
    
          </div>
        
        </div>

    <div class="row">
        
        <div class="input-field col s6">
        <asp:Label runat="server" ID="lblduration" ><b>Quantity of Food</b></asp:Label>
        <asp:TextBox runat="server" ID="quantity" />
    
    
        </div>
        
        </div>

    <div class="row">
        
        <div class="input-field col s6">
        <asp:Label runat="server" ID="Label1" ><b>Amount</b></asp:Label>
        <asp:TextBox runat="server" ID="amount" />
    
    
        </div>
        
        </div>

    <div class="row">
     <asp:Button Cssclass="btn waves-effect waves-light" text="Add Bill" ID="allot_btn" runat="server" OnClick="add_bill"/>
    </div>
    <br/>

    <asp:Label runat="server" ID="lbl"/>
</asp:Content>
