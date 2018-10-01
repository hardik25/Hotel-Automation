<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.Master" AutoEventWireup="true" CodeBehind="staffAdmin.aspx.cs" Inherits="Hotel_Automation_Software.staffAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row">
        <div class="input-field col s6">
          <asp:Label runat="server" ID="lblf"><b>First Name</b></asp:Label>
          <asp:TextBox runat="server" ID="fname"  Cssclass="validate"/>
          <asp:RequiredFieldValidator ID="first" runat="server" ControlToValidate="fname" ErrorMessage="First Name required" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
         </div>

    <div class="row">
        
        <div class="input-field col s6">
        <asp:Label runat="server" ID="lbladv" ><b>Advance Paid</b></asp:Label>
        <asp:TextBox runat="server" ID="adv" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="adv" ErrorMessage="Advance cannot be empty" Display="Dynamic"></asp:RequiredFieldValidator>
     <asp:RangeValidator ID="advvalidate" runat="server" ControlToValidate="adv" MinimumValue="1000" MaximumValue="10000" Display="Dynamic" ErrorMessage="Advance at least 1000" Type="Integer">
         </asp:RangeValidator>
          </div>
        
        </div>

    <div class="row">
        
        <div class="input-field col s6">
        <asp:Label runat="server" ID="lblduration" ><b>Duration of Stay</b></asp:Label>
        <asp:TextBox runat="server" ID="duration" />
    <asp:RangeValidator runat="server" ID="range" Type="Integer" ControlToValidate="duration" Display="Dynamic" MinimumValue="1" MaximumValue="10" ErrorMessage="Minimum stay must be 1 day">
        </asp:RangeValidator>
        </div>
        
        </div>

    <div class="row">
     <asp:Button Cssclass="btn waves-effect waves-light" text="Allot Room" ID="allot_btn" runat="server" OnClick="allot_room"/>
    </div>
    <br/>

    <asp:Label runat="server" ID="lbl"/>
</asp:Content>
