<%@ Page Title="" Language="C#" MasterPageFile="~/Hotel.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="Hotel_Automation_Software.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HotelConnectionString %>" SelectCommand="SELECT * FROM [checkedin]" DeleteCommand="DELETE FROM checkedin where cust_id=@cust_id"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="cust_id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="cust_id" HeaderText="cust_id" ReadOnly="True" SortExpression="cust_id" />
            <asp:BoundField DataField="first_name" HeaderText="first_name" SortExpression="first_name" />
            <asp:BoundField DataField="last_name" HeaderText="last_name" SortExpression="last_name" />
            <asp:BoundField DataField="advance" HeaderText="advance" SortExpression="advance" />
            <asp:BoundField DataField="duration" HeaderText="duration" SortExpression="duration" />
            <asp:BoundField DataField="room_type" HeaderText="room_type" SortExpression="room_type" />
            <asp:BoundField DataField="room_no" HeaderText="room_no" SortExpression="room_no" />
            <asp:BoundField DataField="balance " HeaderText="balance " SortExpression="balance " />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" DeleteText="Checkout"  />
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
    <br/>

    <div class="row">
    
      <div class="row">
        <div class="input-field col s6">
          <asp:Label ID="Frequent_guest" runat="server"><b>Frequent Guest Registration</b></asp:Label>
          <asp:TextBox id="frequent" runat="server" CssClass="validate"/>
          
        </div>
      </div>

         <asp:Button Cssclass="btn waves-effect waves-light" text="Register" ID="login_btn" runat="server" OnClick="register"/>
         <asp:Button Cssclass="btn waves-effect waves-light" text="Print Bill" ID="print_btn" runat="server" OnClick="print"/>
        <br/>
    <asp:Label runat="server" ID="lbl"/>
    </div>
</asp:Content>
