<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.Master" AutoEventWireup="true" CodeBehind="selectop.aspx.cs" Inherits="Hotel_Automation_Software.selectop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br/>
    <asp:Button Cssclass="btn waves-effect waves-light" text="Check-Out" ID="chkout_btn" runat="server" OnClick="checkout"/>
    &nbsp;
    &nbsp;
    <asp:Button Cssclass="btn waves-effect waves-light" text="Check-In" ID="chkin_btn" runat="server" OnClick="checkin"/>
    &nbsp;
    &nbsp;
    <asp:Button Cssclass="btn waves-effect waves-light" text="Modify Tariff" ID="modify_btn" runat="server" OnClick="modify"/>
    <br/>
    <br/>
</asp:Content>
